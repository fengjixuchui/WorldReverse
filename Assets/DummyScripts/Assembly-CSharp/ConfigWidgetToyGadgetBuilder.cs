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
public class ConfigWidgetToyGadgetBuilder : ConfigBaseWidgetToy, IAutoAllocRecycle // TypeDefIndex: 19218
{
	// Fields
	private SimpleSafeUInt32 lastingTimeRawNum; // 0x30
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x34
	private SimpleSafeFloat distanceToAvatarRawNum; // 0x38
	private SimpleSafeFloat heightToAvatarRawNum; // 0x3C
	private SimpleSafeFloat radiusRawNum; // 0x40
	private bool _checkCollision; // 0x44

	// Properties
	public uint lastingTime { /* [XID] */ /* 0x0000000189A94E90-0x0000000189A94EB0 */ get => default; /* [XID] */ /* 0x0000000189A9C810-0x0000000189A9C830 */ private set {} } // 0x0000000183005030-0x0000000183005100 0x0000000183005E40-0x0000000183005F20
	public uint gadgetId { /* [XID] */ /* 0x0000000189AA3F60-0x0000000189AA3F80 */ get => default; /* [XID] */ /* 0x0000000189AAB3D0-0x0000000189AAB3F0 */ private set {} } // 0x00000001830059D0-0x0000000183005AA0 0x0000000183005880-0x0000000183005960
	public float distanceToAvatar { /* [XID] */ /* 0x0000000189AB2E00-0x0000000189AB2E20 */ get => default; /* [XID] */ /* 0x0000000189ABAB10-0x0000000189ABAB30 */ private set {} } // 0x0000000183006EE0-0x0000000183006FC0 0x0000000183006FC0-0x00000001830070A0
	public float heightToAvatar { /* [XID] */ /* 0x0000000189AC2230-0x0000000189AC2250 */ get => default; /* [XID] */ /* 0x0000000189AC9960-0x0000000189AC9980 */ private set {} } // 0x00000001830049E0-0x0000000183004AC0 0x00000001830057A0-0x0000000183005880
	public float radius { /* [XID] */ /* 0x0000000189AD11F0-0x0000000189AD1210 */ get => default; /* [XID] */ /* 0x0000000189AD9030-0x0000000189AD9050 */ private set {} } // 0x00000001830066C0-0x00000001830067A0 0x00000001830070A0-0x0000000183007180
	public bool checkCollision { /* [XID] */ /* 0x0000000189AE0AC0-0x0000000189AE0AE0 */ get => default; /* [XID] */ /* 0x0000000189AE7F70-0x0000000189AE7F90 */ private set {} } // 0x0000000183005DA0-0x0000000183005E40 0x0000000183006CB0-0x0000000183006D60

	// Constructors
	public ConfigWidgetToyGadgetBuilder() {} // 0x0000000183007220-0x00000001830072E0

	// Methods
	// [XID] // 0x0000000189AEFD60-0x0000000189AEFD80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183006D60-0x0000000183006EE0
	// [XID] // 0x0000000189AF7280-0x0000000189AF72A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183006610-0x00000001830066C0
	// [XID] // 0x0000000189AFE8D0-0x0000000189AFE8F0
	public override ConfigBaseWidgetToy Clone(bool useObjectPool = false /* Metadata: 0x00AFC5A5 */) => default; // 0x0000000183006220-0x0000000183006300
	// [XID] // 0x0000000189B061A0-0x0000000189B061C0
	public override int GetHashNum() => default; // 0x00000001830048B0-0x0000000183004980
	// [XID] // 0x0000000189B0D950-0x0000000189B0D970
	public override void InitEmpty() {} // 0x0000000183005AA0-0x0000000183005BD0
	[BlackList] // 0x0000000189B14D90-0x0000000189B14DD0
	// [XID] // 0x0000000189B14D90-0x0000000189B14DD0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183005200-0x0000000183005580
	// [XID] // 0x0000000189B1F3C0-0x0000000189B1F3E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183003BC0-0x00000001830042E0
	[BlackList] // 0x0000000189B26C20-0x0000000189B26C60
	// [XID] // 0x0000000189B26C20-0x0000000189B26C60
	public static new ConfigWidgetToyGadgetBuilder ParseFromJson(JSONNode node) => default; // 0x0000000183006360-0x00000001830065B0
	// [XID] // 0x0000000189B30D30-0x0000000189B30D50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC5A6 */, bool useObjectPool = false /* Metadata: 0x00AFC5AA */) => default; // 0x0000000183005F20-0x0000000183006220
	// [XID] // 0x0000000189B383F0-0x0000000189B38410
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC5AB */, bool useObjectPool = false /* Metadata: 0x00AFC5AF */) => default; // 0x0000000183004B40-0x0000000183005030
	// [XID] // 0x0000000189B3FDC0-0x0000000189B3FDE0
	public static new ConfigWidgetToyGadgetBuilder ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC5B0 */, bool useObjectPool = false /* Metadata: 0x00AFC5B4 */) => default; // 0x0000000183005580-0x00000001830057A0
	[BlackList] // 0x0000000189B47640-0x0000000189B47680
	// [XID] // 0x0000000189B47640-0x0000000189B47680
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001830042E0-0x00000001830045B0
	// [XID] // 0x0000000189B51EE0-0x0000000189B51F00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001830067A0-0x0000000183006CB0
	[BlackList] // 0x0000000189B59740-0x0000000189B59780
	// [XID] // 0x0000000189B59740-0x0000000189B59780
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183005CB0-0x0000000183005DA0
	[BlackList] // 0x0000000189B63E50-0x0000000189B63E90
	// [XID] // 0x0000000189B63E50-0x0000000189B63E90
	public override void AutoAllocTypeFields() {} // 0x00000001830045B0-0x0000000183004650
	[BlackList] // 0x0000000189B6E300-0x0000000189B6E340
	// [XID] // 0x0000000189B6E300-0x0000000189B6E340
	public override void AutoRecycleTypeFields() {} // 0x0000000183004650-0x0000000183004790
	[BlackList] // 0x0000000189B78B60-0x0000000189B78BA0
	// [XID] // 0x0000000189B78B60-0x0000000189B78BA0
	public override void ReturnToObjectPool() {} // 0x0000000183007180-0x0000000183007220
}

