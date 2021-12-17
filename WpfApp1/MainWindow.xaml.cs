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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Student> array = new List<Student>();
            array.Add(new Student(){Name = "张三",Sex = "男"});
            array.Add(new Student() { Name = "张4", Sex = "女" });
            array.Add(new Student() { Name = "张5", Sex = "男" });
            array.Add(new Student() { Name = "张6", Sex = "男" });
            array.Add(new Student() { Name = "张7", Sex = "女" });
            array.Add(new Student() { Name = "张8", Sex = "男" });
            com.ItemsSource = array;
            lb.ItemsSource = array;
        }
    }

    public class Student
    {
        public string  Name { get; set; }

        public string  Sex { get; set; }
    }
}
