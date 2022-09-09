/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Beebyte.Obfuscator;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699
/// <summary>
/// 已完成-所有管理器根类
/// </summary>
namespace MoleMole
{
    [Skip] // 0x0000000189622900-0x0000000189622910
    public abstract class BaseManager // TypeDefIndex: 10485
    {
        // Constructors
        protected BaseManager() { } // 0x00000001868F2BF0-0x00000001868F2C50

        // Methods
        public abstract void Init();
        // [XID] // 0x00000001898A5A90-0x00000001898A5AB0
        public virtual void Tick() { } // 0x00000001868F2B50-0x00000001868F2BF0
                                       // [XID] // 0x00000001896FDCF0-0x00000001896FDD10
        public virtual void PostTick() { } // 0x00000001868F2AB0-0x00000001868F2B50
                                           // [XID] // 0x000000018971BA50-0x000000018971BA70
        public virtual void LateTick() { } // 0x00000001868F2A10-0x00000001868F2AB0
                                           // [XID] // 0x00000001898BC270-0x00000001898BC290
        public virtual void LatePreTick() { } // 0x00000001868F2970-0x00000001868F2A10
                                              // [XID] // 0x00000001898C3610-0x00000001898C3630
        public virtual void LatePreTickEnd() { } // 0x00000001868F28D0-0x00000001868F2970
                                                 // [XID] // 0x0000000189731CA0-0x0000000189731CC0
        public virtual void LatePostTick() { } // 0x00000001868F2830-0x00000001868F28D0
                                               // [XID] // 0x00000001898D2750-0x00000001898D2770
        public virtual void LatePostTickEnd() { } // 0x00000001868F2790-0x00000001868F2830
                                                  // [XID] // 0x00000001898D9FB0-0x00000001898D9FD0
        public virtual string Dump(string tag) => default; // 0x00000001868F26B0-0x00000001868F2790
        public abstract void Destroy();
    }
}
