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
using System.Reflection;

namespace PrimaryEducationSystem.Study.Lessons.PartOne
{
    public partial class MainPartOne : UserControl
    {
        string lessonName;
        public MainPartOne()
        {
            InitializeComponent();
            idealPageSize = new Size(this.Width, this.Height);
        }

        private Size idealPageSize;

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Compare the current window to the ideal dimensions.
            double heightRatio = this.ActualHeight / idealPageSize.Height;
            double widthRatio = this.ActualWidth / idealPageSize.Width;

            // Create the transform.
            ScaleTransform scale = new ScaleTransform();

            // Determine the smallest dimension.
            // This preserves the aspect ratio.
            if (heightRatio < widthRatio)
            {
                scale.ScaleX = heightRatio;
                scale.ScaleY = heightRatio;
            }
            else
            {
                scale.ScaleX = widthRatio;
                scale.ScaleY = widthRatio;
            }

            // Apply the transform.
            this.RenderTransform = scale;
        }

        private void note_img_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            note_ST.Begin();
        }

        private void note_img_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            note_ST.Stop();
        }

        //private void link_Music_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    BitmapImage img = new BitmapImage(new Uri("./Images/note_dis.png",UriKind.Relative));
        //    if(audio.IsMuted==false)
        //    {
        //        audio.IsMuted=true;
        //        note_img.Source=img;
        //    }
        //    else
        //    {
        //        audio.IsMuted=false;
        //        note_img.Source=new BitmapImage(new Uri("./Images/note_en.png",UriKind.Relative));
        //    }
        //}
        //------------------------------------------------
        private void Load_Control(string name)
        {
            Type type = this.GetType();
            Assembly assembly = type.Assembly;
            UserControl newPage = (UserControl)assembly.CreateInstance(
                "PESLessonHome" + ".Lession_" + name);

            // Show the page.
            container.Child = newPage;
        }
        //-----------------------------------------------
        private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            lessonName = this.lesson_TextBlock.Text;
            string name = lessonName.Substring(lessonName.IndexOf(" ") + 1, lessonName.Length - lessonName.IndexOf(" ") - 1);
            Load_Control(name);


        }

        private void prev_Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            lessonName = this.lesson_TextBlock.Text;
            string name = lessonName.Substring(lessonName.IndexOf(" ") + 1, lessonName.Length - lessonName.IndexOf(" ") - 1);
            int control = int.Parse(name);
            if (control > 1)
            {
                this.lesson_TextBlock.Text = "Bài " + (control - 1).ToString();
                Load_Control((control - 1).ToString());
            }
        }

        private void next_Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            lessonName = this.lesson_TextBlock.Text;
            string name = lessonName.Substring(lessonName.IndexOf(" ") + 1, lessonName.Length - lessonName.IndexOf(" ") - 1);
            int control = int.Parse(name);
            if (control <= 34)
            {
                this.lesson_TextBlock.Text = "Bài " + (control + 1).ToString();
                Load_Control((control + 1).ToString());
            }
        }

    }
}
