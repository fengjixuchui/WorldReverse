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
public class ByHitElement : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17240
{
	// Fields
	private ElementType _element; // 0x18

	// Properties
	public ElementType element { /* [XID] */ /* 0x0000000189AE21E0-0x0000000189AE2200 */ get => default; /* [XID] */ /* 0x0000000189AE9AF0-0x0000000189AE9B10 */ private set {} } // 0x0000000182010BD0-0x0000000182010C70 0x0000000182011730-0x00000001820117E0

	// Constructors
	public ByHitElement() {} // 0x0000000182011B70-0x0000000182011BD0

	// Methods
	// [XID] // 0x0000000189AF1830-0x0000000189AF1850
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820119E0-0x0000000182011AD0
	// [XID] // 0x0000000189AF8F50-0x0000000189AF8F70
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001820115D0-0x0000000182011680
	// [XID] // 0x0000000189B004F0-0x0000000189B00510
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF67B7 */) => default; // 0x00000001820111E0-0x00000001820112C0
	// [XID] // 0x0000000189B079D0-0x0000000189B079F0
	public override int GetHashNum() => default; // 0x000000018200FFB0-0x0000000182010080
	// [XID] // 0x0000000189B0F290-0x0000000189B0F2B0
	public override void InitEmpty() {} // 0x0000000182010C70-0x0000000182010D10
	[BlackList] // 0x0000000189B165D0-0x0000000189B16610
	// [XID] // 0x0000000189B165D0-0x0000000189B16610
	public override bool FromJson(JSONNode node) => default; // 0x00000001820105C0-0x0000000182010940
	// [XID] // 0x0000000189B20D10-0x0000000189B20D30
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018200F850-0x000000018200FA70
	[BlackList] // 0x0000000189B283F0-0x0000000189B28430
	// [XID] // 0x0000000189B283F0-0x0000000189B28430
	public static new ByHitElement ParseFromJson(JSONNode node) => default; // 0x0000000182011320-0x0000000182011570
	// [XID] // 0x0000000189B32920-0x0000000189B32940
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67B8 */, bool useObjectPool = false /* Metadata: 0x00AF67BC */) => default; // 0x0000000182010EE0-0x00000001820111E0
	// [XID] // 0x0000000189B3A210-0x0000000189B3A230
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67BD */, bool useObjectPool = false /* Metadata: 0x00AF67C1 */) => default; // 0x0000000182010160-0x0000000182010390
	// [XID] // 0x0000000189B41B70-0x0000000189B41B90
	public static new ByHitElement ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67C2 */, bool useObjectPool = false /* Metadata: 0x00AF67C6 */) => default; // 0x0000000182010940-0x0000000182010B60
	[BlackList] // 0x0000000189B49500-0x0000000189B49540
	// [XID] // 0x0000000189B49500-0x0000000189B49540
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018200FA70-0x000000018200FD40
	// [XID] // 0x0000000189B539A0-0x0000000189B539C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820117E0-0x00000001820119E0
	[BlackList] // 0x0000000189B5B230-0x0000000189B5B270
	// [XID] // 0x0000000189B5B230-0x0000000189B5B270
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182010DF0-0x0000000182010EE0
	// [XID] // 0x0000000189B65A00-0x0000000189B65A20
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182010390-0x00000001820104C0
	[BlackList] // 0x0000000189B6CF60-0x0000000189B6CFA0
	// [XID] // 0x0000000189B6CF60-0x0000000189B6CFA0
	public override void AutoAllocTypeFields() {} // 0x000000018200FD40-0x000000018200FDE0
	[BlackList] // 0x0000000189B77410-0x0000000189B77450
	// [XID] // 0x0000000189B77410-0x0000000189B77450
	public override void AutoRecycleTypeFields() {} // 0x000000018200FDE0-0x000000018200FE90
	[BlackList] // 0x0000000189B81D30-0x0000000189B81D70
	// [XID] // 0x0000000189B81D30-0x0000000189B81D70
	public override void ReturnToObjectPool() {} // 0x0000000182011AD0-0x0000000182011B70
}

