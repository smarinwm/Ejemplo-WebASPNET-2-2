﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EjemploWebASPNET.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/EjemploWCF")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> ActivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idUsuarioField;
        
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
        public System.Nullable<bool> Activo {
            get {
                return this.ActivoField;
            }
            set {
                if ((this.ActivoField.Equals(value) != true)) {
                    this.ActivoField = value;
                    this.RaisePropertyChanged("Activo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreUsuario {
            get {
                return this.NombreUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreUsuarioField, value) != true)) {
                    this.NombreUsuarioField = value;
                    this.RaisePropertyChanged("NombreUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pass {
            get {
                return this.PassField;
            }
            set {
                if ((object.ReferenceEquals(this.PassField, value) != true)) {
                    this.PassField = value;
                    this.RaisePropertyChanged("Pass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                if ((this.idUsuarioField.Equals(value) != true)) {
                    this.idUsuarioField = value;
                    this.RaisePropertyChanged("idUsuario");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/obtenerUsuarios", ReplyAction="http://tempuri.org/IService1/obtenerUsuariosResponse")]
        EjemploWebASPNET.ServiceReference1.Usuario[] obtenerUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/obtenerUsuarios", ReplyAction="http://tempuri.org/IService1/obtenerUsuariosResponse")]
        System.Threading.Tasks.Task<EjemploWebASPNET.ServiceReference1.Usuario[]> obtenerUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerificarAcceso", ReplyAction="http://tempuri.org/IService1/VerificarAccesoResponse")]
        bool VerificarAcceso(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerificarAcceso", ReplyAction="http://tempuri.org/IService1/VerificarAccesoResponse")]
        System.Threading.Tasks.Task<bool> VerificarAccesoAsync(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarUsuario", ReplyAction="http://tempuri.org/IService1/InsertarUsuarioResponse")]
        void InsertarUsuario(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarUsuario", ReplyAction="http://tempuri.org/IService1/InsertarUsuarioResponse")]
        System.Threading.Tasks.Task InsertarUsuarioAsync(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuario", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioResponse")]
        void EliminarUsuario(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarUsuario", ReplyAction="http://tempuri.org/IService1/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task EliminarUsuarioAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DesactivarUsuario", ReplyAction="http://tempuri.org/IService1/DesactivarUsuarioResponse")]
        bool DesactivarUsuario(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DesactivarUsuario", ReplyAction="http://tempuri.org/IService1/DesactivarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> DesactivarUsuarioAsync(string user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : EjemploWebASPNET.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<EjemploWebASPNET.ServiceReference1.IService1>, EjemploWebASPNET.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EjemploWebASPNET.ServiceReference1.Usuario[] obtenerUsuarios() {
            return base.Channel.obtenerUsuarios();
        }
        
        public System.Threading.Tasks.Task<EjemploWebASPNET.ServiceReference1.Usuario[]> obtenerUsuariosAsync() {
            return base.Channel.obtenerUsuariosAsync();
        }
        
        public bool VerificarAcceso(string user, string pass) {
            return base.Channel.VerificarAcceso(user, pass);
        }
        
        public System.Threading.Tasks.Task<bool> VerificarAccesoAsync(string user, string pass) {
            return base.Channel.VerificarAccesoAsync(user, pass);
        }
        
        public void InsertarUsuario(string user, string pass) {
            base.Channel.InsertarUsuario(user, pass);
        }
        
        public System.Threading.Tasks.Task InsertarUsuarioAsync(string user, string pass) {
            return base.Channel.InsertarUsuarioAsync(user, pass);
        }
        
        public void EliminarUsuario(string user) {
            base.Channel.EliminarUsuario(user);
        }
        
        public System.Threading.Tasks.Task EliminarUsuarioAsync(string user) {
            return base.Channel.EliminarUsuarioAsync(user);
        }
        
        public bool DesactivarUsuario(string user) {
            return base.Channel.DesactivarUsuario(user);
        }
        
        public System.Threading.Tasks.Task<bool> DesactivarUsuarioAsync(string user) {
            return base.Channel.DesactivarUsuarioAsync(user);
        }
    }
}
