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
public class ConfigAISensingSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17384
{
	// Fields
	private SimpleSafeFloat sensitivityRawNum; // 0x10
	private bool _enableVision; // 0x14
	private SimpleSafeFloat viewRangeRawNum; // 0x18
	private bool _viewPanoramic; // 0x1C
	private SimpleSafeFloat horizontalFovRawNum; // 0x20
	private SimpleSafeFloat verticalFovRawNum; // 0x24
	private SimpleSafeFloat hearAttractionRangeRawNum; // 0x28
	private SimpleSafeFloat hearFootstepRangeRawNum; // 0x2C
	private SimpleSafeFloat feelRangeRawNum; // 0x30
	private SimpleSafeFloat sourcelessHitAttractionRangeRawNum; // 0x34

	// Properties
	public float sensitivity { /* [XID] */ /* 0x00000001898D35D0-0x00000001898D35F0 */ get => default; /* [XID] */ /* 0x00000001898DAD60-0x00000001898DAD80 */ private set {} } // 0x0000000182C05850-0x0000000182C05930 0x0000000182C04BA0-0x0000000182C04C80
	public bool enableVision { /* [XID] */ /* 0x00000001898E2B40-0x00000001898E2B60 */ get => default; /* [XID] */ /* 0x00000001898EA790-0x00000001898EA7B0 */ private set {} } // 0x0000000182C04F20-0x0000000182C04FC0 0x0000000182C05A10-0x0000000182C05AC0
	public float viewRange { /* [XID] */ /* 0x0000000189673CF0-0x0000000189673D10 */ get => default; /* [XID] */ /* 0x00000001898F95F0-0x00000001898F9610 */ private set {} } // 0x0000000182C03F30-0x0000000182C04010 0x0000000182C06530-0x0000000182C06610
	public bool viewPanoramic { /* [XID] */ /* 0x00000001896BE040-0x00000001896BE060 */ get => default; /* [XID] */ /* 0x0000000189908830-0x0000000189908850 */ private set {} } // 0x0000000182C06490-0x0000000182C06530 0x0000000182C050A0-0x0000000182C05150
	public float horizontalFov { /* [XID] */ /* 0x000000018990FE10-0x000000018990FE30 */ get => default; /* [XID] */ /* 0x0000000189917A20-0x0000000189917A40 */ private set {} } // 0x0000000182C03E50-0x0000000182C03F30 0x0000000182C04740-0x0000000182C04820
	public float verticalFov { /* [XID] */ /* 0x000000018966BF40-0x000000018966BF60 */ get => default; /* [XID] */ /* 0x00000001899269C0-0x00000001899269E0 */ private set {} } // 0x0000000182C055B0-0x0000000182C05690 0x0000000182C04E40-0x0000000182C04F20
	public float hearAttractionRange { /* [XID] */ /* 0x00000001899643D0-0x00000001899643F0 */ get => default; /* [XID] */ /* 0x0000000189935330-0x0000000189935350 */ private set {} } // 0x0000000182C04C80-0x0000000182C04D60 0x0000000182C04660-0x0000000182C04740
	public float hearFootstepRange { /* [XID] */ /* 0x0000000189B55A20-0x0000000189B55A40 */ get => default; /* [XID] */ /* 0x0000000189944520-0x0000000189944540 */ private set {} } // 0x0000000182C038A0-0x0000000182C03980 0x0000000182C04FC0-0x0000000182C050A0
	public float feelRange { /* [XID] */ /* 0x0000000189A2E2B0-0x0000000189A2E2D0 */ get => default; /* [XID] */ /* 0x00000001899532F0-0x0000000189953310 */ private set {} } // 0x0000000182C05690-0x0000000182C05770 0x0000000182C05930-0x0000000182C05A10
	public float sourcelessHitAttractionRange { /* [XID] */ /* 0x000000018995AA50-0x000000018995AA70 */ get => default; /* [XID] */ /* 0x00000001899625D0-0x00000001899625F0 */ private set {} } // 0x0000000182C05770-0x0000000182C05850 0x0000000182C04D60-0x0000000182C04E40

	// Constructors
	public ConfigAISensingSetting() {} // 0x0000000182C066B0-0x0000000182C067E0

	// Methods
	// [XID] // 0x0000000189969A40-0x0000000189969A60
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C06170-0x0000000182C06350
	// [XID] // 0x00000001899717A0-0x00000001899717C0
	public void InitEmpty() {} // 0x0000000182C05150-0x0000000182C052B0
	[BlackList] // 0x0000000189979090-0x00000001899790D0
	// [XID] // 0x0000000189979090-0x00000001899790D0
	public bool FromJson(JSONNode node) => default; // 0x0000000182C04820-0x0000000182C04BA0
	// [XID] // 0x00000001899835B0-0x00000001899835D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C02E50-0x0000000182C038A0
	// [XID] // 0x000000018998ADA0-0x000000018998ADC0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C85 */, bool useObjectPool = false /* Metadata: 0x00AF6C89 */) => default; // 0x0000000182C052B0-0x0000000182C055B0
	// [XID] // 0x0000000189992670-0x0000000189992690
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C8A */, bool useObjectPool = false /* Metadata: 0x00AF6C8E */) => default; // 0x0000000182C04010-0x0000000182C04660
	[BlackList] // 0x000000018999A410-0x000000018999A450
	// [XID] // 0x000000018999A410-0x000000018999A450
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C03980-0x0000000182C03C50
	// [XID] // 0x00000001899A4B90-0x00000001899A4BB0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C05AC0-0x0000000182C06170
	[BlackList] // 0x00000001899AC610-0x00000001899AC650
	// [XID] // 0x00000001899AC610-0x00000001899AC650
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C03C50-0x0000000182C03CF0
	[BlackList] // 0x00000001899B69B0-0x00000001899B69F0
	// [XID] // 0x00000001899B69B0-0x00000001899B69F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C03CF0-0x0000000182C03E50
	[BlackList] // 0x00000001899C1430-0x00000001899C1470
	// [XID] // 0x00000001899C1430-0x00000001899C1470
	public virtual void ReturnToObjectPool() {} // 0x0000000182C06610-0x0000000182C066B0
	[BlackList] // 0x00000001899CBD20-0x00000001899CBD60
	// [XID] // 0x00000001899CBD20-0x00000001899CBD60
	public virtual void OnPoolAllocated() {} // 0x0000000182C063F0-0x0000000182C06490
	[BlackList] // 0x00000001899D6150-0x00000001899D6190
	// [XID] // 0x00000001899D6150-0x00000001899D6190
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C06350-0x0000000182C063F0
}

