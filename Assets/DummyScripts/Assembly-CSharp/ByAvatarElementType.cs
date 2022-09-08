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
public class ByAvatarElementType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17284
{
	// Fields
	private ElementType _elementType; // 0x18

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189772EA0-0x0000000189772EC0 */ get => default; /* [XID] */ /* 0x000000018977A5A0-0x000000018977A5C0 */ private set {} } // 0x0000000182C6E120-0x0000000182C6E1C0 0x0000000182C6EF80-0x0000000182C6F030

	// Constructors
	public ByAvatarElementType() {} // 0x0000000182C6F7D0-0x0000000182C6F830

	// Methods
	// [XID] // 0x0000000189782140-0x0000000189782160
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C6F640-0x0000000182C6F730
	// [XID] // 0x0000000189789500-0x0000000189789520
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182C6F2E0-0x0000000182C6F390
	// [XID] // 0x0000000189790BD0-0x0000000189790BF0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF694B */) => default; // 0x0000000182C6EE40-0x0000000182C6EF20
	// [XID] // 0x0000000189798540-0x0000000189798560
	public override int GetHashNum() => default; // 0x0000000182C6DC10-0x0000000182C6DCE0
	// [XID] // 0x00000001897A0350-0x00000001897A0370
	public override void InitEmpty() {} // 0x0000000182C6E8D0-0x0000000182C6E970
	[BlackList] // 0x00000001897A7960-0x00000001897A79A0
	// [XID] // 0x00000001897A7960-0x00000001897A79A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182C6E2C0-0x0000000182C6E640
	// [XID] // 0x00000001897B2270-0x00000001897B2290
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182C6D4B0-0x0000000182C6D6D0
	[BlackList] // 0x00000001897B9CD0-0x00000001897B9D10
	// [XID] // 0x00000001897B9CD0-0x00000001897B9D10
	public static new ByAvatarElementType ParseFromJson(JSONNode node) => default; // 0x0000000182C6F030-0x0000000182C6F280
	// [XID] // 0x00000001897C4B60-0x00000001897C4B80
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF694C */, bool useObjectPool = false /* Metadata: 0x00AF6950 */) => default; // 0x0000000182C6EB40-0x0000000182C6EE40
	// [XID] // 0x00000001897CC3D0-0x00000001897CC3F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6951 */, bool useObjectPool = false /* Metadata: 0x00AF6955 */) => default; // 0x0000000182C6DDC0-0x0000000182C6DFF0
	// [XID] // 0x00000001897D3CE0-0x00000001897D3D00
	public static new ByAvatarElementType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6956 */, bool useObjectPool = false /* Metadata: 0x00AF695A */) => default; // 0x0000000182C6E640-0x0000000182C6E860
	[BlackList] // 0x00000001897DB670-0x00000001897DB6B0
	// [XID] // 0x00000001897DB670-0x00000001897DB6B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C6D6D0-0x0000000182C6D9A0
	// [XID] // 0x00000001897E5E50-0x00000001897E5E70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C6F440-0x0000000182C6F640
	[BlackList] // 0x00000001897ED850-0x00000001897ED890
	// [XID] // 0x00000001897ED850-0x00000001897ED890
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182C6EA50-0x0000000182C6EB40
	// [XID] // 0x00000001897F8100-0x00000001897F8120
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182C6DFF0-0x0000000182C6E120
	[BlackList] // 0x00000001897FF8B0-0x00000001897FF8F0
	// [XID] // 0x00000001897FF8B0-0x00000001897FF8F0
	public override void AutoAllocTypeFields() {} // 0x0000000182C6D9A0-0x0000000182C6DA40
	[BlackList] // 0x0000000189809E10-0x0000000189809E50
	// [XID] // 0x0000000189809E10-0x0000000189809E50
	public override void AutoRecycleTypeFields() {} // 0x0000000182C6DA40-0x0000000182C6DAF0
	[BlackList] // 0x0000000189814310-0x0000000189814350
	// [XID] // 0x0000000189814310-0x0000000189814350
	public override void ReturnToObjectPool() {} // 0x0000000182C6F730-0x0000000182C6F7D0
}

