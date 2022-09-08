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
public class DebugMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16872
{
	// Properties
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899CEB20-0x00000001899CEB40 */ get => default; } // 0x00000001828351B0-0x0000000182835250 

	// Constructors
	public DebugMixin() {} // 0x0000000182836690-0x00000001828366F0

	// Methods
	// [XID] // 0x0000000189951D70-0x0000000189951D90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182836540-0x00000001828365F0
	// [XID] // 0x00000001899592F0-0x0000000189959310
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001828363A0-0x0000000182836450
	// [XID] // 0x0000000189960B40-0x0000000189960B60
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5C09 */) => default; // 0x0000000182835FB0-0x0000000182836090
	// [XID] // 0x00000001899682E0-0x0000000189968300
	public override int GetHashNum() => default; // 0x0000000182834DD0-0x0000000182834EA0
	// [XID] // 0x000000018996F7A0-0x000000018996F7C0
	public override void InitEmpty() {} // 0x0000000182835960-0x0000000182835A00
	[BlackList] // 0x0000000189977420-0x0000000189977460
	// [XID] // 0x0000000189977420-0x0000000189977460
	public override bool FromJson(JSONNode node) => default; // 0x0000000182835250-0x00000001828355D0
	// [XID] // 0x0000000189981E20-0x0000000189981E40
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001828347B0-0x00000001828348A0
	[BlackList] // 0x0000000189989680-0x00000001899896C0
	// [XID] // 0x0000000189989680-0x00000001899896C0
	public static new DebugMixin ParseFromJson(JSONNode node) => default; // 0x00000001828360F0-0x0000000182836340
	// [XID] // 0x0000000189994210-0x0000000189994230
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C0A */, bool useObjectPool = false /* Metadata: 0x00AF5C0E */) => default; // 0x0000000182835BD0-0x0000000182835ED0
	// [XID] // 0x000000018999BA80-0x000000018999BAA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C0F */, bool useObjectPool = false /* Metadata: 0x00AF5C13 */) => default; // 0x0000000182834F80-0x00000001828350B0
	// [XID] // 0x00000001899A3250-0x00000001899A3270
	public static new DebugMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C14 */, bool useObjectPool = false /* Metadata: 0x00AF5C18 */) => default; // 0x0000000182835640-0x0000000182835860
	[BlackList] // 0x00000001899AACC0-0x00000001899AAD00
	// [XID] // 0x00000001899AACC0-0x00000001899AAD00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001828348A0-0x0000000182834B70
	// [XID] // 0x00000001899B5480-0x00000001899B54A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182836450-0x0000000182836540
	[BlackList] // 0x00000001899BCB70-0x00000001899BCBB0
	// [XID] // 0x00000001899BCB70-0x00000001899BCBB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182835AE0-0x0000000182835BD0
	// [XID] // 0x00000001899C74D0-0x00000001899C74F0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182835ED0-0x0000000182835FB0
	[BlackList] // 0x00000001899D6250-0x00000001899D6290
	// [XID] // 0x00000001899D6250-0x00000001899D6290
	public override void AutoAllocTypeFields() {} // 0x0000000182834B70-0x0000000182834C10
	[BlackList] // 0x00000001899E0760-0x00000001899E07A0
	// [XID] // 0x00000001899E0760-0x00000001899E07A0
	public override void AutoRecycleTypeFields() {} // 0x0000000182834C10-0x0000000182834CB0
	[BlackList] // 0x00000001899EAD20-0x00000001899EAD60
	// [XID] // 0x00000001899EAD20-0x00000001899EAD60
	public override void ReturnToObjectPool() {} // 0x00000001828365F0-0x0000000182836690
}

