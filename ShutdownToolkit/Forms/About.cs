using ShutdownToolkit.Service.Service.MainService;
using System.Windows.Forms;

namespace ShutdownToolkit.Forms
{
    public partial class About : Form
    {
        #region ..:: Constructor ::..

        public About()
        {
            InitializeComponent();
        }

        #endregion

        #region ..:: Auxiliar Methods ::..

        private void ShowGithubProfile()
        {
            var service = new MainService();
            service.ShowGithubProfile();
        }

        #endregion

        #region ..:: Events ::..

        private void picGithubProfile_Click(object sender, System.EventArgs e) => ShowGithubProfile();

        private void linkGithubProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ShowGithubProfile();

        #endregion
    }
}
