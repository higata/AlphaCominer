namespace AlpaCombiner
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.srcImagebox = new System.Windows.Forms.PictureBox();
            this.srcImagePath = new System.Windows.Forms.TextBox();
            this.srcImageOpenButton = new System.Windows.Forms.Button();
            this.srcImageGroup = new System.Windows.Forms.GroupBox();
            this.grayImageGroup = new System.Windows.Forms.GroupBox();
            this.grayImagebox = new System.Windows.Forms.PictureBox();
            this.grayImageOpenButton = new System.Windows.Forms.Button();
            this.grayImagePath = new System.Windows.Forms.TextBox();
            this.leftTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.resultImageGroup = new System.Windows.Forms.GroupBox();
            this.isAlphaKeepCheck = new System.Windows.Forms.CheckBox();
            this.execButton = new System.Windows.Forms.Button();
            this.resultImageBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.srcImagebox)).BeginInit();
            this.srcImageGroup.SuspendLayout();
            this.grayImageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayImagebox)).BeginInit();
            this.leftTableLayout.SuspendLayout();
            this.mainTableLayout.SuspendLayout();
            this.resultImageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // srcImagebox
            // 
            this.srcImagebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.srcImagebox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.srcImagebox.Location = new System.Drawing.Point(3, 15);
            this.srcImagebox.Name = "srcImagebox";
            this.srcImagebox.Size = new System.Drawing.Size(383, 154);
            this.srcImagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.srcImagebox.TabIndex = 0;
            this.srcImagebox.TabStop = false;
            this.srcImagebox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SrcImagebox_DragDrop);
            this.srcImagebox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImageBox_DragEnter);
            // 
            // srcImagePath
            // 
            this.srcImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.srcImagePath.Location = new System.Drawing.Point(3, 177);
            this.srcImagePath.Name = "srcImagePath";
            this.srcImagePath.ReadOnly = true;
            this.srcImagePath.Size = new System.Drawing.Size(302, 19);
            this.srcImagePath.TabIndex = 99;
            this.srcImagePath.Click += new System.EventHandler(this.SrcImageOpenButton_Click);
            // 
            // srcImageOpenButton
            // 
            this.srcImageOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.srcImageOpenButton.Location = new System.Drawing.Point(311, 175);
            this.srcImageOpenButton.Name = "srcImageOpenButton";
            this.srcImageOpenButton.Size = new System.Drawing.Size(75, 23);
            this.srcImageOpenButton.TabIndex = 0;
            this.srcImageOpenButton.Text = "参照";
            this.srcImageOpenButton.UseVisualStyleBackColor = true;
            this.srcImageOpenButton.Click += new System.EventHandler(this.SrcImageOpenButton_Click);
            // 
            // srcImageGroup
            // 
            this.srcImageGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.srcImageGroup.Controls.Add(this.srcImagebox);
            this.srcImageGroup.Controls.Add(this.srcImageOpenButton);
            this.srcImageGroup.Controls.Add(this.srcImagePath);
            this.srcImageGroup.Location = new System.Drawing.Point(0, 0);
            this.srcImageGroup.Margin = new System.Windows.Forms.Padding(0);
            this.srcImageGroup.Name = "srcImageGroup";
            this.srcImageGroup.Padding = new System.Windows.Forms.Padding(0);
            this.srcImageGroup.Size = new System.Drawing.Size(389, 202);
            this.srcImageGroup.TabIndex = 4;
            this.srcImageGroup.TabStop = false;
            this.srcImageGroup.Text = "元画像";
            // 
            // grayImageGroup
            // 
            this.grayImageGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grayImageGroup.Controls.Add(this.grayImagebox);
            this.grayImageGroup.Controls.Add(this.grayImageOpenButton);
            this.grayImageGroup.Controls.Add(this.grayImagePath);
            this.grayImageGroup.Location = new System.Drawing.Point(0, 202);
            this.grayImageGroup.Margin = new System.Windows.Forms.Padding(0);
            this.grayImageGroup.Name = "grayImageGroup";
            this.grayImageGroup.Padding = new System.Windows.Forms.Padding(0);
            this.grayImageGroup.Size = new System.Drawing.Size(389, 203);
            this.grayImageGroup.TabIndex = 5;
            this.grayImageGroup.TabStop = false;
            this.grayImageGroup.Text = "グレースケール画像";
            // 
            // grayImagebox
            // 
            this.grayImagebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grayImagebox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grayImagebox.Location = new System.Drawing.Point(3, 15);
            this.grayImagebox.Name = "grayImagebox";
            this.grayImagebox.Size = new System.Drawing.Size(383, 155);
            this.grayImagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.grayImagebox.TabIndex = 0;
            this.grayImagebox.TabStop = false;
            this.grayImagebox.DragDrop += new System.Windows.Forms.DragEventHandler(this.GrayImagebox_DragDrop);
            this.grayImagebox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImageBox_DragEnter);
            // 
            // grayImageOpenButton
            // 
            this.grayImageOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grayImageOpenButton.Location = new System.Drawing.Point(311, 176);
            this.grayImageOpenButton.Name = "grayImageOpenButton";
            this.grayImageOpenButton.Size = new System.Drawing.Size(75, 23);
            this.grayImageOpenButton.TabIndex = 1;
            this.grayImageOpenButton.Text = "参照";
            this.grayImageOpenButton.UseVisualStyleBackColor = true;
            this.grayImageOpenButton.Click += new System.EventHandler(this.GrayImageOpenButton_Click);
            // 
            // grayImagePath
            // 
            this.grayImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grayImagePath.Location = new System.Drawing.Point(3, 178);
            this.grayImagePath.Name = "grayImagePath";
            this.grayImagePath.ReadOnly = true;
            this.grayImagePath.Size = new System.Drawing.Size(302, 19);
            this.grayImagePath.TabIndex = 99;
            this.grayImagePath.Click += new System.EventHandler(this.GrayImageOpenButton_Click);
            // 
            // leftTableLayout
            // 
            this.leftTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftTableLayout.ColumnCount = 1;
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftTableLayout.Controls.Add(this.srcImageGroup, 0, 0);
            this.leftTableLayout.Controls.Add(this.grayImageGroup, 0, 1);
            this.leftTableLayout.Location = new System.Drawing.Point(3, 3);
            this.leftTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.leftTableLayout.Name = "leftTableLayout";
            this.leftTableLayout.RowCount = 2;
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftTableLayout.Size = new System.Drawing.Size(389, 405);
            this.leftTableLayout.TabIndex = 7;
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Controls.Add(this.resultImageGroup, 1, 0);
            this.mainTableLayout.Controls.Add(this.leftTableLayout, 0, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.Padding = new System.Windows.Forms.Padding(3);
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayout.Size = new System.Drawing.Size(784, 411);
            this.mainTableLayout.TabIndex = 8;
            // 
            // resultImageGroup
            // 
            this.resultImageGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultImageGroup.Controls.Add(this.isAlphaKeepCheck);
            this.resultImageGroup.Controls.Add(this.execButton);
            this.resultImageGroup.Controls.Add(this.resultImageBox);
            this.resultImageGroup.Controls.Add(this.saveButton);
            this.resultImageGroup.Location = new System.Drawing.Point(392, 3);
            this.resultImageGroup.Margin = new System.Windows.Forms.Padding(0);
            this.resultImageGroup.Name = "resultImageGroup";
            this.resultImageGroup.Padding = new System.Windows.Forms.Padding(0);
            this.resultImageGroup.Size = new System.Drawing.Size(389, 405);
            this.resultImageGroup.TabIndex = 8;
            this.resultImageGroup.TabStop = false;
            this.resultImageGroup.Text = "結果画像";
            // 
            // isAlphaKeepCheck
            // 
            this.isAlphaKeepCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.isAlphaKeepCheck.AutoSize = true;
            this.isAlphaKeepCheck.Location = new System.Drawing.Point(50, 382);
            this.isAlphaKeepCheck.Name = "isAlphaKeepCheck";
            this.isAlphaKeepCheck.Size = new System.Drawing.Size(174, 16);
            this.isAlphaKeepCheck.TabIndex = 2;
            this.isAlphaKeepCheck.Text = "元画像のアルファ値0を維持する";
            this.isAlphaKeepCheck.UseVisualStyleBackColor = true;
            // 
            // execButton
            // 
            this.execButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.execButton.Location = new System.Drawing.Point(230, 378);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(75, 23);
            this.execButton.TabIndex = 3;
            this.execButton.Text = "合成";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.ExecButton_Click);
            // 
            // resultImageBox
            // 
            this.resultImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultImageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resultImageBox.Location = new System.Drawing.Point(3, 15);
            this.resultImageBox.Name = "resultImageBox";
            this.resultImageBox.Size = new System.Drawing.Size(383, 357);
            this.resultImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.resultImageBox.TabIndex = 0;
            this.resultImageBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(311, 378);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "MainWindow";
            this.Text = "AlphaCombiner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.srcImagebox)).EndInit();
            this.srcImageGroup.ResumeLayout(false);
            this.srcImageGroup.PerformLayout();
            this.grayImageGroup.ResumeLayout(false);
            this.grayImageGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayImagebox)).EndInit();
            this.leftTableLayout.ResumeLayout(false);
            this.mainTableLayout.ResumeLayout(false);
            this.resultImageGroup.ResumeLayout(false);
            this.resultImageGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox srcImagebox;
        private System.Windows.Forms.TextBox srcImagePath;
        private System.Windows.Forms.Button srcImageOpenButton;
        private System.Windows.Forms.GroupBox srcImageGroup;
        private System.Windows.Forms.GroupBox grayImageGroup;
        private System.Windows.Forms.PictureBox grayImagebox;
        private System.Windows.Forms.Button grayImageOpenButton;
        private System.Windows.Forms.TextBox grayImagePath;
        private System.Windows.Forms.TableLayoutPanel leftTableLayout;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.GroupBox resultImageGroup;
        private System.Windows.Forms.PictureBox resultImageBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.CheckBox isAlphaKeepCheck;
    }
}

