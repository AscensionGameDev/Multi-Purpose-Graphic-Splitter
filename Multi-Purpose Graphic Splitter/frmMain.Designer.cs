namespace Multi_Purpose_Graphic_Splitter
{
    partial class frmMain
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.grpStep2 = new System.Windows.Forms.GroupBox();
            this.scrlSplitRows = new System.Windows.Forms.HScrollBar();
            this.lblSplitRows = new System.Windows.Forms.Label();
            this.scrlSplitColumns = new System.Windows.Forms.HScrollBar();
            this.lblSplitColumns = new System.Windows.Forms.Label();
            this.pnlSampleImg = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpStep3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.grpStep1.SuspendLayout();
            this.grpStep2.SuspendLayout();
            this.grpStep3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(57, 52);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(222, 20);
            this.txtSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Isolate the images you want to split. Throw them into a folder all by themselves." +
    " Select that folder as the source.";
            // 
            // btnChooseSource
            // 
            this.btnChooseSource.Location = new System.Drawing.Point(285, 50);
            this.btnChooseSource.Name = "btnChooseSource";
            this.btnChooseSource.Size = new System.Drawing.Size(69, 23);
            this.btnChooseSource.TabIndex = 2;
            this.btnChooseSource.Text = "Browse";
            this.btnChooseSource.UseVisualStyleBackColor = true;
            this.btnChooseSource.Click += new System.EventHandler(this.btnChooseSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source:";
            // 
            // grpStep1
            // 
            this.grpStep1.Controls.Add(this.label1);
            this.grpStep1.Controls.Add(this.label2);
            this.grpStep1.Controls.Add(this.txtSource);
            this.grpStep1.Controls.Add(this.btnChooseSource);
            this.grpStep1.Location = new System.Drawing.Point(12, 12);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Size = new System.Drawing.Size(360, 83);
            this.grpStep1.TabIndex = 4;
            this.grpStep1.TabStop = false;
            this.grpStep1.Text = "Step 1";
            // 
            // grpStep2
            // 
            this.grpStep2.Controls.Add(this.scrlSplitRows);
            this.grpStep2.Controls.Add(this.lblSplitRows);
            this.grpStep2.Controls.Add(this.scrlSplitColumns);
            this.grpStep2.Controls.Add(this.lblSplitColumns);
            this.grpStep2.Controls.Add(this.pnlSampleImg);
            this.grpStep2.Controls.Add(this.label3);
            this.grpStep2.Location = new System.Drawing.Point(12, 101);
            this.grpStep2.Name = "grpStep2";
            this.grpStep2.Size = new System.Drawing.Size(360, 353);
            this.grpStep2.TabIndex = 5;
            this.grpStep2.TabStop = false;
            this.grpStep2.Text = "Step 2";
            this.grpStep2.Visible = false;
            // 
            // scrlSplitRows
            // 
            this.scrlSplitRows.Location = new System.Drawing.Point(98, 322);
            this.scrlSplitRows.Name = "scrlSplitRows";
            this.scrlSplitRows.Size = new System.Drawing.Size(256, 17);
            this.scrlSplitRows.TabIndex = 6;
            this.scrlSplitRows.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlSplitRows_Scroll);
            // 
            // lblSplitRows
            // 
            this.lblSplitRows.AutoSize = true;
            this.lblSplitRows.Location = new System.Drawing.Point(9, 323);
            this.lblSplitRows.Name = "lblSplitRows";
            this.lblSplitRows.Size = new System.Drawing.Size(69, 13);
            this.lblSplitRows.TabIndex = 5;
            this.lblSplitRows.Text = "Split Rows: 0";
            // 
            // scrlSplitColumns
            // 
            this.scrlSplitColumns.Location = new System.Drawing.Point(98, 296);
            this.scrlSplitColumns.Name = "scrlSplitColumns";
            this.scrlSplitColumns.Size = new System.Drawing.Size(256, 17);
            this.scrlSplitColumns.TabIndex = 4;
            this.scrlSplitColumns.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlSplitColumns_Scroll);
            // 
            // lblSplitColumns
            // 
            this.lblSplitColumns.AutoSize = true;
            this.lblSplitColumns.Location = new System.Drawing.Point(9, 297);
            this.lblSplitColumns.Name = "lblSplitColumns";
            this.lblSplitColumns.Size = new System.Drawing.Size(82, 13);
            this.lblSplitColumns.TabIndex = 3;
            this.lblSplitColumns.Text = "Split Columns: 0";
            // 
            // pnlSampleImg
            // 
            this.pnlSampleImg.Location = new System.Drawing.Point(9, 57);
            this.pnlSampleImg.Name = "pnlSampleImg";
            this.pnlSampleImg.Size = new System.Drawing.Size(345, 233);
            this.pnlSampleImg.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 49);
            this.label3.TabIndex = 1;
            this.label3.Text = "One of the images found should be displayed below. Use the scrollbars below to se" +
    "t where you want the image to be split. (Note: All images will be split in this " +
    "manner.)";
            // 
            // grpStep3
            // 
            this.grpStep3.Controls.Add(this.label4);
            this.grpStep3.Controls.Add(this.label5);
            this.grpStep3.Controls.Add(this.txtDestination);
            this.grpStep3.Controls.Add(this.btnBrowseDestination);
            this.grpStep3.Location = new System.Drawing.Point(12, 460);
            this.grpStep3.Name = "grpStep3";
            this.grpStep3.Size = new System.Drawing.Size(360, 61);
            this.grpStep3.TabIndex = 6;
            this.grpStep3.TabStop = false;
            this.grpStep3.Text = "Step 3";
            this.grpStep3.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select an empty folder to place the split graphics into.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Source:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(57, 34);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(222, 20);
            this.txtDestination.TabIndex = 0;
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Location = new System.Drawing.Point(285, 32);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(69, 23);
            this.btnBrowseDestination.TabIndex = 2;
            this.btnBrowseDestination.Text = "Browse";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(110, 527);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(149, 34);
            this.btnSplit.TabIndex = 7;
            this.btnSplit.Text = "Split!";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Visible = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 573);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.grpStep3);
            this.Controls.Add(this.grpStep2);
            this.Controls.Add(this.grpStep1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Ascension Game Dev Multi-Purpose Graphic Splitter";
            this.grpStep1.ResumeLayout(false);
            this.grpStep1.PerformLayout();
            this.grpStep2.ResumeLayout(false);
            this.grpStep2.PerformLayout();
            this.grpStep3.ResumeLayout(false);
            this.grpStep3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.GroupBox grpStep2;
        private System.Windows.Forms.HScrollBar scrlSplitRows;
        private System.Windows.Forms.Label lblSplitRows;
        private System.Windows.Forms.HScrollBar scrlSplitColumns;
        private System.Windows.Forms.Label lblSplitColumns;
        private System.Windows.Forms.Panel pnlSampleImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpStep3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.Button btnSplit;
    }
}

