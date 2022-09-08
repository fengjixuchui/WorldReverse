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
public class ConfigWidgetMiracleRing : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19151
{
	// Fields
	private SimpleSafeUInt32 maxCountInSceneRawNum; // 0x30
	private SimpleSafeUInt32 maxCountByPlayerRawNum; // 0x34
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x38
	private SimpleSafeFloat distanceToAvatarRawNum; // 0x3C
	private SimpleSafeFloat radiusRawNum; // 0x40
	private SimpleSafeFloat combatDestroyDistanceRawNum; // 0x44

	// Properties
	public uint maxCountInScene { /* [XID] */ /* 0x0000000189869D40-0x0000000189869D60 */ get => default; /* [XID] */ /* 0x0000000189871110-0x0000000189871130 */ private set {} } // 0x0000000183234450-0x0000000183234520 0x0000000183231E70-0x0000000183231F50
	public uint maxCountByPlayer { /* [XID] */ /* 0x0000000189878A50-0x0000000189878A70 */ get => default; /* [XID] */ /* 0x0000000189880000-0x0000000189880020 */ private set {} } // 0x0000000183232890-0x0000000183232960 0x0000000183232730-0x0000000183232810
	public uint gadgetId { /* [XID] */ /* 0x00000001898875C0-0x00000001898875E0 */ get => default; /* [XID] */ /* 0x000000018988E8C0-0x000000018988E8E0 */ private set {} } // 0x0000000183233050-0x0000000183233120 0x0000000183232F00-0x0000000183232FE0
	public float distanceToAvatar { /* [XID] */ /* 0x0000000189895D60-0x0000000189895D80 */ get => default; /* [XID] */ /* 0x000000018989D3A0-0x000000018989D3C0 */ private set {} } // 0x0000000183234370-0x0000000183234450 0x0000000183234600-0x00000001832346E0
	public float radius { /* [XID] */ /* 0x00000001898A4DC0-0x00000001898A4DE0 */ get => default; /* [XID] */ /* 0x00000001898AC240-0x00000001898AC260 */ private set {} } // 0x0000000183233BD0-0x0000000183233CB0 0x00000001832346E0-0x00000001832347C0
	public float combatDestroyDistance { /* [XID] */ /* 0x00000001898B38E0-0x00000001898B3900 */ get => default; /* [XID] */ /* 0x00000001898BB690-0x00000001898BB6B0 */ private set {} } // 0x00000001832325D0-0x00000001832326B0 0x0000000183234520-0x0000000183234600

	// Constructors
	public ConfigWidgetMiracleRing() {} // 0x0000000183234860-0x00000001832348C0

	// Methods
	// [XID] // 0x00000001898C2960-0x00000001898C2980
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832341F0-0x0000000183234370
	// [XID] // 0x00000001898CA380-0x00000001898CA3A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183233B20-0x0000000183233BD0
	// [XID] // 0x00000001898D1B50-0x00000001898D1B70
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC37D */) => default; // 0x0000000183233730-0x0000000183233810
	// [XID] // 0x00000001898D93D0-0x00000001898D93F0
	public override int GetHashNum() => default; // 0x0000000183231DA0-0x0000000183231E70
	// [XID] // 0x00000001898E0FC0-0x00000001898E0FE0
	public override void InitEmpty() {} // 0x0000000183233120-0x0000000183233260
	[BlackList] // 0x00000001898E8A60-0x00000001898E8AA0
	// [XID] // 0x00000001898E8A60-0x00000001898E8AA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183232960-0x0000000183232CE0
	// [XID] // 0x00000001898F31C0-0x00000001898F31E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183230FE0-0x00000001832317B0
	[BlackList] // 0x00000001898FA880-0x00000001898FA8C0
	// [XID] // 0x00000001898FA880-0x00000001898FA8C0
	public static new ConfigWidgetMiracleRing ParseFromJson(JSONNode node) => default; // 0x0000000183233870-0x0000000183233AC0
	// [XID] // 0x00000001899052E0-0x0000000189905300
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC37E */, bool useObjectPool = false /* Metadata: 0x00AFC382 */) => default; // 0x0000000183233430-0x0000000183233730
	// [XID] // 0x000000018990CC30-0x000000018990CC50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC383 */, bool useObjectPool = false /* Metadata: 0x00AFC387 */) => default; // 0x0000000183232030-0x00000001832325D0
	// [XID] // 0x0000000189914360-0x0000000189914380
	public static new ConfigWidgetMiracleRing ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC388 */, bool useObjectPool = false /* Metadata: 0x00AFC38C */) => default; // 0x0000000183232CE0-0x0000000183232F00
	[BlackList] // 0x000000018991BE60-0x000000018991BEA0
	// [XID] // 0x000000018991BE60-0x000000018991BEA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001832317B0-0x0000000183231A80
	// [XID] // 0x0000000189926540-0x0000000189926560
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183233CB0-0x00000001832341F0
	[BlackList] // 0x000000018992DC90-0x000000018992DCD0
	// [XID] // 0x000000018992DC90-0x000000018992DCD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183233340-0x0000000183233430
	[BlackList] // 0x0000000189938010-0x0000000189938050
	// [XID] // 0x0000000189938010-0x0000000189938050
	public override void AutoAllocTypeFields() {} // 0x0000000183231A80-0x0000000183231B20
	[BlackList] // 0x00000001899425F0-0x0000000189942630
	// [XID] // 0x00000001899425F0-0x0000000189942630
	public override void AutoRecycleTypeFields() {} // 0x0000000183231B20-0x0000000183231C80
	[BlackList] // 0x000000018994CDF0-0x000000018994CE30
	// [XID] // 0x000000018994CDF0-0x000000018994CE30
	public override void ReturnToObjectPool() {} // 0x00000001832347C0-0x0000000183234860
}

