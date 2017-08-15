////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
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

namespace Merlin.API.Direct
{
    /* Internal type: iz.PvpRules */
    public enum PvpRules
    {
        PvpDisabled = 0,
        PvpAllowed = 1,
        PvpForced = 2
    }
    
    public static class PvpRulesExtensions
    {
        public static iz.PvpRules ToInternal(this PvpRules instance)
        {
            return (iz.PvpRules)instance;
        }
        
        public static PvpRules ToWrapped(this iz.PvpRules instance)
        {
            return (PvpRules)instance;
        }
    }
}