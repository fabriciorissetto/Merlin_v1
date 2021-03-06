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
    /* Internal type: fj */
    public partial class MountItemDescriptor : EquipmentItemDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private fj _internal;
        
        #region Properties
        
        public fj MountItemDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetHalfMountRange() => _internal.ei();
        public float GetRemountDistance() => _internal.en();
        
        #endregion
        
        #region Constructor
        
        public MountItemDescriptor(fj instance) : base(instance)
        {
            _internal = instance;
        }
        
        static MountItemDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator fj(MountItemDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MountItemDescriptor(fj instance)
        {
            return new MountItemDescriptor(instance);
        }
        
        public static implicit operator bool(MountItemDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
