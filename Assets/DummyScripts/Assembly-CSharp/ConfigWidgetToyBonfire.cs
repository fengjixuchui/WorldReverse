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
public class ConfigWidgetToyBonfire : ConfigBaseWidgetToy, IAutoAllocRecycle // TypeDefIndex: 19200
{
	// Fields
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x30
	private SimpleSafeFloat distanceToAvatarRawNum; // 0x34
	private SimpleSafeFloat radiusRawNum; // 0x38

	// Properties
	public uint gadgetId { /* [XID] */ /* 0x0000000189A0B750-0x0000000189A0B770 */ get => default; /* [XID] */ /* 0x0000000189A12FA0-0x0000000189A12FC0 */ private set {} } // 0x0000000182E80780-0x0000000182E80850 0x0000000182E80630-0x0000000182E80710
	public float distanceToAvatar { /* [XID] */ /* 0x0000000189A1A2D0-0x0000000189A1A2F0 */ get => default; /* [XID] */ /* 0x0000000189A21850-0x0000000189A21870 */ private set {} } // 0x0000000182E81830-0x0000000182E81910 0x0000000182E81910-0x0000000182E819F0
	public float radius { /* [XID] */ /* 0x0000000189A28E20-0x0000000189A28E40 */ get => default; /* [XID] */ /* 0x0000000189A30510-0x0000000189A30530 */ private set {} } // 0x0000000182E812D0-0x0000000182E813B0 0x0000000182E819F0-0x0000000182E81AD0

	// Constructors
	public ConfigWidgetToyBonfire() {} // 0x0000000182E81B70-0x0000000182E81BD0

	// Methods
	// [XID] // 0x0000000189A37ED0-0x0000000189A37EF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182E81700-0x0000000182E81830
	// [XID] // 0x0000000189A3F620-0x0000000189A3F640
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182E81220-0x0000000182E812D0
	// [XID] // 0x0000000189A46CB0-0x0000000189A46CD0
	public override ConfigBaseWidgetToy Clone(bool useObjectPool = false /* Metadata: 0x00AFC515 */) => default; // 0x0000000182E80E30-0x0000000182E80F10
	// [XID] // 0x0000000189A4E500-0x0000000189A4E520
	public override int GetHashNum() => default; // 0x0000000182E7FA30-0x0000000182E7FB00
	// [XID] // 0x0000000189A55CC0-0x0000000189A55CE0
	public override void InitEmpty() {} // 0x0000000182E80850-0x0000000182E80960
	[BlackList] // 0x0000000189A5D4C0-0x0000000189A5D500
	// [XID] // 0x0000000189A5D4C0-0x0000000189A5D500
	public override bool FromJson(JSONNode node) => default; // 0x0000000182E80090-0x0000000182E80410
	// [XID] // 0x0000000189A68190-0x0000000189A681B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182E7EFD0-0x0000000182E7F480
	[BlackList] // 0x0000000189A6F5A0-0x0000000189A6F5E0
	// [XID] // 0x0000000189A6F5A0-0x0000000189A6F5E0
	public static new ConfigWidgetToyBonfire ParseFromJson(JSONNode node) => default; // 0x0000000182E80F70-0x0000000182E811C0
	// [XID] // 0x0000000189A7A370-0x0000000189A7A390
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC516 */, bool useObjectPool = false /* Metadata: 0x00AFC51A */) => default; // 0x0000000182E80B30-0x0000000182E80E30
	// [XID] // 0x0000000189A81770-0x0000000189A81790
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC51B */, bool useObjectPool = false /* Metadata: 0x00AFC51F */) => default; // 0x0000000182E7FBE0-0x0000000182E7FF90
	// [XID] // 0x0000000189A892F0-0x0000000189A89310
	public static new ConfigWidgetToyBonfire ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC520 */, bool useObjectPool = false /* Metadata: 0x00AFC524 */) => default; // 0x0000000182E80410-0x0000000182E80630
	[BlackList] // 0x0000000189A90B10-0x0000000189A90B50
	// [XID] // 0x0000000189A90B10-0x0000000189A90B50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182E7F480-0x0000000182E7F750
	// [XID] // 0x0000000189A9B280-0x0000000189A9B2A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182E813B0-0x0000000182E81700
	[BlackList] // 0x0000000189AA2520-0x0000000189AA2560
	// [XID] // 0x0000000189AA2520-0x0000000189AA2560
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182E80A40-0x0000000182E80B30
	[BlackList] // 0x0000000189AACDE0-0x0000000189AACE20
	// [XID] // 0x0000000189AACDE0-0x0000000189AACE20
	public override void AutoAllocTypeFields() {} // 0x0000000182E7F750-0x0000000182E7F7F0
	[BlackList] // 0x0000000189AB75B0-0x0000000189AB75F0
	// [XID] // 0x0000000189AB75B0-0x0000000189AB75F0
	public override void AutoRecycleTypeFields() {} // 0x0000000182E7F7F0-0x0000000182E7F910
	[BlackList] // 0x0000000189AC2250-0x0000000189AC2290
	// [XID] // 0x0000000189AC2250-0x0000000189AC2290
	public override void ReturnToObjectPool() {} // 0x0000000182E81AD0-0x0000000182E81B70
}

