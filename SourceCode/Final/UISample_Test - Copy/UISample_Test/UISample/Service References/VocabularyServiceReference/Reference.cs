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
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 3.0.40818.0
// 
namespace UISample.VocabularyServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VOCABULARY", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class VOCABULARY : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int ID_VocField;
        
        private System.Nullable<int> ID_UnitField;
        
        private System.Nullable<int> ID_SkillField;
        
        private string TypeField;
        
        private string EwordField;
        
        private string VwordField;
        
        private string Voice_PathField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Voc {
            get {
                return this.ID_VocField;
            }
            set {
                if ((this.ID_VocField.Equals(value) != true)) {
                    this.ID_VocField = value;
                    this.RaisePropertyChanged("ID_Voc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.Nullable<int> ID_Unit {
            get {
                return this.ID_UnitField;
            }
            set {
                if ((this.ID_UnitField.Equals(value) != true)) {
                    this.ID_UnitField = value;
                    this.RaisePropertyChanged("ID_Unit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.Nullable<int> ID_Skill {
            get {
                return this.ID_SkillField;
            }
            set {
                if ((this.ID_SkillField.Equals(value) != true)) {
                    this.ID_SkillField = value;
                    this.RaisePropertyChanged("ID_Skill");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Eword {
            get {
                return this.EwordField;
            }
            set {
                if ((object.ReferenceEquals(this.EwordField, value) != true)) {
                    this.EwordField = value;
                    this.RaisePropertyChanged("Eword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string Vword {
            get {
                return this.VwordField;
            }
            set {
                if ((object.ReferenceEquals(this.VwordField, value) != true)) {
                    this.VwordField = value;
                    this.RaisePropertyChanged("Vword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public string Voice_Path {
            get {
                return this.Voice_PathField;
            }
            set {
                if ((object.ReferenceEquals(this.Voice_PathField, value) != true)) {
                    this.Voice_PathField = value;
                    this.RaisePropertyChanged("Voice_Path");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VocabularyServiceReference.IVocabularyService")]
    public interface IVocabularyService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IVocabularyService/DoWork", ReplyAction="http://tempuri.org/IVocabularyService/DoWorkResponse")]
        System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState);
        
        void EndDoWork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IVocabularyService/GetVocabulary", ReplyAction="http://tempuri.org/IVocabularyService/GetVocabularyResponse")]
        System.IAsyncResult BeginGetVocabulary(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<UISample.VocabularyServiceReference.VOCABULARY> EndGetVocabulary(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IVocabularyServiceChannel : UISample.VocabularyServiceReference.IVocabularyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class GetVocabularyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetVocabularyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<UISample.VocabularyServiceReference.VOCABULARY> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<UISample.VocabularyServiceReference.VOCABULARY>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class VocabularyServiceClient : System.ServiceModel.ClientBase<UISample.VocabularyServiceReference.IVocabularyService>, UISample.VocabularyServiceReference.IVocabularyService {
        
        private BeginOperationDelegate onBeginDoWorkDelegate;
        
        private EndOperationDelegate onEndDoWorkDelegate;
        
        private System.Threading.SendOrPostCallback onDoWorkCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetVocabularyDelegate;
        
        private EndOperationDelegate onEndGetVocabularyDelegate;
        
        private System.Threading.SendOrPostCallback onGetVocabularyCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public VocabularyServiceClient() {
        }
        
        public VocabularyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VocabularyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VocabularyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VocabularyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<GetVocabularyCompletedEventArgs> GetVocabularyCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult UISample.VocabularyServiceReference.IVocabularyService.BeginDoWork(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDoWork(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void UISample.VocabularyServiceReference.IVocabularyService.EndDoWork(System.IAsyncResult result) {
            base.Channel.EndDoWork(result);
        }
        
        private System.IAsyncResult OnBeginDoWork(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((UISample.VocabularyServiceReference.IVocabularyService)(this)).BeginDoWork(callback, asyncState);
        }
        
        private object[] OnEndDoWork(System.IAsyncResult result) {
            ((UISample.VocabularyServiceReference.IVocabularyService)(this)).EndDoWork(result);
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
        System.IAsyncResult UISample.VocabularyServiceReference.IVocabularyService.BeginGetVocabulary(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetVocabulary(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<UISample.VocabularyServiceReference.VOCABULARY> UISample.VocabularyServiceReference.IVocabularyService.EndGetVocabulary(System.IAsyncResult result) {
            return base.Channel.EndGetVocabulary(result);
        }
        
        private System.IAsyncResult OnBeginGetVocabulary(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((UISample.VocabularyServiceReference.IVocabularyService)(this)).BeginGetVocabulary(callback, asyncState);
        }
        
        private object[] OnEndGetVocabulary(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<UISample.VocabularyServiceReference.VOCABULARY> retVal = ((UISample.VocabularyServiceReference.IVocabularyService)(this)).EndGetVocabulary(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetVocabularyCompleted(object state) {
            if ((this.GetVocabularyCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetVocabularyCompleted(this, new GetVocabularyCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetVocabularyAsync() {
            this.GetVocabularyAsync(null);
        }
        
        public void GetVocabularyAsync(object userState) {
            if ((this.onBeginGetVocabularyDelegate == null)) {
                this.onBeginGetVocabularyDelegate = new BeginOperationDelegate(this.OnBeginGetVocabulary);
            }
            if ((this.onEndGetVocabularyDelegate == null)) {
                this.onEndGetVocabularyDelegate = new EndOperationDelegate(this.OnEndGetVocabulary);
            }
            if ((this.onGetVocabularyCompletedDelegate == null)) {
                this.onGetVocabularyCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetVocabularyCompleted);
            }
            base.InvokeAsync(this.onBeginGetVocabularyDelegate, null, this.onEndGetVocabularyDelegate, this.onGetVocabularyCompletedDelegate, userState);
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
        
        protected override UISample.VocabularyServiceReference.IVocabularyService CreateChannel() {
            return new VocabularyServiceClientChannel(this);
        }
        
        private class VocabularyServiceClientChannel : ChannelBase<UISample.VocabularyServiceReference.IVocabularyService>, UISample.VocabularyServiceReference.IVocabularyService {
            
            public VocabularyServiceClientChannel(System.ServiceModel.ClientBase<UISample.VocabularyServiceReference.IVocabularyService> client) : 
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
            
            public System.IAsyncResult BeginGetVocabulary(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetVocabulary", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<UISample.VocabularyServiceReference.VOCABULARY> EndGetVocabulary(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<UISample.VocabularyServiceReference.VOCABULARY> _result = ((System.Collections.ObjectModel.ObservableCollection<UISample.VocabularyServiceReference.VOCABULARY>)(base.EndInvoke("GetVocabulary", _args, result)));
                return _result;
            }
        }
    }
}
