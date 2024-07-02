using System;
using System.Windows.Forms;

namespace discord_screenshare_not_responding {
    public partial class MainWindow : Form {

        const long TIME_DELAY = 60;

        public MainWindow() {
            InitializeComponent();
        }

        private void doBlockMainThread_Click(object sender, EventArgs e) {

            long startTime = DateTime.UtcNow.Ticks;
            long currentTime = -1;

            while (true) {
                currentTime = DateTime.UtcNow.Ticks;
                if ( currentTime - startTime > ( TimeSpan.TicksPerSecond * TIME_DELAY)) {
                    break;
                }
            }
        }
    }
}
