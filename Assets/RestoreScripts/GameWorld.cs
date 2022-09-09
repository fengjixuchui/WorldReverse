/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500
/// <summary>
/// 已完成-游戏世界的基类
/// 2022/09/09
/// </summary>
public abstract class GameWorld // TypeDefIndex: 19918
{
    // Properties
    public string scenePath { /* [XID] */ /* 0x00000001899F8250-0x00000001899F8290 */ get; /* [XID] */ /* 0x0000000189A02850-0x0000000189A02890 */ set; } // 0x0000000184ECD100-0x0000000184ECD160 0x0000000184ECCD20-0x0000000184ECCD80
    public GlobalVars.WorldType worldType { /* [XID] */ /* 0x0000000189A0CDE0-0x0000000189A0CE20 */ get; /* [XID] */ /* 0x0000000189A17210-0x0000000189A17250 */ set; } // 0x0000000184ECD0A0-0x0000000184ECD100 0x0000000184ECD200-0x0000000184ECD260

    // Constructors
    protected GameWorld() { } // 0x0000000184ECD3A0-0x0000000184ECD400

    // Methods
    public abstract void Init(uint token);
    public abstract void FixedTick();
    public abstract void Tick();
    public abstract void LateTick();
    public abstract void Destroy();
    // [XID] // 0x0000000189A217F0-0x0000000189A21810
    public virtual void BeforeUpdateSchedule() { } // 0x0000000184ECCAA0-0x0000000184ECCB40
                                                   // [XID] // 0x0000000189A28D30-0x0000000189A28D50
    public virtual void UpdateSchedule() { } // 0x0000000184ECCEC0-0x0000000184ECCF60
                                             // [XID] // 0x0000000189A30450-0x0000000189A30470
    public virtual void AfterUpdateSchedule() { } // 0x0000000184ECCBE0-0x0000000184ECCC80
                                                  // [XID] // 0x0000000189A37E70-0x0000000189A37E90
    public virtual void EndUpdateSchedule() { } // 0x0000000184ECD160-0x0000000184ECD200
                                                // [XID] // 0x0000000189A3F5C0-0x0000000189A3F5E0
    public virtual void BeforeLateUpdatePreSchedule() { } // 0x0000000184ECCF60-0x0000000184ECD000
                                                          // [XID] // 0x0000000189A46BF0-0x0000000189A46C10
    public virtual void LateUpdatePreSchedule() { } // 0x0000000184ECD000-0x0000000184ECD0A0
                                                    // [XID] // 0x0000000189A4E3F0-0x0000000189A4E410
    public virtual void AfterLateUpdatePreSchedule() { } // 0x0000000184ECD260-0x0000000184ECD300
                                                         // [XID] // 0x0000000189A55C20-0x0000000189A55C40
    public virtual void EndLateUpdatePreSchedule() { } // 0x0000000184ECD300-0x0000000184ECD3A0
                                                       // [XID] // 0x0000000189A5D400-0x0000000189A5D420
    public virtual void BeforeLateUpdatePostSchedule() { } // 0x0000000184ECCB40-0x0000000184ECCBE0
                                                           // [XID] // 0x0000000189A64D60-0x0000000189A64D80
    public virtual void LateUpdatePostSchedule() { } // 0x0000000184ECCD80-0x0000000184ECCE20
                                                     // [XID] // 0x0000000189A6C4E0-0x0000000189A6C500
    public virtual void AfterLateUpdatePostSchedule() { } // 0x0000000184ECCE20-0x0000000184ECCEC0
                                                          // [XID] // 0x0000000189A73C90-0x0000000189A73CB0
    public virtual void EndLateUpdatePostSchedule() { } // 0x0000000184ECCC80-0x0000000184ECCD20
}

