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
public class ByBigTeamHasBodyType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17314
{
	// Fields
	private string _bodyType; // 0x18
	private SimpleSafeUInt32 numberRawNum; // 0x20
	private RelationalOperator _logic; // 0x24

	// Properties
	public string bodyType { /* [XID] */ /* 0x0000000189706060-0x0000000189706080 */ get => default; /* [XID] */ /* 0x000000018970D8F0-0x000000018970D910 */ private set {} } // 0x00000001827B3060-0x00000001827B3100 0x00000001827B3710-0x00000001827B37C0
	public uint number { /* [XID] */ /* 0x0000000189714D90-0x0000000189714DB0 */ get => default; /* [XID] */ /* 0x000000018971C860-0x000000018971C880 */ private set {} } // 0x00000001827B1910-0x00000001827B19E0 0x00000001827B3240-0x00000001827B3320
	public RelationalOperator logic { /* [XID] */ /* 0x0000000189723CF0-0x0000000189723D10 */ get => default; /* [XID] */ /* 0x000000018972B430-0x000000018972B450 */ private set {} } // 0x00000001827B2D70-0x00000001827B2E10 0x00000001827B2530-0x00000001827B25E0

	// Constructors
	public ByBigTeamHasBodyType() {} // 0x00000001827B3990-0x00000001827B39F0

	// Methods
	// [XID] // 0x0000000189732CA0-0x0000000189732CC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001827B37C0-0x00000001827B38F0
	// [XID] // 0x000000018973A390-0x000000018973A3B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001827B3160-0x00000001827B3240
	// [XID] // 0x0000000189741DC0-0x0000000189741DE0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6A3B */) => default; // 0x00000001827B2C30-0x00000001827B2D10
	// [XID] // 0x0000000189749780-0x00000001897497A0
	public override int GetHashNum() => default; // 0x00000001827B1760-0x00000001827B1830
	// [XID] // 0x0000000189750C40-0x0000000189750C60
	public override void InitEmpty() {} // 0x00000001827B2650-0x00000001827B2760
	[BlackList] // 0x0000000189758030-0x0000000189758070
	// [XID] // 0x0000000189758030-0x0000000189758070
	public override bool FromJson(JSONNode node) => default; // 0x00000001827B1F90-0x00000001827B2310
	// [XID] // 0x0000000189762AD0-0x0000000189762AF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001827B0DC0-0x00000001827B11F0
	[BlackList] // 0x000000018976A110-0x000000018976A150
	// [XID] // 0x000000018976A110-0x000000018976A150
	public static new ByBigTeamHasBodyType ParseFromJson(JSONNode node) => default; // 0x00000001827B2E10-0x00000001827B3060
	// [XID] // 0x0000000189774530-0x0000000189774550
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A3C */, bool useObjectPool = false /* Metadata: 0x00AF6A40 */) => default; // 0x00000001827B2930-0x00000001827B2C30
	// [XID] // 0x000000018977BF40-0x000000018977BF60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A41 */, bool useObjectPool = false /* Metadata: 0x00AF6A45 */) => default; // 0x00000001827B19E0-0x00000001827B1D60
	// [XID] // 0x00000001897837F0-0x0000000189783810
	public static new ByBigTeamHasBodyType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A46 */, bool useObjectPool = false /* Metadata: 0x00AF6A4A */) => default; // 0x00000001827B2310-0x00000001827B2530
	[BlackList] // 0x000000018978AFC0-0x000000018978B000
	// [XID] // 0x000000018978AFC0-0x000000018978B000
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001827B11F0-0x00000001827B14C0
	// [XID] // 0x0000000189795460-0x0000000189795480
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001827B33D0-0x00000001827B3710
	[BlackList] // 0x000000018979D810-0x000000018979D850
	// [XID] // 0x000000018979D810-0x000000018979D850
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001827B2840-0x00000001827B2930
	// [XID] // 0x00000001897A7940-0x00000001897A7960
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001827B1D60-0x00000001827B1E90
	[BlackList] // 0x00000001897AF3F0-0x00000001897AF430
	// [XID] // 0x00000001897AF3F0-0x00000001897AF430
	public override void AutoAllocTypeFields() {} // 0x00000001827B14C0-0x00000001827B1560
	[BlackList] // 0x00000001897B9C90-0x00000001897B9CD0
	// [XID] // 0x00000001897B9C90-0x00000001897B9CD0
	public override void AutoRecycleTypeFields() {} // 0x00000001827B1560-0x00000001827B1640
	[BlackList] // 0x00000001897C4B20-0x00000001897C4B60
	// [XID] // 0x00000001897C4B20-0x00000001897C4B60
	public override void ReturnToObjectPool() {} // 0x00000001827B38F0-0x00000001827B3990
}

