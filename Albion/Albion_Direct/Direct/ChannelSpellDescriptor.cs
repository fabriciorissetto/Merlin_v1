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
    /* Internal type: hm */
    public partial class ChannelSpellDescriptor : ActiveSpellDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private hm _internal;
        
        #region Properties
        
        public hm ChannelSpellDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ChannelSpellDescriptor(hm instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ChannelSpellDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator hm(ChannelSpellDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ChannelSpellDescriptor(hm instance)
        {
            return new ChannelSpellDescriptor(instance);
        }
        
        public static implicit operator bool(ChannelSpellDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
