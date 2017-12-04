﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeWCFServiceClient.EmployeeWCFServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeDataContract", Namespace="http://schemas.datacontract.org/2004/07/EmployeeWCFService")]
    [System.SerializableAttribute()]
    public partial class EmployeeDataContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HomePhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotesField;
        
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
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HomePhone {
            get {
                return this.HomePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.HomePhoneField, value) != true)) {
                    this.HomePhoneField = value;
                    this.RaisePropertyChanged("HomePhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Notes {
            get {
                return this.NotesField;
            }
            set {
                if ((object.ReferenceEquals(this.NotesField, value) != true)) {
                    this.NotesField = value;
                    this.RaisePropertyChanged("Notes");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeWCFServiceReference.IEmployeeManager")]
    public interface IEmployeeManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManager/SelectAll", ReplyAction="http://tempuri.org/IEmployeeManager/SelectAllResponse")]
        EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract[] SelectAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManager/SelectAll", ReplyAction="http://tempuri.org/IEmployeeManager/SelectAllResponse")]
        System.Threading.Tasks.Task<EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract[]> SelectAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManager/SelectByID", ReplyAction="http://tempuri.org/IEmployeeManager/SelectByIDResponse")]
        EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract SelectByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManager/SelectByID", ReplyAction="http://tempuri.org/IEmployeeManager/SelectByIDResponse")]
        System.Threading.Tasks.Task<EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract> SelectByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManager/Update", ReplyAction="http://tempuri.org/IEmployeeManager/UpdateResponse")]
        string Update(EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeManager/Update", ReplyAction="http://tempuri.org/IEmployeeManager/UpdateResponse")]
        System.Threading.Tasks.Task<string> UpdateAsync(EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract emp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeManagerChannel : EmployeeWCFServiceClient.EmployeeWCFServiceReference.IEmployeeManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeManagerClient : System.ServiceModel.ClientBase<EmployeeWCFServiceClient.EmployeeWCFServiceReference.IEmployeeManager>, EmployeeWCFServiceClient.EmployeeWCFServiceReference.IEmployeeManager {
        
        public EmployeeManagerClient() {
        }
        
        public EmployeeManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract[] SelectAll() {
            return base.Channel.SelectAll();
        }
        
        public System.Threading.Tasks.Task<EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract[]> SelectAllAsync() {
            return base.Channel.SelectAllAsync();
        }
        
        public EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract SelectByID(int id) {
            return base.Channel.SelectByID(id);
        }
        
        public System.Threading.Tasks.Task<EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract> SelectByIDAsync(int id) {
            return base.Channel.SelectByIDAsync(id);
        }
        
        public string Update(EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract emp) {
            return base.Channel.Update(emp);
        }
        
        public System.Threading.Tasks.Task<string> UpdateAsync(EmployeeWCFServiceClient.EmployeeWCFServiceReference.EmployeeDataContract emp) {
            return base.Channel.UpdateAsync(emp);
        }
    }
}
