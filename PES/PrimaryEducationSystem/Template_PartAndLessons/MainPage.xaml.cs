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
using System.Windows.Browser;
using Template_PartAndLessons.DemoCode;
using System.Windows.Media.Imaging;
using System.Text;

namespace Template_PartAndLessons
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
			Collapsed();

        }

        public string GetURL()
        {
            StringBuilder t = new StringBuilder();
            t.Append("http://");
            t.Append(HtmlPage.Document.DocumentUri.Host);
            t.Append(":");
            t.Append(HtmlPage.Document.DocumentUri.Port);
            t.Append("/");
            return t.ToString();

        }

        private void btnprev_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Nut_Lui_ST.Begin();
        }

        private void btnprev_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Nut_Lui_ST.Stop();
        }

        private void btnNext_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Nut_Toi_ST.Begin();
        }

        private void btnNext_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Nut_Toi_ST.Stop();
        }

        private void home_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Home_ST.Begin();
        }

        private void home_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Home_ST.Stop();
        }

        private void PageLoad_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            //Ong_ST.Begin();
            Sun_ST.Begin();
            May_ST.Begin();
            //this.loa.Source = new BitmapImage(new Uri("./Images/loa.png", UriKind.Relative));
            media.Play();
        }

        private void image_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Book1_ST.Begin();
        }

        private void image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Book1_ST.Stop();
        }

        private void image2_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Book2_ST.Begin();
        }

        private void image2_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Book2_ST.Stop();
        }

        private void image1_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Book3_ST.Begin();
        }

        private void image1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Book3_ST.Stop();
        }

        private void image3_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Book4_ST.Begin();
        }

        private void image3_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Book4_ST.Stop();
        }


        private void book1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
        void On_GetLink(object sender, GetLinkCompletedEventArgs e)
        {
            HtmlPage.Window.Navigate(new Uri(e.Result + "OneClass/MathLesson"));// + "/dfd"));
        }


        private void loa_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            BitmapImage img = new BitmapImage(new Uri("./Images/note_dis.png", UriKind.Relative));
            if (media.IsMuted)
            {
                this.loa.Source = new BitmapImage(new Uri("./Images/note_en.png", UriKind.Relative));
                media.IsMuted = false;
            }
            else
            {
                this.loa.Source = img;
                media.IsMuted = true;
            }

            //loa.Source = new bit"";
        }

        private void link_Home_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            HtmlPage.Window.Navigate(new Uri(GetURL() + "Default.aspx"));
            //DemoClient demo1 = new DemoClient();
            //demo1.GetLinkCompleted += On_GetDefault_Link;
            //demo1.GetLinkAsync();
        }

        void On_GetDefault_Link(object sender, GetLinkCompletedEventArgs e)
        {
            //HtmlPage.Window.Navigate(new Uri(e.Result + @"/Default.aspx"));
            
        }

        private void link_Home_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void loa_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	note_ST.Begin();
        }

        private void loa_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	note_ST.Stop();
        }

		private void Collapsed()
		{
			image_P2.Visibility = Visibility.Collapsed;
			image_P3.Visibility = Visibility.Collapsed;
			image_P4.Visibility = Visibility.Collapsed;
		}
		
        private void Button_Right_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (image_P4.Visibility == 0)
            {
                image_P4.Visibility = Visibility.Collapsed;
                image_P1.Visibility = Visibility.Visible;
                return;
            }
            if (image_P3.Visibility == 0)
            {
                image_P3.Visibility = Visibility.Collapsed;
                image_P4.Visibility = Visibility.Visible;
            }
            if (image_P2.Visibility == 0)
            {
                image_P2.Visibility = Visibility.Collapsed;
                image_P3.Visibility = Visibility.Visible;
            }
            if (image_P1.Visibility == 0)
            {
                image_P1.Visibility = Visibility.Collapsed;
                image_P2.Visibility = Visibility.Visible;
            }

        }

        private void Button_Left_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (image_P1.Visibility == 0)
            {
                image_P1.Visibility = Visibility.Collapsed;
                image_P4.Visibility = Visibility.Visible;
                return;
            }
            if (image_P2.Visibility == 0)
            {
                image_P2.Visibility = Visibility.Collapsed;
                image_P1.Visibility = Visibility.Visible;
            }
            if (image_P3.Visibility == 0)
            {
                image_P3.Visibility = Visibility.Collapsed;
                image_P2.Visibility = Visibility.Visible;
            }
            if (image_P4.Visibility == 0)
            {
                image_P4.Visibility = Visibility.Collapsed;
                image_P3.Visibility = Visibility.Visible;
            }
        }

        private void image_P1_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_P1.Begin();
            
        }

        private void image_P1_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_P1.Stop();
        }

        private void image_P1_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// Show Part one's lesson.
			//DemoCode.DemoClient demo1 = new DemoClient();
            //demo1.GetLinkCompleted += On_GetLink;
            //demo1.GetLinkAsync();
            HtmlPage.Window.Navigate(new Uri(GetURL() + "OneClass/MathLesson"));
        }

        private void image_P2_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_P2.Begin();
        }

        private void image_P2_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_P2.Stop();
        }

        private void image_P2_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Show Part two's lesson.
        }

        private void image_P3_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_P3.Begin();
        }

        private void image_P3_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_P3.Stop();
        }

        private void image_P3_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// Show Part three's lesson
        }

        private void image_P4_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_P4.Begin();
        }

        private void image_P4_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_P4.Stop();
        }

        private void image_P4_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Show Part four's lesson
        }

    }
}
