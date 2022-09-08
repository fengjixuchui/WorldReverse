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
public class SteerAttackMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16908
{
	// Fields
	private string[] _steerStateIDs; // 0x30
	private SimpleSafeFloat startNormalizedTimeRawNum; // 0x38
	private SimpleSafeFloat endNormalizedTimeRawNum; // 0x3C
	private SimpleSafeFloat angularSpeedRawNum; // 0x40
	private SimpleSafeFloat attackAngleRawNum; // 0x44
	private string _attackTrigger; // 0x48
	private SimpleSafeFloat attackDistanceRawNum; // 0x50

	// Properties
	public string[] steerStateIDs { /* [XID] */ /* 0x00000001896D0C80-0x00000001896D0CA0 */ get => default; /* [XID] */ /* 0x00000001896D8270-0x00000001896D8290 */ private set {} } // 0x0000000181FF9220-0x0000000181FF92C0 0x0000000181FFBBA0-0x0000000181FFBC50
	public float startNormalizedTime { /* [XID] */ /* 0x00000001896DFBC0-0x00000001896DFBE0 */ get => default; /* [XID] */ /* 0x00000001896E6F60-0x00000001896E6F80 */ private set {} } // 0x0000000181FFB470-0x0000000181FFB550 0x0000000181FF9090-0x0000000181FF9170
	public float endNormalizedTime { /* [XID] */ /* 0x00000001896EE4D0-0x00000001896EE4F0 */ get => default; /* [XID] */ /* 0x00000001896F5DC0-0x00000001896F5DE0 */ private set {} } // 0x0000000181FF9C20-0x0000000181FF9D00 0x0000000181FFA080-0x0000000181FFA160
	public float angularSpeed { /* [XID] */ /* 0x00000001896FD5D0-0x00000001896FD5F0 */ get => default; /* [XID] */ /* 0x0000000189704A10-0x0000000189704A30 */ private set {} } // 0x0000000181FFA5D0-0x0000000181FFA6B0 0x0000000181FFB150-0x0000000181FFB230
	public float attackAngle { /* [XID] */ /* 0x000000018970C190-0x000000018970C1B0 */ get => default; /* [XID] */ /* 0x0000000189713BC0-0x0000000189713BE0 */ private set {} } // 0x0000000181FFB390-0x0000000181FFB470 0x0000000181FF9900-0x0000000181FF99E0
	public string attackTrigger { /* [XID] */ /* 0x000000018971B420-0x000000018971B440 */ get => default; /* [XID] */ /* 0x0000000189722680-0x00000001897226A0 */ private set {} } // 0x0000000181FF9AE0-0x0000000181FF9B80 0x0000000181FF9170-0x0000000181FF9220
	public float attackDistance { /* [XID] */ /* 0x0000000189729DE0-0x0000000189729E00 */ get => default; /* [XID] */ /* 0x0000000189731500-0x0000000189731520 */ private set {} } // 0x0000000181FFA4F0-0x0000000181FFA5D0 0x0000000181FFBAC0-0x0000000181FFBBA0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001897B5B30-0x00000001897B5B50 */ get => default; } // 0x0000000181FF9B80-0x0000000181FF9C20 

	// Constructors
	public SteerAttackMixin() {} // 0x0000000181FFBE90-0x0000000181FFBF50

	// Methods
	// [XID] // 0x0000000189738D50-0x0000000189738D70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FFBC50-0x0000000181FFBDF0
	// [XID] // 0x0000000189740B40-0x0000000189740B60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181FFB290-0x0000000181FFB390
	// [XID] // 0x0000000189747F60-0x0000000189747F80
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5D39 */) => default; // 0x0000000181FFADC0-0x0000000181FFAEA0
	// [XID] // 0x000000018974F690-0x000000018974F6B0
	public override int GetHashNum() => default; // 0x0000000181FF8F60-0x0000000181FF9030
	// [XID] // 0x0000000189756CE0-0x0000000189756D00
	public override void InitEmpty() {} // 0x0000000181FFA6B0-0x0000000181FFA810
	[BlackList] // 0x000000018975E1D0-0x000000018975E210
	// [XID] // 0x000000018975E1D0-0x000000018975E210
	public override bool FromJson(JSONNode node) => default; // 0x0000000181FF9D00-0x0000000181FFA080
	// [XID] // 0x00000001897688A0-0x00000001897688C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181FF8140-0x0000000181FF89A0
	[BlackList] // 0x000000018976FF50-0x000000018976FF90
	// [XID] // 0x000000018976FF50-0x000000018976FF90
	public static new SteerAttackMixin ParseFromJson(JSONNode node) => default; // 0x0000000181FFAF00-0x0000000181FFB150
	// [XID] // 0x000000018977A620-0x000000018977A640
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D3A */, bool useObjectPool = false /* Metadata: 0x00AF5D3E */) => default; // 0x0000000181FFA9E0-0x0000000181FFACE0
	// [XID] // 0x0000000189782200-0x0000000189782220
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D3F */, bool useObjectPool = false /* Metadata: 0x00AF5D43 */) => default; // 0x0000000181FF9340-0x0000000181FF9900
	// [XID] // 0x00000001897895A0-0x00000001897895C0
	public static new SteerAttackMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D44 */, bool useObjectPool = false /* Metadata: 0x00AF5D48 */) => default; // 0x0000000181FFA1D0-0x0000000181FFA3F0
	[BlackList] // 0x0000000189790C70-0x0000000189790CB0
	// [XID] // 0x0000000189790C70-0x0000000189790CB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FF89A0-0x0000000181FF8C70
	// [XID] // 0x000000018979BDF0-0x000000018979BE10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FFB550-0x0000000181FFBAC0
	[BlackList] // 0x00000001897A3280-0x00000001897A32C0
	// [XID] // 0x00000001897A3280-0x00000001897A32C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181FFA8F0-0x0000000181FFA9E0
	// [XID] // 0x00000001897ADA10-0x00000001897ADA30
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181FFACE0-0x0000000181FFADC0
	[BlackList] // 0x00000001897BD8C0-0x00000001897BD900
	// [XID] // 0x00000001897BD8C0-0x00000001897BD900
	public override void AutoAllocTypeFields() {} // 0x0000000181FF8C70-0x0000000181FF8D10
	[BlackList] // 0x00000001897C81B0-0x00000001897C81F0
	// [XID] // 0x00000001897C81B0-0x00000001897C81F0
	public override void AutoRecycleTypeFields() {} // 0x0000000181FF8D10-0x0000000181FF8E40
	[BlackList] // 0x00000001897D24F0-0x00000001897D2530
	// [XID] // 0x00000001897D24F0-0x00000001897D2530
	public override void ReturnToObjectPool() {} // 0x0000000181FFBDF0-0x0000000181FFBE90
}

