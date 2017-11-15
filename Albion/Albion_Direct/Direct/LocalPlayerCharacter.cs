////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: ayt */
    public partial class LocalPlayerCharacter : PlayerCharacter
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ayt _internal;
        
        #region Properties
        
        public ayt LocalPlayerCharacter_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ObservableRange<aeb> GetCraftingFocus() => _internal.s0();
        public Point2 GetDestination() => _internal.uc();
        public GameTimeStamp GetGlobalCooldownTimeStamp() => _internal.t8();
        public float GetSpellSlotCooldownPercent(byte A_0) => _internal.hn((byte)A_0);
        public SpellSlot[] GetSpellSlots() => _internal.t7().Select(x =>(SpellSlot)x).ToArray();
        public float GetWeight() => _internal.u3();
        
        #endregion
        
        #region Constructor
        
        public LocalPlayerCharacter(ayt instance) : base(instance)
        {
            _internal = instance;
        }
        
        static LocalPlayerCharacter()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ayt(LocalPlayerCharacter instance)
        {
            return instance._internal;
        }
        
        public static implicit operator LocalPlayerCharacter(ayt instance)
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