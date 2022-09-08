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
public class ConfigWidgetPredict_CheckEqualDynamicValue : ConfigWidgetPredict, IAutoAllocRecycle // TypeDefIndex: 19182
{
	// Fields
	private string _key; // 0x10
	private SimpleSafeFloat valueRawNum; // 0x18

	// Properties
	public string key { /* [XID] */ /* 0x00000001898C73C0-0x00000001898C73E0 */ get => default; /* [XID] */ /* 0x00000001898CE950-0x00000001898CE970 */ private set {} } // 0x0000000183704D30-0x0000000183704DD0 0x0000000183706460-0x0000000183706510
	public float value { /* [XID] */ /* 0x00000001898D62E0-0x00000001898D6300 */ get => default; /* [XID] */ /* 0x00000001898DDF80-0x00000001898DDFA0 */ private set {} } // 0x0000000183705370-0x0000000183705450 0x0000000183705210-0x00000001837052F0

	// Constructors
	public ConfigWidgetPredict_CheckEqualDynamicValue() {} // 0x0000000183706A90-0x0000000183706B20

	// Methods
	// [XID] // 0x00000001898E5800-0x00000001898E5820
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837068E0-0x00000001837069F0
	// [XID] // 0x00000001898ED220-0x00000001898ED240
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183706570-0x0000000183706650
	// [XID] // 0x00000001898F4980-0x00000001898F49A0
	public override ConfigWidgetPredict Clone(bool useObjectPool = false /* Metadata: 0x00AFC487 */) => default; // 0x00000001837060D0-0x00000001837061B0
	// [XID] // 0x00000001898FC270-0x00000001898FC290
	public override int GetHashNum() => default; // 0x0000000183704C60-0x0000000183704D30
	// [XID] // 0x0000000189903CD0-0x0000000189903CF0
	public override void InitEmpty() {} // 0x0000000183705A60-0x0000000183705B70
	[BlackList] // 0x000000018990B210-0x000000018990B250
	// [XID] // 0x000000018990B210-0x000000018990B250
	public override bool FromJson(JSONNode node) => default; // 0x0000000183705450-0x00000001837057D0
	// [XID] // 0x0000000189915BE0-0x0000000189915C00
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001837042E0-0x0000000183704620
	[BlackList] // 0x000000018991D5B0-0x000000018991D5F0
	// [XID] // 0x000000018991D5B0-0x000000018991D5F0
	public static new ConfigWidgetPredict_CheckEqualDynamicValue ParseFromJson(JSONNode node) => default; // 0x0000000183706210-0x0000000183706460
	// [XID] // 0x0000000189927BF0-0x0000000189927C10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC488 */, bool useObjectPool = false /* Metadata: 0x00AFC48C */) => default; // 0x0000000183705D40-0x0000000183706040
	// [XID] // 0x000000018992F440-0x000000018992F460
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC48D */, bool useObjectPool = false /* Metadata: 0x00AFC491 */) => default; // 0x0000000183704EB0-0x0000000183705190
	// [XID] // 0x0000000189936790-0x00000001899367B0
	public static new ConfigWidgetPredict_CheckEqualDynamicValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC492 */, bool useObjectPool = false /* Metadata: 0x00AFC496 */) => default; // 0x00000001837057D0-0x00000001837059F0
	[BlackList] // 0x000000018993E370-0x000000018993E3B0
	// [XID] // 0x000000018993E370-0x000000018993E3B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183704620-0x00000001837048F0
	// [XID] // 0x0000000189948860-0x0000000189948880
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183706650-0x00000001837068E0
	[BlackList] // 0x000000018994FFF0-0x0000000189950030
	// [XID] // 0x000000018994FFF0-0x0000000189950030
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183705C50-0x0000000183705D40
	[BlackList] // 0x000000018995A6B0-0x000000018995A6F0
	// [XID] // 0x000000018995A6B0-0x000000018995A6F0
	public override void AutoAllocTypeFields() {} // 0x00000001837048F0-0x0000000183704990
	[BlackList] // 0x0000000189965070-0x00000001899650B0
	// [XID] // 0x0000000189965070-0x00000001899650B0
	public override void AutoRecycleTypeFields() {} // 0x0000000183704990-0x0000000183704A70
	[BlackList] // 0x000000018996F300-0x000000018996F340
	// [XID] // 0x000000018996F300-0x000000018996F340
	public override void ReturnToObjectPool() {} // 0x00000001837069F0-0x0000000183706A90
	// [XID] // 0x000000018997A170-0x000000018997A190
	public override bool DoPredict(LCWidget lcWidget, QuickWidgetGeneral widget) => default; // 0x0000000183704B90-0x0000000183704C60
}

