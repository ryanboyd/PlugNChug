namespace PlugNChug
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.VarBox = new System.Windows.Forms.TextBox();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.AboutButton = new System.Windows.Forms.Button();
            this.BenderBox = new System.Windows.Forms.PictureBox();
            this.FryBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.BenderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VarBox
            // 
            this.VarBox.AcceptsReturn = true;
            this.VarBox.AcceptsTab = true;
            this.VarBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.VarBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarBox.Location = new System.Drawing.Point(18, 49);
            this.VarBox.MaxLength = 2147483647;
            this.VarBox.Multiline = true;
            this.VarBox.Name = "VarBox";
            this.VarBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VarBox.Size = new System.Drawing.Size(699, 166);
            this.VarBox.TabIndex = 0;
            this.VarBox.Text = "{{DV}} Happiness Sadness Depression";
            this.VarBox.WordWrap = false;
            // 
            // CodeBox
            // 
            this.CodeBox.AcceptsReturn = true;
            this.CodeBox.AcceptsTab = true;
            this.CodeBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CodeBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeBox.Location = new System.Drawing.Point(18, 265);
            this.CodeBox.MaxLength = 2147483647;
            this.CodeBox.Multiline = true;
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CodeBox.Size = new System.Drawing.Size(699, 194);
            this.CodeBox.TabIndex = 1;
            this.CodeBox.Text = "linear_model = lm({{DV}} ~ {{IV}}, data=df); summary(linear_model);";
            this.CodeBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Variable Names (Separated by Spaces or Tabs):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code to Fill In:";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(238, 482);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(119, 42);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(18, 541);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(704, 28);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Ready to build code...";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // AboutButton
            // 
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.Location = new System.Drawing.Point(379, 482);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(119, 42);
            this.AboutButton.TabIndex = 6;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // BenderBox
            // 
            this.BenderBox.BackColor = System.Drawing.Color.Transparent;
            this.BenderBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BenderBox.Location = new System.Drawing.Point(123, 477);
            this.BenderBox.Name = "BenderBox";
            this.BenderBox.Size = new System.Drawing.Size(71, 65);
            this.BenderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BenderBox.TabIndex = 7;
            this.BenderBox.TabStop = false;
            // 
            // FryBox
            // 
            this.FryBox.BackColor = System.Drawing.Color.Transparent;
            this.FryBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FryBox.Location = new System.Drawing.Point(536, 477);
            this.FryBox.Name = "FryBox";
            this.FryBox.Size = new System.Drawing.Size(71, 65);
            this.FryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FryBox.TabIndex = 8;
            this.FryBox.TabStop = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 578);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.VarBox);
            this.Controls.Add(this.BenderBox);
            this.Controls.Add(this.FryBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 617);
            this.MinimumSize = new System.Drawing.Size(750, 617);
            this.Name = "MainForm";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plug N Chug v1.00";
            ((System.ComponentModel.ISupportInitialize)(this.BenderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FryBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VarBox;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.PictureBox BenderBox;
        private System.Windows.Forms.PictureBox FryBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

