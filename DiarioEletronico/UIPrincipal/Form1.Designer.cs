
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.logar = new System.Windows.Forms.Button();
            this.cBxServidorBanco = new System.Windows.Forms.ComboBox();
            this.Servidor = new System.Windows.Forms.Label();
            this.MostraSenha = new System.Windows.Forms.Button();
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(562, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 26);
            this.textBox2.TabIndex = 10;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(565, 200);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(57, 18);
            this.Senha.TabIndex = 9;
            this.Senha.Text = "Senha:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(562, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 26);
            this.textBox1.TabIndex = 8;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(565, 133);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(66, 18);
            this.Usuario.TabIndex = 7;
            this.Usuario.Text = "Usuário:";
            // 
            // logar
            // 
            this.logar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logar.Location = new System.Drawing.Point(694, 354);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(121, 35);
            this.logar.TabIndex = 11;
            this.logar.Text = "Logar";
            this.logar.UseVisualStyleBackColor = true;
            // 
            // cBxServidorBanco
            // 
            this.cBxServidorBanco.BackColor = System.Drawing.Color.White;
            this.cBxServidorBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxServidorBanco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBxServidorBanco.FormattingEnabled = true;
            this.cBxServidorBanco.Items.AddRange(new object[] {
            "Servidor 01B",
            "Servidor 02B",
            "Servidor 03H",
            "Servidor 04H",
            "Servidor 05D",
            "Servidor 06F"});
            this.cBxServidorBanco.Location = new System.Drawing.Point(563, 296);
            this.cBxServidorBanco.Name = "cBxServidorBanco";
            this.cBxServidorBanco.Size = new System.Drawing.Size(315, 26);
            this.cBxServidorBanco.TabIndex = 12;
            // 
            // Servidor
            // 
            this.Servidor.AutoSize = true;
            this.Servidor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servidor.Location = new System.Drawing.Point(565, 273);
            this.Servidor.Name = "Servidor";
            this.Servidor.Size = new System.Drawing.Size(158, 18);
            this.Servidor.TabIndex = 13;
            this.Servidor.Text = "Selecione o Servidor:";
            // 
            // MostraSenha
            // 
            this.MostraSenha.BackColor = System.Drawing.Color.Black;
            this.MostraSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MostraSenha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MostraSenha.FlatAppearance.BorderSize = 0;
            this.MostraSenha.Location = new System.Drawing.Point(855, 223);
            this.MostraSenha.Name = "MostraSenha";
            this.MostraSenha.Size = new System.Drawing.Size(22, 22);
            this.MostraSenha.TabIndex = 14;
            this.MostraSenha.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.MostraSenha);
            this.Controls.Add(this.Servidor);
            this.Controls.Add(this.cBxServidorBanco);
            this.Controls.Add(this.logar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Usuario);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fundoPBX;
        private System.Windows.Forms.Button SAIR;
        private System.Windows.Forms.PictureBox logoPbx;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button logar;
        private System.Windows.Forms.ComboBox cBxServidorBanco;
        private System.Windows.Forms.Label Servidor;
        private System.Windows.Forms.Button MostraSenha;
    }
}

