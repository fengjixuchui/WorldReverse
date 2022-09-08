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
public class TrialAvatarTemplateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16244
{
	// Fields
	protected SimpleSafeUInt32 trialAvatarLevelRawNum; // 0x10
	protected SimpleSafeUInt32[] _trialReliquaryList; // 0x18
	protected SimpleSafeUInt32[] _trialTalentList; // 0x20
	protected SimpleSafeUInt32[] _trialInherentProudSkillList; // 0x28
	protected SimpleSafeUInt32 trialAvatarSkillLevelRawNum; // 0x30

	// Properties
	public uint trialAvatarLevel { /* [XID] */ /* 0x0000000189B4C560-0x0000000189B4C580 */ get => default; /* [XID] */ /* 0x0000000189B53B00-0x0000000189B53B20 */ protected set {} } // 0x0000000183E0CF20-0x0000000183E0CFF0 0x0000000183E0D8D0-0x0000000183E0D9B0
	public SimpleSafeUInt32[] trialReliquaryList { /* [XID] */ /* 0x0000000189B5B430-0x0000000189B5B450 */ get => default; /* [XID] */ /* 0x0000000189B62880-0x0000000189B628A0 */ protected set {} } // 0x0000000183E0BB60-0x0000000183E0BC00 0x0000000183E0D600-0x0000000183E0D6B0
	public SimpleSafeUInt32[] trialTalentList { /* [XID] */ /* 0x0000000189B6A3F0-0x0000000189B6A410 */ get => default; /* [XID] */ /* 0x0000000189B71BB0-0x0000000189B71BD0 */ protected set {} } // 0x0000000183E0D6B0-0x0000000183E0D750 0x0000000183E0CFF0-0x0000000183E0D0A0
	public SimpleSafeUInt32[] trialInherentProudSkillList { /* [XID] */ /* 0x0000000189B78F00-0x0000000189B78F20 */ get => default; /* [XID] */ /* 0x0000000189B80490-0x0000000189B804B0 */ protected set {} } // 0x0000000183E0D750-0x0000000183E0D7F0 0x0000000183E0BC00-0x0000000183E0BCB0
	public uint trialAvatarSkillLevel { /* [XID] */ /* 0x0000000189B87FA0-0x0000000189B87FC0 */ get => default; /* [XID] */ /* 0x0000000189B8F1B0-0x0000000189B8F1D0 */ protected set {} } // 0x0000000183E0BA90-0x0000000183E0BB60 0x0000000183E0D7F0-0x0000000183E0D8D0

	// Constructors
	public TrialAvatarTemplateExcelConfig() {} // 0x0000000183E0DB90-0x0000000183E0DBF0

	// Methods
	// [IDTag] // 0x0000000189B96660-0x0000000189B966A0
	// [XID] // 0x0000000189B96660-0x0000000189B966A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183E0C5E0-0x0000000183E0CF20
	// [IDTag] // 0x0000000189BA0C50-0x0000000189BA0C90
	// [XID] // 0x0000000189BA0C50-0x0000000189BA0C90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183E0BCB0-0x0000000183E0C5E0
	// [XID] // 0x0000000189BAB220-0x0000000189BAB240
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3564 */, bool useObjectPool = false /* Metadata: 0x00AF3568 */) => default; // 0x0000000183E0D0A0-0x0000000183E0D600
	[BlackList] // 0x0000000189BB2810-0x0000000189BB2850
	// [XID] // 0x0000000189BB2810-0x0000000189BB2850
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E0B900-0x0000000183E0B9A0
	[BlackList] // 0x0000000189BBCC60-0x0000000189BBCCA0
	// [XID] // 0x0000000189BBCC60-0x0000000189BBCCA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E0B9A0-0x0000000183E0BA90
	[BlackList] // 0x0000000189BC7780-0x0000000189BC77C0
	// [XID] // 0x0000000189BC7780-0x0000000189BC77C0
	public virtual void ReturnToObjectPool() {} // 0x0000000183E0DAF0-0x0000000183E0DB90
	[BlackList] // 0x0000000189BD22A0-0x0000000189BD22E0
	// [XID] // 0x0000000189BD22A0-0x0000000189BD22E0
	public virtual void OnPoolAllocated() {} // 0x0000000183E0DA50-0x0000000183E0DAF0
	[BlackList] // 0x0000000189BDCCC0-0x0000000189BDCD00
	// [XID] // 0x0000000189BDCCC0-0x0000000189BDCD00
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E0D9B0-0x0000000183E0DA50
}

