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
public class ProudSkillExcelConfig : BaseTalentConfig, IAutoAllocRecycle // TypeDefIndex: 14846
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 proudSkillIdRawNum; // 0x28
	protected SimpleSafeUInt32 proudSkillGroupIdRawNum; // 0x2C
	protected SimpleSafeUInt32 levelRawNum; // 0x30
	protected SimpleSafeUInt32 proudSkillTypeRawNum; // 0x34
	protected uint _nameTextMapHash; // 0x38
	protected uint _descTextMapHash; // 0x3C
	protected uint _unlockDescTextMapHash; // 0x40
	protected string _icon; // 0x48
	protected SimpleSafeUInt32 coinCostRawNum; // 0x50
	protected IdCountConfig[] _costItems; // 0x58
	protected TalentFilterCond[] _filterConds; // 0x60
	protected SimpleSafeUInt32 breakLevelRawNum; // 0x68
	protected uint[] _paramDescList; // 0x70
	protected ProudLifeEffectType _lifeEffectType; // 0x78
	protected string[] _lifeEffectParams; // 0x80
	protected SimpleSafeUInt8 effectiveForTeamRawNum; // 0x88

	// Properties
	public override uint talentSkillID { /* [XID] */ /* 0x00000001896048D0-0x00000001896048F0 */ get => default; } // 0x0000000182A4A2D0-0x0000000182A4A380 
	public uint proudSkillId { /* [XID] */ /* 0x000000018960C0A0-0x000000018960C0C0 */ get => default; /* [XID] */ /* 0x0000000189613660-0x0000000189613680 */ protected set {} } // 0x0000000182A4BA90-0x0000000182A4BB60 0x0000000182A4BEA0-0x0000000182A4BF80
	public uint proudSkillGroupId { /* [XID] */ /* 0x000000018961AEC0-0x000000018961AEE0 */ get => default; /* [XID] */ /* 0x0000000189622400-0x0000000189622420 */ protected set {} } // 0x0000000182A4A6F0-0x0000000182A4A7C0 0x0000000182A472D0-0x0000000182A473B0
	public uint level { /* [XID] */ /* 0x0000000189629DF0-0x0000000189629E10 */ get => default; /* [XID] */ /* 0x0000000189631580-0x00000001896315A0 */ protected set {} } // 0x0000000182A4B790-0x0000000182A4B860 0x0000000182A4B6B0-0x0000000182A4B790
	public uint proudSkillType { /* [XID] */ /* 0x0000000189639010-0x0000000189639030 */ get => default; /* [XID] */ /* 0x00000001896403D0-0x00000001896403F0 */ protected set {} } // 0x0000000182A4A200-0x0000000182A4A2D0 0x0000000182A4A120-0x0000000182A4A200
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189647C30-0x0000000189647C50 */ get => default; /* [XID] */ /* 0x000000018964F380-0x000000018964F3A0 */ protected set {} } // 0x0000000182A47A90-0x0000000182A47B30 0x0000000182A4B9E0-0x0000000182A4BA90
	public string name { /* [XID] */ /* 0x0000000189656D70-0x0000000189656D90 */ get => default; } // 0x0000000182A4C240-0x0000000182A4C3C0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018965E490-0x000000018965E4B0 */ get => default; /* [XID] */ /* 0x0000000189665B50-0x0000000189665B70 */ protected set {} } // 0x0000000182A4B940-0x0000000182A4B9E0 0x0000000182A47C00-0x0000000182A47CB0
	public string desc { /* [XID] */ /* 0x000000018966D200-0x000000018966D220 */ get => default; } // 0x0000000182A4A430-0x0000000182A4A5B0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unlockDescTextMapHash { /* [XID] */ /* 0x0000000189675210-0x0000000189675230 */ get => default; /* [XID] */ /* 0x000000018967C8E0-0x000000018967C900 */ protected set {} } // 0x0000000182A49FD0-0x0000000182A4A070 0x0000000182A4A380-0x0000000182A4A430
	public string unlockDesc { /* [XID] */ /* 0x0000000189683F70-0x0000000189683F90 */ get => default; } // 0x0000000182A49E50-0x0000000182A49FD0 
	public string icon { /* [XID] */ /* 0x000000018968BB50-0x000000018968BB70 */ get => default; /* [XID] */ /* 0x0000000189693760-0x0000000189693780 */ protected set {} } // 0x0000000182A47230-0x0000000182A472D0 0x0000000182A4BBC0-0x0000000182A4BC70
	public uint coinCost { /* [XID] */ /* 0x000000018969AAF0-0x000000018969AB10 */ get => default; /* [XID] */ /* 0x00000001896A2540-0x00000001896A2560 */ protected set {} } // 0x0000000182A46FD0-0x0000000182A470A0 0x0000000182A4B860-0x0000000182A4B940
	public IdCountConfig[] costItems { /* [XID] */ /* 0x00000001896A9720-0x00000001896A9740 */ get => default; /* [XID] */ /* 0x00000001896B0830-0x00000001896B0850 */ protected set {} } // 0x0000000182A4C050-0x0000000182A4C0F0 0x0000000182A4A070-0x0000000182A4A120
	public TalentFilterCond[] filterConds { /* [XID] */ /* 0x00000001896B8210-0x00000001896B8230 */ get => default; /* [XID] */ /* 0x00000001896BF290-0x00000001896BF2B0 */ protected set {} } // 0x0000000182A4C1A0-0x0000000182A4C240 0x0000000182A4C0F0-0x0000000182A4C1A0
	public uint breakLevel { /* [XID] */ /* 0x00000001896C6BD0-0x00000001896C6BF0 */ get => default; /* [XID] */ /* 0x00000001896CE290-0x00000001896CE2B0 */ protected set {} } // 0x0000000182A4BF80-0x0000000182A4C050 0x0000000182A4BD20-0x0000000182A4BE00
	public uint[] paramDescList { /* [XID] */ /* 0x00000001896D5840-0x00000001896D5860 */ get => default; /* [XID] */ /* 0x00000001896DCCE0-0x00000001896DCD00 */ protected set {} } // 0x0000000182A479F0-0x0000000182A47A90 0x0000000182A470A0-0x0000000182A47150
	public string[] paramDescListLocalized { /* [XID] */ /* 0x00000001896E4670-0x00000001896E4690 */ get => default; } // 0x0000000182A473B0-0x0000000182A47710 
	public ProudLifeEffectType lifeEffectType { /* [XID] */ /* 0x00000001896EBAA0-0x00000001896EBAC0 */ get => default; /* [XID] */ /* 0x00000001896F30B0-0x00000001896F30D0 */ protected set {} } // 0x0000000182A4BE00-0x0000000182A4BEA0 0x0000000182A4A640-0x0000000182A4A6F0
	public string[] lifeEffectParams { /* [XID] */ /* 0x00000001896FA850-0x00000001896FA870 */ get => default; /* [XID] */ /* 0x0000000189701EE0-0x0000000189701F00 */ protected set {} } // 0x0000000182A49DA0-0x0000000182A49E50 0x0000000182A4BC70-0x0000000182A4BD20
	public byte effectiveForTeam { /* [XID] */ /* 0x0000000189709780-0x00000001897097A0 */ get => default; /* [XID] */ /* 0x0000000189711070-0x0000000189711090 */ protected set {} } // 0x0000000182A47B30-0x0000000182A47C00 0x0000000182A47150-0x0000000182A47230

	// Constructors
	public ProudSkillExcelConfig() {} // 0x0000000182A4C460-0x0000000182A4C4C0

	// Methods
	// [IDTag] // 0x0000000189718470-0x00000001897184B0
	// [XID] // 0x0000000189718470-0x00000001897184B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182A47D10-0x0000000182A48DD0
	// [IDTag] // 0x0000000189722A60-0x0000000189722AA0
	// [XID] // 0x0000000189722A60-0x0000000189722AA0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182A48DD0-0x0000000182A49D30
	// [XID] // 0x000000018972D140-0x000000018972D160
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7AC */, bool useObjectPool = false /* Metadata: 0x00AEF7B0 */) => default; // 0x0000000182A4A820-0x0000000182A4B6B0
	[BlackList] // 0x00000001897348F0-0x0000000189734930
	// [XID] // 0x00000001897348F0-0x0000000189734930
	public override void AutoAllocTypeFields() {} // 0x0000000182A47710-0x0000000182A477B0
	[BlackList] // 0x000000018973F720-0x000000018973F760
	// [XID] // 0x000000018973F720-0x000000018973F760
	public override void AutoRecycleTypeFields() {} // 0x0000000182A477B0-0x0000000182A47950
	[BlackList] // 0x0000000189749BC0-0x0000000189749C00
	// [XID] // 0x0000000189749BC0-0x0000000189749C00
	public override void ReturnToObjectPool() {} // 0x0000000182A4C3C0-0x0000000182A4C460
}

