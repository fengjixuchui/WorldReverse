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
public class EliteShieldMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16922
{
	// Fields
	private string _shieldType; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _shieldAngle; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _shieldHPRatio; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _shieldHP; // 0x48
	private string _costShieldRatioName; // 0x50
	private string _showDamageText; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onShieldBroken; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByGetDamage; // 0x68
	private bool _targetMuteHitEffect; // 0x70
	private bool _infiniteShield; // 0x71
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _healLimitedByCasterMaxHPRatio; // 0x78

	// Properties
	public string shieldType { /* [XID] */ /* 0x0000000189696490-0x00000001896964B0 */ get => default; /* [XID] */ /* 0x000000018969DA30-0x000000018969DA50 */ private set {} } // 0x0000000183197320-0x00000001831973C0 0x0000000183199060-0x0000000183199110
	public DynamicFloat shieldAngle { /* [XID] */ /* 0x00000001896A4AC0-0x00000001896A4AE0 */ get => default; /* [XID] */ /* 0x00000001896AC270-0x00000001896AC290 */ private set {} } // 0x00000001831989A0-0x0000000183198A40 0x0000000183199A70-0x0000000183199B20
	public DynamicFloat shieldHPRatio { /* [XID] */ /* 0x00000001896B3510-0x00000001896B3530 */ get => default; /* [XID] */ /* 0x00000001896BACB0-0x00000001896BACD0 */ private set {} } // 0x0000000183198BF0-0x0000000183198C90 0x00000001831980E0-0x0000000183198190
	public DynamicFloat shieldHP { /* [XID] */ /* 0x00000001896C1DC0-0x00000001896C1DE0 */ get => default; /* [XID] */ /* 0x00000001896C93D0-0x00000001896C93F0 */ private set {} } // 0x0000000183195E30-0x0000000183195ED0 0x0000000183198C90-0x0000000183198D40
	public string costShieldRatioName { /* [XID] */ /* 0x00000001896D0C60-0x00000001896D0C80 */ get => default; /* [XID] */ /* 0x00000001896D8250-0x00000001896D8270 */ private set {} } // 0x000000018319A870-0x000000018319A910 0x0000000183197070-0x0000000183197120
	public string showDamageText { /* [XID] */ /* 0x00000001896DFBA0-0x00000001896DFBC0 */ get => default; /* [XID] */ /* 0x00000001896E6F40-0x00000001896E6F60 */ private set {} } // 0x000000018319A7D0-0x000000018319A870 0x0000000183197270-0x0000000183197320
	public ConfigAbilityAction[] onShieldBroken { /* [XID] */ /* 0x00000001896EE4B0-0x00000001896EE4D0 */ get => default; /* [XID] */ /* 0x00000001896F5DA0-0x00000001896F5DC0 */ private set {} } // 0x000000018319A910-0x000000018319A9B0 0x00000001831988F0-0x00000001831989A0
	public DynamicFloat amountByGetDamage { /* [XID] */ /* 0x00000001896FD5B0-0x00000001896FD5D0 */ get => default; /* [XID] */ /* 0x00000001897049F0-0x0000000189704A10 */ private set {} } // 0x00000001831999D0-0x0000000183199A70 0x00000001831996D0-0x0000000183199780
	public bool targetMuteHitEffect { /* [XID] */ /* 0x000000018970C170-0x000000018970C190 */ get => default; /* [XID] */ /* 0x0000000189713BA0-0x0000000189713BC0 */ private set {} } // 0x00000001831995D0-0x0000000183199670 0x0000000183198AD0-0x0000000183198B80
	public bool infiniteShield { /* [XID] */ /* 0x000000018971B400-0x000000018971B420 */ get => default; /* [XID] */ /* 0x0000000189722660-0x0000000189722680 */ private set {} } // 0x0000000183197470-0x0000000183197510 0x0000000183198230-0x00000001831982E0
	public DynamicFloat healLimitedByCasterMaxHPRatio { /* [XID] */ /* 0x0000000189729DC0-0x0000000189729DE0 */ get => default; /* [XID] */ /* 0x00000001897314E0-0x0000000189731500 */ private set {} } // 0x0000000183197570-0x0000000183197610 0x00000001831973C0-0x0000000183197470
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001897B5B10-0x00000001897B5B30 */ get => default; } // 0x0000000183198190-0x0000000183198230 

	// Constructors
	public EliteShieldMixin() {} // 0x000000018319AA50-0x000000018319AB00

	// Methods
	// [XID] // 0x0000000189738D30-0x0000000189738D50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018319A560-0x000000018319A7D0
	// [XID] // 0x0000000189740B20-0x0000000189740B40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183199B80-0x0000000183199D40
	// [XID] // 0x0000000189747F40-0x0000000189747F60
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5DA5 */) => default; // 0x00000001831994F0-0x00000001831995D0
	// [XID] // 0x000000018974F670-0x000000018974F690
	public override int GetHashNum() => default; // 0x00000001831971A0-0x0000000183197270
	// [XID] // 0x0000000189756CC0-0x0000000189756CE0
	public override void InitEmpty() {} // 0x0000000183198D40-0x0000000183198E90
	[BlackList] // 0x000000018975E190-0x000000018975E1D0
	// [XID] // 0x000000018975E190-0x000000018975E1D0
	public override bool FromJson(JSONNode node) => default; // 0x00000001831982E0-0x0000000183198660
	// [XID] // 0x0000000189768880-0x00000001897688A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183195ED0-0x0000000183196950
	[BlackList] // 0x000000018976FF10-0x000000018976FF50
	// [XID] // 0x000000018976FF10-0x000000018976FF50
	public static new EliteShieldMixin ParseFromJson(JSONNode node) => default; // 0x0000000183199780-0x00000001831999D0
	// [XID] // 0x000000018977A600-0x000000018977A620
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DA6 */, bool useObjectPool = false /* Metadata: 0x00AF5DAA */) => default; // 0x0000000183199110-0x0000000183199410
	// [XID] // 0x00000001897821E0-0x0000000189782200
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DAB */, bool useObjectPool = false /* Metadata: 0x00AF5DAF */) => default; // 0x0000000183197690-0x0000000183197FE0
	// [XID] // 0x0000000189789580-0x00000001897895A0
	public static new EliteShieldMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DB0 */, bool useObjectPool = false /* Metadata: 0x00AF5DB4 */) => default; // 0x00000001831986D0-0x00000001831988F0
	[BlackList] // 0x0000000189790C30-0x0000000189790C70
	// [XID] // 0x0000000189790C30-0x0000000189790C70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183196950-0x0000000183196C20
	// [XID] // 0x000000018979BDD0-0x000000018979BDF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183199D40-0x000000018319A560
	[BlackList] // 0x00000001897A3240-0x00000001897A3280
	// [XID] // 0x00000001897A3240-0x00000001897A3280
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183198F70-0x0000000183199060
	// [XID] // 0x00000001897AD9F0-0x00000001897ADA10
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183199410-0x00000001831994F0
	[BlackList] // 0x00000001897BD880-0x00000001897BD8C0
	// [XID] // 0x00000001897BD880-0x00000001897BD8C0
	public override void AutoAllocTypeFields() {} // 0x0000000183196C20-0x0000000183196CC0
	[BlackList] // 0x00000001897C8170-0x00000001897C81B0
	// [XID] // 0x00000001897C8170-0x00000001897C81B0
	public override void AutoRecycleTypeFields() {} // 0x0000000183196CC0-0x0000000183196FD0
	[BlackList] // 0x00000001897D24B0-0x00000001897D24F0
	// [XID] // 0x00000001897D24B0-0x00000001897D24F0
	public override void ReturnToObjectPool() {} // 0x000000018319A9B0-0x000000018319AA50
}

