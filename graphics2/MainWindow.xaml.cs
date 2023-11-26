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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace graphics2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Ellipse o;
        double x, y;
        double R = 80;
            private void cmRun(object sender, RoutedEventArgs e)
            {
                o = new Ellipse();
                o.Width = 2 * R;
                o.Height = 2 * R;
                o.Fill = Brushes.Red;
                o.Stroke = Brushes.Black;
                o.StrokeThickness = 15;

                x = 0;
                y = Grafic.Height / 2.0 - R;
                o.Margin = new Thickness(x, y, 0, 0);
                Grafic.Children.Add(o);


                Timer = new DispatcherTimer();// создаем таймер
                Timer.Tick += new EventHandler(onTick); // связывание функции, чтобы она выполнялась по таймеру
                Timer.Interval = new TimeSpan(0, 0, 0, 0, 1); // интервал
                Timer.Start();
            }
            DispatcherTimer Timer;
            double dx = 4;

        private void cmClick(object sender, RoutedEventArgs e)
        {
            Grafic.Children.Clear();
        }

        void onTick(object sender, EventArgs e)
            {
                if ((x > Grafic.Width - 2 * R) || (x < 0))
                {
                    dx = -dx;
                }
                x += dx;
                o.Margin = new Thickness(x, y, 0, 0);
            }
        }
    }

