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
public class ButtonHoldChargeMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16902
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x30
	private SimpleSafeFloat chargeTimeRawNum; // 0x34
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _secondChargeTime; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _OnBeginUncharged; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _OnReleaseUncharged; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _OnBeginCharged; // 0x50
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _OnReleaseCharged; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _OnBeginSecondCharged; // 0x60
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _OnReleaseSecondCharged; // 0x68
	private string[] _chargeStateIDs; // 0x70

	// Properties
	public uint skillID { /* [XID] */ /* 0x00000001899836D0-0x00000001899836F0 */ get => default; /* [XID] */ /* 0x000000018998AE60-0x000000018998AE80 */ private set {} } // 0x00000001839662C0-0x0000000183966390 0x0000000183967E90-0x0000000183967F70
	public float chargeTime { /* [XID] */ /* 0x0000000189992750-0x0000000189992770 */ get => default; /* [XID] */ /* 0x000000018999A530-0x000000018999A550 */ private set {} } // 0x00000001839672A0-0x0000000183967380 0x0000000183965F90-0x0000000183966070
	public DynamicFloat secondChargeTime { /* [XID] */ /* 0x00000001899A1BD0-0x00000001899A1BF0 */ get => default; /* [XID] */ /* 0x00000001899A93C0-0x00000001899A93E0 */ private set {} } // 0x0000000183967380-0x0000000183967420 0x0000000183966C80-0x0000000183966D30
	public ConfigAbilityAction[] OnBeginUncharged { /* [XID] */ /* 0x00000001899B0ED0-0x00000001899B0EF0 */ get => default; /* [XID] */ /* 0x00000001899B81B0-0x00000001899B81D0 */ private set {} } // 0x00000001839642B0-0x0000000183964350 0x0000000183964B50-0x0000000183964C00
	public ConfigAbilityAction[] OnReleaseUncharged { /* [XID] */ /* 0x00000001899BFCD0-0x00000001899BFCF0 */ get => default; /* [XID] */ /* 0x00000001899C7490-0x00000001899C74B0 */ private set {} } // 0x00000001839655F0-0x0000000183965690 0x0000000183965710-0x00000001839657C0
	public ConfigAbilityAction[] OnBeginCharged { /* [XID] */ /* 0x00000001899CEAE0-0x00000001899CEB00 */ get => default; /* [XID] */ /* 0x00000001899D6210-0x00000001899D6230 */ private set {} } // 0x0000000183967DF0-0x0000000183967E90 0x0000000183967D40-0x0000000183967DF0
	public ConfigAbilityAction[] OnReleaseCharged { /* [XID] */ /* 0x00000001899DD6C0-0x00000001899DD6E0 */ get => default; /* [XID] */ /* 0x00000001899E53C0-0x00000001899E53E0 */ private set {} } // 0x00000001839658E0-0x0000000183965980 0x0000000183966210-0x00000001839662C0
	public ConfigAbilityAction[] OnBeginSecondCharged { /* [XID] */ /* 0x00000001899EC6B0-0x00000001899EC6D0 */ get => default; /* [XID] */ /* 0x00000001899F4430-0x00000001899F4450 */ private set {} } // 0x0000000183964620-0x00000001839646C0 0x0000000183966D90-0x0000000183966E40
	public ConfigAbilityAction[] OnReleaseSecondCharged { /* [XID] */ /* 0x00000001899FB9B0-0x00000001899FB9D0 */ get => default; /* [XID] */ /* 0x0000000189A02DB0-0x0000000189A02DD0 */ private set {} } // 0x0000000183964CE0-0x0000000183964D80 0x0000000183967420-0x00000001839674D0
	public string[] chargeStateIDs { /* [XID] */ /* 0x0000000189A0A420-0x0000000189A0A440 */ get => default; /* [XID] */ /* 0x0000000189A11D20-0x0000000189A11D40 */ private set {} } // 0x0000000183966100-0x00000001839661A0 0x0000000183966390-0x0000000183966440
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A953F0-0x0000000189A95410 */ get => default; } // 0x0000000183965840-0x00000001839658E0 

	// Constructors
	public ButtonHoldChargeMixin() {} // 0x0000000183968210-0x00000001839682B0

	// Methods
	// [XID] // 0x0000000189A18FF0-0x0000000189A19010
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183967F70-0x0000000183968170
	// [XID] // 0x0000000189A20770-0x0000000189A20790
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001839670F0-0x00000001839672A0
	// [XID] // 0x0000000189A27B80-0x0000000189A27BA0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5D09 */) => default; // 0x0000000183966BA0-0x0000000183966C80
	// [XID] // 0x0000000189A2F1F0-0x0000000189A2F210
	public override int GetHashNum() => default; // 0x0000000183964A80-0x0000000183964B50
	// [XID] // 0x0000000189A36BB0-0x0000000189A36BD0
	public override void InitEmpty() {} // 0x0000000183966440-0x00000001839665F0
	[BlackList] // 0x0000000189A3E210-0x0000000189A3E250
	// [XID] // 0x0000000189A3E210-0x0000000189A3E250
	public override bool FromJson(JSONNode node) => default; // 0x0000000183965980-0x0000000183965D00
	// [XID] // 0x0000000189A488D0-0x0000000189A488F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183963840-0x00000001839642B0
	[BlackList] // 0x0000000189A4FFE0-0x0000000189A50020
	// [XID] // 0x0000000189A4FFE0-0x0000000189A50020
	public static new ButtonHoldChargeMixin ParseFromJson(JSONNode node) => default; // 0x0000000183966E40-0x0000000183967090
	// [XID] // 0x0000000189A5A790-0x0000000189A5A7B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D0A */, bool useObjectPool = false /* Metadata: 0x00AF5D0E */) => default; // 0x00000001839667C0-0x0000000183966AC0
	// [XID] // 0x0000000189A61F10-0x0000000189A61F30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D0F */, bool useObjectPool = false /* Metadata: 0x00AF5D13 */) => default; // 0x0000000183964D80-0x00000001839655F0
	// [XID] // 0x0000000189A69D50-0x0000000189A69D70
	public static new ButtonHoldChargeMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D14 */, bool useObjectPool = false /* Metadata: 0x00AF5D18 */) => default; // 0x0000000183965D70-0x0000000183965F90
	[BlackList] // 0x0000000189A71000-0x0000000189A71040
	// [XID] // 0x0000000189A71000-0x0000000189A71040
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183964350-0x0000000183964620
	// [XID] // 0x0000000189A7BB80-0x0000000189A7BBA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001839674D0-0x0000000183967D40
	[BlackList] // 0x0000000189A83420-0x0000000189A83460
	// [XID] // 0x0000000189A83420-0x0000000189A83460
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001839666D0-0x00000001839667C0
	// [XID] // 0x0000000189A8DE50-0x0000000189A8DE70
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183966AC0-0x0000000183966BA0
	[BlackList] // 0x0000000189A9CC10-0x0000000189A9CC50
	// [XID] // 0x0000000189A9CC10-0x0000000189A9CC50
	public override void AutoAllocTypeFields() {} // 0x00000001839646C0-0x0000000183964760
	[BlackList] // 0x0000000189AA72A0-0x0000000189AA72E0
	// [XID] // 0x0000000189AA72A0-0x0000000189AA72E0
	public override void AutoRecycleTypeFields() {} // 0x0000000183964760-0x0000000183964960
	[BlackList] // 0x0000000189AB1DA0-0x0000000189AB1DE0
	// [XID] // 0x0000000189AB1DA0-0x0000000189AB1DE0
	public override void ReturnToObjectPool() {} // 0x0000000183968170-0x0000000183968210
}

