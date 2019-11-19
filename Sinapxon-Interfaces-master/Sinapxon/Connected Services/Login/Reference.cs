﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sinapxon.Login {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.sinapxon.pucp.edu.pe/", ConfigurationName="Login.LoginServices")]
    public interface LoginServices {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sinapxon.pucp.edu.pe/LoginServices/validarCorreoRequest", ReplyAction="http://services.sinapxon.pucp.edu.pe/LoginServices/validarCorreoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Sinapxon.Login.validarCorreoResponse validarCorreo(Sinapxon.Login.validarCorreoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sinapxon.pucp.edu.pe/LoginServices/validarCorreoRequest", ReplyAction="http://services.sinapxon.pucp.edu.pe/LoginServices/validarCorreoResponse")]
        System.Threading.Tasks.Task<Sinapxon.Login.validarCorreoResponse> validarCorreoAsync(Sinapxon.Login.validarCorreoRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sinapxon.pucp.edu.pe/LoginServices/validarLoginRequest", ReplyAction="http://services.sinapxon.pucp.edu.pe/LoginServices/validarLoginResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        Sinapxon.Login.validarLoginResponse validarLogin(Sinapxon.Login.validarLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sinapxon.pucp.edu.pe/LoginServices/validarLoginRequest", ReplyAction="http://services.sinapxon.pucp.edu.pe/LoginServices/validarLoginResponse")]
        System.Threading.Tasks.Task<Sinapxon.Login.validarLoginResponse> validarLoginAsync(Sinapxon.Login.validarLoginRequest request);
        
        // CODEGEN: Parameter 'codigo' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sinapxon.pucp.edu.pe/LoginServices/actualizarPasswordRequest", ReplyAction="http://services.sinapxon.pucp.edu.pe/LoginServices/actualizarPasswordResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Sinapxon.Login.actualizarPasswordResponse actualizarPassword(Sinapxon.Login.actualizarPasswordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.sinapxon.pucp.edu.pe/LoginServices/actualizarPasswordRequest", ReplyAction="http://services.sinapxon.pucp.edu.pe/LoginServices/actualizarPasswordResponse")]
        System.Threading.Tasks.Task<Sinapxon.Login.actualizarPasswordResponse> actualizarPasswordAsync(Sinapxon.Login.actualizarPasswordRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.sinapxon.pucp.edu.pe/")]
    public partial class persona : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codigoField;
        
        private string nombreField;
        
        private string tipoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string tipo {
            get {
                return this.tipoField;
            }
            set {
                this.tipoField = value;
                this.RaisePropertyChanged("tipo");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarCorreo", WrapperNamespace="http://services.sinapxon.pucp.edu.pe/", IsWrapped=true)]
    public partial class validarCorreoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.sinapxon.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string correo;
        
        public validarCorreoRequest() {
        }
        
        public validarCorreoRequest(string correo) {
            this.correo = correo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarCorreoResponse", WrapperNamespace="http://services.sinapxon.pucp.edu.pe/", IsWrapped=true)]
    public partial class validarCorreoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.sinapxon.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Sinapxon.Login.persona @return;
        
        public validarCorreoResponse() {
        }
        
        public validarCorreoResponse(Sinapxon.Login.persona @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarLogin", WrapperNamespace="http://services.sinapxon.pucp.edu.pe/", IsWrapped=true)]
    public partial class validarLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.sinapxon.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nickname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.sinapxon.pucp.edu.pe/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        public validarLoginRequest() {
        }
        
        public validarLoginRequest(string nickname, string password) {
            this.nickname = nickname;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarLoginResponse", WrapperNamespace="http://services.sinapxon.pucp.edu.pe/", IsWrapped=true)]
    public partial class validarLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.sinapxon.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Sinapxon.Login.persona @return;
        
        public validarLoginResponse() {
        }
        
        public validarLoginResponse(Sinapxon.Login.persona @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarPassword", WrapperNamespace="http://services.sinapxon.pucp.edu.pe/", IsWrapped=true)]
    public partial class actualizarPasswordRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.sinapxon.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.sinapxon.pucp.edu.pe/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        public actualizarPasswordRequest() {
        }
        
        public actualizarPasswordRequest(string codigo, string password) {
            this.codigo = codigo;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarPasswordResponse", WrapperNamespace="http://services.sinapxon.pucp.edu.pe/", IsWrapped=true)]
    public partial class actualizarPasswordResponse {
        
        public actualizarPasswordResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LoginServicesChannel : Sinapxon.Login.LoginServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServicesClient : System.ServiceModel.ClientBase<Sinapxon.Login.LoginServices>, Sinapxon.Login.LoginServices {
        
        public LoginServicesClient() {
        }
        
        public LoginServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sinapxon.Login.validarCorreoResponse Sinapxon.Login.LoginServices.validarCorreo(Sinapxon.Login.validarCorreoRequest request) {
            return base.Channel.validarCorreo(request);
        }
        
        public Sinapxon.Login.persona validarCorreo(string correo) {
            Sinapxon.Login.validarCorreoRequest inValue = new Sinapxon.Login.validarCorreoRequest();
            inValue.correo = correo;
            Sinapxon.Login.validarCorreoResponse retVal = ((Sinapxon.Login.LoginServices)(this)).validarCorreo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sinapxon.Login.validarCorreoResponse> Sinapxon.Login.LoginServices.validarCorreoAsync(Sinapxon.Login.validarCorreoRequest request) {
            return base.Channel.validarCorreoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sinapxon.Login.validarCorreoResponse> validarCorreoAsync(string correo) {
            Sinapxon.Login.validarCorreoRequest inValue = new Sinapxon.Login.validarCorreoRequest();
            inValue.correo = correo;
            return ((Sinapxon.Login.LoginServices)(this)).validarCorreoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sinapxon.Login.validarLoginResponse Sinapxon.Login.LoginServices.validarLogin(Sinapxon.Login.validarLoginRequest request) {
            return base.Channel.validarLogin(request);
        }
        
        public Sinapxon.Login.persona validarLogin(string nickname, string password) {
            Sinapxon.Login.validarLoginRequest inValue = new Sinapxon.Login.validarLoginRequest();
            inValue.nickname = nickname;
            inValue.password = password;
            Sinapxon.Login.validarLoginResponse retVal = ((Sinapxon.Login.LoginServices)(this)).validarLogin(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sinapxon.Login.validarLoginResponse> Sinapxon.Login.LoginServices.validarLoginAsync(Sinapxon.Login.validarLoginRequest request) {
            return base.Channel.validarLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sinapxon.Login.validarLoginResponse> validarLoginAsync(string nickname, string password) {
            Sinapxon.Login.validarLoginRequest inValue = new Sinapxon.Login.validarLoginRequest();
            inValue.nickname = nickname;
            inValue.password = password;
            return ((Sinapxon.Login.LoginServices)(this)).validarLoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Sinapxon.Login.actualizarPasswordResponse Sinapxon.Login.LoginServices.actualizarPassword(Sinapxon.Login.actualizarPasswordRequest request) {
            return base.Channel.actualizarPassword(request);
        }
        
        public void actualizarPassword(string codigo, string password) {
            Sinapxon.Login.actualizarPasswordRequest inValue = new Sinapxon.Login.actualizarPasswordRequest();
            inValue.codigo = codigo;
            inValue.password = password;
            Sinapxon.Login.actualizarPasswordResponse retVal = ((Sinapxon.Login.LoginServices)(this)).actualizarPassword(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Sinapxon.Login.actualizarPasswordResponse> Sinapxon.Login.LoginServices.actualizarPasswordAsync(Sinapxon.Login.actualizarPasswordRequest request) {
            return base.Channel.actualizarPasswordAsync(request);
        }
        
        public System.Threading.Tasks.Task<Sinapxon.Login.actualizarPasswordResponse> actualizarPasswordAsync(string codigo, string password) {
            Sinapxon.Login.actualizarPasswordRequest inValue = new Sinapxon.Login.actualizarPasswordRequest();
            inValue.codigo = codigo;
            inValue.password = password;
            return ((Sinapxon.Login.LoginServices)(this)).actualizarPasswordAsync(inValue);
        }
    }
}
