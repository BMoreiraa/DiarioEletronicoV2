using Infra;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            logoopbx.ImageLocation = Environment.CurrentDirectory + @"\Imagens\ImagemLongin.png";
            logoPbx.ImageLocation = Environment.CurrentDirectory + @"\Imagens\senai_logo.png";
        }

        private void SAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salvarString_Click(object sender, EventArgs e)
        {
            UsuarioLogado.conexaoAtual = cBxServidorBanco.Text;
            ArquivoBanco.Gravarbanco(FuncoesGlobais.Base64Encode(Convert.ToString(cBxServidorBanco.Text)));
        }
/*###################################################################################################################################*/
        private void AbrirFormEnPanel(object Formhijo) //formulario sobre formulario
        {
            if (this.panelConteiner.Controls.Count > 0)
                this.panelConteiner.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelConteiner.Controls.Add(fh);
            this.panelConteiner.Tag = fh;
            fh.Show();
        }

        private void AddServidor_Click(object sender, EventArgs e) // abrindo o formulario dentro do painel
        {
            AbrirFormEnPanel(new FormAddServidor());
            logoopbx.Visible = true;                    //quando o formulario for fechado torna a pintureBox visivel
            panelConteiner.Controls.Add(logoopbx);      //add o a pintureBox novamente
        }

/*###################################################################################################################################*/
    }
}
