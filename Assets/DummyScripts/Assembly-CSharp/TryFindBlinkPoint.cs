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
public class TryFindBlinkPoint : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16551
{
	// Fields
	private SimpleSafeFloat forwardAngleRawNum; // 0x68
	private SimpleSafeFloat minRangeRawNum; // 0x6C
	private SimpleSafeFloat maxRangeRawNum; // 0x70
	private SimpleSafeFloat limitYRawNum; // 0x74
	private bool _ignoreWater; // 0x78

	// Properties
	public float forwardAngle { /* [XID] */ /* 0x0000000189886440-0x0000000189886460 */ get => default; /* [XID] */ /* 0x000000018988D560-0x000000018988D580 */ private set {} } // 0x0000000182552830-0x0000000182552910 0x0000000182551780-0x0000000182551860
	public float minRange { /* [XID] */ /* 0x0000000189894CD0-0x0000000189894CF0 */ get => default; /* [XID] */ /* 0x000000018989C2A0-0x000000018989C2C0 */ private set {} } // 0x0000000182552F50-0x0000000182553030 0x0000000182550E20-0x0000000182550F00
	public float maxRange { /* [XID] */ /* 0x00000001898A3940-0x00000001898A3960 */ get => default; /* [XID] */ /* 0x00000001898AACE0-0x00000001898AAD00 */ private set {} } // 0x0000000182550B10-0x0000000182550BF0 0x0000000182551F20-0x0000000182552000
	public float limitY { /* [XID] */ /* 0x00000001898B25D0-0x00000001898B25F0 */ get => default; /* [XID] */ /* 0x00000001898BA400-0x00000001898BA420 */ private set {} } // 0x0000000182550CD0-0x0000000182550DB0 0x0000000182550BF0-0x0000000182550CD0
	public bool ignoreWater { /* [XID] */ /* 0x00000001898C1720-0x00000001898C1740 */ get => default; /* [XID] */ /* 0x00000001898C9060-0x00000001898C9080 */ private set {} } // 0x0000000182551480-0x0000000182551520 0x0000000182551BE0-0x0000000182551C90
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189954A60-0x0000000189954A80 */ get => default; } // 0x0000000182552CC0-0x0000000182552D60 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018995C220-0x000000018995C240 */ get => default; } // 0x0000000182552070-0x0000000182552110 

	// Constructors
	public TryFindBlinkPoint() {} // 0x0000000182553970-0x0000000182553A10

	// Methods
	// [XID] // 0x00000001898D08A0-0x00000001898D08C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001825536C0-0x0000000182553830
	// [XID] // 0x00000001898D7F80-0x00000001898D7FA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182552DC0-0x0000000182552E70
	// [XID] // 0x00000001898DFD40-0x00000001898DFD60
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3EF6 */) => default; // 0x00000001825526F0-0x00000001825527D0
	// [XID] // 0x00000001898E7810-0x00000001898E7830
	public override int GetHashNum() => default; // 0x0000000182550A40-0x0000000182550B10
	// [XID] // 0x00000001898EEF60-0x00000001898EEF80
	public override void InitEmpty() {} // 0x0000000182552110-0x0000000182552220
	[BlackList] // 0x00000001898F6820-0x00000001898F6860
	// [XID] // 0x00000001898F6820-0x00000001898F6860
	public override bool FromJson(JSONNode node) => default; // 0x0000000182551860-0x0000000182551BE0
	// [XID] // 0x00000001899010B0-0x00000001899010D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018254FDB0-0x0000000182550420
	[BlackList] // 0x0000000189908990-0x00000001899089D0
	// [XID] // 0x0000000189908990-0x00000001899089D0
	public static new TryFindBlinkPoint ParseFromJson(JSONNode node) => default; // 0x0000000182552A70-0x0000000182552CC0
	// [XID] // 0x0000000189913320-0x0000000189913340
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EF7 */, bool useObjectPool = false /* Metadata: 0x00AF3EFB */) => default; // 0x00000001825523F0-0x00000001825526F0
	// [XID] // 0x000000018991AAD0-0x000000018991AAF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EFC */, bool useObjectPool = false /* Metadata: 0x00AF3F00 */) => default; // 0x0000000182550FE0-0x0000000182551480
	// [XID] // 0x0000000189922340-0x0000000189922360
	public static new TryFindBlinkPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F01 */, bool useObjectPool = false /* Metadata: 0x00AF3F05 */) => default; // 0x0000000182551C90-0x0000000182551EB0
	[BlackList] // 0x0000000189929AC0-0x0000000189929B00
	// [XID] // 0x0000000189929AC0-0x0000000189929B00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182550420-0x00000001825506F0
	// [XID] // 0x0000000189933E80-0x0000000189933EA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182553290-0x00000001825536C0
	[BlackList] // 0x000000018993B9B0-0x000000018993B9F0
	// [XID] // 0x000000018993B9B0-0x000000018993B9F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182552300-0x00000001825523F0
	// [XID] // 0x0000000189945DA0-0x0000000189945DC0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182553830-0x00000001825538D0
	// [XID] // 0x000000018994D270-0x000000018994D290
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182551520-0x0000000182551680
	// [XID] // 0x0000000189963C60-0x0000000189963C80
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000182553110-0x0000000182553290
	// [XID] // 0x000000018996B1F0-0x000000018996B210
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000182552910-0x0000000182552A70
	[BlackList] // 0x0000000189972C90-0x0000000189972CD0
	// [XID] // 0x0000000189972C90-0x0000000189972CD0
	public override void AutoAllocTypeFields() {} // 0x00000001825506F0-0x0000000182550790
	[BlackList] // 0x000000018997CCF0-0x000000018997CD30
	// [XID] // 0x000000018997CCF0-0x000000018997CD30
	public override void AutoRecycleTypeFields() {} // 0x0000000182550790-0x00000001825508B0
	[BlackList] // 0x0000000189987AB0-0x0000000189987AF0
	// [XID] // 0x0000000189987AB0-0x0000000189987AF0
	public override void ReturnToObjectPool() {} // 0x00000001825538D0-0x0000000182553970
}

