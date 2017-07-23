﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotesWebApp.NoteService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NoteService.NoteServiceSoap")]
    public interface NoteServiceSoap {
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNote", ReplyAction="*")]
        NotesWebApp.NoteService.InsertNoteResponse InsertNote(NotesWebApp.NoteService.InsertNoteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNote", ReplyAction="*")]
        System.Threading.Tasks.Task<NotesWebApp.NoteService.InsertNoteResponse> InsertNoteAsync(NotesWebApp.NoteService.InsertNoteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertNoteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertNote", Namespace="http://tempuri.org/", Order=0)]
        public NotesWebApp.NoteService.InsertNoteRequestBody Body;
        
        public InsertNoteRequest() {
        }
        
        public InsertNoteRequest(NotesWebApp.NoteService.InsertNoteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertNoteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string title;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string text;
        
        public InsertNoteRequestBody() {
        }
        
        public InsertNoteRequestBody(string username, string title, string text) {
            this.username = username;
            this.title = title;
            this.text = text;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertNoteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertNoteResponse", Namespace="http://tempuri.org/", Order=0)]
        public NotesWebApp.NoteService.InsertNoteResponseBody Body;
        
        public InsertNoteResponse() {
        }
        
        public InsertNoteResponse(NotesWebApp.NoteService.InsertNoteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertNoteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool InsertNoteResult;
        
        public InsertNoteResponseBody() {
        }
        
        public InsertNoteResponseBody(bool InsertNoteResult) {
            this.InsertNoteResult = InsertNoteResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NoteServiceSoapChannel : NotesWebApp.NoteService.NoteServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NoteServiceSoapClient : System.ServiceModel.ClientBase<NotesWebApp.NoteService.NoteServiceSoap>, NotesWebApp.NoteService.NoteServiceSoap {
        
        public NoteServiceSoapClient() {
        }
        
        public NoteServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NoteServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NoteServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NoteServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NotesWebApp.NoteService.InsertNoteResponse NotesWebApp.NoteService.NoteServiceSoap.InsertNote(NotesWebApp.NoteService.InsertNoteRequest request) {
            return base.Channel.InsertNote(request);
        }
        
        public bool InsertNote(string username, string title, string text) {
            NotesWebApp.NoteService.InsertNoteRequest inValue = new NotesWebApp.NoteService.InsertNoteRequest();
            inValue.Body = new NotesWebApp.NoteService.InsertNoteRequestBody();
            inValue.Body.username = username;
            inValue.Body.title = title;
            inValue.Body.text = text;
            NotesWebApp.NoteService.InsertNoteResponse retVal = ((NotesWebApp.NoteService.NoteServiceSoap)(this)).InsertNote(inValue);
            return retVal.Body.InsertNoteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NotesWebApp.NoteService.InsertNoteResponse> NotesWebApp.NoteService.NoteServiceSoap.InsertNoteAsync(NotesWebApp.NoteService.InsertNoteRequest request) {
            return base.Channel.InsertNoteAsync(request);
        }
        
        public System.Threading.Tasks.Task<NotesWebApp.NoteService.InsertNoteResponse> InsertNoteAsync(string username, string title, string text) {
            NotesWebApp.NoteService.InsertNoteRequest inValue = new NotesWebApp.NoteService.InsertNoteRequest();
            inValue.Body = new NotesWebApp.NoteService.InsertNoteRequestBody();
            inValue.Body.username = username;
            inValue.Body.title = title;
            inValue.Body.text = text;
            return ((NotesWebApp.NoteService.NoteServiceSoap)(this)).InsertNoteAsync(inValue);
        }
    }
}