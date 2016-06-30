using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ProjectApplication
{
    /// <summary>
    /// Логика взаимодействия для Calendar.xaml
    /// </summary>
    public partial class Watch : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int seconds_1, seconds_2, minutes_1, minutes_2, hours_1, hours_2;
        public Watch()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            seconds_1 = DateTime.Now.Second % 10;
            seconds_2 = DateTime.Now.Second / 10;
            minutes_1 = DateTime.Now.Minute % 10;
            minutes_2 = DateTime.Now.Minute / 10;
            hours_1 = DateTime.Now.Hour % 10;
            hours_2 = DateTime.Now.Hour / 10;
            clock__s();
            clock_ss();
            clock__m();
            clock_mm();
            clock__h();
            clock_hh();
        }

        private void clock_hh()
        {
            switch (hours_2)
            {
                case 0:
                    hour_a.Fill = hour_b.Fill = hour_c.Fill = hour_d.Fill = hour_e.Fill = hour_f.Fill = hour_g.Fill = Brushes.Gray;
                    hour_a.Fill = Brushes.Yellow;
                    hour_b.Fill = Brushes.Yellow;
                    hour_c.Fill = Brushes.Yellow;
                    hour_e.Fill = Brushes.Yellow;
                    hour_f.Fill = Brushes.Yellow;
                    hour_g.Fill = Brushes.Yellow;
                    break;
                case 1:
                    hour_a.Fill = hour_b.Fill = hour_c.Fill = hour_d.Fill = hour_e.Fill = hour_f.Fill = hour_g.Fill = Brushes.Gray;
                    hour_g.Fill = Brushes.Yellow;
                    hour_f.Fill = Brushes.Yellow;
                    break;
                case 2:
                    hour_a.Fill = hour_b.Fill = hour_c.Fill = hour_d.Fill = hour_e.Fill = hour_f.Fill = hour_g.Fill = Brushes.Gray;
                    hour_c.Fill = Brushes.Yellow;
                    hour_g.Fill = Brushes.Yellow;
                    hour_d.Fill = Brushes.Yellow;
                    hour_a.Fill = Brushes.Yellow;
                    hour_e.Fill = Brushes.Yellow;
                    break;
            }
        }
        private void clock__h()
        {
            switch (hours_1)
            {
                case 0:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_a_.Fill = Brushes.Yellow;
                    hour_b_.Fill = Brushes.Yellow;
                    hour_c_.Fill = Brushes.Yellow;
                    hour_e_.Fill = Brushes.Yellow;
                    hour_f_.Fill = Brushes.Yellow;
                    hour_g_.Fill = Brushes.Yellow;
                    break;
                case 1:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_g_.Fill = Brushes.Yellow;
                    hour_f_.Fill = Brushes.Yellow;
                    break;
                case 2:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_c_.Fill = Brushes.Yellow;
                    hour_g_.Fill = Brushes.Yellow;
                    hour_d_.Fill = Brushes.Yellow;
                    hour_a_.Fill = Brushes.Yellow;
                    hour_e_.Fill = Brushes.Yellow;
                    break;
                case 3:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_c_.Fill = Brushes.Yellow;
                    hour_g_.Fill = Brushes.Yellow;
                    hour_d_.Fill = Brushes.Yellow;
                    hour_f_.Fill = Brushes.Yellow;
                    hour_e_.Fill = Brushes.Yellow;
                    break;
                case 4:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_b_.Fill = Brushes.Yellow;
                    hour_g_.Fill = Brushes.Yellow;
                    hour_d_.Fill = Brushes.Yellow;
                    hour_f_.Fill = Brushes.Yellow;
                    break;
                case 5:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_c_.Fill = Brushes.Yellow;
                    hour_b_.Fill = Brushes.Yellow;
                    hour_d_.Fill = Brushes.Yellow;
                    hour_f_.Fill = Brushes.Yellow;
                    hour_e_.Fill = Brushes.Yellow;
                    break;
                case 6:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_c_.Fill = Brushes.Yellow;
                    hour_b_.Fill = Brushes.Yellow;
                    hour_d_.Fill = Brushes.Yellow;
                    hour_f_.Fill = Brushes.Yellow;
                    hour_e_.Fill = Brushes.Yellow;
                    hour_a_.Fill = Brushes.Yellow;
                    break;
                case 7:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_c_.Fill = Brushes.Yellow;
                    hour_g_.Fill = Brushes.Yellow;
                    hour_f_.Fill = Brushes.Yellow;
                    break;
                case 8:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_c_.Fill = Brushes.Yellow;
                    hour_b_.Fill = Brushes.Yellow;
                    hour_d_.Fill = Brushes.Yellow;
                    hour_f_.Fill = Brushes.Yellow;
                    hour_e_.Fill = Brushes.Yellow;
                    hour_g_.Fill = Brushes.Yellow;
                    hour_a_.Fill = Brushes.Yellow;
                    break;
                case 9:
                    hour_a_.Fill = hour_b_.Fill = hour_c_.Fill = hour_d_.Fill = hour_e_.Fill = hour_f_.Fill = hour_g_.Fill = Brushes.Gray;
                    hour_c_.Fill = Brushes.Yellow;
                    hour_b_.Fill = Brushes.Yellow;
                    hour_d_.Fill = Brushes.Yellow;
                    hour_f_.Fill = Brushes.Yellow;
                    hour_g_.Fill = Brushes.Yellow;
                    break;
            }
        }

        private void clock_mm()
        {
            switch (minutes_2)
            {
                case 0:
                    min_a.Fill = min_b.Fill = min_c.Fill = min_d.Fill = min_e.Fill = min_f.Fill = min_g.Fill = Brushes.Gray;
                    min_a.Fill = Brushes.Yellow;
                    min_b.Fill = Brushes.Yellow;
                    min_c.Fill = Brushes.Yellow;
                    min_e.Fill = Brushes.Yellow;
                    min_f.Fill = Brushes.Yellow;
                    min_g.Fill = Brushes.Yellow;
                    break;
                case 1:
                    min_a.Fill = min_b.Fill = min_c.Fill = min_d.Fill = min_e.Fill = min_f.Fill = min_g.Fill = Brushes.Gray;
                    min_g.Fill = Brushes.Yellow;
                    min_f.Fill = Brushes.Yellow;
                    break;
                case 2:
                    min_a.Fill = min_b.Fill = min_c.Fill = min_d.Fill = min_e.Fill = min_f.Fill = min_g.Fill = Brushes.Gray;
                    min_c.Fill = Brushes.Yellow;
                    min_g.Fill = Brushes.Yellow;
                    min_d.Fill = Brushes.Yellow;
                    min_a.Fill = Brushes.Yellow;
                    min_e.Fill = Brushes.Yellow;
                    break;
                case 3:
                    min_a.Fill = min_b.Fill = min_c.Fill = min_d.Fill = min_e.Fill = min_f.Fill = min_g.Fill = Brushes.Gray;
                    min_c.Fill = Brushes.Yellow;
                    min_g.Fill = Brushes.Yellow;
                    min_d.Fill = Brushes.Yellow;
                    min_f.Fill = Brushes.Yellow;
                    min_e.Fill = Brushes.Yellow;
                    break;
                case 4:
                    min_a.Fill = min_b.Fill = min_c.Fill = min_d.Fill = min_e.Fill = min_f.Fill = min_g.Fill = Brushes.Gray;
                    min_b.Fill = Brushes.Yellow;
                    min_g.Fill = Brushes.Yellow;
                    min_d.Fill = Brushes.Yellow;
                    min_f.Fill = Brushes.Yellow;
                    break;
                case 5:
                    min_a.Fill = min_b.Fill = min_c.Fill = min_d.Fill = min_e.Fill = min_f.Fill = min_g.Fill = Brushes.Gray;
                    min_c.Fill = Brushes.Yellow;
                    min_b.Fill = Brushes.Yellow;
                    min_d.Fill = Brushes.Yellow;
                    min_f.Fill = Brushes.Yellow;
                    min_e.Fill = Brushes.Yellow;
                    break;
            }
        }
        private void clock__m()
        {
            switch (minutes_1)
            {
                case 0:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_a_.Fill = Brushes.Yellow;
                    min_b_.Fill = Brushes.Yellow;
                    min_c_.Fill = Brushes.Yellow;
                    min_e_.Fill = Brushes.Yellow;
                    min_f_.Fill = Brushes.Yellow;
                    min_g_.Fill = Brushes.Yellow;
                    break;
                case 1:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_g_.Fill = Brushes.Yellow;
                    min_f_.Fill = Brushes.Yellow;
                    break;
                case 2:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_c_.Fill = Brushes.Yellow;
                    min_g_.Fill = Brushes.Yellow;
                    min_d_.Fill = Brushes.Yellow;
                    min_a_.Fill = Brushes.Yellow;
                    min_e_.Fill = Brushes.Yellow;
                    break;
                case 3:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_c_.Fill = Brushes.Yellow;
                    min_g_.Fill = Brushes.Yellow;
                    min_d_.Fill = Brushes.Yellow;
                    min_f_.Fill = Brushes.Yellow;
                    min_e_.Fill = Brushes.Yellow;
                    break;
                case 4:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_b_.Fill = Brushes.Yellow;
                    min_g_.Fill = Brushes.Yellow;
                    min_d_.Fill = Brushes.Yellow;
                    min_f_.Fill = Brushes.Yellow;
                    break;
                case 5:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_c_.Fill = Brushes.Yellow;
                    min_b_.Fill = Brushes.Yellow;
                    min_d_.Fill = Brushes.Yellow;
                    min_f_.Fill = Brushes.Yellow;
                    min_e_.Fill = Brushes.Yellow;
                    break;
                case 6:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_c_.Fill = Brushes.Yellow;
                    min_b_.Fill = Brushes.Yellow;
                    min_d_.Fill = Brushes.Yellow;
                    min_f_.Fill = Brushes.Yellow;
                    min_e_.Fill = Brushes.Yellow;
                    min_a_.Fill = Brushes.Yellow;
                    break;
                case 7:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_c_.Fill = Brushes.Yellow;
                    min_g_.Fill = Brushes.Yellow;
                    min_f_.Fill = Brushes.Yellow;
                    break;
                case 8:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_c_.Fill = Brushes.Yellow;
                    min_b_.Fill = Brushes.Yellow;
                    min_d_.Fill = Brushes.Yellow;
                    min_f_.Fill = Brushes.Yellow;
                    min_e_.Fill = Brushes.Yellow;
                    min_g_.Fill = Brushes.Yellow;
                    min_a_.Fill = Brushes.Yellow;
                    break;
                case 9:
                    min_a_.Fill = min_b_.Fill = min_c_.Fill = min_d_.Fill = min_e_.Fill = min_f_.Fill = min_g_.Fill = Brushes.Gray;
                    min_c_.Fill = Brushes.Yellow;
                    min_b_.Fill = Brushes.Yellow;
                    min_d_.Fill = Brushes.Yellow;
                    min_f_.Fill = Brushes.Yellow;
                    min_g_.Fill = Brushes.Yellow;
                    break;
            }
        }

        private void clock_ss()
        {
            switch (seconds_2)
            {
                case 0:
                    sec_a.Fill = sec_b.Fill = sec_c.Fill = sec_d.Fill = sec_e.Fill = sec_f.Fill = sec_g.Fill = Brushes.Gray;
                    sec_a.Fill = Brushes.Yellow;
                    sec_b.Fill = Brushes.Yellow;
                    sec_c.Fill = Brushes.Yellow;
                    sec_e.Fill = Brushes.Yellow;
                    sec_f.Fill = Brushes.Yellow;
                    sec_g.Fill = Brushes.Yellow;
                    break;
                case 1:
                    sec_a.Fill = sec_b.Fill = sec_c.Fill = sec_d.Fill = sec_e.Fill = sec_f.Fill = sec_g.Fill = Brushes.Gray;
                    sec_g.Fill = Brushes.Yellow;
                    sec_f.Fill = Brushes.Yellow;
                    break;
                case 2:
                    sec_a.Fill = sec_b.Fill = sec_c.Fill = sec_d.Fill = sec_e.Fill = sec_f.Fill = sec_g.Fill = Brushes.Gray;
                    sec_c.Fill = Brushes.Yellow;
                    sec_g.Fill = Brushes.Yellow;
                    sec_d.Fill = Brushes.Yellow;
                    sec_a.Fill = Brushes.Yellow;
                    sec_e.Fill = Brushes.Yellow;
                    break;
                case 3:
                    sec_a.Fill = sec_b.Fill = sec_c.Fill = sec_d.Fill = sec_e.Fill = sec_f.Fill = sec_g.Fill = Brushes.Gray;
                    sec_c.Fill = Brushes.Yellow;
                    sec_g.Fill = Brushes.Yellow;
                    sec_d.Fill = Brushes.Yellow;
                    sec_f.Fill = Brushes.Yellow;
                    sec_e.Fill = Brushes.Yellow;
                    break;
                case 4:
                    sec_a.Fill = sec_b.Fill = sec_c.Fill = sec_d.Fill = sec_e.Fill = sec_f.Fill = sec_g.Fill = Brushes.Gray;
                    sec_b.Fill = Brushes.Yellow;
                    sec_g.Fill = Brushes.Yellow;
                    sec_d.Fill = Brushes.Yellow;
                    sec_f.Fill = Brushes.Yellow;
                    break;
                case 5:
                    sec_a.Fill = sec_b.Fill = sec_c.Fill = sec_d.Fill = sec_e.Fill = sec_f.Fill = sec_g.Fill = Brushes.Gray;
                    sec_c.Fill = Brushes.Yellow;
                    sec_b.Fill = Brushes.Yellow;
                    sec_d.Fill = Brushes.Yellow;
                    sec_f.Fill = Brushes.Yellow;
                    sec_e.Fill = Brushes.Yellow;
                    break;
            }
        }

        private void startclock()
        {
           /* DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start(); */
        }

        private void clock__s()
        {
            switch (seconds_1)
            {
                case 0:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_a_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    break;
                case 1:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    break;
                case 2:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_a_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    break;
                case 3:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    break;
                case 4:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    break;
                case 5:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    break;
                case 6:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    sec_a_.Fill = Brushes.Yellow;
                    break;
                case 7:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    break;
                case 8:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_a_.Fill = Brushes.Yellow;
                    break;
                case 9:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.Gray;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    break;
            }
            seconds_1++;
        }
    }
}
