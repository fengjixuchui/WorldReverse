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
public class ConfigBornByStormLightning : ConfigBornType, IAutoAllocRecycle // TypeDefIndex: 17864
{
	// Fields
	private SimpleSafeFloat hitHeightRatioRawNum; // 0x38
	private SimpleSafeFloat selectRangeRawNum; // 0x3C
	private SimpleSafeFloat maxOffsetLenRawNum; // 0x40
	private SimpleSafeFloat lightningHitOrNotRatioRawNum; // 0x44

	// Properties
	public float hitHeightRatio { /* [XID] */ /* 0x00000001899D1940-0x00000001899D1960 */ get => default; /* [XID] */ /* 0x00000001899D8E90-0x00000001899D8EB0 */ private set {} } // 0x0000000184212FF0-0x00000001842130D0 0x0000000184213FE0-0x00000001842140C0
	public float selectRange { /* [XID] */ /* 0x00000001899E0480-0x00000001899E04A0 */ get => default; /* [XID] */ /* 0x00000001899E7FE0-0x00000001899E8000 */ private set {} } // 0x0000000184213DB0-0x0000000184213E90 0x0000000184215130-0x0000000184215210
	public float maxOffsetLen { /* [XID] */ /* 0x0000000189A13D70-0x0000000189A13D90 */ get => default; /* [XID] */ /* 0x00000001899F6DF0-0x00000001899F6E10 */ private set {} } // 0x00000001842143B0-0x0000000184214490 0x0000000184213550-0x0000000184213630
	public float lightningHitOrNotRatio { /* [XID] */ /* 0x00000001899FE650-0x00000001899FE670 */ get => default; /* [XID] */ /* 0x0000000189A05E70-0x0000000189A05E90 */ private set {} } // 0x0000000184213E90-0x0000000184213F70 0x00000001842136B0-0x0000000184213790

	// Constructors
	public ConfigBornByStormLightning() {} // 0x00000001842152B0-0x0000000184215390

	// Methods
	// [XID] // 0x0000000189A0D1C0-0x0000000189A0D1E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184214FE0-0x0000000184215130
	// [XID] // 0x0000000189A14A60-0x0000000189A14A80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184214B80-0x0000000184214C30
	// [XID] // 0x0000000189A1BCF0-0x0000000189A1BD10
	public override ConfigBornType Clone(bool useObjectPool = false /* Metadata: 0x00AF7F79 */) => default; // 0x0000000184214790-0x0000000184214870
	// [XID] // 0x0000000189A234E0-0x0000000189A23500
	public override int GetHashNum() => default; // 0x0000000184212F20-0x0000000184212FF0
	// [XID] // 0x0000000189A2A900-0x0000000189A2A920
	public override void InitEmpty() {} // 0x00000001842140C0-0x00000001842141E0
	[BlackList] // 0x0000000189A31E00-0x0000000189A31E40
	// [XID] // 0x0000000189A31E00-0x0000000189A31E40
	public override bool FromJson(JSONNode node) => default; // 0x0000000184213810-0x0000000184213B90
	// [XID] // 0x0000000189A3C570-0x0000000189A3C590
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184212410-0x0000000184212970
	[BlackList] // 0x0000000189A44050-0x0000000189A44090
	// [XID] // 0x0000000189A44050-0x0000000189A44090
	public static new ConfigBornByStormLightning ParseFromJson(JSONNode node) => default; // 0x00000001842148D0-0x0000000184214B20
	// [XID] // 0x0000000189A4E7F0-0x0000000189A4E810
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F7A */, bool useObjectPool = false /* Metadata: 0x00AF7F7E */) => default; // 0x0000000184214490-0x0000000184214790
	// [XID] // 0x0000000189A55EE0-0x0000000189A55F00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F7F */, bool useObjectPool = false /* Metadata: 0x00AF7F83 */) => default; // 0x00000001842131B0-0x0000000184213550
	// [XID] // 0x0000000189A5D8A0-0x0000000189A5D8C0
	public static new ConfigBornByStormLightning ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F84 */, bool useObjectPool = false /* Metadata: 0x00AF7F88 */) => default; // 0x0000000184213B90-0x0000000184213DB0
	[BlackList] // 0x0000000189A65060-0x0000000189A650A0
	// [XID] // 0x0000000189A65060-0x0000000189A650A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184212970-0x0000000184212C40
	// [XID] // 0x0000000189A6F820-0x0000000189A6F840
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184214C30-0x0000000184214FE0
	[BlackList] // 0x0000000189A76F30-0x0000000189A76F70
	// [XID] // 0x0000000189A76F30-0x0000000189A76F70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001842142C0-0x00000001842143B0
	[BlackList] // 0x0000000189A81950-0x0000000189A81990
	// [XID] // 0x0000000189A81950-0x0000000189A81990
	public override void AutoAllocTypeFields() {} // 0x0000000184212C40-0x0000000184212CE0
	[BlackList] // 0x0000000189A8C390-0x0000000189A8C3D0
	// [XID] // 0x0000000189A8C390-0x0000000189A8C3D0
	public override void AutoRecycleTypeFields() {} // 0x0000000184212CE0-0x0000000184212E00
	[BlackList] // 0x0000000189A96A20-0x0000000189A96A60
	// [XID] // 0x0000000189A96A20-0x0000000189A96A60
	public override void ReturnToObjectPool() {} // 0x0000000184215210-0x00000001842152B0
}

