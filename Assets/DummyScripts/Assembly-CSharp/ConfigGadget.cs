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
public class ConfigGadget : ConfigEntity, IAutoAllocRecycle // TypeDefIndex: 18010
{
	// Fields
	private bool _hasEquip; // 0x58
	private bool _hasAudio; // 0x59
	private bool _hasModel; // 0x5A
	private bool _hasAbility; // 0x5B
	private bool _hasFollowWindZoneRotation; // 0x5C
	private bool _forceDontUseUpdateRigidbody; // 0x5D
	private bool _hasConnectTrigger; // 0x5E
	private bool _canBeCreatedOnPlatform; // 0x5F
	private SimpleSafeUInt32 connectTriggerPriorityRawNum; // 0x60
	private bool _ignoreChildSceneProp; // 0x64
	private bool _moveRefreshGroundForceUp; // 0x65
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCombat _combat; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityAbilityEntry[] _abilities; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigTrigger _field; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigTimer _timer; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMove _move; // 0x88
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGadgetPattern _gadget; // 0x90
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEquipment _equipment; // 0x98
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigNavigation _navigation; // 0xA0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGadgetUI _uiInteract; // 0xA8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGadgetMisc _misc; // 0xB0
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigBaseStateLayer> _stateLayers; // 0xB8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGadgetAudio _audio; // 0xC0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBeta _aibeta; // 0xC8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWeather _weather; // 0xD0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWall _wall; // 0xD8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigFace _face; // 0xE0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPartController _partControl; // 0xE8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPaimon _paimon; // 0xF0
	private bool _radarHint; // 0xF8
	private bool _keepModifierOutSight; // 0xF9
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGadgetAction _gadgetAction; // 0x100
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBillboard _billboard; // 0x108
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigIntee _intee; // 0x110
	private string[] _bindEmotions; // 0x118
	private bool _projector; // 0x120
	private bool _lowPriorityIntee; // 0x121
	private bool _canRemoveByClient; // 0x122
	private string[] _tags; // 0x128
	private bool _canBeTriggeredByAvatarRay; // 0x130

	// Properties
	public bool hasEquip { /* [XID] */ /* 0x0000000189A426D0-0x0000000189A426F0 */ get => default; /* [XID] */ /* 0x0000000189A49C60-0x0000000189A49C80 */ private set {} } // 0x000000018314D1C0-0x000000018314D260 0x0000000183150CD0-0x0000000183150D80
	public bool hasAudio { /* [XID] */ /* 0x0000000189A51670-0x0000000189A51690 */ get => default; /* [XID] */ /* 0x0000000189A58D00-0x0000000189A58D20 */ private set {} } // 0x000000018314FB70-0x000000018314FC10 0x0000000183151640-0x00000001831516F0
	public bool hasModel { /* [XID] */ /* 0x0000000189BB5E50-0x0000000189BB5E70 */ get => default; /* [XID] */ /* 0x0000000189A683D0-0x0000000189A683F0 */ private set {} } // 0x0000000183150B80-0x0000000183150C20 0x000000018314C180-0x000000018314C230
	public bool hasAbility { /* [XID] */ /* 0x0000000189BBD490-0x0000000189BBD4B0 */ get => default; /* [XID] */ /* 0x0000000189A76EF0-0x0000000189A76F10 */ private set {} } // 0x0000000183150040-0x00000001831500E0 0x000000018314F8F0-0x000000018314F9A0
	public bool hasFollowWindZoneRotation { /* [XID] */ /* 0x0000000189A20F60-0x0000000189A20F80 */ get => default; /* [XID] */ /* 0x0000000189A86270-0x0000000189A86290 */ private set {} } // 0x0000000183150510-0x00000001831505B0 0x00000001831505B0-0x0000000183150660
	public bool forceDontUseUpdateRigidbody { /* [XID] */ /* 0x0000000189A8DB70-0x0000000189A8DB90 */ get => default; /* [XID] */ /* 0x0000000189A95130-0x0000000189A95150 */ private set {} } // 0x0000000183151240-0x00000001831512E0 0x0000000183149810-0x00000001831498C0
	public bool hasConnectTrigger { /* [XID] */ /* 0x0000000189A9C9D0-0x0000000189A9C9F0 */ get => default; /* [XID] */ /* 0x0000000189AA41A0-0x0000000189AA41C0 */ private set {} } // 0x000000018314F9A0-0x000000018314FA40 0x0000000183155430-0x00000001831554E0
	public bool canBeCreatedOnPlatform { /* [XID] */ /* 0x0000000189AAB630-0x0000000189AAB650 */ get => default; /* [XID] */ /* 0x0000000189AB3020-0x0000000189AB3040 */ private set {} } // 0x0000000183152B80-0x0000000183152C20 0x0000000183152460-0x0000000183152510
	public uint connectTriggerPriority { /* [XID] */ /* 0x0000000189AD6C90-0x0000000189AD6CB0 */ get => default; /* [XID] */ /* 0x0000000189AC2520-0x0000000189AC2540 */ private set {} } // 0x000000018314F7A0-0x000000018314F870 0x00000001831499F0-0x0000000183149AD0
	public bool ignoreChildSceneProp { /* [XID] */ /* 0x000000018966A970-0x000000018966A990 */ get => default; /* [XID] */ /* 0x0000000189AD1470-0x0000000189AD1490 */ private set {} } // 0x0000000183155230-0x00000001831552D0 0x000000018314C0D0-0x000000018314C180
	public bool moveRefreshGroundForceUp { /* [XID] */ /* 0x0000000189AD91F0-0x0000000189AD9210 */ get => default; /* [XID] */ /* 0x0000000189AE0C60-0x0000000189AE0C80 */ private set {} } // 0x0000000183152C20-0x0000000183152CC0 0x000000018314D260-0x000000018314D310
	public ConfigCombat combat { /* [XID] */ /* 0x0000000189AE8150-0x0000000189AE8170 */ get => default; /* [XID] */ /* 0x0000000189AEFFF0-0x0000000189AF0010 */ private set {} } // 0x0000000183150AE0-0x0000000183150B80 0x0000000183151D90-0x0000000183151E40
	public ConfigEntityAbilityEntry[] abilities { /* [XID] */ /* 0x0000000189AF7480-0x0000000189AF74A0 */ get => default; /* [XID] */ /* 0x0000000189AFEB30-0x0000000189AFEB50 */ private set {} } // 0x00000001831507C0-0x0000000183150860 0x0000000183154AE0-0x0000000183154B90
	public ConfigTrigger field { /* [XID] */ /* 0x0000000189B062C0-0x0000000189B062E0 */ get => default; /* [XID] */ /* 0x0000000189B0DA70-0x0000000189B0DA90 */ private set {} } // 0x000000018314D120-0x000000018314D1C0 0x000000018314D6E0-0x000000018314D790
	public ConfigTimer timer { /* [XID] */ /* 0x0000000189B14E90-0x0000000189B14EB0 */ get => default; /* [XID] */ /* 0x0000000189B1C830-0x0000000189B1C850 */ private set {} } // 0x000000018314D630-0x000000018314D6E0 0x000000018314CF10-0x000000018314CFC0
	public ConfigMove move { /* [XID] */ /* 0x0000000189B23E00-0x0000000189B23E20 */ get => default; /* [XID] */ /* 0x0000000189B2B0C0-0x0000000189B2B0E0 */ private set {} } // 0x0000000183152510-0x00000001831525C0 0x00000001831513F0-0x00000001831514A0
	public ConfigGadgetPattern gadget { /* [XID] */ /* 0x0000000189B32700-0x0000000189B32720 */ get => default; /* [XID] */ /* 0x0000000189B3A050-0x0000000189B3A070 */ private set {} } // 0x0000000183150A30-0x0000000183150AE0 0x000000018314F640-0x000000018314F6F0
	public ConfigEquipment equipment { /* [XID] */ /* 0x0000000189B419F0-0x0000000189B41A10 */ get => default; /* [XID] */ /* 0x0000000189B493C0-0x0000000189B493E0 */ private set {} } // 0x00000001831514A0-0x0000000183151550 0x0000000183150D80-0x0000000183150E30
	public ConfigNavigation navigation { /* [XID] */ /* 0x0000000189B50980-0x0000000189B509A0 */ get => default; /* [XID] */ /* 0x0000000189B582A0-0x0000000189B582C0 */ private set {} } // 0x0000000183155640-0x00000001831556F0 0x0000000183150C20-0x0000000183150CD0
	public ConfigGadgetUI uiInteract { /* [XID] */ /* 0x0000000189B5FB80-0x0000000189B5FBA0 */ get => default; /* [XID] */ /* 0x0000000189B67240-0x0000000189B67260 */ private set {} } // 0x00000001831525C0-0x0000000183152670 0x0000000183151F50-0x0000000183152000
	public ConfigGadgetMisc misc { /* [XID] */ /* 0x0000000189BAE5E0-0x0000000189BAE600 */ get => default; /* [XID] */ /* 0x0000000189B75CF0-0x0000000189B75D10 */ private set {} } // 0x00000001831552D0-0x0000000183155380 0x0000000183150460-0x0000000183150510
	public Dictionary<string, ConfigBaseStateLayer> stateLayers { /* [XID] */ /* 0x0000000189B7D140-0x0000000189B7D160 */ get => default; /* [XID] */ /* 0x0000000189B84F70-0x0000000189B84F90 */ private set {} } // 0x000000018314CFC0-0x000000018314D070 0x0000000183151EA0-0x0000000183151F50
	public ConfigGadgetAudio audio { /* [XID] */ /* 0x0000000189B8BDE0-0x0000000189B8BE00 */ get => default; /* [XID] */ /* 0x0000000189B935D0-0x0000000189B935F0 */ private set {} } // 0x00000001831516F0-0x00000001831517A0 0x00000001831503B0-0x0000000183150460
	public ConfigAIBeta aibeta { /* [XID] */ /* 0x0000000189B9AB40-0x0000000189B9AB60 */ get => default; /* [XID] */ /* 0x0000000189BA2330-0x0000000189BA2350 */ private set {} } // 0x0000000183152E20-0x0000000183152ED0 0x0000000183150980-0x0000000183150A30
	public ConfigWeather weather { /* [XID] */ /* 0x0000000189BA9780-0x0000000189BA97A0 */ get => default; /* [XID] */ /* 0x0000000189BB0F90-0x0000000189BB0FB0 */ private set {} } // 0x0000000183152000-0x00000001831520B0 0x0000000183150710-0x00000001831507C0
	public ConfigWall wall { /* [XID] */ /* 0x0000000189BA74F0-0x0000000189BA7510 */ get => default; /* [XID] */ /* 0x0000000189BBF870-0x0000000189BBF890 */ private set {} } // 0x000000018314F6F0-0x000000018314F7A0 0x00000001831512E0-0x0000000183151390
	public ConfigFace face { /* [XID] */ /* 0x0000000189BC74C0-0x0000000189BC74E0 */ get => default; /* [XID] */ /* 0x0000000189BCF1B0-0x0000000189BCF1D0 */ private set {} } // 0x0000000183150E30-0x0000000183150EE0 0x000000018314D470-0x000000018314D520
	public ConfigPartController partControl { /* [XID] */ /* 0x000000018960F450-0x000000018960F470 */ get => default; /* [XID] */ /* 0x0000000189BDE000-0x0000000189BDE020 */ private set {} } // 0x0000000183152A20-0x0000000183152AD0 0x0000000183154980-0x0000000183154A30
	public ConfigPaimon paimon { /* [XID] */ /* 0x00000001895EABD0-0x00000001895EABF0 */ get => default; /* [XID] */ /* 0x00000001895F20D0-0x00000001895F20F0 */ private set {} } // 0x0000000183150860-0x0000000183150910 0x000000018314D070-0x000000018314D120
	public bool radarHint { /* [XID] */ /* 0x00000001895F99A0-0x00000001895F99C0 */ get => default; /* [XID] */ /* 0x0000000189601120-0x0000000189601140 */ private set {} } // 0x0000000183152CC0-0x0000000183152D70 0x0000000183152AD0-0x0000000183152B80
	public bool keepModifierOutSight { /* [XID] */ /* 0x0000000189608AD0-0x0000000189608AF0 */ get => default; /* [XID] */ /* 0x00000001896102B0-0x00000001896102D0 */ private set {} } // 0x000000018314FF90-0x0000000183150040 0x0000000183151C30-0x0000000183151CE0
	public ConfigGadgetAction gadgetAction { /* [XID] */ /* 0x0000000189743DC0-0x0000000189743DE0 */ get => default; /* [XID] */ /* 0x000000018961F140-0x000000018961F160 */ private set {} } // 0x0000000183155380-0x0000000183155430 0x0000000183155590-0x0000000183155640
	public ConfigBillboard billboard { /* [XID] */ /* 0x0000000189626580-0x00000001896265A0 */ get => default; /* [XID] */ /* 0x000000018962DED0-0x000000018962DEF0 */ private set {} } // 0x000000018314D3C0-0x000000018314D470 0x000000018314FAC0-0x000000018314FB70
	public ConfigIntee intee { /* [XID] */ /* 0x0000000189AF0A40-0x0000000189AF0A60 */ get => default; /* [XID] */ /* 0x000000018963D210-0x000000018963D230 */ private set {} } // 0x00000001831554E0-0x0000000183155590 0x0000000183152D70-0x0000000183152E20
	public string[] bindEmotions { /* [XID] */ /* 0x0000000189644730-0x0000000189644750 */ get => default; /* [XID] */ /* 0x000000018964C050-0x000000018964C070 */ private set {} } // 0x0000000183150660-0x0000000183150710 0x000000018314D790-0x000000018314D840
	public bool projector { /* [XID] */ /* 0x0000000189653640-0x0000000189653660 */ get => default; /* [XID] */ /* 0x000000018965AF30-0x000000018965AF50 */ private set {} } // 0x0000000183152160-0x0000000183152210 0x0000000183149940-0x00000001831499F0
	public bool lowPriorityIntee { /* [XID] */ /* 0x0000000189B26070-0x0000000189B26090 */ get => default; /* [XID] */ /* 0x000000018966A020-0x000000018966A040 */ private set {} } // 0x00000001831520B0-0x0000000183152160 0x0000000183151CE0-0x0000000183151D90
	public bool canRemoveByClient { /* [XID] */ /* 0x0000000189671C60-0x0000000189671C80 */ get => default; /* [XID] */ /* 0x00000001896794D0-0x00000001896794F0 */ private set {} } // 0x0000000183154A30-0x0000000183154AE0 0x000000018314D580-0x000000018314D630
	public string[] tags { /* [XID] */ /* 0x0000000189680BC0-0x0000000189680BE0 */ get => default; /* [XID] */ /* 0x0000000189688640-0x0000000189688660 */ private set {} } // 0x0000000183150300-0x00000001831503B0 0x000000018314D310-0x000000018314D3C0
	public bool canBeTriggeredByAvatarRay { /* [XID] */ /* 0x000000018968FF40-0x000000018968FF60 */ get => default; /* [XID] */ /* 0x0000000189697880-0x00000001896978A0 */ private set {} } // 0x000000018314D8C0-0x000000018314D970 0x00000001831517A0-0x0000000183151850

	// Constructors
	public ConfigGadget() {} // 0x0000000183155790-0x0000000183155860

	// Methods
	// [XID] // 0x000000018969ED30-0x000000018969ED50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183154B90-0x0000000183155230
	// [XID] // 0x00000001896A6010-0x00000001896A6030
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001831526D0-0x0000000183152A20
	// [XID] // 0x00000001896AD4F0-0x00000001896AD510
	public override ConfigEntity Clone(bool useObjectPool = false /* Metadata: 0x00AF8673 */) => default; // 0x0000000183151B50-0x0000000183151C30
	// [XID] // 0x00000001896B4C10-0x00000001896B4C30
	public override int GetHashNum() => default; // 0x000000018314CE40-0x000000018314CF10
	// [XID] // 0x00000001896BBFC0-0x00000001896BBFE0
	public override void InitEmpty() {} // 0x0000000183150EE0-0x00000001831511C0
	[BlackList] // 0x00000001896C3440-0x00000001896C3480
	// [XID] // 0x00000001896C3440-0x00000001896C3480
	public override bool FromJson(JSONNode node) => default; // 0x000000018314FC10-0x000000018314FF90
	// [XID] // 0x00000001896CDB70-0x00000001896CDB90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183149AD0-0x000000018314BE00
	[BlackList] // 0x00000001896D5160-0x00000001896D51A0
	// [XID] // 0x00000001896D5160-0x00000001896D51A0
	public static new ConfigGadget ParseFromJson(JSONNode node) => default; // 0x0000000183152210-0x0000000183152460
	// [XID] // 0x00000001896DF940-0x00000001896DF960
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8674 */, bool useObjectPool = false /* Metadata: 0x00AF8678 */) => default; // 0x0000000183151850-0x0000000183151B50
	// [XID] // 0x00000001896E6CE0-0x00000001896E6D00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8679 */, bool useObjectPool = false /* Metadata: 0x00AF867D */) => default; // 0x000000018314D970-0x000000018314F640
	// [XID] // 0x00000001896EE1F0-0x00000001896EE210
	public static new ConfigGadget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF867E */, bool useObjectPool = false /* Metadata: 0x00AF8682 */) => default; // 0x00000001831500E0-0x0000000183150300
	[BlackList] // 0x00000001896F5B00-0x00000001896F5B40
	// [XID] // 0x00000001896F5B00-0x00000001896F5B40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018314BE00-0x000000018314C0D0
	// [XID] // 0x00000001897000A0-0x00000001897000C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183152ED0-0x0000000183154980
	[BlackList] // 0x0000000189707790-0x00000001897077D0
	// [XID] // 0x0000000189707790-0x00000001897077D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183151550-0x0000000183151640
	[BlackList] // 0x0000000189712270-0x00000001897122B0
	// [XID] // 0x0000000189712270-0x00000001897122B0
	public override void AutoAllocTypeFields() {} // 0x000000018314C230-0x000000018314C2D0
	[BlackList] // 0x000000018971C6C0-0x000000018971C700
	// [XID] // 0x000000018971C6C0-0x000000018971C700
	public override void AutoRecycleTypeFields() {} // 0x000000018314C2D0-0x000000018314CD20
	[BlackList] // 0x0000000189726DA0-0x0000000189726DE0
	// [XID] // 0x0000000189726DA0-0x0000000189726DE0
	public override void ReturnToObjectPool() {} // 0x00000001831556F0-0x0000000183155790
}

