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
public class MonsterReadyMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17078
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onMonsterReady; // 0x30

	// Properties
	public ConfigAbilityAction[] onMonsterReady { /* [XID] */ /* 0x0000000189B0AC60-0x0000000189B0AC80 */ get => default; /* [XID] */ /* 0x0000000189B12380-0x0000000189B123A0 */ private set {} } // 0x0000000184737600-0x00000001847376A0 0x0000000184738CE0-0x0000000184738D90
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B94E30-0x0000000189B94E50 */ get => default; } // 0x00000001847377A0-0x0000000184737840 

	// Constructors
	public MonsterReadyMixin() {} // 0x0000000184738F20-0x0000000184738F80

	// Methods
	// [XID] // 0x0000000189B19690-0x0000000189B196B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184738D90-0x0000000184738E80
	// [XID] // 0x0000000189B20D30-0x0000000189B20D50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847389C0-0x0000000184738AA0
	// [XID] // 0x0000000189B28430-0x0000000189B28450
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6263 */) => default; // 0x00000001847385D0-0x00000001847386B0
	// [XID] // 0x0000000189B2F710-0x0000000189B2F730
	public override int GetHashNum() => default; // 0x00000001847371E0-0x00000001847372B0
	// [XID] // 0x0000000189B36FB0-0x0000000189B36FD0
	public override void InitEmpty() {} // 0x0000000184737F50-0x0000000184738020
	[BlackList] // 0x0000000189B3E8C0-0x0000000189B3E900
	// [XID] // 0x0000000189B3E8C0-0x0000000189B3E900
	public override bool FromJson(JSONNode node) => default; // 0x0000000184737840-0x0000000184737BC0
	// [XID] // 0x0000000189B49560-0x0000000189B49580
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184736A70-0x0000000184736CA0
	[BlackList] // 0x0000000189B50B80-0x0000000189B50BC0
	// [XID] // 0x0000000189B50B80-0x0000000189B50BC0
	public static new MonsterReadyMixin ParseFromJson(JSONNode node) => default; // 0x0000000184738710-0x0000000184738960
	// [XID] // 0x0000000189B5B2B0-0x0000000189B5B2D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6264 */, bool useObjectPool = false /* Metadata: 0x00AF6268 */) => default; // 0x00000001847381F0-0x00000001847384F0
	// [XID] // 0x0000000189B62720-0x0000000189B62740
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6269 */, bool useObjectPool = false /* Metadata: 0x00AF626D */) => default; // 0x0000000184737390-0x0000000184737600
	// [XID] // 0x0000000189B6A2D0-0x0000000189B6A2F0
	public static new MonsterReadyMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF626E */, bool useObjectPool = false /* Metadata: 0x00AF6272 */) => default; // 0x0000000184737C30-0x0000000184737E50
	[BlackList] // 0x0000000189B71A10-0x0000000189B71A50
	// [XID] // 0x0000000189B71A10-0x0000000189B71A50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184736CA0-0x0000000184736F70
	// [XID] // 0x0000000189B7BD70-0x0000000189B7BD90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184738AA0-0x0000000184738CE0
	[BlackList] // 0x0000000189B83600-0x0000000189B83640
	// [XID] // 0x0000000189B83600-0x0000000189B83640
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184738100-0x00000001847381F0
	// [XID] // 0x0000000189B8D850-0x0000000189B8D870
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001847384F0-0x00000001847385D0
	[BlackList] // 0x0000000189B9C5A0-0x0000000189B9C5E0
	// [XID] // 0x0000000189B9C5A0-0x0000000189B9C5E0
	public override void AutoAllocTypeFields() {} // 0x0000000184736F70-0x0000000184737010
	[BlackList] // 0x0000000189BA6AC0-0x0000000189BA6B00
	// [XID] // 0x0000000189BA6AC0-0x0000000189BA6B00
	public override void AutoRecycleTypeFields() {} // 0x0000000184737010-0x00000001847370C0
	[BlackList] // 0x0000000189BB11F0-0x0000000189BB1230
	// [XID] // 0x0000000189BB11F0-0x0000000189BB1230
	public override void ReturnToObjectPool() {} // 0x0000000184738E80-0x0000000184738F20
}

