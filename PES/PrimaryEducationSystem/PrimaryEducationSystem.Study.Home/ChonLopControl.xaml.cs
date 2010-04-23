using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Browser;
using System.Reflection;

namespace PrimaryEducationSystem.Study.Home
{
    public partial class ChonLopControl : UserControl
    {
        public ChonLopControl()
        {
            // Required to initialize variables
            InitializeComponent();
        }

        private void Lop01_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            this.Storyboard_Lop01.Begin();
        }

        private void Lop02_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
			this.Storyboard_Lop02.Begin();
        }

        private void Lop03_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.

        }

        private void Lop02_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // TODO: Add event handler implementation here.
        }

        private void Lop01_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // TODO: Add event handler implementation here.

        }

        private void Lop03_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // TODO: Add event handler implementation here.

        }

        private void Lop01_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            //MainPage rootPage = Application.Current.RootVisual as MainPage;
            Home01Class root = Application.Current.RootVisual as Home01Class;
            root = new Home01Class();
            root.IsEnabled = true;
        }

        private void Lop01_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			this.Storyboard_Lop01.Stop();
        }

        private void Lop02_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			this.Storyboard_Lop02.Stop();
        }

        private void Lop03_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			this.Storyboard_Lop03.Stop();
        }
    }
}