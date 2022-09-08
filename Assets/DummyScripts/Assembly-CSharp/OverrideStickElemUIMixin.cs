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
public class OverrideStickElemUIMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17053
{
	// Fields
	private string _effName; // 0x30

	// Properties
	public string effName { /* [XID] */ /* 0x00000001895EF3E0-0x00000001895EF400 */ get => default; /* [XID] */ /* 0x00000001895F6DE0-0x00000001895F6E00 */ private set {} } // 0x000000018392A4C0-0x000000018392A560 0x0000000183929120-0x00000001839291D0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018967AB00-0x000000018967AB20 */ get => default; } // 0x0000000183929770-0x0000000183929810 

	// Constructors
	public OverrideStickElemUIMixin() {} // 0x000000018392AEA0-0x000000018392AF00

	// Methods
	// [XID] // 0x00000001895FE1E0-0x00000001895FE200
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018392AD10-0x000000018392AE00
	// [XID] // 0x00000001896059F0-0x0000000189605A10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018392AA30-0x000000018392AB10
	// [XID] // 0x000000018960D360-0x000000018960D380
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF61A3 */) => default; // 0x000000018392A640-0x000000018392A720
	// [XID] // 0x0000000189614A00-0x0000000189614A20
	public override int GetHashNum() => default; // 0x0000000183929250-0x0000000183929320
	// [XID] // 0x000000018961C420-0x000000018961C440
	public override void InitEmpty() {} // 0x0000000183929F20-0x0000000183929FF0
	[BlackList] // 0x00000001896237A0-0x00000001896237E0
	// [XID] // 0x00000001896237A0-0x00000001896237E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183929810-0x0000000183929B90
	// [XID] // 0x000000018962E010-0x000000018962E030
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183928A30-0x0000000183928C60
	[BlackList] // 0x0000000189635CD0-0x0000000189635D10
	// [XID] // 0x0000000189635CD0-0x0000000189635D10
	public static new OverrideStickElemUIMixin ParseFromJson(JSONNode node) => default; // 0x000000018392A780-0x000000018392A9D0
	// [XID] // 0x0000000189640090-0x00000001896400B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61A4 */, bool useObjectPool = false /* Metadata: 0x00AF61A8 */) => default; // 0x000000018392A1C0-0x000000018392A4C0
	// [XID] // 0x0000000189647970-0x0000000189647990
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61A9 */, bool useObjectPool = false /* Metadata: 0x00AF61AD */) => default; // 0x0000000183929400-0x0000000183929670
	// [XID] // 0x000000018964EF80-0x000000018964EFA0
	public static new OverrideStickElemUIMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61AE */, bool useObjectPool = false /* Metadata: 0x00AF61B2 */) => default; // 0x0000000183929C00-0x0000000183929E20
	[BlackList] // 0x00000001896567D0-0x0000000189656810
	// [XID] // 0x00000001896567D0-0x0000000189656810
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183928C60-0x0000000183928F30
	// [XID] // 0x0000000189660F70-0x0000000189660F90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018392AB10-0x000000018392AD10
	[BlackList] // 0x0000000189668900-0x0000000189668940
	// [XID] // 0x0000000189668900-0x0000000189668940
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018392A0D0-0x000000018392A1C0
	// [XID] // 0x0000000189673300-0x0000000189673320
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018392A560-0x000000018392A640
	[BlackList] // 0x00000001896823B0-0x00000001896823F0
	// [XID] // 0x00000001896823B0-0x00000001896823F0
	public override void AutoAllocTypeFields() {} // 0x0000000183928F30-0x0000000183928FD0
	[BlackList] // 0x000000018968CDA0-0x000000018968CDE0
	// [XID] // 0x000000018968CDA0-0x000000018968CDE0
	public override void AutoRecycleTypeFields() {} // 0x0000000183928FD0-0x0000000183929080
	[BlackList] // 0x0000000189697AE0-0x0000000189697B20
	// [XID] // 0x0000000189697AE0-0x0000000189697B20
	public override void ReturnToObjectPool() {} // 0x000000018392AE00-0x000000018392AEA0
}

