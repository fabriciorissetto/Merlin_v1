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

namespace Albion_Direct
{
    /* Internal type: agz.a */
    public enum CollisionFlags
    {
        Terrain = 0,
        Barrier = 1,
        Wall = 2,
        Unknown1 = 4,
        Unknown2 = 5,
        Building = 16,
        GameObject = 32,
        Unknown3 = 37,
        MeshCollider = 255
    }
    
    public static class CollisionFlagsExtensions
    {
        public static agz.a ToInternal(this CollisionFlags instance)
        {
            return (agz.a)instance;
        }
        
        public static CollisionFlags ToWrapped(this agz.a instance)
        {
            return (CollisionFlags)instance;
        }
    }
}
