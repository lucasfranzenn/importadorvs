﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Importador.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.10.0.0")]
    internal sealed partial class Configuracoes : global::System.Configuration.ApplicationSettingsBase {
        
        private static Configuracoes defaultInstance = ((Configuracoes)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Configuracoes())));
        
        public static Configuracoes Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Configuracao\\imp.db")]
        public string BancoLocal {
            get {
                return ((string)(this["BancoLocal"]));
            }
            set {
                this["BancoLocal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string CodigoImplantacao {
            get {
                return ((string)(this["CodigoImplantacao"]));
            }
            set {
                this["CodigoImplantacao"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Basic")]
        public string NomeSkin {
            get {
                return ((string)(this["NomeSkin"]));
            }
            set {
                this["NomeSkin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Violet Dark")]
        public string PaletaSkin {
            get {
                return ((string)(this["PaletaSkin"]));
            }
            set {
                this["PaletaSkin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int RegimeEmpresa {
            get {
                return ((int)(this["RegimeEmpresa"]));
            }
            set {
                this["RegimeEmpresa"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UsuarioLogado {
            get {
                return ((string)(this["UsuarioLogado"]));
            }
            set {
                this["UsuarioLogado"] = value;
            }
        }
    }
}
