namespace discord_screenshare_not_responding {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.doBlockMainThread = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doBlockMainThread
            // 
            this.doBlockMainThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doBlockMainThread.Location = new System.Drawing.Point(319, 108);
            this.doBlockMainThread.Name = "doBlockMainThread";
            this.doBlockMainThread.Size = new System.Drawing.Size(169, 23);
            this.doBlockMainThread.TabIndex = 0;
            this.doBlockMainThread.Text = "Start not responding for 1 minute";
            this.doBlockMainThread.UseVisualStyleBackColor = true;
            this.doBlockMainThread.Click += new System.EventHandler(this.doBlockMainThread_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This application is designed solely to demonstrate a bug with the Discord Desktop" +
    " client. It makes this application go not responding in order to demonstrate the" +
    " bug.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doBlockMainThread);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 182);
            this.MinimumSize = new System.Drawing.Size(816, 182);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord bug demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doBlockMainThread;
        private System.Windows.Forms.Label label1;
    }
}

