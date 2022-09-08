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
public class CoopChapterExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15460
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x14
	protected uint _chapterNameTextMapHash; // 0x18
	protected uint _coopPageTitleTextMapHash; // 0x1C
	protected SimpleSafeUInt32 chapterSortIdRawNum; // 0x20
	protected SimpleSafeUInt32 avatarSortIdRawNum; // 0x24
	protected string _chapterIcon; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected CoopCondConfig[] _unlockCond; // 0x30
	protected uint[] _unlockCondTips; // 0x38
	protected SimpleSafeUInt32 openMaterialIdRawNum; // 0x40
	protected SimpleSafeUInt32 openMaterialNumRawNum; // 0x44
	protected string _beginTimeStr; // 0x48
	protected SimpleSafeUInt32 confidenceValueRawNum; // 0x50
	protected string _pointGraphPath; // 0x58
	protected SimpleSafeFloat graphXRatioRawNum; // 0x60
	protected SimpleSafeFloat graphYRatioRawNum; // 0x64

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189783C70-0x0000000189783C90 */ get => default; /* [XID] */ /* 0x000000018978B460-0x000000018978B480 */ protected set {} } // 0x0000000181525D20-0x0000000181525DF0 0x0000000181523F40-0x0000000181524020
	public uint avatarId { /* [XID] */ /* 0x00000001897928C0-0x00000001897928E0 */ get => default; /* [XID] */ /* 0x0000000189799E50-0x0000000189799E70 */ protected set {} } // 0x00000001815238B0-0x0000000181523980 0x0000000181521A40-0x0000000181521B20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint chapterNameTextMapHash { /* [XID] */ /* 0x00000001897A1D80-0x00000001897A1DA0 */ get => default; /* [XID] */ /* 0x00000001897A95A0-0x00000001897A95C0 */ protected set {} } // 0x0000000181521EF0-0x0000000181521F90 0x0000000181522110-0x00000001815221C0
	public string chapterName { /* [XID] */ /* 0x00000001897B0D40-0x00000001897B0D60 */ get => default; } // 0x0000000181523B90-0x0000000181523D10 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint coopPageTitleTextMapHash { /* [XID] */ /* 0x00000001897B8A20-0x00000001897B8A40 */ get => default; /* [XID] */ /* 0x00000001897C0A60-0x00000001897C0A80 */ protected set {} } // 0x0000000181525DF0-0x0000000181525E90 0x00000001815221C0-0x0000000181522270
	public string coopPageTitle { /* [XID] */ /* 0x00000001897C83F0-0x00000001897C8410 */ get => default; } // 0x0000000181524F90-0x0000000181525110 
	public uint chapterSortId { /* [XID] */ /* 0x00000001897CF810-0x00000001897CF830 */ get => default; /* [XID] */ /* 0x00000001897D7140-0x00000001897D7160 */ protected set {} } // 0x0000000181524EC0-0x0000000181524F90 0x0000000181523E60-0x0000000181523F40
	public uint avatarSortId { /* [XID] */ /* 0x00000001897DE6B0-0x00000001897DE6D0 */ get => default; /* [XID] */ /* 0x00000001897E6210-0x00000001897E6230 */ protected set {} } // 0x0000000181521E20-0x0000000181521EF0 0x0000000181525420-0x0000000181525500
	public string chapterIcon { /* [XID] */ /* 0x00000001897EDC30-0x00000001897EDC50 */ get => default; /* [XID] */ /* 0x00000001897F5350-0x00000001897F5370 */ protected set {} } // 0x0000000181523D10-0x0000000181523DB0 0x0000000181524D40-0x0000000181524DF0
	public CoopCondConfig[] unlockCond { /* [XID] */ /* 0x00000001897FCD00-0x00000001897FCD20 */ get => default; /* [XID] */ /* 0x0000000189804390-0x00000001898043B0 */ protected set {} } // 0x0000000181524CA0-0x0000000181524D40 0x0000000181523DB0-0x0000000181523E60
	public uint[] unlockCondTips { /* [XID] */ /* 0x000000018980B7A0-0x000000018980B7C0 */ get => default; /* [XID] */ /* 0x0000000189812FE0-0x0000000189813000 */ protected set {} } // 0x0000000181523A50-0x0000000181523AF0 0x00000001815252C0-0x0000000181525370
	public string[] unlockCondTipsLocalized { /* [XID] */ /* 0x000000018981AA80-0x000000018981AAA0 */ get => default; } // 0x00000001815256C0-0x0000000181525A20 
	public uint openMaterialId { /* [XID] */ /* 0x0000000189822250-0x0000000189822270 */ get => default; /* [XID] */ /* 0x00000001898297D0-0x00000001898297F0 */ protected set {} } // 0x0000000181525110-0x00000001815251E0 0x0000000181525E90-0x0000000181525F70
	public uint openMaterialNum { /* [XID] */ /* 0x0000000189830D80-0x0000000189830DA0 */ get => default; /* [XID] */ /* 0x00000001898384C0-0x00000001898384E0 */ protected set {} } // 0x0000000181524DF0-0x0000000181524EC0 0x0000000181522030-0x0000000181522110
	public string beginTimeStr { /* [XID] */ /* 0x000000018983FAF0-0x000000018983FB10 */ get => default; /* [XID] */ /* 0x0000000189847130-0x0000000189847150 */ protected set {} } // 0x0000000181523AF0-0x0000000181523B90 0x0000000181525370-0x0000000181525420
	public uint confidenceValue { /* [XID] */ /* 0x000000018984E7C0-0x000000018984E7E0 */ get => default; /* [XID] */ /* 0x0000000189855810-0x0000000189855830 */ protected set {} } // 0x0000000181523980-0x0000000181523A50 0x00000001815251E0-0x00000001815252C0
	public string pointGraphPath { /* [XID] */ /* 0x000000018985CC70-0x000000018985CC90 */ get => default; /* [XID] */ /* 0x0000000189864670-0x0000000189864690 */ protected set {} } // 0x0000000181521F90-0x0000000181522030 0x0000000181521D70-0x0000000181521E20
	public float graphXRatio { /* [XID] */ /* 0x000000018986BC20-0x000000018986BC40 */ get => default; /* [XID] */ /* 0x0000000189872FB0-0x0000000189872FD0 */ protected set {} } // 0x0000000181525500-0x00000001815255E0 0x0000000181525A20-0x0000000181525B00
	public float graphYRatio { /* [XID] */ /* 0x000000018987ACD0-0x000000018987ACF0 */ get => default; /* [XID] */ /* 0x0000000189881C20-0x0000000189881C40 */ protected set {} } // 0x00000001815255E0-0x00000001815256C0 0x0000000181525B00-0x0000000181525BE0

	// Constructors
	public CoopChapterExcelConfig() {} // 0x0000000181526010-0x0000000181526070

	// Methods
	// [IDTag] // 0x0000000189889380-0x00000001898893C0
	// [XID] // 0x0000000189889380-0x00000001898893C0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181522270-0x0000000181522E20
	// [IDTag] // 0x0000000189893790-0x00000001898937D0
	// [XID] // 0x0000000189893790-0x00000001898937D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181522E20-0x00000001815238B0
	// [XID] // 0x000000018989DBA0-0x000000018989DBC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B22 */, bool useObjectPool = false /* Metadata: 0x00AF1B26 */) => default; // 0x0000000181524020-0x0000000181524CA0
	[BlackList] // 0x00000001898A54E0-0x00000001898A5520
	// [XID] // 0x00000001898A54E0-0x00000001898A5520
	public virtual void AutoAllocTypeFields() {} // 0x0000000181521B20-0x0000000181521BC0
	[BlackList] // 0x00000001898AFB10-0x00000001898AFB50
	// [XID] // 0x00000001898AFB10-0x00000001898AFB50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181521BC0-0x0000000181521D70
	[BlackList] // 0x00000001898BA5E0-0x00000001898BA620
	// [XID] // 0x00000001898BA5E0-0x00000001898BA620
	public virtual void ReturnToObjectPool() {} // 0x0000000181525F70-0x0000000181526010
	[BlackList] // 0x00000001898C4AE0-0x00000001898C4B20
	// [XID] // 0x00000001898C4AE0-0x00000001898C4B20
	public virtual void OnPoolAllocated() {} // 0x0000000181525C80-0x0000000181525D20
	[BlackList] // 0x00000001898CF210-0x00000001898CF250
	// [XID] // 0x00000001898CF210-0x00000001898CF250
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181525BE0-0x0000000181525C80
}

