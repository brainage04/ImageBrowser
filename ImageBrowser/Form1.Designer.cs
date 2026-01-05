namespace ImageBrowser
{
    partial class ImageBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rowContainer = new System.Windows.Forms.TableLayoutPanel();
            this.topRow = new System.Windows.Forms.TableLayoutPanel();
            this.topLeftTable = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.flipYButton = new System.Windows.Forms.Button();
            this.flipXButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.imageLabel = new System.Windows.Forms.Label();
            this.topRightTable = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pictureButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.middleRow = new System.Windows.Forms.TableLayoutPanel();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.advancedInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.formatValue = new System.Windows.Forms.Label();
            this.dpiValue = new System.Windows.Forms.Label();
            this.advancedInfoLabel = new System.Windows.Forms.Label();
            this.filePathTable = new System.Windows.Forms.TableLayoutPanel();
            this.filePathValue = new System.Windows.Forms.Label();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.dateTable = new System.Windows.Forms.TableLayoutPanel();
            this.dateAccessedValue = new System.Windows.Forms.Label();
            this.dateModifiedValue = new System.Windows.Forms.Label();
            this.dateCreatedValue = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bottomRow = new System.Windows.Forms.TableLayoutPanel();
            this.bottomLeftTable = new System.Windows.Forms.TableLayoutPanel();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.explorerButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.bottomRightTable = new System.Windows.Forms.TableLayoutPanel();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomBox = new System.Windows.Forms.ComboBox();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.rowContainer.SuspendLayout();
            this.topRow.SuspendLayout();
            this.topLeftTable.SuspendLayout();
            this.topRightTable.SuspendLayout();
            this.middleRow.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.advancedInfoTable.SuspendLayout();
            this.filePathTable.SuspendLayout();
            this.dateTable.SuspendLayout();
            this.pictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.bottomRow.SuspendLayout();
            this.bottomLeftTable.SuspendLayout();
            this.bottomTable.SuspendLayout();
            this.bottomRightTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // rowContainer
            // 
            this.rowContainer.ColumnCount = 1;
            this.rowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rowContainer.Controls.Add(this.topRow, 0, 0);
            this.rowContainer.Controls.Add(this.middleRow, 0, 1);
            this.rowContainer.Controls.Add(this.bottomRow, 0, 2);
            this.rowContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowContainer.Location = new System.Drawing.Point(3, 3);
            this.rowContainer.Margin = new System.Windows.Forms.Padding(0);
            this.rowContainer.Name = "rowContainer";
            this.rowContainer.RowCount = 3;
            this.rowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rowContainer.Size = new System.Drawing.Size(936, 487);
            this.rowContainer.TabIndex = 10;
            // 
            // topRow
            // 
            this.topRow.ColumnCount = 3;
            this.topRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.topRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.topRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.topRow.Controls.Add(this.topLeftTable, 0, 0);
            this.topRow.Controls.Add(this.imageLabel, 1, 0);
            this.topRow.Controls.Add(this.topRightTable, 2, 0);
            this.topRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRow.Location = new System.Drawing.Point(0, 0);
            this.topRow.Margin = new System.Windows.Forms.Padding(0);
            this.topRow.Name = "topRow";
            this.topRow.RowCount = 1;
            this.topRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topRow.Size = new System.Drawing.Size(936, 50);
            this.topRow.TabIndex = 0;
            // 
            // topLeftTable
            // 
            this.topLeftTable.ColumnCount = 4;
            this.topLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topLeftTable.Controls.Add(this.resetButton, 3, 0);
            this.topLeftTable.Controls.Add(this.flipYButton, 2, 0);
            this.topLeftTable.Controls.Add(this.flipXButton, 1, 0);
            this.topLeftTable.Controls.Add(this.rotateButton, 0, 0);
            this.topLeftTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLeftTable.Location = new System.Drawing.Point(0, 0);
            this.topLeftTable.Margin = new System.Windows.Forms.Padding(0);
            this.topLeftTable.Name = "topLeftTable";
            this.topLeftTable.RowCount = 1;
            this.topLeftTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLeftTable.Size = new System.Drawing.Size(327, 50);
            this.topLeftTable.TabIndex = 8;
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(246, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(78, 44);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // flipYButton
            // 
            this.flipYButton.AutoSize = true;
            this.flipYButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipYButton.Location = new System.Drawing.Point(165, 3);
            this.flipYButton.Name = "flipYButton";
            this.flipYButton.Size = new System.Drawing.Size(75, 44);
            this.flipYButton.TabIndex = 8;
            this.flipYButton.Text = "Flip (Y)";
            this.flipYButton.UseVisualStyleBackColor = true;
            this.flipYButton.Click += new System.EventHandler(this.flipYButton_Click);
            // 
            // flipXButton
            // 
            this.flipXButton.AutoSize = true;
            this.flipXButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipXButton.Location = new System.Drawing.Point(84, 3);
            this.flipXButton.Name = "flipXButton";
            this.flipXButton.Size = new System.Drawing.Size(75, 44);
            this.flipXButton.TabIndex = 7;
            this.flipXButton.Text = "Flip (X)";
            this.flipXButton.UseVisualStyleBackColor = true;
            this.flipXButton.Click += new System.EventHandler(this.flipXButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.AutoSize = true;
            this.rotateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateButton.Location = new System.Drawing.Point(3, 3);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(75, 44);
            this.rotateButton.TabIndex = 6;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.imageLabel.Location = new System.Drawing.Point(330, 3);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(3);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(274, 44);
            this.imageLabel.TabIndex = 6;
            this.imageLabel.Text = "image.png (0 of 0)";
            this.imageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topRightTable
            // 
            this.topRightTable.ColumnCount = 3;
            this.topRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.topRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.topRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.topRightTable.Controls.Add(this.deleteButton, 0, 0);
            this.topRightTable.Controls.Add(this.pictureButton, 2, 0);
            this.topRightTable.Controls.Add(this.copyButton, 1, 0);
            this.topRightTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRightTable.Location = new System.Drawing.Point(607, 0);
            this.topRightTable.Margin = new System.Windows.Forms.Padding(0);
            this.topRightTable.Name = "topRightTable";
            this.topRightTable.RowCount = 1;
            this.topRightTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topRightTable.Size = new System.Drawing.Size(329, 50);
            this.topRightTable.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(3, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 44);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.AutoSize = true;
            this.pictureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureButton.Location = new System.Drawing.Point(221, 3);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(105, 44);
            this.pictureButton.TabIndex = 6;
            this.pictureButton.Text = "Open Picture";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.AutoSize = true;
            this.copyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyButton.Location = new System.Drawing.Point(112, 3);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(103, 44);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // middleRow
            // 
            this.middleRow.ColumnCount = 2;
            this.middleRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.middleRow.Controls.Add(this.infoPanel, 1, 0);
            this.middleRow.Controls.Add(this.pictureBoxPanel, 0, 0);
            this.middleRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleRow.Location = new System.Drawing.Point(0, 50);
            this.middleRow.Margin = new System.Windows.Forms.Padding(0);
            this.middleRow.Name = "middleRow";
            this.middleRow.RowCount = 1;
            this.middleRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.middleRow.Size = new System.Drawing.Size(936, 387);
            this.middleRow.TabIndex = 1;
            // 
            // infoPanel
            // 
            this.infoPanel.ColumnCount = 1;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoPanel.Controls.Add(this.advancedInfoTable, 0, 3);
            this.infoPanel.Controls.Add(this.filePathTable, 0, 1);
            this.infoPanel.Controls.Add(this.dateTable, 0, 2);
            this.infoPanel.Controls.Add(this.infoLabel, 0, 0);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(686, 0);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.RowCount = 5;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoPanel.Size = new System.Drawing.Size(250, 387);
            this.infoPanel.TabIndex = 2;
            // 
            // advancedInfoTable
            // 
            this.advancedInfoTable.AutoSize = true;
            this.advancedInfoTable.ColumnCount = 1;
            this.advancedInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.advancedInfoTable.Controls.Add(this.formatValue, 0, 2);
            this.advancedInfoTable.Controls.Add(this.dpiValue, 0, 1);
            this.advancedInfoTable.Controls.Add(this.advancedInfoLabel, 0, 0);
            this.advancedInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedInfoTable.Location = new System.Drawing.Point(0, 164);
            this.advancedInfoTable.Margin = new System.Windows.Forms.Padding(0);
            this.advancedInfoTable.Name = "advancedInfoTable";
            this.advancedInfoTable.RowCount = 3;
            this.advancedInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.advancedInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.advancedInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.advancedInfoTable.Size = new System.Drawing.Size(250, 57);
            this.advancedInfoTable.TabIndex = 13;
            // 
            // formatValue
            // 
            this.formatValue.AutoSize = true;
            this.formatValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatValue.Location = new System.Drawing.Point(0, 41);
            this.formatValue.Margin = new System.Windows.Forms.Padding(0);
            this.formatValue.Name = "formatValue";
            this.formatValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.formatValue.Size = new System.Drawing.Size(250, 16);
            this.formatValue.TabIndex = 3;
            this.formatValue.Text = "Format: Unknown";
            this.formatValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpiValue
            // 
            this.dpiValue.AutoSize = true;
            this.dpiValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpiValue.Location = new System.Drawing.Point(0, 25);
            this.dpiValue.Margin = new System.Windows.Forms.Padding(0);
            this.dpiValue.Name = "dpiValue";
            this.dpiValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dpiValue.Size = new System.Drawing.Size(250, 16);
            this.dpiValue.TabIndex = 2;
            this.dpiValue.Text = "DPI: 0dpi";
            this.dpiValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // advancedInfoLabel
            // 
            this.advancedInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.advancedInfoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.advancedInfoLabel.Name = "advancedInfoLabel";
            this.advancedInfoLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.advancedInfoLabel.Size = new System.Drawing.Size(250, 25);
            this.advancedInfoLabel.TabIndex = 1;
            this.advancedInfoLabel.Text = "Advanced Info";
            this.advancedInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filePathTable
            // 
            this.filePathTable.AutoSize = true;
            this.filePathTable.ColumnCount = 1;
            this.filePathTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filePathTable.Controls.Add(this.filePathValue, 0, 1);
            this.filePathTable.Controls.Add(this.filePathLabel, 0, 0);
            this.filePathTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePathTable.Location = new System.Drawing.Point(0, 50);
            this.filePathTable.Margin = new System.Windows.Forms.Padding(0);
            this.filePathTable.Name = "filePathTable";
            this.filePathTable.RowCount = 2;
            this.filePathTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.filePathTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.filePathTable.Size = new System.Drawing.Size(250, 41);
            this.filePathTable.TabIndex = 11;
            // 
            // filePathValue
            // 
            this.filePathValue.AutoSize = true;
            this.filePathValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePathValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathValue.Location = new System.Drawing.Point(0, 25);
            this.filePathValue.Margin = new System.Windows.Forms.Padding(0);
            this.filePathValue.Name = "filePathValue";
            this.filePathValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.filePathValue.Size = new System.Drawing.Size(250, 16);
            this.filePathValue.TabIndex = 2;
            this.filePathValue.Text = "C:\\image.png";
            this.filePathValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filePathLabel
            // 
            this.filePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathLabel.Location = new System.Drawing.Point(0, 0);
            this.filePathLabel.Margin = new System.Windows.Forms.Padding(0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.filePathLabel.Size = new System.Drawing.Size(250, 25);
            this.filePathLabel.TabIndex = 1;
            this.filePathLabel.Text = "File Path";
            this.filePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTable
            // 
            this.dateTable.AutoSize = true;
            this.dateTable.ColumnCount = 1;
            this.dateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dateTable.Controls.Add(this.dateAccessedValue, 0, 3);
            this.dateTable.Controls.Add(this.dateModifiedValue, 0, 2);
            this.dateTable.Controls.Add(this.dateCreatedValue, 0, 1);
            this.dateTable.Controls.Add(this.dateLabel, 0, 0);
            this.dateTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTable.Location = new System.Drawing.Point(0, 91);
            this.dateTable.Margin = new System.Windows.Forms.Padding(0);
            this.dateTable.Name = "dateTable";
            this.dateTable.RowCount = 4;
            this.dateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.dateTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dateTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dateTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dateTable.Size = new System.Drawing.Size(250, 73);
            this.dateTable.TabIndex = 8;
            // 
            // dateAccessedValue
            // 
            this.dateAccessedValue.AutoSize = true;
            this.dateAccessedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateAccessedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAccessedValue.Location = new System.Drawing.Point(0, 57);
            this.dateAccessedValue.Margin = new System.Windows.Forms.Padding(0);
            this.dateAccessedValue.Name = "dateAccessedValue";
            this.dateAccessedValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dateAccessedValue.Size = new System.Drawing.Size(250, 16);
            this.dateAccessedValue.TabIndex = 4;
            this.dateAccessedValue.Text = "Accessed: 01/01/01 12:01am";
            this.dateAccessedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateModifiedValue
            // 
            this.dateModifiedValue.AutoSize = true;
            this.dateModifiedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateModifiedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateModifiedValue.Location = new System.Drawing.Point(0, 41);
            this.dateModifiedValue.Margin = new System.Windows.Forms.Padding(0);
            this.dateModifiedValue.Name = "dateModifiedValue";
            this.dateModifiedValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dateModifiedValue.Size = new System.Drawing.Size(250, 16);
            this.dateModifiedValue.TabIndex = 3;
            this.dateModifiedValue.Text = "Modified: 01/01/01 12:01am";
            this.dateModifiedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateCreatedValue
            // 
            this.dateCreatedValue.AutoSize = true;
            this.dateCreatedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateCreatedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedValue.Location = new System.Drawing.Point(0, 25);
            this.dateCreatedValue.Margin = new System.Windows.Forms.Padding(0);
            this.dateCreatedValue.Name = "dateCreatedValue";
            this.dateCreatedValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dateCreatedValue.Size = new System.Drawing.Size(250, 16);
            this.dateCreatedValue.TabIndex = 2;
            this.dateCreatedValue.Text = "Created: 01/01/01 12:01am";
            this.dateCreatedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(0, 0);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dateLabel.Size = new System.Drawing.Size(250, 25);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.infoLabel.Size = new System.Drawing.Size(250, 50);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Info/Metadata";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.AutoScroll = true;
            this.pictureBoxPanel.Controls.Add(this.pictureBox);
            this.pictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPanel.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(680, 381);
            this.pictureBoxPanel.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(680, 381);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // bottomRow
            // 
            this.bottomRow.ColumnCount = 3;
            this.bottomRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bottomRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bottomRow.Controls.Add(this.bottomLeftTable, 0, 0);
            this.bottomRow.Controls.Add(this.bottomTable, 1, 0);
            this.bottomRow.Controls.Add(this.bottomRightTable, 2, 0);
            this.bottomRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRow.Location = new System.Drawing.Point(0, 437);
            this.bottomRow.Margin = new System.Windows.Forms.Padding(0);
            this.bottomRow.Name = "bottomRow";
            this.bottomRow.RowCount = 1;
            this.bottomRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomRow.Size = new System.Drawing.Size(936, 50);
            this.bottomRow.TabIndex = 2;
            // 
            // bottomLeftTable
            // 
            this.bottomLeftTable.ColumnCount = 4;
            this.bottomLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.bottomLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.bottomLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomLeftTable.Controls.Add(this.dimensionsLabel, 3, 0);
            this.bottomLeftTable.Controls.Add(this.explorerButton, 1, 0);
            this.bottomLeftTable.Controls.Add(this.sizeLabel, 2, 0);
            this.bottomLeftTable.Controls.Add(this.infoButton, 0, 0);
            this.bottomLeftTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeftTable.Location = new System.Drawing.Point(0, 0);
            this.bottomLeftTable.Margin = new System.Windows.Forms.Padding(0);
            this.bottomLeftTable.Name = "bottomLeftTable";
            this.bottomLeftTable.RowCount = 1;
            this.bottomLeftTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomLeftTable.Size = new System.Drawing.Size(374, 50);
            this.bottomLeftTable.TabIndex = 11;
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimensionsLabel.Location = new System.Drawing.Point(298, 0);
            this.dimensionsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(76, 50);
            this.dimensionsLabel.TabIndex = 14;
            this.dimensionsLabel.Text = "0 x 0";
            this.dimensionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // explorerButton
            // 
            this.explorerButton.AutoSize = true;
            this.explorerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerButton.Location = new System.Drawing.Point(115, 3);
            this.explorerButton.Name = "explorerButton";
            this.explorerButton.Size = new System.Drawing.Size(106, 44);
            this.explorerButton.TabIndex = 13;
            this.explorerButton.Text = "Open Folder";
            this.explorerButton.UseVisualStyleBackColor = true;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeLabel.Location = new System.Drawing.Point(224, 0);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(74, 50);
            this.sizeLabel.TabIndex = 12;
            this.sizeLabel.Text = "0 B";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoButton
            // 
            this.infoButton.AutoSize = true;
            this.infoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoButton.Location = new System.Drawing.Point(3, 3);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(106, 44);
            this.infoButton.TabIndex = 9;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // bottomTable
            // 
            this.bottomTable.ColumnCount = 2;
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTable.Controls.Add(this.previousButton, 0, 0);
            this.bottomTable.Controls.Add(this.nextButton, 1, 0);
            this.bottomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTable.Location = new System.Drawing.Point(374, 0);
            this.bottomTable.Margin = new System.Windows.Forms.Padding(0);
            this.bottomTable.Name = "bottomTable";
            this.bottomTable.RowCount = 1;
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTable.Size = new System.Drawing.Size(187, 50);
            this.bottomTable.TabIndex = 10;
            // 
            // previousButton
            // 
            this.previousButton.AutoSize = true;
            this.previousButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousButton.Location = new System.Drawing.Point(3, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(87, 44);
            this.previousButton.TabIndex = 13;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButton.Location = new System.Drawing.Point(96, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(88, 44);
            this.nextButton.TabIndex = 14;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // bottomRightTable
            // 
            this.bottomRightTable.ColumnCount = 4;
            this.bottomRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bottomRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.bottomRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.bottomRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.bottomRightTable.Controls.Add(this.zoomInButton, 3, 0);
            this.bottomRightTable.Controls.Add(this.zoomOutButton, 1, 0);
            this.bottomRightTable.Controls.Add(this.zoomBox, 0, 0);
            this.bottomRightTable.Controls.Add(this.zoomBar, 2, 0);
            this.bottomRightTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightTable.Location = new System.Drawing.Point(561, 0);
            this.bottomRightTable.Margin = new System.Windows.Forms.Padding(0);
            this.bottomRightTable.Name = "bottomRightTable";
            this.bottomRightTable.RowCount = 1;
            this.bottomRightTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomRightTable.Size = new System.Drawing.Size(375, 50);
            this.bottomRightTable.TabIndex = 9;
            // 
            // zoomInButton
            // 
            this.zoomInButton.AutoSize = true;
            this.zoomInButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomInButton.Location = new System.Drawing.Point(323, 3);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(49, 44);
            this.zoomInButton.TabIndex = 21;
            this.zoomInButton.Text = "+";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.AutoSize = true;
            this.zoomOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomOutButton.Location = new System.Drawing.Point(111, 3);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(44, 44);
            this.zoomOutButton.TabIndex = 20;
            this.zoomOutButton.Text = "-";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // zoomBox
            // 
            this.zoomBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zoomBox.FormattingEnabled = true;
            this.zoomBox.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.zoomBox.Location = new System.Drawing.Point(4, 13);
            this.zoomBox.Name = "zoomBox";
            this.zoomBox.Size = new System.Drawing.Size(100, 24);
            this.zoomBox.TabIndex = 1;
            this.zoomBox.Text = "100%";
            this.zoomBox.SelectedIndexChanged += new System.EventHandler(this.zoomBox_SelectedIndexChanged);
            // 
            // zoomBar
            // 
            this.zoomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomBar.LargeChange = 1;
            this.zoomBar.Location = new System.Drawing.Point(161, 3);
            this.zoomBar.Maximum = 9;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(156, 44);
            this.zoomBar.TabIndex = 17;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // ImageBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.rowContainer);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "ImageBrowser";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Image Browser";
            this.Resize += new System.EventHandler(this.ImageBrowser_Resize);
            this.rowContainer.ResumeLayout(false);
            this.topRow.ResumeLayout(false);
            this.topRow.PerformLayout();
            this.topLeftTable.ResumeLayout(false);
            this.topLeftTable.PerformLayout();
            this.topRightTable.ResumeLayout(false);
            this.topRightTable.PerformLayout();
            this.middleRow.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.advancedInfoTable.ResumeLayout(false);
            this.advancedInfoTable.PerformLayout();
            this.filePathTable.ResumeLayout(false);
            this.filePathTable.PerformLayout();
            this.dateTable.ResumeLayout(false);
            this.dateTable.PerformLayout();
            this.pictureBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.bottomRow.ResumeLayout(false);
            this.bottomLeftTable.ResumeLayout(false);
            this.bottomLeftTable.PerformLayout();
            this.bottomTable.ResumeLayout(false);
            this.bottomTable.PerformLayout();
            this.bottomRightTable.ResumeLayout(false);
            this.bottomRightTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel rowContainer;
        private System.Windows.Forms.TableLayoutPanel topRow;
        private System.Windows.Forms.TableLayoutPanel topLeftTable;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button flipYButton;
        private System.Windows.Forms.Button flipXButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.TableLayoutPanel topRightTable;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TableLayoutPanel middleRow;
        private System.Windows.Forms.TableLayoutPanel bottomRow;
        private System.Windows.Forms.TableLayoutPanel bottomLeftTable;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.TableLayoutPanel bottomTable;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TableLayoutPanel bottomRightTable;
        private System.Windows.Forms.TableLayoutPanel infoPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TableLayoutPanel advancedInfoTable;
        private System.Windows.Forms.Label formatValue;
        private System.Windows.Forms.Label dpiValue;
        private System.Windows.Forms.Label advancedInfoLabel;
        private System.Windows.Forms.TableLayoutPanel filePathTable;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.TableLayoutPanel dateTable;
        private System.Windows.Forms.Label dateAccessedValue;
        private System.Windows.Forms.Label dateModifiedValue;
        private System.Windows.Forms.Label dateCreatedValue;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label filePathValue;
        private System.Windows.Forms.Label dimensionsLabel;
        private System.Windows.Forms.Button explorerButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ComboBox zoomBox;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button zoomOutButton;
        protected System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.Panel pictureBoxPanel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

