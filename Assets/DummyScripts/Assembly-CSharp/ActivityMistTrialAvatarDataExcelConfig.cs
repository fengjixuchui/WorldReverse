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
public class ActivityMistTrialAvatarDataExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15139
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x14
	protected SimpleSafeUInt32 trialAvatarIdRawNum; // 0x18

	// Properties
	public uint Id { /* [XID] */ /* 0x000000018988AA30-0x000000018988AA50 */ get => default; /* [XID] */ /* 0x0000000189891F40-0x0000000189891F60 */ protected set {} } // 0x0000000184C53300-0x0000000184C533D0 0x0000000184C538C0-0x0000000184C539A0
	public uint scheduleId { /* [XID] */ /* 0x00000001898998D0-0x00000001898998F0 */ get => default; /* [XID] */ /* 0x00000001898A09B0-0x00000001898A09D0 */ protected set {} } // 0x0000000184C52B20-0x0000000184C52BF0 0x0000000184C537E0-0x0000000184C538C0
	public uint trialAvatarId { /* [XID] */ /* 0x00000001898A8070-0x00000001898A8090 */ get => default; /* [XID] */ /* 0x00000001898AFBD0-0x00000001898AFBF0 */ protected set {} } // 0x0000000184C539A0-0x0000000184C53A70 0x0000000184C53A70-0x0000000184C53B50

	// Constructors
	public ActivityMistTrialAvatarDataExcelConfig() {} // 0x0000000184C53D30-0x0000000184C53D90

	// Methods
	// [IDTag] // 0x00000001898B70B0-0x00000001898B70F0
	// [XID] // 0x00000001898B70B0-0x00000001898B70F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184C52D80-0x0000000184C53060
	// [IDTag] // 0x00000001898C18A0-0x00000001898C18E0
	// [XID] // 0x00000001898C18A0-0x00000001898C18E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184C53060-0x0000000184C53300
	// [XID] // 0x00000001898CBFD0-0x00000001898CBFF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF01F4 */, bool useObjectPool = false /* Metadata: 0x00AF01F8 */) => default; // 0x0000000184C533D0-0x0000000184C537E0
	[BlackList] // 0x00000001898D3830-0x00000001898D3870
	// [XID] // 0x00000001898D3830-0x00000001898D3870
	public virtual void AutoAllocTypeFields() {} // 0x0000000184C52BF0-0x0000000184C52C90
	[BlackList] // 0x00000001898DE780-0x00000001898DE7C0
	// [XID] // 0x00000001898DE780-0x00000001898DE7C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184C52C90-0x0000000184C52D80
	[BlackList] // 0x00000001898E9240-0x00000001898E9280
	// [XID] // 0x00000001898E9240-0x00000001898E9280
	public virtual void ReturnToObjectPool() {} // 0x0000000184C53C90-0x0000000184C53D30
	[BlackList] // 0x00000001898F3880-0x00000001898F38C0
	// [XID] // 0x00000001898F3880-0x00000001898F38C0
	public virtual void OnPoolAllocated() {} // 0x0000000184C53BF0-0x0000000184C53C90
	[BlackList] // 0x00000001898FE1A0-0x00000001898FE1E0
	// [XID] // 0x00000001898FE1A0-0x00000001898FE1E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184C53B50-0x0000000184C53BF0
}

