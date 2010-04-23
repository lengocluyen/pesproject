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

namespace PrimaryEducationSystem.Families.Home
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

		private void EmptyTextBlook()
		{
			this.TextBlook_Menu.Text = "";
		}
		
         private void image_Present_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_Presents.Begin();
			this.TextBlook_Menu.Text = "Hộp quà tặng cho bé.";
        }

        private void image_Present_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_Presents.Stop();
            this.Storyboard_BtPresents.Stop();
			EmptyTextBlook();
        }

        private void image_Present_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Storyboard_BtPresents.Begin();
        }

        private void image_News_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_Info.Begin();
			this.TextBlook_Menu.Text = "Chia sẽ kinh nghiệm nuôi dạy con.";
        }

        private void image_News_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_Info.Stop();
            this.Storyboard_BtNews.Stop();
			EmptyTextBlook();
        }

        private void image_News_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Storyboard_BtNews.Begin();
        }

        private void image_Links_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_Candle.Begin();
			this.TextBlook_Menu.Text = "Gia đình bạn bè.";
        }

        private void image_Links_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_Candle.Stop();
            this.Storyboard_BtCandle.Stop();
			EmptyTextBlook();
        }

        private void image_Links_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Storyboard_BtCandle.Begin();
        }

        private void image_MailBox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_MailBox.Begin();
			this.TextBlook_Menu.Text = "Hộp thư gia đình.";
        }

        private void image_MailBox_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_MailBox.Stop();
            this.Storyboard_BTMailBox.Stop();
			EmptyTextBlook();
        }

        private void image_MailBox_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Storyboard_BTMailBox.Begin();
        }

        private void Image_Broom_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
			this.Storyboard_RideBroom.Begin();
        }

        private void Image_Broom_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
			this.Storyboard_RideBroom.Stop();
        }

        private void Image_Moon_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
			this.Storyboard_TheMoon.Begin();
        }

        private void Image_Moon_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
			this.Storyboard_TheMoon.Stop();
        }

        private void Button_Home_Click(object sender, System.Windows.RoutedEventArgs e)
        {
			//Hiển thị trang gia đình ở sự kiện này
        }

        private void Button_Home_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
			this.Storyboard_Home.Stop();
			EmptyTextBlook();
        }

        private void Button_Home_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
			this.TextBlook_Menu.Text = "Trở lại trang chủ.";
			this.Storyboard_Home.Begin();
        }
    }
}
