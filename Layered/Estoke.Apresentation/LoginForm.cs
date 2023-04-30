using Estoke.BusinessLogic.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoke.Apresentation
{
    public partial class LoginForm : Form
    {
        #region Attributes Privates

        #endregion

        #region Constructs
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void authenticate()
        {
            try
            {
                string emailContent = txtEmail.Text;
                if(string.IsNullOrWhiteSpace(emailContent) )
                {
                    MessageBox.Show("Você precisa digitar o e-mail");
                    txtEmail.Focus();
                    return;
                }

                string senhaContent = txtSenha.Text;
                if(string.IsNullOrWhiteSpace(senhaContent) )
                {
                    MessageBox.Show("Você precisa digitar sua senha.");
                    txtSenha.Focus(); 
                    return;
                }

                AuthenticationService authenticationService = AuthenticationService.Instance;
                if(authenticationService?.Authenticate(emailContent, senhaContent) ?? false)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Não foi possível fazer Login.");
                }
            }
            catch (Exception problem)
            {
                throw problem;
            }
        }
        #endregion

        #region Events
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                authenticate();
            }
            catch (Exception problem)
            {
                MessageBox.Show(problem.Message);
            }
        }
        #endregion

    }
}
