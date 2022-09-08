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
public class BySelfForwardAndTargetPosition : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17264
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x20
	private bool _isXZ; // 0x28

	// Properties
	public DynamicFloat value { /* [XID] */ /* 0x0000000189640010-0x0000000189640030 */ get => default; /* [XID] */ /* 0x0000000189647930-0x0000000189647950 */ private set {} } // 0x0000000184B29E70-0x0000000184B29F10 0x0000000184B29D40-0x0000000184B29DF0
	public bool isXZ { /* [XID] */ /* 0x000000018964EF40-0x000000018964EF60 */ get => default; /* [XID] */ /* 0x0000000189656790-0x00000001896567B0 */ private set {} } // 0x0000000184B2A6D0-0x0000000184B2A770 0x0000000184B2B0E0-0x0000000184B2B190

	// Constructors
	public BySelfForwardAndTargetPosition() {} // 0x0000000184B2B600-0x0000000184B2B670

	// Methods
	// [XID] // 0x000000018965DEF0-0x000000018965DF10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B2B440-0x0000000184B2B560
	// [XID] // 0x0000000189665630-0x0000000189665650
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184B2AF50-0x0000000184B2B030
	// [XID] // 0x000000018966CD60-0x000000018966CD80
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF68AB */) => default; // 0x0000000184B2AB60-0x0000000184B2AC40
	// [XID] // 0x0000000189674C10-0x0000000189674C30
	public override int GetHashNum() => default; // 0x0000000184B296D0-0x0000000184B297A0
	// [XID] // 0x000000018967C480-0x000000018967C4A0
	public override void InitEmpty() {} // 0x0000000184B2A520-0x0000000184B2A5F0
	[BlackList] // 0x0000000189683AF0-0x0000000189683B30
	// [XID] // 0x0000000189683AF0-0x0000000189683B30
	public override bool FromJson(JSONNode node) => default; // 0x0000000184B29F10-0x0000000184B2A290
	// [XID] // 0x000000018968E950-0x000000018968E970
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184B28E00-0x0000000184B29110
	[BlackList] // 0x00000001896963F0-0x0000000189696430
	// [XID] // 0x00000001896963F0-0x0000000189696430
	public static new BySelfForwardAndTargetPosition ParseFromJson(JSONNode node) => default; // 0x0000000184B2ACA0-0x0000000184B2AEF0
	// [XID] // 0x00000001896A05B0-0x00000001896A05D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68AC */, bool useObjectPool = false /* Metadata: 0x00AF68B0 */) => default; // 0x0000000184B2A860-0x0000000184B2AB60
	// [XID] // 0x00000001896A7AE0-0x00000001896A7B00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68B1 */, bool useObjectPool = false /* Metadata: 0x00AF68B5 */) => default; // 0x0000000184B29880-0x0000000184B29B90
	// [XID] // 0x00000001896AEEB0-0x00000001896AEED0
	public static new BySelfForwardAndTargetPosition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68B6 */, bool useObjectPool = false /* Metadata: 0x00AF68BA */) => default; // 0x0000000184B2A290-0x0000000184B2A4B0
	[BlackList] // 0x00000001896B6540-0x00000001896B6580
	// [XID] // 0x00000001896B6540-0x00000001896B6580
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B29110-0x0000000184B293E0
	// [XID] // 0x00000001896C0720-0x00000001896C0740
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B2B190-0x0000000184B2B440
	[BlackList] // 0x00000001896C7E50-0x00000001896C7E90
	// [XID] // 0x00000001896C7E50-0x00000001896C7E90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184B2A770-0x0000000184B2A860
	// [XID] // 0x00000001896D2260-0x00000001896D2280
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000184B29B90-0x0000000184B29CC0
	[BlackList] // 0x00000001896D9BF0-0x00000001896D9C30
	// [XID] // 0x00000001896D9BF0-0x00000001896D9C30
	public override void AutoAllocTypeFields() {} // 0x0000000184B293E0-0x0000000184B29480
	[BlackList] // 0x00000001896E4210-0x00000001896E4250
	// [XID] // 0x00000001896E4210-0x00000001896E4250
	public override void AutoRecycleTypeFields() {} // 0x0000000184B29480-0x0000000184B295B0
	[BlackList] // 0x00000001896EE3D0-0x00000001896EE410
	// [XID] // 0x00000001896EE3D0-0x00000001896EE410
	public override void ReturnToObjectPool() {} // 0x0000000184B2B560-0x0000000184B2B600
}

