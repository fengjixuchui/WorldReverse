/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigAudioUi : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17633
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioUiSupport _support; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioUiEquip _equip; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _openChestEvent; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _joinTeamEvent; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _elementStateKey; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _elementStateDefaultValue; // 0x38
	private Dictionary<string, string> _elementStateValueMap; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _characterAppearEvent; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _addMapPinEvent; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _removeMapPinEvent; // 0x58
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _enableElementViewEvent; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _disableElementViewEvent; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _dungeonVictoryEvent; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _dungeonDefeatEvent; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _changeWeaponEvent; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _wearRelicEvent; // 0x88
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _takeoffRelicEvent; // 0x90
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _selectAvatarRelicEvent; // 0x98
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _addEquipMaterialEvent; // 0xA0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _talentUnlockEvent; // 0xA8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _changeAvatarSuccessEvent; // 0xB0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _changeAvatarFailedEvent; // 0xB8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _selectMainQuestEvent; // 0xC0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _teamAvatarHoldUp; // 0xC8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _teamAvatarHoldDown; // 0xD0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _teamAvatarClick; // 0xD8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _bagDropItem; // 0xE0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _mailDeleteEvent; // 0xE8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _itemInCDEvent; // 0xF0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _pickUpEvent; // 0xF8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _playerLevelBtnEvent; // 0x100
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _chestPickupFailEvent; // 0x108
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _enterDungeonSuccessEvent; // 0x110
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _openPageDefaultEvent; // 0x118
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _closePageDefaultEvent; // 0x120
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigWwiseString> _openPageCustomEvents; // 0x128
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigWwiseString> _closePageCustomEvents; // 0x130
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _videoStartDefaultEvent; // 0x138
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _videoEndDefaultEvent; // 0x140
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigWwiseString> _videoStartCustomEvents; // 0x148
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigWwiseString> _videoEndCustomEvents; // 0x150
	private SimpleSafeInt32 defaultEnableDelayCountRawNum; // 0x158
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _characterSelectMusicEndEvent; // 0x160
	private EnumToHash _uiElementState; // 0x168

	// Properties
	public AudioUiSupport support { /* [XID] */ /* 0x0000000189996EC0-0x0000000189996EE0 */ get => default; /* [XID] */ /* 0x000000018999EA90-0x000000018999EAB0 */ private set {} } // 0x000000018588AF20-0x000000018588AFC0 0x0000000185894030-0x00000001858940E0
	public AudioUiEquip equip { /* [XID] */ /* 0x00000001899A6430-0x00000001899A6450 */ get => default; /* [XID] */ /* 0x00000001899ADB00-0x00000001899ADB20 */ private set {} } // 0x000000018588F860-0x000000018588F900 0x0000000185890930-0x00000001858909E0
	public ConfigWwiseString openChestEvent { /* [XID] */ /* 0x0000000189B28CA0-0x0000000189B28CC0 */ get => default; /* [XID] */ /* 0x00000001899BC9B0-0x00000001899BC9D0 */ private set {} } // 0x00000001858912B0-0x0000000185891350 0x000000018588AE70-0x000000018588AF20
	public AudioOneTimeEvent joinTeamEvent { /* [XID] */ /* 0x00000001899C4400-0x00000001899C4420 */ get => default; /* [XID] */ /* 0x00000001899CBC80-0x00000001899CBCA0 */ private set {} } // 0x000000018588DD40-0x000000018588DDE0 0x000000018588DDE0-0x000000018588DE90
	public ConfigWwiseString elementStateKey { /* [XID] */ /* 0x00000001899D3170-0x00000001899D3190 */ get => default; /* [XID] */ /* 0x00000001899DA760-0x00000001899DA780 */ private set {} } // 0x000000018588B570-0x000000018588B610 0x000000018588B3D0-0x000000018588B480
	public ConfigWwiseString elementStateDefaultValue { /* [XID] */ /* 0x00000001899E2160-0x00000001899E2180 */ get => default; /* [XID] */ /* 0x00000001899E9640-0x00000001899E9660 */ private set {} } // 0x000000018588FEC0-0x000000018588FF60 0x000000018588ECC0-0x000000018588ED70
	public Dictionary<string, string> elementStateValueMap { /* [XID] */ /* 0x00000001899F0CB0-0x00000001899F0CD0 */ get => default; /* [XID] */ /* 0x00000001899F8530-0x00000001899F8550 */ private set {} } // 0x0000000185890D00-0x0000000185890DA0 0x0000000185886C80-0x0000000185886D30
	public ConfigWwiseString characterAppearEvent { /* [XID] */ /* 0x0000000189B76820-0x0000000189B76840 */ get => default; /* [XID] */ /* 0x0000000189A07350-0x0000000189A07370 */ private set {} } // 0x0000000185886A40-0x0000000185886AE0 0x00000001858900C0-0x0000000185890170
	public ConfigWwiseString addMapPinEvent { /* [XID] */ /* 0x0000000189A0E8D0-0x0000000189A0E8F0 */ get => default; /* [XID] */ /* 0x0000000189A16000-0x0000000189A16020 */ private set {} } // 0x000000018588ED70-0x000000018588EE10 0x000000018588AFC0-0x000000018588B070
	public ConfigWwiseString removeMapPinEvent { /* [XID] */ /* 0x0000000189A1D520-0x0000000189A1D540 */ get => default; /* [XID] */ /* 0x0000000189A24A30-0x0000000189A24A50 */ private set {} } // 0x000000018588F010-0x000000018588F0B0 0x0000000185890220-0x00000001858902D0
	public ConfigWwiseString enableElementViewEvent { /* [XID] */ /* 0x0000000189A2C030-0x0000000189A2C050 */ get => default; /* [XID] */ /* 0x0000000189A33780-0x0000000189A337A0 */ private set {} } // 0x000000018588B120-0x000000018588B1C0 0x000000018588B320-0x000000018588B3D0
	public ConfigWwiseString disableElementViewEvent { /* [XID] */ /* 0x0000000189A3AEE0-0x0000000189A3AF00 */ get => default; /* [XID] */ /* 0x0000000189A42790-0x0000000189A427B0 */ private set {} } // 0x0000000185893490-0x0000000185893530 0x0000000185894190-0x0000000185894240
	public ConfigWwiseString dungeonVictoryEvent { /* [XID] */ /* 0x0000000189655C60-0x0000000189655C80 */ get => default; /* [XID] */ /* 0x0000000189A516F0-0x0000000189A51710 */ private set {} } // 0x000000018588EEC0-0x000000018588EF60 0x000000018588F9B0-0x000000018588FA60
	public ConfigWwiseString dungeonDefeatEvent { /* [XID] */ /* 0x0000000189A58DC0-0x0000000189A58DE0 */ get => default; /* [XID] */ /* 0x0000000189A60720-0x0000000189A60740 */ private set {} } // 0x0000000185893290-0x0000000185893330 0x000000018588EB60-0x000000018588EC10
	public ConfigWwiseString changeWeaponEvent { /* [XID] */ /* 0x00000001897723E0-0x0000000189772400 */ get => default; /* [XID] */ /* 0x0000000189A6F880-0x0000000189A6F8A0 */ private set {} } // 0x000000018588F2C0-0x000000018588F370 0x000000018588F0B0-0x000000018588F160
	public ConfigWwiseString wearRelicEvent { /* [XID] */ /* 0x0000000189A77070-0x0000000189A77090 */ get => default; /* [XID] */ /* 0x0000000189A7EA80-0x0000000189A7EAA0 */ private set {} } // 0x00000001858904E0-0x0000000185890590 0x000000018588EAB0-0x000000018588EB60
	public ConfigWwiseString takeoffRelicEvent { /* [XID] */ /* 0x0000000189781530-0x0000000189781550 */ get => default; /* [XID] */ /* 0x0000000189A8DCB0-0x0000000189A8DCD0 */ private set {} } // 0x0000000185890880-0x0000000185890930 0x000000018588F210-0x000000018588F2C0
	public ConfigWwiseString selectAvatarRelicEvent { /* [XID] */ /* 0x0000000189A95230-0x0000000189A95250 */ get => default; /* [XID] */ /* 0x0000000189A9CA70-0x0000000189A9CA90 */ private set {} } // 0x000000018588E5D0-0x000000018588E680 0x0000000185891150-0x0000000185891200
	public ConfigWwiseString addEquipMaterialEvent { /* [XID] */ /* 0x00000001897900B0-0x00000001897900D0 */ get => default; /* [XID] */ /* 0x0000000189AAB710-0x0000000189AAB730 */ private set {} } // 0x000000018588B610-0x000000018588B6C0 0x0000000185890010-0x00000001858900C0
	public ConfigWwiseString talentUnlockEvent { /* [XID] */ /* 0x00000001897CE800-0x00000001897CE820 */ get => default; /* [XID] */ /* 0x0000000189ABAD50-0x0000000189ABAD70 */ private set {} } // 0x00000001858909E0-0x0000000185890A90 0x000000018588F900-0x000000018588F9B0
	public ConfigWwiseString changeAvatarSuccessEvent { /* [XID] */ /* 0x00000001897D5F10-0x00000001897D5F30 */ get => default; /* [XID] */ /* 0x0000000189AC9CC0-0x0000000189AC9CE0 */ private set {} } // 0x0000000185890FF0-0x00000001858910A0 0x000000018588E150-0x000000018588E200
	public ConfigWwiseString changeAvatarFailedEvent { /* [XID] */ /* 0x0000000189AD1550-0x0000000189AD1570 */ get => default; /* [XID] */ /* 0x0000000189AD9250-0x0000000189AD9270 */ private set {} } // 0x0000000185891200-0x00000001858912B0 0x000000018588EE10-0x000000018588EEC0
	public ConfigWwiseString selectMainQuestEvent { /* [XID] */ /* 0x0000000189AE0D40-0x0000000189AE0D60 */ get => default; /* [XID] */ /* 0x0000000189AE81F0-0x0000000189AE8210 */ private set {} } // 0x000000018588DF40-0x000000018588DFF0 0x000000018588DE90-0x000000018588DF40
	public ConfigWwiseString teamAvatarHoldUp { /* [XID] */ /* 0x0000000189AF0070-0x0000000189AF0090 */ get => default; /* [XID] */ /* 0x0000000189AF7540-0x0000000189AF7560 */ private set {} } // 0x00000001858933E0-0x0000000185893490 0x000000018588B270-0x000000018588B320
	public ConfigWwiseString teamAvatarHoldDown { /* [XID] */ /* 0x00000001897FA5C0-0x00000001897FA5E0 */ get => default; /* [XID] */ /* 0x0000000189B06400-0x0000000189B06420 */ private set {} } // 0x0000000185893530-0x00000001858935E0 0x0000000185890BA0-0x0000000185890C50
	public ConfigWwiseString teamAvatarClick { /* [XID] */ /* 0x0000000189B0DAF0-0x0000000189B0DB10 */ get => default; /* [XID] */ /* 0x0000000189B14F70-0x0000000189B14F90 */ private set {} } // 0x000000018588FA60-0x000000018588FB10 0x000000018588EC10-0x000000018588ECC0
	public ConfigWwiseString bagDropItem { /* [XID] */ /* 0x0000000189801BA0-0x0000000189801BC0 */ get => default; /* [XID] */ /* 0x0000000189B23E80-0x0000000189B23EA0 */ private set {} } // 0x00000001858943A0-0x0000000185894450 0x000000018588E200-0x000000018588E2B0
	public ConfigWwiseString mailDeleteEvent { /* [XID] */ /* 0x0000000189809070-0x0000000189809090 */ get => default; /* [XID] */ /* 0x0000000189B327C0-0x0000000189B327E0 */ private set {} } // 0x0000000185890170-0x0000000185890220 0x00000001858910A0-0x0000000185891150
	public ConfigWwiseString itemInCDEvent { /* [XID] */ /* 0x0000000189B3A090-0x0000000189B3A0B0 */ get => default; /* [XID] */ /* 0x0000000189B41A10-0x0000000189B41A30 */ private set {} } // 0x000000018588E520-0x000000018588E5D0 0x000000018588B1C0-0x000000018588B270
	public ConfigWwiseString pickUpEvent { /* [XID] */ /* 0x0000000189818020-0x0000000189818040 */ get => default; /* [XID] */ /* 0x0000000189B50A20-0x0000000189B50A40 */ private set {} } // 0x000000018588F7B0-0x000000018588F860 0x000000018588E0A0-0x000000018588E150
	public ConfigWwiseString playerLevelBtnEvent { /* [XID] */ /* 0x0000000189B58300-0x0000000189B58320 */ get => default; /* [XID] */ /* 0x0000000189B5FC60-0x0000000189B5FC80 */ private set {} } // 0x0000000185886AE0-0x0000000185886B90 0x000000018588E680-0x000000018588E730
	public ConfigWwiseString chestPickupFailEvent { /* [XID] */ /* 0x0000000189B672A0-0x0000000189B672C0 */ get => default; /* [XID] */ /* 0x0000000189B6E540-0x0000000189B6E560 */ private set {} } // 0x0000000185893330-0x00000001858933E0 0x000000018588ADC0-0x000000018588AE70
	public ConfigWwiseString enterDungeonSuccessEvent { /* [XID] */ /* 0x0000000189B75D90-0x0000000189B75DB0 */ get => default; /* [XID] */ /* 0x0000000189B7D240-0x0000000189B7D260 */ private set {} } // 0x00000001858940E0-0x0000000185894190 0x0000000185893F80-0x0000000185894030
	public ConfigWwiseString openPageDefaultEvent { /* [XID] */ /* 0x00000001896F37C0-0x00000001896F37E0 */ get => default; /* [XID] */ /* 0x0000000189B8BE60-0x0000000189B8BE80 */ private set {} } // 0x000000018588DFF0-0x000000018588E0A0 0x0000000185890380-0x0000000185890430
	public ConfigWwiseString closePageDefaultEvent { /* [XID] */ /* 0x0000000189B93630-0x0000000189B93650 */ get => default; /* [XID] */ /* 0x0000000189B9ABA0-0x0000000189B9ABC0 */ private set {} } // 0x000000018588E3A0-0x000000018588E450 0x000000018588F160-0x000000018588F210
	public Dictionary<string, ConfigWwiseString> openPageCustomEvents { /* [XID] */ /* 0x00000001896E4A90-0x00000001896E4AB0 */ get => default; /* [XID] */ /* 0x0000000189BA98A0-0x0000000189BA98C0 */ private set {} } // 0x000000018588FE10-0x000000018588FEC0 0x000000018588EF60-0x000000018588F010
	public Dictionary<string, ConfigWwiseString> closePageCustomEvents { /* [XID] */ /* 0x0000000189736750-0x0000000189736770 */ get => default; /* [XID] */ /* 0x0000000189BB8200-0x0000000189BB8220 */ private set {} } // 0x0000000185890C50-0x0000000185890D00 0x0000000185890F40-0x0000000185890FF0
	public ConfigWwiseString videoStartDefaultEvent { /* [XID] */ /* 0x0000000189974C70-0x0000000189974C90 */ get => default; /* [XID] */ /* 0x0000000189BC7540-0x0000000189BC7560 */ private set {} } // 0x0000000185890430-0x00000001858904E0 0x000000018588B070-0x000000018588B120
	public ConfigWwiseString videoEndDefaultEvent { /* [XID] */ /* 0x0000000189BCF230-0x0000000189BCF250 */ get => default; /* [XID] */ /* 0x0000000189BD64E0-0x0000000189BD6500 */ private set {} } // 0x0000000185890590-0x0000000185890640 0x000000018588FF60-0x0000000185890010
	public Dictionary<string, ConfigWwiseString> videoStartCustomEvents { /* [XID] */ /* 0x0000000189BDE120-0x0000000189BDE140 */ get => default; /* [XID] */ /* 0x00000001895EAC30-0x00000001895EAC50 */ private set {} } // 0x0000000185894240-0x00000001858942F0 0x00000001858942F0-0x00000001858943A0
	public Dictionary<string, ConfigWwiseString> videoEndCustomEvents { /* [XID] */ /* 0x00000001895F2110-0x00000001895F2130 */ get => default; /* [XID] */ /* 0x00000001895F9A40-0x00000001895F9A60 */ private set {} } // 0x0000000185890DA0-0x0000000185890E50 0x00000001858931E0-0x0000000185893290
	public int defaultEnableDelayCount { /* [XID] */ /* 0x0000000189B37A80-0x0000000189B37AA0 */ get => default; /* [XID] */ /* 0x0000000189608BD0-0x0000000189608BF0 */ private set {} } // 0x000000018588E450-0x000000018588E520 0x000000018588ACE0-0x000000018588ADC0
	public ConfigWwiseString characterSelectMusicEndEvent { /* [XID] */ /* 0x00000001896103D0-0x00000001896103F0 */ get => default; /* [XID] */ /* 0x0000000189617690-0x00000001896176B0 */ private set {} } // 0x00000001858902D0-0x0000000185890380 0x000000018588DC90-0x000000018588DD40

	// Constructors
	public ConfigAudioUi() {} // 0x00000001858944F0-0x0000000185894550

	// Methods
	// [XID] // 0x000000018961F1E0-0x000000018961F200
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001858935E0-0x0000000185893E40
	// [XID] // 0x0000000189626620-0x0000000189626640
	public void InitEmpty() {} // 0x000000018588F370-0x000000018588F7B0
	[BlackList] // 0x000000018962DF10-0x000000018962DF50
	// [XID] // 0x000000018962DF10-0x000000018962DF50
	public bool FromJson(JSONNode node) => default; // 0x000000018588E730-0x000000018588EAB0
	// [XID] // 0x0000000189638B30-0x0000000189638B50
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185886D30-0x0000000185889700
	// [XID] // 0x000000018963FF70-0x000000018963FF90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7581 */, bool useObjectPool = false /* Metadata: 0x00AF7585 */) => default; // 0x000000018588FB10-0x000000018588FE10
	// [XID] // 0x0000000189647830-0x0000000189647850
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7586 */, bool useObjectPool = false /* Metadata: 0x00AF758A */) => default; // 0x000000018588B6C0-0x000000018588DC90
	[BlackList] // 0x000000018964EDE0-0x000000018964EE20
	// [XID] // 0x000000018964EDE0-0x000000018964EE20
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185889700-0x00000001858899D0
	// [XID] // 0x00000001896596B0-0x00000001896596D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185891350-0x00000001858931E0
	// [XID] // 0x0000000189660E10-0x0000000189660E30
	public void SetupUiElementState() {} // 0x0000000185890730-0x0000000185890880
	// [XID] // 0x0000000189668760-0x0000000189668780
	public uint GetUiElementState(ElementType element) => default; // 0x0000000185886B90-0x0000000185886C80
	// [XID] // 0x00000001896702F0-0x0000000189670310
	public ConfigWwiseString GetOpenPageEvent(string pageName) => default; // 0x000000018588E2B0-0x000000018588E3A0
	// [XID] // 0x000000018972EFB0-0x000000018972EFD0
	public ConfigWwiseString GetClosePageEvent(string pageName) => default; // 0x0000000185890E50-0x0000000185890F40
	// [XID] // 0x000000018967F160-0x000000018967F180
	public ConfigWwiseString GetVideoStartEvent(string videoName) => default; // 0x000000018588B480-0x000000018588B570
	// [XID] // 0x0000000189686A70-0x0000000189686A90
	public ConfigWwiseString GetVideoEndEvent(string videoName) => default; // 0x0000000185890640-0x0000000185890730
	// [XID] // 0x00000001897116D0-0x00000001897116F0
	private ConfigWwiseString GetCustomEvent(string key, Dictionary<string, ConfigWwiseString> customEvents, ConfigWwiseString defaultEvent) => default; // 0x0000000185890A90-0x0000000185890BA0
	[BlackList] // 0x0000000189696330-0x0000000189696370
	// [XID] // 0x0000000189696330-0x0000000189696370
	public virtual void AutoAllocTypeFields() {} // 0x00000001858899D0-0x0000000185889A70
	[BlackList] // 0x00000001896A0510-0x00000001896A0550
	// [XID] // 0x00000001896A0510-0x00000001896A0550
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185889A70-0x000000018588ACE0
	[BlackList] // 0x00000001896AA7F0-0x00000001896AA830
	// [XID] // 0x00000001896AA7F0-0x00000001896AA830
	public virtual void ReturnToObjectPool() {} // 0x0000000185894450-0x00000001858944F0
	[BlackList] // 0x00000001896B4CF0-0x00000001896B4D30
	// [XID] // 0x00000001896B4CF0-0x00000001896B4D30
	public virtual void OnPoolAllocated() {} // 0x0000000185893EE0-0x0000000185893F80
	[BlackList] // 0x00000001896BEC90-0x00000001896BECD0
	// [XID] // 0x00000001896BEC90-0x00000001896BECD0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185893E40-0x0000000185893EE0
}

