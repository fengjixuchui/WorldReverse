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
public class ByLocalAvatarStamina : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17182
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _stamina; // 0x20

	// Properties
	public DynamicFloat stamina { /* [XID] */ /* 0x0000000189908910-0x0000000189908930 */ get => default; /* [XID] */ /* 0x000000018990FED0-0x000000018990FEF0 */ private set {} } // 0x0000000181B174D0-0x0000000181B17570 0x0000000181B176B0-0x0000000181B17760

	// Constructors
	public ByLocalAvatarStamina() {} // 0x0000000181B17BC0-0x0000000181B17C50

	// Methods
	// [XID] // 0x0000000189917AC0-0x0000000189917AE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181B17A40-0x0000000181B17B20
	// [XID] // 0x000000018991EFC0-0x000000018991EFE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181B175D0-0x0000000181B176B0
	// [XID] // 0x0000000189926A40-0x0000000189926A60
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF65D7 */) => default; // 0x0000000181B17140-0x0000000181B17220
	// [XID] // 0x000000018992E050-0x000000018992E070
	public override int GetHashNum() => default; // 0x0000000181B15F70-0x0000000181B16040
	// [XID] // 0x0000000189935370-0x0000000189935390
	public override void InitEmpty() {} // 0x0000000181B16BD0-0x0000000181B16C70
	[BlackList] // 0x000000018993CF10-0x000000018993CF50
	// [XID] // 0x000000018993CF10-0x000000018993CF50
	public override bool FromJson(JSONNode node) => default; // 0x0000000181B165C0-0x0000000181B16940
	// [XID] // 0x0000000189947400-0x0000000189947420
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181B157A0-0x0000000181B159B0
	[BlackList] // 0x000000018994EB40-0x000000018994EB80
	// [XID] // 0x000000018994EB40-0x000000018994EB80
	public static new ByLocalAvatarStamina ParseFromJson(JSONNode node) => default; // 0x0000000181B17280-0x0000000181B174D0
	// [XID] // 0x00000001899592B0-0x00000001899592D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65D8 */, bool useObjectPool = false /* Metadata: 0x00AF65DC */) => default; // 0x0000000181B16E40-0x0000000181B17140
	// [XID] // 0x0000000189960B00-0x0000000189960B20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65DD */, bool useObjectPool = false /* Metadata: 0x00AF65E1 */) => default; // 0x0000000181B16120-0x0000000181B16390
	// [XID] // 0x0000000189968280-0x00000001899682A0
	public static new ByLocalAvatarStamina ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65E2 */, bool useObjectPool = false /* Metadata: 0x00AF65E6 */) => default; // 0x0000000181B16940-0x0000000181B16B60
	[BlackList] // 0x000000018996F6C0-0x000000018996F700
	// [XID] // 0x000000018996F6C0-0x000000018996F700
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181B159B0-0x0000000181B15C80
	// [XID] // 0x000000018997A510-0x000000018997A530
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181B17810-0x0000000181B17A40
	[BlackList] // 0x0000000189981D60-0x0000000189981DA0
	// [XID] // 0x0000000189981D60-0x0000000189981DA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181B16D50-0x0000000181B16E40
	// [XID] // 0x000000018998C450-0x000000018998C470
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000181B16390-0x0000000181B164C0
	[BlackList] // 0x0000000189994170-0x00000001899941B0
	// [XID] // 0x0000000189994170-0x00000001899941B0
	public override void AutoAllocTypeFields() {} // 0x0000000181B15C80-0x0000000181B15D20
	[BlackList] // 0x000000018999EAF0-0x000000018999EB30
	// [XID] // 0x000000018999EAF0-0x000000018999EB30
	public override void AutoRecycleTypeFields() {} // 0x0000000181B15D20-0x0000000181B15E50
	[BlackList] // 0x00000001899A9340-0x00000001899A9380
	// [XID] // 0x00000001899A9340-0x00000001899A9380
	public override void ReturnToObjectPool() {} // 0x0000000181B17B20-0x0000000181B17BC0
}

