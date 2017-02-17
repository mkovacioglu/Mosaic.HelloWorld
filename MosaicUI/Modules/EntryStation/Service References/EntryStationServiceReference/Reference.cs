﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MosaicSample.UI.EntryStation.EntryStationServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IEntryStationServiceFault", Namespace="http://schemas.datacontract.org/2004/07/MosaicSample.EntryStation")]
    [System.SerializableAttribute()]
    public partial class IEntryStationServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EntryStationServiceReference.IEntryStationService", CallbackContract=typeof(MosaicSample.UI.EntryStation.EntryStationServiceReference.IEntryStationServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IEntryStationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/KeepAlive", ReplyAction="http://tempuri.org/IEntryStationServiceREST/KeepAliveResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MosaicSample.UI.EntryStation.EntryStationServiceReference.IEntryStationServiceFault), Action="http://tempuri.org/IEntryStationServiceREST/KeepAliveIEntryStationServiceFaultFau" +
            "lt", Name="IEntryStationServiceFault", Namespace="http://schemas.datacontract.org/2004/07/MosaicSample.EntryStation")]
        bool KeepAlive();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/KeepAlive", ReplyAction="http://tempuri.org/IEntryStationServiceREST/KeepAliveResponse")]
        System.Threading.Tasks.Task<bool> KeepAliveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/get_IsInitialized", ReplyAction="http://tempuri.org/IEntryStationServiceREST/get_IsInitializedResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MosaicSample.UI.EntryStation.EntryStationServiceReference.IEntryStationServiceFault), Action="http://tempuri.org/IEntryStationServiceREST/get_IsInitializedIEntryStationService" +
            "FaultFault", Name="IEntryStationServiceFault", Namespace="http://schemas.datacontract.org/2004/07/MosaicSample.EntryStation")]
        bool get_IsInitialized();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/get_IsInitialized", ReplyAction="http://tempuri.org/IEntryStationServiceREST/get_IsInitializedResponse")]
        System.Threading.Tasks.Task<bool> get_IsInitializedAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/Start", ReplyAction="http://tempuri.org/IEntryStationServiceREST/StartResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MosaicSample.UI.EntryStation.EntryStationServiceReference.IEntryStationServiceFault), Action="http://tempuri.org/IEntryStationServiceREST/StartIEntryStationServiceFaultFault", Name="IEntryStationServiceFault", Namespace="http://schemas.datacontract.org/2004/07/MosaicSample.EntryStation")]
        void Start();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/Start", ReplyAction="http://tempuri.org/IEntryStationServiceREST/StartResponse")]
        System.Threading.Tasks.Task StartAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/Stop", ReplyAction="http://tempuri.org/IEntryStationServiceREST/StopResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MosaicSample.UI.EntryStation.EntryStationServiceReference.IEntryStationServiceFault), Action="http://tempuri.org/IEntryStationServiceREST/StopIEntryStationServiceFaultFault", Name="IEntryStationServiceFault", Namespace="http://schemas.datacontract.org/2004/07/MosaicSample.EntryStation")]
        void Stop();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/Stop", ReplyAction="http://tempuri.org/IEntryStationServiceREST/StopResponse")]
        System.Threading.Tasks.Task StopAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/ResetAlarms", ReplyAction="http://tempuri.org/IEntryStationServiceREST/ResetAlarmsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MosaicSample.UI.EntryStation.EntryStationServiceReference.IEntryStationServiceFault), Action="http://tempuri.org/IEntryStationServiceREST/ResetAlarmsIEntryStationServiceFaultF" +
            "ault", Name="IEntryStationServiceFault", Namespace="http://schemas.datacontract.org/2004/07/MosaicSample.EntryStation")]
        void ResetAlarms(int moduleInstance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/ResetAlarms", ReplyAction="http://tempuri.org/IEntryStationServiceREST/ResetAlarmsResponse")]
        System.Threading.Tasks.Task ResetAlarmsAsync(int moduleInstance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/SubscribeEvents", ReplyAction="http://tempuri.org/IEntryStationServiceREST/SubscribeEventsResponse")]
        void SubscribeEvents(int moduleInstance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/SubscribeEvents", ReplyAction="http://tempuri.org/IEntryStationServiceREST/SubscribeEventsResponse")]
        System.Threading.Tasks.Task SubscribeEventsAsync(int moduleInstance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/UnsubscribeEvents", ReplyAction="http://tempuri.org/IEntryStationServiceREST/UnsubscribeEventsResponse")]
        void UnsubscribeEvents(int moduleInstance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntryStationServiceREST/UnsubscribeEvents", ReplyAction="http://tempuri.org/IEntryStationServiceREST/UnsubscribeEventsResponse")]
        System.Threading.Tasks.Task UnsubscribeEventsAsync(int moduleInstance);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEntryStationServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPlatformModuleWcfService/ModuleStateChanged")]
        void ModuleStateChanged(VP.FF.PT.Common.PlatformEssentials.Entities.DTOs.PlatformModuleDTO module);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPlatformModuleWcfService/MetricsChanged")]
        void MetricsChanged(VP.FF.PT.Common.PlatformEssentials.Entities.DTOs.MetricsDTO metrics);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPlatformModuleWcfService/SendUserNotification")]
        void SendUserNotification(VP.FF.PT.Common.PlatformEssentials.MessageType type, string message, System.TimeSpan duration);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEntryStationServiceChannel : MosaicSample.UI.EntryStation.EntryStationServiceReference.IEntryStationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EntryStationServiceClient : System.ServiceModel.DuplexClientBase<MosaicSample.UI.EntryStation.EntryStationServiceReference.IEntryStationService>, MosaicSample.UI.EntryStation.EntryStationServiceReference.IEntryStationService {
        
        public EntryStationServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public EntryStationServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public EntryStationServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EntryStationServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EntryStationServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool KeepAlive() {
            return base.Channel.KeepAlive();
        }
        
        public System.Threading.Tasks.Task<bool> KeepAliveAsync() {
            return base.Channel.KeepAliveAsync();
        }
        
        public bool get_IsInitialized() {
            return base.Channel.get_IsInitialized();
        }
        
        public System.Threading.Tasks.Task<bool> get_IsInitializedAsync() {
            return base.Channel.get_IsInitializedAsync();
        }
        
        public void Start() {
            base.Channel.Start();
        }
        
        public System.Threading.Tasks.Task StartAsync() {
            return base.Channel.StartAsync();
        }
        
        public void Stop() {
            base.Channel.Stop();
        }
        
        public System.Threading.Tasks.Task StopAsync() {
            return base.Channel.StopAsync();
        }
        
        public void ResetAlarms(int moduleInstance) {
            base.Channel.ResetAlarms(moduleInstance);
        }
        
        public System.Threading.Tasks.Task ResetAlarmsAsync(int moduleInstance) {
            return base.Channel.ResetAlarmsAsync(moduleInstance);
        }
        
        public void SubscribeEvents(int moduleInstance) {
            base.Channel.SubscribeEvents(moduleInstance);
        }
        
        public System.Threading.Tasks.Task SubscribeEventsAsync(int moduleInstance) {
            return base.Channel.SubscribeEventsAsync(moduleInstance);
        }
        
        public void UnsubscribeEvents(int moduleInstance) {
            base.Channel.UnsubscribeEvents(moduleInstance);
        }
        
        public System.Threading.Tasks.Task UnsubscribeEventsAsync(int moduleInstance) {
            return base.Channel.UnsubscribeEventsAsync(moduleInstance);
        }
    }
}
