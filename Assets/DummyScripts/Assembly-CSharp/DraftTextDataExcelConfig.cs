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
public class DraftTextDataExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15500
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 draftIdRawNum; // 0x10
	protected string _draftBtnName; // 0x18
	protected string _draftBtnTips; // 0x20
	protected uint _requirementDescTextMapHash; // 0x28
	protected uint _draftLimitReasonDescTextMapHash; // 0x2C
	protected uint _limitWarningDescTextMapHash; // 0x30
	protected uint _inviteDescTextMapHash; // 0x34
	protected uint _inviteGuestDescTextMapHash; // 0x38
	protected uint _inviteHostDescTextMapHash; // 0x3C
	protected uint _inviteWarningDescTextMapHash; // 0x40
	protected uint _draftTitleTextMapHash; // 0x44

	// Properties
	public uint draftId { /* [XID] */ /* 0x0000000189B95070-0x0000000189B95090 */ get => default; /* [XID] */ /* 0x0000000189B9C780-0x0000000189B9C7A0 */ protected set {} } // 0x0000000184CFB1E0-0x0000000184CFB2B0 0x0000000184CFCAA0-0x0000000184CFCB80
	public string draftBtnName { /* [XID] */ /* 0x0000000189BA3E50-0x0000000189BA3E70 */ get => default; /* [XID] */ /* 0x0000000189BAB3C0-0x0000000189BAB3E0 */ protected set {} } // 0x0000000184CFB2B0-0x0000000184CFB350 0x0000000184CFD8E0-0x0000000184CFD990
	public string draftBtnTips { /* [XID] */ /* 0x0000000189BB2990-0x0000000189BB29B0 */ get => default; /* [XID] */ /* 0x0000000189BB9E20-0x0000000189BB9E40 */ protected set {} } // 0x0000000184CFC090-0x0000000184CFC130 0x0000000184CFBFE0-0x0000000184CFC090
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint requirementDescTextMapHash { /* [XID] */ /* 0x0000000189BC1D90-0x0000000189BC1DB0 */ get => default; /* [XID] */ /* 0x0000000189BC9300-0x0000000189BC9320 */ protected set {} } // 0x0000000184CFAD00-0x0000000184CFADA0 0x0000000184CFC130-0x0000000184CFC1E0
	public string requirementDesc { /* [XID] */ /* 0x0000000189BD0B30-0x0000000189BD0B50 */ get => default; } // 0x0000000184CFC570-0x0000000184CFC6F0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint draftLimitReasonDescTextMapHash { /* [XID] */ /* 0x0000000189BD80B0-0x0000000189BD80D0 */ get => default; /* [XID] */ /* 0x0000000189BDFC20-0x0000000189BDFC40 */ protected set {} } // 0x0000000184CFDAD0-0x0000000184CFDB70 0x0000000184CFDE10-0x0000000184CFDEC0
	public string draftLimitReasonDesc { /* [XID] */ /* 0x00000001895EC7D0-0x00000001895EC7F0 */ get => default; } // 0x0000000184CFB060-0x0000000184CFB1E0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint limitWarningDescTextMapHash { /* [XID] */ /* 0x00000001895F3DD0-0x00000001895F3DF0 */ get => default; /* [XID] */ /* 0x00000001895FB650-0x00000001895FB670 */ protected set {} } // 0x0000000184CFDA30-0x0000000184CFDAD0 0x0000000184CFC9F0-0x0000000184CFCAA0
	public string limitWarningDesc { /* [XID] */ /* 0x0000000189602D90-0x0000000189602DB0 */ get => default; } // 0x0000000184CFC6F0-0x0000000184CFC870 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint inviteDescTextMapHash { /* [XID] */ /* 0x000000018960A790-0x000000018960A7B0 */ get => default; /* [XID] */ /* 0x0000000189611E40-0x0000000189611E60 */ protected set {} } // 0x0000000184CFAFC0-0x0000000184CFB060 0x0000000184CFC1E0-0x0000000184CFC290
	public string inviteDesc { /* [XID] */ /* 0x0000000189619720-0x0000000189619740 */ get => default; } // 0x0000000184CFC340-0x0000000184CFC4C0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint inviteGuestDescTextMapHash { /* [XID] */ /* 0x0000000189620C60-0x0000000189620C80 */ get => default; /* [XID] */ /* 0x00000001896282B0-0x00000001896282D0 */ protected set {} } // 0x0000000184CFD990-0x0000000184CFDA30 0x0000000184CFDC20-0x0000000184CFDCD0
	public string inviteGuestDesc { /* [XID] */ /* 0x000000018962FB60-0x000000018962FB80 */ get => default; } // 0x0000000184CFD540-0x0000000184CFD6C0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint inviteHostDescTextMapHash { /* [XID] */ /* 0x0000000189637720-0x0000000189637740 */ get => default; /* [XID] */ /* 0x000000018963EBE0-0x000000018963EC00 */ protected set {} } // 0x0000000184CFD4A0-0x0000000184CFD540 0x0000000184CFDB70-0x0000000184CFDC20
	public string inviteHostDesc { /* [XID] */ /* 0x0000000189646420-0x0000000189646440 */ get => default; } // 0x0000000184CFAE40-0x0000000184CFAFC0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint inviteWarningDescTextMapHash { /* [XID] */ /* 0x000000018964DB60-0x000000018964DB80 */ get => default; /* [XID] */ /* 0x0000000189655440-0x0000000189655460 */ protected set {} } // 0x0000000184CFADA0-0x0000000184CFAE40 0x0000000184CFC290-0x0000000184CFC340
	public string inviteWarningDesc { /* [XID] */ /* 0x000000018965CBE0-0x000000018965CC00 */ get => default; } // 0x0000000184CFC870-0x0000000184CFC9F0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint draftTitleTextMapHash { /* [XID] */ /* 0x0000000189664100-0x0000000189664120 */ get => default; /* [XID] */ /* 0x000000018966B760-0x000000018966B780 */ protected set {} } // 0x0000000184CFD840-0x0000000184CFD8E0 0x0000000184CFC4C0-0x0000000184CFC570
	public string draftTitle { /* [XID] */ /* 0x0000000189673520-0x0000000189673540 */ get => default; } // 0x0000000184CFD6C0-0x0000000184CFD840 

	// Constructors
	public DraftTextDataExcelConfig() {} // 0x0000000184CFDF60-0x0000000184CFDFC0

	// Methods
	// [IDTag] // 0x000000018967AD40-0x000000018967AD80
	// [XID] // 0x000000018967AD40-0x000000018967AD80
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184CFB9A0-0x0000000184CFBFE0
	// [IDTag] // 0x0000000189685580-0x00000001896855C0
	// [XID] // 0x0000000189685580-0x00000001896855C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184CFB350-0x0000000184CFB9A0
	// [XID] // 0x00000001896905A0-0x00000001896905C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C72 */, bool useObjectPool = false /* Metadata: 0x00AF1C76 */) => default; // 0x0000000184CFCB80-0x0000000184CFD4A0
	[BlackList] // 0x0000000189697DC0-0x0000000189697E00
	// [XID] // 0x0000000189697DC0-0x0000000189697E00
	public virtual void AutoAllocTypeFields() {} // 0x0000000184CFAB70-0x0000000184CFAC10
	[BlackList] // 0x00000001896A23C0-0x00000001896A2400
	// [XID] // 0x00000001896A23C0-0x00000001896A2400
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184CFAC10-0x0000000184CFAD00
	[BlackList] // 0x00000001896AC590-0x00000001896AC5D0
	// [XID] // 0x00000001896AC590-0x00000001896AC5D0
	public virtual void ReturnToObjectPool() {} // 0x0000000184CFDEC0-0x0000000184CFDF60
	[BlackList] // 0x00000001896B67E0-0x00000001896B6820
	// [XID] // 0x00000001896B67E0-0x00000001896B6820
	public virtual void OnPoolAllocated() {} // 0x0000000184CFDD70-0x0000000184CFDE10
	[BlackList] // 0x00000001896C0A80-0x00000001896C0AC0
	// [XID] // 0x00000001896C0A80-0x00000001896C0AC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184CFDCD0-0x0000000184CFDD70
}

