﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tests.WCFOrdersService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderDTO", Namespace="http://epam.com/OrdersService")]
    [System.SerializableAttribute()]
    public partial class OrderDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> FreightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> OrderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DAL.Entities.OrderDetail[] OrderDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> RequiredDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipCountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipPostalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipRegionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ShipViaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ShippedDateField;
        
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
        public string CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerIDField, value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> EmployeeID {
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
        public System.Nullable<decimal> Freight {
            get {
                return this.FreightField;
            }
            set {
                if ((this.FreightField.Equals(value) != true)) {
                    this.FreightField = value;
                    this.RaisePropertyChanged("Freight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DAL.Entities.OrderDetail[] OrderDetails {
            get {
                return this.OrderDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderDetailsField, value) != true)) {
                    this.OrderDetailsField = value;
                    this.RaisePropertyChanged("OrderDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((this.OrderIdField.Equals(value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> RequiredDate {
            get {
                return this.RequiredDateField;
            }
            set {
                if ((this.RequiredDateField.Equals(value) != true)) {
                    this.RequiredDateField = value;
                    this.RaisePropertyChanged("RequiredDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipAddress {
            get {
                return this.ShipAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.ShipAddressField, value) != true)) {
                    this.ShipAddressField = value;
                    this.RaisePropertyChanged("ShipAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipCity {
            get {
                return this.ShipCityField;
            }
            set {
                if ((object.ReferenceEquals(this.ShipCityField, value) != true)) {
                    this.ShipCityField = value;
                    this.RaisePropertyChanged("ShipCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipCountry {
            get {
                return this.ShipCountryField;
            }
            set {
                if ((object.ReferenceEquals(this.ShipCountryField, value) != true)) {
                    this.ShipCountryField = value;
                    this.RaisePropertyChanged("ShipCountry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipName {
            get {
                return this.ShipNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ShipNameField, value) != true)) {
                    this.ShipNameField = value;
                    this.RaisePropertyChanged("ShipName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipPostalCode {
            get {
                return this.ShipPostalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ShipPostalCodeField, value) != true)) {
                    this.ShipPostalCodeField = value;
                    this.RaisePropertyChanged("ShipPostalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipRegion {
            get {
                return this.ShipRegionField;
            }
            set {
                if ((object.ReferenceEquals(this.ShipRegionField, value) != true)) {
                    this.ShipRegionField = value;
                    this.RaisePropertyChanged("ShipRegion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ShipVia {
            get {
                return this.ShipViaField;
            }
            set {
                if ((this.ShipViaField.Equals(value) != true)) {
                    this.ShipViaField = value;
                    this.RaisePropertyChanged("ShipVia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ShippedDate {
            get {
                return this.ShippedDateField;
            }
            set {
                if ((this.ShippedDateField.Equals(value) != true)) {
                    this.ShippedDateField = value;
                    this.RaisePropertyChanged("ShippedDate");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://epam.com/OrdersService", ConfigurationName="WCFOrdersService.IOrdersService")]
    public interface IOrdersService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/OrdersService/IOrdersService/GetAll", ReplyAction="http://epam.com/OrdersService/IOrdersService/GetAllResponse")]
        Tests.WCFOrdersService.OrderDTO[] GetAll();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdersServiceChannel : Tests.WCFOrdersService.IOrdersService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdersServiceClient : System.ServiceModel.ClientBase<Tests.WCFOrdersService.IOrdersService>, Tests.WCFOrdersService.IOrdersService {
        
        public OrdersServiceClient() {
        }
        
        public OrdersServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrdersServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdersServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdersServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Tests.WCFOrdersService.OrderDTO[] GetAll() {
            return base.Channel.GetAll();
        }
    }
}
