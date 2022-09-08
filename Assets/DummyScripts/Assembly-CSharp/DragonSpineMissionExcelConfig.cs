/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class DragonSpineMissionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15068
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x14
	protected SimpleSafeUInt32 watcherIdRawNum; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected DragonSpineMissionFinishConfig[] _finishExec; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898B8C00-0x00000001898B8C20 */ get => default; /* [XID] */ /* 0x00000001898C0280-0x00000001898C02A0 */ protected set {} } // 0x0000000184615AD0-0x0000000184615BA0 0x0000000184615400-0x00000001846154E0
	public uint chapterId { /* [XID] */ /* 0x00000001898C7BA0-0x00000001898C7BC0 */ get => default; /* [XID] */ /* 0x00000001898CF310-0x00000001898CF330 */ protected set {} } // 0x0000000184615260-0x0000000184615330 0x0000000184614760-0x0000000184614840
	public uint watcherId { /* [XID] */ /* 0x00000001898D6B40-0x00000001898D6B60 */ get => default; /* [XID] */ /* 0x00000001898DE820-0x00000001898DE840 */ protected set {} } // 0x0000000184615330-0x0000000184615400 0x0000000184614840-0x0000000184614920
	public DragonSpineMissionFinishConfig[] finishExec { /* [XID] */ /* 0x00000001898E6000-0x00000001898E6020 */ get => default; /* [XID] */ /* 0x00000001898ED960-0x00000001898ED980 */ protected set {} } // 0x0000000184614520-0x00000001846145C0 0x00000001846151B0-0x0000000184615260

	// Constructors
	public DragonSpineMissionExcelConfig() {} // 0x0000000184615C40-0x0000000184615CA0

	// Methods
	// [IDTag] // 0x00000001898F51C0-0x00000001898F5200
	// [XID] // 0x00000001898F51C0-0x00000001898F5200
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184614D20-0x00000001846151B0
	// [IDTag] // 0x00000001898FF9F0-0x00000001898FFA30
	// [XID] // 0x00000001898FF9F0-0x00000001898FFA30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184614920-0x0000000184614D20
	// [XID] // 0x000000018990A0E0-0x000000018990A100
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFFE8 */, bool useObjectPool = false /* Metadata: 0x00AEFFEC */) => default; // 0x00000001846154E0-0x0000000184615990
	[BlackList] // 0x00000001899119E0-0x0000000189911A20
	// [XID] // 0x00000001899119E0-0x0000000189911A20
	public virtual void AutoAllocTypeFields() {} // 0x00000001846145C0-0x0000000184614660
	[BlackList] // 0x000000018991C6E0-0x000000018991C720
	// [XID] // 0x000000018991C6E0-0x000000018991C720
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184614660-0x0000000184614760
	[BlackList] // 0x0000000189926D60-0x0000000189926DA0
	// [XID] // 0x0000000189926D60-0x0000000189926DA0
	public virtual void ReturnToObjectPool() {} // 0x0000000184615BA0-0x0000000184615C40
	[BlackList] // 0x0000000189931240-0x0000000189931280
	// [XID] // 0x0000000189931240-0x0000000189931280
	public virtual void OnPoolAllocated() {} // 0x0000000184615A30-0x0000000184615AD0
	[BlackList] // 0x000000018993BC90-0x000000018993BCD0
	// [XID] // 0x000000018993BC90-0x000000018993BCD0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184615990-0x0000000184615A30
}

