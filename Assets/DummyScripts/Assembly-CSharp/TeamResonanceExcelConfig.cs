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
public class TeamResonanceExcelConfig : BaseTalentConfig, IAutoAllocRecycle // TypeDefIndex: 16179
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 teamResonanceIdRawNum; // 0x28
	protected SimpleSafeUInt32 teamResonanceGroupIdRawNum; // 0x2C
	protected SimpleSafeUInt32 levelRawNum; // 0x30
	protected SimpleSafeUInt32 fireAvatarCountRawNum; // 0x34
	protected SimpleSafeUInt32 waterAvatarCountRawNum; // 0x38
	protected SimpleSafeUInt32 grassAvatarCountRawNum; // 0x3C
	protected SimpleSafeUInt32 electricAvatarCountRawNum; // 0x40
	protected SimpleSafeUInt32 iceAvatarCountRawNum; // 0x44
	protected SimpleSafeUInt32 windAvatarCountRawNum; // 0x48
	protected SimpleSafeUInt32 rockAvatarCountRawNum; // 0x4C
	protected TeamResonanceCondType _cond; // 0x50
	protected SimpleSafeUInt32 minTotalPromoteLevelRawNum; // 0x54
	protected uint _nameTextMapHash; // 0x58
	protected uint _descTextMapHash; // 0x5C

	// Properties
	public uint teamResonanceId { /* [XID] */ /* 0x0000000189A8C7F0-0x0000000189A8C810 */ get => default; /* [XID] */ /* 0x0000000189A93C10-0x0000000189A93C30 */ protected set {} } // 0x000000018257D770-0x000000018257D840 0x000000018257EF30-0x000000018257F010
	public uint teamResonanceGroupId { /* [XID] */ /* 0x0000000189A9B6A0-0x0000000189A9B6C0 */ get => default; /* [XID] */ /* 0x0000000189AA2A00-0x0000000189AA2A20 */ protected set {} } // 0x000000018257D6A0-0x000000018257D770 0x000000018257B860-0x000000018257B940
	public uint level { /* [XID] */ /* 0x0000000189AAA0E0-0x0000000189AAA100 */ get => default; /* [XID] */ /* 0x0000000189AB1E80-0x0000000189AB1EA0 */ protected set {} } // 0x000000018257E980-0x000000018257EA50 0x000000018257E8A0-0x000000018257E980
	public uint fireAvatarCount { /* [XID] */ /* 0x0000000189AB9130-0x0000000189AB9150 */ get => default; /* [XID] */ /* 0x0000000189AC0D10-0x0000000189AC0D30 */ protected set {} } // 0x000000018257F0E0-0x000000018257F1B0 0x000000018257EDF0-0x000000018257EED0
	public uint waterAvatarCount { /* [XID] */ /* 0x0000000189AC8750-0x0000000189AC8770 */ get => default; /* [XID] */ /* 0x0000000189ACFE70-0x0000000189ACFE90 */ protected set {} } // 0x000000018257B9F0-0x000000018257BAC0 0x000000018257B5C0-0x000000018257B6A0
	public uint grassAvatarCount { /* [XID] */ /* 0x0000000189AD7C80-0x0000000189AD7CA0 */ get => default; /* [XID] */ /* 0x0000000189ADF7B0-0x0000000189ADF7D0 */ protected set {} } // 0x000000018257D4F0-0x000000018257D5C0 0x000000018257ED10-0x000000018257EDF0
	public uint electricAvatarCount { /* [XID] */ /* 0x0000000189AE6F70-0x0000000189AE6F90 */ get => default; /* [XID] */ /* 0x0000000189AEEA80-0x0000000189AEEAA0 */ protected set {} } // 0x000000018257F1B0-0x000000018257F280 0x000000018257BB20-0x000000018257BC00
	public uint iceAvatarCount { /* [XID] */ /* 0x0000000189AF6090-0x0000000189AF60B0 */ get => default; /* [XID] */ /* 0x0000000189AFD5F0-0x0000000189AFD610 */ protected set {} } // 0x000000018257D420-0x000000018257D4F0 0x000000018257B6A0-0x000000018257B780
	public uint windAvatarCount { /* [XID] */ /* 0x0000000189B04D40-0x0000000189B04D60 */ get => default; /* [XID] */ /* 0x0000000189B0C550-0x0000000189B0C570 */ protected set {} } // 0x000000018257D350-0x000000018257D420 0x000000018257D5C0-0x000000018257D6A0
	public uint rockAvatarCount { /* [XID] */ /* 0x0000000189B13A90-0x0000000189B13AB0 */ get => default; /* [XID] */ /* 0x0000000189B1B140-0x0000000189B1B160 */ protected set {} } // 0x000000018257EAF0-0x000000018257EBC0 0x000000018257B780-0x000000018257B860
	public TeamResonanceCondType cond { /* [XID] */ /* 0x0000000189B228B0-0x0000000189B228D0 */ get => default; /* [XID] */ /* 0x0000000189B29E20-0x0000000189B29E40 */ protected set {} } // 0x000000018257EA50-0x000000018257EAF0 0x000000018257B470-0x000000018257B520
	public uint minTotalPromoteLevel { /* [XID] */ /* 0x0000000189B31470-0x0000000189B31490 */ get => default; /* [XID] */ /* 0x0000000189B38930-0x0000000189B38950 */ protected set {} } // 0x000000018257F010-0x000000018257F0E0 0x000000018257D840-0x000000018257D920
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189B402E0-0x0000000189B40300 */ get => default; /* [XID] */ /* 0x0000000189B47BC0-0x0000000189B47BE0 */ protected set {} } // 0x000000018257B520-0x000000018257B5C0 0x000000018257EC60-0x000000018257ED10
	public string name { /* [XID] */ /* 0x0000000189B4F450-0x0000000189B4F470 */ get => default; } // 0x000000018257F280-0x000000018257F400 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189B56D90-0x0000000189B56DB0 */ get => default; /* [XID] */ /* 0x0000000189B5E640-0x0000000189B5E660 */ protected set {} } // 0x000000018257EBC0-0x000000018257EC60 0x000000018257B940-0x000000018257B9F0
	public string desc { /* [XID] */ /* 0x0000000189B65BA0-0x0000000189B65BC0 */ get => default; } // 0x000000018257D920-0x000000018257DAA0 

	// Constructors
	public TeamResonanceExcelConfig() {} // 0x000000018257F4A0-0x000000018257F500

	// Methods
	// [IDTag] // 0x0000000189B6D120-0x0000000189B6D160
	// [XID] // 0x0000000189B6D120-0x0000000189B6D160
	public virtual bool ParseFromLine(string line) => default; // 0x000000018257BC00-0x000000018257C840
	// [IDTag] // 0x0000000189B776F0-0x0000000189B77730
	// [XID] // 0x0000000189B776F0-0x0000000189B77730
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018257C840-0x000000018257D350
	// [XID] // 0x0000000189B81F30-0x0000000189B81F50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3377 */, bool useObjectPool = false /* Metadata: 0x00AF337B */) => default; // 0x000000018257DB90-0x000000018257E8A0
	[BlackList] // 0x0000000189B89630-0x0000000189B89670
	// [XID] // 0x0000000189B89630-0x0000000189B89670
	public override void AutoAllocTypeFields() {} // 0x000000018257B190-0x000000018257B230
	[BlackList] // 0x0000000189B939B0-0x0000000189B939F0
	// [XID] // 0x0000000189B939B0-0x0000000189B939F0
	public override void AutoRecycleTypeFields() {} // 0x000000018257B230-0x000000018257B3D0
	[BlackList] // 0x0000000189B9DB60-0x0000000189B9DBA0
	// [XID] // 0x0000000189B9DB60-0x0000000189B9DBA0
	public override void ReturnToObjectPool() {} // 0x000000018257F400-0x000000018257F4A0
}

