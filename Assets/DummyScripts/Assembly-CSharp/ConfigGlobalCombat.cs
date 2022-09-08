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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigGlobalCombat : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18127
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalHit _hitData; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalCollision _collisionData; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalAI _aiData; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalMove _moveData; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarHitBucketSetting _defaultAvatarHitBucketSetting; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigBladeElementFx> _elementBladeData; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigFireGrassAirflowField _fireGrassAirflowData; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGloablMiscs _miscs; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigDefaultAbilities _defaultAbilities; // 0x50
	private Dictionary<string, Dictionary<string, SimpleSafeFloat>> _elemReactDamage; // 0x58
	private Dictionary<string, Dictionary<string, SimpleSafeFloat>> _elemAmplifyDamage; // 0x60
	private ElementType[] _elemPrority; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalShakeOff _shakeOff; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigElementShield _elementShield; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEliteShield _eliteShield; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalSwitch _globalSwitch; // 0x88
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalLockTarget _lockTarget; // 0x90
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigElementUI _elemUI; // 0x98
	private Dictionary<AbilityState, ElementReactionType[]> _rejectElementReaction; // 0xA0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigLogSetting _logSetting; // 0xA8
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigAttackAttenuation> _attackAttenuation; // 0xB0
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGadgetCreationLimit[] _gadgetCreationLimits; // 0xB8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigLuaSafetyCheckSwitch _luaSafetySwitch; // 0xC0
	private Dictionary<SimpleSafeInt32, SimpleSafeFloat> _tempComponentBudget; // 0xC8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalInteraction _globalInteraction; // 0xD0
	private MoleMole.Config.Vector[] _lampOffset; // 0xD8
	private Dictionary<AbilityState, string> _abilityStateTriggerAbilities; // 0xE0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGlobalDither _dither; // 0xE8
	private Dictionary<string, ConfigElementDecrate[]> _elementDecrateGroup; // 0xF0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigSliceFrameWatch _sliceFrameWatch; // 0xF8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigIK _ik; // 0x100
	private Dictionary<SimpleSafeInt32, EquipSizeData[]> _avatarEquipSizeDatas; // 0x108
	private Dictionary<SimpleSafeInt32, EquipSizeData[]> _manekinEquipSizeDatas; // 0x110
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBigWorldEnvironmentDamageClamp _bigWorldEnvironmentDamageClamp; // 0x118
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigTDPlay _tdPlay; // 0x120
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigSafeTypeReportData _gameAnimSafeType; // 0x128

	// Properties
	public ConfigGlobalHit hitData { /* [XID] */ /* 0x000000018972E310-0x000000018972E330 */ get => default; /* [XID] */ /* 0x00000001897359E0-0x0000000189735A00 */ private set {} } // 0x000000018570BB80-0x000000018570BC20 0x000000018570FEE0-0x000000018570FF90
	public ConfigGlobalCollision collisionData { /* [XID] */ /* 0x000000018973D570-0x000000018973D590 */ get => default; /* [XID] */ /* 0x0000000189744A10-0x0000000189744A30 */ private set {} } // 0x00000001857130C0-0x0000000185713160 0x000000018570C020-0x000000018570C0D0
	public ConfigGlobalAI aiData { /* [XID] */ /* 0x000000018974C720-0x000000018974C740 */ get => default; /* [XID] */ /* 0x00000001897539A0-0x00000001897539C0 */ private set {} } // 0x000000018570FE40-0x000000018570FEE0 0x000000018570E320-0x000000018570E3D0
	public ConfigGlobalMove moveData { /* [XID] */ /* 0x000000018975AFA0-0x000000018975AFC0 */ get => default; /* [XID] */ /* 0x0000000189762930-0x0000000189762950 */ private set {} } // 0x0000000185710B20-0x0000000185710BC0 0x00000001857100F0-0x00000001857101A0
	public ConfigAvatarHitBucketSetting defaultAvatarHitBucketSetting { /* [XID] */ /* 0x0000000189769F50-0x0000000189769F70 */ get => default; /* [XID] */ /* 0x0000000189771750-0x0000000189771770 */ private set {} } // 0x000000018570BC20-0x000000018570BCC0 0x000000018570F670-0x000000018570F720
	public Dictionary<string, ConfigBladeElementFx> elementBladeData { /* [XID] */ /* 0x0000000189778EC0-0x0000000189778EE0 */ get => default; /* [XID] */ /* 0x00000001897805C0-0x00000001897805E0 */ private set {} } // 0x000000018570EED0-0x000000018570EF70 0x00000001857086A0-0x0000000185708750
	public ConfigFireGrassAirflowField fireGrassAirflowData { /* [XID] */ /* 0x00000001898E3240-0x00000001898E3260 */ get => default; /* [XID] */ /* 0x000000018978F2E0-0x000000018978F300 */ private set {} } // 0x000000018570C0D0-0x000000018570C170 0x000000018570BD60-0x000000018570BE10
	public ConfigGloablMiscs miscs { /* [XID] */ /* 0x0000000189796AB0-0x0000000189796AD0 */ get => default; /* [XID] */ /* 0x000000018979EC50-0x000000018979EC70 */ private set {} } // 0x000000018570BCC0-0x000000018570BD60 0x0000000185713010-0x00000001857130C0
	public ConfigDefaultAbilities defaultAbilities { /* [XID] */ /* 0x00000001897A62C0-0x00000001897A62E0 */ get => default; /* [XID] */ /* 0x00000001897AD6F0-0x00000001897AD710 */ private set {} } // 0x00000001857107C0-0x0000000185710860 0x000000018570BE10-0x000000018570BEC0
	public Dictionary<string, Dictionary<string, SimpleSafeFloat>> elemReactDamage { /* [XID] */ /* 0x00000001897B5850-0x00000001897B5870 */ get => default; /* [XID] */ /* 0x00000001897BD580-0x00000001897BD5A0 */ private set {} } // 0x000000018570BAE0-0x000000018570BB80 0x000000018570E110-0x000000018570E1C0
	public Dictionary<string, Dictionary<string, SimpleSafeFloat>> elemAmplifyDamage { /* [XID] */ /* 0x000000018962B990-0x000000018962B9B0 */ get => default; /* [XID] */ /* 0x00000001897CC190-0x00000001897CC1B0 */ private set {} } // 0x0000000185712660-0x0000000185712700 0x000000018570EF70-0x000000018570F020
	public ElementType[] elemPrority { /* [XID] */ /* 0x00000001897D3AE0-0x00000001897D3B00 */ get => default; /* [XID] */ /* 0x00000001897DB550-0x00000001897DB570 */ private set {} } // 0x0000000185710460-0x0000000185710500 0x0000000185712F60-0x0000000185713010
	public ConfigGlobalShakeOff shakeOff { /* [XID] */ /* 0x0000000189AB3BC0-0x0000000189AB3BE0 */ get => default; /* [XID] */ /* 0x00000001897EA420-0x00000001897EA440 */ private set {} } // 0x000000018570EC20-0x000000018570ECC0 0x000000018570F020-0x000000018570F0D0
	public ConfigElementShield elementShield { /* [XID] */ /* 0x00000001897F2150-0x00000001897F2170 */ get => default; /* [XID] */ /* 0x00000001897F9880-0x00000001897F98A0 */ private set {} } // 0x000000018570C170-0x000000018570C210 0x000000018570EA10-0x000000018570EAC0
	public ConfigEliteShield eliteShield { /* [XID] */ /* 0x0000000189800DC0-0x0000000189800DE0 */ get => default; /* [XID] */ /* 0x0000000189808320-0x0000000189808340 */ private set {} } // 0x000000018570FF90-0x0000000185710040 0x000000018570A9A0-0x000000018570AA50
	public ConfigGlobalSwitch globalSwitch { /* [XID] */ /* 0x000000018980FD90-0x000000018980FDB0 */ get => default; /* [XID] */ /* 0x00000001898173A0-0x00000001898173C0 */ private set {} } // 0x000000018570E1C0-0x000000018570E270 0x000000018570BEC0-0x000000018570BF70
	public ConfigGlobalLockTarget lockTarget { /* [XID] */ /* 0x000000018981ED00-0x000000018981ED20 */ get => default; /* [XID] */ /* 0x0000000189826210-0x0000000189826230 */ private set {} } // 0x000000018570F180-0x000000018570F230 0x0000000185710910-0x00000001857109C0
	public ConfigElementUI elemUI { /* [XID] */ /* 0x0000000189ACBEE0-0x0000000189ACBF00 */ get => default; /* [XID] */ /* 0x0000000189834FB0-0x0000000189834FD0 */ private set {} } // 0x00000001857105B0-0x0000000185710660 0x000000018570E3D0-0x000000018570E480
	public Dictionary<AbilityState, ElementReactionType[]> rejectElementReaction { /* [XID] */ /* 0x0000000189A07D10-0x0000000189A07D30 */ get => default; /* [XID] */ /* 0x0000000189843DA0-0x0000000189843DC0 */ private set {} } // 0x0000000185710BC0-0x0000000185710C70 0x000000018570BF70-0x000000018570C020
	public ConfigLogSetting logSetting { /* [XID] */ /* 0x000000018984B2D0-0x000000018984B2F0 */ get => default; /* [XID] */ /* 0x00000001898524C0-0x00000001898524E0 */ private set {} } // 0x0000000185710660-0x0000000185710710 0x000000018570E270-0x000000018570E320
	public Dictionary<string, ConfigAttackAttenuation> attackAttenuation { /* [XID] */ /* 0x0000000189859E30-0x0000000189859E50 */ get => default; /* [XID] */ /* 0x0000000189860F30-0x0000000189860F50 */ private set {} } // 0x000000018570E530-0x000000018570E5E0 0x000000018570E480-0x000000018570E530
	public ConfigGadgetCreationLimit[] gadgetCreationLimits { /* [XID] */ /* 0x0000000189868730-0x0000000189868750 */ get => default; /* [XID] */ /* 0x000000018986FBA0-0x000000018986FBC0 */ private set {} } // 0x0000000185710300-0x00000001857103B0 0x0000000185708540-0x00000001857085F0
	public ConfigLuaSafetyCheckSwitch luaSafetySwitch { /* [XID] */ /* 0x00000001898772B0-0x00000001898772D0 */ get => default; /* [XID] */ /* 0x000000018987EBC0-0x000000018987EBE0 */ private set {} } // 0x000000018570F720-0x000000018570F7D0 0x000000018570ECC0-0x000000018570ED70
	public Dictionary<SimpleSafeInt32, SimpleSafeFloat> tempComponentBudget { /* [XID] */ /* 0x000000018960B020-0x000000018960B040 */ get => default; /* [XID] */ /* 0x000000018988D360-0x000000018988D380 */ private set {} } // 0x000000018570E5E0-0x000000018570E690 0x000000018570EB70-0x000000018570EC20
	public ConfigGlobalInteraction globalInteraction { /* [XID] */ /* 0x0000000189894A10-0x0000000189894A30 */ get => default; /* [XID] */ /* 0x000000018989BF40-0x000000018989BF60 */ private set {} } // 0x000000018570F7D0-0x000000018570F880 0x00000001857103B0-0x0000000185710460
	public MoleMole.Config.Vector[] lampOffset { /* [XID] */ /* 0x00000001898A3600-0x00000001898A3620 */ get => default; /* [XID] */ /* 0x00000001898AA9A0-0x00000001898AA9C0 */ private set {} } // 0x000000018570C210-0x000000018570C2C0 0x000000018570F0D0-0x000000018570F180
	public Dictionary<AbilityState, string> abilityStateTriggerAbilities { /* [XID] */ /* 0x00000001898B2370-0x00000001898B2390 */ get => default; /* [XID] */ /* 0x00000001898BA120-0x00000001898BA140 */ private set {} } // 0x000000018570BA30-0x000000018570BAE0 0x000000018570F5C0-0x000000018570F670
	public ConfigGlobalDither dither { /* [XID] */ /* 0x00000001898C1460-0x00000001898C1480 */ get => default; /* [XID] */ /* 0x00000001898C8DC0-0x00000001898C8DE0 */ private set {} } // 0x0000000185710A70-0x0000000185710B20 0x000000018570FD90-0x000000018570FE40
	public Dictionary<string, ConfigElementDecrate[]> elementDecrateGroup { /* [XID] */ /* 0x00000001898D0620-0x00000001898D0640 */ get => default; /* [XID] */ /* 0x00000001898D7CE0-0x00000001898D7D00 */ private set {} } // 0x00000001857085F0-0x00000001857086A0 0x000000018570FCE0-0x000000018570FD90
	public ConfigSliceFrameWatch sliceFrameWatch { /* [XID] */ /* 0x00000001898DF980-0x00000001898DF9A0 */ get => default; /* [XID] */ /* 0x00000001898E7470-0x00000001898E7490 */ private set {} } // 0x00000001857109C0-0x0000000185710A70 0x0000000185710040-0x00000001857100F0
	public ConfigIK ik { /* [XID] */ /* 0x00000001898EECA0-0x00000001898EECC0 */ get => default; /* [XID] */ /* 0x00000001898F6560-0x00000001898F6580 */ private set {} } // 0x000000018570EE20-0x000000018570EED0 0x000000018570B980-0x000000018570BA30
	public Dictionary<SimpleSafeInt32, EquipSizeData[]> avatarEquipSizeDatas { /* [XID] */ /* 0x00000001898FDC80-0x00000001898FDCA0 */ get => default; /* [XID] */ /* 0x0000000189905480-0x00000001899054A0 */ private set {} } // 0x0000000185710710-0x00000001857107C0 0x000000018570FC30-0x000000018570FCE0
	public Dictionary<SimpleSafeInt32, EquipSizeData[]> manekinEquipSizeDatas { /* [XID] */ /* 0x00000001898D9FB0-0x00000001898D9FD0 */ get => default; /* [XID] */ /* 0x0000000189914500-0x0000000189914520 */ private set {} } // 0x00000001857101A0-0x0000000185710250 0x000000018570ED70-0x000000018570EE20
	public ConfigBigWorldEnvironmentDamageClamp bigWorldEnvironmentDamageClamp { /* [XID] */ /* 0x000000018991B470-0x000000018991B490 */ get => default; /* [XID] */ /* 0x0000000189923740-0x0000000189923760 */ private set {} } // 0x0000000185710860-0x0000000185710910 0x0000000185710250-0x0000000185710300
	public ConfigTDPlay tdPlay { /* [XID] */ /* 0x000000018992AE00-0x000000018992AE20 */ get => default; /* [XID] */ /* 0x0000000189932420-0x0000000189932440 */ private set {} } // 0x0000000185710500-0x00000001857105B0 0x000000018570EAC0-0x000000018570EB70
	public ConfigSafeTypeReportData gameAnimSafeType { /* [XID] */ /* 0x0000000189939E30-0x0000000189939E50 */ get => default; /* [XID] */ /* 0x0000000189941020-0x0000000189941040 */ private set {} } // 0x0000000185712700-0x00000001857127B0 0x000000018570FB80-0x000000018570FC30

	// Constructors
	public ConfigGlobalCombat() {} // 0x0000000185713200-0x0000000185713260

	// Methods
	// [XID] // 0x0000000189948AE0-0x0000000189948B00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001857127B0-0x0000000185712E20
	// [XID] // 0x0000000189950250-0x0000000189950270
	public void InitEmpty() {} // 0x000000018570F230-0x000000018570F5C0
	[BlackList] // 0x00000001899577E0-0x0000000189957820
	// [XID] // 0x00000001899577E0-0x0000000189957820
	public bool FromJson(JSONNode node) => default; // 0x000000018570E690-0x000000018570EA10
	// [XID] // 0x0000000189962390-0x00000001899623B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185708750-0x000000018570A9A0
	// [XID] // 0x0000000189969860-0x0000000189969880
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C0D */, bool useObjectPool = false /* Metadata: 0x00AF8C11 */) => default; // 0x000000018570F880-0x000000018570FB80
	// [XID] // 0x00000001899715A0-0x00000001899715C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C12 */, bool useObjectPool = false /* Metadata: 0x00AF8C16 */) => default; // 0x000000018570C2C0-0x000000018570E110
	[BlackList] // 0x0000000189978FB0-0x0000000189978FF0
	// [XID] // 0x0000000189978FB0-0x0000000189978FF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018570AA50-0x000000018570AD20
	// [XID] // 0x0000000189983430-0x0000000189983450
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185710C70-0x0000000185712660
	[BlackList] // 0x000000018998AC40-0x000000018998AC80
	// [XID] // 0x000000018998AC40-0x000000018998AC80
	public virtual void AutoAllocTypeFields() {} // 0x000000018570AD20-0x000000018570ADC0
	[BlackList] // 0x0000000189995630-0x0000000189995670
	// [XID] // 0x0000000189995630-0x0000000189995670
	public virtual void AutoRecycleTypeFields() {} // 0x000000018570ADC0-0x000000018570B980
	[BlackList] // 0x000000018999FF90-0x000000018999FFD0
	// [XID] // 0x000000018999FF90-0x000000018999FFD0
	public virtual void ReturnToObjectPool() {} // 0x0000000185713160-0x0000000185713200
	[BlackList] // 0x00000001899AAA80-0x00000001899AAAC0
	// [XID] // 0x00000001899AAA80-0x00000001899AAAC0
	public virtual void OnPoolAllocated() {} // 0x0000000185712EC0-0x0000000185712F60
	[BlackList] // 0x00000001899B52A0-0x00000001899B52E0
	// [XID] // 0x00000001899B52A0-0x00000001899B52E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185712E20-0x0000000185712EC0
}

