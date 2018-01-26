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
    /* Internal type: avy */
    public partial class WorldObject : SimulationObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private avy _internal;
        
        #region Properties
        
        public avy WorldObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public Point2 GetPosition() => _internal.h3();
        public float GetRotation() => _internal.h5();
        
        #endregion
        
        #region Constructor
        
        public WorldObject(avy instance) : base(instance)
        {
            _internal = instance;
        }
        
        static WorldObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator avy(WorldObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator WorldObject(avy instance)
        {
            return new WorldObject(instance);
        }
        
        public static implicit operator bool(WorldObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
