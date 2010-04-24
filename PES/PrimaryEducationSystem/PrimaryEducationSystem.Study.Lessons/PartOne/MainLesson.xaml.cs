﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace PESLessonHome
{
	public partial class MainLesson : UserControl
	{
		public MainLesson()
		{
			// Required to initialize variables
			InitializeComponent();
            
		}
        private void HyperlinkButton_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            book_ST.Begin();
        }

        private void down_link_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            down_ST.Begin();
        }

        private void up_link_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            up_ST.Begin();
        }

        private void btap_link_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	btap_ST.Begin();
        }

        private void link_music_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	music_ST.Begin();
        }

        private void book_link_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	book_ST.Stop();
        }

        private void btap_link_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	btap_ST.Stop();
        }

        private void link_music_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	music_ST.Stop();
        }

        private void link_music_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            BitmapImage imag_mute = new BitmapImage(new Uri("./Images/loa_mute.png", UriKind.Relative));
            //image_m = image_music.Source;
            if (!audio1.IsMuted)
            {
                audio1.IsMuted = true;
                image_music.Source = imag_mute;                
            }
            else
            {
                audio1.IsMuted = false;
                image_music.Source = new BitmapImage(new Uri("./Images/loa.png", UriKind.Relative));
            }           
        }
	}
}