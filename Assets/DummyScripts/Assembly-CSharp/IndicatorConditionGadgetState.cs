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
public class IndicatorConditionGadgetState : IndicatorCondition, IAutoAllocRecycle // TypeDefIndex: 18479
{
	// Fields
	private SimpleSafeInt32 fromStateRawNum; // 0x10
	private SimpleSafeInt32 toStateRawNum; // 0x14

	// Properties
	public int fromState { /* [XID] */ /* 0x00000001898801E0-0x0000000189880200 */ get => default; /* [XID] */ /* 0x0000000189887700-0x0000000189887720 */ private set {} } // 0x00000001851A3020-0x00000001851A30F0 0x00000001851A3DE0-0x00000001851A3EC0
	public int toState { /* [XID] */ /* 0x000000018988EA20-0x000000018988EA40 */ get => default; /* [XID] */ /* 0x0000000189895EC0-0x0000000189895EE0 */ private set {} } // 0x00000001851A28B0-0x00000001851A2980 0x00000001851A37D0-0x00000001851A38B0

	// Constructors
	public IndicatorConditionGadgetState() {} // 0x00000001851A4610-0x00000001851A46B0

	// Methods
	// [XID] // 0x000000018989D500-0x000000018989D520
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851A42F0-0x00000001851A4400
	// [XID] // 0x00000001898A4E80-0x00000001898A4EA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001851A3D30-0x00000001851A3DE0
	// [XID] // 0x00000001898AC380-0x00000001898AC3A0
	public override IndicatorCondition Clone(bool useObjectPool = false /* Metadata: 0x00AF9ECD */) => default; // 0x00000001851A38B0-0x00000001851A3990
	// [XID] // 0x00000001898B39C0-0x00000001898B39E0
	public override int GetHashNum() => default; // 0x00000001851A2460-0x00000001851A2530
	// [XID] // 0x00000001898BB7B0-0x00000001898BB7D0
	public override void InitEmpty() {} // 0x00000001851A3160-0x00000001851A3240
	[BlackList] // 0x00000001898C2A00-0x00000001898C2A40
	// [XID] // 0x00000001898C2A00-0x00000001898C2A40
	public override bool FromJson(JSONNode node) => default; // 0x00000001851A2A80-0x00000001851A2E00
	// [XID] // 0x00000001898CD2C0-0x00000001898CD2E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001851A1BB0-0x00000001851A1EF0
	[BlackList] // 0x00000001898D4B70-0x00000001898D4BB0
	// [XID] // 0x00000001898D4B70-0x00000001898D4BB0
	public static new IndicatorConditionGadgetState ParseFromJson(JSONNode node) => default; // 0x00000001851A3A80-0x00000001851A3CD0
	// [XID] // 0x00000001898DF920-0x00000001898DF940
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9ECE */, bool useObjectPool = false /* Metadata: 0x00AF9ED2 */) => default; // 0x00000001851A34D0-0x00000001851A37D0
	// [XID] // 0x00000001898E7430-0x00000001898E7450
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9ED3 */, bool useObjectPool = false /* Metadata: 0x00AF9ED7 */) => default; // 0x00000001851A2610-0x00000001851A28B0
	// [XID] // 0x00000001898EEC20-0x00000001898EEC40
	public static new IndicatorConditionGadgetState ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9ED8 */, bool useObjectPool = false /* Metadata: 0x00AF9EDC */) => default; // 0x00000001851A2E00-0x00000001851A3020
	[BlackList] // 0x00000001898F6460-0x00000001898F64A0
	// [XID] // 0x00000001898F6460-0x00000001898F64A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001851A1EF0-0x00000001851A21C0
	// [XID] // 0x0000000189900DF0-0x0000000189900E10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851A3EC0-0x00000001851A41B0
	[BlackList] // 0x0000000189908590-0x00000001899085D0
	// [XID] // 0x0000000189908590-0x00000001899085D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851A33E0-0x00000001851A34D0
	// [XID] // 0x0000000189913040-0x0000000189913060
	public override bool Register(LCIndicatorPlugin plugin, int state, int index, LCIndicatorPlugin.DominatorCondition condition) => default; // 0x00000001851A41B0-0x00000001851A42F0
	// [XID] // 0x000000018991A7F0-0x000000018991A810
	public override bool OnTriggered(LCIndicatorPlugin plugin, int state, BaseEvent fromEvent) => default; // 0x00000001851A4400-0x00000001851A4570
	[BlackList] // 0x0000000189921FE0-0x0000000189922020
	// [XID] // 0x0000000189921FE0-0x0000000189922020
	public override void AutoAllocTypeFields() {} // 0x00000001851A21C0-0x00000001851A2260
	[BlackList] // 0x000000018992C500-0x000000018992C540
	// [XID] // 0x000000018992C500-0x000000018992C540
	public override void AutoRecycleTypeFields() {} // 0x00000001851A2260-0x00000001851A2340
	[BlackList] // 0x00000001899368B0-0x00000001899368F0
	// [XID] // 0x00000001899368B0-0x00000001899368F0
	public override void ReturnToObjectPool() {} // 0x00000001851A4570-0x00000001851A4610
}

