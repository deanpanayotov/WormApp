using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WormApp
{
    public partial class MainPage : PhoneApplicationPage
    {

        private int wormThickness;
        private double halfWormThikness;
        private Color wormColor;
        private int refreshRate = 50; //in milliseconds
        private Random random;
        private Line line;
        private Ellipse ellipse;
        private double currentX;
        private double currentY;
        private int maximumDistance = 30;
        private int maximumCount = 50;
        private int borderThickness = 5;
        private System.Windows.Threading.DispatcherTimer dt;
        private bool slidersInitialized = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            //inital values
            wormThickness = 8;
            halfWormThikness = wormThickness / 2;
            wormColor = Colors.Purple;
            random = new Random();
            currentX = random.Next((int) LayoutRoot.ActualWidth);
            currentY = random.Next((int) LayoutRoot.ActualHeight);

            dt = new System.Windows.Threading.DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 0, refreshRate);
            dt.Tick += new EventHandler(dt_Tick);
            dt.Start();
        }

        void dt_Tick(object sender, EventArgs e)
        {
            double newX = currentX + random.Next(maximumDistance * (-1), maximumDistance);
            double newY = currentY + random.Next(maximumDistance * (-1), maximumDistance);
            if (newX < 0)
            {
                newX = borderThickness;
            }
            if (newX > LayoutRoot.ActualWidth)
            {
                newX = LayoutRoot.ActualWidth - borderThickness; 
            }
            if (newY < 0)
            {
                newY = borderThickness;
            }
            if (newY > LayoutRoot.ActualHeight)
            {
                newY = LayoutRoot.ActualHeight - borderThickness;
            }
            line = new Line()
            {
                X1 = currentX,
                Y1 = currentY,
                X2 = newX,
                Y2 = newY
            };
            currentX = newX;
            currentY = newY;
            line.Stroke = new SolidColorBrush(wormColor);
            line.StrokeThickness = wormThickness;

            Ellipse ellipse = new Ellipse();
            ellipse.Width = wormThickness;
            ellipse.Height = wormThickness;
            ellipse.Fill = new SolidColorBrush(wormColor);
            ellipse.Margin = new Thickness(currentX - halfWormThikness, currentY - halfWormThikness, 0, 0);
            drawingCanvas.Children.Add(line);
            drawingCanvas.Children.Add(ellipse);
            if (drawingCanvas.Children.Count > maximumCount)
            {
                drawingCanvas.Children.RemoveAt(0);
                drawingCanvas.Children.RemoveAt(0);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            drawingCanvas.Children.Clear();
            currentX = random.Next((int)LayoutRoot.ActualWidth);
            currentY = random.Next((int)LayoutRoot.ActualHeight);
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            if (SettingsPanel.Visibility == Visibility.Visible)
            {
                SettingsPanel.Visibility = Visibility.Collapsed;
                slidersInitialized = false;
            }
            else
            {
                SettingsPanel.Visibility = Visibility.Visible;
                slRed.Value = wormColor.R;
                slGreen.Value = wormColor.G;
                slBlue.Value = wormColor.B;
                slThickness.Value = wormThickness;
                slSpeed.Value = 200 - refreshRate;
                slDistance.Value = maximumDistance;
                slidersInitialized = true;
            }
        }

        private void slRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slRed == null || !slidersInitialized)
            {
                return;
            }
            createNewColor();
        }

        private void slGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slGreen == null || !slidersInitialized)
            {
                return;
            }
            createNewColor();
        }

        private void slBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slBlue == null || !slidersInitialized)
            {
                return;
            }
            createNewColor();
        }

        private void slThickness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slThickness == null)
            {
                return;
            }
            wormThickness = (int) e.NewValue;
            halfWormThikness = wormThickness / 2;
        }

        private void slSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slSpeed == null)
            {
                return;
            }
            refreshRate = (int) (200 - e.NewValue);
            if (dt != null)
            {
                dt.Interval = new TimeSpan(0, 0, 0, 0, refreshRate);
            }
        }

        private void slDistance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slDistance == null)
            {
                return;
            }
            maximumDistance = (int) e.NewValue;
        }

        private void createNewColor()
        {
            wormColor = Color.FromArgb(255, (byte)slRed.Value, (byte)slGreen.Value, (byte)slBlue.Value);
        }
    }
}