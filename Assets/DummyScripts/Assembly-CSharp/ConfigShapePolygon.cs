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
public class ConfigShapePolygon : ConfigBaseShape, IAutoAllocRecycle // TypeDefIndex: 18990
{
	// Fields
	private string _polygonConfigPath; // 0x20

	// Properties
	public string polygonConfigPath { /* [XID] */ /* 0x00000001899E4FC0-0x00000001899E4FE0 */ get => default; /* [XID] */ /* 0x00000001899EC370-0x00000001899EC390 */ private set {} } // 0x0000000182D245F0-0x0000000182D24690 0x0000000182D24E60-0x0000000182D24F10

	// Constructors
	public ConfigShapePolygon() {} // 0x0000000182D252A0-0x0000000182D25300

	// Methods
	// [XID] // 0x00000001899F3EB0-0x00000001899F3ED0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D25110-0x0000000182D25200
	// [XID] // 0x00000001899FB650-0x00000001899FB670
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D24D80-0x0000000182D24E60
	// [XID] // 0x0000000189A02950-0x0000000189A02970
	public override ConfigBaseShape Clone(bool useObjectPool = false /* Metadata: 0x00AFB67F */) => default; // 0x0000000182D24990-0x0000000182D24A70
	// [XID] // 0x0000000189A0A0C0-0x0000000189A0A0E0
	public override int GetHashNum() => default; // 0x0000000182D23300-0x0000000182D233D0
	// [XID] // 0x0000000189A119C0-0x0000000189A119E0
	public override void InitEmpty() {} // 0x0000000182D24350-0x0000000182D24420
	[BlackList] // 0x0000000189A18BF0-0x0000000189A18C30
	// [XID] // 0x0000000189A18BF0-0x0000000189A18C30
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D23820-0x0000000182D23BA0
	// [XID] // 0x0000000189A233E0-0x0000000189A23400
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D22B90-0x0000000182D22DC0
	[BlackList] // 0x0000000189A2A6C0-0x0000000189A2A700
	// [XID] // 0x0000000189A2A6C0-0x0000000189A2A700
	public static new ConfigShapePolygon ParseFromJson(JSONNode node) => default; // 0x0000000182D24AD0-0x0000000182D24D20
	// [XID] // 0x0000000189A34F10-0x0000000189A34F30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB680 */, bool useObjectPool = false /* Metadata: 0x00AFB684 */) => default; // 0x0000000182D24690-0x0000000182D24990
	// [XID] // 0x0000000189A3C3B0-0x0000000189A3C3D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB685 */, bool useObjectPool = false /* Metadata: 0x00AFB689 */) => default; // 0x0000000182D234B0-0x0000000182D23720
	// [XID] // 0x0000000189A43ED0-0x0000000189A43EF0
	public static new ConfigShapePolygon ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB68A */, bool useObjectPool = false /* Metadata: 0x00AFB68E */) => default; // 0x0000000182D23C90-0x0000000182D23EB0
	[BlackList] // 0x0000000189A4B440-0x0000000189A4B480
	// [XID] // 0x0000000189A4B440-0x0000000189A4B480
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D22DC0-0x0000000182D23090
	// [XID] // 0x0000000189A55D40-0x0000000189A55D60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D24F10-0x0000000182D25110
	[BlackList] // 0x0000000189A5D5A0-0x0000000189A5D5E0
	// [XID] // 0x0000000189A5D5A0-0x0000000189A5D5E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D24500-0x0000000182D245F0
	[BlackList] // 0x0000000189A681F0-0x0000000189A68230
	// [XID] // 0x0000000189A681F0-0x0000000189A68230
	public override void AutoAllocTypeFields() {} // 0x0000000182D23090-0x0000000182D23130
	[BlackList] // 0x0000000189A72770-0x0000000189A727B0
	// [XID] // 0x0000000189A72770-0x0000000189A727B0
	public override void AutoRecycleTypeFields() {} // 0x0000000182D23130-0x0000000182D231E0
	[BlackList] // 0x0000000189A7D150-0x0000000189A7D190
	// [XID] // 0x0000000189A7D150-0x0000000189A7D190
	public override void ReturnToObjectPool() {} // 0x0000000182D25200-0x0000000182D252A0
	// [XID] // 0x0000000189A87AA0-0x0000000189A87AC0
	public override BaseShape CreateShape(Vector3 position, Vector3 direction, bool useHeight, float height, float sizeRatio) => default; // 0x0000000182D23EB0-0x0000000182D242E0
}

