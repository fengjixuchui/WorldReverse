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
public class ByUnlockTalentParam : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17252
{
	// Fields
	private string _talentParam; // 0x18

	// Properties
	public string talentParam { /* [XID] */ /* 0x000000018987D980-0x000000018987D9A0 */ get => default; /* [XID] */ /* 0x00000001898848B0-0x00000001898848D0 */ private set {} } // 0x000000018384D750-0x000000018384D7F0 0x000000018384E4D0-0x000000018384E580

	// Constructors
	public ByUnlockTalentParam() {} // 0x000000018384F430-0x000000018384F490

	// Methods
	// [XID] // 0x000000018988BEE0-0x000000018988BF00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018384F2A0-0x000000018384F390
	// [XID] // 0x0000000189893530-0x0000000189893550
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018384EF10-0x000000018384EFF0
	// [XID] // 0x000000018989AC30-0x000000018989AC50
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF684F */) => default; // 0x000000018384EB20-0x000000018384EC00
	// [XID] // 0x00000001898A1F60-0x00000001898A1F80
	public override int GetHashNum() => default; // 0x000000018384D870-0x000000018384D940
	// [XID] // 0x00000001898A9730-0x00000001898A9750
	public override void InitEmpty() {} // 0x000000018384E580-0x000000018384E650
	[BlackList] // 0x00000001898B0F20-0x00000001898B0F60
	// [XID] // 0x00000001898B0F20-0x00000001898B0F60
	public override bool FromJson(JSONNode node) => default; // 0x000000018384DEC0-0x000000018384E240
	// [XID] // 0x00000001898BB950-0x00000001898BB970
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018384D060-0x000000018384D290
	[BlackList] // 0x00000001898C2C80-0x00000001898C2CC0
	// [XID] // 0x00000001898C2C80-0x00000001898C2CC0
	public static new ByUnlockTalentParam ParseFromJson(JSONNode node) => default; // 0x000000018384EC60-0x000000018384EEB0
	// [XID] // 0x00000001898CD4C0-0x00000001898CD4E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6850 */, bool useObjectPool = false /* Metadata: 0x00AF6854 */) => default; // 0x000000018384E820-0x000000018384EB20
	// [XID] // 0x00000001898D4E90-0x00000001898D4EB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6855 */, bool useObjectPool = false /* Metadata: 0x00AF6859 */) => default; // 0x000000018384DA20-0x000000018384DC90
	// [XID] // 0x00000001898DC850-0x00000001898DC870
	public static new ByUnlockTalentParam ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF685A */, bool useObjectPool = false /* Metadata: 0x00AF685E */) => default; // 0x000000018384E240-0x000000018384E460
	[BlackList] // 0x00000001898E4240-0x00000001898E4280
	// [XID] // 0x00000001898E4240-0x00000001898E4280
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018384D290-0x000000018384D560
	// [XID] // 0x00000001898EEE00-0x00000001898EEE20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018384F0A0-0x000000018384F2A0
	[BlackList] // 0x00000001898F6740-0x00000001898F6780
	// [XID] // 0x00000001898F6740-0x00000001898F6780
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018384E730-0x000000018384E820
	// [XID] // 0x0000000189900FF0-0x0000000189901010
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x000000018384DC90-0x000000018384DDC0
	[BlackList] // 0x00000001899088B0-0x00000001899088F0
	// [XID] // 0x00000001899088B0-0x00000001899088F0
	public override void AutoAllocTypeFields() {} // 0x000000018384D560-0x000000018384D600
	[BlackList] // 0x00000001899131C0-0x0000000189913200
	// [XID] // 0x00000001899131C0-0x0000000189913200
	public override void AutoRecycleTypeFields() {} // 0x000000018384D600-0x000000018384D6B0
	[BlackList] // 0x000000018991D950-0x000000018991D990
	// [XID] // 0x000000018991D950-0x000000018991D990
	public override void ReturnToObjectPool() {} // 0x000000018384F390-0x000000018384F430
}

