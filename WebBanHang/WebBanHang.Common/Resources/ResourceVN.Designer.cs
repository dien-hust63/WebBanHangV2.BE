﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanHang.Common.Resources {
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
    public class ResourceVN {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceVN() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebBanHang.Common.Resources.ResourceVN", typeof(ResourceVN).Assembly);
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
        ///   Looks up a localized string similar to Trường {0} bị trùng.
        /// </summary>
        public static string Exception_Duplication {
            get {
                return ResourceManager.GetString("Exception_Duplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email không đúng định dạng.
        /// </summary>
        public static string Exception_EmployeeEmail {
            get {
                return ResourceManager.GetString("Exception_EmployeeEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Có lỗi xảy ra.
        /// </summary>
        public static string Exception_ErrorMsg {
            get {
                return ResourceManager.GetString("Exception_ErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File không đúng định dạng.  Chỉ hỗ trợ file .xls, xlsx.
        /// </summary>
        public static string Exception_FileFormat {
            get {
                return ResourceManager.GetString("Exception_FileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vui lòng nhập tệp nhập khẩu.
        /// </summary>
        public static string Exception_FileNull {
            get {
                return ResourceManager.GetString("Exception_FileNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trường {0} không được để trống.
        /// </summary>
        public static string Exception_Required {
            get {
                return ResourceManager.GetString("Exception_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Xóa thành công.
        /// </summary>
        public static string Success_Delete {
            get {
                return ResourceManager.GetString("Success_Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thêm thành công.
        /// </summary>
        public static string Success_Insert {
            get {
                return ResourceManager.GetString("Success_Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sửa thành công.
        /// </summary>
        public static string Success_Update {
            get {
                return ResourceManager.GetString("Success_Update", resourceCulture);
            }
        }
    }
}
