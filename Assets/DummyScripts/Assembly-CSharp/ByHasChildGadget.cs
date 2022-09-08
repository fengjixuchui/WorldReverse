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
public class ByHasChildGadget : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17350
{
	// Fields
	private SimpleSafeUInt32[] _configIdArray; // 0x18
	private SimpleSafeUInt32 valueRawNum; // 0x20
	private RelationType _compareType; // 0x24
	private bool _forceByCaster; // 0x28
	private bool _checkEntityAlive; // 0x29

	// Properties
	public SimpleSafeUInt32[] configIdArray { /* [XID] */ /* 0x00000001896DB200-0x00000001896DB220 */ get => default; /* [XID] */ /* 0x00000001896E2980-0x00000001896E29A0 */ private set {} } // 0x0000000181B9BE20-0x0000000181B9BEC0 0x0000000181B9B6D0-0x0000000181B9B780
	public uint value { /* [XID] */ /* 0x00000001896E9F40-0x00000001896E9F60 */ get => default; /* [XID] */ /* 0x00000001896F1020-0x00000001896F1040 */ private set {} } // 0x0000000181B9C1D0-0x0000000181B9C2A0 0x0000000181B9C070-0x0000000181B9C150
	public RelationType compareType { /* [XID] */ /* 0x00000001896F88A0-0x00000001896F88C0 */ get => default; /* [XID] */ /* 0x0000000189700180-0x00000001897001A0 */ private set {} } // 0x0000000181B9CF40-0x0000000181B9CFE0 0x0000000181B9B780-0x0000000181B9B830
	public bool forceByCaster { /* [XID] */ /* 0x00000001897078F0-0x0000000189707910 */ get => default; /* [XID] */ /* 0x000000018970F360-0x000000018970F380 */ private set {} } // 0x0000000181B9DBF0-0x0000000181B9DC90 0x0000000181B9C8B0-0x0000000181B9C960
	public bool checkEntityAlive { /* [XID] */ /* 0x00000001897166C0-0x00000001897166E0 */ get => default; /* [XID] */ /* 0x000000018971E160-0x000000018971E180 */ private set {} } // 0x0000000181B9B890-0x0000000181B9B930 0x0000000181B9D4B0-0x0000000181B9D560

	// Constructors
	public ByHasChildGadget() {} // 0x0000000181B9DD30-0x0000000181B9DD90

	// Methods
	// [XID] // 0x00000001897256E0-0x0000000189725700
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181B9DA90-0x0000000181B9DBF0
	// [XID] // 0x000000018972CC00-0x000000018972CC20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181B9D3D0-0x0000000181B9D4B0
	// [XID] // 0x0000000189734410-0x0000000189734430
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6B4F */) => default; // 0x0000000181B9CFE0-0x0000000181B9D0C0
	// [XID] // 0x000000018973BD00-0x000000018973BD20
	public override int GetHashNum() => default; // 0x0000000181B9B600-0x0000000181B9B6D0
	// [XID] // 0x00000001897435F0-0x0000000189743610
	public override void InitEmpty() {} // 0x0000000181B9C960-0x0000000181B9CA70
	[BlackList] // 0x000000018974B280-0x000000018974B2C0
	// [XID] // 0x000000018974B280-0x000000018974B2C0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181B9C2A0-0x0000000181B9C620
	// [XID] // 0x0000000189755730-0x0000000189755750
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181B9AAF0-0x0000000181B9B080
	[BlackList] // 0x000000018975C9D0-0x000000018975CA10
	// [XID] // 0x000000018975C9D0-0x000000018975CA10
	public static new ByHasChildGadget ParseFromJson(JSONNode node) => default; // 0x0000000181B9D120-0x0000000181B9D370
	// [XID] // 0x0000000189767280-0x00000001897672A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B50 */, bool useObjectPool = false /* Metadata: 0x00AF6B54 */) => default; // 0x0000000181B9CC40-0x0000000181B9CF40
	// [XID] // 0x000000018976E720-0x000000018976E740
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B55 */, bool useObjectPool = false /* Metadata: 0x00AF6B59 */) => default; // 0x0000000181B9B9B0-0x0000000181B9BE20
	// [XID] // 0x0000000189776160-0x0000000189776180
	public static new ByHasChildGadget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B5A */, bool useObjectPool = false /* Metadata: 0x00AF6B5E */) => default; // 0x0000000181B9C620-0x0000000181B9C840
	[BlackList] // 0x000000018977D7C0-0x000000018977D800
	// [XID] // 0x000000018977D7C0-0x000000018977D800
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181B9B080-0x0000000181B9B350
	// [XID] // 0x0000000189787F20-0x0000000189787F40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181B9D610-0x0000000181B9DA90
	[BlackList] // 0x000000018978F520-0x000000018978F560
	// [XID] // 0x000000018978F520-0x000000018978F560
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181B9CB50-0x0000000181B9CC40
	// [XID] // 0x0000000189799B50-0x0000000189799B70
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000181B9BEC0-0x0000000181B9BFF0
	[BlackList] // 0x00000001897A1980-0x00000001897A19C0
	// [XID] // 0x00000001897A1980-0x00000001897A19C0
	public override void AutoAllocTypeFields() {} // 0x0000000181B9B350-0x0000000181B9B3F0
	[BlackList] // 0x00000001897AC120-0x00000001897AC160
	// [XID] // 0x00000001897AC120-0x00000001897AC160
	public override void AutoRecycleTypeFields() {} // 0x0000000181B9B3F0-0x0000000181B9B4E0
	[BlackList] // 0x00000001897B7250-0x00000001897B7290
	// [XID] // 0x00000001897B7250-0x00000001897B7290
	public override void ReturnToObjectPool() {} // 0x0000000181B9DC90-0x0000000181B9DD30
}

