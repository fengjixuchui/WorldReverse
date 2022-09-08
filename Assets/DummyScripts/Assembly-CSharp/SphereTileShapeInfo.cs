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
public class SphereTileShapeInfo : TileShapeInfo, IAutoAllocRecycle // TypeDefIndex: 14585
{
	// Fields
	private SimpleSafeFloat radiusRawNum; // 0x10

	// Properties
	public float radius { /* [XID] */ /* 0x0000000189BA4100-0x0000000189BA4120 */ get => default; /* [XID] */ /* 0x0000000189BAB710-0x0000000189BAB730 */ private set {} } // 0x00000001835A82D0-0x00000001835A83B0 0x00000001835A86A0-0x00000001835A8780

	// Constructors
	public SphereTileShapeInfo() {} // 0x00000001835A8820-0x00000001835A8880

	// Methods
	// [XID] // 0x0000000189B953A0-0x0000000189B953C0
	public override Bounds GetBounds(Vector3 pos, Quaternion rotate) => default; // 0x00000001835A7D70-0x00000001835A7F70
	// [XID] // 0x0000000189B9CA50-0x0000000189B9CA70
	public override bool IsCapsuleInShape(Vector3 selfPos, Quaternion selfRotate, Vector3 targetCenter, float targetRadius, float targetHeight) => default; // 0x00000001835A6C50-0x00000001835A6F10
	// [XID] // 0x0000000189BB2C90-0x0000000189BB2CB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835A85A0-0x00000001835A86A0
	// [XID] // 0x0000000189BBA040-0x0000000189BBA060
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835A8220-0x00000001835A82D0
	// [XID] // 0x0000000189BC2160-0x0000000189BC2180
	public override TileShapeInfo Clone(bool useObjectPool = false /* Metadata: 0x00AEB92B */) => default; // 0x00000001835A7C30-0x00000001835A7D10
	// [XID] // 0x0000000189BC9630-0x0000000189BC9650
	public override int GetHashNum() => default; // 0x00000001835A66E0-0x00000001835A67B0
	// [XID] // 0x0000000189BD0E90-0x0000000189BD0EB0
	public override void InitEmpty() {} // 0x00000001835A7690-0x00000001835A7760
	[BlackList] // 0x0000000189BD8460-0x0000000189BD84A0
	// [XID] // 0x0000000189BD8460-0x0000000189BD84A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001835A6F90-0x00000001835A7310
	// [XID] // 0x00000001895E81B0-0x00000001895E81D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001835A5F00-0x00000001835A6170
	[BlackList] // 0x00000001895EFA80-0x00000001895EFAC0
	// [XID] // 0x00000001895EFA80-0x00000001895EFAC0
	public static new SphereTileShapeInfo ParseFromJson(JSONNode node) => default; // 0x00000001835A7F70-0x00000001835A81C0
	// [XID] // 0x00000001895FA180-0x00000001895FA1A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEB92C */, bool useObjectPool = false /* Metadata: 0x00AEB930 */) => default; // 0x00000001835A7930-0x00000001835A7C30
	// [XID] // 0x0000000189601B10-0x0000000189601B30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEB931 */, bool useObjectPool = false /* Metadata: 0x00AEB935 */) => default; // 0x00000001835A6890-0x00000001835A6B00
	// [XID] // 0x0000000189609300-0x0000000189609320
	public static new SphereTileShapeInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEB936 */, bool useObjectPool = false /* Metadata: 0x00AEB93A */) => default; // 0x00000001835A7400-0x00000001835A7620
	[BlackList] // 0x0000000189610A60-0x0000000189610AA0
	// [XID] // 0x0000000189610A60-0x0000000189610AA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001835A6170-0x00000001835A6440
	// [XID] // 0x000000018961B0F0-0x000000018961B110
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835A83B0-0x00000001835A85A0
	[BlackList] // 0x0000000189622600-0x0000000189622640
	// [XID] // 0x0000000189622600-0x0000000189622640
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001835A7840-0x00000001835A7930
	[BlackList] // 0x000000018962CE50-0x000000018962CE90
	// [XID] // 0x000000018962CE50-0x000000018962CE90
	public override void AutoAllocTypeFields() {} // 0x00000001835A6440-0x00000001835A64E0
	[BlackList] // 0x0000000189637BE0-0x0000000189637C20
	// [XID] // 0x0000000189637BE0-0x0000000189637C20
	public override void AutoRecycleTypeFields() {} // 0x00000001835A64E0-0x00000001835A65C0
	[BlackList] // 0x0000000189641FF0-0x0000000189642030
	// [XID] // 0x0000000189641FF0-0x0000000189642030
	public override void ReturnToObjectPool() {} // 0x00000001835A8780-0x00000001835A8820
}

