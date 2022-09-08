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
public class AttachToElementTypeMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17086
{
	// Fields
	private ElementType[] _elementTypes; // 0x30
	private bool _reject; // 0x38
	private string _modifierName; // 0x40

	// Properties
	public ElementType[] elementTypes { /* [XID] */ /* 0x0000000189829430-0x0000000189829450 */ get => default; /* [XID] */ /* 0x0000000189830AE0-0x0000000189830B00 */ private set {} } // 0x000000018342E800-0x000000018342E8A0 0x000000018342ECA0-0x000000018342ED50
	public bool reject { /* [XID] */ /* 0x0000000189838140-0x0000000189838160 */ get => default; /* [XID] */ /* 0x000000018983F830-0x000000018983F850 */ private set {} } // 0x000000018342ED50-0x000000018342EDF0 0x000000018342F310-0x000000018342F3C0
	public string modifierName { /* [XID] */ /* 0x0000000189846E50-0x0000000189846E70 */ get => default; /* [XID] */ /* 0x000000018984E460-0x000000018984E480 */ private set {} } // 0x0000000183430800-0x00000001834308A0 0x000000018342F920-0x000000018342F9D0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898D0740-0x00000001898D0760 */ get => default; } // 0x000000018342EEF0-0x000000018342EF90 

	// Constructors
	public AttachToElementTypeMixin() {} // 0x0000000183430940-0x00000001834309A0

	// Methods
	// [XID] // 0x00000001898555B0-0x00000001898555D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001834306D0-0x0000000183430800
	// [XID] // 0x000000018985CAF0-0x000000018985CB10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183430290-0x0000000183430390
	// [XID] // 0x0000000189864490-0x00000001898644B0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF62A3 */) => default; // 0x000000018342FEA0-0x000000018342FF80
	// [XID] // 0x000000018986B9E0-0x000000018986BA00
	public override int GetHashNum() => default; // 0x000000018342E6D0-0x000000018342E7A0
	// [XID] // 0x0000000189872CB0-0x0000000189872CD0
	public override void InitEmpty() {} // 0x000000018342F750-0x000000018342F840
	[BlackList] // 0x000000018987A950-0x000000018987A990
	// [XID] // 0x000000018987A950-0x000000018987A990
	public override bool FromJson(JSONNode node) => default; // 0x000000018342EF90-0x000000018342F310
	// [XID] // 0x00000001898848F0-0x0000000189884910
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018342DDC0-0x000000018342E190
	[BlackList] // 0x000000018988BF20-0x000000018988BF60
	// [XID] // 0x000000018988BF20-0x000000018988BF60
	public static new AttachToElementTypeMixin ParseFromJson(JSONNode node) => default; // 0x000000018342FFE0-0x0000000183430230
	// [XID] // 0x00000001898961C0-0x00000001898961E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF62A4 */, bool useObjectPool = false /* Metadata: 0x00AF62A8 */) => default; // 0x000000018342FAC0-0x000000018342FDC0
	// [XID] // 0x000000018989D820-0x000000018989D840
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF62A9 */, bool useObjectPool = false /* Metadata: 0x00AF62AD */) => default; // 0x000000018342E920-0x000000018342ECA0
	// [XID] // 0x00000001898A51C0-0x00000001898A51E0
	public static new AttachToElementTypeMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF62AE */, bool useObjectPool = false /* Metadata: 0x00AF62B2 */) => default; // 0x000000018342F430-0x000000018342F650
	[BlackList] // 0x00000001898AC6C0-0x00000001898AC700
	// [XID] // 0x00000001898AC6C0-0x00000001898AC700
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018342E190-0x000000018342E460
	// [XID] // 0x00000001898B6E50-0x00000001898B6E70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183430390-0x00000001834306D0
	[BlackList] // 0x00000001898BE540-0x00000001898BE580
	// [XID] // 0x00000001898BE540-0x00000001898BE580
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018342F9D0-0x000000018342FAC0
	// [XID] // 0x00000001898C8F60-0x00000001898C8F80
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018342FDC0-0x000000018342FEA0
	[BlackList] // 0x00000001898D7E00-0x00000001898D7E40
	// [XID] // 0x00000001898D7E00-0x00000001898D7E40
	public override void AutoAllocTypeFields() {} // 0x000000018342E460-0x000000018342E500
	[BlackList] // 0x00000001898E2B60-0x00000001898E2BA0
	// [XID] // 0x00000001898E2B60-0x00000001898E2BA0
	public override void AutoRecycleTypeFields() {} // 0x000000018342E500-0x000000018342E5B0
	[BlackList] // 0x00000001898ED5A0-0x00000001898ED5E0
	// [XID] // 0x00000001898ED5A0-0x00000001898ED5E0
	public override void ReturnToObjectPool() {} // 0x00000001834308A0-0x0000000183430940
}

