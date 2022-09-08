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
public class ConfigEffectAttachBox : ConfigEffectAttachShape, IAutoAllocRecycle // TypeDefIndex: 17702
{
	// Fields
	private ParticleShapeType _emitFrom; // 0x10
	private SimpleSafeFloat scaleXRawNum; // 0x14
	private SimpleSafeFloat scaleYRawNum; // 0x18
	private SimpleSafeFloat scaleZRawNum; // 0x1C

	// Properties
	public ParticleShapeType emitFrom { /* [XID] */ /* 0x000000018994EAA0-0x000000018994EAC0 */ get => default; /* [XID] */ /* 0x0000000189956080-0x00000001899560A0 */ private set {} } // 0x0000000182531100-0x00000001825311A0 0x00000001825324E0-0x0000000182532590
	public float scaleX { /* [XID] */ /* 0x000000018995DB70-0x000000018995DB90 */ get => default; /* [XID] */ /* 0x0000000189A6A5E0-0x0000000189A6A600 */ set {} } // 0x00000001825320A0-0x0000000182532180 0x0000000182531620-0x0000000182531700
	public float scaleY { /* [XID] */ /* 0x000000018996C870-0x000000018996C890 */ get => default; /* [XID] */ /* 0x0000000189B09D70-0x0000000189B09D90 */ set {} } // 0x0000000182532590-0x0000000182532670 0x0000000182532BE0-0x0000000182532CC0
	public float scaleZ { /* [XID] */ /* 0x000000018997B9E0-0x000000018997BA00 */ get => default; /* [XID] */ /* 0x0000000189983590-0x00000001899835B0 */ set {} } // 0x0000000182532A10-0x0000000182532AF0 0x0000000182530C00-0x0000000182530CE0

	// Constructors
	public ConfigEffectAttachBox() {} // 0x0000000182532D60-0x0000000182532E20

	// Methods
	// [XID] // 0x000000018998AD20-0x000000018998AD40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182532AF0-0x0000000182532BE0
	// [XID] // 0x00000001899925F0-0x0000000189992610
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182532430-0x00000001825324E0
	// [XID] // 0x000000018999A310-0x000000018999A330
	public override ConfigEffectAttachShape Clone(bool useObjectPool = false /* Metadata: 0x00AF784B */) => default; // 0x0000000182531F60-0x0000000182532040
	// [XID] // 0x00000001899A19F0-0x00000001899A1A10
	public override int GetHashNum() => default; // 0x0000000182530AD0-0x0000000182530BA0
	// [XID] // 0x00000001899A9280-0x00000001899A92A0
	public override void InitEmpty() {} // 0x0000000182531990-0x0000000182531A90
	[BlackList] // 0x00000001899B0D50-0x00000001899B0D90
	// [XID] // 0x00000001899B0D50-0x00000001899B0D90
	public override bool FromJson(JSONNode node) => default; // 0x00000001825312A0-0x0000000182531620
	// [XID] // 0x00000001899BB170-0x00000001899BB190
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018252FFF0-0x0000000182530530
	[BlackList] // 0x00000001899C2B80-0x00000001899C2BC0
	// [XID] // 0x00000001899C2B80-0x00000001899C2BC0
	public static new ConfigEffectAttachBox ParseFromJson(JSONNode node) => default; // 0x0000000182532180-0x00000001825323D0
	// [XID] // 0x00000001899CD2D0-0x00000001899CD2F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF784C */, bool useObjectPool = false /* Metadata: 0x00AF7850 */) => default; // 0x0000000182531C60-0x0000000182531F60
	// [XID] // 0x00000001899D47B0-0x00000001899D47D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7851 */, bool useObjectPool = false /* Metadata: 0x00AF7855 */) => default; // 0x0000000182530D60-0x0000000182531100
	// [XID] // 0x00000001899DBE70-0x00000001899DBE90
	public static new ConfigEffectAttachBox ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7856 */, bool useObjectPool = false /* Metadata: 0x00AF785A */) => default; // 0x0000000182531700-0x0000000182531920
	[BlackList] // 0x00000001899E3830-0x00000001899E3870
	// [XID] // 0x00000001899E3830-0x00000001899E3870
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182530530-0x0000000182530800
	// [XID] // 0x00000001899EDE20-0x00000001899EDE40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182532670-0x0000000182532A10
	[BlackList] // 0x00000001899F5650-0x00000001899F5690
	// [XID] // 0x00000001899F5650-0x00000001899F5690
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182531B70-0x0000000182531C60
	[BlackList] // 0x00000001899FFAE0-0x00000001899FFB20
	// [XID] // 0x00000001899FFAE0-0x00000001899FFB20
	public override void AutoAllocTypeFields() {} // 0x0000000182530800-0x00000001825308A0
	[BlackList] // 0x0000000189A0A260-0x0000000189A0A2A0
	// [XID] // 0x0000000189A0A260-0x0000000189A0A2A0
	public override void AutoRecycleTypeFields() {} // 0x00000001825308A0-0x00000001825309B0
	[BlackList] // 0x0000000189A14AA0-0x0000000189A14AE0
	// [XID] // 0x0000000189A14AA0-0x0000000189A14AE0
	public override void ReturnToObjectPool() {} // 0x0000000182532CC0-0x0000000182532D60
}

