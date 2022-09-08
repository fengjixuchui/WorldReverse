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
public class ByAvatarInWaterDepth : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17234
{
	// Fields
	private RelationType _compareType; // 0x18
	private SimpleSafeFloat depthRawNum; // 0x1C

	// Properties
	public RelationType compareType { /* [XID] */ /* 0x000000018988EC80-0x000000018988ECA0 */ get => default; /* [XID] */ /* 0x00000001898961A0-0x00000001898961C0 */ private set {} } // 0x0000000181D74E90-0x0000000181D74F30 0x0000000181D73A80-0x0000000181D73B30
	public float depth { /* [XID] */ /* 0x000000018989D7C0-0x000000018989D7E0 */ get => default; /* [XID] */ /* 0x00000001898A51A0-0x00000001898A51C0 */ private set {} } // 0x0000000181D73EF0-0x0000000181D73FD0 0x0000000181D74810-0x0000000181D748F0

	// Constructors
	public ByAvatarInWaterDepth() {} // 0x0000000181D758C0-0x0000000181D75920

	// Methods
	// [XID] // 0x00000001898AC680-0x00000001898AC6A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181D75710-0x0000000181D75820
	// [XID] // 0x00000001898B3BE0-0x00000001898B3C00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181D75320-0x0000000181D753D0
	// [XID] // 0x00000001898BB970-0x00000001898BB990
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6787 */) => default; // 0x0000000181D74F30-0x0000000181D75010
	// [XID] // 0x00000001898C2CC0-0x00000001898C2CE0
	public override int GetHashNum() => default; // 0x0000000181D739B0-0x0000000181D73A80
	// [XID] // 0x00000001898CA680-0x00000001898CA6A0
	public override void InitEmpty() {} // 0x0000000181D748F0-0x0000000181D749C0
	[BlackList] // 0x00000001898D1E10-0x00000001898D1E50
	// [XID] // 0x00000001898D1E10-0x00000001898D1E50
	public override bool FromJson(JSONNode node) => default; // 0x0000000181D74200-0x0000000181D74580
	// [XID] // 0x00000001898DC870-0x00000001898DC890
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181D730E0-0x0000000181D73440
	[BlackList] // 0x00000001898E4280-0x00000001898E42C0
	// [XID] // 0x00000001898E4280-0x00000001898E42C0
	public static new ByAvatarInWaterDepth ParseFromJson(JSONNode node) => default; // 0x0000000181D75070-0x0000000181D752C0
	// [XID] // 0x00000001898EEE20-0x00000001898EEE40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6788 */, bool useObjectPool = false /* Metadata: 0x00AF678C */) => default; // 0x0000000181D74B90-0x0000000181D74E90
	// [XID] // 0x00000001898F6780-0x00000001898F67A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF678D */, bool useObjectPool = false /* Metadata: 0x00AF6791 */) => default; // 0x0000000181D73C10-0x0000000181D73EF0
	// [XID] // 0x00000001898FDEC0-0x00000001898FDEE0
	public static new ByAvatarInWaterDepth ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6792 */, bool useObjectPool = false /* Metadata: 0x00AF6796 */) => default; // 0x0000000181D74580-0x0000000181D747A0
	[BlackList] // 0x0000000189905620-0x0000000189905660
	// [XID] // 0x0000000189905620-0x0000000189905660
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181D73440-0x0000000181D73710
	// [XID] // 0x000000018990FE90-0x000000018990FEB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181D75480-0x0000000181D75710
	[BlackList] // 0x0000000189917A60-0x0000000189917AA0
	// [XID] // 0x0000000189917A60-0x0000000189917AA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181D74AA0-0x0000000181D74B90
	// [XID] // 0x0000000189922240-0x0000000189922260
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000181D73FD0-0x0000000181D74100
	[BlackList] // 0x0000000189929A00-0x0000000189929A40
	// [XID] // 0x0000000189929A00-0x0000000189929A40
	public override void AutoAllocTypeFields() {} // 0x0000000181D73710-0x0000000181D737B0
	[BlackList] // 0x0000000189933D80-0x0000000189933DC0
	// [XID] // 0x0000000189933D80-0x0000000189933DC0
	public override void AutoRecycleTypeFields() {} // 0x0000000181D737B0-0x0000000181D73890
	[BlackList] // 0x000000018993E690-0x000000018993E6D0
	// [XID] // 0x000000018993E690-0x000000018993E6D0
	public override void ReturnToObjectPool() {} // 0x0000000181D75820-0x0000000181D758C0
}

