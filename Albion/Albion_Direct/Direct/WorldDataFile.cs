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
    /* Internal type: anq */
    public partial class WorldDataFile : DataFile
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private anq _internal;
        
        #region Properties
        
        public anq WorldDataFile_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ClusterDescriptor GetCluster(string A_0) => _internal.it((string)A_0);
        public IEnumerable<ClusterDescriptor> GetClusters() => _internal.iu().Select(x =>(ClusterDescriptor)x);
        public ClusterExitDescriptor GetExit(string A_0) => _internal.iu((string)A_0);
        public TerritoryDescriptor GetTerritory(string A_0) => _internal.iv((string)A_0);
        
        #endregion
        
        #region Constructor
        
        public WorldDataFile(anq instance) : base(instance)
        {
            _internal = instance;
        }
        
        static WorldDataFile()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator anq(WorldDataFile instance)
        {
            return instance._internal;
        }
        
        public static implicit operator WorldDataFile(anq instance)
        {
            return new WorldDataFile(instance);
        }
        
        public static implicit operator bool(WorldDataFile instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
