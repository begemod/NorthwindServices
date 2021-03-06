﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrdersServiceWinFormClient.WCFOrdersService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderDTO", Namespace="http://epam.com/NorthwindServices")]
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
        private System.Collections.Generic.List<OrdersServiceWinFormClient.WCFOrdersService.OrderDetailDTO> OrderDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OrdersServiceWinFormClient.WCFOrdersService.OrderState OrderStateField;
        
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
        public System.Collections.Generic.List<OrdersServiceWinFormClient.WCFOrdersService.OrderDetailDTO> OrderDetails {
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
        public OrdersServiceWinFormClient.WCFOrdersService.OrderState OrderState {
            get {
                return this.OrderStateField;
            }
            set {
                if ((this.OrderStateField.Equals(value) != true)) {
                    this.OrderStateField = value;
                    this.RaisePropertyChanged("OrderState");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderDetailDTO", Namespace="http://epam.com/NorthwindServices")]
    [System.SerializableAttribute()]
    public partial class OrderDetailDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float DiscountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OrdersServiceWinFormClient.WCFOrdersService.OrderDTO OrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OrdersServiceWinFormClient.WCFOrdersService.ProductDTO ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnitPriceField;
        
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
        public float Discount {
            get {
                return this.DiscountField;
            }
            set {
                if ((this.DiscountField.Equals(value) != true)) {
                    this.DiscountField = value;
                    this.RaisePropertyChanged("Discount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OrdersServiceWinFormClient.WCFOrdersService.OrderDTO Order {
            get {
                return this.OrderField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderField, value) != true)) {
                    this.OrderField = value;
                    this.RaisePropertyChanged("Order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderID {
            get {
                return this.OrderIDField;
            }
            set {
                if ((this.OrderIDField.Equals(value) != true)) {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OrdersServiceWinFormClient.WCFOrdersService.ProductDTO Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderState", Namespace="http://epam.com/NorthwindServices")]
    public enum OrderState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        New = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InWork = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Closed = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductDTO", Namespace="http://epam.com/NorthwindServices")]
    [System.SerializableAttribute()]
    public partial class ProductDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CategoryIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DiscontinuedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuantityPerUnitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> ReorderLevelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SupplierIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> UnitPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> UnitsInStockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> UnitsOnOrderField;
        
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
        public System.Nullable<int> CategoryID {
            get {
                return this.CategoryIDField;
            }
            set {
                if ((this.CategoryIDField.Equals(value) != true)) {
                    this.CategoryIDField = value;
                    this.RaisePropertyChanged("CategoryID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Discontinued {
            get {
                return this.DiscontinuedField;
            }
            set {
                if ((this.DiscontinuedField.Equals(value) != true)) {
                    this.DiscontinuedField = value;
                    this.RaisePropertyChanged("Discontinued");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QuantityPerUnit {
            get {
                return this.QuantityPerUnitField;
            }
            set {
                if ((object.ReferenceEquals(this.QuantityPerUnitField, value) != true)) {
                    this.QuantityPerUnitField = value;
                    this.RaisePropertyChanged("QuantityPerUnit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> ReorderLevel {
            get {
                return this.ReorderLevelField;
            }
            set {
                if ((this.ReorderLevelField.Equals(value) != true)) {
                    this.ReorderLevelField = value;
                    this.RaisePropertyChanged("ReorderLevel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SupplierID {
            get {
                return this.SupplierIDField;
            }
            set {
                if ((this.SupplierIDField.Equals(value) != true)) {
                    this.SupplierIDField = value;
                    this.RaisePropertyChanged("SupplierID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> UnitsInStock {
            get {
                return this.UnitsInStockField;
            }
            set {
                if ((this.UnitsInStockField.Equals(value) != true)) {
                    this.UnitsInStockField = value;
                    this.RaisePropertyChanged("UnitsInStock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> UnitsOnOrder {
            get {
                return this.UnitsOnOrderField;
            }
            set {
                if ((this.UnitsOnOrderField.Equals(value) != true)) {
                    this.UnitsOnOrderField = value;
                    this.RaisePropertyChanged("UnitsOnOrder");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://epam.com/NorthwindService", ConfigurationName="WCFOrdersService.IOrdersService")]
    public interface IOrdersService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/GetAll", ReplyAction="http://epam.com/NorthwindService/IOrdersService/GetAllResponse")]
        System.Collections.Generic.List<OrdersServiceWinFormClient.WCFOrdersService.OrderDTO> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/GetAll", ReplyAction="http://epam.com/NorthwindService/IOrdersService/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<OrdersServiceWinFormClient.WCFOrdersService.OrderDTO>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/GetById", ReplyAction="http://epam.com/NorthwindService/IOrdersService/GetByIdResponse")]
        OrdersServiceWinFormClient.WCFOrdersService.OrderDTO GetById(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/GetById", ReplyAction="http://epam.com/NorthwindService/IOrdersService/GetByIdResponse")]
        System.Threading.Tasks.Task<OrdersServiceWinFormClient.WCFOrdersService.OrderDTO> GetByIdAsync(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/DeleteOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/DeleteOrderResponse")]
        int DeleteOrder(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/DeleteOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/DeleteOrderResponse")]
        System.Threading.Tasks.Task<int> DeleteOrderAsync(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/CreateNewOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/CreateNewOrderResponse")]
        int CreateNewOrder(OrdersServiceWinFormClient.WCFOrdersService.OrderDTO order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/CreateNewOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/CreateNewOrderResponse")]
        System.Threading.Tasks.Task<int> CreateNewOrderAsync(OrdersServiceWinFormClient.WCFOrdersService.OrderDTO order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/UpdateOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/UpdateOrderResponse")]
        void UpdateOrder(OrdersServiceWinFormClient.WCFOrdersService.OrderDTO order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/UpdateOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/UpdateOrderResponse")]
        System.Threading.Tasks.Task UpdateOrderAsync(OrdersServiceWinFormClient.WCFOrdersService.OrderDTO order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/ProcessOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/ProcessOrderResponse")]
        void ProcessOrder(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/ProcessOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/ProcessOrderResponse")]
        System.Threading.Tasks.Task ProcessOrderAsync(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/CloseOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/CloseOrderResponse")]
        void CloseOrder(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersService/CloseOrder", ReplyAction="http://epam.com/NorthwindService/IOrdersService/CloseOrderResponse")]
        System.Threading.Tasks.Task CloseOrderAsync(int orderId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdersServiceChannel : OrdersServiceWinFormClient.WCFOrdersService.IOrdersService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdersServiceClient : System.ServiceModel.ClientBase<OrdersServiceWinFormClient.WCFOrdersService.IOrdersService>, OrdersServiceWinFormClient.WCFOrdersService.IOrdersService {
        
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
        
        public System.Collections.Generic.List<OrdersServiceWinFormClient.WCFOrdersService.OrderDTO> GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<OrdersServiceWinFormClient.WCFOrdersService.OrderDTO>> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public OrdersServiceWinFormClient.WCFOrdersService.OrderDTO GetById(int orderId) {
            return base.Channel.GetById(orderId);
        }
        
        public System.Threading.Tasks.Task<OrdersServiceWinFormClient.WCFOrdersService.OrderDTO> GetByIdAsync(int orderId) {
            return base.Channel.GetByIdAsync(orderId);
        }
        
        public int DeleteOrder(int orderId) {
            return base.Channel.DeleteOrder(orderId);
        }
        
        public System.Threading.Tasks.Task<int> DeleteOrderAsync(int orderId) {
            return base.Channel.DeleteOrderAsync(orderId);
        }
        
        public int CreateNewOrder(OrdersServiceWinFormClient.WCFOrdersService.OrderDTO order) {
            return base.Channel.CreateNewOrder(order);
        }
        
        public System.Threading.Tasks.Task<int> CreateNewOrderAsync(OrdersServiceWinFormClient.WCFOrdersService.OrderDTO order) {
            return base.Channel.CreateNewOrderAsync(order);
        }
        
        public void UpdateOrder(OrdersServiceWinFormClient.WCFOrdersService.OrderDTO order) {
            base.Channel.UpdateOrder(order);
        }
        
        public System.Threading.Tasks.Task UpdateOrderAsync(OrdersServiceWinFormClient.WCFOrdersService.OrderDTO order) {
            return base.Channel.UpdateOrderAsync(order);
        }
        
        public void ProcessOrder(int orderId) {
            base.Channel.ProcessOrder(orderId);
        }
        
        public System.Threading.Tasks.Task ProcessOrderAsync(int orderId) {
            return base.Channel.ProcessOrderAsync(orderId);
        }
        
        public void CloseOrder(int orderId) {
            base.Channel.CloseOrder(orderId);
        }
        
        public System.Threading.Tasks.Task CloseOrderAsync(int orderId) {
            return base.Channel.CloseOrderAsync(orderId);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://epam.com/NorthwindService", ConfigurationName="WCFOrdersService.IOrdersSubscriptionService", CallbackContract=typeof(OrdersServiceWinFormClient.WCFOrdersService.IOrdersSubscriptionServiceCallback))]
    public interface IOrdersSubscriptionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersSubscriptionService/Subscribe", ReplyAction="http://epam.com/NorthwindService/IOrdersSubscriptionService/SubscribeResponse")]
        bool Subscribe(string clientIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersSubscriptionService/Subscribe", ReplyAction="http://epam.com/NorthwindService/IOrdersSubscriptionService/SubscribeResponse")]
        System.Threading.Tasks.Task<bool> SubscribeAsync(string clientIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersSubscriptionService/Unsubscribe", ReplyAction="http://epam.com/NorthwindService/IOrdersSubscriptionService/UnsubscribeResponse")]
        bool Unsubscribe(string clientIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/IOrdersSubscriptionService/Unsubscribe", ReplyAction="http://epam.com/NorthwindService/IOrdersSubscriptionService/UnsubscribeResponse")]
        System.Threading.Tasks.Task<bool> UnsubscribeAsync(string clientIdentifier);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdersSubscriptionServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://epam.com/NorthwindService/IOrdersSubscriptionService/OrderStatusIsChanged")]
        void OrderStatusIsChanged(int orderId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdersSubscriptionServiceChannel : OrdersServiceWinFormClient.WCFOrdersService.IOrdersSubscriptionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdersSubscriptionServiceClient : System.ServiceModel.DuplexClientBase<OrdersServiceWinFormClient.WCFOrdersService.IOrdersSubscriptionService>, OrdersServiceWinFormClient.WCFOrdersService.IOrdersSubscriptionService {
        
        public OrdersSubscriptionServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public OrdersSubscriptionServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public OrdersSubscriptionServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public OrdersSubscriptionServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public OrdersSubscriptionServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool Subscribe(string clientIdentifier) {
            return base.Channel.Subscribe(clientIdentifier);
        }
        
        public System.Threading.Tasks.Task<bool> SubscribeAsync(string clientIdentifier) {
            return base.Channel.SubscribeAsync(clientIdentifier);
        }
        
        public bool Unsubscribe(string clientIdentifier) {
            return base.Channel.Unsubscribe(clientIdentifier);
        }
        
        public System.Threading.Tasks.Task<bool> UnsubscribeAsync(string clientIdentifier) {
            return base.Channel.UnsubscribeAsync(clientIdentifier);
        }
    }
}
