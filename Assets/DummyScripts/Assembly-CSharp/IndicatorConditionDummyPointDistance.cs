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
public class IndicatorConditionDummyPointDistance : IndicatorCondition, IAutoAllocRecycle // TypeDefIndex: 18483
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private TemplateParamString _key; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private TemplateParamFloat _distance; // 0x18

	// Properties
	public TemplateParamString key { /* [XID] */ /* 0x0000000189A11A80-0x0000000189A11AA0 */ get => default; /* [XID] */ /* 0x0000000189A18CD0-0x0000000189A18CF0 */ private set {} } // 0x00000001841E1170-0x00000001841E1210 0x00000001841E29E0-0x00000001841E2A90
	public TemplateParamFloat distance { /* [XID] */ /* 0x0000000189A203B0-0x0000000189A203D0 */ get => default; /* [XID] */ /* 0x0000000189A277E0-0x0000000189A27800 */ private set {} } // 0x00000001841E0670-0x00000001841E0710 0x00000001841E26E0-0x00000001841E2790
	public override bool TimeCheck { /* [XID] */ /* 0x0000000189AA40C0-0x0000000189AA40E0 */ get => default; } // 0x00000001841E1270-0x00000001841E1310 

	// Constructors
	public IndicatorConditionDummyPointDistance() {} // 0x00000001841E3450-0x00000001841E34B0

	// Methods
	// [XID] // 0x0000000189A2EF10-0x0000000189A2EF30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841E2FE0-0x00000001841E30F0
	// [XID] // 0x0000000189A368D0-0x0000000189A368F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001841E2AF0-0x00000001841E2BF0
	// [XID] // 0x0000000189A3DE70-0x0000000189A3DE90
	public override IndicatorCondition Clone(bool useObjectPool = false /* Metadata: 0x00AF9EED */) => default; // 0x00000001841E2510-0x00000001841E25F0
	// [XID] // 0x0000000189A45600-0x0000000189A45620
	public override int GetHashNum() => default; // 0x00000001841E10A0-0x00000001841E1170
	// [XID] // 0x0000000189A4CBE0-0x0000000189A4CC00
	public override void InitEmpty() {} // 0x00000001841E1E20-0x00000001841E1F10
	[BlackList] // 0x0000000189A54490-0x0000000189A544D0
	// [XID] // 0x0000000189A54490-0x0000000189A544D0
	public override bool FromJson(JSONNode node) => default; // 0x00000001841E1810-0x00000001841E1B90
	// [XID] // 0x0000000189A5EEB0-0x0000000189A5EED0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001841E0710-0x00000001841E0A60
	[BlackList] // 0x0000000189A667C0-0x0000000189A66800
	// [XID] // 0x0000000189A667C0-0x0000000189A66800
	public static new IndicatorConditionDummyPointDistance ParseFromJson(JSONNode node) => default; // 0x00000001841E2790-0x00000001841E29E0
	// [XID] // 0x0000000189A70EE0-0x0000000189A70F00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EEE */, bool useObjectPool = false /* Metadata: 0x00AF9EF2 */) => default; // 0x00000001841E2210-0x00000001841E2510
	// [XID] // 0x0000000189A78A20-0x0000000189A78A40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EF3 */, bool useObjectPool = false /* Metadata: 0x00AF9EF7 */) => default; // 0x00000001841E1390-0x00000001841E1710
	// [XID] // 0x0000000189A7FDE0-0x0000000189A7FE00
	public static new IndicatorConditionDummyPointDistance ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9EF8 */, bool useObjectPool = false /* Metadata: 0x00AF9EFC */) => default; // 0x00000001841E1B90-0x00000001841E1DB0
	[BlackList] // 0x0000000189A87B80-0x0000000189A87BC0
	// [XID] // 0x0000000189A87B80-0x0000000189A87BC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001841E0A60-0x00000001841E0D30
	// [XID] // 0x0000000189A92350-0x0000000189A92370
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841E2BF0-0x00000001841E2ED0
	[BlackList] // 0x0000000189A99CC0-0x0000000189A99D00
	// [XID] // 0x0000000189A99CC0-0x0000000189A99D00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001841E20B0-0x00000001841E21A0
	// [XID] // 0x0000000189AAB590-0x0000000189AAB5B0
	public override bool Register(LCIndicatorPlugin plugin, int state, int index, LCIndicatorPlugin.DominatorCondition condition) => default; // 0x00000001841E2ED0-0x00000001841E2FE0
	// [XID] // 0x0000000189AB2EC0-0x0000000189AB2EE0
	public override bool OnTriggered(LCIndicatorPlugin plugin, int state, BaseEvent fromEvent) => default; // 0x00000001841E30F0-0x00000001841E33B0
	[BlackList] // 0x0000000189ABABD0-0x0000000189ABAC10
	// [XID] // 0x0000000189ABABD0-0x0000000189ABAC10
	public override void AutoAllocTypeFields() {} // 0x00000001841E0D30-0x00000001841E0DD0
	[BlackList] // 0x0000000189AC5570-0x0000000189AC55B0
	// [XID] // 0x0000000189AC5570-0x0000000189AC55B0
	public override void AutoRecycleTypeFields() {} // 0x00000001841E0DD0-0x00000001841E0F80
	[BlackList] // 0x0000000189ACFAD0-0x0000000189ACFB10
	// [XID] // 0x0000000189ACFAD0-0x0000000189ACFB10
	public override void ReturnToObjectPool() {} // 0x00000001841E33B0-0x00000001841E3450
}

