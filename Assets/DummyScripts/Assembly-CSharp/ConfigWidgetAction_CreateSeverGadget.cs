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
public class ConfigWidgetAction_CreateSeverGadget : ConfigWidgetAction, IAutoAllocRecycle // TypeDefIndex: 19167
{
	// Fields
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x10

	// Properties
	public uint gadgetId { /* [XID] */ /* 0x00000001898D3110-0x00000001898D3130 */ get => default; /* [XID] */ /* 0x00000001898DAA80-0x00000001898DAAA0 */ private set {} } // 0x00000001828B5400-0x00000001828B54D0 0x00000001828B52B0-0x00000001828B5390

	// Constructors
	public ConfigWidgetAction_CreateSeverGadget() {} // 0x00000001828B6450-0x00000001828B64B0

	// Methods
	// [XID] // 0x00000001898E29A0-0x00000001898E29C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828B62C0-0x00000001828B63B0
	// [XID] // 0x00000001898EA3D0-0x00000001898EA3F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001828B5FE0-0x00000001828B6090
	// [XID] // 0x00000001898F1B90-0x00000001898F1BB0
	public override ConfigWidgetAction Clone(bool useObjectPool = false /* Metadata: 0x00AFC407 */) => default; // 0x00000001828B5BF0-0x00000001828B5CD0
	// [XID] // 0x00000001898F9350-0x00000001898F9370
	public override int GetHashNum() => default; // 0x00000001828B47F0-0x00000001828B48C0
	// [XID] // 0x0000000189900C70-0x0000000189900C90
	public override void InitEmpty() {} // 0x00000001828B5560-0x00000001828B5630
	[BlackList] // 0x00000001899083F0-0x0000000189908430
	// [XID] // 0x00000001899083F0-0x0000000189908430
	public override bool FromJson(JSONNode node) => default; // 0x00000001828B4D10-0x00000001828B5090
	// [XID] // 0x0000000189912E00-0x0000000189912E20
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001828B4020-0x00000001828B4280
	[BlackList] // 0x000000018991A6F0-0x000000018991A730
	// [XID] // 0x000000018991A6F0-0x000000018991A730
	public static new ConfigWidgetAction_CreateSeverGadget ParseFromJson(JSONNode node) => default; // 0x00000001828B5D30-0x00000001828B5F80
	// [XID] // 0x0000000189924E80-0x0000000189924EA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC408 */, bool useObjectPool = false /* Metadata: 0x00AFC40C */) => default; // 0x00000001828B5800-0x00000001828B5B00
	// [XID] // 0x000000018992C380-0x000000018992C3A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC40D */, bool useObjectPool = false /* Metadata: 0x00AFC411 */) => default; // 0x00000001828B49A0-0x00000001828B4C10
	// [XID] // 0x0000000189933980-0x00000001899339A0
	public static new ConfigWidgetAction_CreateSeverGadget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC412 */, bool useObjectPool = false /* Metadata: 0x00AFC416 */) => default; // 0x00000001828B5090-0x00000001828B52B0
	[BlackList] // 0x000000018993B4F0-0x000000018993B530
	// [XID] // 0x000000018993B4F0-0x000000018993B530
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001828B4280-0x00000001828B4550
	// [XID] // 0x0000000189945980-0x00000001899459A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828B6090-0x00000001828B62C0
	[BlackList] // 0x000000018994CDB0-0x000000018994CDF0
	// [XID] // 0x000000018994CDB0-0x000000018994CDF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001828B5710-0x00000001828B5800
	[BlackList] // 0x00000001899575A0-0x00000001899575E0
	// [XID] // 0x00000001899575A0-0x00000001899575E0
	public override void AutoAllocTypeFields() {} // 0x00000001828B4550-0x00000001828B45F0
	[BlackList] // 0x00000001899621F0-0x0000000189962230
	// [XID] // 0x00000001899621F0-0x0000000189962230
	public override void AutoRecycleTypeFields() {} // 0x00000001828B45F0-0x00000001828B46D0
	[BlackList] // 0x000000018996C630-0x000000018996C670
	// [XID] // 0x000000018996C630-0x000000018996C670
	public override void ReturnToObjectPool() {} // 0x00000001828B63B0-0x00000001828B6450
	// [XID] // 0x0000000189976FE0-0x0000000189977000
	public override void DoAction(LCWidget lcWidget, QuickWidgetGeneral widget) {} // 0x00000001828B5B00-0x00000001828B5BF0
}

