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

namespace _2DColumnChart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Item> Items { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Items = new List<Item>()
            {
                // test 01
                //new Item(){Header= "Item1", Value = 266},
                //new Item(){Header= "Item2", Value = 133},
                //new Item(){Header= "Item3", Value = 222},
                //new Item(){Header= "Item4", Value = 366},
                //new Item(){Header= "Item5", Value = 111},
                //new Item(){Header= "Item6", Value = 377},
                //new Item(){Header= "Item7", Value = 444},
                //new Item(){Header= "Item8", Value = 366},
                //new Item(){Header= "Item9", Value = 288},
                //new Item(){Header= "Item10", Value = 455},

                // test 02
                //new Item(){Header= "Item1", Value = 166},
                //new Item(){Header= "Item2", Value = 433},
                //new Item(){Header= "Item3", Value = 322},
                //new Item(){Header= "Item4", Value = 166},
                //new Item(){Header= "Item5", Value = 21},
                //new Item(){Header= "Item6", Value = 277},
                //new Item(){Header= "Item7", Value = 44},
                //new Item(){Header= "Item8", Value = 166},
                //new Item(){Header= "Item9", Value = 288},
                //new Item(){Header= "Item10", Value = 55},

                // test 03
                //new Item(){Header= "Item1", Value = 66},
                //new Item(){Header= "Item2", Value = 300},
                //new Item(){Header= "Item3", Value = 122},
                //new Item(){Header= "Item4", Value = 200},
                //new Item(){Header= "Item5", Value = 411},
                //new Item(){Header= "Item6", Value = 377},
                //new Item(){Header= "Item7", Value = 144},
                //new Item(){Header= "Item8", Value = 366},
                //new Item(){Header= "Item9", Value = 288},
                //new Item(){Header= "Item10", Value = 155},

                // test 04
                new Item(){Header= "Item1", Value = 101},
                new Item(){Header= "Item2", Value = 208},
                new Item(){Header= "Item3", Value = 75},
                new Item(){Header= "Item4", Value = 135},
                new Item(){Header= "Item5", Value = 300},
                new Item(){Header= "Item6", Value = 400},
                new Item(){Header= "Item7", Value = 360},
                new Item(){Header= "Item8", Value = 499},
                new Item(){Header= "Item9", Value = 233},
                new Item(){Header= "Item10", Value = 122},
            };

            Paint();
        }

        private void Paint()
        {
            try
            {
                float chartWidth = 1200, chartHeight = 700, axisMargin = 100, yAxisInterval = 100,
                    blockWidth = 70, blockMargin = 25;
                mainCanvas.Width = chartWidth;
                mainCanvas.Height = chartHeight;

                Point yAxisEndPoint = new Point(axisMargin, axisMargin);
                Point origin = new Point(axisMargin, chartHeight - axisMargin);
                Point xAxisEndPoint = new Point(chartWidth - axisMargin, chartHeight - axisMargin);

                // for illustration
                //Ellipse yAxisEndPointEllipse = new Ellipse()
                //{
                //    Fill = Brushes.Red,
                //    Width = 10,
                //    Height = 10,
                //};
                //mainCanvas.Children.Add(yAxisEndPointEllipse);
                //Canvas.SetLeft(yAxisEndPointEllipse, yAxisEndPoint.X - 5);
                //Canvas.SetTop(yAxisEndPointEllipse, yAxisEndPoint.Y - 5);

                //Ellipse originEllipse = new Ellipse()
                //{
                //    Fill = Brushes.Red,
                //    Width = 10,
                //    Height = 10,
                //};
                //mainCanvas.Children.Add(originEllipse);
                //Canvas.SetLeft(originEllipse, origin.X - 5);
                //Canvas.SetTop(originEllipse, origin.Y - 5);

                //Ellipse xAxisEndPointEllipse = new Ellipse()
                //{
                //    Fill = Brushes.Blue,
                //    Width = 10,
                //    Height = 10,
                //};
                //mainCanvas.Children.Add(xAxisEndPointEllipse);
                //Canvas.SetLeft(xAxisEndPointEllipse, xAxisEndPoint.X - 5);
                //Canvas.SetTop(xAxisEndPointEllipse, xAxisEndPoint.Y - 5);

                //Line yAxisStartLine = new Line()
                //{
                //    Stroke = Brushes.LightGray,
                //    StrokeThickness = 1,
                //    X1 = yAxisEndPoint.X,
                //    Y1 = yAxisEndPoint.Y,
                //    X2 = origin.X,
                //    Y2 = origin.Y,
                //};
                //mainCanvas.Children.Add(yAxisStartLine);

                //Line yAxisEndLine = new Line()
                //{
                //    Stroke = Brushes.LightGray,
                //    StrokeThickness = 1,
                //    X1 = xAxisEndPoint.X,
                //    Y1 = xAxisEndPoint.Y,
                //    X2 = xAxisEndPoint.X,
                //    Y2 = yAxisEndPoint.Y,
                //};
                //mainCanvas.Children.Add(yAxisEndLine);


                double yValue = 0;
                var yAxisValue = origin.Y;
                while (yAxisValue >= yAxisEndPoint.Y)
                {
                    // for illustration
                    //Ellipse lEllipse = new Ellipse()
                    //{
                    //    Fill = Brushes.Red,
                    //    Width = 10,
                    //    Height = 10,
                    //};

                    //Ellipse rEllipse = new Ellipse()
                    //{
                    //    Fill = Brushes.Blue,
                    //    Width = 10,
                    //    Height = 10,
                    //};

                    //mainCanvas.Children.Add(lEllipse);
                    //mainCanvas.Children.Add(rEllipse);

                    //Canvas.SetLeft(lEllipse, origin.X - 5);
                    //Canvas.SetTop(lEllipse, yAxisValue - 5);

                    //Canvas.SetLeft(rEllipse, xAxisEndPoint.X - 5);
                    //Canvas.SetTop(rEllipse, yAxisValue - 5);



                    Line yLine = new Line()
                    {
                        Stroke = Brushes.LightGray,
                        StrokeThickness = 1,
                        X1 = origin.X,
                        Y1 = yAxisValue,
                        X2 = xAxisEndPoint.X,
                        Y2 = yAxisValue,
                    };
                    mainCanvas.Children.Add(yLine);

                    TextBlock yAxisTextBlock = new TextBlock()
                    {
                        Text = $"{yValue}",
                        Foreground = Brushes.Black,
                        FontSize = 16,
                    };
                    mainCanvas.Children.Add(yAxisTextBlock);

                    Canvas.SetLeft(yAxisTextBlock, origin.X - 35);
                    Canvas.SetTop(yAxisTextBlock, yAxisValue - 12.5);


                    yAxisValue -= yAxisInterval;
                    yValue += yAxisInterval;
                }


                var margin = origin.X + blockMargin;
                foreach (var item in Items)
                {
                    Rectangle block = new Rectangle()
                    {
                        Fill = Brushes.Gold,
                        //Fill = new SolidColorBrush(Color.FromRgb(68, 114, 196)),
                        Width = blockWidth,
                        Height = item.Value,
                    };

                    mainCanvas.Children.Add(block);
                    Canvas.SetLeft(block, margin);
                    Canvas.SetTop(block, origin.Y - block.Height);

                    TextBlock blockHeader = new TextBlock()
                    {
                        Text = item.Header,
                        FontSize = 16,
                        Foreground = Brushes.Black,
                    };
                    mainCanvas.Children.Add(blockHeader);
                    Canvas.SetLeft(blockHeader, margin + 10);
                    Canvas.SetTop(blockHeader, origin.Y + 5);


                    margin += (blockWidth + blockMargin);
                }
            }
            catch (Exception exception)
            {
            }
        }
    }

    public class Item
    {
        public string Header { get; set; }
        public int Value { get; set; }
    }
}
