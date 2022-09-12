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
            fundoPBX.ImageLocation = Environment.CurrentDirectory + @"\Imagens\ImagemLongin.png";
            logoPbx.ImageLocation = Environment.CurrentDirectory + @"\Imagens\senai_logo.png";
        }

        private void SAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
