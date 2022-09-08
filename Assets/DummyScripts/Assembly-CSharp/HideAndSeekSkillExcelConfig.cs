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
public class HideAndSeekSkillExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15124
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 challengeIDRawNum; // 0x14
	protected SimpleSafeUInt32 skillIDRawNum; // 0x18
	protected SimpleSafeUInt32 orderRawNum; // 0x1C
	protected HIDE_AND_SEEK_SKILL_CATEGORY _skillCategory; // 0x20
	protected HIDE_AND_SEEK_SKILL_SUB_CATEGORY _skillSubCategory; // 0x24
	protected bool _isDefault; // 0x28
	protected uint _categoryDescTextMapHash; // 0x2C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189721330-0x0000000189721350 */ get => default; /* [XID] */ /* 0x0000000189728950-0x0000000189728970 */ protected set {} } // 0x0000000180CB0AF0-0x0000000180CB0BC0 0x0000000180CAFC90-0x0000000180CAFD70
	public uint challengeID { /* [XID] */ /* 0x0000000189730120-0x0000000189730140 */ get => default; /* [XID] */ /* 0x0000000189737AA0-0x0000000189737AC0 */ protected set {} } // 0x0000000180CAF770-0x0000000180CAF840 0x0000000180CAEB40-0x0000000180CAEC20
	public uint skillID { /* [XID] */ /* 0x000000018973F620-0x000000018973F640 */ get => default; /* [XID] */ /* 0x00000001897469A0-0x00000001897469C0 */ protected set {} } // 0x0000000180CAFAE0-0x0000000180CAFBB0 0x0000000180CB08D0-0x0000000180CB09B0
	public uint order { /* [XID] */ /* 0x000000018974E390-0x000000018974E3B0 */ get => default; /* [XID] */ /* 0x00000001897559F0-0x0000000189755A10 */ protected set {} } // 0x0000000180CAEC20-0x0000000180CAECF0 0x0000000180CAFBB0-0x0000000180CAFC90
	public HIDE_AND_SEEK_SKILL_CATEGORY skillCategory { /* [XID] */ /* 0x000000018975CD10-0x000000018975CD30 */ get => default; /* [XID] */ /* 0x0000000189764460-0x0000000189764480 */ protected set {} } // 0x0000000180CAF840-0x0000000180CAF8E0 0x0000000180CB0780-0x0000000180CB0830
	public HIDE_AND_SEEK_SKILL_SUB_CATEGORY skillSubCategory { /* [XID] */ /* 0x000000018976BE00-0x000000018976BE20 */ get => default; /* [XID] */ /* 0x0000000189773300-0x0000000189773320 */ protected set {} } // 0x0000000180CB0830-0x0000000180CB08D0 0x0000000180CAF980-0x0000000180CAFA30
	public bool isDefault { /* [XID] */ /* 0x000000018977A940-0x000000018977A960 */ get => default; /* [XID] */ /* 0x00000001897825A0-0x00000001897825C0 */ protected set {} } // 0x0000000180CB04B0-0x0000000180CB0550 0x0000000180CAFA30-0x0000000180CAFAE0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint categoryDescTextMapHash { /* [XID] */ /* 0x00000001897898A0-0x00000001897898C0 */ get => default; /* [XID] */ /* 0x00000001897910D0-0x00000001897910F0 */ protected set {} } // 0x0000000180CAF8E0-0x0000000180CAF980 0x0000000180CB0550-0x0000000180CB0600
	public string categoryDesc { /* [XID] */ /* 0x0000000189798900-0x0000000189798920 */ get => default; } // 0x0000000180CB0600-0x0000000180CB0780 

	// Constructors
	public HideAndSeekSkillExcelConfig() {} // 0x0000000180CB0C60-0x0000000180CB0CC0

	// Methods
	// [IDTag] // 0x00000001897A0670-0x00000001897A06B0
	// [XID] // 0x00000001897A0670-0x00000001897A06B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000180CAF220-0x0000000180CAF770
	// [IDTag] // 0x00000001897AAB20-0x00000001897AAB60
	// [XID] // 0x00000001897AAB20-0x00000001897AAB60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000180CAECF0-0x0000000180CAF220
	// [XID] // 0x00000001897B5E10-0x00000001897B5E30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0178 */, bool useObjectPool = false /* Metadata: 0x00AF017C */) => default; // 0x0000000180CAFD70-0x0000000180CB04B0
	[BlackList] // 0x00000001897BDBE0-0x00000001897BDC20
	// [XID] // 0x00000001897BDBE0-0x00000001897BDC20
	public virtual void AutoAllocTypeFields() {} // 0x0000000180CAE990-0x0000000180CAEA30
	[BlackList] // 0x00000001897C8470-0x00000001897C84B0
	// [XID] // 0x00000001897C8470-0x00000001897C84B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180CAEA30-0x0000000180CAEB40
	[BlackList] // 0x00000001897D27F0-0x00000001897D2830
	// [XID] // 0x00000001897D27F0-0x00000001897D2830
	public virtual void ReturnToObjectPool() {} // 0x0000000180CB0BC0-0x0000000180CB0C60
	[BlackList] // 0x00000001897DCFB0-0x00000001897DCFF0
	// [XID] // 0x00000001897DCFB0-0x00000001897DCFF0
	public virtual void OnPoolAllocated() {} // 0x0000000180CB0A50-0x0000000180CB0AF0
	[BlackList] // 0x00000001897E7810-0x00000001897E7850
	// [XID] // 0x00000001897E7810-0x00000001897E7850
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180CB09B0-0x0000000180CB0A50
}

