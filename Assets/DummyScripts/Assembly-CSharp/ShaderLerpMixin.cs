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
public class ShaderLerpMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17082
{
	// Fields
	private E_ShaderData _type; // 0x30

	// Properties
	public E_ShaderData type { /* [XID] */ /* 0x00000001896A7B20-0x00000001896A7B40 */ get => default; /* [XID] */ /* 0x00000001896AEF50-0x00000001896AEF70 */ private set {} } // 0x0000000182261E30-0x0000000182261ED0 0x0000000182261A90-0x0000000182261B40
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189731420-0x0000000189731440 */ get => default; } // 0x00000001822607F0-0x0000000182260890 

	// Constructors
	public ShaderLerpMixin() {} // 0x0000000182261F70-0x0000000182261FD0

	// Methods
	// [XID] // 0x00000001896B6580-0x00000001896B65A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182261D40-0x0000000182261E30
	// [XID] // 0x00000001896BD840-0x00000001896BD860
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001822619E0-0x0000000182261A90
	// [XID] // 0x00000001896C4F70-0x00000001896C4F90
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6283 */) => default; // 0x00000001822615F0-0x00000001822616D0
	// [XID] // 0x00000001896CC530-0x00000001896CC550
	public override int GetHashNum() => default; // 0x0000000182260310-0x00000001822603E0
	// [XID] // 0x00000001896D3780-0x00000001896D37A0
	public override void InitEmpty() {} // 0x0000000182260FA0-0x0000000182261040
	[BlackList] // 0x00000001896DB260-0x00000001896DB2A0
	// [XID] // 0x00000001896DB260-0x00000001896DB2A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182260890-0x0000000182260C10
	// [XID] // 0x00000001896E5630-0x00000001896E5650
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018225FBB0-0x000000018225FDD0
	[BlackList] // 0x00000001896ECD40-0x00000001896ECD80
	// [XID] // 0x00000001896ECD40-0x00000001896ECD80
	public static new ShaderLerpMixin ParseFromJson(JSONNode node) => default; // 0x0000000182261730-0x0000000182261980
	// [XID] // 0x00000001896F74B0-0x00000001896F74D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6284 */, bool useObjectPool = false /* Metadata: 0x00AF6288 */) => default; // 0x0000000182261210-0x0000000182261510
	// [XID] // 0x00000001896FEE70-0x00000001896FEE90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6289 */, bool useObjectPool = false /* Metadata: 0x00AF628D */) => default; // 0x00000001822604C0-0x00000001822606F0
	// [XID] // 0x00000001897060A0-0x00000001897060C0
	public static new ShaderLerpMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF628E */, bool useObjectPool = false /* Metadata: 0x00AF6292 */) => default; // 0x0000000182260C80-0x0000000182260EA0
	[BlackList] // 0x000000018970D930-0x000000018970D970
	// [XID] // 0x000000018970D930-0x000000018970D970
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018225FDD0-0x00000001822600A0
	// [XID] // 0x0000000189717F50-0x0000000189717F70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182261B40-0x0000000182261D40
	[BlackList] // 0x000000018971F8F0-0x000000018971F930
	// [XID] // 0x000000018971F8F0-0x000000018971F930
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182261120-0x0000000182261210
	// [XID] // 0x0000000189729D60-0x0000000189729D80
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182261510-0x00000001822615F0
	[BlackList] // 0x0000000189738C50-0x0000000189738C90
	// [XID] // 0x0000000189738C50-0x0000000189738C90
	public override void AutoAllocTypeFields() {} // 0x00000001822600A0-0x0000000182260140
	[BlackList] // 0x0000000189743630-0x0000000189743670
	// [XID] // 0x0000000189743630-0x0000000189743670
	public override void AutoRecycleTypeFields() {} // 0x0000000182260140-0x00000001822601F0
	[BlackList] // 0x000000018974DFF0-0x000000018974E030
	// [XID] // 0x000000018974DFF0-0x000000018974E030
	public override void ReturnToObjectPool() {} // 0x0000000182261ED0-0x0000000182261F70
}

