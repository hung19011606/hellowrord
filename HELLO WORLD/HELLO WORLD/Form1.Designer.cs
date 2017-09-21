namespace WindowsFormsApplication1
{
    partial class FRMHELLOWORLD
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
            this.LBLHELLOWORLD = new System.Windows.Forms.Label();
            this.BTNSHOW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLHELLOWORLD
            // 
            this.LBLHELLOWORLD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBLHELLOWORLD.AutoSize = true;
            this.LBLHELLOWORLD.Font = new System.Drawing.Font("Segoe Script", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHELLOWORLD.Location = new System.Drawing.Point(101, 142);
            this.LBLHELLOWORLD.Name = "LBLHELLOWORLD";
            this.LBLHELLOWORLD.Size = new System.Drawing.Size(0, 80);
            this.LBLHELLOWORLD.TabIndex = 1;
            this.LBLHELLOWORLD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNSHOW
            // 
            this.BTNSHOW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNSHOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSHOW.ForeColor = System.Drawing.Color.Red;
            this.BTNSHOW.Location = new System.Drawing.Point(188, 430);
            this.BTNSHOW.Name = "BTNSHOW";
            this.BTNSHOW.Size = new System.Drawing.Size(268, 48);
            this.BTNSHOW.TabIndex = 2;
            this.BTNSHOW.Text = "SHOW HELLO WORLD ";
            this.BTNSHOW.UseVisualStyleBackColor = true;
            this.BTNSHOW.Click += new System.EventHandler(this.BTNSHOW_Click);
            // 
            // FRMHELLOWORLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 490);
            this.Controls.Add(this.BTNSHOW);
            this.Controls.Add(this.LBLHELLOWORLD);
            this.MinimumSize = new System.Drawing.Size(660, 500);
            this.Name = "FRMHELLOWORLD";
            this.Text = "HELLOWORLD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLHELLOWORLD;
        private System.Windows.Forms.Button BTNSHOW;
    }
}

