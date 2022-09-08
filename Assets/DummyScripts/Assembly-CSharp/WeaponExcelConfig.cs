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
public class WeaponExcelConfig : ItemConfig, IAutoAllocRecycle // TypeDefIndex: 16271
{
	// Fields
	protected WeaponType _weaponType; // 0x48
	protected SimpleSafeUInt32 rankLevelRawNum; // 0x4C
	protected WeaponMaterialType _materialType; // 0x50
	protected ElementType _elemType; // 0x54
	protected bool _isGold; // 0x58
	protected SimpleSafeUInt32 weaponBaseExpRawNum; // 0x5C
	protected SimpleSafeUInt32[] _skillAffix; // 0x60
	protected SimpleSafeUInt32 awakenMaterialRawNum; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected WeaponProperty[] _weaponProp; // 0x70
	protected string _awakenTexture; // 0x78
	protected string _awakenLightMapTexture; // 0x80
	protected string _awakenIcon; // 0x88
	protected bool _unRotate; // 0x90
	protected SimpleSafeUInt32 weaponPromoteIdRawNum; // 0x94
	protected SimpleSafeUInt32 storyIdRawNum; // 0x98
	protected SimpleSafeUInt32[] _awakenCosts; // 0xA0
	protected byte _gachaCardNameHashPre; // 0xA8
	protected uint _gachaCardNameHashSuffix; // 0xAC
	protected SimpleSafeUInt32 enhanceRuleRawNum; // 0xB0
	protected MaterialDestroyType _destroyRule; // 0xB4
	protected SimpleSafeUInt32[] _destroyReturnMaterial; // 0xB8
	protected SimpleSafeUInt32[] _destroyReturnMaterialCount; // 0xC0
	protected SimpleSafeUInt32 initialLockStateRawNum; // 0xC8

	// Properties
	public WeaponType weaponType { /* [XID] */ /* 0x00000001896706B0-0x00000001896706D0 */ get => default; /* [XID] */ /* 0x0000000189677EB0-0x0000000189677ED0 */ protected set {} } // 0x00000001828E1E80-0x00000001828E1F20 0x00000001828E1B40-0x00000001828E1BF0
	public uint rankLevel { /* [XID] */ /* 0x000000018967F480-0x000000018967F4A0 */ get => default; /* [XID] */ /* 0x0000000189686CB0-0x0000000189686CD0 */ protected set {} } // 0x00000001828E1A70-0x00000001828E1B40 0x00000001828E1990-0x00000001828E1A70
	public WeaponMaterialType materialType { /* [XID] */ /* 0x000000018968EBD0-0x000000018968EBF0 */ get => default; /* [XID] */ /* 0x00000001896965D0-0x00000001896965F0 */ protected set {} } // 0x00000001828E1CA0-0x00000001828E1D40 0x00000001828E3AB0-0x00000001828E3B60
	public ElementType elemType { /* [XID] */ /* 0x000000018969DB70-0x000000018969DB90 */ get => default; /* [XID] */ /* 0x00000001896A4BA0-0x00000001896A4BC0 */ protected set {} } // 0x00000001828E4200-0x00000001828E42A0 0x00000001828E1720-0x00000001828E17D0
	public bool isGold { /* [XID] */ /* 0x00000001896AC3D0-0x00000001896AC3F0 */ get => default; /* [XID] */ /* 0x00000001896B36B0-0x00000001896B36D0 */ protected set {} } // 0x00000001828E1490-0x00000001828E1530 0x00000001828E1BF0-0x00000001828E1CA0
	public uint weaponBaseExp { /* [XID] */ /* 0x00000001896BAE30-0x00000001896BAE50 */ get => default; /* [XID] */ /* 0x00000001896C1F60-0x00000001896C1F80 */ protected set {} } // 0x00000001828E42A0-0x00000001828E4370 0x00000001828DD960-0x00000001828DDA40
	public SimpleSafeUInt32[] skillAffix { /* [XID] */ /* 0x00000001896C9550-0x00000001896C9570 */ get => default; /* [XID] */ /* 0x00000001896D0D20-0x00000001896D0D40 */ protected set {} } // 0x00000001828E1530-0x00000001828E15D0 0x00000001828E4000-0x00000001828E40B0
	public uint awakenMaterial { /* [XID] */ /* 0x00000001896D8350-0x00000001896D8370 */ get => default; /* [XID] */ /* 0x00000001896DFCA0-0x00000001896DFCC0 */ protected set {} } // 0x00000001828DD270-0x00000001828DD340 0x00000001828E3D60-0x00000001828E3E40
	public WeaponProperty[] weaponProp { /* [XID] */ /* 0x00000001896E7080-0x00000001896E70A0 */ get => default; /* [XID] */ /* 0x00000001896EE5F0-0x00000001896EE610 */ protected set {} } // 0x00000001828E4160-0x00000001828E4200 0x00000001828E11D0-0x00000001828E1280
	public string awakenTexture { /* [XID] */ /* 0x0000000189B70930-0x0000000189B70950 */ get => default; /* [XID] */ /* 0x00000001896FD6D0-0x00000001896FD6F0 */ protected set {} } // 0x00000001828E2050-0x00000001828E20F0 0x00000001828DD8B0-0x00000001828DD960
	public string awakenLightMapTexture { /* [XID] */ /* 0x0000000189704B70-0x0000000189704B90 */ get => default; /* [XID] */ /* 0x000000018970C370-0x000000018970C390 */ protected set {} } // 0x00000001828E15D0-0x00000001828E1680 0x00000001828E1D40-0x00000001828E1DF0
	public string awakenIcon { /* [XID] */ /* 0x0000000189713D00-0x0000000189713D20 */ get => default; /* [XID] */ /* 0x000000018971B4E0-0x000000018971B500 */ protected set {} } // 0x00000001828E40B0-0x00000001828E4160 0x00000001828E3F50-0x00000001828E4000
	public bool unRotate { /* [XID] */ /* 0x0000000189722740-0x0000000189722760 */ get => default; /* [XID] */ /* 0x0000000189729E80-0x0000000189729EA0 */ protected set {} } // 0x00000001828E1330-0x00000001828E13E0 0x00000001828E3CB0-0x00000001828E3D60
	public uint weaponPromoteId { /* [XID] */ /* 0x0000000189731580-0x00000001897315A0 */ get => default; /* [XID] */ /* 0x0000000189738E10-0x0000000189738E30 */ protected set {} } // 0x00000001828DDAF0-0x00000001828DDBC0 0x00000001828E1020-0x00000001828E1100
	public uint storyId { /* [XID] */ /* 0x0000000189740C20-0x0000000189740C40 */ get => default; /* [XID] */ /* 0x0000000189748120-0x0000000189748140 */ protected set {} } // 0x00000001828E1F20-0x00000001828E1FF0 0x00000001828E17D0-0x00000001828E18B0
	public SimpleSafeUInt32[] awakenCosts { /* [XID] */ /* 0x000000018974F8D0-0x000000018974F8F0 */ get => default; /* [XID] */ /* 0x0000000189756EE0-0x0000000189756F00 */ protected set {} } // 0x00000001828DD6F0-0x00000001828DD7A0 0x00000001828E3920-0x00000001828E39D0
	public byte gachaCardNameHashPre { /* [XID] */ /* 0x000000018975E410-0x000000018975E430 */ get => default; /* [XID] */ /* 0x0000000189765AB0-0x0000000189765AD0 */ protected set {} } // 0x00000001828DD800-0x00000001828DD8B0 0x00000001828E3EA0-0x00000001828E3F50
	public uint gachaCardNameHashSuffix { /* [XID] */ /* 0x000000018976D260-0x000000018976D280 */ get => default; /* [XID] */ /* 0x00000001897746B0-0x00000001897746D0 */ protected set {} } // 0x00000001828E1680-0x00000001828E1720 0x00000001828E13E0-0x00000001828E1490
	public ulong gachaCardNameHash { /* [XID] */ /* 0x000000018977C100-0x000000018977C120 */ get => default; } // 0x00000001828DD1A0-0x00000001828DD270 
	public uint enhanceRule { /* [XID] */ /* 0x0000000189783A90-0x0000000189783AB0 */ get => default; /* [XID] */ /* 0x000000018978B2A0-0x000000018978B2C0 */ protected set {} } // 0x00000001828DDBC0-0x00000001828DDC90 0x00000001828E39D0-0x00000001828E3AB0
	public MaterialDestroyType destroyRule { /* [XID] */ /* 0x00000001897927A0-0x00000001897927C0 */ get => default; /* [XID] */ /* 0x0000000189799CF0-0x0000000189799D10 */ protected set {} } // 0x00000001828E3C10-0x00000001828E3CB0 0x00000001828E1280-0x00000001828E1330
	public SimpleSafeUInt32[] destroyReturnMaterial { /* [XID] */ /* 0x00000001897A1B80-0x00000001897A1BA0 */ get => default; /* [XID] */ /* 0x00000001897A9420-0x00000001897A9440 */ protected set {} } // 0x00000001828DD640-0x00000001828DD6F0 0x00000001828DDA40-0x00000001828DDAF0
	public SimpleSafeUInt32[] destroyReturnMaterialCount { /* [XID] */ /* 0x00000001897B0B60-0x00000001897B0B80 */ get => default; /* [XID] */ /* 0x00000001897B88E0-0x00000001897B8900 */ protected set {} } // 0x00000001828DDC90-0x00000001828DDD40 0x00000001828E3B60-0x00000001828E3C10
	public uint initialLockState { /* [XID] */ /* 0x00000001897C0920-0x00000001897C0940 */ get => default; /* [XID] */ /* 0x00000001897C82D0-0x00000001897C82F0 */ protected set {} } // 0x00000001828E1100-0x00000001828E11D0 0x00000001828E18B0-0x00000001828E1990

	// Constructors
	public WeaponExcelConfig() {} // 0x00000001828E4410-0x00000001828E4470

	// Methods
	// [IDTag] // 0x00000001897CF6B0-0x00000001897CF6F0
	// [XID] // 0x00000001897CF6B0-0x00000001897CF6F0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001828DDD40-0x00000001828DF790
	// [IDTag] // 0x00000001897DA350-0x00000001897DA390
	// [XID] // 0x00000001897DA350-0x00000001897DA390
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001828DF790-0x00000001828E1020
	// [XID] // 0x00000001897E46B0-0x00000001897E46D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF360D */, bool useObjectPool = false /* Metadata: 0x00AF3611 */) => default; // 0x00000001828E20F0-0x00000001828E3920
	[BlackList] // 0x00000001897EC220-0x00000001897EC260
	// [XID] // 0x00000001897EC220-0x00000001897EC260
	public override void AutoAllocTypeFields() {} // 0x00000001828DD340-0x00000001828DD3E0
	[BlackList] // 0x00000001897F6800-0x00000001897F6840
	// [XID] // 0x00000001897F6800-0x00000001897F6840
	public override void AutoRecycleTypeFields() {} // 0x00000001828DD3E0-0x00000001828DD5A0
	[BlackList] // 0x0000000189801220-0x0000000189801260
	// [XID] // 0x0000000189801220-0x0000000189801260
	public override void ReturnToObjectPool() {} // 0x00000001828E4370-0x00000001828E4410
}

