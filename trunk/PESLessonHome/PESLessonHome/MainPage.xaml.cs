using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PESLessonHome
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			// Required to initialize variables
			InitializeComponent();
            idealPageSize = new Size(this.Width, this.Height);
		}
        private Size idealPageSize;

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Compare the current window to the ideal dimensions.
            double heightRatio = this.ActualHeight / idealPageSize.Height;
            double widthRatio = this.ActualWidth / idealPageSize.Width;

            // Create the transform.
            ScaleTransform scale = new ScaleTransform();

            // Determine the smallest dimension.
            // This preserves the aspect ratio.
            if (heightRatio < widthRatio)
            {
                scale.ScaleX = heightRatio;
                scale.ScaleY = heightRatio;
            }
            else
            {
                scale.ScaleX = widthRatio;
                scale.ScaleY = widthRatio;
            }

            // Apply the transform.
            this.RenderTransform = scale;
        }

	}
}