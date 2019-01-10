using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Enumer em = new Enumer();
            foreach (var item in em)
            {
                
            }

            Type[] types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(Ihuman)))).ToArray();

            for (int i = 0; i < types.Length; i++)
            {
                Action action = new Action(() => { MessageBox.Show("xxx"); });
                Type type = types[i];
               
                EventInfo eventInfo = type.GetEvent("a");
           

               




            }
        }

        private void Ihuman_a()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Man a = new Man();

            a.run();
        }
    }

    public static class NotifyPropertyBaseEx
    {
        public static void SetProperty<T>(this T tvm) where T : Man
        {


        }
    }
}
