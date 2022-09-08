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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigShapeSector : ConfigBaseShape, IAutoAllocRecycle // TypeDefIndex: 18988
{
	// Fields
	private SimpleSafeFloat radiusRawNum; // 0x20
	private SimpleSafeFloat fullDegreeRawNum; // 0x24

	// Properties
	public float radius { /* [XID] */ /* 0x0000000189923600-0x0000000189923620 */ get => default; /* [XID] */ /* 0x000000018992AC40-0x000000018992AC60 */ private set {} } // 0x00000001828ABEC0-0x00000001828ABFA0 0x00000001828AC350-0x00000001828AC430
	public float fullDegree { /* [XID] */ /* 0x0000000189932280-0x00000001899322A0 */ get => default; /* [XID] */ /* 0x0000000189939C70-0x0000000189939C90 */ private set {} } // 0x00000001828ABDE0-0x00000001828ABEC0 0x00000001828AA440-0x00000001828AA520

	// Constructors
	public ConfigShapeSector() {} // 0x00000001828AC4D0-0x00000001828AC530

	// Methods
	// [XID] // 0x0000000189940E60-0x0000000189940E80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828AC240-0x00000001828AC350
	// [XID] // 0x00000001899488E0-0x0000000189948900
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001828ABD30-0x00000001828ABDE0
	// [XID] // 0x0000000189950050-0x0000000189950070
	public override ConfigBaseShape Clone(bool useObjectPool = false /* Metadata: 0x00AFB66F */) => default; // 0x00000001828AB940-0x00000001828ABA20
	// [XID] // 0x0000000189957600-0x0000000189957620
	public override int GetHashNum() => default; // 0x00000001828AA370-0x00000001828AA440
	// [XID] // 0x000000018995F010-0x000000018995F030
	public override void InitEmpty() {} // 0x00000001828AB390-0x00000001828AB470
	[BlackList] // 0x0000000189966850-0x0000000189966890
	// [XID] // 0x0000000189966850-0x0000000189966890
	public override bool FromJson(JSONNode node) => default; // 0x00000001828AAA00-0x00000001828AAD80
	// [XID] // 0x0000000189971360-0x0000000189971380
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001828A9A50-0x00000001828A9DF0
	[BlackList] // 0x0000000189978D30-0x0000000189978D70
	// [XID] // 0x0000000189978D30-0x0000000189978D70
	public static new ConfigShapeSector ParseFromJson(JSONNode node) => default; // 0x00000001828ABA80-0x00000001828ABCD0
	// [XID] // 0x00000001899832B0-0x00000001899832D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB670 */, bool useObjectPool = false /* Metadata: 0x00AFB674 */) => default; // 0x00000001828AB640-0x00000001828AB940
	// [XID] // 0x000000018998AA20-0x000000018998AA40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB675 */, bool useObjectPool = false /* Metadata: 0x00AFB679 */) => default; // 0x00000001828AA600-0x00000001828AA900
	// [XID] // 0x0000000189992330-0x0000000189992350
	public static new ConfigShapeSector ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB67A */, bool useObjectPool = false /* Metadata: 0x00AFB67E */) => default; // 0x00000001828AAE70-0x00000001828AB090
	[BlackList] // 0x000000018999A0B0-0x000000018999A0F0
	// [XID] // 0x000000018999A0B0-0x000000018999A0F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001828A9DF0-0x00000001828AA0C0
	// [XID] // 0x00000001899A48D0-0x00000001899A48F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828ABFA0-0x00000001828AC240
	[BlackList] // 0x00000001899AC210-0x00000001899AC250
	// [XID] // 0x00000001899AC210-0x00000001899AC250
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001828AB550-0x00000001828AB640
	[BlackList] // 0x00000001899B6550-0x00000001899B6590
	// [XID] // 0x00000001899B6550-0x00000001899B6590
	public override void AutoAllocTypeFields() {} // 0x00000001828AA0C0-0x00000001828AA160
	[BlackList] // 0x00000001899C1090-0x00000001899C10D0
	// [XID] // 0x00000001899C1090-0x00000001899C10D0
	public override void AutoRecycleTypeFields() {} // 0x00000001828AA160-0x00000001828AA250
	[BlackList] // 0x00000001899CB940-0x00000001899CB980
	// [XID] // 0x00000001899CB940-0x00000001899CB980
	public override void ReturnToObjectPool() {} // 0x00000001828AC430-0x00000001828AC4D0
	// [XID] // 0x00000001899D5E50-0x00000001899D5E70
	public override BaseShape CreateShape(Vector3 position, Vector3 direction, bool useHeight, float height, float sizeRatio) => default; // 0x00000001828AB090-0x00000001828AB320
}

