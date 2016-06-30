using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ProjectApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            startclock();
        }

        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            label.Content = DateTime.Now.ToString(@"hh\:mm\:ss");
        }

        private void button_calendar_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation wid = new DoubleAnimation();
            DoubleAnimation heig = new DoubleAnimation();
            //.From = 327.162;
            //heig.From = 300;
            wid.To = 350;
            heig.To = 330;
            wid.Duration = TimeSpan.FromSeconds(0.5);
            heig.Duration = TimeSpan.FromSeconds(0.5);
            button_calendar.BeginAnimation(Button.WidthProperty, wid);
            button_calendar.BeginAnimation(Button.HeightProperty, heig);
        }

        private void button_watch_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation wid = new DoubleAnimation();
            DoubleAnimation heig = new DoubleAnimation();
            //.From = 327.162;
            //heig.From = 300;
            wid.To = 350;
            heig.To = 330;
            wid.Duration = TimeSpan.FromSeconds(0.5);
            heig.Duration = TimeSpan.FromSeconds(0.5);
            button_watch.BeginAnimation(Button.WidthProperty, wid);
            button_watch.BeginAnimation(Button.HeightProperty, heig);
        }

        private void button_watch_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation wid = new DoubleAnimation();
            DoubleAnimation heig = new DoubleAnimation();
            //wid.From = 327.162;
            //heig.From = 300;
            wid.To = 327.162;
            heig.To = 300;
            wid.Duration = TimeSpan.FromSeconds(0.5);
            heig.Duration = TimeSpan.FromSeconds(0.5);
            button_watch.BeginAnimation(Button.WidthProperty, wid);
            button_watch.BeginAnimation(Button.HeightProperty, heig);
        }

        private void button_calendar_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation wid = new DoubleAnimation();
            DoubleAnimation heig = new DoubleAnimation();
            //wid.From = 327.162;
            //heig.From = 300;
            wid.To = 327.162;
            heig.To = 300;
            wid.Duration = TimeSpan.FromSeconds(0.5);
            heig.Duration = TimeSpan.FromSeconds(0.5);
            button_calendar.BeginAnimation(Button.WidthProperty, wid);
            button_calendar.BeginAnimation(Button.HeightProperty, heig);
        }

        private void button_watch_Click(object sender, RoutedEventArgs e)
        {
            Watch f = new Watch();
            f.Show();
        }

        private void button_calendar_Click(object sender, RoutedEventArgs e)
        {
            Calendar f = new Calendar();
            f.Show();
        }
    }
}
