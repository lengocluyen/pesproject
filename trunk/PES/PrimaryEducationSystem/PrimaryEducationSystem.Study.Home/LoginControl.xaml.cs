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
using System.Text.RegularExpressions;
using System.Windows.Browser;

namespace Home
{
    public partial class LoginControl : System.Windows.Controls.UserControl
    {
        ////Commons variables
        //protected ITBusServiceReference.ITBusServicesClient home_Service = new Home.ITBusServiceReference.ITBusServicesClient();
        //protected ITBusSVForSession.TBusWSForSessionSoapClient home_Session = new Home.ITBusSVForSession.TBusWSForSessionSoapClient();
        //protected string webURL = ITBusSilverlightCommons.parameters["webURL"];
        //MainPage _parentPage;

        //public LoginControl(MainPage parentPage)
        //{
        //    InitializeComponent();
        //    _parentPage = parentPage;
        //    ShowBox();
        //    AddEvent();
        //}
        //#region -------------Events-----------------
        //private void image_Closed_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    this.Close_MouseLeave_Storyboard.Begin();
        //}

        //private void image_Closed_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    this.Close_MouseEnter_Storyboard.Begin();
        //}

        //private void image_Closed_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    HideBox();
        //}

        //private void img_button_Login_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    this.Storyboard_Login_Hover_.Begin();
        //}

        //private void img_button_Login_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    this.Storyboard_Login_Hover_.Stop();
        //}

        ///*--------------Login-----------------*/

        //private void img_button_Login_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
           
        //}
        //void ShowError(string mss)
        //{
        //    this.lbl_Mess.Text = mss;
        //}
        //#endregion

        //#region/*--Add Event--*/

        //void AddEvent()
        //{
        //    home_Service.GetPupilLoginCompleted += new EventHandler<Home.ITBusServiceReference.GetPupilLoginCompletedEventArgs>(home_Service_GetPupilLoginCompleted);
        //    home_Session.SetPupilLoginIDCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(home_Session_SetPupilLoginIDCompleted);
        //}

        //#endregion

        //#region/*--EventComplete--*/

        //void home_Service_GetPupilLoginCompleted(object sender, Home.ITBusServiceReference.GetPupilLoginCompletedEventArgs e)
        //{
        //    Pupil pupil = e.Result;
        //    if (pupil != null)
        //    {
        //        //Login sucess
        //        ShowError("Đăng nhập thành công !");
        //        home_Session.SetPupilLoginIDAsync(pupil.PupilID);
        //        //Do something at :'home_Session_SetPupilLoginIDCompleted(...)'
        //    }
        //    else
        //    {
        //        ShowError("(*) Tài khoản đăng nhập không đúng. Bạn hãy thử lại !");
        //    }
        //}
        //bool isLog = false;
        //void home_Session_SetPupilLoginIDCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        //{
        //    isLog = true;
        //    HideBox();
        //    HtmlPage.Window.Navigate(new Uri(webURL + "/PreView.aspx"));
        //}
        //#endregion

        //#region   ------------Fuction-------------
        //void HideBox()
        //{
        //    this.HideBox_Storyboard.Begin();
        //    this.HideBox_Storyboard.Completed += new EventHandler(HideBox_Storyboard_Completed);

        //}
        //void HideBox_Storyboard_Completed(object sender, EventArgs e)
        //{
        //    this.rec_Overflow.Visibility = Visibility.Collapsed;
        //    this.Visibility = Visibility.Collapsed;
        //    if (isLog || _parentPage.pupilID > 0)//Đã login hoặc đang thông báo logout
        //    {
        //        _parentPage.LayoutRoot.Children.Clear();
        //        _parentPage.LayoutRoot.Children.Add(new MainPage());//Resfresh MainPage and pupilID is reseted (id ò pupil if login or 0 if logout
        //    }
        //}
        //void ShowBox()
        //{
        //    if (_parentPage.pupilID > 0)//Show logout
        //    {
        //        Canvas_Out.Visibility = Visibility.Visible;
        //        Canvas_Log.Visibility = Visibility.Collapsed;
        //    }
        //    else//Show login
        //    {
        //        Canvas_Out.Visibility = Visibility.Collapsed;
        //        Canvas_Log.Visibility = Visibility.Visible;
        //    }
        //    this.ShowBox_Storyboard.Begin();
        //}

        //private void lbt_Forgotpass_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    HtmlPage.Window.Navigate(new Uri(webURL + "/PupilAccountProfile.aspx?action=forgotpw"));
        //}

        //private void Button_Login_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //                 Regex regx = new Regex(@"^(?:[a-zA-Z0-9_'^&amp;/+-])+(?:\.(?:[a-zA-Z0-9_'^&amp;/+-])+)*@(?:(?:\[?(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?))\.){3}(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\]?)|(?:[a-zA-Z0-9-]+\.)+(?:[a-zA-Z]){2,}\.?)$");
        //    if (this.txt_EmailLogin.Text == String.Empty)
        //    {
        //        ShowError("Bạn hãy nhập email đăng nhập");
        //        return;
        //    }
        //    if (!regx.Match(this.txt_EmailLogin.Text).Success)
        //    {
        //        ShowError("(*) Email không hợp lệ");
        //        return;
        //    }
        //    if (this.txt_PasswordLogin.Password == String.Empty)
        //    {
        //        ShowError("(*) Bạn hãy nhập mật khẩu");
        //        return;
        //    }
        //    ShowError("Hãy đợi trong giây lát...");
        //    //get pupil
        //    home_Service.GetPupilLoginAsync(this.txt_EmailLogin.Text, this.txt_PasswordLogin.Password, true);
        //    //xu ly tiep tai 'home_Service_GetPupilLoginCompleted(...)'

        //}
        //#endregion
    }
}
