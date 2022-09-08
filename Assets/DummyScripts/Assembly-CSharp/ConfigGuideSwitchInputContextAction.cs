/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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
public class ConfigGuideSwitchInputContextAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18336
{
	// Fields
	private string[] _inputEventList; // 0x18
	private string[] _contextEventList; // 0x20
	private SimpleSafeInt32[] _inputPriorityList; // 0x28

	// Properties
	public string[] inputEventList { /* [XID] */ /* 0x0000000189A45680-0x0000000189A456A0 */ get => default; /* [XID] */ /* 0x0000000189A4CC20-0x0000000189A4CC40 */ private set {} } // 0x0000000184BF0870-0x0000000184BF0910 0x0000000184BEFE30-0x0000000184BEFEE0
	public string[] contextEventList { /* [XID] */ /* 0x0000000189A544F0-0x0000000189A54510 */ get => default; /* [XID] */ /* 0x0000000189A5BFE0-0x0000000189A5C000 */ private set {} } // 0x0000000184BF13E0-0x0000000184BF1480 0x0000000184BEF7E0-0x0000000184BEF890
	public SimpleSafeInt32[] inputPriorityList { /* [XID] */ /* 0x0000000189A63850-0x0000000189A63870 */ get => default; /* [XID] */ /* 0x0000000189A6B0F0-0x0000000189A6B110 */ private set {} } // 0x0000000184BF1480-0x0000000184BF1520 0x0000000184BEF540-0x0000000184BEF5F0

	// Constructors
	public ConfigGuideSwitchInputContextAction() {} // 0x0000000184BF1B10-0x0000000184BF1B70

	// Methods
	// [XID] // 0x0000000189A72900-0x0000000189A72920
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184BF1940-0x0000000184BF1A70
	// [XID] // 0x0000000189A7A430-0x0000000189A7A450
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184BF12D0-0x0000000184BF13E0
	// [XID] // 0x0000000189A818F0-0x0000000189A81910
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF948B */) => default; // 0x0000000184BF0EE0-0x0000000184BF0FC0
	// [XID] // 0x0000000189A89430-0x0000000189A89450
	public override int GetHashNum() => default; // 0x0000000184BEF710-0x0000000184BEF7E0
	// [XID] // 0x0000000189A90C90-0x0000000189A90CB0
	public override void InitEmpty() {} // 0x0000000184BF06F0-0x0000000184BF07F0
	[BlackList] // 0x0000000189A98420-0x0000000189A98460
	// [XID] // 0x0000000189A98420-0x0000000189A98460
	public override bool FromJson(JSONNode node) => default; // 0x0000000184BF00E0-0x0000000184BF0460
	// [XID] // 0x0000000189AA26A0-0x0000000189AA26C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184BEED30-0x0000000184BEF120
	[BlackList] // 0x0000000189AA9C00-0x0000000189AA9C40
	// [XID] // 0x0000000189AA9C00-0x0000000189AA9C40
	public static new ConfigGuideSwitchInputContextAction ParseFromJson(JSONNode node) => default; // 0x0000000184BF1020-0x0000000184BF1270
	// [XID] // 0x0000000189AB47F0-0x0000000189AB4810
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF948C */, bool useObjectPool = false /* Metadata: 0x00AF9490 */) => default; // 0x0000000184BF0BE0-0x0000000184BF0EE0
	// [XID] // 0x0000000189ABC560-0x0000000189ABC580
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9491 */, bool useObjectPool = false /* Metadata: 0x00AF9495 */) => default; // 0x0000000184BEFA80-0x0000000184BEFE30
	// [XID] // 0x0000000189AC3F20-0x0000000189AC3F40
	public static new ConfigGuideSwitchInputContextAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9496 */, bool useObjectPool = false /* Metadata: 0x00AF949A */) => default; // 0x0000000184BF0460-0x0000000184BF0680
	[BlackList] // 0x0000000189ACB330-0x0000000189ACB370
	// [XID] // 0x0000000189ACB330-0x0000000189ACB370
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184BEF120-0x0000000184BEF3F0
	// [XID] // 0x0000000189AD61E0-0x0000000189AD6200
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184BF15A0-0x0000000184BF1940
	[BlackList] // 0x0000000189ADDB60-0x0000000189ADDBA0
	// [XID] // 0x0000000189ADDB60-0x0000000189ADDBA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184BF09E0-0x0000000184BF0AD0
	// [XID] // 0x0000000189AE8090-0x0000000189AE80B0
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x0000000184BEF970-0x0000000184BEFA80
	[DebuggerHidden] // 0x0000000189AEFEF0-0x0000000189AEFF30
	// [XID] // 0x0000000189AEFEF0-0x0000000189AEFF30
	private IEnumerator SwitchInputContextToCustom() => default; // 0x0000000184BF0AD0-0x0000000184BF0BE0
	// [XID] // 0x0000000189AFA560-0x0000000189AFA580
	protected override bool Stop() => default; // 0x0000000184BEEC30-0x0000000184BEED30
	[DebuggerHidden] // 0x0000000189B01A90-0x0000000189B01AD0
	// [XID] // 0x0000000189B01A90-0x0000000189B01AD0
	private IEnumerator SwitchInputContextBack() => default; // 0x0000000184BEFEE0-0x0000000184BEFFE0
	[BlackList] // 0x0000000189B0C050-0x0000000189B0C090
	// [XID] // 0x0000000189B0C050-0x0000000189B0C090
	public override void AutoAllocTypeFields() {} // 0x0000000184BEF3F0-0x0000000184BEF490
	[BlackList] // 0x0000000189B16370-0x0000000189B163B0
	// [XID] // 0x0000000189B16370-0x0000000189B163B0
	public override void AutoRecycleTypeFields() {} // 0x0000000184BEF490-0x0000000184BEF540
	[BlackList] // 0x0000000189B20A90-0x0000000189B20AD0
	// [XID] // 0x0000000189B20A90-0x0000000189B20AD0
	public override void ReturnToObjectPool() {} // 0x0000000184BF1A70-0x0000000184BF1B10
}

