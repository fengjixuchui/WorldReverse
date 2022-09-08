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
public class ConfigProgressBillboard : ConfigBillboard, IAutoAllocRecycle // TypeDefIndex: 17716
{
	// Fields
	private string _customKey; // 0x40
	private SimpleSafeFloat maxValueRawNum; // 0x48
	private string _prefabPluginName; // 0x50

	// Properties
	public string customKey { /* [XID] */ /* 0x000000018996B070-0x000000018996B090 */ get => default; /* [XID] */ /* 0x0000000189972B10-0x0000000189972B30 */ private set {} } // 0x0000000184483C60-0x0000000184483D00 0x0000000184483680-0x0000000184483730
	public float maxValue { /* [XID] */ /* 0x000000018997A3B0-0x000000018997A3D0 */ get => default; /* [XID] */ /* 0x0000000189981B60-0x0000000189981B80 */ private set {} } // 0x00000001844833A0-0x0000000184483480 0x0000000184482750-0x0000000184482830
	public string prefabPluginName { /* [XID] */ /* 0x0000000189989500-0x0000000189989520 */ get => default; /* [XID] */ /* 0x0000000189990D30-0x0000000189990D50 */ private set {} } // 0x00000001844826B0-0x0000000184482750 0x0000000184482530-0x00000001844825E0

	// Constructors
	public ConfigProgressBillboard() {} // 0x00000001844845A0-0x0000000184484630

	// Methods
	// [XID] // 0x0000000189998830-0x0000000189998850
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001844843D0-0x0000000184484500
	// [XID] // 0x00000001899A0110-0x00000001899A0130
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184483FB0-0x00000001844840B0
	// [XID] // 0x00000001899A7C80-0x00000001899A7CA0
	public override ConfigBillboard Clone(bool useObjectPool = false /* Metadata: 0x00AF78BD */) => default; // 0x0000000184483B20-0x0000000184483C00
	// [XID] // 0x00000001899AF410-0x00000001899AF430
	public override int GetHashNum() => default; // 0x00000001844825E0-0x00000001844826B0
	// [XID] // 0x00000001899B68D0-0x00000001899B68F0
	public override void InitEmpty() {} // 0x0000000184483480-0x00000001844835A0
	[BlackList] // 0x00000001899BE3F0-0x00000001899BE430
	// [XID] // 0x00000001899BE3F0-0x00000001899BE430
	public override bool FromJson(JSONNode node) => default; // 0x0000000184482D90-0x0000000184483110
	// [XID] // 0x00000001899C8960-0x00000001899C8980
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184481BA0-0x0000000184481FC0
	[BlackList] // 0x00000001899D0310-0x00000001899D0350
	// [XID] // 0x00000001899D0310-0x00000001899D0350
	public static new ConfigProgressBillboard ParseFromJson(JSONNode node) => default; // 0x0000000184483D00-0x0000000184483F50
	// [XID] // 0x00000001899DA6E0-0x00000001899DA700
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF78BE */, bool useObjectPool = false /* Metadata: 0x00AF78C2 */) => default; // 0x0000000184483820-0x0000000184483B20
	// [XID] // 0x00000001899E2100-0x00000001899E2120
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF78C3 */, bool useObjectPool = false /* Metadata: 0x00AF78C7 */) => default; // 0x0000000184482910-0x0000000184482C90
	// [XID] // 0x00000001899E95E0-0x00000001899E9600
	public static new ConfigProgressBillboard ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF78C8 */, bool useObjectPool = false /* Metadata: 0x00AF78CC */) => default; // 0x0000000184483110-0x0000000184483330
	[BlackList] // 0x00000001899F0C30-0x00000001899F0C70
	// [XID] // 0x00000001899F0C30-0x00000001899F0C70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184481FC0-0x0000000184482290
	// [XID] // 0x00000001899FB890-0x00000001899FB8B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001844840B0-0x00000001844843D0
	[BlackList] // 0x0000000189A02B30-0x0000000189A02B70
	// [XID] // 0x0000000189A02B30-0x0000000189A02B70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184483730-0x0000000184483820
	[BlackList] // 0x0000000189A0D200-0x0000000189A0D240
	// [XID] // 0x0000000189A0D200-0x0000000189A0D240
	public override void AutoAllocTypeFields() {} // 0x0000000184482290-0x0000000184482330
	[BlackList] // 0x0000000189A17530-0x0000000189A17570
	// [XID] // 0x0000000189A17530-0x0000000189A17570
	public override void AutoRecycleTypeFields() {} // 0x0000000184482330-0x0000000184482410
	[BlackList] // 0x0000000189A21B90-0x0000000189A21BD0
	// [XID] // 0x0000000189A21B90-0x0000000189A21BD0
	public override void ReturnToObjectPool() {} // 0x0000000184484500-0x00000001844845A0
}

