using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string cronometro;
        private Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
            cronometro = "";
            stopwatch = new Stopwatch();
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(00, 00, 00, 00, (int)
                stopwatch.ElapsedMilliseconds);

            var hour = ts.Hours;
            var minute = ts.Minutes;
            var second = ts.Seconds;
            var microsecond = ts.Milliseconds;

            cronometro = $"{hour}:{minute}:{second}:{microsecond}";
            lblcronometro.Text = cronometro;
        }


        private void inicio_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            tmrTimer.Enabled = true;

        }

        private void detener_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void resetear_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            tmrTimer.Enabled = false;
            cronometro = "00:00:00:00";
            lblcronometro.Text = cronometro;
        }

        private void lblcronometro_Click(object sender, EventArgs e)
        {

        }
    }
}
