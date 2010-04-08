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
	public partial class Home : UserControl
	{
		public Home()
		{
			// Required to initialize variables
			InitializeComponent();
			SmokeAm.Begin();
			FerrisWheelAm.Begin();
		}

		private void House_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
            HouseAm.Begin();
            Childrentgame.Begin();
		}

		private void Tortoise_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			// TODO: Add event handler implementation here.
            TortoiseAm.Begin();
		}

	}
}