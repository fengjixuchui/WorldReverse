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
public class TrialAvatarActivityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16235
{
	// Fields
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x10
	protected SimpleSafeUInt32[] _avatarIndexIdList; // 0x18
	protected SimpleSafeUInt32[] _rewardIdList; // 0x20

	// Properties
	public uint scheduleId { /* [XID] */ /* 0x0000000189714FD0-0x0000000189714FF0 */ get => default; /* [XID] */ /* 0x000000018971CAC0-0x000000018971CAE0 */ protected set {} } // 0x00000001830D0080-0x00000001830D0150 0x00000001830D11D0-0x00000001830D12B0
	public SimpleSafeUInt32[] avatarIndexIdList { /* [XID] */ /* 0x0000000189723E90-0x0000000189723EB0 */ get => default; /* [XID] */ /* 0x000000018972B6F0-0x000000018972B710 */ protected set {} } // 0x00000001830D12B0-0x00000001830D1350 0x00000001830D02D0-0x00000001830D0380
	public SimpleSafeUInt32[] rewardIdList { /* [XID] */ /* 0x0000000189732EE0-0x0000000189732F00 */ get => default; /* [XID] */ /* 0x000000018973A570-0x000000018973A590 */ protected set {} } // 0x00000001830D1130-0x00000001830D11D0 0x00000001830D1350-0x00000001830D1400

	// Constructors
	public TrialAvatarActivityExcelConfig() {} // 0x00000001830D15E0-0x00000001830D1640

	// Methods
	// [IDTag] // 0x0000000189741F00-0x0000000189741F40
	// [XID] // 0x0000000189741F00-0x0000000189741F40
	public virtual bool ParseFromLine(string line) => default; // 0x00000001830D0380-0x00000001830D0870
	// [IDTag] // 0x000000018974CA20-0x000000018974CA60
	// [XID] // 0x000000018974CA20-0x000000018974CA60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001830D0870-0x00000001830D0D20
	// [XID] // 0x0000000189756F00-0x0000000189756F20
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF352E */, bool useObjectPool = false /* Metadata: 0x00AF3532 */) => default; // 0x00000001830D0D20-0x00000001830D1130
	[BlackList] // 0x000000018975E430-0x000000018975E470
	// [XID] // 0x000000018975E430-0x000000018975E470
	public virtual void AutoAllocTypeFields() {} // 0x00000001830D0150-0x00000001830D01F0
	[BlackList] // 0x0000000189768A60-0x0000000189768AA0
	// [XID] // 0x0000000189768A60-0x0000000189768AA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830D01F0-0x00000001830D02D0
	[BlackList] // 0x0000000189773180-0x00000001897731C0
	// [XID] // 0x0000000189773180-0x00000001897731C0
	public virtual void ReturnToObjectPool() {} // 0x00000001830D1540-0x00000001830D15E0
	[BlackList] // 0x000000018977DA20-0x000000018977DA60
	// [XID] // 0x000000018977DA20-0x000000018977DA60
	public virtual void OnPoolAllocated() {} // 0x00000001830D14A0-0x00000001830D1540
	[BlackList] // 0x00000001897880C0-0x0000000189788100
	// [XID] // 0x00000001897880C0-0x0000000189788100
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830D1400-0x00000001830D14A0
}

