﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clientws.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombreResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/nombre", ReplyAction="*")]
        clientws.Service.nombreResponse nombre(clientws.Service.nombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/nombre", ReplyAction="*")]
        System.Threading.Tasks.Task<clientws.Service.nombreResponse> nombreAsync(clientws.Service.nombreRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nombreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="nombre", Namespace="http://tempuri.org/", Order=0)]
        public clientws.Service.nombreRequestBody Body;
        
        public nombreRequest() {
        }
        
        public nombreRequest(clientws.Service.nombreRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class nombreRequestBody {
        
        public nombreRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nombreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="nombreResponse", Namespace="http://tempuri.org/", Order=0)]
        public clientws.Service.nombreResponseBody Body;
        
        public nombreResponse() {
        }
        
        public nombreResponse(clientws.Service.nombreResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class nombreResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombreResult;
        
        public nombreResponseBody() {
        }
        
        public nombreResponseBody(string nombreResult) {
            this.nombreResult = nombreResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : clientws.Service.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<clientws.Service.WebService1Soap>, clientws.Service.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        clientws.Service.nombreResponse clientws.Service.WebService1Soap.nombre(clientws.Service.nombreRequest request) {
            return base.Channel.nombre(request);
        }
        
        public string nombre() {
            clientws.Service.nombreRequest inValue = new clientws.Service.nombreRequest();
            inValue.Body = new clientws.Service.nombreRequestBody();
            clientws.Service.nombreResponse retVal = ((clientws.Service.WebService1Soap)(this)).nombre(inValue);
            return retVal.Body.nombreResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<clientws.Service.nombreResponse> clientws.Service.WebService1Soap.nombreAsync(clientws.Service.nombreRequest request) {
            return base.Channel.nombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<clientws.Service.nombreResponse> nombreAsync() {
            clientws.Service.nombreRequest inValue = new clientws.Service.nombreRequest();
            inValue.Body = new clientws.Service.nombreRequestBody();
            return ((clientws.Service.WebService1Soap)(this)).nombreAsync(inValue);
        }
    }
}
