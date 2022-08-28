/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
    public class ObjectPoolNonGenericCluster : IObjectPoolCluster // TypeDefIndex: 7456
    {
        // Fields
        private static ObjectPoolNonGenericCluster _ins; // 0x00
        private ConcurrentDictionary<System.Type, ObjectPoolInstanceNonGeneric> _objectPoolCluster; // 0x10
        private LockFreeStack _addList; // 0x18
        [ThreadStatic] // 0x0000000189823E60-0x0000000189823E70
        private static HashSet<System.Type> _addSet; // 0xFFFFFFFF
        private static bool logError; // 0x08

        // Properties
        public static ObjectPoolNonGenericCluster instance { /* [XID] */ /* 0x0000000189A9D420-0x0000000189A9D440 */ get => default; } // 0x0000000186C319C0-0x0000000186C31B00 
        private static HashSet<System.Type> addSet { /* [XID] */ /* 0x0000000189AAC340-0x0000000189AAC360 */ get => default; } // 0x0000000186C31860-0x0000000186C319C0 

        // Nested types
        private class AddNode // TypeDefIndex: 7457
        {
            // Fields
            public System.Type t; // 0x10
            public Func<object> func; // 0x18

            // Constructors
            public AddNode() { } // Dummy constructor
            public AddNode(System.Type t, Func<object> func) { } // 0x0000000186C1E680-0x0000000186C1E780
        }

        // Constructors
        private ObjectPoolNonGenericCluster() { } // 0x0000000186C317A0-0x0000000186C31860
        static ObjectPoolNonGenericCluster() { } // 0x0000000186C31740-0x0000000186C317A0

        // Methods
        // [XID] // 0x0000000189A6B090-0x0000000189A6B0B0
        private static ObjectPoolInstanceNonGeneric CreateObjectPoolNonGeneric(System.Type t)
        {
            return new ObjectPoolInstanceNonGeneric(t, new Func<object>(() => { return Activator.CreateInstance(t); }), true);
        }// 0x0000000186C30E10-0x0000000186C30F90
         // [XID] // 0x0000000189AB3C80-0x0000000189AB3CA0
        private void Init() { } // 0x0000000186C312B0-0x0000000186C31350
                                // [XID] // 0x0000000189ABB8F0-0x0000000189ABB910
        public void Tick() { } // 0x0000000186C31560-0x0000000186C31740
                               // [XID] // 0x0000000189AC3090-0x0000000189AC30B0
        public void AddObjectPool(System.Type t)
        {
            if (!_objectPoolCluster.Contains(t))
            {
                _objectPoolCluster[t] = CreateObjectPoolNonGeneric(t);
            }
        } // 0x0000000186C30AF0-0x0000000186C30C10
          // [XID] // 0x0000000189ACA7F0-0x0000000189ACA810
        public ObjectPoolInstanceNonGeneric GetObjectPool(System.Type t)
        {
            if (!_objectPoolCluster.TryGetValue(t, out var value))
            {
                if (addSet.Add(t))
                {
                    _addList.Push(t);
                }
            }
            return value;
        }// 0x0000000186C31150-0x0000000186C312B0
         // [XID] // 0x0000000189AD2290-0x0000000189AD22B0
        public void PreRegisterObjectPools(params /* 0x000000018989F6F0-0x000000018989F700 */ System.Type[] types) { } // 0x0000000186C31350-0x0000000186C31440
        public T Allocate<T>()
            where T : class, new() => default;
        public T Allocate<T>(ref bool isNew)
            where T : class, new() => default;
        // [IDTag] // 0x0000000189AE1760-0x0000000189AE17A0
        // [XID] // 0x0000000189AE1760-0x0000000189AE17A0
        public void Deallocate(object objInstance) { } // 0x0000000186C31070-0x0000000186C31150
                                                       // [XID] // 0x0000000189AEBFB0-0x0000000189AEBFD0
        public void ReplaceAllocator(System.Type t, Func<object> inAllocator)
        {
            if (!_objectPoolCluster.Contains(t))
            {
                AddObjectPool(t);
                GetObjectPool(t).ReplaceAllocator(inAllocator);
            }
        } // 0x0000000186C31440-0x0000000186C31560
          // [XID] // 0x0000000189AF39D0-0x0000000189AF39F0
        public object Allocate(System.Type t) => default; // 0x0000000186C30C10-0x0000000186C30E10
                                                          // [IDTag] // 0x0000000189AFB1E0-0x0000000189AFB220
                                                          // [XID] // 0x0000000189AFB1E0-0x0000000189AFB220
        public void Deallocate(System.Type t, object obj) { } // 0x0000000186C30F90-0x0000000186C31070
    }
}
