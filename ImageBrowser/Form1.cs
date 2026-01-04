using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageBrowser
{
    public partial class ImageBrowser : Form
    {
        public ImageBrowser()
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
        private List<string> _imagesInCurrentFolder = new List<string>();
        private int _currentFolderIndex;
        private Image _originalImage;
        private long _originalImageLength;
        private RotateFlipType _currentRotateFlip = RotateFlipType.RotateNoneFlipNone;

        private bool _infoPanelVisible;

        private static readonly string[] ImageExtensions = new[]
        {
            ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".tif", ".tiff"
        };

        private static readonly string[] SizeExtensions = new[]
        {
            "B", "KB", "MB", "GB", "TB"
        };

        private static bool IsImageFile(string path)
        {
            var ext = Path.GetExtension(path);
            if (string.IsNullOrEmpty(ext))
                return false;

            return ImageExtensions.Contains(ext.ToLowerInvariant());
        }

        private static bool IsValidImageByHeader(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (var img = Image.FromStream(fs, useEmbeddedColorManagement: false, validateImageData: false))
                    {
                        // If this succeeds, it's at least structurally a valid image
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void UpdateOriginalImage()
        {
            string path = _imagesInCurrentFolder[_currentFolderIndex];
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} does not exist on disk - cannot regenerate image");
                return;
            }

            _originalImage?.Dispose();
            _originalImage = Image.FromFile(path);
            _originalImageLength = new FileInfo(path).Length;
            _currentRotateFlip = RotateFlipType.RotateNoneFlipNone;
        }

        private void SetCurrentImageIndex(int value)
        {
            if (_imagesInCurrentFolder.Count == 0)
            {
                Console.WriteLine("Cannot set current image index - images in current folder list is empty");
                return;
            }
            if (value > _imagesInCurrentFolder.Count - 1)
            {
                Console.WriteLine($"Cannot set current image index - {nameof(value)} {value} is greater than {nameof(_imagesInCurrentFolder.Count)} {_imagesInCurrentFolder.Count}");
                return;
            }

            _currentFolderIndex = value;

            UpdateOriginalImage();

            UpdateImageAndLabels();
        }

        private void ModifyCurrentImageIndex(int amount)
        {
            int count = _imagesInCurrentFolder.Count;
            if (count == 0)
            {
                Console.WriteLine($"{nameof(_imagesInCurrentFolder.Count)} is 0 - cannot perform modulo operation in {nameof(ModifyCurrentImageIndex)}");
                return;
            }
            SetCurrentImageIndex((_currentFolderIndex + amount + count) % count);
        }

        private void RegenerateImagesList()
        {
            _imagesInCurrentFolder.Clear();
            foreach (string file in Directory.EnumerateFiles(_currentFolder))
            {
                // if file is image, read from file
                if (IsImageFile(file) && IsValidImageByHeader(file))
                {
                    _imagesInCurrentFolder.Add(file);
                }
            }
        }

        private string DecimalPlaces(string numString, int decimalPlaces)
        {
            int decimalIndex = numString.IndexOf('.');
            if (decimalIndex == -1) return numString;

            return numString.Substring(0, decimalIndex + decimalPlaces + 1);
        }

        private string GetBytesString(long bytes)
        {
            double size = bytes;
            int sizeIndex = 0;
            while (size > 1024 && sizeIndex < SizeExtensions.Length - 1)
            {
                size /= 1024;
                sizeIndex++;
            }

            return $"{DecimalPlaces(size.ToString(), 1)} {SizeExtensions[sizeIndex]}";
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

            imageLabel.Text = $"{fileName} ({_currentFolderIndex + 1} of {_imagesInCurrentFolder.Count})";
            dimensionsLabel.Text = $"{_originalImage.PhysicalDimension.Width} x {_originalImage.PhysicalDimension.Width}";
            sizeLabel.Text = GetBytesString(_originalImageLength);

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
            transformed.RotateFlip(_currentRotateFlip);

            pictureBox.Image = transformed;
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            switch (_currentRotateFlip)
            {
                case RotateFlipType.RotateNoneFlipNone:
                    _currentRotateFlip = RotateFlipType.Rotate90FlipNone;
                    break;
                case RotateFlipType.Rotate90FlipNone:
                    _currentRotateFlip = RotateFlipType.Rotate180FlipNone;
                    break;
                case RotateFlipType.Rotate180FlipNone:
                    _currentRotateFlip = RotateFlipType.Rotate270FlipNone;
                    break;
                case RotateFlipType.Rotate270FlipNone:
                    _currentRotateFlip = RotateFlipType.RotateNoneFlipNone;
                    break;

                case RotateFlipType.RotateNoneFlipX:
                    _currentRotateFlip = RotateFlipType.RotateNoneFlipX;
                    break;
                case RotateFlipType.Rotate90FlipX:
                    _currentRotateFlip = RotateFlipType.Rotate90FlipX;
                    break;
                case RotateFlipType.Rotate180FlipX:
                    _currentRotateFlip = RotateFlipType.Rotate180FlipX;
                    break;
                case RotateFlipType.Rotate270FlipX:
                    _currentRotateFlip = RotateFlipType.Rotate270FlipX;
                    break;
            }

            ApplyCurrentTransform();
        }

        private void flipXButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            switch (_currentRotateFlip)
            {
                case RotateFlipType.RotateNoneFlipNone:
                    _currentRotateFlip = RotateFlipType.RotateNoneFlipX;
                    break;
                case RotateFlipType.Rotate90FlipNone:
                    _currentRotateFlip = RotateFlipType.Rotate90FlipX;
                    break;
                case RotateFlipType.Rotate180FlipNone:
                    _currentRotateFlip = RotateFlipType.Rotate180FlipX;
                    break;
                case RotateFlipType.Rotate270FlipNone:
                    _currentRotateFlip = RotateFlipType.Rotate270FlipX;
                    break;

                case RotateFlipType.RotateNoneFlipX:
                    _currentRotateFlip = RotateFlipType.RotateNoneFlipNone;
                    break;
                case RotateFlipType.Rotate90FlipX:
                    _currentRotateFlip = RotateFlipType.Rotate90FlipNone;
                    break;
                case RotateFlipType.Rotate180FlipX:
                    _currentRotateFlip = RotateFlipType.Rotate180FlipNone;
                    break;
                case RotateFlipType.Rotate270FlipX:
                    _currentRotateFlip = RotateFlipType.Rotate270FlipNone;
                    break;
            }

            ApplyCurrentTransform();
        }

        private void flipYButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            switch (_currentRotateFlip)
            {
                case RotateFlipType.RotateNoneFlipNone:
                    _currentRotateFlip = RotateFlipType.RotateNoneFlipY;
                    break;
                case RotateFlipType.Rotate90FlipNone:
                    _currentRotateFlip = RotateFlipType.Rotate90FlipY;
                    break;
                case RotateFlipType.Rotate180FlipNone:
                    _currentRotateFlip = RotateFlipType.Rotate180FlipY;
                    break;
                case RotateFlipType.Rotate270FlipNone:
                    _currentRotateFlip = RotateFlipType.Rotate270FlipY;
                    break;

                case RotateFlipType.RotateNoneFlipY:
                    _currentRotateFlip = RotateFlipType.RotateNoneFlipNone;
                    break;
                case RotateFlipType.Rotate90FlipY:
                    _currentRotateFlip = RotateFlipType.Rotate90FlipNone;
                    break;
                case RotateFlipType.Rotate180FlipY:
                    _currentRotateFlip = RotateFlipType.Rotate180FlipNone;
                    break;
                case RotateFlipType.Rotate270FlipY:
                    _currentRotateFlip = RotateFlipType.Rotate270FlipNone;
                    break;
            }

            ApplyCurrentTransform();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            _currentRotateFlip = RotateFlipType.RotateNoneFlipNone;

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

            // revert to default names/no image if no images will be left afterwards
            if (_imagesInCurrentFolder.Count == 1)
            {
                _currentFolderIndex = 0;

                imageLabel.Text = _imageLabelText;
                dimensionsLabel.Text = _dimensionsLabelText;
                sizeLabel.Text = _sizeLabelText;
            }
            else
            {
                // ensure _currentFolderIndex is not out of bounds
                if (_currentFolderIndex < 0) _currentFolderIndex = 0;
                if (_currentFolderIndex > _imagesInCurrentFolder.Count - 1) _currentFolderIndex = _imagesInCurrentFolder.Count - 1;

                SetCurrentImageIndex(_currentFolderIndex);
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentFolder = folderBrowserDialog1.SelectedPath;

                RegenerateImagesList();

                SetCurrentImageIndex(0);
            }
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentFolder = Path.GetDirectoryName(openFileDialog1.FileName);

                RegenerateImagesList();

                SetCurrentImageIndex(_imagesInCurrentFolder.IndexOf(openFileDialog1.FileName));
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            _infoPanelVisible = !_infoPanelVisible;

            middleRow.ColumnStyles[1].Width = _infoPanelVisible ? 250F : 0F;

            middleRow.PerformLayout();
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
    }
}
