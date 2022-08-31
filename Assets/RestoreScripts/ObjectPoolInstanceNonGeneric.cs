/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
    public class ObjectPoolInstanceNonGeneric : ObjectPoolInstanceBase // TypeDefIndex: 7454
    {
        // Fields
        protected Func<object> _allocator; // 0x40
        protected readonly LockFreeCollection _cache; // 0x48
        private int _preferCapacity; // 0x50
        private bool _usePreferCapacityWhenReleaseCache; // 0x54

        // Properties
        protected override ICollection _debugCache { /* [XID] */ /* 0x00000001896D40E0-0x00000001896D4100 */ get => default; } // 0x0000000186C2FEA0-0x0000000186C2FF40 

        // Constructors
        public ObjectPoolInstanceNonGeneric() { } // Dummy constructor
        public ObjectPoolInstanceNonGeneric(System.Type type, Func<object> inAllocator, bool staticPool = false /* Metadata: 0x00ADE9F7 */) { } // 0x0000000186C2FD80-0x0000000186C2FEA0

        // Methods
        // [XID] // 0x0000000189A4C2E0-0x0000000189A4C300
        protected override void Init(System.Type t, bool bGeneric) { } // 0x0000000186C2F8B0-0x0000000186C2F980
                                                                       // [XID] // 0x0000000189A53AB0-0x0000000189A53AD0
        public void ReplaceAllocator(Func<object> inAllocator)
        {
            _allocator = inAllocator;
        } // 0x0000000186C2FAB0-0x0000000186C2FB60
          // [XID] // 0x0000000189B53700-0x0000000189B53720
        public void Expand(int inCapacity, bool needPreAllocate) { } // 0x0000000186C2F720-0x0000000186C2F8B0
                                                                     // [IDTag] // 0x0000000189A62A00-0x0000000189A62A40
                                                                     // [XID] // 0x0000000189A62A00-0x0000000189A62A40
        public object Allocate() => default; // 0x0000000186C2F220-0x0000000186C2F370
                                             // [IDTag] // 0x0000000189A6D330-0x0000000189A6D370
                                             // [XID] // 0x0000000189A6D330-0x0000000189A6D370
        public object Allocate(ref bool isNew) => default; // 0x0000000186C2F370-0x0000000186C2F4D0
                                                           // [XID] // 0x0000000189A38BF0-0x0000000189A38C10
        public void Deallocate(object instance) { } // 0x0000000186C2F590-0x0000000186C2F720
                                                    // [XID] // 0x0000000189A7F180-0x0000000189A7F1A0
        public override void ReleaseAllCache() { } // 0x0000000186C2F980-0x0000000186C2FAB0
                                                   // [XID] // 0x0000000189A86D40-0x0000000189A86D60
        public int CachePoolCount() => default; // 0x0000000186C2F4D0-0x0000000186C2F590
                                                // [XID] // 0x0000000189A8E910-0x0000000189A8E930
        public override string ToString() => default; // 0x0000000186C2FB60-0x0000000186C2FC80
    }
}
