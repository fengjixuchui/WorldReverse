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
public class MaterialExcelConfig : ItemConfig, IAutoAllocRecycle // TypeDefIndex: 14873
{
	// Fields
	protected uint _interactionTitleTextMapHash; // 0x48
	protected MaterialType _materialType; // 0x4C
	protected SimpleSafeUInt32 cdTimeRawNum; // 0x50
	protected SimpleSafeUInt32 cdGroupRawNum; // 0x54
	protected SimpleSafeUInt32 stackLimitRawNum; // 0x58
	protected SimpleSafeUInt32 maxUseCountRawNum; // 0x5C
	protected bool _useOnGain; // 0x60
	protected bool _noFirstGetHint; // 0x61
	protected bool _playGainEffect; // 0x62
	protected ItemUseTarget _useTarget; // 0x64
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected ItemUseConfig[] _itemUse; // 0x68
	protected SimpleSafeUInt32 rankLevelRawNum; // 0x70
	protected FoodQualityType _foodQuality; // 0x74
	protected uint _effectDescTextMapHash; // 0x78
	protected uint _specialDescTextMapHash; // 0x7C
	protected uint _typeDescTextMapHash; // 0x80
	protected string _effectIcon; // 0x88
	protected SimpleSafeUInt32 effectGadgetIDRawNum; // 0x90
	protected string _effectName; // 0x98
	protected string[] _picPath; // 0xA0
	protected bool _isSplitDrop; // 0xA8
	protected bool _closeBagAfterUsed; // 0xA9
	protected SimpleSafeUInt32[] _satiationParams; // 0xB0
	protected MaterialDestroyType _destroyRule; // 0xB8
	protected SimpleSafeUInt32[] _destroyReturnMaterial; // 0xC0
	protected SimpleSafeUInt32[] _destroyReturnMaterialCount; // 0xC8
	protected SimpleSafeUInt32 setIDRawNum; // 0xD0
	protected bool _isHidden; // 0xD4
	protected bool _isForceGetHint; // 0xD5

	// Properties
	public bool canReviveAvatar { /* [XID] */ /* 0x00000001897C9980-0x00000001897C99A0 */ get => default; } // 0x0000000182FD0400-0x0000000182FD0530 
	public uint getAvatarID { /* [XID] */ /* 0x00000001897D0FF0-0x00000001897D1010 */ get => default; } // 0x0000000182FD0670-0x0000000182FD07E0 
	public uint getUnlockCookRecipeID { /* [XID] */ /* 0x00000001897D8FD0-0x00000001897D8FF0 */ get => default; } // 0x0000000182FCFF60-0x0000000182FD00D0 
	public uint getChannellerSlabBuff { /* [XID] */ /* 0x00000001897E78D0-0x00000001897E78F0 */ get => default; } // 0x0000000182FCB050-0x0000000182FCB1F0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint interactionTitleTextMapHash { /* [XID] */ /* 0x00000001897EF4B0-0x00000001897EF4D0 */ get => default; /* [XID] */ /* 0x00000001897F6B20-0x00000001897F6B40 */ protected set {} } // 0x0000000182FCA9D0-0x0000000182FCAA70 0x0000000182FCABE0-0x0000000182FCAC90
	public string interactionTitle { /* [XID] */ /* 0x00000001897FE1E0-0x00000001897FE200 */ get => default; } // 0x0000000182FCB1F0-0x0000000182FCB370 
	public MaterialType materialType { /* [XID] */ /* 0x0000000189805910-0x0000000189805930 */ get => default; /* [XID] */ /* 0x000000018980D030-0x000000018980D050 */ protected set {} } // 0x0000000182FD05D0-0x0000000182FD0670 0x0000000182FD2F40-0x0000000182FD2FF0
	public uint cdTime { /* [XID] */ /* 0x00000001898147F0-0x0000000189814810 */ get => default; /* [XID] */ /* 0x000000018981C260-0x000000018981C280 */ protected set {} } // 0x0000000182FD0D60-0x0000000182FD0E30 0x0000000182FD3A80-0x0000000182FD3B60
	public uint cdGroup { /* [XID] */ /* 0x00000001898237D0-0x00000001898237F0 */ get => default; /* [XID] */ /* 0x000000018982B0F0-0x000000018982B110 */ protected set {} } // 0x0000000182FD00D0-0x0000000182FD01A0 0x0000000182FD3B60-0x0000000182FD3C40
	public uint stackLimit { /* [XID] */ /* 0x0000000189832630-0x0000000189832650 */ get => default; /* [XID] */ /* 0x0000000189839C80-0x0000000189839CA0 */ protected set {} } // 0x0000000182FCFB00-0x0000000182FCFBD0 0x0000000182FD0BE0-0x0000000182FD0CC0
	public uint maxUseCount { /* [XID] */ /* 0x0000000189841120-0x0000000189841140 */ get => default; /* [XID] */ /* 0x0000000189848600-0x0000000189848620 */ protected set {} } // 0x0000000182FCAB10-0x0000000182FCABE0 0x0000000182FD2E60-0x0000000182FD2F40
	public bool useOnGain { /* [XID] */ /* 0x000000018984FD60-0x000000018984FD80 */ get => default; /* [XID] */ /* 0x00000001898571E0-0x0000000189857200 */ protected set {} } // 0x0000000182FD31E0-0x0000000182FD3280 0x0000000182FD3870-0x0000000182FD3920
	public bool noFirstGetHint { /* [XID] */ /* 0x000000018985E2F0-0x000000018985E310 */ get => default; /* [XID] */ /* 0x0000000189865CB0-0x0000000189865CD0 */ protected set {} } // 0x0000000182FD3140-0x0000000182FD31E0 0x0000000182FD0350-0x0000000182FD0400
	public bool playGainEffect { /* [XID] */ /* 0x000000018986D230-0x000000018986D250 */ get => default; /* [XID] */ /* 0x00000001898746E0-0x0000000189874700 */ protected set {} } // 0x0000000182FCFDE0-0x0000000182FCFE80 0x0000000182FCB4C0-0x0000000182FCB570
	public ItemUseTarget useTarget { /* [XID] */ /* 0x000000018987C2A0-0x000000018987C2C0 */ get => default; /* [XID] */ /* 0x00000001898833B0-0x00000001898833D0 */ protected set {} } // 0x0000000182FCAA70-0x0000000182FCAB10 0x0000000182FCB750-0x0000000182FCB800
	public ItemUseConfig[] itemUse { /* [XID] */ /* 0x000000018988AB10-0x000000018988AB30 */ get => default; /* [XID] */ /* 0x0000000189891FA0-0x0000000189891FC0 */ protected set {} } // 0x0000000182FD0CC0-0x0000000182FD0D60 0x0000000182FCFA50-0x0000000182FCFB00
	public uint rankLevel { /* [XID] */ /* 0x0000000189899970-0x0000000189899990 */ get => default; /* [XID] */ /* 0x00000001898A0A70-0x00000001898A0A90 */ protected set {} } // 0x0000000182FD0280-0x0000000182FD0350 0x0000000182FD01A0-0x0000000182FD0280
	public FoodQualityType foodQuality { /* [XID] */ /* 0x00000001898A8170-0x00000001898A8190 */ get => default; /* [XID] */ /* 0x00000001898AFCB0-0x00000001898AFCD0 */ protected set {} } // 0x0000000182FD0530-0x0000000182FD05D0 0x0000000182FCB800-0x0000000182FCB8B0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint effectDescTextMapHash { /* [XID] */ /* 0x00000001898B71D0-0x00000001898B71F0 */ get => default; /* [XID] */ /* 0x00000001898BE960-0x00000001898BE980 */ protected set {} } // 0x0000000182FCB370-0x0000000182FCB410 0x0000000182FD0B30-0x0000000182FD0BE0
	public string effectDesc { /* [XID] */ /* 0x00000001898C6110-0x00000001898C6130 */ get => default; } // 0x0000000182FCB5D0-0x0000000182FCB750 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint specialDescTextMapHash { /* [XID] */ /* 0x00000001898CD8E0-0x00000001898CD900 */ get => default; /* [XID] */ /* 0x00000001898D53D0-0x00000001898D53F0 */ protected set {} } // 0x0000000182FD3400-0x0000000182FD34A0 0x0000000182FD3500-0x0000000182FD35B0
	public string specialDesc { /* [XID] */ /* 0x00000001898DCD10-0x00000001898DCD30 */ get => default; } // 0x0000000182FCF8D0-0x0000000182FCFA50 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint typeDescTextMapHash { /* [XID] */ /* 0x00000001898E4740-0x00000001898E4760 */ get => default; /* [XID] */ /* 0x00000001898EC110-0x00000001898EC130 */ protected set {} } // 0x0000000182FD0A30-0x0000000182FD0AD0 0x0000000182FD3350-0x0000000182FD3400
	public string typeDesc { /* [XID] */ /* 0x00000001898F3960-0x00000001898F3980 */ get => default; } // 0x0000000182FD2C30-0x0000000182FD2DB0 
	public string effectIcon { /* [XID] */ /* 0x00000001898FB060-0x00000001898FB080 */ get => default; /* [XID] */ /* 0x0000000189902B60-0x0000000189902B80 */ protected set {} } // 0x0000000182FCB960-0x0000000182FCBA10 0x0000000182FCF820-0x0000000182FCF8D0
	public uint effectGadgetID { /* [XID] */ /* 0x000000018990A1C0-0x000000018990A1E0 */ get => default; /* [XID] */ /* 0x0000000189911BA0-0x0000000189911BC0 */ protected set {} } // 0x0000000182FD3280-0x0000000182FD3350 0x0000000182FCFE80-0x0000000182FCFF60
	public string effectName { /* [XID] */ /* 0x0000000189919680-0x00000001899196A0 */ get => default; /* [XID] */ /* 0x0000000189920B50-0x0000000189920B70 */ protected set {} } // 0x0000000182FD3920-0x0000000182FD39D0 0x0000000182FCA920-0x0000000182FCA9D0
	public string[] picPath { /* [XID] */ /* 0x00000001899285F0-0x0000000189928610 */ get => default; /* [XID] */ /* 0x000000018992FA60-0x000000018992FA80 */ protected set {} } // 0x0000000182FD39D0-0x0000000182FD3A80 0x0000000182FD2B80-0x0000000182FD2C30
	public bool isSplitDrop { /* [XID] */ /* 0x0000000189936F90-0x0000000189936FB0 */ get => default; /* [XID] */ /* 0x000000018993EB70-0x000000018993EB90 */ protected set {} } // 0x0000000182FD0980-0x0000000182FD0A30 0x0000000182FD37C0-0x0000000182FD3870
	public bool closeBagAfterUsed { /* [XID] */ /* 0x0000000189946200-0x0000000189946220 */ get => default; /* [XID] */ /* 0x000000018994D790-0x000000018994D7B0 */ protected set {} } // 0x0000000182FD35B0-0x0000000182FD3660 0x0000000182FCFD30-0x0000000182FCFDE0
	public SimpleSafeUInt32[] satiationParams { /* [XID] */ /* 0x0000000189954DA0-0x0000000189954DC0 */ get => default; /* [XID] */ /* 0x000000018995C640-0x000000018995C660 */ protected set {} } // 0x0000000182FD3660-0x0000000182FD3710 0x0000000182FCB410-0x0000000182FCB4C0
	public MaterialDestroyType destroyRule { /* [XID] */ /* 0x0000000189963F80-0x0000000189963FA0 */ get => default; /* [XID] */ /* 0x000000018996B4B0-0x000000018996B4D0 */ protected set {} } // 0x0000000182FD30A0-0x0000000182FD3140 0x0000000182FCFBD0-0x0000000182FCFC80
	public SimpleSafeUInt32[] destroyReturnMaterial { /* [XID] */ /* 0x0000000189973010-0x0000000189973030 */ get => default; /* [XID] */ /* 0x000000018997A930-0x000000018997A950 */ protected set {} } // 0x0000000182FCAFA0-0x0000000182FCB050 0x0000000182FCB8B0-0x0000000182FCB960
	public SimpleSafeUInt32[] destroyReturnMaterialCount { /* [XID] */ /* 0x00000001899822C0-0x00000001899822E0 */ get => default; /* [XID] */ /* 0x0000000189989AC0-0x0000000189989AE0 */ protected set {} } // 0x0000000182FCBAE0-0x0000000182FCBB90 0x0000000182FD2FF0-0x0000000182FD30A0
	public uint setID { /* [XID] */ /* 0x0000000189991310-0x0000000189991330 */ get => default; /* [XID] */ /* 0x0000000189998E50-0x0000000189998E70 */ protected set {} } // 0x0000000182FCBA10-0x0000000182FCBAE0 0x0000000182FD0E30-0x0000000182FD0F10
	public bool isHidden { /* [XID] */ /* 0x00000001899A0650-0x00000001899A0670 */ get => default; /* [XID] */ /* 0x00000001899A81E0-0x00000001899A8200 */ protected set {} } // 0x0000000182FD3710-0x0000000182FD37C0 0x0000000182FCFC80-0x0000000182FCFD30
	public bool isForceGetHint { /* [XID] */ /* 0x00000001899AF950-0x00000001899AF970 */ get => default; /* [XID] */ /* 0x00000001899B6DF0-0x00000001899B6E10 */ protected set {} } // 0x0000000182FCF770-0x0000000182FCF820 0x0000000182FD2DB0-0x0000000182FD2E60

	// Constructors
	public MaterialExcelConfig() {} // 0x0000000182FD3CE0-0x0000000182FD3D40

	// Methods
	// [XID] // 0x00000001897E0210-0x00000001897E0230
	public string GetNameCardPicPath(int index = 0 /* Metadata: 0x00AEF8A0 */) => default; // 0x0000000182FD0870-0x0000000182FD0980
	// [IDTag] // 0x00000001899BE8B0-0x00000001899BE8F0
	// [XID] // 0x00000001899BE8B0-0x00000001899BE8F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182FCBB90-0x0000000182FCDA70
	// [IDTag] // 0x00000001899C8DC0-0x00000001899C8E00
	// [XID] // 0x00000001899C8DC0-0x00000001899C8E00
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182FCDA70-0x0000000182FCF770
	// [XID] // 0x00000001899D36B0-0x00000001899D36D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8A4 */, bool useObjectPool = false /* Metadata: 0x00AEF8A8 */) => default; // 0x0000000182FD0F10-0x0000000182FD2B80
	[BlackList] // 0x00000001899DAC40-0x00000001899DAC80
	// [XID] // 0x00000001899DAC40-0x00000001899DAC80
	public override void AutoAllocTypeFields() {} // 0x0000000182FCAC90-0x0000000182FCAD30
	[BlackList] // 0x00000001899E5820-0x00000001899E5860
	// [XID] // 0x00000001899E5820-0x00000001899E5860
	public override void AutoRecycleTypeFields() {} // 0x0000000182FCAD30-0x0000000182FCAF00
	[BlackList] // 0x00000001899EFD30-0x00000001899EFD70
	// [XID] // 0x00000001899EFD30-0x00000001899EFD70
	public override void ReturnToObjectPool() {} // 0x0000000182FD3C40-0x0000000182FD3CE0
}

