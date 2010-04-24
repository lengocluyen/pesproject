﻿using System;
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
using System.Windows.Media.Imaging;

namespace PESLessonHome
{
    public partial class Lession_5 : UserControl
    {
        public Lession_5()
        {
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
        int index;
        private void link_start_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            lession5_ST1.Begin();
            //up_link.Visibility = Visibility.Visible;
            down_link.Visibility = Visibility.Visible;
        }

        private void down_link_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (index == 1)
            {

                index = 2;
                lession5_ST1.Stop();
                lession5_ST2.Begin();
                up_link.Visibility = Visibility.Visible;
                down_link.Visibility = Visibility.Visible;

            }
            else
            {
                if (index == 2)
                {
                    index = 3;
                    // phan 3 cua bai
                    lession5_ST2.Stop();
                    lession5_ST3.Begin();
                    up_link.Visibility = Visibility.Visible;
                    down_link.Visibility = Visibility.Collapsed;
                }
                else
                {
                    up_link.Visibility = Visibility.Collapsed;
                    down_link.Visibility = Visibility.Visible;
                }
            }
        }

        private void up_link_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
            if (index == 3)
            {

                index = 2;
                //phan 2 cua
                lession5_ST3.Stop();
                lession5_ST2.Begin();
                up_link.Visibility = Visibility.Visible;
                down_link.Visibility = Visibility.Visible;

            }
            else
            {
                if (index == 2)
                {

                    index = 1;
                    // phan 1 cua bai
                    lession5_ST2.Stop();
                    lession5_ST1.Begin();
                    up_link.Visibility = Visibility.Collapsed;
                    down_link.Visibility = Visibility.Visible;
                }
                else
                {
                    up_link.Visibility = Visibility.Visible;
                    down_link.Visibility = Visibility.Collapsed;

                }
            }
        }

        private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            up_ST.Begin();
            down_ST.Begin();
            index = 1;
            start_ST.Begin();
            up_link.Visibility = Visibility.Collapsed;
            down_link.Visibility = Visibility.Collapsed;
        }
    }
}
