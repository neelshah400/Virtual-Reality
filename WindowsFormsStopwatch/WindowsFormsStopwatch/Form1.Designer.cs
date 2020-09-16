namespace WindowsFormsStopwatch
{
    partial class Form1
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
            this.buttonToggle = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.radioSeconds = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioMilliseconds = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonToggle
            // 
            this.buttonToggle.Location = new System.Drawing.Point(49, 109);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(75, 23);
            this.buttonToggle.TabIndex = 0;
            this.buttonToggle.Text = "Start/Stop";
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(39, 36);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(130, 55);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // radioSeconds
            // 
            this.radioSeconds.AutoSize = true;
            this.radioSeconds.Checked = true;
            this.radioSeconds.Location = new System.Drawing.Point(6, 19);
            this.radioSeconds.Name = "radioSeconds";
            this.radioSeconds.Size = new System.Drawing.Size(65, 17);
            this.radioSeconds.TabIndex = 2;
            this.radioSeconds.TabStop = true;
            this.radioSeconds.Text = "seconds";
            this.radioSeconds.UseVisualStyleBackColor = true;
            this.radioSeconds.CheckedChanged += new System.EventHandler(this.radioSeconds_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioMilliseconds);
            this.groupBox.Controls.Add(this.radioSeconds);
            this.groupBox.Location = new System.Drawing.Point(49, 144);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 51);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Unit";
            // 
            // radioMilliseconds
            // 
            this.radioMilliseconds.AutoSize = true;
            this.radioMilliseconds.Location = new System.Drawing.Point(97, 19);
            this.radioMilliseconds.Name = "radioMilliseconds";
            this.radioMilliseconds.Size = new System.Drawing.Size(81, 17);
            this.radioMilliseconds.TabIndex = 3;
            this.radioMilliseconds.TabStop = true;
            this.radioMilliseconds.Text = "milliseconds";
            this.radioMilliseconds.UseVisualStyleBackColor = true;
            this.radioMilliseconds.CheckedChanged += new System.EventHandler(this.radioMilliseconds_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 256);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonToggle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.RadioButton radioSeconds;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioMilliseconds;
    }
}

