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
    /* Internal type: b5 */
    public partial class SpellDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private b5 _internal;
        
        #region Properties
        
        public b5 SpellDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public string GetIdent() => _internal.kr();
        public string GetName() => _internal.ks();
        public string GetNameTag() => (string)_methodReflectionPool[0].Invoke(_internal,new object[]{});
        
        #endregion
        
        #region Constructor
        
        public SpellDescriptor(b5 instance)
        {
            _internal = instance;
        }
        
        static SpellDescriptor()
        {
            _methodReflectionPool.Add(typeof(b5).GetMethod("iy", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, null, new Type[]{}, null));
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator b5(SpellDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SpellDescriptor(b5 instance)
        {
            return new SpellDescriptor(instance);
        }
        
        public static implicit operator bool(SpellDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
