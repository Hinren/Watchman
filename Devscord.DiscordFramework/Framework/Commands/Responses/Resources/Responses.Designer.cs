﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Devscord.DiscordFramework.Framework.Commands.Responses.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Responses {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Responses() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Devscord.DiscordFramework.Framework.Commands.Responses.Resources.Responses", typeof(Responses).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} został zmutowany do {{timeEnd}}UTC.
        /// </summary>
        public static string MutedUser {
            get {
                return ResourceManager.GetString("MutedUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cześć {{user}}! Witamy cię na serwerze {{server}}.
        /// </summary>
        public static string NewUserArrived {
            get {
                return ResourceManager.GetString("NewUserArrived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dostępne komendy: ```{{help}}```.
        /// </summary>
        public static string PrintHelp {
            get {
                return ResourceManager.GetString("PrintHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zakończono wczytywanie historii wiadomości..
        /// </summary>
        public static string ReadingHistoryDone {
            get {
                return ResourceManager.GetString("ReadingHistoryDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dodano role: {{role}} użytkownikowi {{user}}.
        /// </summary>
        public static string RoleAddedToUser {
            get {
                return ResourceManager.GetString("RoleAddedToUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} posiada już role {{role}}.
        /// </summary>
        public static string RoleIsInUserAlready {
            get {
                return ResourceManager.GetString("RoleIsInUserAlready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie znaleziono roli {{role}}..
        /// </summary>
        public static string RoleNotFound {
            get {
                return ResourceManager.GetString("RoleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} nie posiada roli {{role}}.
        /// </summary>
        public static string RoleNotFoundInUser {
            get {
                return ResourceManager.GetString("RoleNotFoundInUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie znaleziono roli {{role}} lub wybrana rola musi być zmieniona ręcznie przez członka administracji.
        /// </summary>
        public static string RoleNotFoundOrIsNotSafe {
            get {
                return ResourceManager.GetString("RoleNotFoundOrIsNotSafe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usunięto role {{role}} użytkownikowi {{user}}.
        /// </summary>
        public static string RoleRemovedFromUser {
            get {
                return ResourceManager.GetString("RoleRemovedFromUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spam alert! Wykryto spam u użytkownika {{user}} na kanale {{channel}}. Poczekaj chwile zanim coś napiszesz..
        /// </summary>
        public static string SpamAlertRecognized {
            get {
                return ResourceManager.GetString("SpamAlertRecognized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spam alert! Uzytkownik {{user}} został zmutowany..
        /// </summary>
        public static string SpamAlertUserIsMuted {
            get {
                return ResourceManager.GetString("SpamAlertUserIsMuted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spam alert! Użytkownik {{user}} został zmutowany na dłużej.
        /// </summary>
        public static string SpamAlertUserIsMutedForLong {
            get {
                return ResourceManager.GetString("SpamAlertUserIsMutedForLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Czas nie może być ujemny!.
        /// </summary>
        public static string TimeCannotBeNegative {
            get {
                return ResourceManager.GetString("TimeCannotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podano za dużą wartość czasu!.
        /// </summary>
        public static string TimeIsTooBig {
            get {
                return ResourceManager.GetString("TimeIsTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} może pisać ponownie..
        /// </summary>
        public static string UnmutedUser {
            get {
                return ResourceManager.GetString("UnmutedUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Musisz wskazać użytkownika do zmutowania..
        /// </summary>
        public static string UserDidntMentionedAnyUserToMute {
            get {
                return ResourceManager.GetString("UserDidntMentionedAnyUserToMute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie masz wystarczających uprawnień do wywołania tej komendy..
        /// </summary>
        public static string UserIsNotAdmin {
            get {
                return ResourceManager.GetString("UserIsNotAdmin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} nie istnieje..
        /// </summary>
        public static string UserNotFound {
            get {
                return ResourceManager.GetString("UserNotFound", resourceCulture);
            }
        }
    }
}
