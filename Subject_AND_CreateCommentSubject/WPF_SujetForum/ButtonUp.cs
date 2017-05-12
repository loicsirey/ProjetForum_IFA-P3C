using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPF_SujetForum
{
    class ButtonUp : Button
    {
        public ButtonUp()
        {
            /*this.Template = new ControlTemplate(typeof(Button));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            Template.VisualTree = grid;

            PathGeometry pathGeometry = new PathGeometry();

            pathGeometry.FillRule = FillRule.Nonzero;

            PathFigure pathFigure = new PathFigure();

            pathFigure.StartPoint = new Point(0,100);

            pathFigure.IsClosed = true;

            pathGeometry.Figures.Add(pathFigure);

            
            PolyLineSegment lineSegment1 = new PolyLineSegment();

            lineSegment1.Points.Add(new Point(0, 100));
            lineSegment1.Points.Add(new Point(50, 50));
            lineSegment1.Points.Add(new Point(100, 100));
            lineSegment1.Points.Add(new Point(0, 100));

            pathFigure.Segments.Add(lineSegment1);


            Path path = new Path();

            path.Stretch = Stretch.Fill;

            path.StrokeLineJoin = PenLineJoin.Miter;

            path.Stroke = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            path.Fill = new SolidColorBrush(Color.FromRgb(170, 87, 170));

            path.StrokeThickness = 2;

            path.Data = pathGeometry;

            grid.SetValue(Grid.)
            Content = path;*/
            Loaded += ButtonUp_Loaded;
            Click += ButtonUp_Click;
            
        }

        private void ButtonUp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("UP");
        }

        private void ButtonUp_Loaded(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string template =
                "<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' TargetType=\"Button\">" +
"<Grid Margin=\"0,0,-33,0\">" +
"<Grid.RowDefinitions>" +
"<RowDefinition Height=\"Auto\"/>" +
"<RowDefinition/>" +
"</Grid.RowDefinitions>" +
"<Path Stroke=\"Black\"  StrokeThickness=\"2\" Fill=\"Gray\" Grid.Row=\"1\" Margin=\"0,0,31.731,0\" Stretch=\"Fill\">" +
"<Path.Data>" +
"<PathGeometry>" +
"<PathGeometry.Figures>" +
"<PathFigureCollection>" +
"<PathFigure StartPoint=\"0,100\">" +
"<PathFigure.Segments>" +
"<PathSegmentCollection>" +
"<PolyLineSegment Points=\"0,100 50,0 100,100 0,100\" />" +
"</PathSegmentCollection>" +
"</PathFigure.Segments>" +
"</PathFigure>" +
"</PathFigureCollection>" +
"</PathGeometry.Figures>" +
"<PathGeometry.Transform>" +
"<ScaleTransform ScaleX=\"{Binding ActualWidth, ElementName=polylineCanvas}\" ScaleY=\"{Binding ActualHeight, ElementName=polylineCanvas}\"/>" +
"</PathGeometry.Transform>" +
"</PathGeometry>" +
"</Path.Data>" +
"</Path>" +
"</Grid>" +
"</ControlTemplate>";
            button.Template = (ControlTemplate)XamlReader.Parse(template);
        }
    }
}
