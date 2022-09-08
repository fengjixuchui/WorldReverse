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
public class ByAvatarWeaponType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17286
{
	// Fields
	private string[] _weaponTypes; // 0x18

	// Properties
	public string[] weaponTypes { /* [XID] */ /* 0x00000001898263B0-0x00000001898263D0 */ get => default; /* [XID] */ /* 0x000000018982DA40-0x000000018982DA60 */ private set {} } // 0x0000000182D4F210-0x0000000182D4F2B0 0x0000000182D4F2B0-0x0000000182D4F360

	// Constructors
	public ByAvatarWeaponType() {} // 0x0000000182D50DE0-0x0000000182D50E40

	// Methods
	// [XID] // 0x0000000189835170-0x0000000189835190
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D50C50-0x0000000182D50D40
	// [XID] // 0x000000018983C8B0-0x000000018983C8D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D50880-0x0000000182D50960
	// [XID] // 0x0000000189844000-0x0000000189844020
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF695B */) => default; // 0x0000000182D50490-0x0000000182D50570
	// [XID] // 0x000000018984B430-0x000000018984B450
	public override int GetHashNum() => default; // 0x0000000182D4F140-0x0000000182D4F210
	// [XID] // 0x00000001898525A0-0x00000001898525C0
	public override void InitEmpty() {} // 0x0000000182D4FEF0-0x0000000182D4FFC0
	[BlackList] // 0x0000000189859FF0-0x000000018985A030
	// [XID] // 0x0000000189859FF0-0x000000018985A030
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D4F8E0-0x0000000182D4FC60
	// [XID] // 0x0000000189864470-0x0000000189864490
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D4E9D0-0x0000000182D4EC00
	[BlackList] // 0x000000018986B960-0x000000018986B9A0
	// [XID] // 0x000000018986B960-0x000000018986B9A0
	public static new ByAvatarWeaponType ParseFromJson(JSONNode node) => default; // 0x0000000182D505D0-0x0000000182D50820
	// [XID] // 0x0000000189875DC0-0x0000000189875DE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF695C */, bool useObjectPool = false /* Metadata: 0x00AF6960 */) => default; // 0x0000000182D50190-0x0000000182D50490
	// [XID] // 0x000000018987D960-0x000000018987D980
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6961 */, bool useObjectPool = false /* Metadata: 0x00AF6965 */) => default; // 0x0000000182D4F440-0x0000000182D4F6B0
	// [XID] // 0x0000000189884890-0x00000001898848B0
	public static new ByAvatarWeaponType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6966 */, bool useObjectPool = false /* Metadata: 0x00AF696A */) => default; // 0x0000000182D4FC60-0x0000000182D4FE80
	[BlackList] // 0x000000018988BEA0-0x000000018988BEE0
	// [XID] // 0x000000018988BEA0-0x000000018988BEE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D4EC00-0x0000000182D4EED0
	// [XID] // 0x0000000189896180-0x00000001898961A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D50A10-0x0000000182D50C50
	[BlackList] // 0x000000018989D780-0x000000018989D7C0
	// [XID] // 0x000000018989D780-0x000000018989D7C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D500A0-0x0000000182D50190
	// [XID] // 0x00000001898A7D90-0x00000001898A7DB0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182D4F6B0-0x0000000182D4F7E0
	[BlackList] // 0x00000001898AF870-0x00000001898AF8B0
	// [XID] // 0x00000001898AF870-0x00000001898AF8B0
	public override void AutoAllocTypeFields() {} // 0x0000000182D4EED0-0x0000000182D4EF70
	[BlackList] // 0x00000001898BA2A0-0x00000001898BA2E0
	// [XID] // 0x00000001898BA2A0-0x00000001898BA2E0
	public override void AutoRecycleTypeFields() {} // 0x0000000182D4EF70-0x0000000182D4F020
	[BlackList] // 0x00000001898C4760-0x00000001898C47A0
	// [XID] // 0x00000001898C4760-0x00000001898C47A0
	public override void ReturnToObjectPool() {} // 0x0000000182D50D40-0x0000000182D50DE0
}

