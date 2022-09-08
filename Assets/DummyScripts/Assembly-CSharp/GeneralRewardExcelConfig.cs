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
public class GeneralRewardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16070
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected bool _useCondenseResin; // 0x14
	protected RewardSourceSystemType _rewardSourceSystem; // 0x18
	protected SimpleSafeUInt32 rewardSourceSystemParaRawNum; // 0x1C
	protected uint _titleTextMapHash; // 0x20
	protected uint _staminaEnoughTextMapHash; // 0x24
	protected uint _staminaLessTextMapHash; // 0x28
	protected uint _condenseResinStaminaEnoughTextMapHash; // 0x2C
	protected uint _condenseResinStaminaLessTextMapHash; // 0x30
	protected uint _usingActivityCoinTextMapHash; // 0x34
	protected uint _usingActivityCoinButtonTextMapHash; // 0x38
	protected uint _confirmTextMapHash; // 0x3C
	protected uint _resinMonthlyTextMapHash; // 0x40
	protected uint _insufficientTextMapHash; // 0x44
	protected uint _insufficientUseitemTextMapHash; // 0x48
	protected uint _condenseResinTextMapHash; // 0x4C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A83660-0x0000000189A83680 */ get => default; /* [XID] */ /* 0x0000000189A8AF20-0x0000000189A8AF40 */ protected set {} } // 0x0000000182CB27D0-0x0000000182CB28A0 0x0000000182CB0BC0-0x0000000182CB0CA0
	public bool useCondenseResin { /* [XID] */ /* 0x0000000189A92690-0x0000000189A926B0 */ get => default; /* [XID] */ /* 0x0000000189A9A160-0x0000000189A9A180 */ protected set {} } // 0x0000000182CB07A0-0x0000000182CB0840 0x0000000182CAEBF0-0x0000000182CAECA0
	public RewardSourceSystemType rewardSourceSystem { /* [XID] */ /* 0x0000000189AA1100-0x0000000189AA1120 */ get => default; /* [XID] */ /* 0x0000000189AA8880-0x0000000189AA88A0 */ protected set {} } // 0x0000000182CAE090-0x0000000182CAE130 0x0000000182CB0B10-0x0000000182CB0BC0
	public uint rewardSourceSystemPara { /* [XID] */ /* 0x0000000189AB0440-0x0000000189AB0460 */ get => default; /* [XID] */ /* 0x0000000189AB7AE0-0x0000000189AB7B00 */ protected set {} } // 0x0000000182CB0620-0x0000000182CB06F0 0x0000000182CB0990-0x0000000182CB0A70
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189ABF590-0x0000000189ABF5B0 */ get => default; /* [XID] */ /* 0x0000000189AC6FA0-0x0000000189AC6FC0 */ protected set {} } // 0x0000000182CAEA10-0x0000000182CAEAB0 0x0000000182CAECA0-0x0000000182CAED50
	public string title { /* [XID] */ /* 0x0000000189ACE750-0x0000000189ACE770 */ get => default; } // 0x0000000182CB1C90-0x0000000182CB1E10 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint staminaEnoughTextMapHash { /* [XID] */ /* 0x0000000189AD65C0-0x0000000189AD65E0 */ get => default; /* [XID] */ /* 0x0000000189ADDE00-0x0000000189ADDE20 */ protected set {} } // 0x0000000182CB2320-0x0000000182CB23C0 0x0000000182CB23C0-0x0000000182CB2470
	public string staminaEnough { /* [XID] */ /* 0x0000000189AE58A0-0x0000000189AE58C0 */ get => default; } // 0x0000000182CB1E10-0x0000000182CB1F90 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint staminaLessTextMapHash { /* [XID] */ /* 0x0000000189AECD00-0x0000000189AECD20 */ get => default; /* [XID] */ /* 0x0000000189AF46D0-0x0000000189AF46F0 */ protected set {} } // 0x0000000182CB0A70-0x0000000182CB0B10 0x0000000182CAEE00-0x0000000182CAEEB0
	public string staminaLess { /* [XID] */ /* 0x0000000189AFBC80-0x0000000189AFBCA0 */ get => default; } // 0x0000000182CAE890-0x0000000182CAEA10 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint condenseResinStaminaEnoughTextMapHash { /* [XID] */ /* 0x0000000189B034B0-0x0000000189B034D0 */ get => default; /* [XID] */ /* 0x0000000189B0ACE0-0x0000000189B0AD00 */ protected set {} } // 0x0000000182CB0840-0x0000000182CB08E0 0x0000000182CB1F90-0x0000000182CB2040
	public string condenseResinStaminaEnough { /* [XID] */ /* 0x0000000189B12500-0x0000000189B12520 */ get => default; } // 0x0000000182CB0CA0-0x0000000182CB0E20 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint condenseResinStaminaLessTextMapHash { /* [XID] */ /* 0x0000000189B197D0-0x0000000189B197F0 */ get => default; /* [XID] */ /* 0x0000000189B20E90-0x0000000189B20EB0 */ protected set {} } // 0x0000000182CAEAB0-0x0000000182CAEB50 0x0000000182CB0200-0x0000000182CB02B0
	public string condenseResinStaminaLess { /* [XID] */ /* 0x0000000189B285D0-0x0000000189B285F0 */ get => default; } // 0x0000000182CAE590-0x0000000182CAE710 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint usingActivityCoinTextMapHash { /* [XID] */ /* 0x0000000189B2F910-0x0000000189B2F930 */ get => default; /* [XID] */ /* 0x0000000189B372B0-0x0000000189B372D0 */ protected set {} } // 0x0000000182CAE130-0x0000000182CAE1D0 0x0000000182CAED50-0x0000000182CAEE00
	public string usingActivityCoin { /* [XID] */ /* 0x0000000189B3EB20-0x0000000189B3EB40 */ get => default; } // 0x0000000182CAE710-0x0000000182CAE890 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint usingActivityCoinButtonTextMapHash { /* [XID] */ /* 0x0000000189B46560-0x0000000189B46580 */ get => default; /* [XID] */ /* 0x0000000189B4DB00-0x0000000189B4DB20 */ protected set {} } // 0x0000000182CAE1D0-0x0000000182CAE270 0x0000000182CB08E0-0x0000000182CB0990
	public string usingActivityCoinButton { /* [XID] */ /* 0x0000000189B553D0-0x0000000189B553F0 */ get => default; } // 0x0000000182CB1B10-0x0000000182CB1C90 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint confirmTextMapHash { /* [XID] */ /* 0x0000000189B5CD50-0x0000000189B5CD70 */ get => default; /* [XID] */ /* 0x0000000189B64450-0x0000000189B64470 */ protected set {} } // 0x0000000182CB25F0-0x0000000182CB2690 0x0000000182CB2270-0x0000000182CB2320
	public string confirm { /* [XID] */ /* 0x0000000189B6B990-0x0000000189B6B9B0 */ get => default; } // 0x0000000182CB0080-0x0000000182CB0200 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint resinMonthlyTextMapHash { /* [XID] */ /* 0x0000000189B73170-0x0000000189B73190 */ get => default; /* [XID] */ /* 0x0000000189B7A6F0-0x0000000189B7A710 */ protected set {} } // 0x0000000182CAEB50-0x0000000182CAEBF0 0x0000000182CB0350-0x0000000182CB0400
	public string resinMonthly { /* [XID] */ /* 0x0000000189B81F50-0x0000000189B81F70 */ get => default; } // 0x0000000182CB0400-0x0000000182CB0580 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint insufficientTextMapHash { /* [XID] */ /* 0x0000000189B89670-0x0000000189B89690 */ get => default; /* [XID] */ /* 0x0000000189B90C90-0x0000000189B90CB0 */ protected set {} } // 0x0000000182CB0580-0x0000000182CB0620 0x0000000182CB06F0-0x0000000182CB07A0
	public string insufficient { /* [XID] */ /* 0x0000000189B97F80-0x0000000189B97FA0 */ get => default; } // 0x0000000182CB2470-0x0000000182CB25F0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint insufficientUseitemTextMapHash { /* [XID] */ /* 0x0000000189B9F3F0-0x0000000189B9F410 */ get => default; /* [XID] */ /* 0x0000000189BA6C40-0x0000000189BA6C60 */ protected set {} } // 0x0000000182CB02B0-0x0000000182CB0350 0x0000000182CB2040-0x0000000182CB20F0
	public string insufficientUseitem { /* [XID] */ /* 0x0000000189BADDE0-0x0000000189BADE00 */ get => default; } // 0x0000000182CAE410-0x0000000182CAE590 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint condenseResinTextMapHash { /* [XID] */ /* 0x0000000189BB55B0-0x0000000189BB55D0 */ get => default; /* [XID] */ /* 0x0000000189BBCD00-0x0000000189BBCD20 */ protected set {} } // 0x0000000182CB1A70-0x0000000182CB1B10 0x0000000182CB28A0-0x0000000182CB2950
	public string condenseResin { /* [XID] */ /* 0x0000000189BC4940-0x0000000189BC4960 */ get => default; } // 0x0000000182CB20F0-0x0000000182CB2270 

	// Constructors
	public GeneralRewardExcelConfig() {} // 0x0000000182CB29F0-0x0000000182CB2A50

	// Methods
	// [IDTag] // 0x0000000189BCC360-0x0000000189BCC3A0
	// [XID] // 0x0000000189BCC360-0x0000000189BCC3A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182CAF7B0-0x0000000182CB0080
	// [IDTag] // 0x0000000189BD66E0-0x0000000189BD6720
	// [XID] // 0x0000000189BD66E0-0x0000000189BD6720
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182CAEEB0-0x0000000182CAF7B0
	// [XID] // 0x00000001895E6350-0x00000001895E6370
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F78 */, bool useObjectPool = false /* Metadata: 0x00AF2F7C */) => default; // 0x0000000182CB0E20-0x0000000182CB1A70
	[BlackList] // 0x00000001895EDD50-0x00000001895EDD90
	// [XID] // 0x00000001895EDD50-0x00000001895EDD90
	public virtual void AutoAllocTypeFields() {} // 0x0000000182CAE270-0x0000000182CAE310
	[BlackList] // 0x00000001895F86D0-0x00000001895F8710
	// [XID] // 0x00000001895F86D0-0x00000001895F8710
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182CAE310-0x0000000182CAE410
	[BlackList] // 0x0000000189602CF0-0x0000000189602D30
	// [XID] // 0x0000000189602CF0-0x0000000189602D30
	public virtual void ReturnToObjectPool() {} // 0x0000000182CB2950-0x0000000182CB29F0
	[BlackList] // 0x000000018960D5A0-0x000000018960D5E0
	// [XID] // 0x000000018960D5A0-0x000000018960D5E0
	public virtual void OnPoolAllocated() {} // 0x0000000182CB2730-0x0000000182CB27D0
	[BlackList] // 0x0000000189617930-0x0000000189617970
	// [XID] // 0x0000000189617930-0x0000000189617970
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182CB2690-0x0000000182CB2730
}

