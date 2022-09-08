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
public class Predicated : BaseUtilityAction, IAutoAllocRecycle // TypeDefIndex: 16440
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _targetPredicates; // 0x68
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _successActions; // 0x70
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _failActions; // 0x78

	// Properties
	public ConfigAbilityPredicate[] targetPredicates { /* [XID] */ /* 0x00000001897DE590-0x00000001897DE5B0 */ get => default; /* [XID] */ /* 0x00000001897E60B0-0x00000001897E60D0 */ private set {} } // 0x0000000184A0C960-0x0000000184A0CA00 0x0000000184A0A8B0-0x0000000184A0A960
	public ConfigAbilityAction[] successActions { /* [XID] */ /* 0x00000001897EDA50-0x00000001897EDA70 */ get => default; /* [XID] */ /* 0x00000001897F5190-0x00000001897F51B0 */ private set {} } // 0x0000000184A0C440-0x0000000184A0C4E0 0x0000000184A0C180-0x0000000184A0C230
	public ConfigAbilityAction[] failActions { /* [XID] */ /* 0x00000001897FCBE0-0x00000001897FCC00 */ get => default; /* [XID] */ /* 0x0000000189804190-0x00000001898041B0 */ private set {} } // 0x0000000184A0B050-0x0000000184A0B0F0 0x0000000184A0CBD0-0x0000000184A0CC80
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018988D5C0-0x000000018988D5E0 */ get => default; } // 0x0000000184A0C230-0x0000000184A0C2D0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189894D50-0x0000000189894D70 */ get => default; } // 0x0000000184A0B770-0x0000000184A0B810 

	// Constructors
	public Predicated() {} // 0x0000000184A0CD20-0x0000000184A0CD80

	// Methods
	// [XID] // 0x000000018980B5C0-0x000000018980B5E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A0CA00-0x0000000184A0CB30
	// [XID] // 0x0000000189812C80-0x0000000189812CA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A0C330-0x0000000184A0C440
	// [XID] // 0x000000018981A860-0x000000018981A880
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3B7A */) => default; // 0x0000000184A0BDF0-0x0000000184A0BED0
	// [XID] // 0x00000001898220B0-0x00000001898220D0
	public override int GetHashNum() => default; // 0x0000000184A0A770-0x0000000184A0A840
	// [XID] // 0x0000000189829610-0x0000000189829630
	public override void InitEmpty() {} // 0x0000000184A0B810-0x0000000184A0B910
	[BlackList] // 0x0000000189830C00-0x0000000189830C40
	// [XID] // 0x0000000189830C00-0x0000000189830C40
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A0B0F0-0x0000000184A0B470
	// [XID] // 0x000000018983B1E0-0x000000018983B200
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A09DB0-0x0000000184A0A1A0
	[BlackList] // 0x0000000189842A60-0x0000000189842AA0
	// [XID] // 0x0000000189842A60-0x0000000189842AA0
	public static new Predicated ParseFromJson(JSONNode node) => default; // 0x0000000184A0BF30-0x0000000184A0C180
	// [XID] // 0x000000018984CD40-0x000000018984CD60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B7B */, bool useObjectPool = false /* Metadata: 0x00AF3B7F */) => default; // 0x0000000184A0BAF0-0x0000000184A0BDF0
	// [XID] // 0x0000000189853E40-0x0000000189853E60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B80 */, bool useObjectPool = false /* Metadata: 0x00AF3B84 */) => default; // 0x0000000184A0AA40-0x0000000184A0ADF0
	// [XID] // 0x000000018985B910-0x000000018985B930
	public static new Predicated ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B85 */, bool useObjectPool = false /* Metadata: 0x00AF3B89 */) => default; // 0x0000000184A0B470-0x0000000184A0B690
	[BlackList] // 0x0000000189862E50-0x0000000189862E90
	// [XID] // 0x0000000189862E50-0x0000000189862E90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A0A1A0-0x0000000184A0A470
	// [XID] // 0x000000018986CFF0-0x000000018986D010
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A0C5C0-0x0000000184A0C960
	[BlackList] // 0x0000000189874420-0x0000000189874460
	// [XID] // 0x0000000189874420-0x0000000189874460
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A0B9F0-0x0000000184A0BAF0
	// [XID] // 0x000000018987EEA0-0x000000018987EEC0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184A0CB30-0x0000000184A0CBD0
	// [XID] // 0x00000001898864A0-0x00000001898864C0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184A0ADF0-0x0000000184A0AF50
	[BlackList] // 0x000000018989C340-0x000000018989C380
	// [XID] // 0x000000018989C340-0x000000018989C380
	public override void AutoAllocTypeFields() {} // 0x0000000184A0A470-0x0000000184A0A510
	[BlackList] // 0x00000001898A6A80-0x00000001898A6AC0
	// [XID] // 0x00000001898A6A80-0x00000001898A6AC0
	public override void AutoRecycleTypeFields() {} // 0x0000000184A0A510-0x0000000184A0A5E0
	[BlackList] // 0x00000001898B1100-0x00000001898B1140
	// [XID] // 0x00000001898B1100-0x00000001898B1140
	public override void ReturnToObjectPool() {} // 0x0000000184A0CC80-0x0000000184A0CD20
}

