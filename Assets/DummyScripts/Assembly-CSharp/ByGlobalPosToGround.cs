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
public class ByGlobalPosToGround : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17344
{
	// Fields
	private string _globalPos; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _toGroundHeight; // 0x28
	private bool _toWater; // 0x30

	// Properties
	public string globalPos { /* [XID] */ /* 0x0000000189A93970-0x0000000189A93990 */ get => default; /* [XID] */ /* 0x0000000189A9B560-0x0000000189A9B580 */ private set {} } // 0x0000000181C21000-0x0000000181C210A0 0x0000000181C20100-0x0000000181C201B0
	public DynamicFloat toGroundHeight { /* [XID] */ /* 0x0000000189AA2860-0x0000000189AA2880 */ get => default; /* [XID] */ /* 0x0000000189AA9EA0-0x0000000189AA9EC0 */ private set {} } // 0x0000000181C206F0-0x0000000181C20790 0x0000000181C21C70-0x0000000181C21D20
	public bool toWater { /* [XID] */ /* 0x0000000189AB1D00-0x0000000189AB1D20 */ get => default; /* [XID] */ /* 0x0000000189AB8FD0-0x0000000189AB8FF0 */ private set {} } // 0x0000000181C20F60-0x0000000181C21000 0x0000000181C201B0-0x0000000181C20260

	// Constructors
	public ByGlobalPosToGround() {} // 0x0000000181C22230-0x0000000181C22290

	// Methods
	// [XID] // 0x0000000189AC0B50-0x0000000189AC0B70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C22050-0x0000000181C22190
	// [XID] // 0x0000000189AC8570-0x0000000189AC8590
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181C21AC0-0x0000000181C21BC0
	// [XID] // 0x0000000189ACFC70-0x0000000189ACFC90
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6B1F */) => default; // 0x0000000181C216D0-0x0000000181C217B0
	// [XID] // 0x0000000189AD7A20-0x0000000189AD7A40
	public override int GetHashNum() => default; // 0x0000000181C20030-0x0000000181C20100
	// [XID] // 0x0000000189ADF4B0-0x0000000189ADF4D0
	public override void InitEmpty() {} // 0x0000000181C21110-0x0000000181C21200
	[BlackList] // 0x0000000189AE6CB0-0x0000000189AE6CF0
	// [XID] // 0x0000000189AE6CB0-0x0000000189AE6CF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181C209C0-0x0000000181C20D40
	// [XID] // 0x0000000189AF1790-0x0000000189AF17B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181C1F680-0x0000000181C1FA60
	[BlackList] // 0x0000000189AF8EB0-0x0000000189AF8EF0
	// [XID] // 0x0000000189AF8EB0-0x0000000189AF8EF0
	public static new ByGlobalPosToGround ParseFromJson(JSONNode node) => default; // 0x0000000181C21810-0x0000000181C21A60
	// [XID] // 0x0000000189B03390-0x0000000189B033B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B20 */, bool useObjectPool = false /* Metadata: 0x00AF6B24 */) => default; // 0x0000000181C213D0-0x0000000181C216D0
	// [XID] // 0x0000000189B0ABA0-0x0000000189B0ABC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B25 */, bool useObjectPool = false /* Metadata: 0x00AF6B29 */) => default; // 0x0000000181C20340-0x0000000181C206F0
	// [XID] // 0x0000000189B122A0-0x0000000189B122C0
	public static new ByGlobalPosToGround ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B2A */, bool useObjectPool = false /* Metadata: 0x00AF6B2E */) => default; // 0x0000000181C20D40-0x0000000181C20F60
	[BlackList] // 0x0000000189B195D0-0x0000000189B19610
	// [XID] // 0x0000000189B195D0-0x0000000189B19610
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C1FA60-0x0000000181C1FD30
	// [XID] // 0x0000000189B23F20-0x0000000189B23F40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C21D20-0x0000000181C22050
	[BlackList] // 0x0000000189B2B2F0-0x0000000189B2B330
	// [XID] // 0x0000000189B2B2F0-0x0000000189B2B330
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181C212E0-0x0000000181C213D0
	// [XID] // 0x0000000189B35520-0x0000000189B35540
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000181C20790-0x0000000181C208C0
	[BlackList] // 0x0000000189B3CDA0-0x0000000189B3CDE0
	// [XID] // 0x0000000189B3CDA0-0x0000000189B3CDE0
	public override void AutoAllocTypeFields() {} // 0x0000000181C1FD30-0x0000000181C1FDD0
	[BlackList] // 0x0000000189B47A80-0x0000000189B47AC0
	// [XID] // 0x0000000189B47A80-0x0000000189B47AC0
	public override void AutoRecycleTypeFields() {} // 0x0000000181C1FDD0-0x0000000181C1FF10
	[BlackList] // 0x0000000189B520C0-0x0000000189B52100
	// [XID] // 0x0000000189B520C0-0x0000000189B52100
	public override void ReturnToObjectPool() {} // 0x0000000181C22190-0x0000000181C22230
}

