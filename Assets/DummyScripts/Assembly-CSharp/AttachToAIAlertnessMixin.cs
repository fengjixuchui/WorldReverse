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
public class AttachToAIAlertnessMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16894
{
	// Fields
	private SimpleSafeInt32[] _alertness; // 0x30
	private string _modifierName; // 0x38

	// Properties
	public SimpleSafeInt32[] alertness { /* [XID] */ /* 0x000000018962C730-0x000000018962C750 */ get => default; /* [XID] */ /* 0x00000001896343F0-0x0000000189634410 */ private set {} } // 0x0000000184782720-0x00000001847827C0 0x0000000184781700-0x00000001847817B0
	public string modifierName { /* [XID] */ /* 0x000000018963BB20-0x000000018963BB40 */ get => default; /* [XID] */ /* 0x00000001896431E0-0x0000000189643200 */ private set {} } // 0x00000001847828D0-0x0000000184782970 0x00000001847819F0-0x0000000184781AA0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896C6850-0x00000001896C6870 */ get => default; } // 0x0000000184780FC0-0x0000000184781060 

	// Constructors
	public AttachToAIAlertnessMixin() {} // 0x0000000184782A10-0x0000000184782A70

	// Methods
	// [XID] // 0x000000018964A8C0-0x000000018964A8E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001847827C0-0x00000001847828D0
	// [XID] // 0x0000000189652180-0x00000001896521A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184782360-0x0000000184782460
	// [XID] // 0x00000001896597F0-0x0000000189659810
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5CB9 */) => default; // 0x0000000184781F70-0x0000000184782050
	// [XID] // 0x0000000189660FB0-0x0000000189660FD0
	public override int GetHashNum() => default; // 0x0000000184780A10-0x0000000184780AE0
	// [XID] // 0x00000001896689A0-0x00000001896689C0
	public override void InitEmpty() {} // 0x0000000184781820-0x0000000184781910
	[BlackList] // 0x00000001896704F0-0x0000000189670530
	// [XID] // 0x00000001896704F0-0x0000000189670530
	public override bool FromJson(JSONNode node) => default; // 0x0000000184781060-0x00000001847813E0
	// [XID] // 0x000000018967AB20-0x000000018967AB40
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001847801C0-0x00000001847804D0
	[BlackList] // 0x00000001896823F0-0x0000000189682430
	// [XID] // 0x00000001896823F0-0x0000000189682430
	public static new AttachToAIAlertnessMixin ParseFromJson(JSONNode node) => default; // 0x00000001847820B0-0x0000000184782300
	// [XID] // 0x000000018968CE00-0x000000018968CE20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CBA */, bool useObjectPool = false /* Metadata: 0x00AF5CBE */) => default; // 0x0000000184781B90-0x0000000184781E90
	// [XID] // 0x0000000189694960-0x0000000189694980
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CBF */, bool useObjectPool = false /* Metadata: 0x00AF5CC3 */) => default; // 0x0000000184780BC0-0x0000000184780EC0
	// [XID] // 0x000000018969C100-0x000000018969C120
	public static new AttachToAIAlertnessMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CC4 */, bool useObjectPool = false /* Metadata: 0x00AF5CC8 */) => default; // 0x0000000184781450-0x0000000184781670
	[BlackList] // 0x00000001896A3520-0x00000001896A3560
	// [XID] // 0x00000001896A3520-0x00000001896A3560
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001847804D0-0x00000001847807A0
	// [XID] // 0x00000001896AD8F0-0x00000001896AD910
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184782460-0x0000000184782720
	[BlackList] // 0x00000001896B5010-0x00000001896B5050
	// [XID] // 0x00000001896B5010-0x00000001896B5050
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184781AA0-0x0000000184781B90
	// [XID] // 0x00000001896BEEF0-0x00000001896BEF10
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184781E90-0x0000000184781F70
	[BlackList] // 0x00000001896CDE30-0x00000001896CDE70
	// [XID] // 0x00000001896CDE30-0x00000001896CDE70
	public override void AutoAllocTypeFields() {} // 0x00000001847807A0-0x0000000184780840
	[BlackList] // 0x00000001896D8290-0x00000001896D82D0
	// [XID] // 0x00000001896D8290-0x00000001896D82D0
	public override void AutoRecycleTypeFields() {} // 0x0000000184780840-0x00000001847808F0
	[BlackList] // 0x00000001896E2A40-0x00000001896E2A80
	// [XID] // 0x00000001896E2A40-0x00000001896E2A80
	public override void ReturnToObjectPool() {} // 0x0000000184782970-0x0000000184782A10
}

