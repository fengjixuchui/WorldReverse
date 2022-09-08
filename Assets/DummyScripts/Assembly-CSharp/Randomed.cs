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
public class Randomed : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16571
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _chance; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _successActions; // 0x70
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _failActions; // 0x78

	// Properties
	public DynamicFloat chance { /* [XID] */ /* 0x0000000189A1EE90-0x0000000189A1EEB0 */ get => default; /* [XID] */ /* 0x0000000189A264E0-0x0000000189A26500 */ private set {} } // 0x0000000184686A00-0x0000000184686AA0 0x0000000184685580-0x0000000184685630
	public ConfigAbilityAction[] successActions { /* [XID] */ /* 0x0000000189A2D7D0-0x0000000189A2D7F0 */ get => default; /* [XID] */ /* 0x0000000189A353D0-0x0000000189A353F0 */ private set {} } // 0x0000000184686960-0x0000000184686A00 0x00000001846866A0-0x0000000184686750
	public ConfigAbilityAction[] failActions { /* [XID] */ /* 0x0000000189A3C8E0-0x0000000189A3C900 */ get => default; /* [XID] */ /* 0x0000000189A44350-0x0000000189A44370 */ private set {} } // 0x00000001846854E0-0x0000000184685580 0x00000001846870F0-0x00000001846871A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189ACFD70-0x0000000189ACFD90 */ get => default; } // 0x0000000184686750-0x00000001846867F0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189AD7BC0-0x0000000189AD7BE0 */ get => default; } // 0x0000000184685CB0-0x0000000184685D50 

	// Constructors
	public Randomed() {} // 0x0000000184687240-0x00000001846872D0

	// Methods
	// [XID] // 0x0000000189A4B920-0x0000000189A4B940
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184686F10-0x0000000184687050
	// [XID] // 0x0000000189A52FE0-0x0000000189A53000
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184686850-0x0000000184686960
	// [XID] // 0x0000000189A5A7F0-0x0000000189A5A810
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3F8A */) => default; // 0x0000000184686310-0x00000001846863F0
	// [XID] // 0x0000000189A61F90-0x0000000189A61FB0
	public override int GetHashNum() => default; // 0x0000000184684CB0-0x0000000184684D80
	// [XID] // 0x0000000189A69E50-0x0000000189A69E70
	public override void InitEmpty() {} // 0x0000000184685D50-0x0000000184685E40
	[BlackList] // 0x0000000189A710A0-0x0000000189A710E0
	// [XID] // 0x0000000189A710A0-0x0000000189A710E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184685630-0x00000001846859B0
	// [XID] // 0x0000000189A7BC00-0x0000000189A7BC20
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184684290-0x0000000184684660
	[BlackList] // 0x0000000189A83520-0x0000000189A83560
	// [XID] // 0x0000000189A83520-0x0000000189A83560
	public static new Randomed ParseFromJson(JSONNode node) => default; // 0x0000000184686450-0x00000001846866A0
	// [XID] // 0x0000000189A8DED0-0x0000000189A8DEF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F8B */, bool useObjectPool = false /* Metadata: 0x00AF3F8F */) => default; // 0x0000000184686010-0x0000000184686310
	// [XID] // 0x0000000189A95450-0x0000000189A95470
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F90 */, bool useObjectPool = false /* Metadata: 0x00AF3F94 */) => default; // 0x0000000184684ED0-0x0000000184685280
	// [XID] // 0x0000000189A9CC90-0x0000000189A9CCB0
	public static new Randomed ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F95 */, bool useObjectPool = false /* Metadata: 0x00AF3F99 */) => default; // 0x00000001846859B0-0x0000000184685BD0
	[BlackList] // 0x0000000189AA4480-0x0000000189AA44C0
	// [XID] // 0x0000000189AA4480-0x0000000189AA44C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184684660-0x0000000184684930
	// [XID] // 0x0000000189AAEA20-0x0000000189AAEA40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184686B80-0x0000000184686F10
	[BlackList] // 0x0000000189AB6320-0x0000000189AB6360
	// [XID] // 0x0000000189AB6320-0x0000000189AB6360
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184685F20-0x0000000184686010
	// [XID] // 0x0000000189AC0C10-0x0000000189AC0C30
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184687050-0x00000001846870F0
	// [XID] // 0x0000000189AC8690-0x0000000189AC86B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184685280-0x00000001846853E0
	[BlackList] // 0x0000000189ADF630-0x0000000189ADF670
	// [XID] // 0x0000000189ADF630-0x0000000189ADF670
	public override void AutoAllocTypeFields() {} // 0x0000000184684930-0x00000001846849D0
	[BlackList] // 0x0000000189AE9BB0-0x0000000189AE9BF0
	// [XID] // 0x0000000189AE9BB0-0x0000000189AE9BF0
	public override void AutoRecycleTypeFields() {} // 0x00000001846849D0-0x0000000184684B20
	[BlackList] // 0x0000000189AF45F0-0x0000000189AF4630
	// [XID] // 0x0000000189AF45F0-0x0000000189AF4630
	public override void ReturnToObjectPool() {} // 0x00000001846871A0-0x0000000184687240
}

