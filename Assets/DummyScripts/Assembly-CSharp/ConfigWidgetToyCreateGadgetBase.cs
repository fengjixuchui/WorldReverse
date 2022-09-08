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
public class ConfigWidgetToyCreateGadgetBase : ConfigBaseWidgetToy, IAutoAllocRecycle // TypeDefIndex: 19228
{
	// Fields
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x30
	private bool _isSeverGadget; // 0x34
	private bool _isSeverGadgetCoverCreate; // 0x35
	private bool _isSetCamera; // 0x36
	private SimpleSafeFloat setCameraAngleRawNum; // 0x38

	// Properties
	public uint gadgetId { /* [XID] */ /* 0x0000000189873F60-0x0000000189873F80 */ get => default; /* [XID] */ /* 0x000000018987BA20-0x000000018987BA40 */ private set {} } // 0x00000001832246B0-0x0000000183224780 0x0000000183224560-0x0000000183224640
	public bool isSeverGadget { /* [XID] */ /* 0x0000000189882B90-0x0000000189882BB0 */ get => default; /* [XID] */ /* 0x000000018988A2F0-0x000000018988A310 */ private set {} } // 0x0000000183224E30-0x0000000183224ED0 0x0000000183225A70-0x0000000183225B20
	public bool isSeverGadgetCoverCreate { /* [XID] */ /* 0x0000000189891780-0x00000001898917A0 */ get => default; /* [XID] */ /* 0x00000001898990F0-0x0000000189899110 */ private set {} } // 0x00000001832257C0-0x0000000183225860 0x00000001832259C0-0x0000000183225A70
	public bool isSetCamera { /* [XID] */ /* 0x00000001898A02D0-0x00000001898A02F0 */ get => default; /* [XID] */ /* 0x00000001898A7A30-0x00000001898A7A50 */ private set {} } // 0x0000000183223C90-0x0000000183223D30 0x0000000183224290-0x0000000183224340
	public float setCameraAngle { /* [XID] */ /* 0x00000001898AF550-0x00000001898AF570 */ get => default; /* [XID] */ /* 0x00000001898B69B0-0x00000001898B69D0 */ private set {} } // 0x0000000183225290-0x0000000183225370 0x0000000183223DB0-0x0000000183223E90

	// Constructors
	public ConfigWidgetToyCreateGadgetBase() {} // 0x0000000183225BC0-0x0000000183225C20

	// Methods
	// [XID] // 0x00000001898BE1A0-0x00000001898BE1C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183225860-0x00000001832259C0
	// [XID] // 0x00000001898C5A50-0x00000001898C5A70
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001832251E0-0x0000000183225290
	// [XID] // 0x00000001898CD1A0-0x00000001898CD1C0
	public override ConfigBaseWidgetToy Clone(bool useObjectPool = false /* Metadata: 0x00AFC5F5 */) => default; // 0x0000000183224D50-0x0000000183224E30
	// [XID] // 0x00000001898D4A90-0x00000001898D4AB0
	public override int GetHashNum() => default; // 0x0000000183223670-0x0000000183223740
	// [XID] // 0x00000001898DC4B0-0x00000001898DC4D0
	public override void InitEmpty() {} // 0x0000000183224780-0x0000000183224880
	[BlackList] // 0x00000001898E3F00-0x00000001898E3F40
	// [XID] // 0x00000001898E3F00-0x00000001898E3F40
	public override bool FromJson(JSONNode node) => default; // 0x0000000183223F10-0x0000000183224290
	// [XID] // 0x00000001898EEB20-0x00000001898EEB40
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183222B30-0x00000001832230C0
	[BlackList] // 0x00000001898F62C0-0x00000001898F6300
	// [XID] // 0x00000001898F62C0-0x00000001898F6300
	public static new ConfigWidgetToyCreateGadgetBase ParseFromJson(JSONNode node) => default; // 0x0000000183224F30-0x0000000183225180
	// [XID] // 0x0000000189900C50-0x0000000189900C70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC5F6 */, bool useObjectPool = false /* Metadata: 0x00AFC5FA */) => default; // 0x0000000183224A50-0x0000000183224D50
	// [XID] // 0x00000001899083D0-0x00000001899083F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC5FB */, bool useObjectPool = false /* Metadata: 0x00AFC5FF */) => default; // 0x0000000183223820-0x0000000183223C90
	// [XID] // 0x000000018990FB90-0x000000018990FBB0
	public static new ConfigWidgetToyCreateGadgetBase ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC600 */, bool useObjectPool = false /* Metadata: 0x00AFC604 */) => default; // 0x0000000183224340-0x0000000183224560
	[BlackList] // 0x00000001899175A0-0x00000001899175E0
	// [XID] // 0x00000001899175A0-0x00000001899175E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001832230C0-0x0000000183223390
	// [XID] // 0x0000000189921E40-0x0000000189921E60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183225370-0x00000001832257C0
	[BlackList] // 0x0000000189929620-0x0000000189929660
	// [XID] // 0x0000000189929620-0x0000000189929660
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183224960-0x0000000183224A50
	[BlackList] // 0x0000000189933940-0x0000000189933980
	// [XID] // 0x0000000189933940-0x0000000189933980
	public override void AutoAllocTypeFields() {} // 0x0000000183223390-0x0000000183223430
	[BlackList] // 0x000000018993E330-0x000000018993E370
	// [XID] // 0x000000018993E330-0x000000018993E370
	public override void AutoRecycleTypeFields() {} // 0x0000000183223430-0x0000000183223550
	[BlackList] // 0x0000000189948820-0x0000000189948860
	// [XID] // 0x0000000189948820-0x0000000189948860
	public override void ReturnToObjectPool() {} // 0x0000000183225B20-0x0000000183225BC0
}

