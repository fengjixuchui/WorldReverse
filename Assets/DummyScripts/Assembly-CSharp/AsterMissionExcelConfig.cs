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
public class AsterMissionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15021
{
	// Fields
	protected SimpleSafeUInt32 missionIdRawNum; // 0x10
	protected SimpleSafeUInt32 phaseRawNum; // 0x14
	protected SimpleSafeUInt32 watcherIdRawNum; // 0x18
	protected SimpleSafeUInt32 transPointIdRawNum; // 0x1C
	protected string _tracePoint; // 0x20
	protected byte _perfabPathHashPre; // 0x28
	protected uint _perfabPathHashSuffix; // 0x2C

	// Properties
	public uint missionId { /* [XID] */ /* 0x00000001897D8F10-0x00000001897D8F30 */ get => default; /* [XID] */ /* 0x00000001897E0190-0x00000001897E01B0 */ protected set {} } // 0x00000001834EB710-0x00000001834EB7E0 0x00000001834E9DD0-0x00000001834E9EB0
	public uint phase { /* [XID] */ /* 0x00000001897E7850-0x00000001897E7870 */ get => default; /* [XID] */ /* 0x00000001897EF450-0x00000001897EF470 */ protected set {} } // 0x00000001834EA1E0-0x00000001834EA2B0 0x00000001834EA060-0x00000001834EA140
	public uint watcherId { /* [XID] */ /* 0x00000001897F6AA0-0x00000001897F6AC0 */ get => default; /* [XID] */ /* 0x00000001897FE140-0x00000001897FE160 */ protected set {} } // 0x00000001834EADD0-0x00000001834EAEA0 0x00000001834EA2B0-0x00000001834EA390
	public uint transPointId { /* [XID] */ /* 0x0000000189805870-0x0000000189805890 */ get => default; /* [XID] */ /* 0x000000018980CF10-0x000000018980CF30 */ protected set {} } // 0x00000001834EAEA0-0x00000001834EAF70 0x00000001834EA440-0x00000001834EA520
	public string tracePoint { /* [XID] */ /* 0x0000000189814710-0x0000000189814730 */ get => default; /* [XID] */ /* 0x000000018981C180-0x000000018981C1A0 */ protected set {} } // 0x00000001834EB8B0-0x00000001834EB950 0x00000001834EA390-0x00000001834EA440
	public byte perfabPathHashPre { /* [XID] */ /* 0x00000001898236B0-0x00000001898236D0 */ get => default; /* [XID] */ /* 0x000000018982B010-0x000000018982B030 */ protected set {} } // 0x00000001834EAF70-0x00000001834EB010 0x00000001834EB950-0x00000001834EBA00
	public uint perfabPathHashSuffix { /* [XID] */ /* 0x00000001898325B0-0x00000001898325D0 */ get => default; /* [XID] */ /* 0x0000000189839C20-0x0000000189839C40 */ protected set {} } // 0x00000001834EA140-0x00000001834EA1E0 0x00000001834EB010-0x00000001834EB0C0
	public ulong perfabPathHash { /* [XID] */ /* 0x00000001898410A0-0x00000001898410C0 */ get => default; } // 0x00000001834EB7E0-0x00000001834EB8B0 

	// Constructors
	public AsterMissionExcelConfig() {} // 0x00000001834EBBE0-0x00000001834EBC40

	// Methods
	// [IDTag] // 0x0000000189848540-0x0000000189848580
	// [XID] // 0x0000000189848540-0x0000000189848580
	public virtual bool ParseFromLine(string line) => default; // 0x00000001834EA970-0x00000001834EADD0
	// [IDTag] // 0x00000001898528C0-0x0000000189852900
	// [XID] // 0x00000001898528C0-0x0000000189852900
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001834EA520-0x00000001834EA970
	// [XID] // 0x000000018985CD30-0x000000018985CD50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEB2 */, bool useObjectPool = false /* Metadata: 0x00AEFEB6 */) => default; // 0x00000001834EB0C0-0x00000001834EB710
	[BlackList] // 0x0000000189864710-0x0000000189864750
	// [XID] // 0x0000000189864710-0x0000000189864750
	public virtual void AutoAllocTypeFields() {} // 0x00000001834E9EB0-0x00000001834E9F50
	[BlackList] // 0x000000018986EC30-0x000000018986EC70
	// [XID] // 0x000000018986EC30-0x000000018986EC70
	public virtual void AutoRecycleTypeFields() {} // 0x00000001834E9F50-0x00000001834EA060
	[BlackList] // 0x0000000189879290-0x00000001898792D0
	// [XID] // 0x0000000189879290-0x00000001898792D0
	public virtual void ReturnToObjectPool() {} // 0x00000001834EBB40-0x00000001834EBBE0
	[BlackList] // 0x0000000189883330-0x0000000189883370
	// [XID] // 0x0000000189883330-0x0000000189883370
	public virtual void OnPoolAllocated() {} // 0x00000001834EBAA0-0x00000001834EBB40
	[BlackList] // 0x000000018988D840-0x000000018988D880
	// [XID] // 0x000000018988D840-0x000000018988D880
	public virtual void OnBeforePoolRecycled() {} // 0x00000001834EBA00-0x00000001834EBAA0
}

