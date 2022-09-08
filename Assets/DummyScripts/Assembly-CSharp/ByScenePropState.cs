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
public class ByScenePropState : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17232
{
	// Fields
	private EntityType _entityType; // 0x18
	private SceneObjState _state; // 0x1C

	// Properties
	public EntityType entityType { /* [XID] */ /* 0x00000001897CF3D0-0x00000001897CF3F0 */ get => default; /* [XID] */ /* 0x00000001897D6CA0-0x00000001897D6CC0 */ private set {} } // 0x0000000182D9C300-0x0000000182D9C3A0 0x0000000182D9BC80-0x0000000182D9BD30
	public SceneObjState state { /* [XID] */ /* 0x00000001897DE3F0-0x00000001897DE410 */ get => default; /* [XID] */ /* 0x00000001897E5E70-0x00000001897E5E90 */ private set {} } // 0x0000000182D9C0B0-0x0000000182D9C150 0x0000000182D9B5C0-0x0000000182D9B670

	// Constructors
	public ByScenePropState() {} // 0x0000000182D9D930-0x0000000182D9D990

	// Methods
	// [XID] // 0x00000001897ED890-0x00000001897ED8B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D9D780-0x0000000182D9D890
	// [XID] // 0x00000001897F50D0-0x00000001897F50F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D9D390-0x0000000182D9D440
	// [XID] // 0x00000001897FCB60-0x00000001897FCB80
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6777 */) => default; // 0x0000000182D9CFA0-0x0000000182D9D080
	// [XID] // 0x00000001898040D0-0x00000001898040F0
	public override int GetHashNum() => default; // 0x0000000182D9BBB0-0x0000000182D9BC80
	// [XID] // 0x000000018980B4E0-0x000000018980B500
	public override void InitEmpty() {} // 0x0000000182D9CA30-0x0000000182D9CAD0
	[BlackList] // 0x0000000189812B60-0x0000000189812BA0
	// [XID] // 0x0000000189812B60-0x0000000189812BA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D9C420-0x0000000182D9C7A0
	// [XID] // 0x000000018981D710-0x000000018981D730
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D9B2C0-0x0000000182D9B5C0
	[BlackList] // 0x0000000189824C00-0x0000000189824C40
	// [XID] // 0x0000000189824C00-0x0000000189824C40
	public static new ByScenePropState ParseFromJson(JSONNode node) => default; // 0x0000000182D9D0E0-0x0000000182D9D330
	// [XID] // 0x000000018982F140-0x000000018982F160
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6778 */, bool useObjectPool = false /* Metadata: 0x00AF677C */) => default; // 0x0000000182D9CCA0-0x0000000182D9CFA0
	// [XID] // 0x0000000189836A10-0x0000000189836A30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF677D */, bool useObjectPool = false /* Metadata: 0x00AF6781 */) => default; // 0x0000000182D9BE10-0x0000000182D9C0B0
	// [XID] // 0x000000018983DEA0-0x000000018983DEC0
	public static new ByScenePropState ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6782 */, bool useObjectPool = false /* Metadata: 0x00AF6786 */) => default; // 0x0000000182D9C7A0-0x0000000182D9C9C0
	[BlackList] // 0x0000000189845670-0x00000001898456B0
	// [XID] // 0x0000000189845670-0x00000001898456B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D9B670-0x0000000182D9B940
	// [XID] // 0x000000018984F9E0-0x000000018984FA00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D9D4F0-0x0000000182D9D780
	[BlackList] // 0x0000000189856D20-0x0000000189856D60
	// [XID] // 0x0000000189856D20-0x0000000189856D60
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D9CBB0-0x0000000182D9CCA0
	// [XID] // 0x0000000189861190-0x00000001898611B0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182D9C150-0x0000000182D9C280
	[BlackList] // 0x0000000189868930-0x0000000189868970
	// [XID] // 0x0000000189868930-0x0000000189868970
	public override void AutoAllocTypeFields() {} // 0x0000000182D9B940-0x0000000182D9B9E0
	[BlackList] // 0x0000000189872C70-0x0000000189872CB0
	// [XID] // 0x0000000189872C70-0x0000000189872CB0
	public override void AutoRecycleTypeFields() {} // 0x0000000182D9B9E0-0x0000000182D9BA90
	[BlackList] // 0x000000018987D9A0-0x000000018987D9E0
	// [XID] // 0x000000018987D9A0-0x000000018987D9E0
	public override void ReturnToObjectPool() {} // 0x0000000182D9D890-0x0000000182D9D930
}

