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
public class ChangeFollowDampTime : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16577
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicString _effectPattern; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _PositionDampTime; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _RotationDampTime; // 0x78

	// Properties
	public DynamicString effectPattern { /* [XID] */ /* 0x00000001896F4620-0x00000001896F4640 */ get => default; /* [XID] */ /* 0x00000001896FBE90-0x00000001896FBEB0 */ private set {} } // 0x0000000182641DA0-0x0000000182641E40 0x0000000182642FB0-0x0000000182643060
	public DynamicFloat PositionDampTime { /* [XID] */ /* 0x0000000189703350-0x0000000189703370 */ get => default; /* [XID] */ /* 0x000000018970AA60-0x000000018970AA80 */ private set {} } // 0x00000001826429B0-0x0000000182642A50 0x0000000182641A60-0x0000000182641B10
	public DynamicFloat RotationDampTime { /* [XID] */ /* 0x00000001897124D0-0x00000001897124F0 */ get => default; /* [XID] */ /* 0x0000000189719C10-0x0000000189719C30 */ private set {} } // 0x0000000182641EA0-0x0000000182641F40 0x0000000182642DC0-0x0000000182642E70
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018979DA30-0x000000018979DA50 */ get => default; } // 0x00000001826426C0-0x0000000182642760 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897A4CF0-0x00000001897A4D10 */ get => default; } // 0x0000000182641B80-0x0000000182641C20 

	// Constructors
	public ChangeFollowDampTime() {} // 0x0000000182643100-0x0000000182643160

	// Methods
	// [XID] // 0x00000001897211F0-0x0000000189721210
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182642E70-0x0000000182642FB0
	// [XID] // 0x00000001897287B0-0x00000001897287D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001826427C0-0x00000001826428D0
	// [XID] // 0x000000018972FF60-0x000000018972FF80
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3FBA */) => default; // 0x0000000182642330-0x0000000182642410
	// [XID] // 0x0000000189737800-0x0000000189737820
	public override int GetHashNum() => default; // 0x0000000182640C00-0x0000000182640CD0
	// [XID] // 0x000000018973F340-0x000000018973F360
	public override void InitEmpty() {} // 0x0000000182641C20-0x0000000182641D20
	[BlackList] // 0x0000000189746660-0x00000001897466A0
	// [XID] // 0x0000000189746660-0x00000001897466A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001826414C0-0x0000000182641840
	// [XID] // 0x0000000189750D40-0x0000000189750D60
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001826400B0-0x00000001826404E0
	[BlackList] // 0x00000001897581B0-0x00000001897581F0
	// [XID] // 0x00000001897581B0-0x00000001897581F0
	public static new ChangeFollowDampTime ParseFromJson(JSONNode node) => default; // 0x0000000182642470-0x00000001826426C0
	// [XID] // 0x0000000189762BD0-0x0000000189762BF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FBB */, bool useObjectPool = false /* Metadata: 0x00AF3FBF */) => default; // 0x0000000182642030-0x0000000182642330
	// [XID] // 0x000000018976A210-0x000000018976A230
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FC0 */, bool useObjectPool = false /* Metadata: 0x00AF3FC4 */) => default; // 0x0000000182640E20-0x0000000182641260
	// [XID] // 0x0000000189771A50-0x0000000189771A70
	public static new ChangeFollowDampTime ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FC5 */, bool useObjectPool = false /* Metadata: 0x00AF3FC9 */) => default; // 0x0000000182641840-0x0000000182641A60
	[BlackList] // 0x0000000189779160-0x00000001897791A0
	// [XID] // 0x0000000189779160-0x00000001897791A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001826404E0-0x00000001826407B0
	// [XID] // 0x0000000189783990-0x00000001897839B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182642A50-0x0000000182642DC0
	[BlackList] // 0x000000018978B1E0-0x000000018978B220
	// [XID] // 0x000000018978B1E0-0x000000018978B220
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182641F40-0x0000000182642030
	// [XID] // 0x0000000189795580-0x00000001897955A0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182641260-0x00000001826413C0
	[BlackList] // 0x00000001897AC260-0x00000001897AC2A0
	// [XID] // 0x00000001897AC260-0x00000001897AC2A0
	public override void AutoAllocTypeFields() {} // 0x00000001826407B0-0x0000000182640850
	[BlackList] // 0x00000001897B7350-0x00000001897B7390
	// [XID] // 0x00000001897B7350-0x00000001897B7390
	public override void AutoRecycleTypeFields() {} // 0x0000000182640850-0x0000000182640A70
	[BlackList] // 0x00000001897C1E50-0x00000001897C1E90
	// [XID] // 0x00000001897C1E50-0x00000001897C1E90
	public override void ReturnToObjectPool() {} // 0x0000000182643060-0x0000000182643100
}

