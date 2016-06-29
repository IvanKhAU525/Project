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
        int counter;
        public Watch()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {

            switch(counter)
            {
                case 0:
                    sec_a_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    break;
                case 1:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.White;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    break;
                case 2:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.White;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_a_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    break;
                case 3:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.White;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    break;
                case 4:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.White;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    break;
                case 5:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.White;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    break;
                case 6:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.White;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    sec_a_.Fill = Brushes.Yellow;
                    break;
                case 7:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.White;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    break;
                case 8:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.White;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_e_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    sec_a_.Fill = Brushes.Yellow;
                    break;
                case 9:
                    sec_a_.Fill = sec_b_.Fill = sec_c_.Fill = sec_d_.Fill = sec_e_.Fill = sec_f_.Fill = sec_g_.Fill = Brushes.White;
                    sec_c_.Fill = Brushes.Yellow;
                    sec_b_.Fill = Brushes.Yellow;
                    sec_d_.Fill = Brushes.Yellow;
                    sec_f_.Fill = Brushes.Yellow;
                    sec_g_.Fill = Brushes.Yellow;
                    break;
            }
            counter++;
        }

        private void startclock()
        {
           /* DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start(); */
        }

        private void tickevent(object sender, EventArgs e)
        {
            
        }
    }
}
