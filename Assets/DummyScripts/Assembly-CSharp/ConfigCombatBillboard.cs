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
public class ConfigCombatBillboard : ConfigBillboard, IAutoAllocRecycle // TypeDefIndex: 17714
{
	// Fields
	private bool _showHPBar; // 0x40
	private SimpleSafeFloat forceShowDistanceRawNum; // 0x44
	private CombatBillboardSize _size; // 0x48
	private bool _shieldBarOnly; // 0x4C

	// Properties
	public bool showHPBar { /* [XID] */ /* 0x0000000189893470-0x0000000189893490 */ get => default; /* [XID] */ /* 0x000000018989AB90-0x000000018989ABB0 */ private set {} } // 0x000000018276DE20-0x000000018276DEC0 0x00000001827700A0-0x0000000182770150
	public float forceShowDistance { /* [XID] */ /* 0x00000001898A1DC0-0x00000001898A1DE0 */ get => default; /* [XID] */ /* 0x00000001898A9670-0x00000001898A9690 */ private set {} } // 0x000000018276E5E0-0x000000018276E6C0 0x000000018276D810-0x000000018276D8F0
	public CombatBillboardSize size { /* [XID] */ /* 0x00000001898B0E80-0x00000001898B0EA0 */ get => default; /* [XID] */ /* 0x00000001898B85C0-0x00000001898B85E0 */ private set {} } // 0x0000000182770150-0x00000001827701F0 0x000000018276F410-0x000000018276F4C0
	public bool shieldBarOnly { /* [XID] */ /* 0x00000001898BFD40-0x00000001898BFD60 */ get => default; /* [XID] */ /* 0x00000001898C7680-0x00000001898C76A0 */ private set {} } // 0x000000018276FC60-0x000000018276FD00 0x0000000182770340-0x00000001827703F0

	// Constructors
	public ConfigCombatBillboard() {} // 0x0000000182770490-0x0000000182770530

	// Methods
	// [XID] // 0x00000001898CEC50-0x00000001898CEC70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001827701F0-0x0000000182770340
	// [XID] // 0x00000001898D6620-0x00000001898D6640
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018276FBB0-0x000000018276FC60
	// [XID] // 0x00000001898DE300-0x00000001898DE320
	public override ConfigBillboard Clone(bool useObjectPool = false /* Metadata: 0x00AF78AD */) => default; // 0x000000018276F7C0-0x000000018276F8A0
	// [XID] // 0x00000001898E5B20-0x00000001898E5B40
	public override int GetHashNum() => default; // 0x000000018276E430-0x000000018276E500
	// [XID] // 0x00000001898ED480-0x00000001898ED4A0
	public override void InitEmpty() {} // 0x000000018276F170-0x000000018276F240
	[BlackList] // 0x00000001898F4CA0-0x00000001898F4CE0
	// [XID] // 0x00000001898F4CA0-0x00000001898F4CE0
	public override bool FromJson(JSONNode node) => default; // 0x000000018276EB60-0x000000018276EEE0
	// [XID] // 0x00000001898FF4D0-0x00000001898FF4F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018276D970-0x000000018276DE20
	[BlackList] // 0x0000000189906CB0-0x0000000189906CF0
	// [XID] // 0x0000000189906CB0-0x0000000189906CF0
	public static new ConfigCombatBillboard ParseFromJson(JSONNode node) => default; // 0x000000018276F900-0x000000018276FB50
	// [XID] // 0x0000000189911420-0x0000000189911440
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF78AE */, bool useObjectPool = false /* Metadata: 0x00AF78B2 */) => default; // 0x000000018276F4C0-0x000000018276F7C0
	// [XID] // 0x0000000189919020-0x0000000189919040
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF78B3 */, bool useObjectPool = false /* Metadata: 0x00AF78B7 */) => default; // 0x000000018276E6C0-0x000000018276EA60
	// [XID] // 0x0000000189920590-0x00000001899205B0
	public static new ConfigCombatBillboard ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF78B8 */, bool useObjectPool = false /* Metadata: 0x00AF78BC */) => default; // 0x000000018276EEE0-0x000000018276F100
	[BlackList] // 0x0000000189927EB0-0x0000000189927EF0
	// [XID] // 0x0000000189927EB0-0x0000000189927EF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018276DEC0-0x000000018276E190
	// [XID] // 0x0000000189932500-0x0000000189932520
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018276FD00-0x00000001827700A0
	[BlackList] // 0x0000000189939F50-0x0000000189939F90
	// [XID] // 0x0000000189939F50-0x0000000189939F90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018276F320-0x000000018276F410
	[BlackList] // 0x00000001899444A0-0x00000001899444E0
	// [XID] // 0x00000001899444A0-0x00000001899444E0
	public override void AutoAllocTypeFields() {} // 0x000000018276E190-0x000000018276E230
	[BlackList] // 0x000000018994EA60-0x000000018994EAA0
	// [XID] // 0x000000018994EA60-0x000000018994EAA0
	public override void AutoRecycleTypeFields() {} // 0x000000018276E230-0x000000018276E310
	[BlackList] // 0x0000000189959130-0x0000000189959170
	// [XID] // 0x0000000189959130-0x0000000189959170
	public override void ReturnToObjectPool() {} // 0x00000001827703F0-0x0000000182770490
}

