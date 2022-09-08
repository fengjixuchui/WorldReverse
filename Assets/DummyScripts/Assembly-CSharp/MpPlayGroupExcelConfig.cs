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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class MpPlayGroupExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15865
{
	// Fields
	protected SimpleSafeUInt32 EntryIdRawNum; // 0x10
	protected SimpleSafeUInt32 playIdRawNum; // 0x14
	protected SimpleSafeUInt32[] _serverLuaCallGroupList; // 0x18
	protected SimpleSafeUInt32 resinCostRawNum; // 0x20
	protected SimpleSafeUInt32 materialCostIdRawNum; // 0x24
	protected SimpleSafeUInt32 materialCostNumRawNum; // 0x28
	protected SimpleSafeUInt32[] _upAvatarList; // 0x30
	protected MpPlayShowType _clientShowType; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected MpCrucibleRewardConfig[] _rewardVec; // 0x40
	protected SimpleSafeUInt32[] _activateGroupList; // 0x48
	protected SimpleSafeUInt32[] _groupList; // 0x50
	protected SimpleSafeUInt32 bornGroupIdRawNum; // 0x58
	protected SimpleSafeUInt32 bornConfigIdRawNum; // 0x5C
	protected SimpleSafeUInt32 safeGroupIdRawNum; // 0x60
	protected SimpleSafeUInt32 safeConfigIdRawNum; // 0x64
	protected SimpleSafeUInt32 rebornGroupIdRawNum; // 0x68
	protected SimpleSafeUInt32 rebornConfigIdRawNum; // 0x6C
	protected SimpleSafeUInt32 rewardGroupIdRawNum; // 0x70
	protected SimpleSafeUInt32 rewardConfigIdRawNum; // 0x74
	protected SimpleSafeUInt32 generalRewardConfigIdRawNum; // 0x78
	protected SimpleSafeUInt32 prepareTimeRawNum; // 0x7C
	protected SimpleSafeFloat[] _centerPosList; // 0x80
	protected SimpleSafeUInt32 centerRadiusRawNum; // 0x88
	protected SimpleSafeFloat[] _targetPosList; // 0x90
	protected SimpleSafeUInt32 reviseIdRawNum; // 0x98
	protected SimpleSafeUInt32[] _rateList; // 0xA0
	protected string _limitRegion; // 0xA8
	protected SimpleSafeUInt32[] _abilityGroupList; // 0xB0

	// Properties
	public uint EntryId { /* [XID] */ /* 0x0000000189620BC0-0x0000000189620BE0 */ get => default; /* [XID] */ /* 0x0000000189628230-0x0000000189628250 */ protected set {} } // 0x0000000184B93790-0x0000000184B93860 0x0000000184B90A70-0x0000000184B90B50
	public uint playId { /* [XID] */ /* 0x000000018962FA80-0x000000018962FAA0 */ get => default; /* [XID] */ /* 0x0000000189637660-0x0000000189637680 */ protected set {} } // 0x0000000184B8C3E0-0x0000000184B8C4B0 0x0000000184B931A0-0x0000000184B93280
	public SimpleSafeUInt32[] serverLuaCallGroupList { /* [XID] */ /* 0x000000018963EBA0-0x000000018963EBC0 */ get => default; /* [XID] */ /* 0x0000000189646320-0x0000000189646340 */ protected set {} } // 0x0000000184B93CE0-0x0000000184B93D80 0x0000000184B93400-0x0000000184B934B0
	public uint resinCost { /* [XID] */ /* 0x000000018964DB20-0x000000018964DB40 */ get => default; /* [XID] */ /* 0x0000000189655380-0x00000001896553A0 */ protected set {} } // 0x0000000184B90D00-0x0000000184B90DD0 0x0000000184B91500-0x0000000184B915E0
	public uint materialCostId { /* [XID] */ /* 0x000000018965CBA0-0x000000018965CBC0 */ get => default; /* [XID] */ /* 0x00000001896640C0-0x00000001896640E0 */ protected set {} } // 0x0000000184B915E0-0x0000000184B916B0 0x0000000184B8CA70-0x0000000184B8CB50
	public uint materialCostNum { /* [XID] */ /* 0x000000018966B6E0-0x000000018966B700 */ get => default; /* [XID] */ /* 0x00000001896734E0-0x0000000189673500 */ protected set {} } // 0x0000000184B93280-0x0000000184B93350 0x0000000184B93C00-0x0000000184B93CE0
	public SimpleSafeUInt32[] upAvatarList { /* [XID] */ /* 0x000000018967ACE0-0x000000018967AD00 */ get => default; /* [XID] */ /* 0x00000001896825F0-0x0000000189682610 */ protected set {} } // 0x0000000184B93B60-0x0000000184B93C00 0x0000000184B93560-0x0000000184B93610
	public MpPlayShowType clientShowType { /* [XID] */ /* 0x0000000189689FF0-0x000000018968A010 */ get => default; /* [XID] */ /* 0x0000000189691DD0-0x0000000189691DF0 */ protected set {} } // 0x0000000184B8C820-0x0000000184B8C8C0 0x0000000184B93AB0-0x0000000184B93B60
	public MpCrucibleRewardConfig[] rewardVec { /* [XID] */ /* 0x0000000189699380-0x00000001896993A0 */ get => default; /* [XID] */ /* 0x00000001896A07F0-0x00000001896A0810 */ protected set {} } // 0x0000000184B8CB50-0x0000000184B8CBF0 0x0000000184B93860-0x0000000184B93910
	public SimpleSafeUInt32[] activateGroupList { /* [XID] */ /* 0x00000001896A7D40-0x00000001896A7D60 */ get => default; /* [XID] */ /* 0x00000001896AF190-0x00000001896AF1B0 */ protected set {} } // 0x0000000184B8C780-0x0000000184B8C820 0x0000000184B91030-0x0000000184B910E0
	public SimpleSafeUInt32[] groupList { /* [XID] */ /* 0x00000001896B6720-0x00000001896B6740 */ get => default; /* [XID] */ /* 0x00000001896BDA00-0x00000001896BDA20 */ protected set {} } // 0x0000000184B8C560-0x0000000184B8C600 0x0000000184B93EC0-0x0000000184B93F70
	public uint bornGroupId { /* [XID] */ /* 0x00000001896C51B0-0x00000001896C51D0 */ get => default; /* [XID] */ /* 0x00000001896CC770-0x00000001896CC790 */ protected set {} } // 0x0000000184B916B0-0x0000000184B91780 0x0000000184B91190-0x0000000184B91270
	public uint bornConfigId { /* [XID] */ /* 0x00000001896D3A60-0x00000001896D3A80 */ get => default; /* [XID] */ /* 0x00000001896DB4A0-0x00000001896DB4C0 */ protected set {} } // 0x0000000184B8CBF0-0x0000000184B8CCC0 0x0000000184B91830-0x0000000184B91910
	public uint safeGroupId { /* [XID] */ /* 0x00000001896E2C40-0x00000001896E2C60 */ get => default; /* [XID] */ /* 0x00000001896EA280-0x00000001896EA2A0 */ protected set {} } // 0x0000000184B8C600-0x0000000184B8C6D0 0x0000000184B91350-0x0000000184B91430
	public uint safeConfigId { /* [XID] */ /* 0x00000001896F1240-0x00000001896F1260 */ get => default; /* [XID] */ /* 0x00000001896F8BC0-0x00000001896F8BE0 */ protected set {} } // 0x0000000184B90E80-0x0000000184B90F50 0x0000000184B91910-0x0000000184B919F0
	public uint rebornGroupId { /* [XID] */ /* 0x00000001897003A0-0x00000001897003C0 */ get => default; /* [XID] */ /* 0x0000000189707B70-0x0000000189707B90 */ protected set {} } // 0x0000000184B91BA0-0x0000000184B91C70 0x0000000184B8BF60-0x0000000184B8C040
	public uint rebornConfigId { /* [XID] */ /* 0x000000018970F660-0x000000018970F680 */ get => default; /* [XID] */ /* 0x0000000189716980-0x00000001897169A0 */ protected set {} } // 0x0000000184B90B50-0x0000000184B90C20 0x0000000184B90C20-0x0000000184B90D00
	public uint rewardGroupId { /* [XID] */ /* 0x000000018971E3C0-0x000000018971E3E0 */ get => default; /* [XID] */ /* 0x0000000189725960-0x0000000189725980 */ protected set {} } // 0x0000000184B919F0-0x0000000184B91AC0 0x0000000184B8C990-0x0000000184B8CA70
	public uint rewardConfigId { /* [XID] */ /* 0x000000018972CEA0-0x000000018972CEC0 */ get => default; /* [XID] */ /* 0x0000000189734650-0x0000000189734670 */ protected set {} } // 0x0000000184B8C8C0-0x0000000184B8C990 0x0000000184B8BE80-0x0000000184B8BF60
	public uint generalRewardConfigId { /* [XID] */ /* 0x000000018973C020-0x000000018973C040 */ get => default; /* [XID] */ /* 0x0000000189743810-0x0000000189743830 */ protected set {} } // 0x0000000184B93910-0x0000000184B939E0 0x0000000184B90F50-0x0000000184B91030
	public uint prepareTime { /* [XID] */ /* 0x000000018974B420-0x000000018974B440 */ get => default; /* [XID] */ /* 0x00000001897525D0-0x00000001897525F0 */ protected set {} } // 0x0000000184B939E0-0x0000000184B93AB0 0x0000000184B91AC0-0x0000000184B91BA0
	public SimpleSafeFloat[] centerPosList { /* [XID] */ /* 0x0000000189759B40-0x0000000189759B60 */ get => default; /* [XID] */ /* 0x00000001897617B0-0x00000001897617D0 */ protected set {} } // 0x0000000184B930F0-0x0000000184B931A0 0x0000000184B90DD0-0x0000000184B90E80
	public uint centerRadius { /* [XID] */ /* 0x0000000189768B80-0x0000000189768BA0 */ get => default; /* [XID] */ /* 0x0000000189770270-0x0000000189770290 */ protected set {} } // 0x0000000184B91430-0x0000000184B91500 0x0000000184B8BDA0-0x0000000184B8BE80
	public SimpleSafeFloat[] targetPosList { /* [XID] */ /* 0x0000000189777930-0x0000000189777950 */ get => default; /* [XID] */ /* 0x000000018977EFA0-0x000000018977EFC0 */ protected set {} } // 0x0000000184B8C040-0x0000000184B8C0F0 0x0000000184B8C6D0-0x0000000184B8C780
	public uint reviseId { /* [XID] */ /* 0x00000001897869A0-0x00000001897869C0 */ get => default; /* [XID] */ /* 0x000000018978E050-0x000000018978E070 */ protected set {} } // 0x0000000184B936C0-0x0000000184B93790 0x0000000184B91270-0x0000000184B91350
	public SimpleSafeUInt32[] rateList { /* [XID] */ /* 0x0000000189795740-0x0000000189795760 */ get => default; /* [XID] */ /* 0x000000018979DB90-0x000000018979DBB0 */ protected set {} } // 0x0000000184B93350-0x0000000184B93400 0x0000000184B8C4B0-0x0000000184B8C560
	public string limitRegion { /* [XID] */ /* 0x00000001897A4ED0-0x00000001897A4EF0 */ get => default; /* [XID] */ /* 0x00000001897AC4A0-0x00000001897AC4C0 */ protected set {} } // 0x0000000184B910E0-0x0000000184B91190 0x0000000184B91780-0x0000000184B91830
	public SimpleSafeUInt32[] abilityGroupList { /* [XID] */ /* 0x00000001897B43F0-0x00000001897B4410 */ get => default; /* [XID] */ /* 0x00000001897BC0D0-0x00000001897BC0F0 */ protected set {} } // 0x0000000184B934B0-0x0000000184B93560 0x0000000184B93610-0x0000000184B936C0

	// Constructors
	public MpPlayGroupExcelConfig() {} // 0x0000000184B94010-0x0000000184B94070

	// Methods
	// [IDTag] // 0x00000001897C3870-0x00000001897C38B0
	// [XID] // 0x00000001897C3870-0x00000001897C38B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184B8CCC0-0x0000000184B8EC30
	// [IDTag] // 0x00000001897CE120-0x00000001897CE160
	// [XID] // 0x00000001897CE120-0x00000001897CE160
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B8EC30-0x0000000184B90A70
	// [XID] // 0x00000001897D8DD0-0x00000001897D8DF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28CE */, bool useObjectPool = false /* Metadata: 0x00AF28D2 */) => default; // 0x0000000184B91C70-0x0000000184B930F0
	[BlackList] // 0x00000001897DFFF0-0x00000001897E0030
	// [XID] // 0x00000001897DFFF0-0x00000001897E0030
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B8C0F0-0x0000000184B8C190
	[BlackList] // 0x00000001897EA800-0x00000001897EA840
	// [XID] // 0x00000001897EA800-0x00000001897EA840
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B8C190-0x0000000184B8C3E0
	[BlackList] // 0x00000001897F5270-0x00000001897F52B0
	// [XID] // 0x00000001897F5270-0x00000001897F52B0
	public virtual void ReturnToObjectPool() {} // 0x0000000184B93F70-0x0000000184B94010
	[BlackList] // 0x00000001897FFBD0-0x00000001897FFC10
	// [XID] // 0x00000001897FFBD0-0x00000001897FFC10
	public virtual void OnPoolAllocated() {} // 0x0000000184B93E20-0x0000000184B93EC0
	[BlackList] // 0x000000018980A0D0-0x000000018980A110
	// [XID] // 0x000000018980A0D0-0x000000018980A110
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B93D80-0x0000000184B93E20
}

