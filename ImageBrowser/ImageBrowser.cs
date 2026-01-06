using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageBrowser
{
    public partial class ImageBrowser : Form
    {
        public ImageBrowser(string[] args)
        {
            InitializeComponent();

            _imageLabelText = imageLabel.Text;
            _dimensionsLabelText = dimensionsLabel.Text;
            _sizeLabelText = sizeLabel.Text;
            _filePathValueText = filePathValue.Text;
            _dateCreatedValueText = dateCreatedValue.Text;
            _dateModifiedValueText = dateModifiedValue.Text;
            _dateAccessedValueText = dateAccessedValue.Text;
            _dpiValueText = dpiValue.Text;
            _formatValueText = formatValue.Text;

            _infoPanelVisible = false;
            middleRow.ColumnStyles[1].Width = 0F;
            middleRow.PerformLayout();

            _copyButtonText = copyButton.Text;
            _copyResetTimer = new Timer
            {
                Interval = 1000 // 1 second
            };
            _copyResetTimer.Tick += (s, e) =>
            {
                _copyResetTimer.Stop();
                copyButton.Text = _copyButtonText;
            };

            zoomBox.SelectedIndex = 9;
            zoomBar.Value = 9;

            // arg handling
            if (args != null && args.Length > 0)
            {
                var path = args[0];

                if (File.Exists(path))
                {
                    try
                    {
                        LoadImageFromDisk(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Failed to load image:\n{ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        // default label values
        private readonly string _imageLabelText;
        private readonly string _dimensionsLabelText;
        private readonly string _sizeLabelText;
        private readonly string _filePathValueText;
        private readonly string _dateCreatedValueText;
        private readonly string _dateModifiedValueText;
        private readonly string _dateAccessedValueText;
        private readonly string _dpiValueText;
        private readonly string _formatValueText;

        private string _currentFolder;
        private readonly List<string> _imagesInCurrentFolder = new List<string>();
        private int _currentFolderIndex;
        private Image _originalImage;
        private long _originalImageLength;

        // rotation/flip data
        private int _rotation = 0; // 0, 90, 180, 270
        private bool _flipX = false;
        private bool _flipY = false;

        private int _zoom = 100;
        private float _zoomScale = 1.0F;

        private readonly string _copyButtonText;
        private readonly Timer _copyResetTimer;

        private bool _infoPanelVisible;

        private void UpdateOriginalImage()
        {
            string path = _imagesInCurrentFolder[_currentFolderIndex];
            if (!File.Exists(path)) return;

            _originalImage?.Dispose();
            _originalImage = Image.FromFile(path);
            _originalImageLength = new FileInfo(path).Length;
        }

        private void SetCurrentImageIndex(int value)
        {
            if (_imagesInCurrentFolder.Count == 0
                || value > _imagesInCurrentFolder.Count - 1) return;

            _currentFolderIndex = value;

            UpdateOriginalImage();

            UpdateImageAndLabels();
        }

        private void ModifyCurrentImageIndex(int amount)
        {
            int count = _imagesInCurrentFolder.Count;
            if (count == 0) return;

            SetCurrentImageIndex((_currentFolderIndex + amount + count) % count);
        }

        private void RegenerateImagesList()
        {
            _imagesInCurrentFolder.Clear();
            foreach (string file in Directory.EnumerateFiles(_currentFolder))
            {
                // if file is image, read from file
                if (ImageUtils.IsImageFile(file) && ImageUtils.IsValidImageByHeader(file))
                {
                    _imagesInCurrentFolder.Add(file);
                }
            }
        }

        private void UpdateImageAndLabels()
        {
            RegenerateImagesList();

            // todo: check if this works
            if (_imagesInCurrentFolder.Count == 0)
            {
                imageLabel.Text = _imageLabelText;
                dimensionsLabel.Text = _dimensionsLabelText;
                sizeLabel.Text = _sizeLabelText;
                filePathValue.Text = _filePathValueText;
                dateCreatedValue.Text = _dateCreatedValueText;
                dateModifiedValue.Text = _dateModifiedValueText;
                dateAccessedValue.Text = _dateAccessedValueText;
                dpiValue.Text = _dpiValueText;
                formatValue.Text = _formatValueText;

                return;
            }

            pictureBox.Image?.Dispose();
            pictureBox.Image = (Image)_originalImage.Clone();

            string imagePath = _imagesInCurrentFolder[_currentFolderIndex];
            string fileName = Path.GetFileName(imagePath);

            TitleUtils.SetTruncatedImageLabel(imageLabel, fileName, _currentFolderIndex, _imagesInCurrentFolder.Count);
            dimensionsLabel.Text = $"{_originalImage.PhysicalDimension.Width} x {_originalImage.PhysicalDimension.Width}";
            sizeLabel.Text = SizeUtils.GetBytesString(_originalImageLength);

            filePathValue.Text = imagePath;

            FileInfo fileInfo = new FileInfo(imagePath);
            dateCreatedValue.Text = $"Created: {fileInfo.CreationTime}";
            dateModifiedValue.Text = $"Modified: {fileInfo.LastWriteTime}";
            dateAccessedValue.Text = $"Accessed: {fileInfo.LastAccessTime}";

            string dpiString = pictureBox.Image.HorizontalResolution == pictureBox.Image.VerticalResolution
                ? $"{pictureBox.Image.HorizontalResolution}dpi"
                : $"{pictureBox.Image.HorizontalResolution}hdpi x {pictureBox.Image.VerticalResolution}vdpi";
            dpiValue.Text = $"DPI: {dpiString}";    
            formatValue.Text = $"Format: {pictureBox.Image.PixelFormat}";
        }

        private void ApplyCurrentTransform()
        {
            if (_originalImage == null) return;

            pictureBox.Image?.Dispose();

            Image transformed = (Image)_originalImage.Clone();
            transformed.RotateFlip(ImageUtils.GetRotateFlipType(_rotation, _flipX, _flipY));

            pictureBox.Image = transformed;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (_imagesInCurrentFolder.Count != 0)
            {
                switch (keyData)
                {
                    case Keys.Left:
                        previousButton_Click(previousButton, EventArgs.Empty);
                        return true; // mark as handled
                    case Keys.Right:
                        nextButton_Click(nextButton, EventArgs.Empty);
                        return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UpdateZoom()
        {
            string zoomString = zoomBox.Items[zoomBar.Value].ToString();
            int zoom = -1;
            int.TryParse(zoomString.Substring(0, zoomString.Length - 1), out zoom);
            if (zoom != -1)
            {
                _zoom = zoom;
                _zoomScale = zoom / 100.0F;
            }

            zoomBox.Text = $"{_zoom}%";

            pictureBox.Size = new Size(
                Math.Max(1, (int)Math.Round(pictureBoxPanel.Width * _zoomScale)),
                Math.Max(1, (int)Math.Round(pictureBoxPanel.Height * _zoomScale))
            );

            int x = 0;
            int y = 0;

            // If the image is smaller than the panel, center it
            if (pictureBox.Width < pictureBoxPanel.ClientSize.Width)
            {
                x = (pictureBoxPanel.ClientSize.Width - pictureBox.Width) / 2;
            }

            if (pictureBox.Height < pictureBoxPanel.ClientSize.Height)
            {
                y = (pictureBoxPanel.ClientSize.Height - pictureBox.Height) / 2;
            }

            // If the image is larger, x/y will stay 0 and the scrollbars take over
            pictureBox.Location = new Point(x, y);
        }

        private void LoadImageFromDisk(string path)
        {
            _currentFolder = Path.GetDirectoryName(path);
            RegenerateImagesList();
            SetCurrentImageIndex(_imagesInCurrentFolder.IndexOf(path));
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _rotation = (_rotation + 90) % 360;

            ApplyCurrentTransform();
        }

        private void flipXButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _flipX = !_flipX;

            ApplyCurrentTransform();
        }

        private void flipYButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _flipY = !_flipY;

            ApplyCurrentTransform();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _rotation = 0;
            _flipX = false;
            _flipY = false;

            ApplyCurrentTransform();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_imagesInCurrentFolder.Count == 0) return;

            // get current image path
            string imagePath = _imagesInCurrentFolder[_currentFolderIndex];

            // free up resources used by current image
            pictureBox.Image.Dispose(); pictureBox.Image = null;
            _originalImage?.Dispose(); _originalImage = null;
            // delete current image
            RecycleBinHelper.SendToRecycleBin(imagePath, showUI: true);
            // regenerate list of images in current folder
            RegenerateImagesList();

            if (_imagesInCurrentFolder.Count > 0)
            {
                // current folder index bounds check
                _currentFolderIndex = MathUtils.Clamp(_currentFolderIndex, 0, _imagesInCurrentFolder.Count - 1);

                SetCurrentImageIndex(_currentFolderIndex);
            }
            else
            {
                // revert to default names/no image if no images will be left afterwards
                _currentFolderIndex = 0;

                imageLabel.Text = _imageLabelText;
                dimensionsLabel.Text = _dimensionsLabelText;
                sizeLabel.Text = _sizeLabelText;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            Clipboard.SetImage(_originalImage);
            copyButton.Text = "Copied!";

            // 1 second later: reset button text
            _copyResetTimer.Stop(); // in case it's already running
            _copyResetTimer.Start();
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadImageFromDisk(openFileDialog1.FileName);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            _infoPanelVisible = !_infoPanelVisible;

            middleRow.ColumnStyles[1].Width = _infoPanelVisible ? 250F : 0F;

            middleRow.PerformLayout();

            UpdateZoom();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            ModifyCurrentImageIndex(-1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ModifyCurrentImageIndex(1);
        }

        private void explorerButton_Click(object sender, EventArgs e)
        {
            string folderPath = _currentFolder;
            if (folderPath == null || folderPath.Length == 0)
            {
                MessageBox.Show($"No folder/image selected!");
                return;
            }
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show($"Folder {folderPath} does not exist");
                return;
            }

            string imagePath = _imagesInCurrentFolder[_currentFolderIndex];
            if (File.Exists(imagePath))
            {
                Process.Start("explorer.exe", $"/select,\"{imagePath}\"");
            }
            else
            {
                Process.Start("explorer.exe", folderPath);
            }
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            zoomBar.Value = Math.Min(zoomBar.Value + 1, zoomBar.Maximum);

            UpdateZoom();
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            zoomBar.Value = Math.Max(zoomBar.Value - 1, zoomBar.Minimum);

            UpdateZoom();
        }

        private void zoomBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoomBar.Value = zoomBox.SelectedIndex;

            UpdateZoom();
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            zoomBox.SelectedIndex = zoomBar.Value;

            UpdateZoom();
        }

        private void ImageBrowser_Resize(object sender, EventArgs e)
        {
            if (_imagesInCurrentFolder.Count != 0)
            {
                string imagePath = _imagesInCurrentFolder[_currentFolderIndex];
                string fileName = Path.GetFileName(imagePath);

                TitleUtils.SetTruncatedImageLabel(imageLabel, fileName, _currentFolderIndex, _imagesInCurrentFolder.Count);
            }

            UpdateZoom();
        }
    }
}
