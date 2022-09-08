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
public class ByHitBoxName : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17198
{
	// Fields
	private string[] _hitBoxNames; // 0x18

	// Properties
	public string[] hitBoxNames { /* [XID] */ /* 0x00000001898BA2E0-0x00000001898BA300 */ get => default; /* [XID] */ /* 0x00000001898C1680-0x00000001898C16A0 */ private set {} } // 0x00000001839FB5F0-0x00000001839FB690 0x00000001839FD390-0x00000001839FD440

	// Constructors
	public ByHitBoxName() {} // 0x00000001839FDA00-0x00000001839FDA60

	// Methods
	// [XID] // 0x00000001898C8F40-0x00000001898C8F60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839FD870-0x00000001839FD960
	// [XID] // 0x00000001898D0720-0x00000001898D0740
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001839FD4A0-0x00000001839FD580
	// [XID] // 0x00000001898D7DE0-0x00000001898D7E00
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6657 */) => default; // 0x00000001839FD000-0x00000001839FD0E0
	// [XID] // 0x00000001898DFBC0-0x00000001898DFBE0
	public override int GetHashNum() => default; // 0x00000001839FBE00-0x00000001839FBED0
	// [XID] // 0x00000001898E7610-0x00000001898E7630
	public override void InitEmpty() {} // 0x00000001839FCA60-0x00000001839FCB30
	[BlackList] // 0x00000001898EEE40-0x00000001898EEE80
	// [XID] // 0x00000001898EEE40-0x00000001898EEE80
	public override bool FromJson(JSONNode node) => default; // 0x00000001839FC450-0x00000001839FC7D0
	// [XID] // 0x00000001898F9630-0x00000001898F9650
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001839FB690-0x00000001839FB8C0
	[BlackList] // 0x0000000189901030-0x0000000189901070
	// [XID] // 0x0000000189901030-0x0000000189901070
	public static new ByHitBoxName ParseFromJson(JSONNode node) => default; // 0x00000001839FD140-0x00000001839FD390
	// [XID] // 0x000000018990B4D0-0x000000018990B4F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6658 */, bool useObjectPool = false /* Metadata: 0x00AF665C */) => default; // 0x00000001839FCD00-0x00000001839FD000
	// [XID] // 0x0000000189913200-0x0000000189913220
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF665D */, bool useObjectPool = false /* Metadata: 0x00AF6661 */) => default; // 0x00000001839FBFB0-0x00000001839FC220
	// [XID] // 0x000000018991A970-0x000000018991A990
	public static new ByHitBoxName ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6662 */, bool useObjectPool = false /* Metadata: 0x00AF6666 */) => default; // 0x00000001839FC7D0-0x00000001839FC9F0
	[BlackList] // 0x0000000189922260-0x00000001899222A0
	// [XID] // 0x0000000189922260-0x00000001899222A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001839FB8C0-0x00000001839FBB90
	// [XID] // 0x000000018992C6A0-0x000000018992C6C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001839FD630-0x00000001839FD870
	[BlackList] // 0x0000000189933DC0-0x0000000189933E00
	// [XID] // 0x0000000189933DC0-0x0000000189933E00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001839FCC10-0x00000001839FCD00
	// [XID] // 0x000000018993E6D0-0x000000018993E6F0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001839FC220-0x00000001839FC350
	[BlackList] // 0x0000000189945CE0-0x0000000189945D20
	// [XID] // 0x0000000189945CE0-0x0000000189945D20
	public override void AutoAllocTypeFields() {} // 0x00000001839FBB90-0x00000001839FBC30
	[BlackList] // 0x0000000189950510-0x0000000189950550
	// [XID] // 0x0000000189950510-0x0000000189950550
	public override void AutoRecycleTypeFields() {} // 0x00000001839FBC30-0x00000001839FBCE0
	[BlackList] // 0x000000018995AAD0-0x000000018995AB10
	// [XID] // 0x000000018995AAD0-0x000000018995AB10
	public override void ReturnToObjectPool() {} // 0x00000001839FD960-0x00000001839FDA00
}

