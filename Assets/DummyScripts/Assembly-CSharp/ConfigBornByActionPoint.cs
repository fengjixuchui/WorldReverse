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
public class ConfigBornByActionPoint : ConfigBornType, IAutoAllocRecycle // TypeDefIndex: 17895
{
	// Fields
	private ActionPointType _actionPointType; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigActionPointSelectType _selectType; // 0x40

	// Properties
	public ActionPointType actionPointType { /* [XID] */ /* 0x00000001899771A0-0x00000001899771C0 */ get => default; /* [XID] */ /* 0x000000018997E540-0x000000018997E560 */ private set {} } // 0x0000000183763930-0x00000001837639D0 0x00000001837643A0-0x0000000183764450
	public ConfigActionPointSelectType selectType { /* [XID] */ /* 0x0000000189985FD0-0x0000000189985FF0 */ get => default; /* [XID] */ /* 0x000000018998DC60-0x000000018998DC80 */ private set {} } // 0x00000001837639D0-0x0000000183763A70 0x0000000183764590-0x0000000183764640

	// Constructors
	public ConfigBornByActionPoint() {} // 0x0000000183764AB0-0x0000000183764B10

	// Methods
	// [XID] // 0x0000000189995710-0x0000000189995730
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837648F0-0x0000000183764A10
	// [XID] // 0x000000018999D110-0x000000018999D130
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001837644B0-0x0000000183764590
	// [XID] // 0x00000001899A4A70-0x00000001899A4A90
	public override ConfigBornType Clone(bool useObjectPool = false /* Metadata: 0x00AF8079 */) => default; // 0x0000000183764010-0x00000001837640F0
	// [XID] // 0x00000001899AC530-0x00000001899AC550
	public override int GetHashNum() => default; // 0x0000000183762D90-0x0000000183762E60
	// [XID] // 0x00000001899B3CC0-0x00000001899B3CE0
	public override void InitEmpty() {} // 0x0000000183763A70-0x0000000183763B40
	[BlackList] // 0x00000001899BB0D0-0x00000001899BB110
	// [XID] // 0x00000001899BB0D0-0x00000001899BB110
	public override bool FromJson(JSONNode node) => default; // 0x0000000183763320-0x00000001837636A0
	// [XID] // 0x00000001899C5BB0-0x00000001899C5BD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001837624C0-0x00000001837627D0
	[BlackList] // 0x00000001899CD210-0x00000001899CD250
	// [XID] // 0x00000001899CD210-0x00000001899CD250
	public static new ConfigBornByActionPoint ParseFromJson(JSONNode node) => default; // 0x0000000183764150-0x00000001837643A0
	// [XID] // 0x00000001899D7770-0x00000001899D7790
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF807A */, bool useObjectPool = false /* Metadata: 0x00AF807E */) => default; // 0x0000000183763D10-0x0000000183764010
	// [XID] // 0x00000001899DEBD0-0x00000001899DEBF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF807F */, bool useObjectPool = false /* Metadata: 0x00AF8083 */) => default; // 0x0000000183762F40-0x0000000183763220
	// [XID] // 0x00000001899E67F0-0x00000001899E6810
	public static new ConfigBornByActionPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8084 */, bool useObjectPool = false /* Metadata: 0x00AF8088 */) => default; // 0x00000001837636A0-0x00000001837638C0
	[BlackList] // 0x00000001899EDDC0-0x00000001899EDE00
	// [XID] // 0x00000001899EDDC0-0x00000001899EDE00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001837627D0-0x0000000183762AA0
	// [XID] // 0x00000001899F84D0-0x00000001899F84F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183764640-0x00000001837648F0
	[BlackList] // 0x00000001899FFAA0-0x00000001899FFAE0
	// [XID] // 0x00000001899FFAA0-0x00000001899FFAE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183763C20-0x0000000183763D10
	[BlackList] // 0x0000000189A0A200-0x0000000189A0A240
	// [XID] // 0x0000000189A0A200-0x0000000189A0A240
	public override void AutoAllocTypeFields() {} // 0x0000000183762AA0-0x0000000183762B40
	[BlackList] // 0x0000000189A14A20-0x0000000189A14A60
	// [XID] // 0x0000000189A14A20-0x0000000189A14A60
	public override void AutoRecycleTypeFields() {} // 0x0000000183762B40-0x0000000183762C70
	[BlackList] // 0x0000000189A1ECD0-0x0000000189A1ED10
	// [XID] // 0x0000000189A1ECD0-0x0000000189A1ED10
	public override void ReturnToObjectPool() {} // 0x0000000183764A10-0x0000000183764AB0
}

