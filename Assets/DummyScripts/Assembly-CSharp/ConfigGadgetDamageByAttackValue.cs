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
public class ConfigGadgetDamageByAttackValue : ConfigBaseGadgetTriggerAction, IAutoAllocRecycle // TypeDefIndex: 14953
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAttackInfo _attackInfo; // 0x18

	// Properties
	public ConfigBornType born { /* [XID] */ /* 0x00000001896F7810-0x00000001896F7830 */ get => default; /* [XID] */ /* 0x00000001896FF210-0x00000001896FF230 */ private set {} } // 0x0000000182B577F0-0x0000000182B57890 0x0000000182B592E0-0x0000000182B59390
	public ConfigAttackInfo attackInfo { /* [XID] */ /* 0x0000000189706500-0x0000000189706520 */ get => default; /* [XID] */ /* 0x000000018970DE30-0x000000018970DE50 */ private set {} } // 0x0000000182B58960-0x0000000182B58A00 0x0000000182B56700-0x0000000182B567B0

	// Constructors
	public ConfigGadgetDamageByAttackValue() {} // 0x0000000182B594D0-0x0000000182B59530

	// Methods
	// [XID] // 0x00000001896EFE00-0x00000001896EFE20
	public override void DoTriggerAction(LCGadgetCombat gadgetCombat, uint otherID, int actionIdx) {} // 0x0000000182B567B0-0x0000000182B56DD0
	// [XID] // 0x00000001897152B0-0x00000001897152D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B591D0-0x0000000182B592E0
	// [XID] // 0x000000018971CDC0-0x000000018971CDE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182B58DF0-0x0000000182B58EF0
	// [XID] // 0x0000000189724170-0x0000000189724190
	public override ConfigBaseGadgetTriggerAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFBBD */) => default; // 0x0000000182B58A00-0x0000000182B58AE0
	// [XID] // 0x000000018972B8D0-0x000000018972B8F0
	public override int GetHashNum() => default; // 0x0000000182B57720-0x0000000182B577F0
	// [XID] // 0x00000001897330A0-0x00000001897330C0
	public override void InitEmpty() {} // 0x0000000182B583A0-0x0000000182B58490
	[BlackList] // 0x000000018973A7D0-0x000000018973A810
	// [XID] // 0x000000018973A7D0-0x000000018973A810
	public override bool FromJson(JSONNode node) => default; // 0x0000000182B57D90-0x0000000182B58110
	// [XID] // 0x0000000189745230-0x0000000189745250
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182B56DD0-0x0000000182B570E0
	[BlackList] // 0x000000018974CCE0-0x000000018974CD20
	// [XID] // 0x000000018974CCE0-0x000000018974CD20
	public static new ConfigGadgetDamageByAttackValue ParseFromJson(JSONNode node) => default; // 0x0000000182B58B40-0x0000000182B58D90
	// [XID] // 0x0000000189757180-0x00000001897571A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBBE */, bool useObjectPool = false /* Metadata: 0x00AEFBC2 */) => default; // 0x0000000182B58660-0x0000000182B58960
	// [XID] // 0x000000018975E770-0x000000018975E790
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBC3 */, bool useObjectPool = false /* Metadata: 0x00AEFBC7 */) => default; // 0x0000000182B57970-0x0000000182B57C90
	// [XID] // 0x0000000189765D10-0x0000000189765D30
	public static new ConfigGadgetDamageByAttackValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBC8 */, bool useObjectPool = false /* Metadata: 0x00AEFBCC */) => default; // 0x0000000182B58110-0x0000000182B58330
	[BlackList] // 0x000000018976D520-0x000000018976D560
	// [XID] // 0x000000018976D520-0x000000018976D560
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B570E0-0x0000000182B573B0
	// [XID] // 0x0000000189777A90-0x0000000189777AB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B58EF0-0x0000000182B591D0
	[BlackList] // 0x000000018977F1A0-0x000000018977F1E0
	// [XID] // 0x000000018977F1A0-0x000000018977F1E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182B58570-0x0000000182B58660
	[BlackList] // 0x0000000189789940-0x0000000189789980
	// [XID] // 0x0000000189789940-0x0000000189789980
	public override void AutoAllocTypeFields() {} // 0x0000000182B573B0-0x0000000182B57450
	[BlackList] // 0x0000000189793D80-0x0000000189793DC0
	// [XID] // 0x0000000189793D80-0x0000000189793DC0
	public override void AutoRecycleTypeFields() {} // 0x0000000182B57450-0x0000000182B57600
	[BlackList] // 0x000000018979F110-0x000000018979F150
	// [XID] // 0x000000018979F110-0x000000018979F150
	public override void ReturnToObjectPool() {} // 0x0000000182B59430-0x0000000182B594D0
}

