﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VAV.Web.UserSetting {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="AAA-ASUserManagement", Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-ASUserManagement_1/wsdl", ConfigurationName="UserSetting.AAAASUserManagement")]
    public interface AAAASUserManagement {
        
        // CODEGEN: Generating message contract since the operation GetUserDetails_1 is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="GetUserDetails_1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        VAV.Web.UserSetting.GetUserDetails_1Response GetUserDetails_1(VAV.Web.UserSetting.GetUserDetails_1Request request);
        
        // CODEGEN: Generating message contract since the operation GetAllUserDetails_1 is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="GetAllUserDetails_1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        VAV.Web.UserSetting.GetAllUserDetails_1Response GetAllUserDetails_1(VAV.Web.UserSetting.GetAllUserDetails_1Request request);
        
        // CODEGEN: Generating message contract since the operation SetUserDetails_1 is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="SetUserDetails_1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        VAV.Web.UserSetting.SetUserDetails_1Response SetUserDetails_1(VAV.Web.UserSetting.SetUserDetails_1Request request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class GetUserDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uuidField;
        
        private UserAttributeType[] attributeMapField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
                this.RaisePropertyChanged("uuid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("userAttribute", IsNullable=false)]
        public UserAttributeType[] attributeMap {
            get {
                return this.attributeMapField;
            }
            set {
                this.attributeMapField = value;
                this.RaisePropertyChanged("attributeMap");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class UserAttributeType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class FreeTrialType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string descriptionField;
        
        private System.DateTime endDateField;
        
        private bool endDateFieldSpecified;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }
        
        /// <remarks/>
        public System.DateTime endDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
                this.RaisePropertyChanged("endDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDateSpecified {
            get {
                return this.endDateFieldSpecified;
            }
            set {
                this.endDateFieldSpecified = value;
                this.RaisePropertyChanged("endDateSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class ServiceAccessPointType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string geographicalRegionField;
        
        private string serviceField;
        
        private string networkField;
        
        private string urlField;
        
        /// <remarks/>
        public string geographicalRegion {
            get {
                return this.geographicalRegionField;
            }
            set {
                this.geographicalRegionField = value;
                this.RaisePropertyChanged("geographicalRegion");
            }
        }
        
        /// <remarks/>
        public string service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
                this.RaisePropertyChanged("service");
            }
        }
        
        /// <remarks/>
        public string network {
            get {
                return this.networkField;
            }
            set {
                this.networkField = value;
                this.RaisePropertyChanged("network");
            }
        }
        
        /// <remarks/>
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
                this.RaisePropertyChanged("url");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class UserType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uuidField;
        
        private UserAttributeType[] attributeMapField;
        
        /// <remarks/>
        public string uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
                this.RaisePropertyChanged("uuid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("userAttribute", IsNullable=false)]
        public UserAttributeType[] attributeMap {
            get {
                return this.attributeMapField;
            }
            set {
                this.attributeMapField = value;
                this.RaisePropertyChanged("attributeMap");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class GetUserDetailsResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string errorCodeField;
        
        private string errorTextField;
        
        private UserType userField;
        
        /// <remarks/>
        public string errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("errorCode");
            }
        }
        
        /// <remarks/>
        public string errorText {
            get {
                return this.errorTextField;
            }
            set {
                this.errorTextField = value;
                this.RaisePropertyChanged("errorText");
            }
        }
        
        /// <remarks/>
        public UserType user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
                this.RaisePropertyChanged("user");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserDetails_1Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1", Order=0)]
        public VAV.Web.UserSetting.GetUserDetails GetUserDetails;
        
        public GetUserDetails_1Request() {
        }
        
        public GetUserDetails_1Request(VAV.Web.UserSetting.GetUserDetails GetUserDetails) {
            this.GetUserDetails = GetUserDetails;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserDetails_1Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1", Order=0)]
        public VAV.Web.UserSetting.GetUserDetailsResponse GetUserDetailsResponse;
        
        public GetUserDetails_1Response() {
        }
        
        public GetUserDetails_1Response(VAV.Web.UserSetting.GetUserDetailsResponse GetUserDetailsResponse) {
            this.GetUserDetailsResponse = GetUserDetailsResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class GetAllUserDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uuidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
                this.RaisePropertyChanged("uuid");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class GetAllUserDetailsResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string errorCodeField;
        
        private string errorTextField;
        
        private UserType userField;
        
        private ServiceAccessPointType[] serviceAccessPointsField;
        
        private FreeTrialType[] freeTrialsField;
        
        /// <remarks/>
        public string errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("errorCode");
            }
        }
        
        /// <remarks/>
        public string errorText {
            get {
                return this.errorTextField;
            }
            set {
                this.errorTextField = value;
                this.RaisePropertyChanged("errorText");
            }
        }
        
        /// <remarks/>
        public UserType user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
                this.RaisePropertyChanged("user");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("serviceAccessPoint", IsNullable=false)]
        public ServiceAccessPointType[] serviceAccessPoints {
            get {
                return this.serviceAccessPointsField;
            }
            set {
                this.serviceAccessPointsField = value;
                this.RaisePropertyChanged("serviceAccessPoints");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("freeTrial", IsNullable=false)]
        public FreeTrialType[] freeTrials {
            get {
                return this.freeTrialsField;
            }
            set {
                this.freeTrialsField = value;
                this.RaisePropertyChanged("freeTrials");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllUserDetails_1Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1", Order=0)]
        public VAV.Web.UserSetting.GetAllUserDetails GetAllUserDetails;
        
        public GetAllUserDetails_1Request() {
        }
        
        public GetAllUserDetails_1Request(VAV.Web.UserSetting.GetAllUserDetails GetAllUserDetails) {
            this.GetAllUserDetails = GetAllUserDetails;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllUserDetails_1Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1", Order=0)]
        public VAV.Web.UserSetting.GetAllUserDetailsResponse GetAllUserDetailsResponse;
        
        public GetAllUserDetails_1Response() {
        }
        
        public GetAllUserDetails_1Response(VAV.Web.UserSetting.GetAllUserDetailsResponse GetAllUserDetailsResponse) {
            this.GetAllUserDetailsResponse = GetAllUserDetailsResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class SetUserDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uuidField;
        
        private string adminUuidField;
        
        private UserAttributeType[] attributeMapField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
                this.RaisePropertyChanged("uuid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string adminUuid {
            get {
                return this.adminUuidField;
            }
            set {
                this.adminUuidField = value;
                this.RaisePropertyChanged("adminUuid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("userAttribute", IsNullable=false)]
        public UserAttributeType[] attributeMap {
            get {
                return this.attributeMapField;
            }
            set {
                this.attributeMapField = value;
                this.RaisePropertyChanged("attributeMap");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1")]
    public partial class SetUserDetailsResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string errorCodeField;
        
        private string errorTextField;
        
        /// <remarks/>
        public string errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("errorCode");
            }
        }
        
        /// <remarks/>
        public string errorText {
            get {
                return this.errorTextField;
            }
            set {
                this.errorTextField = value;
                this.RaisePropertyChanged("errorText");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetUserDetails_1Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1", Order=0)]
        public VAV.Web.UserSetting.SetUserDetails SetUserDetails;
        
        public SetUserDetails_1Request() {
        }
        
        public SetUserDetails_1Request(VAV.Web.UserSetting.SetUserDetails SetUserDetails) {
            this.SetUserDetails = SetUserDetails;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SetUserDetails_1Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.reuters.com/ns/2008/08/15/webservices/AAA-AccessServices_1", Order=0)]
        public VAV.Web.UserSetting.SetUserDetailsResponse SetUserDetailsResponse;
        
        public SetUserDetails_1Response() {
        }
        
        public SetUserDetails_1Response(VAV.Web.UserSetting.SetUserDetailsResponse SetUserDetailsResponse) {
            this.SetUserDetailsResponse = SetUserDetailsResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AAAASUserManagementChannel : VAV.Web.UserSetting.AAAASUserManagement, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AAAASUserManagementClient : System.ServiceModel.ClientBase<VAV.Web.UserSetting.AAAASUserManagement>, VAV.Web.UserSetting.AAAASUserManagement {
        
        public AAAASUserManagementClient() {
        }
        
        public AAAASUserManagementClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AAAASUserManagementClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AAAASUserManagementClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AAAASUserManagementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VAV.Web.UserSetting.GetUserDetails_1Response VAV.Web.UserSetting.AAAASUserManagement.GetUserDetails_1(VAV.Web.UserSetting.GetUserDetails_1Request request) {
            return base.Channel.GetUserDetails_1(request);
        }
        
        public VAV.Web.UserSetting.GetUserDetailsResponse GetUserDetails_1(VAV.Web.UserSetting.GetUserDetails GetUserDetails) {
            VAV.Web.UserSetting.GetUserDetails_1Request inValue = new VAV.Web.UserSetting.GetUserDetails_1Request();
            inValue.GetUserDetails = GetUserDetails;
            VAV.Web.UserSetting.GetUserDetails_1Response retVal = ((VAV.Web.UserSetting.AAAASUserManagement)(this)).GetUserDetails_1(inValue);
            return retVal.GetUserDetailsResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VAV.Web.UserSetting.GetAllUserDetails_1Response VAV.Web.UserSetting.AAAASUserManagement.GetAllUserDetails_1(VAV.Web.UserSetting.GetAllUserDetails_1Request request) {
            return base.Channel.GetAllUserDetails_1(request);
        }
        
        public VAV.Web.UserSetting.GetAllUserDetailsResponse GetAllUserDetails_1(VAV.Web.UserSetting.GetAllUserDetails GetAllUserDetails) {
            VAV.Web.UserSetting.GetAllUserDetails_1Request inValue = new VAV.Web.UserSetting.GetAllUserDetails_1Request();
            inValue.GetAllUserDetails = GetAllUserDetails;
            VAV.Web.UserSetting.GetAllUserDetails_1Response retVal = ((VAV.Web.UserSetting.AAAASUserManagement)(this)).GetAllUserDetails_1(inValue);
            return retVal.GetAllUserDetailsResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VAV.Web.UserSetting.SetUserDetails_1Response VAV.Web.UserSetting.AAAASUserManagement.SetUserDetails_1(VAV.Web.UserSetting.SetUserDetails_1Request request) {
            return base.Channel.SetUserDetails_1(request);
        }
        
        public VAV.Web.UserSetting.SetUserDetailsResponse SetUserDetails_1(VAV.Web.UserSetting.SetUserDetails SetUserDetails) {
            VAV.Web.UserSetting.SetUserDetails_1Request inValue = new VAV.Web.UserSetting.SetUserDetails_1Request();
            inValue.SetUserDetails = SetUserDetails;
            VAV.Web.UserSetting.SetUserDetails_1Response retVal = ((VAV.Web.UserSetting.AAAASUserManagement)(this)).SetUserDetails_1(inValue);
            return retVal.SetUserDetailsResponse;
        }
    }
}