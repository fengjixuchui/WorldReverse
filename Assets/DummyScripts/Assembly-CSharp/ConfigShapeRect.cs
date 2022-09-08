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
public class ConfigShapeRect : ConfigBaseShape, IAutoAllocRecycle // TypeDefIndex: 18986
{
	// Fields
	private CenterPosType _centerType; // 0x20
	private SimpleSafeFloat widthRawNum; // 0x24
	private SimpleSafeFloat lengthRawNum; // 0x28

	// Properties
	public CenterPosType centerType { /* [XID] */ /* 0x0000000189853920-0x0000000189853940 */ get => default; /* [XID] */ /* 0x000000018985B410-0x000000018985B430 */ private set {} } // 0x0000000182A0CCF0-0x0000000182A0CD90 0x0000000182A0D040-0x0000000182A0D0F0
	public float width { /* [XID] */ /* 0x00000001898629B0-0x00000001898629D0 */ get => default; /* [XID] */ /* 0x0000000189869DA0-0x0000000189869DC0 */ private set {} } // 0x0000000182A0C6E0-0x0000000182A0C7C0 0x0000000182A0B4C0-0x0000000182A0B5A0
	public float length { /* [XID] */ /* 0x0000000189871150-0x0000000189871170 */ get => default; /* [XID] */ /* 0x0000000189878AB0-0x0000000189878AD0 */ private set {} } // 0x0000000182A0BF70-0x0000000182A0C050 0x0000000182A0BDA0-0x0000000182A0BE80

	// Constructors
	public ConfigShapeRect() {} // 0x0000000182A0D6F0-0x0000000182A0D750

	// Methods
	// [XID] // 0x0000000189880060-0x0000000189880080
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A0D520-0x0000000182A0D650
	// [XID] // 0x0000000189887600-0x0000000189887620
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182A0D150-0x0000000182A0D200
	// [XID] // 0x000000018988E900-0x000000018988E920
	public override ConfigBaseShape Clone(bool useObjectPool = false /* Metadata: 0x00AFB65F */) => default; // 0x0000000182A0CC10-0x0000000182A0CCF0
	// [XID] // 0x0000000189895D80-0x0000000189895DA0
	public override int GetHashNum() => default; // 0x0000000182A0B310-0x0000000182A0B3E0
	// [XID] // 0x000000018989D400-0x000000018989D420
	public override void InitEmpty() {} // 0x0000000182A0C580-0x0000000182A0C660
	[BlackList] // 0x00000001898A4DE0-0x00000001898A4E20
	// [XID] // 0x00000001898A4DE0-0x00000001898A4E20
	public override bool FromJson(JSONNode node) => default; // 0x0000000182A0BA20-0x0000000182A0BDA0
	// [XID] // 0x00000001898AF610-0x00000001898AF630
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182A0A910-0x0000000182A0AD90
	[BlackList] // 0x00000001898B69D0-0x00000001898B6A10
	// [XID] // 0x00000001898B69D0-0x00000001898B6A10
	public static new ConfigShapeRect ParseFromJson(JSONNode node) => default; // 0x0000000182A0CDF0-0x0000000182A0D040
	// [XID] // 0x00000001898C12C0-0x00000001898C12E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB660 */, bool useObjectPool = false /* Metadata: 0x00AFB664 */) => default; // 0x0000000182A0C910-0x0000000182A0CC10
	// [XID] // 0x00000001898C8BE0-0x00000001898C8C00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB665 */, bool useObjectPool = false /* Metadata: 0x00AFB669 */) => default; // 0x0000000182A0B5A0-0x0000000182A0B920
	// [XID] // 0x00000001898D05A0-0x00000001898D05C0
	public static new ConfigShapeRect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB66A */, bool useObjectPool = false /* Metadata: 0x00AFB66E */) => default; // 0x0000000182A0C050-0x0000000182A0C270
	[BlackList] // 0x00000001898D7C00-0x00000001898D7C40
	// [XID] // 0x00000001898D7C00-0x00000001898D7C40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A0AD90-0x0000000182A0B060
	// [XID] // 0x00000001898E29C0-0x00000001898E29E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A0D200-0x0000000182A0D520
	[BlackList] // 0x00000001898EA410-0x00000001898EA450
	// [XID] // 0x00000001898EA410-0x00000001898EA450
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182A0C820-0x0000000182A0C910
	[BlackList] // 0x00000001898F4A00-0x00000001898F4A40
	// [XID] // 0x00000001898F4A00-0x00000001898F4A40
	public override void AutoAllocTypeFields() {} // 0x0000000182A0B060-0x0000000182A0B100
	[BlackList] // 0x00000001898FF270-0x00000001898FF2B0
	// [XID] // 0x00000001898FF270-0x00000001898FF2B0
	public override void AutoRecycleTypeFields() {} // 0x0000000182A0B100-0x0000000182A0B1F0
	[BlackList] // 0x0000000189909A20-0x0000000189909A60
	// [XID] // 0x0000000189909A20-0x0000000189909A60
	public override void ReturnToObjectPool() {} // 0x0000000182A0D650-0x0000000182A0D6F0
	// [XID] // 0x00000001899143C0-0x00000001899143E0
	public override BaseShape CreateShape(Vector3 position, Vector3 direction, bool useHeight, float height, float sizeRatio) => default; // 0x0000000182A0C270-0x0000000182A0C510
}

