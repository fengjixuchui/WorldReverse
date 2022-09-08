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
public class SeaLampSectionMiniQuestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15185
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 sectionIdRawNum; // 0x14
	protected SimpleSafeUInt32 openDayRawNum; // 0x18
	protected bool _isSpecial; // 0x1C
	protected SimpleSafeUInt32 miniQuestIdRawNum; // 0x20
	protected uint _nameTextMapHash; // 0x24
	protected uint _descTextMapHash; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189697E60-0x0000000189697E80 */ get => default; /* [XID] */ /* 0x000000018969F0F0-0x000000018969F110 */ protected set {} } // 0x0000000181262370-0x0000000181262440 0x0000000181261650-0x0000000181261730
	public uint sectionId { /* [XID] */ /* 0x00000001896A6590-0x00000001896A65B0 */ get => default; /* [XID] */ /* 0x00000001896ADA90-0x00000001896ADAB0 */ protected set {} } // 0x0000000181261810-0x00000001812618E0 0x00000001812613F0-0x00000001812614D0
	public uint openDay { /* [XID] */ /* 0x00000001896B52F0-0x00000001896B5310 */ get => default; /* [XID] */ /* 0x00000001896BC4C0-0x00000001896BC4E0 */ protected set {} } // 0x0000000181262160-0x0000000181262230 0x0000000181260550-0x0000000181260630
	public bool isSpecial { /* [XID] */ /* 0x00000001896C3B80-0x00000001896C3BA0 */ get => default; /* [XID] */ /* 0x00000001896CB030-0x00000001896CB050 */ protected set {} } // 0x00000001812620C0-0x0000000181262160 0x0000000181260A00-0x0000000181260AB0
	public uint miniQuestId { /* [XID] */ /* 0x00000001896D25C0-0x00000001896D25E0 */ get => default; /* [XID] */ /* 0x00000001896DA070-0x00000001896DA090 */ protected set {} } // 0x00000001812607E0-0x00000001812608B0 0x0000000181261730-0x0000000181261810
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001896E1630-0x00000001896E1650 */ get => default; /* [XID] */ /* 0x00000001896E89C0-0x00000001896E89E0 */ protected set {} } // 0x00000001812608B0-0x0000000181260950 0x0000000181262010-0x00000001812620C0
	public string name { /* [XID] */ /* 0x00000001896EFD80-0x00000001896EFDA0 */ get => default; } // 0x0000000181262440-0x00000001812625C0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001896F7750-0x00000001896F7770 */ get => default; /* [XID] */ /* 0x00000001896FF1D0-0x00000001896FF1F0 */ protected set {} } // 0x0000000181261F70-0x0000000181262010 0x0000000181260950-0x0000000181260A00
	public string desc { /* [XID] */ /* 0x0000000189706420-0x0000000189706440 */ get => default; } // 0x00000001812614D0-0x0000000181261650 

	// Constructors
	public SeaLampSectionMiniQuestExcelConfig() {} // 0x0000000181262660-0x00000001812626C0

	// Methods
	// [IDTag] // 0x000000018970DD30-0x000000018970DD70
	// [XID] // 0x000000018970DD30-0x000000018970DD70
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181260F40-0x00000001812613F0
	// [IDTag] // 0x0000000189718310-0x0000000189718350
	// [XID] // 0x0000000189718310-0x0000000189718350
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181260AB0-0x0000000181260F40
	// [XID] // 0x00000001897228E0-0x0000000189722900
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0335 */, bool useObjectPool = false /* Metadata: 0x00AF0339 */) => default; // 0x00000001812618E0-0x0000000181261F70
	[BlackList] // 0x000000018972A040-0x000000018972A080
	// [XID] // 0x000000018972A040-0x000000018972A080
	public virtual void AutoAllocTypeFields() {} // 0x0000000181260630-0x00000001812606D0
	[BlackList] // 0x00000001897347F0-0x0000000189734830
	// [XID] // 0x00000001897347F0-0x0000000189734830
	public virtual void AutoRecycleTypeFields() {} // 0x00000001812606D0-0x00000001812607E0
	[BlackList] // 0x000000018973F5E0-0x000000018973F620
	// [XID] // 0x000000018973F5E0-0x000000018973F620
	public virtual void ReturnToObjectPool() {} // 0x00000001812625C0-0x0000000181262660
	[BlackList] // 0x0000000189749B20-0x0000000189749B60
	// [XID] // 0x0000000189749B20-0x0000000189749B60
	public virtual void OnPoolAllocated() {} // 0x00000001812622D0-0x0000000181262370
	[BlackList] // 0x0000000189753FA0-0x0000000189753FE0
	// [XID] // 0x0000000189753FA0-0x0000000189753FE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181262230-0x00000001812622D0
}

