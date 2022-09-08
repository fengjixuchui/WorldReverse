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
public class ConfigGadgetCollidedPattern : ConfigGadgetPattern, IAutoAllocRecycle // TypeDefIndex: 18092
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigBaseGadgetTriggerAction[] _collisionActions; // 0x18
	private string _thisColliderName; // 0x20
	private string _targetColliderName; // 0x28

	// Properties
	public ConfigBaseGadgetTriggerAction[] collisionActions { /* [XID] */ /* 0x00000001898A1D80-0x00000001898A1DA0 */ get => default; /* [XID] */ /* 0x00000001898A95F0-0x00000001898A9610 */ private set {} } // 0x00000001853A99A0-0x00000001853A9A40 0x00000001853A8150-0x00000001853A8200
	public string thisColliderName { /* [XID] */ /* 0x00000001898B0E40-0x00000001898B0E60 */ get => default; /* [XID] */ /* 0x00000001898B84E0-0x00000001898B8500 */ private set {} } // 0x00000001853A93E0-0x00000001853A9480 0x00000001853A8890-0x00000001853A8940
	public string targetColliderName { /* [XID] */ /* 0x0000000189BDD2F0-0x0000000189BDD310 */ get => default; /* [XID] */ /* 0x00000001898C7580-0x00000001898C75A0 */ private set {} } // 0x00000001853A7C50-0x00000001853A7CF0 0x00000001853A98F0-0x00000001853A99A0

	// Constructors
	public ConfigGadgetCollidedPattern() {} // 0x00000001853A9AE0-0x00000001853A9B60

	// Methods
	// [XID] // 0x00000001898CEB90-0x00000001898CEBB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001853A97C0-0x00000001853A98F0
	// [XID] // 0x00000001898D65A0-0x00000001898D65C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001853A92D0-0x00000001853A93E0
	// [XID] // 0x00000001898DE200-0x00000001898DE220
	public override ConfigGadgetPattern Clone(bool useObjectPool = false /* Metadata: 0x00AF8AAD */) => default; // 0x00000001853A8EE0-0x00000001853A8FC0
	// [XID] // 0x00000001898E59C0-0x00000001898E59E0
	public override int GetHashNum() => default; // 0x00000001853A7B20-0x00000001853A7BF0
	// [XID] // 0x00000001898ED3C0-0x00000001898ED3E0
	public override void InitEmpty() {} // 0x00000001853A8940-0x00000001853A8A10
	[BlackList] // 0x00000001898F4BA0-0x00000001898F4BE0
	// [XID] // 0x00000001898F4BA0-0x00000001898F4BE0
	public override bool FromJson(JSONNode node) => default; // 0x00000001853A8280-0x00000001853A8600
	// [XID] // 0x00000001898FF3B0-0x00000001898FF3D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001853A7220-0x00000001853A75D0
	[BlackList] // 0x0000000189906B70-0x0000000189906BB0
	// [XID] // 0x0000000189906B70-0x0000000189906BB0
	public static new ConfigGadgetCollidedPattern ParseFromJson(JSONNode node) => default; // 0x00000001853A9020-0x00000001853A9270
	// [XID] // 0x0000000189911320-0x0000000189911340
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AAE */, bool useObjectPool = false /* Metadata: 0x00AF8AB2 */) => default; // 0x00000001853A8BE0-0x00000001853A8EE0
	// [XID] // 0x0000000189918EC0-0x0000000189918EE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AB3 */, bool useObjectPool = false /* Metadata: 0x00AF8AB7 */) => default; // 0x00000001853A7D70-0x00000001853A80D0
	// [XID] // 0x0000000189920530-0x0000000189920550
	public static new ConfigGadgetCollidedPattern ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AB8 */, bool useObjectPool = false /* Metadata: 0x00AF8ABC */) => default; // 0x00000001853A8600-0x00000001853A8820
	[BlackList] // 0x0000000189927E30-0x0000000189927E70
	// [XID] // 0x0000000189927E30-0x0000000189927E70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001853A75D0-0x00000001853A78A0
	// [XID] // 0x0000000189932460-0x0000000189932480
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001853A9480-0x00000001853A97C0
	[BlackList] // 0x0000000189939E70-0x0000000189939EB0
	// [XID] // 0x0000000189939E70-0x0000000189939EB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001853A8AF0-0x00000001853A8BE0
	[BlackList] // 0x0000000189944400-0x0000000189944440
	// [XID] // 0x0000000189944400-0x0000000189944440
	public override void AutoAllocTypeFields() {} // 0x00000001853A78A0-0x00000001853A7940
	[BlackList] // 0x000000018994E960-0x000000018994E9A0
	// [XID] // 0x000000018994E960-0x000000018994E9A0
	public override void AutoRecycleTypeFields() {} // 0x00000001853A7940-0x00000001853A7A00
	[BlackList] // 0x0000000189959050-0x0000000189959090
	// [XID] // 0x0000000189959050-0x0000000189959090
	public override void ReturnToObjectPool() {} // 0x00000001853A9A40-0x00000001853A9AE0
}

