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
            this.topRightTable = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pictureButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.middleRow = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.bottomRow = new System.Windows.Forms.TableLayoutPanel();
            this.bottomLeftTable = new System.Windows.Forms.TableLayoutPanel();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.bottomRightTable = new System.Windows.Forms.TableLayoutPanel();
            this.explorerButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateCreatedValue = new System.Windows.Forms.Label();
            this.dateModifiedValue = new System.Windows.Forms.Label();
            this.dateAccessedValue = new System.Windows.Forms.Label();
            this.dateTable = new System.Windows.Forms.TableLayoutPanel();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.filePathTable = new System.Windows.Forms.TableLayoutPanel();
            this.advancedInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.formatValue = new System.Windows.Forms.Label();
            this.dpiValue = new System.Windows.Forms.Label();
            this.advancedInfoLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.filePathValue = new System.Windows.Forms.Label();
            this.rowContainer.SuspendLayout();
            this.topRow.SuspendLayout();
            this.topLeftTable.SuspendLayout();
            this.topRightTable.SuspendLayout();
            this.middleRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.bottomRow.SuspendLayout();
            this.bottomLeftTable.SuspendLayout();
            this.bottomTable.SuspendLayout();
            this.bottomRightTable.SuspendLayout();
            this.dateTable.SuspendLayout();
            this.filePathTable.SuspendLayout();
            this.advancedInfoTable.SuspendLayout();
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
            this.rowContainer.Location = new System.Drawing.Point(0, 0);
            this.rowContainer.Name = "rowContainer";
            this.rowContainer.RowCount = 3;
            this.rowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rowContainer.Size = new System.Drawing.Size(942, 493);
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
            this.topRow.Location = new System.Drawing.Point(3, 3);
            this.topRow.Name = "topRow";
            this.topRow.RowCount = 1;
            this.topRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topRow.Size = new System.Drawing.Size(936, 44);
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
            this.topLeftTable.Location = new System.Drawing.Point(3, 3);
            this.topLeftTable.Name = "topLeftTable";
            this.topLeftTable.RowCount = 1;
            this.topLeftTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLeftTable.Size = new System.Drawing.Size(321, 38);
            this.topLeftTable.TabIndex = 8;
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(243, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 32);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // flipYButton
            // 
            this.flipYButton.AutoSize = true;
            this.flipYButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipYButton.Location = new System.Drawing.Point(163, 3);
            this.flipYButton.Name = "flipYButton";
            this.flipYButton.Size = new System.Drawing.Size(74, 32);
            this.flipYButton.TabIndex = 8;
            this.flipYButton.Text = "Flip (Y)";
            this.flipYButton.UseVisualStyleBackColor = true;
            this.flipYButton.Click += new System.EventHandler(this.flipYButton_Click);
            // 
            // flipXButton
            // 
            this.flipXButton.AutoSize = true;
            this.flipXButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipXButton.Location = new System.Drawing.Point(83, 3);
            this.flipXButton.Name = "flipXButton";
            this.flipXButton.Size = new System.Drawing.Size(74, 32);
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
            this.rotateButton.Size = new System.Drawing.Size(74, 32);
            this.rotateButton.TabIndex = 6;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // topRightTable
            // 
            this.topRightTable.ColumnCount = 3;
            this.topRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.topRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.topRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.topRightTable.Controls.Add(this.deleteButton, 0, 0);
            this.topRightTable.Controls.Add(this.pictureButton, 2, 0);
            this.topRightTable.Controls.Add(this.folderButton, 1, 0);
            this.topRightTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRightTable.Location = new System.Drawing.Point(610, 3);
            this.topRightTable.Name = "topRightTable";
            this.topRightTable.RowCount = 1;
            this.topRightTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topRightTable.Size = new System.Drawing.Size(323, 38);
            this.topRightTable.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(3, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 32);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.AutoSize = true;
            this.pictureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureButton.Location = new System.Drawing.Point(217, 3);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(103, 32);
            this.pictureButton.TabIndex = 6;
            this.pictureButton.Text = "Open Picture";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.AutoSize = true;
            this.folderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderButton.Location = new System.Drawing.Point(110, 3);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(101, 32);
            this.folderButton.TabIndex = 5;
            this.folderButton.Text = "Open Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // middleRow
            // 
            this.middleRow.ColumnCount = 2;
            this.middleRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.middleRow.Controls.Add(this.pictureBox, 0, 0);
            this.middleRow.Controls.Add(this.infoPanel, 1, 0);
            this.middleRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleRow.Location = new System.Drawing.Point(3, 53);
            this.middleRow.Name = "middleRow";
            this.middleRow.RowCount = 1;
            this.middleRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.middleRow.Size = new System.Drawing.Size(936, 387);
            this.middleRow.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(680, 381);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // infoPanel
            // 
            this.infoPanel.ColumnCount = 1;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoPanel.Controls.Add(this.advancedInfoTable, 0, 3);
            this.infoPanel.Controls.Add(this.filePathTable, 0, 1);
            this.infoPanel.Controls.Add(this.dateTable, 0, 2);
            this.infoPanel.Controls.Add(this.infoLabel, 0, 0);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(689, 3);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.RowCount = 4;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.infoPanel.Size = new System.Drawing.Size(244, 275);
            this.infoPanel.TabIndex = 2;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(3, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.infoLabel.Size = new System.Drawing.Size(238, 50);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Metadata";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.bottomRow.Location = new System.Drawing.Point(3, 446);
            this.bottomRow.Name = "bottomRow";
            this.bottomRow.RowCount = 1;
            this.bottomRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.bottomRow.Size = new System.Drawing.Size(936, 44);
            this.bottomRow.TabIndex = 2;
            // 
            // bottomLeftTable
            // 
            this.bottomLeftTable.ColumnCount = 3;
            this.bottomLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bottomLeftTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bottomLeftTable.Controls.Add(this.sizeLabel, 2, 0);
            this.bottomLeftTable.Controls.Add(this.infoButton, 0, 0);
            this.bottomLeftTable.Controls.Add(this.dimensionsLabel, 1, 0);
            this.bottomLeftTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeftTable.Location = new System.Drawing.Point(3, 3);
            this.bottomLeftTable.Name = "bottomLeftTable";
            this.bottomLeftTable.RowCount = 1;
            this.bottomLeftTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomLeftTable.Size = new System.Drawing.Size(368, 38);
            this.bottomLeftTable.TabIndex = 11;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeLabel.Location = new System.Drawing.Point(223, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(142, 38);
            this.sizeLabel.TabIndex = 11;
            this.sizeLabel.Text = "0 B";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoButton
            // 
            this.infoButton.AutoSize = true;
            this.infoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoButton.Location = new System.Drawing.Point(3, 3);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(67, 32);
            this.infoButton.TabIndex = 9;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimensionsLabel.Location = new System.Drawing.Point(76, 0);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(141, 38);
            this.dimensionsLabel.TabIndex = 10;
            this.dimensionsLabel.Text = "0 x 0";
            this.dimensionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomTable
            // 
            this.bottomTable.ColumnCount = 2;
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTable.Controls.Add(this.previousButton, 0, 0);
            this.bottomTable.Controls.Add(this.nextButton, 1, 0);
            this.bottomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTable.Location = new System.Drawing.Point(377, 3);
            this.bottomTable.Name = "bottomTable";
            this.bottomTable.RowCount = 1;
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTable.Size = new System.Drawing.Size(181, 38);
            this.bottomTable.TabIndex = 10;
            // 
            // previousButton
            // 
            this.previousButton.AutoSize = true;
            this.previousButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousButton.Location = new System.Drawing.Point(3, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(84, 32);
            this.previousButton.TabIndex = 13;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButton.Location = new System.Drawing.Point(93, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(85, 32);
            this.nextButton.TabIndex = 14;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // bottomRightTable
            // 
            this.bottomRightTable.ColumnCount = 1;
            this.bottomRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomRightTable.Controls.Add(this.explorerButton, 0, 0);
            this.bottomRightTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightTable.Location = new System.Drawing.Point(564, 3);
            this.bottomRightTable.Name = "bottomRightTable";
            this.bottomRightTable.RowCount = 1;
            this.bottomRightTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomRightTable.Size = new System.Drawing.Size(369, 38);
            this.bottomRightTable.TabIndex = 9;
            // 
            // explorerButton
            // 
            this.explorerButton.AutoSize = true;
            this.explorerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerButton.Location = new System.Drawing.Point(3, 3);
            this.explorerButton.Name = "explorerButton";
            this.explorerButton.Size = new System.Drawing.Size(363, 32);
            this.explorerButton.TabIndex = 11;
            this.explorerButton.Text = "Open in File Explorer";
            this.explorerButton.UseVisualStyleBackColor = true;
            this.explorerButton.Click += new System.EventHandler(this.explorerButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(3, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dateLabel.Size = new System.Drawing.Size(232, 23);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateCreatedValue
            // 
            this.dateCreatedValue.AutoSize = true;
            this.dateCreatedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateCreatedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedValue.Location = new System.Drawing.Point(3, 23);
            this.dateCreatedValue.Name = "dateCreatedValue";
            this.dateCreatedValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dateCreatedValue.Size = new System.Drawing.Size(232, 23);
            this.dateCreatedValue.TabIndex = 2;
            this.dateCreatedValue.Text = "Created: 01/01/01 12:01am";
            this.dateCreatedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateModifiedValue
            // 
            this.dateModifiedValue.AutoSize = true;
            this.dateModifiedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateModifiedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateModifiedValue.Location = new System.Drawing.Point(3, 46);
            this.dateModifiedValue.Name = "dateModifiedValue";
            this.dateModifiedValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dateModifiedValue.Size = new System.Drawing.Size(232, 23);
            this.dateModifiedValue.TabIndex = 3;
            this.dateModifiedValue.Text = "Modified: 01/01/01 12:01am";
            this.dateModifiedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateAccessedValue
            // 
            this.dateAccessedValue.AutoSize = true;
            this.dateAccessedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateAccessedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAccessedValue.Location = new System.Drawing.Point(3, 69);
            this.dateAccessedValue.Name = "dateAccessedValue";
            this.dateAccessedValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dateAccessedValue.Size = new System.Drawing.Size(232, 25);
            this.dateAccessedValue.TabIndex = 4;
            this.dateAccessedValue.Text = "Accessed: 01/01/01 12:01am";
            this.dateAccessedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTable
            // 
            this.dateTable.ColumnCount = 1;
            this.dateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dateTable.Controls.Add(this.dateAccessedValue, 0, 3);
            this.dateTable.Controls.Add(this.dateModifiedValue, 0, 2);
            this.dateTable.Controls.Add(this.dateCreatedValue, 0, 1);
            this.dateTable.Controls.Add(this.dateLabel, 0, 0);
            this.dateTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTable.Location = new System.Drawing.Point(3, 103);
            this.dateTable.Name = "dateTable";
            this.dateTable.RowCount = 4;
            this.dateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dateTable.Size = new System.Drawing.Size(238, 94);
            this.dateTable.TabIndex = 8;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathLabel.Location = new System.Drawing.Point(3, 0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.filePathLabel.Size = new System.Drawing.Size(232, 22);
            this.filePathLabel.TabIndex = 1;
            this.filePathLabel.Text = "File Path";
            this.filePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filePathTable
            // 
            this.filePathTable.AutoSize = true;
            this.filePathTable.ColumnCount = 1;
            this.filePathTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filePathTable.Controls.Add(this.filePathValue, 0, 1);
            this.filePathTable.Controls.Add(this.filePathLabel, 0, 0);
            this.filePathTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePathTable.Location = new System.Drawing.Point(3, 53);
            this.filePathTable.Name = "filePathTable";
            this.filePathTable.RowCount = 2;
            this.filePathTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filePathTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filePathTable.Size = new System.Drawing.Size(238, 44);
            this.filePathTable.TabIndex = 11;
            // 
            // advancedInfoTable
            // 
            this.advancedInfoTable.ColumnCount = 1;
            this.advancedInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.advancedInfoTable.Controls.Add(this.formatValue, 0, 2);
            this.advancedInfoTable.Controls.Add(this.dpiValue, 0, 1);
            this.advancedInfoTable.Controls.Add(this.advancedInfoLabel, 0, 0);
            this.advancedInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedInfoTable.Location = new System.Drawing.Point(3, 203);
            this.advancedInfoTable.Name = "advancedInfoTable";
            this.advancedInfoTable.RowCount = 3;
            this.advancedInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.advancedInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.advancedInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.advancedInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.advancedInfoTable.Size = new System.Drawing.Size(238, 69);
            this.advancedInfoTable.TabIndex = 13;
            // 
            // formatValue
            // 
            this.formatValue.AutoSize = true;
            this.formatValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatValue.Location = new System.Drawing.Point(3, 46);
            this.formatValue.Name = "formatValue";
            this.formatValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.formatValue.Size = new System.Drawing.Size(232, 23);
            this.formatValue.TabIndex = 3;
            this.formatValue.Text = "Format: Unknown";
            this.formatValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpiValue
            // 
            this.dpiValue.AutoSize = true;
            this.dpiValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpiValue.Location = new System.Drawing.Point(3, 23);
            this.dpiValue.Name = "dpiValue";
            this.dpiValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dpiValue.Size = new System.Drawing.Size(232, 23);
            this.dpiValue.TabIndex = 2;
            this.dpiValue.Text = "DPI: 0dpi";
            this.dpiValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // advancedInfoLabel
            // 
            this.advancedInfoLabel.AutoSize = true;
            this.advancedInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedInfoLabel.Location = new System.Drawing.Point(3, 0);
            this.advancedInfoLabel.Name = "advancedInfoLabel";
            this.advancedInfoLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.advancedInfoLabel.Size = new System.Drawing.Size(232, 23);
            this.advancedInfoLabel.TabIndex = 1;
            this.advancedInfoLabel.Text = "Advanced Info";
            this.advancedInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.imageLabel.Location = new System.Drawing.Point(330, 3);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(3);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(274, 38);
            this.imageLabel.TabIndex = 6;
            this.imageLabel.Text = "image.png (0 of 0)";
            this.imageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filePathValue
            // 
            this.filePathValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePathValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathValue.Location = new System.Drawing.Point(3, 22);
            this.filePathValue.Name = "filePathValue";
            this.filePathValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.filePathValue.Size = new System.Drawing.Size(232, 22);
            this.filePathValue.TabIndex = 2;
            this.filePathValue.Text = "C:\\image.png";
            this.filePathValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImageBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.rowContainer);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "ImageBrowser";
            this.Text = "Image Browser";
            this.rowContainer.ResumeLayout(false);
            this.topRow.ResumeLayout(false);
            this.topRow.PerformLayout();
            this.topLeftTable.ResumeLayout(false);
            this.topLeftTable.PerformLayout();
            this.topRightTable.ResumeLayout(false);
            this.topRightTable.PerformLayout();
            this.middleRow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.bottomRow.ResumeLayout(false);
            this.bottomLeftTable.ResumeLayout(false);
            this.bottomLeftTable.PerformLayout();
            this.bottomTable.ResumeLayout(false);
            this.bottomTable.PerformLayout();
            this.bottomRightTable.ResumeLayout(false);
            this.bottomRightTable.PerformLayout();
            this.dateTable.ResumeLayout(false);
            this.dateTable.PerformLayout();
            this.filePathTable.ResumeLayout(false);
            this.filePathTable.PerformLayout();
            this.advancedInfoTable.ResumeLayout(false);
            this.advancedInfoTable.PerformLayout();
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
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TableLayoutPanel middleRow;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel bottomRow;
        private System.Windows.Forms.TableLayoutPanel bottomLeftTable;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label dimensionsLabel;
        private System.Windows.Forms.TableLayoutPanel bottomTable;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TableLayoutPanel bottomRightTable;
        private System.Windows.Forms.Button explorerButton;
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
    }
}

