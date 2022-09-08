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
public class AvatarLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15209
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected SimpleSafeUInt32 expRawNum; // 0x14
	protected SimpleSafeUInt32 smallTalentPointRawNum; // 0x18

	// Properties
	public uint level { /* [XID] */ /* 0x000000018967ADE0-0x000000018967AE00 */ get => default; /* [XID] */ /* 0x00000001896826B0-0x00000001896826D0 */ protected set {} } // 0x0000000182483DD0-0x0000000182483EA0 0x0000000182483CF0-0x0000000182483DD0
	public uint exp { /* [XID] */ /* 0x000000018968A130-0x000000018968A150 */ get => default; /* [XID] */ /* 0x0000000189691F30-0x0000000189691F50 */ protected set {} } // 0x0000000182483EA0-0x0000000182483F70 0x0000000182483720-0x0000000182483800
	public uint smallTalentPoint { /* [XID] */ /* 0x0000000189699420-0x0000000189699440 */ get => default; /* [XID] */ /* 0x00000001896A08B0-0x00000001896A08D0 */ protected set {} } // 0x00000001824830D0-0x00000001824831A0 0x0000000182483800-0x00000001824838E0

	// Constructors
	public AvatarLevelExcelConfig() {} // 0x0000000182484150-0x00000001824841B0

	// Methods
	// [IDTag] // 0x00000001896A7EA0-0x00000001896A7EE0
	// [XID] // 0x00000001896A7EA0-0x00000001896A7EE0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182483440-0x0000000182483720
	// [IDTag] // 0x00000001896B1CD0-0x00000001896B1D10
	// [XID] // 0x00000001896B1CD0-0x00000001896B1D10
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001824831A0-0x0000000182483440
	// [XID] // 0x00000001896BC4A0-0x00000001896BC4C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF03E4 */, bool useObjectPool = false /* Metadata: 0x00AF03E8 */) => default; // 0x00000001824838E0-0x0000000182483CF0
	[BlackList] // 0x00000001896C3B40-0x00000001896C3B80
	// [XID] // 0x00000001896C3B40-0x00000001896C3B80
	public virtual void AutoAllocTypeFields() {} // 0x0000000182482F40-0x0000000182482FE0
	[BlackList] // 0x00000001896CE1F0-0x00000001896CE230
	// [XID] // 0x00000001896CE1F0-0x00000001896CE230
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182482FE0-0x00000001824830D0
	[BlackList] // 0x00000001896D8570-0x00000001896D85B0
	// [XID] // 0x00000001896D8570-0x00000001896D85B0
	public virtual void ReturnToObjectPool() {} // 0x00000001824840B0-0x0000000182484150
	[BlackList] // 0x00000001896E2CA0-0x00000001896E2CE0
	// [XID] // 0x00000001896E2CA0-0x00000001896E2CE0
	public virtual void OnPoolAllocated() {} // 0x0000000182484010-0x00000001824840B0
	[BlackList] // 0x00000001896ECF20-0x00000001896ECF60
	// [XID] // 0x00000001896ECF20-0x00000001896ECF60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182483F70-0x0000000182484010
}

