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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class WindSeedSpawnerMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16945
{
	// Fields
	private bool _refreshEnable; // 0x30
	private SimpleSafeFloat spawnerRadiusRawNum; // 0x34
	private SimpleSafeFloat spawnerHeightAngleRawNum; // 0x38
	private SimpleSafeFloat spawnerAreaAngleRawNum; // 0x3C
	private SimpleSafeFloat minDistanceToAvatarRawNum; // 0x40
	private SimpleSafeFloat moveSuppressSpeedRawNum; // 0x44
	private SimpleSafeFloat moveRefreshAngleFreezeRawNum; // 0x48
	private SimpleSafeFloat moveRefreshAngleSlowRawNum; // 0x4C
	private SimpleSafeUInt32 minNumPerSpawnRawNum; // 0x50
	private SimpleSafeUInt32 maxNumPerSpawnRawNum; // 0x54
	private SimpleSafeUInt32 maxSwapNumPerSpawnRawNum; // 0x58
	private SimpleSafeFloat minSeparateRangeRawNum; // 0x5C
	private SimpleSafeFloat maxSeparateRangeRawNum; // 0x60
	private SimpleSafeFloat removeSeedDistanceRawNum; // 0x64
	private SimpleSafeFloat refreshMeterPerMeterRawNum; // 0x68
	private SimpleSafeFloat refreshMeterPerSecondRawNum; // 0x6C
	private SimpleSafeFloat refreshMeterPerDistRemoveRawNum; // 0x70
	private SimpleSafeFloat refreshMeterMaxRawNum; // 0x74
	private string _windForceModifier; // 0x78
	private string _windExplodeModifier; // 0x80
	private string _windBulletAbility; // 0x88
	private string _globalValueKey; // 0x90
	private SimpleSafeUInt32[] _spawnNumArray; // 0x98
	private SimpleSafeUInt32 seedGadgetIDRawNum; // 0xA0
	private SimpleSafeFloat initSignalStrengthRawNum; // 0xA4
	private SimpleSafeFloat triggerSignalStrengthRawNum; // 0xA8
	private SimpleSafeFloat signalDecaySpeedRawNum; // 0xAC
	private SimpleSafeFloat mutipleRangeRawNum; // 0xB0
	private SimpleSafeFloat catchSeedRangeRawNum; // 0xB4

	// Properties
	public bool refreshEnable { /* [XID] */ /* 0x0000000189BD6600-0x0000000189BD6620 */ get => default; /* [XID] */ /* 0x0000000189BDE220-0x0000000189BDE240 */ private set {} } // 0x0000000182C589F0-0x0000000182C58A90 0x0000000182C54490-0x0000000182C54540
	public float spawnerRadius { /* [XID] */ /* 0x00000001895EAD70-0x00000001895EAD90 */ get => default; /* [XID] */ /* 0x00000001895F2250-0x00000001895F2270 */ private set {} } // 0x0000000182C543B0-0x0000000182C54490 0x0000000182C57830-0x0000000182C57910
	public float spawnerHeightAngle { /* [XID] */ /* 0x00000001895F9C20-0x00000001895F9C40 */ get => default; /* [XID] */ /* 0x00000001896013A0-0x00000001896013C0 */ private set {} } // 0x0000000182C55B00-0x0000000182C55BE0 0x0000000182C566E0-0x0000000182C567C0
	public float spawnerAreaAngle { /* [XID] */ /* 0x0000000189608D90-0x0000000189608DB0 */ get => default; /* [XID] */ /* 0x00000001896104D0-0x00000001896104F0 */ private set {} } // 0x0000000182C56F00-0x0000000182C56FE0 0x0000000182C542D0-0x0000000182C543B0
	public float minDistanceToAvatar { /* [XID] */ /* 0x00000001896177D0-0x00000001896177F0 */ get => default; /* [XID] */ /* 0x000000018961F3E0-0x000000018961F400 */ private set {} } // 0x0000000182C5A570-0x0000000182C5A650 0x0000000182C57D70-0x0000000182C57E50
	public float moveSuppressSpeed { /* [XID] */ /* 0x0000000189626800-0x0000000189626820 */ get => default; /* [XID] */ /* 0x000000018962E030-0x000000018962E050 */ private set {} } // 0x0000000182C58860-0x0000000182C58940 0x0000000182C53FC0-0x0000000182C540A0
	public float moveRefreshAngleFreeze { /* [XID] */ /* 0x0000000189635D10-0x0000000189635D30 */ get => default; /* [XID] */ /* 0x000000018963D450-0x000000018963D470 */ private set {} } // 0x0000000182C535E0-0x0000000182C536C0 0x0000000182C55A20-0x0000000182C55B00
	public float moveRefreshAngleSlow { /* [XID] */ /* 0x00000001896449D0-0x00000001896449F0 */ get => default; /* [XID] */ /* 0x000000018964C1F0-0x000000018964C210 */ private set {} } // 0x0000000182C53EE0-0x0000000182C53FC0 0x0000000182C55EB0-0x0000000182C55F90
	public uint minNumPerSpawn { /* [XID] */ /* 0x0000000189653960-0x0000000189653980 */ get => default; /* [XID] */ /* 0x000000018965B230-0x000000018965B250 */ private set {} } // 0x0000000182C58790-0x0000000182C58860 0x0000000182C567C0-0x0000000182C568A0
	public uint maxNumPerSpawn { /* [XID] */ /* 0x00000001896626C0-0x00000001896626E0 */ get => default; /* [XID] */ /* 0x000000018966A260-0x000000018966A280 */ private set {} } // 0x0000000182C514C0-0x0000000182C51590 0x0000000182C51590-0x0000000182C51670
	public uint maxSwapNumPerSpawn { /* [XID] */ /* 0x0000000189671EC0-0x0000000189671EE0 */ get => default; /* [XID] */ /* 0x0000000189679690-0x00000001896796B0 */ private set {} } // 0x0000000182C558D0-0x0000000182C559A0 0x0000000182C55CB0-0x0000000182C55D90
	public float minSeparateRange { /* [XID] */ /* 0x0000000189680DE0-0x0000000189680E00 */ get => default; /* [XID] */ /* 0x0000000189688800-0x0000000189688820 */ private set {} } // 0x0000000182C59D40-0x0000000182C59E20 0x0000000182C585D0-0x0000000182C586B0
	public float maxSeparateRange { /* [XID] */ /* 0x00000001896901E0-0x0000000189690200 */ get => default; /* [XID] */ /* 0x0000000189697B60-0x0000000189697B80 */ private set {} } // 0x0000000182C54540-0x0000000182C54620 0x0000000182C58410-0x0000000182C584F0
	public float removeSeedDistance { /* [XID] */ /* 0x000000018969EED0-0x000000018969EEF0 */ get => default; /* [XID] */ /* 0x00000001896A6370-0x00000001896A6390 */ private set {} } // 0x0000000182C586B0-0x0000000182C58790 0x0000000182C536C0-0x0000000182C537A0
	public float refreshMeterPerMeter { /* [XID] */ /* 0x00000001896AD8D0-0x00000001896AD8F0 */ get => default; /* [XID] */ /* 0x00000001896B4FB0-0x00000001896B4FD0 */ private set {} } // 0x0000000182C540A0-0x0000000182C54180 0x0000000182C54620-0x0000000182C54700
	public float refreshMeterPerSecond { /* [XID] */ /* 0x00000001896BC2A0-0x00000001896BC2C0 */ get => default; /* [XID] */ /* 0x00000001896C3700-0x00000001896C3720 */ private set {} } // 0x0000000182C59FE0-0x0000000182C5A0C0 0x0000000182C579C0-0x0000000182C57AA0
	public float refreshMeterPerDistRemove { /* [XID] */ /* 0x00000001896CAC70-0x00000001896CAC90 */ get => default; /* [XID] */ /* 0x00000001896D2320-0x00000001896D2340 */ private set {} } // 0x0000000182C53C10-0x0000000182C53CF0 0x0000000182C57AA0-0x0000000182C57B80
	public float refreshMeterMax { /* [XID] */ /* 0x00000001896D9CB0-0x00000001896D9CD0 */ get => default; /* [XID] */ /* 0x00000001896E1350-0x00000001896E1370 */ private set {} } // 0x0000000182C53B30-0x0000000182C53C10 0x0000000182C57C90-0x0000000182C57D70
	public string windForceModifier { /* [XID] */ /* 0x00000001896E8600-0x00000001896E8620 */ get => default; /* [XID] */ /* 0x00000001896EFB00-0x00000001896EFB20 */ private set {} } // 0x0000000182C54180-0x0000000182C54220 0x0000000182C569F0-0x0000000182C56AA0
	public string windExplodeModifier { /* [XID] */ /* 0x00000001896F7530-0x00000001896F7550 */ get => default; /* [XID] */ /* 0x00000001896FEEF0-0x00000001896FEF10 */ private set {} } // 0x0000000182C55F90-0x0000000182C56040 0x0000000182C57910-0x0000000182C579C0
	public string windBulletAbility { /* [XID] */ /* 0x0000000189706140-0x0000000189706160 */ get => default; /* [XID] */ /* 0x000000018970DA70-0x000000018970DA90 */ private set {} } // 0x0000000182C59C90-0x0000000182C59D40 0x0000000182C58940-0x0000000182C589F0
	public string globalValueKey { /* [XID] */ /* 0x0000000189714E90-0x0000000189714EB0 */ get => default; /* [XID] */ /* 0x000000018971C960-0x000000018971C980 */ private set {} } // 0x0000000182C57120-0x0000000182C571D0 0x0000000182C54220-0x0000000182C542D0
	public SimpleSafeUInt32[] spawnNumArray { /* [XID] */ /* 0x0000000189723D90-0x0000000189723DB0 */ get => default; /* [XID] */ /* 0x000000018972B530-0x000000018972B550 */ private set {} } // 0x0000000182C57B80-0x0000000182C57C30 0x0000000182C572C0-0x0000000182C57370
	public uint seedGadgetID { /* [XID] */ /* 0x0000000189732D60-0x0000000189732D80 */ get => default; /* [XID] */ /* 0x000000018973A470-0x000000018973A490 */ private set {} } // 0x0000000182C55BE0-0x0000000182C55CB0 0x0000000182C584F0-0x0000000182C585D0
	public float initSignalStrength { /* [XID] */ /* 0x0000000189741E20-0x0000000189741E40 */ get => default; /* [XID] */ /* 0x00000001897497E0-0x0000000189749800 */ private set {} } // 0x0000000182C51670-0x0000000182C51750 0x0000000182C58180-0x0000000182C58260
	public float triggerSignalStrength { /* [XID] */ /* 0x0000000189750CE0-0x0000000189750D00 */ get => default; /* [XID] */ /* 0x00000001897580F0-0x0000000189758110 */ private set {} } // 0x0000000182C59E20-0x0000000182C59F00 0x0000000182C57E50-0x0000000182C57F30
	public float signalDecaySpeed { /* [XID] */ /* 0x000000018975FC30-0x000000018975FC50 */ get => default; /* [XID] */ /* 0x00000001897672E0-0x0000000189767300 */ private set {} } // 0x0000000182C59F00-0x0000000182C59FE0 0x0000000182C5A0C0-0x0000000182C5A1A0
	public float mutipleRange { /* [XID] */ /* 0x000000018976E7C0-0x000000018976E7E0 */ get => default; /* [XID] */ /* 0x0000000189776220-0x0000000189776240 */ private set {} } // 0x0000000182C56AA0-0x0000000182C56B80 0x0000000182C57040-0x0000000182C57120
	public float catchSeedRange { /* [XID] */ /* 0x000000018977D940-0x000000018977D960 */ get => default; /* [XID] */ /* 0x0000000189785160-0x0000000189785180 */ private set {} } // 0x0000000182C557F0-0x0000000182C558D0 0x0000000182C56910-0x0000000182C569F0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189809F10-0x0000000189809F30 */ get => default; } // 0x0000000182C55E10-0x0000000182C55EB0 

	// Constructors
	public WindSeedSpawnerMixin() {} // 0x0000000182C5A6F0-0x0000000182C5A9B0

	// Methods
	// [XID] // 0x000000018978C630-0x000000018978C650
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C5A1A0-0x0000000182C5A570
	// [XID] // 0x0000000189793B40-0x0000000189793B60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182C582C0-0x0000000182C58410
	// [XID] // 0x000000018979BDB0-0x000000018979BDD0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5E57 */) => default; // 0x0000000182C57750-0x0000000182C57830
	// [XID] // 0x00000001897A3220-0x00000001897A3240
	public override int GetHashNum() => default; // 0x0000000182C53E10-0x0000000182C53EE0
	// [XID] // 0x00000001897AA820-0x00000001897AA840
	public override void InitEmpty() {} // 0x0000000182C56B80-0x0000000182C56E80
	[BlackList] // 0x00000001897B2330-0x00000001897B2370
	// [XID] // 0x00000001897B2330-0x00000001897B2370
	public override bool FromJson(JSONNode node) => default; // 0x0000000182C56040-0x0000000182C563C0
	// [XID] // 0x00000001897BD860-0x00000001897BD880
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182C51750-0x0000000182C53310
	[BlackList] // 0x00000001897C4C40-0x00000001897C4C80
	// [XID] // 0x00000001897C4C40-0x00000001897C4C80
	public static new WindSeedSpawnerMixin ParseFromJson(JSONNode node) => default; // 0x0000000182C57F30-0x0000000182C58180
	// [XID] // 0x00000001897CF550-0x00000001897CF570
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E58 */, bool useObjectPool = false /* Metadata: 0x00AF5E5C */) => default; // 0x0000000182C57370-0x0000000182C57670
	// [XID] // 0x00000001897D6DC0-0x00000001897D6DE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E5D */, bool useObjectPool = false /* Metadata: 0x00AF5E61 */) => default; // 0x0000000182C547E0-0x0000000182C557F0
	// [XID] // 0x00000001897DE470-0x00000001897DE490
	public static new WindSeedSpawnerMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E62 */, bool useObjectPool = false /* Metadata: 0x00AF5E66 */) => default; // 0x0000000182C56430-0x0000000182C56650
	[BlackList] // 0x00000001897E5F50-0x00000001897E5F90
	// [XID] // 0x00000001897E5F50-0x00000001897E5F90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C53310-0x0000000182C535E0
	// [XID] // 0x00000001897F0AA0-0x00000001897F0AC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C58A90-0x0000000182C59C90
	[BlackList] // 0x00000001897F8200-0x00000001897F8240
	// [XID] // 0x00000001897F8200-0x00000001897F8240
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182C571D0-0x0000000182C572C0
	// [XID] // 0x0000000189802880-0x00000001898028A0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182C57670-0x0000000182C57750
	[BlackList] // 0x00000001898115E0-0x0000000189811620
	// [XID] // 0x00000001898115E0-0x0000000189811620
	public override void AutoAllocTypeFields() {} // 0x0000000182C537A0-0x0000000182C53840
	[BlackList] // 0x000000018981BF20-0x000000018981BF60
	// [XID] // 0x000000018981BF20-0x000000018981BF60
	public override void AutoRecycleTypeFields() {} // 0x0000000182C53840-0x0000000182C53B30
	[BlackList] // 0x0000000189826470-0x00000001898264B0
	// [XID] // 0x0000000189826470-0x00000001898264B0
	public override void ReturnToObjectPool() {} // 0x0000000182C5A650-0x0000000182C5A6F0
}

