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
public class ConfigRuleCullingDistance : ConfigAudioEventCullingRuleBase, IAutoAllocRecycle // TypeDefIndex: 17573
{
	// Fields
	private SimpleSafeFloat distanceRawNum; // 0x10

	// Properties
	public float distance { /* [XID] */ /* 0x000000018982AC90-0x000000018982ACB0 */ get => default; /* [XID] */ /* 0x0000000189832130-0x0000000189832150 */ private set {} } // 0x0000000183613D00-0x0000000183613DE0 0x00000001836157D0-0x00000001836158B0

	// Constructors
	public ConfigRuleCullingDistance() {} // 0x0000000183615FA0-0x0000000183616000

	// Methods
	// [XID] // 0x0000000189839880-0x00000001898398A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183615E00-0x0000000183615F00
	// [XID] // 0x0000000189840D60-0x0000000189840D80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183615B60-0x0000000183615C10
	// [XID] // 0x0000000189848220-0x0000000189848240
	public override ConfigAudioEventCullingRuleBase Clone(bool useObjectPool = false /* Metadata: 0x00AF735B */) => default; // 0x0000000183615690-0x0000000183615770
	// [XID] // 0x000000018984F940-0x000000018984F960
	public override int GetHashNum() => default; // 0x00000001836145C0-0x0000000183614690
	// [XID] // 0x0000000189856BE0-0x0000000189856C00
	public override void InitEmpty() {} // 0x00000001836150F0-0x00000001836151C0
	[BlackList] // 0x000000018985DDB0-0x000000018985DDF0
	// [XID] // 0x000000018985DDB0-0x000000018985DDF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183614AE0-0x0000000183614E60
	// [XID] // 0x00000001898688D0-0x00000001898688F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183613DE0-0x0000000183614050
	[BlackList] // 0x000000018986FCC0-0x000000018986FD00
	// [XID] // 0x000000018986FCC0-0x000000018986FD00
	public static new ConfigRuleCullingDistance ParseFromJson(JSONNode node) => default; // 0x00000001836158B0-0x0000000183615B00
	// [XID] // 0x000000018987A8B0-0x000000018987A8D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF735C */, bool useObjectPool = false /* Metadata: 0x00AF7360 */) => default; // 0x0000000183615390-0x0000000183615690
	// [XID] // 0x0000000189881A20-0x0000000189881A40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7361 */, bool useObjectPool = false /* Metadata: 0x00AF7365 */) => default; // 0x0000000183614770-0x00000001836149E0
	// [XID] // 0x0000000189889060-0x0000000189889080
	public static new ConfigRuleCullingDistance ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7366 */, bool useObjectPool = false /* Metadata: 0x00AF736A */) => default; // 0x0000000183614E60-0x0000000183615080
	[BlackList] // 0x00000001898903C0-0x0000000189890400
	// [XID] // 0x00000001898903C0-0x0000000189890400
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183614050-0x0000000183614320
	// [XID] // 0x000000018989ABB0-0x000000018989ABD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183615C10-0x0000000183615E00
	[BlackList] // 0x00000001898A1DE0-0x00000001898A1E20
	// [XID] // 0x00000001898A1DE0-0x00000001898A1E20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001836152A0-0x0000000183615390
	[BlackList] // 0x00000001898AC580-0x00000001898AC5C0
	// [XID] // 0x00000001898AC580-0x00000001898AC5C0
	public override void AutoAllocTypeFields() {} // 0x0000000183614320-0x00000001836143C0
	[BlackList] // 0x00000001898B6D50-0x00000001898B6D90
	// [XID] // 0x00000001898B6D50-0x00000001898B6D90
	public override void AutoRecycleTypeFields() {} // 0x00000001836143C0-0x00000001836144A0
	[BlackList] // 0x00000001898C1560-0x00000001898C15A0
	// [XID] // 0x00000001898C1560-0x00000001898C15A0
	public override void ReturnToObjectPool() {} // 0x0000000183615F00-0x0000000183615FA0
}

