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
public class ReplaceEventPatternMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16876
{
	// Fields
	private string[] _oldPatterns; // 0x30
	private string[] _newPatterns; // 0x38

	// Properties
	public string[] oldPatterns { /* [XID] */ /* 0x0000000189AB62C0-0x0000000189AB62E0 */ get => default; /* [XID] */ /* 0x0000000189ABDCF0-0x0000000189ABDD10 */ private set {} } // 0x0000000185948810-0x00000001859488B0 0x0000000185949480-0x0000000185949530
	public string[] newPatterns { /* [XID] */ /* 0x0000000189AC5870-0x0000000189AC5890 */ get => default; /* [XID] */ /* 0x0000000189ACCD80-0x0000000189ACCDA0 */ private set {} } // 0x0000000185948B20-0x0000000185948BC0 0x0000000185947BC0-0x0000000185947C70
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B50C60-0x0000000189B50C80 */ get => default; } // 0x0000000185948160-0x0000000185948200 

	// Constructors
	public ReplaceEventPatternMixin() {} // 0x0000000185949B30-0x0000000185949B90

	// Methods
	// [XID] // 0x0000000189AD4A60-0x0000000189AD4A80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185949980-0x0000000185949A90
	// [XID] // 0x0000000189ADC3C0-0x0000000189ADC3E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185949590-0x0000000185949690
	// [XID] // 0x0000000189AE3DB0-0x0000000189AE3DD0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5C29 */) => default; // 0x00000001859490F0-0x00000001859491D0
	// [XID] // 0x0000000189AEB5F0-0x0000000189AEB610
	public override int GetHashNum() => default; // 0x0000000185947AF0-0x0000000185947BC0
	// [XID] // 0x0000000189AF2F70-0x0000000189AF2F90
	public override void InitEmpty() {} // 0x00000001859489B0-0x0000000185948AA0
	[BlackList] // 0x0000000189AFA820-0x0000000189AFA860
	// [XID] // 0x0000000189AFA820-0x0000000189AFA860
	public override bool FromJson(JSONNode node) => default; // 0x0000000185948200-0x0000000185948580
	// [XID] // 0x0000000189B04BC0-0x0000000189B04BE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185947290-0x00000001859475B0
	[BlackList] // 0x0000000189B0C350-0x0000000189B0C390
	// [XID] // 0x0000000189B0C350-0x0000000189B0C390
	public static new ReplaceEventPatternMixin ParseFromJson(JSONNode node) => default; // 0x0000000185949230-0x0000000185949480
	// [XID] // 0x0000000189B166B0-0x0000000189B166D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C2A */, bool useObjectPool = false /* Metadata: 0x00AF5C2E */) => default; // 0x0000000185948D10-0x0000000185949010
	// [XID] // 0x0000000189B1DD70-0x0000000189B1DD90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C2F */, bool useObjectPool = false /* Metadata: 0x00AF5C33 */) => default; // 0x0000000185947D50-0x0000000185948060
	// [XID] // 0x0000000189B255A0-0x0000000189B255C0
	public static new ReplaceEventPatternMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C34 */, bool useObjectPool = false /* Metadata: 0x00AF5C38 */) => default; // 0x00000001859485F0-0x0000000185948810
	[BlackList] // 0x0000000189B2CAF0-0x0000000189B2CB30
	// [XID] // 0x0000000189B2CAF0-0x0000000189B2CB30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001859475B0-0x0000000185947880
	// [XID] // 0x0000000189B37050-0x0000000189B37070
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185949690-0x0000000185949980
	[BlackList] // 0x0000000189B3E900-0x0000000189B3E940
	// [XID] // 0x0000000189B3E900-0x0000000189B3E940
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185948C20-0x0000000185948D10
	// [XID] // 0x0000000189B495E0-0x0000000189B49600
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000185949010-0x00000001859490F0
	[BlackList] // 0x0000000189B58430-0x0000000189B58470
	// [XID] // 0x0000000189B58430-0x0000000189B58470
	public override void AutoAllocTypeFields() {} // 0x0000000185947880-0x0000000185947920
	[BlackList] // 0x0000000189B62780-0x0000000189B627C0
	// [XID] // 0x0000000189B62780-0x0000000189B627C0
	public override void AutoRecycleTypeFields() {} // 0x0000000185947920-0x00000001859479D0
	[BlackList] // 0x0000000189B6D000-0x0000000189B6D040
	// [XID] // 0x0000000189B6D000-0x0000000189B6D040
	public override void ReturnToObjectPool() {} // 0x0000000185949A90-0x0000000185949B30
}

