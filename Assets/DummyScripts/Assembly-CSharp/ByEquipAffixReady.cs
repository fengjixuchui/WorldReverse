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
public class ByEquipAffixReady : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17346
{
	// Fields
	private SimpleSafeUInt32 equipAffixDataIDRawNum; // 0x18

	// Properties
	public uint equipAffixDataID { /* [XID] */ /* 0x0000000189B64150-0x0000000189B64170 */ get => default; /* [XID] */ /* 0x0000000189B6B890-0x0000000189B6B8B0 */ private set {} } // 0x000000018420C870-0x000000018420C940 0x000000018420C720-0x000000018420C800

	// Constructors
	public ByEquipAffixReady() {} // 0x000000018420D7F0-0x000000018420D850

	// Methods
	// [XID] // 0x0000000189B72F70-0x0000000189B72F90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018420D660-0x000000018420D750
	// [XID] // 0x0000000189B7A570-0x0000000189B7A590
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018420D2D0-0x000000018420D380
	// [XID] // 0x0000000189B81CF0-0x0000000189B81D10
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6B2F */) => default; // 0x000000018420CEE0-0x000000018420CFC0
	// [XID] // 0x0000000189B893F0-0x0000000189B89410
	public override int GetHashNum() => default; // 0x000000018420BB30-0x000000018420BC00
	// [XID] // 0x0000000189B909B0-0x0000000189B909D0
	public override void InitEmpty() {} // 0x000000018420C940-0x000000018420CA10
	[BlackList] // 0x0000000189B97DC0-0x0000000189B97E00
	// [XID] // 0x0000000189B97DC0-0x0000000189B97E00
	public override bool FromJson(JSONNode node) => default; // 0x000000018420C180-0x000000018420C500
	// [XID] // 0x0000000189BA2470-0x0000000189BA2490
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018420B360-0x000000018420B5C0
	[BlackList] // 0x0000000189BA9920-0x0000000189BA9960
	// [XID] // 0x0000000189BA9920-0x0000000189BA9960
	public static new ByEquipAffixReady ParseFromJson(JSONNode node) => default; // 0x000000018420D020-0x000000018420D270
	// [XID] // 0x0000000189BB3E10-0x0000000189BB3E30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B30 */, bool useObjectPool = false /* Metadata: 0x00AF6B34 */) => default; // 0x000000018420CBE0-0x000000018420CEE0
	// [XID] // 0x0000000189BBB3D0-0x0000000189BBB3F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B35 */, bool useObjectPool = false /* Metadata: 0x00AF6B39 */) => default; // 0x000000018420BCE0-0x000000018420BF50
	// [XID] // 0x0000000189BC31F0-0x0000000189BC3210
	public static new ByEquipAffixReady ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B3A */, bool useObjectPool = false /* Metadata: 0x00AF6B3E */) => default; // 0x000000018420C500-0x000000018420C720
	[BlackList] // 0x0000000189BCAA30-0x0000000189BCAA70
	// [XID] // 0x0000000189BCAA30-0x0000000189BCAA70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018420B5C0-0x000000018420B890
	// [XID] // 0x0000000189BD4E70-0x0000000189BD4E90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018420D430-0x000000018420D660
	[BlackList] // 0x0000000189BDCA00-0x0000000189BDCA40
	// [XID] // 0x0000000189BDCA00-0x0000000189BDCA40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018420CAF0-0x000000018420CBE0
	// [XID] // 0x00000001895EC510-0x00000001895EC530
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x000000018420BF50-0x000000018420C080
	[BlackList] // 0x00000001895F3990-0x00000001895F39D0
	// [XID] // 0x00000001895F3990-0x00000001895F39D0
	public override void AutoAllocTypeFields() {} // 0x000000018420B890-0x000000018420B930
	[BlackList] // 0x00000001895FE120-0x00000001895FE160
	// [XID] // 0x00000001895FE120-0x00000001895FE160
	public override void AutoRecycleTypeFields() {} // 0x000000018420B930-0x000000018420BA10
	[BlackList] // 0x0000000189608C70-0x0000000189608CB0
	// [XID] // 0x0000000189608C70-0x0000000189608CB0
	public override void ReturnToObjectPool() {} // 0x000000018420D750-0x000000018420D7F0
}

