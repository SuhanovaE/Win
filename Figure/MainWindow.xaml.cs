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
using Figure.Classes;
using Rectangle = Figure.Classes.Rectangle;

namespace Figure
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

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double r = double.Parse(txtR.Text);
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            double x = double.Parse(txtX.Text); 
            double y = double.Parse(txtY.Text);
            Circle circle;
            Triangle triangle;
            Rectangle rectangle;
            circle = new Circle(r);
            double s = circle.Square();
            triangle = new Triangle(a,b,c);
            double s1 = triangle.Square();
            double p1 = triangle.Perimeter();
            rectangle = new Rectangle(x,y);
            double s2 = rectangle.Square();
            double p2 = rectangle.Perimeter();
            lstResult.Items.Add($"Площадь круга равен {s}");
            lstResult.Items.Add($"Площадь треугольника равен {s1}");
            lstResult.Items.Add($"Периметр треугольника равен {p1}");
            lstResult.Items.Add($"Площадь прямоугольника равен {s2}");
            lstResult.Items.Add($"периметр прямоугольника равен {p2}");

        }
    }
}
