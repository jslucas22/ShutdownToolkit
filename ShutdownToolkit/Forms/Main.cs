using ShutdownToolkit.Service.Service.MainService;
using System;
using System.Windows.Forms;

namespace ShutdownToolkit.Forms
{
    public partial class frmMain : Form
    {
        #region ..:: Variables ::..

        private MainService _mainService;
        private RadioButton _radioButton;

        #endregion

        #region ..:: Constructor ::..

        public frmMain()
        {
            InitializeComponent();

            InstantiateObjects();
        }

        #endregion

        #region ..:: Auxiliar Methods ::..

        private void InstantiateObjects()
        {
            _mainService = new MainService();
        }        

        private RadioButton GetSelectedRadioButton()
        {
            if (rbShutdown.Checked)
                _radioButton = rbShutdown;                

            else if (rbRestart.Checked)
                _radioButton = rbRestart;

            else if (rbLogoff.Checked)
                _radioButton = rbLogoff;

            else
                _radioButton = rbSleep;

            return _radioButton;
        }

        private void StartSequence()
        {            

            GetSelectedRadioButton();

            _mainService.SetRadioButtonValue(_radioButton);            

            _mainService.PopulateTextBoxArray(txtHours: ref txtHours,
                                              txtMinutes: ref txtMinutes,
                                              txtSeconds: ref txtSeconds);

            tmrDelay.Start();
        }

        private void JustNumbers(KeyPressEventArgs e)
        {
            _mainService.JustNumbers(e);
        }

        private void StopSequece()
        {
            tmrDelay.Stop();

            lblTimeLeft.Text = "00:00:00";
        }

        private void ShowAbout()
        {
            new About().ShowDialog();
        }

        private void WriteLog(int log_type)
        {
            var service = new MainService();
            service.WriteFormLog(log_type);
        }


        #endregion

        #region ..:: Events ::..

        private void btnStart_Click(object sender, EventArgs e) => StartSequence();

        private void txtHours_KeyPress(object sender, KeyPressEventArgs e) => JustNumbers(e);

        private void txtMinutes_KeyPress(object sender, KeyPressEventArgs e) => JustNumbers(e);

        private void txtSeconds_KeyPress(object sender, KeyPressEventArgs e) => JustNumbers(e);

        private void tmrDelay_Tick(object sender, EventArgs e) => _mainService.ExecuteTreatments(timer: ref tmrDelay,
                                                                                                 radioButton: ref _radioButton,
                                                                                                 label: ref lblTimeLeft);
        private void btnParar_Click(object sender, EventArgs e) => StopSequece();

        private void picAbout_Click(object sender, EventArgs e) => ShowAbout();

        private void frmMain_Load(object sender, EventArgs e) => WriteLog(log_type: 0);

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) => WriteLog(log_type: 1);

        #endregion
    }
}
