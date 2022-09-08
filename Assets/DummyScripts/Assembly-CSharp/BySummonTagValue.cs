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
public class BySummonTagValue : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17268
{
	// Fields
	private SimpleSafeUInt32 summonTagRawNum; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicInt _value; // 0x28

	// Properties
	public uint summonTag { /* [XID] */ /* 0x00000001897C1DD0-0x00000001897C1DF0 */ get => default; /* [XID] */ /* 0x00000001897C9720-0x00000001897C9740 */ private set {} } // 0x00000001843CCB40-0x00000001843CCC10 0x00000001843CB600-0x00000001843CB6E0
	public DynamicInt value { /* [XID] */ /* 0x00000001897D0CB0-0x00000001897D0CD0 */ get => default; /* [XID] */ /* 0x00000001897D8B50-0x00000001897D8B70 */ private set {} } // 0x00000001843CBD70-0x00000001843CBE10 0x00000001843CBC40-0x00000001843CBCF0

	// Constructors
	public BySummonTagValue() {} // 0x00000001843CD4F0-0x00000001843CD550

	// Methods
	// [XID] // 0x00000001897DFD90-0x00000001897DFDB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001843CD330-0x00000001843CD450
	// [XID] // 0x00000001897E7350-0x00000001897E7370
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001843CCEC0-0x00000001843CCFA0
	// [XID] // 0x00000001897EF070-0x00000001897EF090
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF68CB */) => default; // 0x00000001843CCA00-0x00000001843CCAE0
	// [XID] // 0x00000001897F6700-0x00000001897F6720
	public override int GetHashNum() => default; // 0x00000001843CB4D0-0x00000001843CB5A0
	// [XID] // 0x00000001897FDDA0-0x00000001897FDDC0
	public override void InitEmpty() {} // 0x00000001843CC420-0x00000001843CC530
	[BlackList] // 0x0000000189805570-0x00000001898055B0
	// [XID] // 0x0000000189805570-0x00000001898055B0
	public override bool FromJson(JSONNode node) => default; // 0x00000001843CBE10-0x00000001843CC190
	// [XID] // 0x000000018980FFD0-0x000000018980FFF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001843CAB70-0x00000001843CAED0
	[BlackList] // 0x0000000189817540-0x0000000189817580
	// [XID] // 0x0000000189817540-0x0000000189817580
	public static new BySummonTagValue ParseFromJson(JSONNode node) => default; // 0x00000001843CCC10-0x00000001843CCE60
	// [XID] // 0x0000000189821F30-0x0000000189821F50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68CC */, bool useObjectPool = false /* Metadata: 0x00AF68D0 */) => default; // 0x00000001843CC700-0x00000001843CCA00
	// [XID] // 0x0000000189829410-0x0000000189829430
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68D1 */, bool useObjectPool = false /* Metadata: 0x00AF68D5 */) => default; // 0x00000001843CB760-0x00000001843CBA90
	// [XID] // 0x0000000189830AA0-0x0000000189830AC0
	public static new BySummonTagValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF68D6 */, bool useObjectPool = false /* Metadata: 0x00AF68DA */) => default; // 0x00000001843CC190-0x00000001843CC3B0
	[BlackList] // 0x0000000189838080-0x00000001898380C0
	// [XID] // 0x0000000189838080-0x00000001898380C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001843CAED0-0x00000001843CB1A0
	// [XID] // 0x0000000189842840-0x0000000189842860
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001843CD050-0x00000001843CD330
	[BlackList] // 0x0000000189849B50-0x0000000189849B90
	// [XID] // 0x0000000189849B50-0x0000000189849B90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001843CC610-0x00000001843CC700
	// [XID] // 0x0000000189853C20-0x0000000189853C40
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001843CBA90-0x00000001843CBBC0
	[BlackList] // 0x000000018985B690-0x000000018985B6D0
	// [XID] // 0x000000018985B690-0x000000018985B6D0
	public override void AutoAllocTypeFields() {} // 0x00000001843CB1A0-0x00000001843CB240
	[BlackList] // 0x00000001898658B0-0x00000001898658F0
	// [XID] // 0x00000001898658B0-0x00000001898658F0
	public override void AutoRecycleTypeFields() {} // 0x00000001843CB240-0x00000001843CB3B0
	[BlackList] // 0x000000018986FDC0-0x000000018986FE00
	// [XID] // 0x000000018986FDC0-0x000000018986FE00
	public override void ReturnToObjectPool() {} // 0x00000001843CD450-0x00000001843CD4F0
}

