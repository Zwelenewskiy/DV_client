﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DV_client.Server {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Email", Namespace="http://schemas.datacontract.org/2004/07/DV_server")]
    [System.SerializableAttribute()]
    public partial class Email : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] copyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int fromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string headerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] hidden_copyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] tagsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] toField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content {
            get {
                return this.contentField;
            }
            set {
                if ((object.ReferenceEquals(this.contentField, value) != true)) {
                    this.contentField = value;
                    this.RaisePropertyChanged("content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] copy {
            get {
                return this.copyField;
            }
            set {
                if ((object.ReferenceEquals(this.copyField, value) != true)) {
                    this.copyField = value;
                    this.RaisePropertyChanged("copy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int from {
            get {
                return this.fromField;
            }
            set {
                if ((this.fromField.Equals(value) != true)) {
                    this.fromField = value;
                    this.RaisePropertyChanged("from");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string header {
            get {
                return this.headerField;
            }
            set {
                if ((object.ReferenceEquals(this.headerField, value) != true)) {
                    this.headerField = value;
                    this.RaisePropertyChanged("header");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] hidden_copy {
            get {
                return this.hidden_copyField;
            }
            set {
                if ((object.ReferenceEquals(this.hidden_copyField, value) != true)) {
                    this.hidden_copyField = value;
                    this.RaisePropertyChanged("hidden_copy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] tags {
            get {
                return this.tagsField;
            }
            set {
                if ((object.ReferenceEquals(this.tagsField, value) != true)) {
                    this.tagsField = value;
                    this.RaisePropertyChanged("tags");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] to {
            get {
                return this.toField;
            }
            set {
                if ((object.ReferenceEquals(this.toField, value) != true)) {
                    this.toField = value;
                    this.RaisePropertyChanged("to");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string patronymicField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastname {
            get {
                return this.lastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastnameField, value) != true)) {
                    this.lastnameField = value;
                    this.RaisePropertyChanged("lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string patronymic {
            get {
                return this.patronymicField;
            }
            set {
                if ((object.ReferenceEquals(this.patronymicField, value) != true)) {
                    this.patronymicField = value;
                    this.RaisePropertyChanged("patronymic");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Server.IDV_server")]
    public interface IDV_server {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDV_server/GetEmails", ReplyAction="http://tempuri.org/IDV_server/GetEmailsResponse")]
        DV_client.Server.Email[] GetEmails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDV_server/GetEmails", ReplyAction="http://tempuri.org/IDV_server/GetEmailsResponse")]
        System.Threading.Tasks.Task<DV_client.Server.Email[]> GetEmailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDV_server/saveEmail", ReplyAction="http://tempuri.org/IDV_server/saveEmailResponse")]
        bool saveEmail(DV_client.Server.Email email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDV_server/saveEmail", ReplyAction="http://tempuri.org/IDV_server/saveEmailResponse")]
        System.Threading.Tasks.Task<bool> saveEmailAsync(DV_client.Server.Email email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDV_server/GetUsers", ReplyAction="http://tempuri.org/IDV_server/GetUsersResponse")]
        DV_client.Server.User[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDV_server/GetUsers", ReplyAction="http://tempuri.org/IDV_server/GetUsersResponse")]
        System.Threading.Tasks.Task<DV_client.Server.User[]> GetUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDV_serverChannel : DV_client.Server.IDV_server, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DV_serverClient : System.ServiceModel.ClientBase<DV_client.Server.IDV_server>, DV_client.Server.IDV_server {
        
        public DV_serverClient() {
        }
        
        public DV_serverClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DV_serverClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DV_serverClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DV_serverClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DV_client.Server.Email[] GetEmails() {
            return base.Channel.GetEmails();
        }
        
        public System.Threading.Tasks.Task<DV_client.Server.Email[]> GetEmailsAsync() {
            return base.Channel.GetEmailsAsync();
        }
        
        public bool saveEmail(DV_client.Server.Email email) {
            return base.Channel.saveEmail(email);
        }
        
        public System.Threading.Tasks.Task<bool> saveEmailAsync(DV_client.Server.Email email) {
            return base.Channel.saveEmailAsync(email);
        }
        
        public DV_client.Server.User[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<DV_client.Server.User[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
    }
}
