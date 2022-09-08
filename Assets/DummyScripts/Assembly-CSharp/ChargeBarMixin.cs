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
public class ChargeBarMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16918
{
	// Fields
	private ChargeStateType _chargeState; // 0x30

	// Properties
	public ChargeStateType chargeState { /* [XID] */ /* 0x0000000189A35270-0x0000000189A35290 */ get => default; /* [XID] */ /* 0x0000000189A3C860-0x0000000189A3C880 */ private set {} } // 0x00000001839D2F70-0x00000001839D3010 0x00000001839D2B30-0x00000001839D2BE0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189AC0BF0-0x0000000189AC0C10 */ get => default; } // 0x00000001839D3090-0x00000001839D3130 

	// Constructors
	public ChargeBarMixin() {} // 0x00000001839D46C0-0x00000001839D4720

	// Methods
	// [XID] // 0x0000000189A442F0-0x0000000189A44310
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839D4530-0x00000001839D4620
	// [XID] // 0x0000000189A4B880-0x0000000189A4B8A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001839D4280-0x00000001839D4330
	// [XID] // 0x0000000189A52FA0-0x0000000189A52FC0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5D85 */) => default; // 0x00000001839D3E90-0x00000001839D3F70
	// [XID] // 0x0000000189A5A770-0x0000000189A5A790
	public override int GetHashNum() => default; // 0x00000001839D2A60-0x00000001839D2B30
	// [XID] // 0x0000000189A61EF0-0x0000000189A61F10
	public override void InitEmpty() {} // 0x00000001839D3840-0x00000001839D38E0
	[BlackList] // 0x0000000189A69D10-0x0000000189A69D50
	// [XID] // 0x0000000189A69D10-0x0000000189A69D50
	public override bool FromJson(JSONNode node) => default; // 0x00000001839D3130-0x00000001839D34B0
	// [XID] // 0x0000000189A741B0-0x0000000189A741D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001839D2300-0x00000001839D2520
	[BlackList] // 0x0000000189A7BB40-0x0000000189A7BB80
	// [XID] // 0x0000000189A7BB40-0x0000000189A7BB80
	public static new ChargeBarMixin ParseFromJson(JSONNode node) => default; // 0x00000001839D3FD0-0x00000001839D4220
	// [XID] // 0x0000000189A86430-0x0000000189A86450
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D86 */, bool useObjectPool = false /* Metadata: 0x00AF5D8A */) => default; // 0x00000001839D3AB0-0x00000001839D3DB0
	// [XID] // 0x0000000189A8DE30-0x0000000189A8DE50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D8B */, bool useObjectPool = false /* Metadata: 0x00AF5D8F */) => default; // 0x00000001839D2CC0-0x00000001839D2EF0
	// [XID] // 0x0000000189A953D0-0x0000000189A953F0
	public static new ChargeBarMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D90 */, bool useObjectPool = false /* Metadata: 0x00AF5D94 */) => default; // 0x00000001839D3520-0x00000001839D3740
	[BlackList] // 0x0000000189A9CBD0-0x0000000189A9CC10
	// [XID] // 0x0000000189A9CBD0-0x0000000189A9CC10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001839D2520-0x00000001839D27F0
	// [XID] // 0x0000000189AA7280-0x0000000189AA72A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001839D4330-0x00000001839D4530
	[BlackList] // 0x0000000189AAE9A0-0x0000000189AAE9E0
	// [XID] // 0x0000000189AAE9A0-0x0000000189AAE9E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001839D39C0-0x00000001839D3AB0
	// [XID] // 0x0000000189AB9090-0x0000000189AB90B0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001839D3DB0-0x00000001839D3E90
	[BlackList] // 0x0000000189AC85F0-0x0000000189AC8630
	// [XID] // 0x0000000189AC85F0-0x0000000189AC8630
	public override void AutoAllocTypeFields() {} // 0x00000001839D27F0-0x00000001839D2890
	[BlackList] // 0x0000000189AD3000-0x0000000189AD3040
	// [XID] // 0x0000000189AD3000-0x0000000189AD3040
	public override void AutoRecycleTypeFields() {} // 0x00000001839D2890-0x00000001839D2940
	[BlackList] // 0x0000000189ADDD00-0x0000000189ADDD40
	// [XID] // 0x0000000189ADDD00-0x0000000189ADDD40
	public override void ReturnToObjectPool() {} // 0x00000001839D4620-0x00000001839D46C0
}

