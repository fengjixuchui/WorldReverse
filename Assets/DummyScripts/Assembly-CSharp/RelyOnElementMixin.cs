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
public class RelyOnElementMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16874
{
	// Fields
	private ElementType _elementType; // 0x30

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x00000001899FCF90-0x00000001899FCFB0 */ get => default; /* [XID] */ /* 0x0000000189A04430-0x0000000189A04450 */ private set {} } // 0x00000001835EC3A0-0x00000001835EC440 0x00000001835ED480-0x00000001835ED530
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A87E40-0x0000000189A87E60 */ get => default; } // 0x00000001835EC540-0x00000001835EC5E0 

	// Constructors
	public RelyOnElementMixin() {} // 0x00000001835EDC20-0x00000001835EDC80

	// Methods
	// [XID] // 0x0000000189A0BB10-0x0000000189A0BB30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835EDA90-0x00000001835EDB80
	// [XID] // 0x0000000189A13460-0x0000000189A13480
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835ED7E0-0x00000001835ED890
	// [XID] // 0x0000000189A1A590-0x0000000189A1A5B0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5C19 */) => default; // 0x00000001835ED340-0x00000001835ED420
	// [XID] // 0x0000000189A21D50-0x0000000189A21D70
	public override int GetHashNum() => default; // 0x00000001835EBFC0-0x00000001835EC090
	// [XID] // 0x0000000189A292A0-0x0000000189A292C0
	public override void InitEmpty() {} // 0x00000001835ECCF0-0x00000001835ECD90
	[BlackList] // 0x0000000189A30850-0x0000000189A30890
	// [XID] // 0x0000000189A30850-0x0000000189A30890
	public override bool FromJson(JSONNode node) => default; // 0x00000001835EC5E0-0x00000001835EC960
	// [XID] // 0x0000000189A3B020-0x0000000189A3B040
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001835EB860-0x00000001835EBA80
	[BlackList] // 0x0000000189A428F0-0x0000000189A42930
	// [XID] // 0x0000000189A428F0-0x0000000189A42930
	public static new RelyOnElementMixin ParseFromJson(JSONNode node) => default; // 0x00000001835ED530-0x00000001835ED780
	// [XID] // 0x0000000189A4CFE0-0x0000000189A4D000
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C1A */, bool useObjectPool = false /* Metadata: 0x00AF5C1E */) => default; // 0x00000001835ECF60-0x00000001835ED260
	// [XID] // 0x0000000189A54710-0x0000000189A54730
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C1F */, bool useObjectPool = false /* Metadata: 0x00AF5C23 */) => default; // 0x00000001835EC170-0x00000001835EC3A0
	// [XID] // 0x0000000189A5C200-0x0000000189A5C220
	public static new RelyOnElementMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C24 */, bool useObjectPool = false /* Metadata: 0x00AF5C28 */) => default; // 0x00000001835EC9D0-0x00000001835ECBF0
	[BlackList] // 0x0000000189A63B90-0x0000000189A63BD0
	// [XID] // 0x0000000189A63B90-0x0000000189A63BD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001835EBA80-0x00000001835EBD50
	// [XID] // 0x0000000189A6E2C0-0x0000000189A6E2E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835ED890-0x00000001835EDA90
	[BlackList] // 0x0000000189A75890-0x0000000189A758D0
	// [XID] // 0x0000000189A75890-0x0000000189A758D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001835ECE70-0x00000001835ECF60
	// [XID] // 0x0000000189A80140-0x0000000189A80160
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001835ED260-0x00000001835ED340
	[BlackList] // 0x0000000189A8F6B0-0x0000000189A8F6F0
	// [XID] // 0x0000000189A8F6B0-0x0000000189A8F6F0
	public override void AutoAllocTypeFields() {} // 0x00000001835EBD50-0x00000001835EBDF0
	[BlackList] // 0x0000000189A99F00-0x0000000189A99F40
	// [XID] // 0x0000000189A99F00-0x0000000189A99F40
	public override void AutoRecycleTypeFields() {} // 0x00000001835EBDF0-0x00000001835EBEA0
	[BlackList] // 0x0000000189AA43A0-0x0000000189AA43E0
	// [XID] // 0x0000000189AA43A0-0x0000000189AA43E0
	public override void ReturnToObjectPool() {} // 0x00000001835EDB80-0x00000001835EDC20
}

