﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MosaicSample.Infrastructure.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfModuleVertexViewModelBase xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <ModuleVertexViewModelBase>
    <ID>BRC</ID>
    <Position>
      <X>-810.09816336622907</X>
      <Y>-157.21138488651943</Y>
    </Position>
  </ModuleVertexViewModelBase>
  <ModuleVertexViewModelBase>
    <ID>SimA</ID>
    <Position>
      <X>-814.28517970788823</X>
      <Y>100.70745934070001</Y>
    </Position>
  </ModuleVertexViewModelBase>
  <ModuleVertexViewModelBase>
    <ID>SimB</ID>
    <Position>
      <X>-529.165039065714</X>
      <Y>-157.50000000000011</Y>
    </Position>
  </ModuleVertexViewModelBase>
  <ModuleVertexViewModelBase>
    <ID>SimC1</ID>
    <Position>
      <X>-446.66666666666561</X>
      <Y>105.24389689362712</Y>
    </Position>
  </ModuleVertexViewModelBase>
  <ModuleVertexViewModelBase>
    <ID>SimC2</ID>
    <Position>
      <X>-252.55254149769417</X>
      <Y>-100.09180821212138</Y>
    </Position>
  </ModuleVertexViewModelBase>
  <ModuleVertexViewModelBase>
    <ID>FIN</ID>
    <Position>
      <X>146.5615836712783</X>
      <Y>105.7925406593003</Y>
    </Position>
  </ModuleVertexViewModelBase>
</ArrayOfModuleVertexViewModelBase>")]
        public string HomeScreenVertexPositions {
            get {
                return ((string)(this["HomeScreenVertexPositions"]));
            }
            set {
                this["HomeScreenVertexPositions"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsSimulation {
            get {
                return ((bool)(this["IsSimulation"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("./RecipeDefinitions.json")]
        public string RecipeDefinitionFileName {
            get {
                return ((string)(this["RecipeDefinitionFileName"]));
            }
            set {
                this["RecipeDefinitionFileName"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsSimulatedStacklight {
            get {
                return ((bool)(this["IsSimulatedStacklight"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnablePersistency {
            get {
                return ((bool)(this["EnablePersistency"]));
            }
        }
    }
}
