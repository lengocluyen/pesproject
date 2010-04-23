﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 3.0.40624.0
// 
namespace Template_PartAndLessons.DemoCode {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DemoCode.IDemo")]
    public interface IDemo {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDemo/DoWork", ReplyAction="http://tempuri.org/IDemo/DoWorkResponse")]
        System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState);
        
        void EndDoWork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDemo/GetLink", ReplyAction="http://tempuri.org/IDemo/GetLinkResponse")]
        System.IAsyncResult BeginGetLink(System.AsyncCallback callback, object asyncState);
        
        string EndGetLink(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IDemoChannel : Template_PartAndLessons.DemoCode.IDemo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class GetLinkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetLinkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class DemoClient : System.ServiceModel.ClientBase<Template_PartAndLessons.DemoCode.IDemo>, Template_PartAndLessons.DemoCode.IDemo {
        
        private BeginOperationDelegate onBeginDoWorkDelegate;
        
        private EndOperationDelegate onEndDoWorkDelegate;
        
        private System.Threading.SendOrPostCallback onDoWorkCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetLinkDelegate;
        
        private EndOperationDelegate onEndGetLinkDelegate;
        
        private System.Threading.SendOrPostCallback onGetLinkCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public DemoClient() {
        }
        
        public DemoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DoWorkCompleted;
        
        public event System.EventHandler<GetLinkCompletedEventArgs> GetLinkCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Template_PartAndLessons.DemoCode.IDemo.BeginDoWork(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDoWork(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void Template_PartAndLessons.DemoCode.IDemo.EndDoWork(System.IAsyncResult result) {
            base.Channel.EndDoWork(result);
        }
        
        private System.IAsyncResult OnBeginDoWork(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Template_PartAndLessons.DemoCode.IDemo)(this)).BeginDoWork(callback, asyncState);
        }
        
        private object[] OnEndDoWork(System.IAsyncResult result) {
            ((Template_PartAndLessons.DemoCode.IDemo)(this)).EndDoWork(result);
            return null;
        }
        
        private void OnDoWorkCompleted(object state) {
            if ((this.DoWorkCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DoWorkCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DoWorkAsync() {
            this.DoWorkAsync(null);
        }
        
        public void DoWorkAsync(object userState) {
            if ((this.onBeginDoWorkDelegate == null)) {
                this.onBeginDoWorkDelegate = new BeginOperationDelegate(this.OnBeginDoWork);
            }
            if ((this.onEndDoWorkDelegate == null)) {
                this.onEndDoWorkDelegate = new EndOperationDelegate(this.OnEndDoWork);
            }
            if ((this.onDoWorkCompletedDelegate == null)) {
                this.onDoWorkCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDoWorkCompleted);
            }
            base.InvokeAsync(this.onBeginDoWorkDelegate, null, this.onEndDoWorkDelegate, this.onDoWorkCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Template_PartAndLessons.DemoCode.IDemo.BeginGetLink(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetLink(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string Template_PartAndLessons.DemoCode.IDemo.EndGetLink(System.IAsyncResult result) {
            return base.Channel.EndGetLink(result);
        }
        
        private System.IAsyncResult OnBeginGetLink(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Template_PartAndLessons.DemoCode.IDemo)(this)).BeginGetLink(callback, asyncState);
        }
        
        private object[] OnEndGetLink(System.IAsyncResult result) {
            string retVal = ((Template_PartAndLessons.DemoCode.IDemo)(this)).EndGetLink(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetLinkCompleted(object state) {
            if ((this.GetLinkCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetLinkCompleted(this, new GetLinkCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetLinkAsync() {
            this.GetLinkAsync(null);
        }
        
        public void GetLinkAsync(object userState) {
            if ((this.onBeginGetLinkDelegate == null)) {
                this.onBeginGetLinkDelegate = new BeginOperationDelegate(this.OnBeginGetLink);
            }
            if ((this.onEndGetLinkDelegate == null)) {
                this.onEndGetLinkDelegate = new EndOperationDelegate(this.OnEndGetLink);
            }
            if ((this.onGetLinkCompletedDelegate == null)) {
                this.onGetLinkCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetLinkCompleted);
            }
            base.InvokeAsync(this.onBeginGetLinkDelegate, null, this.onEndGetLinkDelegate, this.onGetLinkCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Template_PartAndLessons.DemoCode.IDemo CreateChannel() {
            return new DemoClientChannel(this);
        }
        
        private class DemoClientChannel : ChannelBase<Template_PartAndLessons.DemoCode.IDemo>, Template_PartAndLessons.DemoCode.IDemo {
            
            public DemoClientChannel(System.ServiceModel.ClientBase<Template_PartAndLessons.DemoCode.IDemo> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("DoWork", _args, callback, asyncState);
                return _result;
            }
            
            public void EndDoWork(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("DoWork", _args, result);
            }
            
            public System.IAsyncResult BeginGetLink(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetLink", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetLink(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetLink", _args, result)));
                return _result;
            }
        }
    }
}
