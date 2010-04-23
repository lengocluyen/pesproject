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
using System.Windows.Navigation;
using PrimaryEducationSystem.Study.Home.PESServices;
using System.Text;
using System.Windows.Browser;
namespace PrimaryEducationSystem.Study.Home
{
    public partial class Home : Page
    {
        //PESServicesClient service = new PESServicesClient();
        
        public Home()
        {
            
			
            InitializeComponent();
            CollsapedChooseClass();
            Collsaped();
            Beginstoryboard();
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

        /// <summary>
        /// Không cho đối tượng chooseclass hiển thị
        /// </summary>
        private void CollsapedChooseClass()
        {
            this.Choose_Class.Visibility = Visibility.Collapsed;
        }

        private void Collsaped()
        {
            this.DangKy.Visibility = Visibility.Collapsed;
            this.DangNhap.Visibility = Visibility.Collapsed;
            this.ThongTin.Visibility = Visibility.Collapsed;
            this.GioiThieu.Visibility = Visibility.Collapsed;
        }
        /// <summary>
        /// Những đối tượng Stroryboard chạy mãi mãi
        /// </summary>
        private void Beginstoryboard()
        {
            this.Storyboard_Frisse.Begin();
            this.Storyboard_DoubleChildrent.Begin();
			this.Storyboard_ChimBay.Begin();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }


        private void The_School_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Choose_Class.Visibility = Visibility.Visible;
            this.Storyboard_ChooseClass.Begin();
        }

        private void The_School_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            CollsapedChooseClass();
			this.Storyboard_School_House.Stop();
        }

        private void Families_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            this.Storyboard_House.Begin();
        }

        private void Park_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            this.Storyboard_ParkDoor.Begin();
            this.Storyboard_ParkYard.Begin();
        }

        private void Tortoise_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            this.Storyboard_Tortoise1.Begin();
            this.Storyboard_Tortoise2.Begin();
            this.Storyboard_Tortoi3.Begin();
        }

        private void Bus_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // TODO: Add event handler implementation here.
            this.Storyboard_Bus.Begin();
        }

        private void Button_Lop02_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
        }

        private void Button_Lop01_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //// TODO: Add event handler implementation here.
            //Button navigationButton = sender as Button;
            //String goToPage = navigationButton.Tag.ToString();
            //this.MainControl.Visibility = Visibility.Collapsed;
            //this.MainContent.Navigate(new Uri(goToPage, UriKind.Relative));
			
            MainPage rootPage = Application.Current.RootVisual as MainPage;
            rootPage.LayoutRoot.Children.Add(new HomeLop01());
        }

        private void Button_Lop03_Click(object sender, System.Windows.RoutedEventArgs e)
        {
			
        }

        private void MainContent_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {

        }

        private void Families_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
			this.Storyboard_House.Stop();
        }

        private void Park_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
			this.Storyboard_ParkDoor.Stop();
        }

        private void Bt_DangKy_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.DangKy.Visibility = Visibility.Visible;
            this.Storyboard_DangKy.Begin();
        }

        private void Bt_DangKy_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_DangKy.Stop();
            Collsaped();
        }

        private void Bt_DangKy_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //form dang ky
        }

        private void Bt_DangNhap_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.DangNhap.Visibility = Visibility.Visible;
            this.Storyboard_DangNhap.Begin();
        }

        private void Bt_DangNhap_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_DangNhap.Stop();
            Collsaped();
        }

        private void Bt_DangNhap_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //form dang nhap
        }

        private void Bt_ThongTin_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.ThongTin.Visibility = Visibility.Visible;
            this.Storyboard_ThongTin.Begin();
        }

        private void Bt_ThongTin_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_ThongTin.Stop();
            Collsaped();
        }

        private void Bt_ThongTin_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //from thong tin
        }

        private void Bt_Gioithieu_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.GioiThieu.Visibility = Visibility.Visible;
            this.Storyboard_GioiThieu.Begin();
        }

        private void Bt_Gioithieu_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Storyboard_GioiThieu.Stop();
            Collsaped();
        }

        private void Bt_Gioithieu_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //form gioi thieu
        }

        private void Families_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            HtmlPage.Window.Navigate(new Uri(GetURL() + "Families"));
        }

    }
}
