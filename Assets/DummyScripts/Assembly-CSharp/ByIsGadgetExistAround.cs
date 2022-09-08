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
public class ByIsGadgetExistAround : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17354
{
	// Fields
	private SimpleSafeUInt32[] _gadgetIdArray; // 0x18
	private bool _trunToTarget; // 0x20

	// Properties
	public SimpleSafeUInt32[] gadgetIdArray { /* [XID] */ /* 0x00000001898979E0-0x0000000189897A00 */ get => default; /* [XID] */ /* 0x000000018989EE00-0x000000018989EE20 */ private set {} } // 0x0000000182DB0360-0x0000000182DB0400 0x0000000182DB0400-0x0000000182DB04B0
	public bool trunToTarget { /* [XID] */ /* 0x00000001898A68C0-0x00000001898A68E0 */ get => default; /* [XID] */ /* 0x00000001898AE010-0x00000001898AE030 */ private set {} } // 0x0000000182DB19E0-0x0000000182DB1A80 0x0000000182DB2040-0x0000000182DB20F0

	// Constructors
	public ByIsGadgetExistAround() {} // 0x0000000182DB2190-0x0000000182DB21F0

	// Methods
	// [XID] // 0x00000001898B5570-0x00000001898B5590
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182DB1F30-0x0000000182DB2040
	// [XID] // 0x00000001898BCF80-0x00000001898BCFA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182DB1AE0-0x0000000182DB1BC0
	// [XID] // 0x00000001898C4700-0x00000001898C4720
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6B6F */) => default; // 0x0000000182DB1650-0x0000000182DB1730
	// [XID] // 0x00000001898CBD30-0x00000001898CBD50
	public override int GetHashNum() => default; // 0x0000000182DB0290-0x0000000182DB0360
	// [XID] // 0x00000001898D35F0-0x00000001898D3610
	public override void InitEmpty() {} // 0x0000000182DB10B0-0x0000000182DB1180
	[BlackList] // 0x00000001898DAD80-0x00000001898DADC0
	// [XID] // 0x00000001898DAD80-0x00000001898DADC0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182DB0AA0-0x0000000182DB0E20
	// [XID] // 0x00000001898E5C20-0x00000001898E5C40
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182DAFA60-0x0000000182DAFD50
	[BlackList] // 0x00000001898ED540-0x00000001898ED580
	// [XID] // 0x00000001898ED540-0x00000001898ED580
	public static new ByIsGadgetExistAround ParseFromJson(JSONNode node) => default; // 0x0000000182DB1790-0x0000000182DB19E0
	// [XID] // 0x00000001898F7F70-0x00000001898F7F90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B70 */, bool useObjectPool = false /* Metadata: 0x00AF6B74 */) => default; // 0x0000000182DB1350-0x0000000182DB1650
	// [XID] // 0x00000001898FF5F0-0x00000001898FF610
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B75 */, bool useObjectPool = false /* Metadata: 0x00AF6B79 */) => default; // 0x0000000182DB0590-0x0000000182DB0870
	// [XID] // 0x0000000189906DB0-0x0000000189906DD0
	public static new ByIsGadgetExistAround ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B7A */, bool useObjectPool = false /* Metadata: 0x00AF6B7E */) => default; // 0x0000000182DB0E20-0x0000000182DB1040
	[BlackList] // 0x000000018990E7D0-0x000000018990E810
	// [XID] // 0x000000018990E7D0-0x000000018990E810
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182DAFD50-0x0000000182DB0020
	// [XID] // 0x0000000189919120-0x0000000189919140
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182DB1C70-0x0000000182DB1F30
	[BlackList] // 0x0000000189920690-0x00000001899206D0
	// [XID] // 0x0000000189920690-0x00000001899206D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182DB1260-0x0000000182DB1350
	// [XID] // 0x000000018992AF80-0x000000018992AFA0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182DB0870-0x0000000182DB09A0
	[BlackList] // 0x0000000189932600-0x0000000189932640
	// [XID] // 0x0000000189932600-0x0000000189932640
	public override void AutoAllocTypeFields() {} // 0x0000000182DB0020-0x0000000182DB00C0
	[BlackList] // 0x000000018993CEB0-0x000000018993CEF0
	// [XID] // 0x000000018993CEB0-0x000000018993CEF0
	public override void AutoRecycleTypeFields() {} // 0x0000000182DB00C0-0x0000000182DB0170
	[BlackList] // 0x00000001899473C0-0x0000000189947400
	// [XID] // 0x00000001899473C0-0x0000000189947400
	public override void ReturnToObjectPool() {} // 0x0000000182DB20F0-0x0000000182DB2190
}

