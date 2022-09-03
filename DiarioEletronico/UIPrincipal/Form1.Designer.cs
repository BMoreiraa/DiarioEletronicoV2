
namespace UIPrincipal
{
    partial class Login
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
            this.fundoPBX = new System.Windows.Forms.PictureBox();
            this.SAIR = new System.Windows.Forms.Button();
            this.logoPbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fundoPBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // fundoPBX
            // 
            this.fundoPBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.fundoPBX.Location = new System.Drawing.Point(0, 0);
            this.fundoPBX.Name = "fundoPBX";
            this.fundoPBX.Size = new System.Drawing.Size(500, 500);
            this.fundoPBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundoPBX.TabIndex = 0;
            this.fundoPBX.TabStop = false;
            // 
            // SAIR
            // 
            this.SAIR.BackColor = System.Drawing.Color.Red;
            this.SAIR.ForeColor = System.Drawing.Color.Black;
            this.SAIR.Location = new System.Drawing.Point(958, 7);
            this.SAIR.Name = "SAIR";
            this.SAIR.Size = new System.Drawing.Size(35, 35);
            this.SAIR.TabIndex = 1;
            this.SAIR.UseVisualStyleBackColor = false;
            this.SAIR.Click += new System.EventHandler(this.SAIR_Click);
            // 
            // logoPbx
            // 
            this.logoPbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.logoPbx.Location = new System.Drawing.Point(636, 12);
            this.logoPbx.Name = "logoPbx";
            this.logoPbx.Size = new System.Drawing.Size(209, 52);
            this.logoPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPbx.TabIndex = 2;
            this.logoPbx.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.logoPbx);
            this.Controls.Add(this.SAIR);
            this.Controls.Add(this.fundoPBX);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fundoPBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fundoPBX;
        private System.Windows.Forms.Button SAIR;
        private System.Windows.Forms.PictureBox logoPbx;
    }
}

