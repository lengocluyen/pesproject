using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PrimaryEducationSystem.Study.Home
{
	public partial class HomeLop01 : UserControl
	{
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
		}

        private void StateWall()
        {
            TarofficeAm.Begin();
            Dragonfly1.Begin();
            DragonFly2Am.Begin();
            Dragonfly3Am.Begin();
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

	}
}