////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.10.351.108124-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: a9n */
    public partial class GuiEquipmentItemProxy : GuiDurableItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a9n _internal;
        
        #region Properties
        
        public a9n GuiEquipmentItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public GuiEquipmentItemProxy(a9n instance) : base(instance)
        {
            _internal = instance;
        }
        
        static GuiEquipmentItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a9n(GuiEquipmentItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator GuiEquipmentItemProxy(a9n instance)
        {
            return new GuiEquipmentItemProxy(instance);
        }
        
        public static implicit operator bool(GuiEquipmentItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
