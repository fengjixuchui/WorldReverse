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
public class ActivitySkillExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15230
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected ActivitySkillTarget _skillTarget; // 0x14
	protected string _abilityName; // 0x18
	protected string _globalValueKey; // 0x20
	protected SimpleSafeUInt32 energyMinRawNum; // 0x28
	protected SimpleSafeUInt32 energyMaxRawNum; // 0x2C
	protected SimpleSafeFloat cdTimeRawNum; // 0x30
	protected SimpleSafeFloat guideTimeRawNum; // 0x34
	protected string _skillIcon; // 0x38
	protected string[] _guideKey; // 0x40
	protected OpenStateType _guideOpenState; // 0x48
	protected uint _unableTextTextMapHash; // 0x4C
	protected uint _channelTextTextMapHash; // 0x50
	protected uint _interruptTextTextMapHash; // 0x54

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AECEA0-0x0000000189AECEC0 */ get => default; /* [XID] */ /* 0x0000000189AF47D0-0x0000000189AF47F0 */ protected set {} } // 0x00000001829B3100-0x00000001829B31D0 0x00000001829B19D0-0x00000001829B1AB0
	public ActivitySkillTarget skillTarget { /* [XID] */ /* 0x0000000189AFBE00-0x0000000189AFBE20 */ get => default; /* [XID] */ /* 0x0000000189B036F0-0x0000000189B03710 */ protected set {} } // 0x00000001829AF9A0-0x00000001829AFA40 0x00000001829B3390-0x00000001829B3440
	public string abilityName { /* [XID] */ /* 0x0000000189B0AE20-0x0000000189B0AE40 */ get => default; /* [XID] */ /* 0x0000000189B126A0-0x0000000189B126C0 */ protected set {} } // 0x00000001829B2940-0x00000001829B29E0 0x00000001829B2F10-0x00000001829B2FC0
	public string globalValueKey { /* [XID] */ /* 0x0000000189B19990-0x0000000189B199B0 */ get => default; /* [XID] */ /* 0x0000000189B20F70-0x0000000189B20F90 */ protected set {} } // 0x00000001829B1B60-0x00000001829B1C00 0x00000001829AFF40-0x00000001829AFFF0
	public uint energyMin { /* [XID] */ /* 0x0000000189B286B0-0x0000000189B286D0 */ get => default; /* [XID] */ /* 0x0000000189B2FAB0-0x0000000189B2FAD0 */ protected set {} } // 0x00000001829B1780-0x00000001829B1850 0x00000001829B1850-0x00000001829B1930
	public uint energyMax { /* [XID] */ /* 0x0000000189B37470-0x0000000189B37490 */ get => default; /* [XID] */ /* 0x0000000189B3ECE0-0x0000000189B3ED00 */ protected set {} } // 0x00000001829B29E0-0x00000001829B2AB0 0x00000001829B31D0-0x00000001829B32B0
	public float cdTime { /* [XID] */ /* 0x0000000189B467A0-0x0000000189B467C0 */ get => default; /* [XID] */ /* 0x0000000189B4DCE0-0x0000000189B4DD00 */ protected set {} } // 0x00000001829B1C00-0x00000001829B1CE0 0x00000001829B32B0-0x00000001829B3390
	public float guideTime { /* [XID] */ /* 0x0000000189B55550-0x0000000189B55570 */ get => default; /* [XID] */ /* 0x0000000189B5CE90-0x0000000189B5CEB0 */ protected set {} } // 0x00000001829B2AB0-0x00000001829B2B90 0x00000001829B16A0-0x00000001829B1780
	public string skillIcon { /* [XID] */ /* 0x0000000189B64550-0x0000000189B64570 */ get => default; /* [XID] */ /* 0x0000000189B6BA50-0x0000000189B6BA70 */ protected set {} } // 0x00000001829B1930-0x00000001829B19D0 0x00000001829AFFF0-0x00000001829B00A0
	public string[] guideKey { /* [XID] */ /* 0x0000000189B73330-0x0000000189B73350 */ get => default; /* [XID] */ /* 0x0000000189B7A870-0x0000000189B7A890 */ protected set {} } // 0x00000001829B28A0-0x00000001829B2940 0x00000001829B01F0-0x00000001829B02A0
	public OpenStateType guideOpenState { /* [XID] */ /* 0x0000000189B82050-0x0000000189B82070 */ get => default; /* [XID] */ /* 0x0000000189B89810-0x0000000189B89830 */ protected set {} } // 0x00000001829B1600-0x00000001829B16A0 0x00000001829B1AB0-0x00000001829B1B60
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unableTextTextMapHash { /* [XID] */ /* 0x0000000189B90DD0-0x0000000189B90DF0 */ get => default; /* [XID] */ /* 0x0000000189B98140-0x0000000189B98160 */ protected set {} } // 0x00000001829B2DC0-0x00000001829B2E60 0x00000001829B2B90-0x00000001829B2C40
	public string unableText { /* [XID] */ /* 0x0000000189B9F5F0-0x0000000189B9F610 */ get => default; } // 0x00000001829AFDC0-0x00000001829AFF40 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint channelTextTextMapHash { /* [XID] */ /* 0x0000000189BA6DA0-0x0000000189BA6DC0 */ get => default; /* [XID] */ /* 0x0000000189BADF60-0x0000000189BADF80 */ protected set {} } // 0x00000001829B1CE0-0x00000001829B1D80 0x00000001829B0140-0x00000001829B01F0
	public string channelText { /* [XID] */ /* 0x0000000189BB5830-0x0000000189BB5850 */ get => default; } // 0x00000001829AFC40-0x00000001829AFDC0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint interruptTextTextMapHash { /* [XID] */ /* 0x0000000189BBCF00-0x0000000189BBCF20 */ get => default; /* [XID] */ /* 0x0000000189BC4B60-0x0000000189BC4B80 */ protected set {} } // 0x00000001829B00A0-0x00000001829B0140 0x00000001829B2E60-0x00000001829B2F10
	public string interruptText { /* [XID] */ /* 0x0000000189BCC5A0-0x0000000189BCC5C0 */ get => default; } // 0x00000001829B2C40-0x00000001829B2DC0 

	// Constructors
	public ActivitySkillExcelConfig() {} // 0x00000001829B34E0-0x00000001829B3540

	// Methods
	// [IDTag] // 0x0000000189BD3C50-0x0000000189BD3C90
	// [XID] // 0x0000000189BD3C50-0x0000000189BD3C90
	public virtual bool ParseFromLine(string line) => default; // 0x00000001829B02A0-0x00000001829B0C40
	// [IDTag] // 0x0000000189BDE580-0x0000000189BDE5C0
	// [XID] // 0x0000000189BDE580-0x0000000189BDE5C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001829B0C40-0x00000001829B1600
	// [XID] // 0x00000001895EDFB0-0x00000001895EDFD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0471 */, bool useObjectPool = false /* Metadata: 0x00AF0475 */) => default; // 0x00000001829B1D80-0x00000001829B28A0
	[BlackList] // 0x00000001895F5710-0x00000001895F5750
	// [XID] // 0x00000001895F5710-0x00000001895F5750
	public virtual void AutoAllocTypeFields() {} // 0x00000001829AFA40-0x00000001829AFAE0
	[BlackList] // 0x00000001895FFD70-0x00000001895FFDB0
	// [XID] // 0x00000001895FFD70-0x00000001895FFDB0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001829AFAE0-0x00000001829AFC40
	[BlackList] // 0x000000018960A7F0-0x000000018960A830
	// [XID] // 0x000000018960A7F0-0x000000018960A830
	public virtual void ReturnToObjectPool() {} // 0x00000001829B3440-0x00000001829B34E0
	[BlackList] // 0x0000000189614F40-0x0000000189614F80
	// [XID] // 0x0000000189614F40-0x0000000189614F80
	public virtual void OnPoolAllocated() {} // 0x00000001829B3060-0x00000001829B3100
	[BlackList] // 0x000000018961F700-0x000000018961F740
	// [XID] // 0x000000018961F700-0x000000018961F740
	public virtual void OnBeforePoolRecycled() {} // 0x00000001829B2FC0-0x00000001829B3060
}

