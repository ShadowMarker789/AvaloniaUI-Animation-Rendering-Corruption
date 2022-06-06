using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using System;

namespace TestAvaloniaUIAnimation
{
    public partial class MainWindow : Window
    {
        private bool _isFullScreen = false;

        public MainWindow()
        {
            InitializeComponent();

            this.KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object? sender, Avalonia.Input.KeyEventArgs e)
        {
            if (_isFullScreen)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.FullScreen;
            _isFullScreen = !_isFullScreen;
        }

        public void MainWindow_Opened(object sender, EventArgs e)
        {
            var animation = new Animation();
            animation.Duration = TimeSpan.FromSeconds(1.0d);
            animation.FillMode = FillMode.Both;
            animation.IterationCount = IterationCount.Infinite;
            KeyFrame fk = new KeyFrame();
            fk.Setters.Add(new Setter(
                        RotateTransform.AngleProperty,
                        45.0d));
            fk.Cue = new Cue(0.0d);

            KeyFrame fk2 = new KeyFrame();
            fk2.Setters.Add(new Setter(
                        RotateTransform.AngleProperty,
                        0d));
            fk2.Cue = new Cue(0.5d);

            KeyFrame fk3 = new KeyFrame();
            fk3.Setters.Add(new Setter(
                        RotateTransform.AngleProperty,
                        45.0d
                ));
            fk3.Cue = new Cue(1.0d);

            animation.Children.Add(fk);
            animation.Children.Add(fk2);
            animation.Children.Add(fk3);
            TestTextBlock.RenderTransform = new RotateTransform();
            TestTextBlock.RenderTransformOrigin = new Avalonia.RelativePoint(0.5, 0.55, Avalonia.RelativeUnit.Relative);
            animation.RunAsync(TestTextBlock, (IClock)Avalonia.AvaloniaLocator.Current.GetService(typeof(IClock)));
            animation.Easing = new Avalonia.Animation.Easings.SineEaseInOut();
        }
    }
}
