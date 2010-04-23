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
using System.Collections;
using System.Text;
namespace PrimaryEducationSystem.Study.Home
{
	public partial class HomeLop01 : UserControl
	{
        //protected PESServices.PESServicesClient service = new PrimaryEducationSystem.Study.Home.PESServices.PESServicesClient();
        //protected string webURL =  HtmlPage.Document.DocumentUri.AbsoluteUri;
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
        public HomeLop01()
		{
			// Required to initialize variables
			InitializeComponent();
            AppCollapsed();
			Collapsed();
            StateWall();

		}

        
		private void Collapsed()
		{
			this.NoteBangChuCai.Visibility = Visibility.Collapsed;
			this.NoteBangTinh.Visibility = Visibility.Collapsed;
			this.NoteTapve.Visibility = Visibility.Collapsed;
			this.NoteThoiKhoaBieu.Visibility = Visibility.Collapsed;
			this.NoteThuVien.Visibility = Visibility.Collapsed;
            this.NoteTapViet.Visibility = Visibility.Collapsed;
			this.BackHome.Visibility = Visibility.Collapsed;

		}

        private void StateWall()
        {
            TarofficeAm.Begin();
            Dragonfly1.Begin();
            DragonFly2Am.Begin();
            Dragonfly3Am.Begin();
            Storyboard_DragonflyTho.Begin();
        }

		private void TiengViet_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			VietNammesBookAm.Begin();
		}

		private void Toan_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
            MathBookAm.Begin();

		}

		private void Toan_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			MathBookAm.Stop();
		}

		private void TiengViet_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			VietNammesBookAm.Stop();
		}

		private void GiaSach_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
            this.NoteThuVien.Visibility = Visibility.Visible;
			BookcaseAm.Begin();
		}

		private void ThoiKhoaBieu_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
            this.NoteThoiKhoaBieu.Visibility = Visibility.Visible;
            TimetableAm.Begin();
			
		}

		private void bangChucai_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
            this.NoteBangChuCai.Visibility = Visibility.Visible;
			WordTableAm.Begin();
		}

		private void TapVe_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
            this.NoteTapve.Visibility = Visibility.Visible;
			PainStudyAm.Begin();
		}

		private void TapViet_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
            this.NoteTapViet.Visibility = Visibility.Visible;
			WritingStudyAm.Begin();
		}

		private void BangTinh_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
            this.NoteBangTinh.Visibility = Visibility.Visible;
			AcounttingTableAm.Begin();
		}

		private void ButtonCanceApp_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            AppCollapsed();
		}

		private void ButtonAlphabet_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Appvisible();
			GridContain.Children.Add(new AlphabetTable());
		}

		private void AppCollapsed()
		{
            GridApplication.Visibility = Visibility.Collapsed;
            BorderApplication.Visibility = Visibility.Collapsed;
		}
        private void Appvisible()
        {
            BorderApplication.Visibility = Visibility.Visible;
            GridApplication.Visibility = Visibility.Visible;
        }

        private void MonToan_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MathBookAm.Stop();
            Collapsed();
        }

        private void BangTinh_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            AcounttingTableAm.Stop();
            Collapsed();
        }

        private void TapVe_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            PainStudyAm.Stop();
            Collapsed();
        }

        private void ThoiKhoaBieu_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            TimetableAm.Stop();
            Collapsed();
        }

        private void TapViet_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            WritingStudyAm.Stop();
            Collapsed();
        }

        private void ButtonAlphabet_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            NoteBangChuCai.Visibility = Visibility.Visible;
            WordTableAm.Begin();
        }

        private void ButtonAlphabet_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            WordTableAm.Stop();
            Collapsed();
        }

        private void GiaSach_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	Collapsed();
        }

        private void TapViet_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        }

        private void MonToan_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            HtmlPage.Window.Navigate(new Uri(GetURL() + "OneClass/Math"));
        }

        private void MonTiengViet_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
			
			MainPage rootPage = Application.Current.RootVisual as MainPage;
            rootPage.LayoutRoot.Children.Add(new Home());
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	this.BackHome.Visibility = Visibility.Visible;
			this.Storyboard_backhome.Begin();
        }

        private void Button_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
			this.Storyboard_backhome.Stop();
			Collapsed();
        }

	}
}