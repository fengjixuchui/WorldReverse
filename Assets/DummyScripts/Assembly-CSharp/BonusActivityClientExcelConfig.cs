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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BonusActivityClientExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16167
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected BonusActivityType _bonusActivityType; // 0x14
	protected SimpleSafeUInt32 avatarConfigIdRawNum; // 0x18
	protected SimpleSafeUInt32[] _voiceIndexList; // 0x20
	protected SimpleSafeUInt32 questIdRawNum; // 0x28
	protected SimpleSafeUInt32 openPlayerLevelRawNum; // 0x2C
	protected string _perfabPath; // 0x30
	protected uint _unlockTipsTextMapHash; // 0x38

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189707AF0-0x0000000189707B10 */ get => default; /* [XID] */ /* 0x000000018970F520-0x000000018970F540 */ protected set {} } // 0x00000001836C3E00-0x00000001836C3ED0 0x00000001836C2FA0-0x00000001836C3080
	public BonusActivityType bonusActivityType { /* [XID] */ /* 0x0000000189716900-0x0000000189716920 */ get => default; /* [XID] */ /* 0x000000018971E340-0x000000018971E360 */ protected set {} } // 0x00000001836C39F0-0x00000001836C3A90 0x00000001836C3130-0x00000001836C31E0
	public uint avatarConfigId { /* [XID] */ /* 0x0000000189725880-0x00000001897258A0 */ get => default; /* [XID] */ /* 0x000000018972CDA0-0x000000018972CDC0 */ protected set {} } // 0x00000001836C3920-0x00000001836C39F0 0x00000001836C1CF0-0x00000001836C1DD0
	public SimpleSafeUInt32[] voiceIndexList { /* [XID] */ /* 0x0000000189734550-0x0000000189734570 */ get => default; /* [XID] */ /* 0x000000018973BF20-0x000000018973BF40 */ protected set {} } // 0x00000001836C2E20-0x00000001836C2EC0 0x00000001836C3B70-0x00000001836C3C20
	public uint questId { /* [XID] */ /* 0x00000001897436F0-0x0000000189743710 */ get => default; /* [XID] */ /* 0x000000018974B380-0x000000018974B3A0 */ protected set {} } // 0x00000001836C2CB0-0x00000001836C2D80 0x00000001836C2EC0-0x00000001836C2FA0
	public uint openPlayerLevel { /* [XID] */ /* 0x0000000189752510-0x0000000189752530 */ get => default; /* [XID] */ /* 0x0000000189759AA0-0x0000000189759AC0 */ protected set {} } // 0x00000001836C18E0-0x00000001836C19B0 0x00000001836C3A90-0x00000001836C3B70
	public string perfabPath { /* [XID] */ /* 0x00000001897616F0-0x0000000189761710 */ get => default; /* [XID] */ /* 0x0000000189768AA0-0x0000000189768AC0 */ protected set {} } // 0x00000001836C3C20-0x00000001836C3CC0 0x00000001836C1DD0-0x00000001836C1E80
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unlockTipsTextMapHash { /* [XID] */ /* 0x0000000189770210-0x0000000189770230 */ get => default; /* [XID] */ /* 0x0000000189777890-0x00000001897778B0 */ protected set {} } // 0x00000001836C2D80-0x00000001836C2E20 0x00000001836C3080-0x00000001836C3130
	public string unlockTips { /* [XID] */ /* 0x000000018977EF00-0x000000018977EF20 */ get => default; } // 0x00000001836C1B70-0x00000001836C1CF0 

	// Constructors
	public BonusActivityClientExcelConfig() {} // 0x00000001836C3F70-0x00000001836C3FD0

	// Methods
	// [IDTag] // 0x0000000189786900-0x0000000189786940
	// [XID] // 0x0000000189786900-0x0000000189786940
	public virtual bool ParseFromLine(string line) => default; // 0x00000001836C1E80-0x00000001836C25A0
	// [IDTag] // 0x0000000189790E90-0x0000000189790ED0
	// [XID] // 0x0000000189790E90-0x0000000189790ED0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001836C25A0-0x00000001836C2CB0
	// [XID] // 0x000000018979BFB0-0x000000018979BFD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3317 */, bool useObjectPool = false /* Metadata: 0x00AF331B */) => default; // 0x00000001836C31E0-0x00000001836C3920
	[BlackList] // 0x00000001897A3440-0x00000001897A3480
	// [XID] // 0x00000001897A3440-0x00000001897A3480
	public virtual void AutoAllocTypeFields() {} // 0x00000001836C19B0-0x00000001836C1A50
	[BlackList] // 0x00000001897ADAF0-0x00000001897ADB30
	// [XID] // 0x00000001897ADAF0-0x00000001897ADB30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836C1A50-0x00000001836C1B70
	[BlackList] // 0x00000001897B8980-0x00000001897B89C0
	// [XID] // 0x00000001897B8980-0x00000001897B89C0
	public virtual void ReturnToObjectPool() {} // 0x00000001836C3ED0-0x00000001836C3F70
	[BlackList] // 0x00000001897C37B0-0x00000001897C37F0
	// [XID] // 0x00000001897C37B0-0x00000001897C37F0
	public virtual void OnPoolAllocated() {} // 0x00000001836C3D60-0x00000001836C3E00
	[BlackList] // 0x00000001897CE0C0-0x00000001897CE100
	// [XID] // 0x00000001897CE0C0-0x00000001897CE100
	public virtual void OnBeforePoolRecycled() {} // 0x00000001836C3CC0-0x00000001836C3D60
}

