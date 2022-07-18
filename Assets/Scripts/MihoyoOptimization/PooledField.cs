/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 55: MihoyoOptimization.dll - Assembly: MihoyoOptimization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6668-6675

namespace MihoyoOptimization
{
    public class PooledField : Attribute // TypeDefIndex: 6673
    {
        // Fields
        public ERecycleStyle _returnStyle; // 0x10
        public ERecycleBehaviour _recycleBehaivour; // 0x14

        // Constructors
        public PooledField() { } // Dummy constructor
        public PooledField(ERecycleStyle inRS, ERecycleBehaviour inRB = ERecycleBehaviour.AllocateAndDeallocate /* Metadata: 0x00ADD9C4 */)
        {
            _returnStyle = inRS;
            _recycleBehaivour = inRB;
        } // 0x00000001895B45A0-0x00000001895B4620
    }
}
