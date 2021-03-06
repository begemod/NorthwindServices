﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tests.CategoriesService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://epam.com/NorthwindService", ConfigurationName="CategoriesService.ICategoriesService")]
    public interface ICategoriesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/ICategoriesService/GetCategoryNames", ReplyAction="http://epam.com/NorthwindService/ICategoriesService/GetCategoryNamesResponse")]
        System.Collections.Generic.List<string> GetCategoryNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/ICategoriesService/GetCategoryImage", ReplyAction="http://epam.com/NorthwindService/ICategoriesService/GetCategoryImageResponse")]
        System.IO.Stream GetCategoryImage(string categoryName);
        
        // CODEGEN: Generating message contract since the operation SaveCategoryImage is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://epam.com/NorthwindService/ICategoriesService/SaveCategoryImage", ReplyAction="http://epam.com/NorthwindService/ICategoriesService/SaveCategoryImageResponse")]
        Tests.CategoriesService.SaveCategoryImageResponse SaveCategoryImage(Tests.CategoriesService.SendingCategory request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendingCategory", WrapperNamespace="http://epam.com/NorthwindService", IsWrapped=true)]
    public partial class SendingCategory {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://epam.com/NorthwindService")]
        public string CategoryName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://epam.com/NorthwindService", Order=0)]
        public System.IO.Stream CategoryImage;
        
        public SendingCategory() {
        }
        
        public SendingCategory(string CategoryName, System.IO.Stream CategoryImage) {
            this.CategoryName = CategoryName;
            this.CategoryImage = CategoryImage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveCategoryImageResponse {
        
        public SaveCategoryImageResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategoriesServiceChannel : Tests.CategoriesService.ICategoriesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoriesServiceClient : System.ServiceModel.ClientBase<Tests.CategoriesService.ICategoriesService>, Tests.CategoriesService.ICategoriesService {
        
        public CategoriesServiceClient() {
        }
        
        public CategoriesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoriesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoriesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoriesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<string> GetCategoryNames() {
            return base.Channel.GetCategoryNames();
        }
        
        public System.IO.Stream GetCategoryImage(string categoryName) {
            return base.Channel.GetCategoryImage(categoryName);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tests.CategoriesService.SaveCategoryImageResponse Tests.CategoriesService.ICategoriesService.SaveCategoryImage(Tests.CategoriesService.SendingCategory request) {
            return base.Channel.SaveCategoryImage(request);
        }
        
        public void SaveCategoryImage(string CategoryName, System.IO.Stream CategoryImage) {
            Tests.CategoriesService.SendingCategory inValue = new Tests.CategoriesService.SendingCategory();
            inValue.CategoryName = CategoryName;
            inValue.CategoryImage = CategoryImage;
            Tests.CategoriesService.SaveCategoryImageResponse retVal = ((Tests.CategoriesService.ICategoriesService)(this)).SaveCategoryImage(inValue);
        }
    }
}
