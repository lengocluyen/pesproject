using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Interactivity;

namespace PESLesson_1
{
	public partial class MainLesson : UserControl
	{
		public MainLesson()
		{
			// Required to initialize variables
			InitializeComponent();
			this.AddEvent();
		}
		public void AddEvent()
		{
			StoryboardGaConChayRa.Begin();
		}
		
		 
	}
}