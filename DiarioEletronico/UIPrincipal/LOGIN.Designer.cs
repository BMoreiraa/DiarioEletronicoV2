
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
            this.SAIR = new System.Windows.Forms.Button();
            this.logoPbx = new System.Windows.Forms.PictureBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.logar = new System.Windows.Forms.Button();
            this.cBxServidorBanco = new System.Windows.Forms.ComboBox();
            this.Servidor = new System.Windows.Forms.Label();
            this.MostraSenha = new System.Windows.Forms.Button();
            this.salvarString = new System.Windows.Forms.Button();
            this.AddServidor = new System.Windows.Forms.Button();
            this.panelConteiner = new System.Windows.Forms.Panel();
            this.logoopbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPbx)).BeginInit();
            this.panelConteiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoopbx)).BeginInit();
            this.SuspendLayout();
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
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.Location = new System.Drawing.Point(562, 221);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(316, 26);
            this.textBoxSenha.TabIndex = 10;
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
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(562, 154);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(316, 26);
            this.textBoxUsuario.TabIndex = 8;
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
            this.logar.Location = new System.Drawing.Point(563, 373);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(121, 35);
            this.logar.TabIndex = 11;
            this.logar.Text = "Logar";
            this.logar.UseVisualStyleBackColor = true;
            this.logar.Click += new System.EventHandler(this.logar_Click);
            // 
            // cBxServidorBanco
            // 
            this.cBxServidorBanco.BackColor = System.Drawing.Color.White;
            this.cBxServidorBanco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBxServidorBanco.FormattingEnabled = true;
            this.cBxServidorBanco.Location = new System.Drawing.Point(563, 296);
            this.cBxServidorBanco.Name = "cBxServidorBanco";
            this.cBxServidorBanco.Size = new System.Drawing.Size(315, 26);
            this.cBxServidorBanco.TabIndex = 12;
            this.cBxServidorBanco.SelectedIndexChanged += new System.EventHandler(this.cBxServidorBanco_SelectedIndexChanged);
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
            this.MostraSenha.Location = new System.Drawing.Point(854, 223);
            this.MostraSenha.Name = "MostraSenha";
            this.MostraSenha.Size = new System.Drawing.Size(22, 22);
            this.MostraSenha.TabIndex = 14;
            this.MostraSenha.UseVisualStyleBackColor = false;
            // 
            // salvarString
            // 
            this.salvarString.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.salvarString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarString.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarString.Location = new System.Drawing.Point(714, 373);
            this.salvarString.Name = "salvarString";
            this.salvarString.Size = new System.Drawing.Size(112, 35);
            this.salvarString.TabIndex = 15;
            this.salvarString.Text = "SalvarString";
            this.salvarString.UseVisualStyleBackColor = true;
            this.salvarString.Click += new System.EventHandler(this.salvarString_Click);
            // 
            // AddServidor
            // 
            this.AddServidor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.AddServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServidor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddServidor.Location = new System.Drawing.Point(650, 439);
            this.AddServidor.Name = "AddServidor";
            this.AddServidor.Size = new System.Drawing.Size(112, 35);
            this.AddServidor.TabIndex = 16;
            this.AddServidor.Text = "AddServidor";
            this.AddServidor.UseVisualStyleBackColor = true;
            this.AddServidor.Click += new System.EventHandler(this.AddServidor_Click);
            // 
            // panelConteiner
            // 
            this.panelConteiner.BackColor = System.Drawing.Color.White;
            this.panelConteiner.Controls.Add(this.logoopbx);
            this.panelConteiner.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConteiner.Location = new System.Drawing.Point(0, 0);
            this.panelConteiner.Name = "panelConteiner";
            this.panelConteiner.Size = new System.Drawing.Size(500, 500);
            this.panelConteiner.TabIndex = 17;
            // 
            // logoopbx
            // 
            this.logoopbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.logoopbx.Location = new System.Drawing.Point(0, 0);
            this.logoopbx.Name = "logoopbx";
            this.logoopbx.Size = new System.Drawing.Size(500, 500);
            this.logoopbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoopbx.TabIndex = 0;
            this.logoopbx.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelConteiner);
            this.Controls.Add(this.AddServidor);
            this.Controls.Add(this.salvarString);
            this.Controls.Add(this.MostraSenha);
            this.Controls.Add(this.Servidor);
            this.Controls.Add(this.cBxServidorBanco);
            this.Controls.Add(this.logar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.logoPbx);
            this.Controls.Add(this.SAIR);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPbx)).EndInit();
            this.panelConteiner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoopbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SAIR;
        private System.Windows.Forms.PictureBox logoPbx;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button logar;
        private System.Windows.Forms.ComboBox cBxServidorBanco;
        private System.Windows.Forms.Label Servidor;
        private System.Windows.Forms.Button MostraSenha;
        private System.Windows.Forms.Button salvarString;
        private System.Windows.Forms.Button AddServidor;
        private System.Windows.Forms.Panel panelConteiner;
        private System.Windows.Forms.PictureBox logoopbx;
    }
}

