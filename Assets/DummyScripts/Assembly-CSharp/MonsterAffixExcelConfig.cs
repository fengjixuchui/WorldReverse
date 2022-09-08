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
public class MonsterAffixExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15843
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _affix; // 0x18
	protected string _comment; // 0x20
	protected string[] _abilityName; // 0x28
	protected bool _isCommon; // 0x30
	protected bool _preAdd; // 0x31
	protected string _isLegal; // 0x38
	protected string _iconPath; // 0x40
	protected SimpleSafeUInt32 radarHintIDRawNum; // 0x48
	protected string _generalSkillIcon; // 0x50

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898FF8F0-0x00000001898FF910 */ get => default; /* [XID] */ /* 0x0000000189907130-0x0000000189907150 */ protected set {} } // 0x0000000181C925D0-0x0000000181C926A0 0x0000000181C91690-0x0000000181C91770
	public string affix { /* [XID] */ /* 0x000000018990EA70-0x000000018990EA90 */ get => default; /* [XID] */ /* 0x00000001899161C0-0x00000001899161E0 */ protected set {} } // 0x0000000181C915F0-0x0000000181C91690 0x0000000181C926A0-0x0000000181C92750
	public string comment { /* [XID] */ /* 0x000000018991DBB0-0x000000018991DBD0 */ get => default; /* [XID] */ /* 0x0000000189925360-0x0000000189925380 */ protected set {} } // 0x0000000181C91400-0x0000000181C914A0 0x0000000181C912B0-0x0000000181C91360
	public string[] abilityName { /* [XID] */ /* 0x000000018962B910-0x000000018962B930 */ get => default; /* [XID] */ /* 0x0000000189933F20-0x0000000189933F40 */ protected set {} } // 0x0000000181C920B0-0x0000000181C92150 0x0000000181C923E0-0x0000000181C92490
	public bool isCommon { /* [XID] */ /* 0x000000018993BB30-0x000000018993BB50 */ get => default; /* [XID] */ /* 0x0000000189942CB0-0x0000000189942CD0 */ protected set {} } // 0x0000000181C91360-0x0000000181C91400 0x0000000181C91540-0x0000000181C915F0
	public bool preAdd { /* [XID] */ /* 0x000000018994A4A0-0x000000018994A4C0 */ get => default; /* [XID] */ /* 0x0000000189951F70-0x0000000189951F90 */ protected set {} } // 0x0000000181C914A0-0x0000000181C91540 0x0000000181C90180-0x0000000181C90230
	public string isLegal { /* [XID] */ /* 0x00000001899594F0-0x0000000189959510 */ get => default; /* [XID] */ /* 0x0000000189960DA0-0x0000000189960DC0 */ protected set {} } // 0x0000000181C92290-0x0000000181C92330 0x0000000181C91200-0x0000000181C912B0
	public string iconPath { /* [XID] */ /* 0x0000000189968500-0x0000000189968520 */ get => default; /* [XID] */ /* 0x000000018996FA00-0x000000018996FA20 */ protected set {} } // 0x0000000181C92150-0x0000000181C921F0 0x0000000181C92330-0x0000000181C923E0
	public uint radarHintID { /* [XID] */ /* 0x00000001899777E0-0x0000000189977800 */ get => default; /* [XID] */ /* 0x000000018997EA40-0x000000018997EA60 */ protected set {} } // 0x0000000181C8FF10-0x0000000181C8FFE0 0x0000000181C90230-0x0000000181C90310
	public string generalSkillIcon { /* [XID] */ /* 0x0000000189986350-0x0000000189986370 */ get => default; /* [XID] */ /* 0x000000018998DF60-0x000000018998DF80 */ protected set {} } // 0x0000000181C921F0-0x0000000181C92290 0x0000000181C91770-0x0000000181C91820

	// Constructors
	public MonsterAffixExcelConfig() {} // 0x0000000181C927F0-0x0000000181C92850

	// Methods
	// [IDTag] // 0x0000000189995AB0-0x0000000189995AF0
	// [XID] // 0x0000000189995AB0-0x0000000189995AF0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181C90310-0x0000000181C90A80
	// [IDTag] // 0x00000001899A0510-0x00000001899A0550
	// [XID] // 0x00000001899A0510-0x00000001899A0550
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C90A80-0x0000000181C91200
	// [XID] // 0x00000001899AAFA0-0x00000001899AAFC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2822 */, bool useObjectPool = false /* Metadata: 0x00AF2826 */) => default; // 0x0000000181C91820-0x0000000181C920B0
	[BlackList] // 0x00000001899B29B0-0x00000001899B29F0
	// [XID] // 0x00000001899B29B0-0x00000001899B29F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C8FFE0-0x0000000181C90080
	[BlackList] // 0x00000001899BCE10-0x00000001899BCE50
	// [XID] // 0x00000001899BCE10-0x00000001899BCE50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C90080-0x0000000181C90180
	[BlackList] // 0x00000001899C76B0-0x00000001899C76F0
	// [XID] // 0x00000001899C76B0-0x00000001899C76F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181C92750-0x0000000181C927F0
	[BlackList] // 0x00000001899D1D60-0x00000001899D1DA0
	// [XID] // 0x00000001899D1D60-0x00000001899D1DA0
	public virtual void OnPoolAllocated() {} // 0x0000000181C92530-0x0000000181C925D0
	[BlackList] // 0x00000001899DC1F0-0x00000001899DC230
	// [XID] // 0x00000001899DC1F0-0x00000001899DC230
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C92490-0x0000000181C92530
}

