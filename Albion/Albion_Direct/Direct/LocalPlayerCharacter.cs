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
    /* Internal type: a0n */
    public partial class LocalPlayerCharacter : PlayerCharacter
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a0n _internal;
        
        #region Properties
        
        public a0n LocalPlayerCharacter_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ObservableRange<afr> GetCraftingFocus() => _internal.ta();
        public Point2 GetDestination() => _internal.uo();
        public GameTimeStamp GetGlobalCooldownTimeStamp() => _internal.uk();
        public float GetSpellSlotCooldownPercent(byte A_0) => _internal.hn((byte)A_0);
        public SpellSlot[] GetSpellSlots() => _internal.uj().Select(x =>(SpellSlot)x).ToArray();
        public float GetWeight() => _internal.vf();
        
        #endregion
        
        #region Constructor
        
        public LocalPlayerCharacter(a0n instance) : base(instance)
        {
            _internal = instance;
        }
        
        static LocalPlayerCharacter()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a0n(LocalPlayerCharacter instance)
        {
            return instance._internal;
        }
        
        public static implicit operator LocalPlayerCharacter(a0n instance)
        {
            return new LocalPlayerCharacter(instance);
        }
        
        public static implicit operator bool(LocalPlayerCharacter instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
