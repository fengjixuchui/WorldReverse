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
public class ByTargetLayoutArea : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17352
{
	// Fields
	private JsonClimateType _areaType; // 0x18
	private JsonClimateType _climateType; // 0x1C
	private SimpleSafeUInt32 areaIDRawNum; // 0x20

	// Properties
	public JsonClimateType areaType { /* [XID] */ /* 0x00000001897C9700-0x00000001897C9720 */ get => default; /* [XID] */ /* 0x00000001897D0C90-0x00000001897D0CB0 */ private set {} } // 0x0000000184D20A30-0x0000000184D20AD0 0x0000000184D1FAD0-0x0000000184D1FB80
	public JsonClimateType climateType { /* [XID] */ /* 0x00000001897D8B30-0x00000001897D8B50 */ get => default; /* [XID] */ /* 0x00000001897DFD70-0x00000001897DFD90 */ private set {} } // 0x0000000184D20190-0x0000000184D20230 0x0000000184D20300-0x0000000184D203B0
	public uint areaID { /* [XID] */ /* 0x00000001897E7330-0x00000001897E7350 */ get => default; /* [XID] */ /* 0x00000001897EF030-0x00000001897EF050 */ private set {} } // 0x0000000184D20230-0x0000000184D20300 0x0000000184D1F970-0x0000000184D1FA50

	// Constructors
	public ByTargetLayoutArea() {} // 0x0000000184D21450-0x0000000184D214B0

	// Methods
	// [XID] // 0x00000001897F66C0-0x00000001897F66E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184D21280-0x0000000184D213B0
	// [XID] // 0x00000001897FDD60-0x00000001897FDD80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184D20DE0-0x0000000184D20E90
	// [XID] // 0x0000000189805510-0x0000000189805530
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6B5F */) => default; // 0x0000000184D20950-0x0000000184D20A30
	// [XID] // 0x000000018980CAD0-0x000000018980CAF0
	public override int GetHashNum() => default; // 0x0000000184D1F2C0-0x0000000184D1F390
	// [XID] // 0x00000001898142F0-0x0000000189814310
	public override void InitEmpty() {} // 0x0000000184D203B0-0x0000000184D20480
	[BlackList] // 0x000000018981BE60-0x000000018981BEA0
	// [XID] // 0x000000018981BE60-0x000000018981BEA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184D1FB80-0x0000000184D1FF00
	// [XID] // 0x0000000189826390-0x00000001898263B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184D1E930-0x0000000184D1ED50
	[BlackList] // 0x000000018982D9C0-0x000000018982DA00
	// [XID] // 0x000000018982D9C0-0x000000018982DA00
	public static new ByTargetLayoutArea ParseFromJson(JSONNode node) => default; // 0x0000000184D20B30-0x0000000184D20D80
	// [XID] // 0x0000000189838020-0x0000000189838040
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B60 */, bool useObjectPool = false /* Metadata: 0x00AF6B64 */) => default; // 0x0000000184D20650-0x0000000184D20950
	// [XID] // 0x000000018983F810-0x000000018983F830
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B65 */, bool useObjectPool = false /* Metadata: 0x00AF6B69 */) => default; // 0x0000000184D1F470-0x0000000184D1F7C0
	// [XID] // 0x0000000189846E30-0x0000000189846E50
	public static new ByTargetLayoutArea ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6B6A */, bool useObjectPool = false /* Metadata: 0x00AF6B6E */) => default; // 0x0000000184D1FF00-0x0000000184D20120
	[BlackList] // 0x000000018984E420-0x000000018984E460
	// [XID] // 0x000000018984E420-0x000000018984E460
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184D1ED50-0x0000000184D1F020
	// [XID] // 0x00000001898587A0-0x00000001898587C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184D20F40-0x0000000184D21280
	[BlackList] // 0x000000018985F870-0x000000018985F8B0
	// [XID] // 0x000000018985F870-0x000000018985F8B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184D20560-0x0000000184D20650
	// [XID] // 0x000000018986A0E0-0x000000018986A100
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000184D1F7C0-0x0000000184D1F8F0
	[BlackList] // 0x0000000189871430-0x0000000189871470
	// [XID] // 0x0000000189871430-0x0000000189871470
	public override void AutoAllocTypeFields() {} // 0x0000000184D1F020-0x0000000184D1F0C0
	[BlackList] // 0x000000018987BCE0-0x000000018987BD20
	// [XID] // 0x000000018987BCE0-0x000000018987BD20
	public override void AutoRecycleTypeFields() {} // 0x0000000184D1F0C0-0x0000000184D1F1A0
	[BlackList] // 0x00000001898861E0-0x0000000189886220
	// [XID] // 0x00000001898861E0-0x0000000189886220
	public override void ReturnToObjectPool() {} // 0x0000000184D213B0-0x0000000184D21450
}

