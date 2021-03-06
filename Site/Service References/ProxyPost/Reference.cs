﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Site.ProxyPost {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/WS.Model")]
    [System.SerializableAttribute()]
    public partial class Post : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Site.ProxyPost.Categoria[] CategoriasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConteudoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataInclusaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataLiberacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char PrivadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
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
        public Site.ProxyPost.Categoria[] Categorias {
            get {
                return this.CategoriasField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriasField, value) != true)) {
                    this.CategoriasField = value;
                    this.RaisePropertyChanged("Categorias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoUsuario {
            get {
                return this.CodigoUsuarioField;
            }
            set {
                if ((this.CodigoUsuarioField.Equals(value) != true)) {
                    this.CodigoUsuarioField = value;
                    this.RaisePropertyChanged("CodigoUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Conteudo {
            get {
                return this.ConteudoField;
            }
            set {
                if ((object.ReferenceEquals(this.ConteudoField, value) != true)) {
                    this.ConteudoField = value;
                    this.RaisePropertyChanged("Conteudo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataInclusao {
            get {
                return this.DataInclusaoField;
            }
            set {
                if ((this.DataInclusaoField.Equals(value) != true)) {
                    this.DataInclusaoField = value;
                    this.RaisePropertyChanged("DataInclusao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataLiberacao {
            get {
                return this.DataLiberacaoField;
            }
            set {
                if ((this.DataLiberacaoField.Equals(value) != true)) {
                    this.DataLiberacaoField = value;
                    this.RaisePropertyChanged("DataLiberacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char Privado {
            get {
                return this.PrivadoField;
            }
            set {
                if ((this.PrivadoField.Equals(value) != true)) {
                    this.PrivadoField = value;
                    this.RaisePropertyChanged("Privado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Categoria", Namespace="http://schemas.datacontract.org/2004/07/WS.Model")]
    [System.SerializableAttribute()]
    public partial class Categoria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DataExclusaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
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
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DataExclusao {
            get {
                return this.DataExclusaoField;
            }
            set {
                if ((this.DataExclusaoField.Equals(value) != true)) {
                    this.DataExclusaoField = value;
                    this.RaisePropertyChanged("DataExclusao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyPost.IPost")]
    public interface IPost {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPost/Inserir", ReplyAction="http://tempuri.org/IPost/InserirResponse")]
        void Inserir(Site.ProxyPost.Post obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPost/Alterar", ReplyAction="http://tempuri.org/IPost/AlterarResponse")]
        void Alterar(Site.ProxyPost.Post obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPost/Excluir", ReplyAction="http://tempuri.org/IPost/ExcluirResponse")]
        void Excluir(Site.ProxyPost.Post obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPost/Selecionar", ReplyAction="http://tempuri.org/IPost/SelecionarResponse")]
        Site.ProxyPost.Post[] Selecionar();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPostChannel : Site.ProxyPost.IPost, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PostClient : System.ServiceModel.ClientBase<Site.ProxyPost.IPost>, Site.ProxyPost.IPost {
        
        public PostClient() {
        }
        
        public PostClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PostClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Inserir(Site.ProxyPost.Post obj) {
            base.Channel.Inserir(obj);
        }
        
        public void Alterar(Site.ProxyPost.Post obj) {
            base.Channel.Alterar(obj);
        }
        
        public void Excluir(Site.ProxyPost.Post obj) {
            base.Channel.Excluir(obj);
        }
        
        public Site.ProxyPost.Post[] Selecionar() {
            return base.Channel.Selecionar();
        }
    }
}
