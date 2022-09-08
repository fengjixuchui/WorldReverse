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
public class IndicatorConditionKilled : IndicatorCondition, IAutoAllocRecycle // TypeDefIndex: 18487
{
	// Constructors
	public IndicatorConditionKilled() {} // 0x0000000182F4D860-0x0000000182F4D8C0

	// Methods
	// [XID] // 0x0000000189BA9660-0x0000000189BA9680
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182F4D630-0x0000000182F4D6E0
	// [XID] // 0x0000000189BB0E70-0x0000000189BB0E90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182F4D360-0x0000000182F4D410
	// [XID] // 0x0000000189BB8060-0x0000000189BB8080
	public override IndicatorCondition Clone(bool useObjectPool = false /* Metadata: 0x00AF9F0D */) => default; // 0x0000000182F4CEE0-0x0000000182F4CFC0
	// [XID] // 0x0000000189BBF750-0x0000000189BBF770
	public override int GetHashNum() => default; // 0x0000000182F4BEC0-0x0000000182F4BF90
	// [XID] // 0x0000000189BC73A0-0x0000000189BC73C0
	public override void InitEmpty() {} // 0x0000000182F4C8B0-0x0000000182F4C950
	[BlackList] // 0x0000000189BCF070-0x0000000189BCF0B0
	// [XID] // 0x0000000189BCF070-0x0000000189BCF0B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182F4C2A0-0x0000000182F4C620
	// [XID] // 0x0000000189BD9520-0x0000000189BD9540
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182F4B8A0-0x0000000182F4B990
	[BlackList] // 0x00000001895E60B0-0x00000001895E60F0
	// [XID] // 0x00000001895E60B0-0x00000001895E60F0
	public static new IndicatorConditionKilled ParseFromJson(JSONNode node) => default; // 0x0000000182F4D0B0-0x0000000182F4D300
	// [XID] // 0x00000001895F08E0-0x00000001895F0900
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F0E */, bool useObjectPool = false /* Metadata: 0x00AF9F12 */) => default; // 0x0000000182F4CBE0-0x0000000182F4CEE0
	// [XID] // 0x00000001895F8270-0x00000001895F8290
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F13 */, bool useObjectPool = false /* Metadata: 0x00AF9F17 */) => default; // 0x0000000182F4C070-0x0000000182F4C1A0
	// [XID] // 0x00000001895FF810-0x00000001895FF830
	public static new IndicatorConditionKilled ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F18 */, bool useObjectPool = false /* Metadata: 0x00AF9F1C */) => default; // 0x0000000182F4C620-0x0000000182F4C840
	[BlackList] // 0x0000000189606F40-0x0000000189606F80
	// [XID] // 0x0000000189606F40-0x0000000189606F80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182F4B990-0x0000000182F4BC60
	// [XID] // 0x0000000189611960-0x0000000189611980
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182F4D410-0x0000000182F4D500
	[BlackList] // 0x0000000189619280-0x00000001896192C0
	// [XID] // 0x0000000189619280-0x00000001896192C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182F4CAF0-0x0000000182F4CBE0
	// [XID] // 0x0000000189623580-0x00000001896235A0
	public override bool Register(LCIndicatorPlugin plugin, int state, int index, LCIndicatorPlugin.DominatorCondition condition) => default; // 0x0000000182F4D500-0x0000000182F4D630
	// [XID] // 0x000000018962AE40-0x000000018962AE60
	public override bool OnTriggered(LCIndicatorPlugin plugin, int state, BaseEvent fromEvent) => default; // 0x0000000182F4D6E0-0x0000000182F4D7C0
	[BlackList] // 0x0000000189632520-0x0000000189632560
	// [XID] // 0x0000000189632520-0x0000000189632560
	public override void AutoAllocTypeFields() {} // 0x0000000182F4BC60-0x0000000182F4BD00
	[BlackList] // 0x000000018963D110-0x000000018963D150
	// [XID] // 0x000000018963D110-0x000000018963D150
	public override void AutoRecycleTypeFields() {} // 0x0000000182F4BD00-0x0000000182F4BDA0
	[BlackList] // 0x00000001896476D0-0x0000000189647710
	// [XID] // 0x00000001896476D0-0x0000000189647710
	public override void ReturnToObjectPool() {} // 0x0000000182F4D7C0-0x0000000182F4D860
}

