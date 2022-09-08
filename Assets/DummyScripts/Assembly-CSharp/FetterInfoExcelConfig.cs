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
public class FetterInfoExcelConfig : FetterConfig, IAutoAllocRecycle // TypeDefIndex: 15612
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected bool _isHiden; // 0x28
	protected SimpleSafeUInt32 infoBirthMonthRawNum; // 0x2C
	protected SimpleSafeUInt32 infoBirthDayRawNum; // 0x30
	protected uint _avatarNativeTextMapHash; // 0x34
	protected uint _avatarVisionBeforTextMapHash; // 0x38
	protected uint _avatarConstellationBeforTextMapHash; // 0x3C
	protected uint _avatarTitleTextMapHash; // 0x40
	protected uint _avatarDetailTextMapHash; // 0x44
	protected AssocType _avatarAssocType; // 0x48
	protected uint _cvChineseTextMapHash; // 0x4C
	protected uint _cvJapaneseTextMapHash; // 0x50
	protected uint _cvEnglishTextMapHash; // 0x54
	protected uint _cvKoreanTextMapHash; // 0x58
	protected uint _avatarVisionAfterTextMapHash; // 0x5C
	protected uint _avatarConstellationAfterTextMapHash; // 0x60

	// Properties
	public bool isHiden { /* [XID] */ /* 0x0000000189BBB7B0-0x0000000189BBB7D0 */ get => default; /* [XID] */ /* 0x0000000189BC35F0-0x0000000189BC3610 */ protected set {} } // 0x0000000184514CA0-0x0000000184514D40 0x00000001845176C0-0x0000000184517770
	public uint infoBirthMonth { /* [XID] */ /* 0x0000000189BCAE10-0x0000000189BCAE30 */ get => default; /* [XID] */ /* 0x0000000189BD2460-0x0000000189BD2480 */ protected set {} } // 0x0000000184518CF0-0x0000000184518DC0 0x0000000184518FF0-0x00000001845190D0
	public uint infoBirthDay { /* [XID] */ /* 0x0000000189BD9A00-0x0000000189BD9A20 */ get => default; /* [XID] */ /* 0x00000001895E6490-0x00000001895E64B0 */ protected set {} } // 0x0000000184519690-0x0000000184519760 0x0000000184517460-0x0000000184517540
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint avatarNativeTextMapHash { /* [XID] */ /* 0x00000001895EDED0-0x00000001895EDEF0 */ get => default; /* [XID] */ /* 0x00000001895F56B0-0x00000001895F56D0 */ protected set {} } // 0x0000000184519540-0x00000001845195E0 0x0000000184517770-0x0000000184517820
	public string avatarNative { /* [XID] */ /* 0x00000001895FCC50-0x00000001895FCC70 */ get => default; } // 0x0000000184519320-0x00000001845194A0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint avatarVisionBeforTextMapHash { /* [XID] */ /* 0x0000000189604610-0x0000000189604630 */ get => default; /* [XID] */ /* 0x000000018960BF00-0x000000018960BF20 */ protected set {} } // 0x00000001845149B0-0x0000000184514A50 0x0000000184517950-0x0000000184517A00
	public string avatarVisionBefor { /* [XID] */ /* 0x00000001896134C0-0x00000001896134E0 */ get => default; } // 0x0000000184517230-0x00000001845173B0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint avatarConstellationBeforTextMapHash { /* [XID] */ /* 0x000000018961ACC0-0x000000018961ACE0 */ get => default; /* [XID] */ /* 0x00000001896222C0-0x00000001896222E0 */ protected set {} } // 0x0000000184516A50-0x0000000184516AF0 0x0000000184518B90-0x0000000184518C40
	public string avatarConstellationBefor { /* [XID] */ /* 0x0000000189629C10-0x0000000189629C30 */ get => default; } // 0x0000000184516DF0-0x0000000184516F70 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint avatarTitleTextMapHash { /* [XID] */ /* 0x0000000189631480-0x00000001896314A0 */ get => default; /* [XID] */ /* 0x0000000189638EB0-0x0000000189638ED0 */ protected set {} } // 0x0000000184519130-0x00000001845191D0 0x0000000184515010-0x00000001845150C0
	public string avatarTitle { /* [XID] */ /* 0x0000000189640290-0x00000001896402B0 */ get => default; } // 0x0000000184516AF0-0x0000000184516C70 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint avatarDetailTextMapHash { /* [XID] */ /* 0x0000000189647B30-0x0000000189647B50 */ get => default; /* [XID] */ /* 0x000000018964F1E0-0x000000018964F200 */ protected set {} } // 0x00000001845191D0-0x0000000184519270 0x00000001845195E0-0x0000000184519690
	public string avatarDetail { /* [XID] */ /* 0x0000000189656B70-0x0000000189656B90 */ get => default; } // 0x0000000184514DE0-0x0000000184514F60 
	public AssocType avatarAssocType { /* [XID] */ /* 0x000000018965E270-0x000000018965E290 */ get => default; /* [XID] */ /* 0x00000001896659B0-0x00000001896659D0 */ protected set {} } // 0x00000001845178B0-0x0000000184517950 0x0000000184519760-0x0000000184519810
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint cvChineseTextMapHash { /* [XID] */ /* 0x000000018966D0A0-0x000000018966D0C0 */ get => default; /* [XID] */ /* 0x0000000189674FD0-0x0000000189674FF0 */ protected set {} } // 0x0000000184517190-0x0000000184517230 0x0000000184518C40-0x0000000184518CF0
	public string cvChinese { /* [XID] */ /* 0x000000018967C7C0-0x000000018967C7E0 */ get => default; } // 0x0000000184516C70-0x0000000184516DF0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint cvJapaneseTextMapHash { /* [XID] */ /* 0x0000000189683E30-0x0000000189683E50 */ get => default; /* [XID] */ /* 0x000000018968BA30-0x000000018968BA50 */ protected set {} } // 0x0000000184519810-0x00000001845198B0 0x0000000184519270-0x0000000184519320
	public string cvJapanese { /* [XID] */ /* 0x0000000189693660-0x0000000189693680 */ get => default; } // 0x0000000184518A10-0x0000000184518B90 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint cvEnglishTextMapHash { /* [XID] */ /* 0x000000018969A910-0x000000018969A930 */ get => default; /* [XID] */ /* 0x00000001896A22E0-0x00000001896A2300 */ protected set {} } // 0x00000001845194A0-0x0000000184519540 0x00000001845173B0-0x0000000184517460
	public string cvEnglish { /* [XID] */ /* 0x00000001896A95A0-0x00000001896A95C0 */ get => default; } // 0x0000000184517540-0x00000001845176C0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint cvKoreanTextMapHash { /* [XID] */ /* 0x00000001896B06D0-0x00000001896B06F0 */ get => default; /* [XID] */ /* 0x00000001896B80F0-0x00000001896B8110 */ protected set {} } // 0x0000000184514D40-0x0000000184514DE0 0x0000000184517A00-0x0000000184517AB0
	public string cvKorean { /* [XID] */ /* 0x00000001896BF1D0-0x00000001896BF1F0 */ get => default; } // 0x0000000184518DC0-0x0000000184518F40 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint avatarVisionAfterTextMapHash { /* [XID] */ /* 0x00000001896C6A30-0x00000001896C6A50 */ get => default; /* [XID] */ /* 0x00000001896CE170-0x00000001896CE190 */ protected set {} } // 0x0000000184517AB0-0x0000000184517B50 0x0000000184518F40-0x0000000184518FF0
	public string avatarVisionAfter { /* [XID] */ /* 0x00000001896D56C0-0x00000001896D56E0 */ get => default; } // 0x0000000184517010-0x0000000184517190 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint avatarConstellationAfterTextMapHash { /* [XID] */ /* 0x00000001896DCB40-0x00000001896DCB60 */ get => default; /* [XID] */ /* 0x00000001896E44B0-0x00000001896E44D0 */ protected set {} } // 0x0000000184516F70-0x0000000184517010 0x0000000184514F60-0x0000000184515010
	public string avatarConstellationAfter { /* [XID] */ /* 0x00000001896EB8E0-0x00000001896EB900 */ get => default; } // 0x0000000184514830-0x00000001845149B0 

	// Constructors
	public FetterInfoExcelConfig() {} // 0x0000000184519950-0x00000001845199B0

	// Methods
	// [IDTag] // 0x00000001896F2D90-0x00000001896F2DD0
	// [XID] // 0x00000001896F2D90-0x00000001896F2DD0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184515D20-0x0000000184516A50
	// [IDTag] // 0x00000001896FD7B0-0x00000001896FD7F0
	// [XID] // 0x00000001896FD7B0-0x00000001896FD7F0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184515120-0x0000000184515D20
	// [XID] // 0x0000000189707BD0-0x0000000189707BF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2097 */, bool useObjectPool = false /* Metadata: 0x00AF209B */) => default; // 0x0000000184517BB0-0x0000000184518A10
	[BlackList] // 0x000000018970F740-0x000000018970F780
	// [XID] // 0x000000018970F740-0x000000018970F780
	public override void AutoAllocTypeFields() {} // 0x0000000184514A50-0x0000000184514AF0
	[BlackList] // 0x0000000189719DF0-0x0000000189719E30
	// [XID] // 0x0000000189719DF0-0x0000000189719E30
	public override void AutoRecycleTypeFields() {} // 0x0000000184514AF0-0x0000000184514C00
	[BlackList] // 0x0000000189724010-0x0000000189724050
	// [XID] // 0x0000000189724010-0x0000000189724050
	public override void ReturnToObjectPool() {} // 0x00000001845198B0-0x0000000184519950
}

