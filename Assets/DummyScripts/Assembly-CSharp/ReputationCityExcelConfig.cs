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
public class ReputationCityExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16048
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 cityIdRawNum; // 0x10
	protected SimpleSafeUInt32[] _exploreAreaVec; // 0x18
	protected SimpleSafeUInt32 virtualItemIdRawNum; // 0x20
	protected OpenStateType _openState; // 0x24
	protected string _bgIconPath; // 0x28
	protected string _bgEffectPath; // 0x30
	protected uint _explainTitleTextMapHash; // 0x38
	protected uint _descTextMapHash; // 0x3C
	protected SimpleSafeUInt32 rewardItemIdRawNum; // 0x40
	protected uint _rewardItemDescTextMapHash; // 0x44
	protected string _rewardItemIcon; // 0x48
	protected string _rewardBgIcon; // 0x50
	protected string _cityIcon; // 0x58

	// Properties
	public uint cityId { /* [XID] */ /* 0x0000000189628210-0x0000000189628230 */ get => default; /* [XID] */ /* 0x000000018962FA60-0x000000018962FA80 */ protected set {} } // 0x0000000183408D50-0x0000000183408E20 0x0000000183407610-0x00000001834076F0
	public SimpleSafeUInt32[] exploreAreaVec { /* [XID] */ /* 0x0000000189637600-0x0000000189637620 */ get => default; /* [XID] */ /* 0x000000018963EB80-0x000000018963EBA0 */ protected set {} } // 0x0000000183407380-0x0000000183407420 0x0000000183407A60-0x0000000183407B10
	public uint virtualItemId { /* [XID] */ /* 0x00000001896462A0-0x00000001896462C0 */ get => default; /* [XID] */ /* 0x000000018964DAE0-0x000000018964DB00 */ protected set {} } // 0x0000000183405F80-0x0000000183406050 0x0000000183408850-0x0000000183408930
	public OpenStateType openState { /* [XID] */ /* 0x0000000189655300-0x0000000189655320 */ get => default; /* [XID] */ /* 0x000000018965CB60-0x000000018965CB80 */ protected set {} } // 0x0000000183405E30-0x0000000183405ED0 0x0000000183408BF0-0x0000000183408CA0
	public string bgIconPath { /* [XID] */ /* 0x0000000189664040-0x0000000189664060 */ get => default; /* [XID] */ /* 0x000000018966B6A0-0x000000018966B6C0 */ protected set {} } // 0x0000000183407420-0x00000001834074C0 0x0000000183405A10-0x0000000183405AC0
	public string bgEffectPath { /* [XID] */ /* 0x00000001896734A0-0x00000001896734C0 */ get => default; /* [XID] */ /* 0x000000018967ACA0-0x000000018967ACC0 */ protected set {} } // 0x0000000183408F60-0x0000000183409000 0x0000000183408CA0-0x0000000183408D50
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint explainTitleTextMapHash { /* [XID] */ /* 0x00000001896825B0-0x00000001896825D0 */ get => default; /* [XID] */ /* 0x0000000189689F70-0x0000000189689F90 */ protected set {} } // 0x0000000183407B10-0x0000000183407BB0 0x0000000183407790-0x0000000183407840
	public string explainTitle { /* [XID] */ /* 0x0000000189691D10-0x0000000189691D30 */ get => default; } // 0x0000000183406050-0x00000001834061D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189699240-0x0000000189699260 */ get => default; /* [XID] */ /* 0x00000001896A0770-0x00000001896A0790 */ protected set {} } // 0x0000000183408930-0x00000001834089D0 0x0000000183405ED0-0x0000000183405F80
	public string desc { /* [XID] */ /* 0x00000001896A7CC0-0x00000001896A7CE0 */ get => default; } // 0x0000000183407840-0x00000001834079C0 
	public uint rewardItemId { /* [XID] */ /* 0x00000001896AF110-0x00000001896AF130 */ get => default; /* [XID] */ /* 0x00000001896B6660-0x00000001896B6680 */ protected set {} } // 0x0000000183405D60-0x0000000183405E30 0x0000000183405C80-0x0000000183405D60
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint rewardItemDescTextMapHash { /* [XID] */ /* 0x00000001896BD960-0x00000001896BD980 */ get => default; /* [XID] */ /* 0x00000001896C5130-0x00000001896C5150 */ protected set {} } // 0x00000001834076F0-0x0000000183407790 0x00000001834087A0-0x0000000183408850
	public string rewardItemDesc { /* [XID] */ /* 0x00000001896CC730-0x00000001896CC750 */ get => default; } // 0x00000001834089D0-0x0000000183408B50 
	public string rewardItemIcon { /* [XID] */ /* 0x00000001896D39E0-0x00000001896D3A00 */ get => default; /* [XID] */ /* 0x00000001896DB460-0x00000001896DB480 */ protected set {} } // 0x0000000183407570-0x0000000183407610 0x0000000183407C60-0x0000000183407D10
	public string rewardBgIcon { /* [XID] */ /* 0x00000001896E2C00-0x00000001896E2C20 */ get => default; /* [XID] */ /* 0x00000001896EA240-0x00000001896EA260 */ protected set {} } // 0x00000001834079C0-0x0000000183407A60 0x00000001834074C0-0x0000000183407570
	public string cityIcon { /* [XID] */ /* 0x00000001896F1200-0x00000001896F1220 */ get => default; /* [XID] */ /* 0x00000001896F8B40-0x00000001896F8B60 */ protected set {} } // 0x0000000183408B50-0x0000000183408BF0 0x0000000183407BB0-0x0000000183407C60

	// Constructors
	public ReputationCityExcelConfig() {} // 0x00000001834090A0-0x0000000183409100

	// Methods
	// [IDTag] // 0x00000001897002E0-0x0000000189700320
	// [XID] // 0x00000001897002E0-0x0000000189700320
	public virtual bool ParseFromLine(string line) => default; // 0x00000001834061D0-0x0000000183406AA0
	// [IDTag] // 0x000000018970ABA0-0x000000018970ABE0
	// [XID] // 0x000000018970ABA0-0x000000018970ABE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183406AA0-0x0000000183407380
	// [XID] // 0x0000000189715070-0x0000000189715090
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2EDD */, bool useObjectPool = false /* Metadata: 0x00AF2EE1 */) => default; // 0x0000000183407D10-0x00000001834087A0
	[BlackList] // 0x000000018971CB80-0x000000018971CBC0
	// [XID] // 0x000000018971CB80-0x000000018971CBC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183405AC0-0x0000000183405B60
	[BlackList] // 0x0000000189727200-0x0000000189727240
	// [XID] // 0x0000000189727200-0x0000000189727240
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183405B60-0x0000000183405C80
	[BlackList] // 0x0000000189731600-0x0000000189731640
	// [XID] // 0x0000000189731600-0x0000000189731640
	public virtual void ReturnToObjectPool() {} // 0x0000000183409000-0x00000001834090A0
	[BlackList] // 0x000000018973BF60-0x000000018973BFA0
	// [XID] // 0x000000018973BF60-0x000000018973BFA0
	public virtual void OnPoolAllocated() {} // 0x0000000183408EC0-0x0000000183408F60
	[BlackList] // 0x0000000189746800-0x0000000189746840
	// [XID] // 0x0000000189746800-0x0000000189746840
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183408E20-0x0000000183408EC0
}

