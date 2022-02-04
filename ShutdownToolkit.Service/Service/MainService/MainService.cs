using ShutdownToolkit.Domain.Enums;
using ShutdownToolkit.Domain.Factory;
using ShutdownToolkit.Domain.Global;
using ShutdownToolkit.Service.Service.LogService;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownToolkit.Service.Service.MainService
{
    public class MainService
    {
        #region ..:: Auxiliar Methods ::..

        /// <summary>
        /// Enable just numbers in the textbox
        /// </summary>
        /// <param name="e">The key press event args</param>
        public void JustNumbers(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Write the log of the form event (start/close)
        /// </summary>
        /// <param name="type">The type of event of the forms</param>
        public void WriteFormLog(int type)
        {
            switch (type)
            {
                case (int)FormLogActionsEnum.Initialized: Log.WriteLog("The system was Initialized."); break;
                case (int)FormLogActionsEnum.Closed: Log.WriteLog("The system was Closed."); break;
                default: Log.WriteLog("A wrong type was informed."); break;
            }

        }

        public void SetRadioButtonValue(RadioButton radioButton)
        {
            Properties.RadioButton = radioButton;
        }

        private int GetAction()
        {
            switch (Properties.RadioButton.Name)
            {
                case "rbShutdown": Properties.Action = (int)ShutdownActionEnum.Shutdown; break;
                case "rbRestart": Properties.Action = (int)ShutdownActionEnum.Restart; break;
                case "rbLogoff": Properties.Action = (int)ShutdownActionEnum.Logoff; break;
                case "rbSleep": Properties.Action = (int)ShutdownActionEnum.Sleep; break;
            }

            return Properties.Action;
        }

        /// <summary>
        /// Instantiates the timespan object
        /// </summary>
        /// <param name="textBox"></param>
        private void InstantiateTimeSpan(TextBox[] textBox, bool is_default_value)
        {
            if (Properties.TimeSpan.TotalSeconds <= 0 || is_default_value)
            {
                Properties.TimeSpan = new TimeSpan(hours: Convert.ToInt32(textBox[(int)TextBoxEnum.Hours].Text),
                                         minutes: Convert.ToInt32(textBox[(int)TextBoxEnum.Minutes].Text),
                                         seconds: Convert.ToInt32(textBox[(int)TextBoxEnum.Seconds].Text));
            }
            else
            {
                Properties.TimeSpan = Properties.AuxTimeSpan;

            }
        }

        /// <summary>
        /// Validates if the textbox value is null or empty
        /// </summary>
        public void ValidateTextboxes()
        {
            if (string.IsNullOrEmpty(Properties.TextBox[(int)TextBoxEnum.Hours].Text))
                Properties.TextBox[(int)TextBoxEnum.Hours].Text = Properties.Hours.ToString();

            if (string.IsNullOrEmpty(Properties.TextBox[(int)TextBoxEnum.Minutes].Text))
                Properties.TextBox[(int)TextBoxEnum.Minutes].Text = Properties.Minutes.ToString();

            if (string.IsNullOrEmpty(Properties.TextBox[(int)TextBoxEnum.Seconds].Text))
                Properties.TextBox[(int)TextBoxEnum.Seconds].Text = Properties.Seconds.ToString();
        }

        private void PerformTimerTick(ref Timer timer, ref Label label, ref RadioButton radioButton, int action)
        {
            Properties.TimeSpan = Properties.TimeSpan.Subtract(TimeSpan.FromSeconds(1));
            Properties.AuxTimeSpan = Properties.TimeSpan;

            label.Text = Properties.TimeSpan.ToString(@"hh\:mm\:ss");

            if (Properties.TimeSpan.TotalSeconds <= 0)
            {
                timer.Stop();

                try
                {
                    Log.WriteLog($"Performming the action.");

                    PerformShutdown(radioButton: ref radioButton,
                                    action: action);
                }
                catch (Exception ex)
                {
                    Log.WriteLog($"Something went wrong: {ex.Message}");
                }

            }
        }

        /// <summary>
        /// Starts the timer
        /// </summary>
        /// <param name="timer"></param>
        private void StartTimer(ref Timer timer, ref RadioButton radioButton, ref Label label, int action)
        {
            timer.Start();

            PerformTimerTick(timer: ref timer,
                             label: ref label,
                             radioButton: ref radioButton,
                             action: action);

            Log.WriteLog("The sequence has been initialized.");
        }

        /// <summary>
        /// Checks if the timer value is 0
        /// </summary>
        /// <param name="timer"></param>
        /// <returns></returns>
        private bool CanPerformShutdownAction(int timer)
        {
            return timer <= 0;
        }

        /// <summary>
        /// Performs the shutdown action
        /// </summary>
        /// <param name="radioButton"></param>
        /// <param name="action"></param>
        private void PerformShutdown(ref RadioButton radioButton, int action)
        {
            if (radioButton.Checked)
            {
                var performShutdown = new PerformShutdown();
                performShutdown.DoShutdown(action);
            }
        }

        public TextBox[] PopulateTextBoxArray(ref TextBox txtHours, ref TextBox txtMinutes, ref TextBox txtSeconds)
        {
            Properties.TextBox = new TextBox[3];

            Properties.TextBox[(int)TextBoxEnum.Hours] = txtHours;
            Properties.TextBox[(int)TextBoxEnum.Minutes] = txtMinutes;
            Properties.TextBox[(int)TextBoxEnum.Seconds] = txtSeconds;

            return Properties.TextBox;
        }

        /// <summary>
        /// Executes the necessary treatments to perform the shutdown action
        /// </summary>
        /// <param name="timer"></param>
        /// <param name="radioButton"></param>
        /// <param name="action">the action to be execute</param>
        public void ExecuteTreatments(ref Timer timer, ref RadioButton radioButton, ref Label label)
        {
            ValidateTextboxes();

            InstantiateTimeSpan(textBox: Properties.TextBox,
                                is_default_value: label.Text == "00:00:00");

            StartTimer(timer: ref timer,
                       radioButton: ref radioButton,
                       label: ref label,
                       action: GetAction());

            if (CanPerformShutdownAction(timer.Interval))
            {
                PerformShutdown(radioButton: ref radioButton,
                                action: GetAction());
            }
        }

        /// <summary>
        /// Start the browser on my github profile
        /// </summary>
        public async void ShowGithubProfile()
        {
            await Task.Run(() => Process.Start(Properties.GithubProfile));
        }

        #endregion
    }
}
