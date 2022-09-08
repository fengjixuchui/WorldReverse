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
public class BillboardMarkMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17125
{
	// Fields
	private string _iconName; // 0x30
	private SimpleSafeFloat showDistanceRawNum; // 0x38

	// Properties
	public string iconName { /* [XID] */ /* 0x00000001899F9E50-0x00000001899F9E70 */ get => default; /* [XID] */ /* 0x0000000189A01270-0x0000000189A01290 */ private set {} } // 0x0000000184163C70-0x0000000184163D10 0x00000001841640B0-0x0000000184164160
	public float showDistance { /* [XID] */ /* 0x0000000189A08C10-0x0000000189A08C30 */ get => default; /* [XID] */ /* 0x0000000189A100F0-0x0000000189A10110 */ private set {} } // 0x00000001841637A0-0x0000000184163880 0x00000001841626F0-0x00000001841627D0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A939F0-0x0000000189A93A10 */ get => default; } // 0x0000000184162850-0x00000001841628F0 

	// Constructors
	public BillboardMarkMixin() {} // 0x0000000184164200-0x00000001841642A0

	// Methods
	// [XID] // 0x0000000189A17690-0x0000000189A176B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184163FA0-0x00000001841640B0
	// [XID] // 0x0000000189A1EDB0-0x0000000189A1EDD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184163B90-0x0000000184163C70
	// [XID] // 0x0000000189A26420-0x0000000189A26440
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF640D */) => default; // 0x00000001841636C0-0x00000001841637A0
	// [XID] // 0x0000000189A2D6F0-0x0000000189A2D710
	public override int GetHashNum() => default; // 0x00000001841621E0-0x00000001841622B0
	// [XID] // 0x0000000189A35230-0x0000000189A35250
	public override void InitEmpty() {} // 0x0000000184163000-0x0000000184163110
	[BlackList] // 0x0000000189A3C7C0-0x0000000189A3C800
	// [XID] // 0x0000000189A3C7C0-0x0000000189A3C800
	public override bool FromJson(JSONNode node) => default; // 0x00000001841628F0-0x0000000184162C70
	// [XID] // 0x0000000189A47070-0x0000000189A47090
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184161930-0x0000000184161C70
	[BlackList] // 0x0000000189A4E970-0x0000000189A4E9B0
	// [XID] // 0x0000000189A4E970-0x0000000189A4E9B0
	public static new BillboardMarkMixin ParseFromJson(JSONNode node) => default; // 0x00000001841638E0-0x0000000184163B30
	// [XID] // 0x0000000189A58FA0-0x0000000189A58FC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF640E */, bool useObjectPool = false /* Metadata: 0x00AF6412 */) => default; // 0x00000001841632E0-0x00000001841635E0
	// [XID] // 0x0000000189A608C0-0x0000000189A608E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6413 */, bool useObjectPool = false /* Metadata: 0x00AF6417 */) => default; // 0x0000000184162390-0x0000000184162670
	// [XID] // 0x0000000189A686D0-0x0000000189A686F0
	public static new BillboardMarkMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6418 */, bool useObjectPool = false /* Metadata: 0x00AF641C */) => default; // 0x0000000184162CE0-0x0000000184162F00
	[BlackList] // 0x0000000189A6FAA0-0x0000000189A6FAE0
	// [XID] // 0x0000000189A6FAA0-0x0000000189A6FAE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184161C70-0x0000000184161F40
	// [XID] // 0x0000000189A7A6B0-0x0000000189A7A6D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184163D10-0x0000000184163FA0
	[BlackList] // 0x0000000189A81BB0-0x0000000189A81BF0
	// [XID] // 0x0000000189A81BB0-0x0000000189A81BF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001841631F0-0x00000001841632E0
	// [XID] // 0x0000000189A8C5B0-0x0000000189A8C5D0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001841635E0-0x00000001841636C0
	[BlackList] // 0x0000000189A9B580-0x0000000189A9B5C0
	// [XID] // 0x0000000189A9B580-0x0000000189A9B5C0
	public override void AutoAllocTypeFields() {} // 0x0000000184161F40-0x0000000184161FE0
	[BlackList] // 0x0000000189AA5A00-0x0000000189AA5A40
	// [XID] // 0x0000000189AA5A00-0x0000000189AA5A40
	public override void AutoRecycleTypeFields() {} // 0x0000000184161FE0-0x00000001841620C0
	[BlackList] // 0x0000000189AB0200-0x0000000189AB0240
	// [XID] // 0x0000000189AB0200-0x0000000189AB0240
	public override void ReturnToObjectPool() {} // 0x0000000184164160-0x0000000184164200
}

