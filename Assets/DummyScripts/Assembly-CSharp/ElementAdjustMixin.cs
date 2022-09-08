/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ElementAdjustMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17084
{
	// Fields
	private SimpleSafeFloat changeIntervalRawNum; // 0x30
	private Dictionary<ElementType, string> _elementModifies; // 0x38

	// Properties
	public float changeInterval { /* [XID] */ /* 0x000000018975FBD0-0x000000018975FBF0 */ get => default; /* [XID] */ /* 0x00000001897672C0-0x00000001897672E0 */ private set {} } // 0x0000000184386BA0-0x0000000184386C80 0x00000001843862C0-0x00000001843863A0
	public Dictionary<ElementType, string> elementModifies { /* [XID] */ /* 0x000000018976E7A0-0x000000018976E7C0 */ get => default; /* [XID] */ /* 0x00000001897761C0-0x00000001897761E0 */ private set {} } // 0x0000000184386840-0x00000001843868E0 0x0000000184386400-0x00000001843864B0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001897FB430-0x00000001897FB450 */ get => default; } // 0x0000000184385370-0x0000000184385410 

	// Constructors
	public ElementAdjustMixin() {} // 0x0000000184386E30-0x0000000184386E90

	// Methods
	// [XID] // 0x000000018977D8C0-0x000000018977D8E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184386C80-0x0000000184386D90
	// [XID] // 0x0000000189785100-0x0000000189785120
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184386760-0x0000000184386840
	// [XID] // 0x000000018978C610-0x000000018978C630
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6293 */) => default; // 0x00000001843861E0-0x00000001843862C0
	// [XID] // 0x0000000189793B20-0x0000000189793B40
	public override int GetHashNum() => default; // 0x0000000184384DB0-0x0000000184384E80
	// [XID] // 0x000000018979BD90-0x000000018979BDB0
	public override void InitEmpty() {} // 0x0000000184385B20-0x0000000184385C30
	[BlackList] // 0x00000001897A31E0-0x00000001897A3220
	// [XID] // 0x00000001897A31E0-0x00000001897A3220
	public override bool FromJson(JSONNode node) => default; // 0x0000000184385410-0x0000000184385790
	// [XID] // 0x00000001897AD9B0-0x00000001897AD9D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001843844E0-0x0000000184384840
	[BlackList] // 0x00000001897B5AB0-0x00000001897B5AF0
	// [XID] // 0x00000001897B5AB0-0x00000001897B5AF0
	public static new ElementAdjustMixin ParseFromJson(JSONNode node) => default; // 0x00000001843864B0-0x0000000184386700
	// [XID] // 0x00000001897C0800-0x00000001897C0820
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6294 */, bool useObjectPool = false /* Metadata: 0x00AF6298 */) => default; // 0x0000000184385E00-0x0000000184386100
	// [XID] // 0x00000001897C80D0-0x00000001897C80F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6299 */, bool useObjectPool = false /* Metadata: 0x00AF629D */) => default; // 0x0000000184384F60-0x0000000184385270
	// [XID] // 0x00000001897CF450-0x00000001897CF470
	public static new ElementAdjustMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF629E */, bool useObjectPool = false /* Metadata: 0x00AF62A2 */) => default; // 0x0000000184385800-0x0000000184385A20
	[BlackList] // 0x00000001897D6D00-0x00000001897D6D40
	// [XID] // 0x00000001897D6D00-0x00000001897D6D40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184384840-0x0000000184384B10
	// [XID] // 0x00000001897E15C0-0x00000001897E15E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001843868E0-0x0000000184386BA0
	[BlackList] // 0x00000001897E8E30-0x00000001897E8E70
	// [XID] // 0x00000001897E8E30-0x00000001897E8E70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184385D10-0x0000000184385E00
	// [XID] // 0x00000001897F3A30-0x00000001897F3A50
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184386100-0x00000001843861E0
	[BlackList] // 0x00000001898027C0-0x0000000189802800
	// [XID] // 0x00000001898027C0-0x0000000189802800
	public override void AutoAllocTypeFields() {} // 0x0000000184384B10-0x0000000184384BB0
	[BlackList] // 0x000000018980CB10-0x000000018980CB50
	// [XID] // 0x000000018980CB10-0x000000018980CB50
	public override void AutoRecycleTypeFields() {} // 0x0000000184384BB0-0x0000000184384C90
	[BlackList] // 0x0000000189817580-0x00000001898175C0
	// [XID] // 0x0000000189817580-0x00000001898175C0
	public override void ReturnToObjectPool() {} // 0x0000000184386D90-0x0000000184386E30
}

