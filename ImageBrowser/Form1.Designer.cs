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
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.imageLabel = new System.Windows.Forms.Label();
            this.topRightTable = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pictureButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bottomLeftTable = new System.Windows.Forms.TableLayoutPanel();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.topLeftTable = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.flipYButton = new System.Windows.Forms.Button();
            this.flipXButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.bottomRightTable = new System.Windows.Forms.TableLayoutPanel();
            this.explorerButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mainTable.SuspendLayout();
            this.topRightTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.bottomLeftTable.SuspendLayout();
            this.bottomTable.SuspendLayout();
            this.topLeftTable.SuspendLayout();
            this.bottomRightTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 3;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTable.Controls.Add(this.imageLabel, 1, 0);
            this.mainTable.Controls.Add(this.topRightTable, 2, 0);
            this.mainTable.Controls.Add(this.pictureBox, 0, 1);
            this.mainTable.Controls.Add(this.bottomLeftTable, 0, 2);
            this.mainTable.Controls.Add(this.bottomTable, 1, 2);
            this.mainTable.Controls.Add(this.topLeftTable, 0, 0);
            this.mainTable.Controls.Add(this.bottomRightTable, 2, 2);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 3;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTable.Size = new System.Drawing.Size(942, 493);
            this.mainTable.TabIndex = 2;
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.imageLabel.Location = new System.Drawing.Point(379, 3);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(3);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(182, 44);
            this.imageLabel.TabIndex = 3;
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
            this.topRightTable.Controls.Add(this.folderButton, 1, 0);
            this.topRightTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRightTable.Location = new System.Drawing.Point(567, 3);
            this.topRightTable.Name = "topRightTable";
            this.topRightTable.RowCount = 1;
            this.topRightTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topRightTable.Size = new System.Drawing.Size(372, 44);
            this.topRightTable.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(3, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 38);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // pictureButton
            // 
            this.pictureButton.AutoSize = true;
            this.pictureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureButton.Location = new System.Drawing.Point(250, 3);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(119, 38);
            this.pictureButton.TabIndex = 6;
            this.pictureButton.Text = "Open Picture";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.AutoSize = true;
            this.folderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderButton.Location = new System.Drawing.Point(126, 3);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(118, 38);
            this.folderButton.TabIndex = 5;
            this.folderButton.Text = "Open Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainTable.SetColumnSpan(this.pictureBox, 3);
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(936, 387);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
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
            this.bottomLeftTable.Location = new System.Drawing.Point(3, 446);
            this.bottomLeftTable.Name = "bottomLeftTable";
            this.bottomLeftTable.RowCount = 1;
            this.bottomLeftTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomLeftTable.Size = new System.Drawing.Size(370, 44);
            this.bottomLeftTable.TabIndex = 5;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeLabel.Location = new System.Drawing.Point(225, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(142, 44);
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
            this.infoButton.Size = new System.Drawing.Size(68, 38);
            this.infoButton.TabIndex = 9;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimensionsLabel.Location = new System.Drawing.Point(77, 0);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(142, 44);
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
            this.bottomTable.Location = new System.Drawing.Point(379, 446);
            this.bottomTable.Name = "bottomTable";
            this.bottomTable.RowCount = 1;
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTable.Size = new System.Drawing.Size(182, 44);
            this.bottomTable.TabIndex = 6;
            // 
            // previousButton
            // 
            this.previousButton.AutoSize = true;
            this.previousButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousButton.Location = new System.Drawing.Point(3, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(85, 38);
            this.previousButton.TabIndex = 13;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButton.Location = new System.Drawing.Point(94, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(85, 38);
            this.nextButton.TabIndex = 14;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
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
            this.topLeftTable.Size = new System.Drawing.Size(370, 44);
            this.topLeftTable.TabIndex = 7;
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(279, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(88, 38);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // flipYButton
            // 
            this.flipYButton.AutoSize = true;
            this.flipYButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipYButton.Location = new System.Drawing.Point(187, 3);
            this.flipYButton.Name = "flipYButton";
            this.flipYButton.Size = new System.Drawing.Size(86, 38);
            this.flipYButton.TabIndex = 8;
            this.flipYButton.Text = "Flip (Y)";
            this.flipYButton.UseVisualStyleBackColor = true;
            this.flipYButton.Click += new System.EventHandler(this.flipYButton_Click);
            // 
            // flipXButton
            // 
            this.flipXButton.AutoSize = true;
            this.flipXButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipXButton.Location = new System.Drawing.Point(95, 3);
            this.flipXButton.Name = "flipXButton";
            this.flipXButton.Size = new System.Drawing.Size(86, 38);
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
            this.rotateButton.Size = new System.Drawing.Size(86, 38);
            this.rotateButton.TabIndex = 6;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // bottomRightTable
            // 
            this.bottomRightTable.ColumnCount = 1;
            this.bottomRightTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomRightTable.Controls.Add(this.explorerButton, 0, 0);
            this.bottomRightTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightTable.Location = new System.Drawing.Point(567, 446);
            this.bottomRightTable.Name = "bottomRightTable";
            this.bottomRightTable.RowCount = 1;
            this.bottomRightTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomRightTable.Size = new System.Drawing.Size(372, 44);
            this.bottomRightTable.TabIndex = 8;
            // 
            // explorerButton
            // 
            this.explorerButton.AutoSize = true;
            this.explorerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerButton.Location = new System.Drawing.Point(3, 3);
            this.explorerButton.Name = "explorerButton";
            this.explorerButton.Size = new System.Drawing.Size(366, 38);
            this.explorerButton.TabIndex = 11;
            this.explorerButton.Text = "Open in File Explorer";
            this.explorerButton.UseVisualStyleBackColor = true;
            this.explorerButton.Click += new System.EventHandler(this.explorerButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // ImageBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.mainTable);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "ImageBrowser";
            this.Text = "Image Browser";
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
            this.topRightTable.ResumeLayout(false);
            this.topRightTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.bottomLeftTable.ResumeLayout(false);
            this.bottomLeftTable.PerformLayout();
            this.bottomTable.ResumeLayout(false);
            this.bottomTable.PerformLayout();
            this.topLeftTable.ResumeLayout(false);
            this.topLeftTable.PerformLayout();
            this.bottomRightTable.ResumeLayout(false);
            this.bottomRightTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.TableLayoutPanel topRightTable;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel bottomLeftTable;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label dimensionsLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TableLayoutPanel bottomTable;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TableLayoutPanel topLeftTable;
        private System.Windows.Forms.Button flipXButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Button flipYButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TableLayoutPanel bottomRightTable;
        private System.Windows.Forms.Button explorerButton;
    }
}

