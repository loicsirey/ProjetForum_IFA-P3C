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
    class ButtonDown : Button
    {
        public ButtonDown()
        {
            Loaded += ButtonDown_Loaded;
            Click += ButtonDown_Click;
        }

        private void ButtonDown_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DOWN");
        }

        private void ButtonDown_Loaded(object sender, RoutedEventArgs e)
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
"<PathFigure StartPoint=\"0,0\">" +
"<PathFigure.Segments>" +
"<PathSegmentCollection>" +
"<PolyLineSegment Points=\"0,0 50,100 100,0 0,0\" />" +
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
