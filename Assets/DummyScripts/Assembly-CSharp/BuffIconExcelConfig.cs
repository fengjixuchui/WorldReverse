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
public class BuffIconExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15298
{
	// Fields
	protected SimpleSafeInt32 buffIDRawNum; // 0x10
	protected string _icon; // 0x18
	protected SimpleSafeInt32 mutexTypeRawNum; // 0x20
	protected string _desc; // 0x28
	protected string _dispelEffect; // 0x30
	protected string _startEffect; // 0x38
	protected string _durationEffect; // 0x40

	// Properties
	public int buffID { /* [XID] */ /* 0x0000000189783CF0-0x0000000189783D10 */ get => default; /* [XID] */ /* 0x000000018978B4A0-0x000000018978B4C0 */ protected set {} } // 0x00000001850E0550-0x00000001850E0620 0x00000001850E06D0-0x00000001850E07B0
	public string icon { /* [XID] */ /* 0x0000000189792920-0x0000000189792940 */ get => default; /* [XID] */ /* 0x0000000189799E70-0x0000000189799E90 */ protected set {} } // 0x00000001850DEED0-0x00000001850DEF70 0x00000001850E04A0-0x00000001850E0550
	public int mutexType { /* [XID] */ /* 0x00000001897A1DA0-0x00000001897A1DC0 */ get => default; /* [XID] */ /* 0x00000001897A95C0-0x00000001897A95E0 */ protected set {} } // 0x00000001850DEE00-0x00000001850DEED0 0x00000001850E03C0-0x00000001850E04A0
	public string desc { /* [XID] */ /* 0x00000001897B0D60-0x00000001897B0D80 */ get => default; /* [XID] */ /* 0x00000001897B8A80-0x00000001897B8AA0 */ protected set {} } // 0x00000001850DFC80-0x00000001850DFD20 0x00000001850E0620-0x00000001850E06D0
	public string dispelEffect { /* [XID] */ /* 0x00000001897C0AA0-0x00000001897C0AC0 */ get => default; /* [XID] */ /* 0x00000001897C8430-0x00000001897C8450 */ protected set {} } // 0x00000001850DFA90-0x00000001850DFB30 0x00000001850E08F0-0x00000001850E09A0
	public string startEffect { /* [XID] */ /* 0x00000001897CF850-0x00000001897CF870 */ get => default; /* [XID] */ /* 0x00000001897D7180-0x00000001897D71A0 */ protected set {} } // 0x00000001850DF110-0x00000001850DF1B0 0x00000001850DFB30-0x00000001850DFBE0
	public string durationEffect { /* [XID] */ /* 0x00000001897DE6F0-0x00000001897DE710 */ get => default; /* [XID] */ /* 0x00000001897E6250-0x00000001897E6270 */ protected set {} } // 0x00000001850DFBE0-0x00000001850DFC80 0x00000001850DF1B0-0x00000001850DF260

	// Constructors
	public BuffIconExcelConfig() {} // 0x00000001850E0A40-0x00000001850E0AA0

	// Methods
	// [IDTag] // 0x00000001897EDC90-0x00000001897EDCD0
	// [XID] // 0x00000001897EDC90-0x00000001897EDCD0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001850DF260-0x00000001850DF680
	// [IDTag] // 0x00000001897F8580-0x00000001897F85C0
	// [XID] // 0x00000001897F8580-0x00000001897F85C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001850DF680-0x00000001850DFA90
	// [XID] // 0x0000000189802BA0-0x0000000189802BC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF06B7 */, bool useObjectPool = false /* Metadata: 0x00AF06BB */) => default; // 0x00000001850DFD20-0x00000001850E03C0
	[BlackList] // 0x000000018980A170-0x000000018980A1B0
	// [XID] // 0x000000018980A170-0x000000018980A1B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001850DEF70-0x00000001850DF010
	[BlackList] // 0x00000001898146B0-0x00000001898146F0
	// [XID] // 0x00000001898146B0-0x00000001898146F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001850DF010-0x00000001850DF110
	[BlackList] // 0x000000018981F2A0-0x000000018981F2E0
	// [XID] // 0x000000018981F2A0-0x000000018981F2E0
	public virtual void ReturnToObjectPool() {} // 0x00000001850E09A0-0x00000001850E0A40
	[BlackList] // 0x0000000189829810-0x0000000189829850
	// [XID] // 0x0000000189829810-0x0000000189829850
	public virtual void OnPoolAllocated() {} // 0x00000001850E0850-0x00000001850E08F0
	[BlackList] // 0x0000000189833DC0-0x0000000189833E00
	// [XID] // 0x0000000189833DC0-0x0000000189833E00
	public virtual void OnBeforePoolRecycled() {} // 0x00000001850E07B0-0x00000001850E0850
}

