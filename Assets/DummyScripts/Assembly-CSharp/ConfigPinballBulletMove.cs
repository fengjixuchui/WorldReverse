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
public class ConfigPinballBulletMove : ConfigBulletMove, IAutoAllocRecycle // TypeDefIndex: 18614
{
	// Fields
	private SimpleSafeFloat radiusRawNum; // 0x58
	private bool _traceOnYAxis; // 0x5C
	private bool _destroyWhenTargetDie; // 0x5D
	private SimpleSafeFloat randomBackAngleAddedRawNum; // 0x60
	private SimpleSafeFloat reboundIntervalRawNum; // 0x64
	private SimpleSafeFloat outOfRangeFixCDRawNum; // 0x68

	// Properties
	public float radius { /* [XID] */ /* 0x00000001897B57D0-0x00000001897B57F0 */ get => default; /* [XID] */ /* 0x00000001897BD500-0x00000001897BD520 */ private set {} } // 0x0000000184647100-0x00000001846471E0 0x00000001846478C0-0x00000001846479A0
	public bool traceOnYAxis { /* [XID] */ /* 0x00000001897C48C0-0x00000001897C48E0 */ get => default; /* [XID] */ /* 0x00000001897CC050-0x00000001897CC070 */ private set {} } // 0x0000000184646420-0x00000001846464C0 0x0000000184647810-0x00000001846478C0
	public bool destroyWhenTargetDie { /* [XID] */ /* 0x00000001897D39C0-0x00000001897D39E0 */ get => default; /* [XID] */ /* 0x00000001897DB450-0x00000001897DB470 */ private set {} } // 0x0000000184645B60-0x0000000184645C00 0x0000000184645C80-0x0000000184645D30
	public float randomBackAngleAdded { /* [XID] */ /* 0x0000000189AEBDD0-0x0000000189AEBDF0 */ get => default; /* [XID] */ /* 0x00000001897EA2A0-0x00000001897EA2C0 */ private set {} } // 0x00000001846444B0-0x0000000184644590 0x00000001846460B0-0x0000000184646190
	public float reboundInterval { /* [XID] */ /* 0x00000001897F1F50-0x00000001897F1F70 */ get => default; /* [XID] */ /* 0x00000001897F97E0-0x00000001897F9800 */ private set {} } // 0x0000000184646F10-0x0000000184646FF0 0x0000000184645A00-0x0000000184645AE0
	public float outOfRangeFixCD { /* [XID] */ /* 0x0000000189AF3820-0x0000000189AF3840 */ get => default; /* [XID] */ /* 0x0000000189808280-0x00000001898082A0 */ private set {} } // 0x00000001846464C0-0x00000001846465A0 0x0000000184645380-0x0000000184645460

	// Constructors
	public ConfigPinballBulletMove() {} // 0x0000000184647A40-0x0000000184647B00

	// Methods
	// [XID] // 0x000000018980FC70-0x000000018980FC90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184647690-0x0000000184647810
	// [XID] // 0x0000000189817300-0x0000000189817320
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184647050-0x0000000184647100
	// [XID] // 0x000000018981EC40-0x000000018981EC60
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA5D5 */) => default; // 0x0000000184646B80-0x0000000184646C60
	// [XID] // 0x0000000189826110-0x0000000189826130
	public override int GetHashNum() => default; // 0x00000001846452B0-0x0000000184645380
	// [XID] // 0x000000018982D700-0x000000018982D720
	public override void InitEmpty() {} // 0x00000001846465A0-0x00000001846466B0
	[BlackList] // 0x0000000189834E90-0x0000000189834ED0
	// [XID] // 0x0000000189834E90-0x0000000189834ED0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184645D30-0x00000001846460B0
	// [XID] // 0x000000018983F510-0x000000018983F530
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184644610-0x0000000184644D00
	[BlackList] // 0x0000000189846B90-0x0000000189846BD0
	// [XID] // 0x0000000189846B90-0x0000000189846BD0
	public static new ConfigPinballBulletMove ParseFromJson(JSONNode node) => default; // 0x0000000184646CC0-0x0000000184646F10
	// [XID] // 0x00000001898510D0-0x00000001898510F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5D6 */, bool useObjectPool = false /* Metadata: 0x00AFA5DA */) => default; // 0x0000000184646880-0x0000000184646B80
	// [XID] // 0x0000000189858580-0x00000001898585A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5DB */, bool useObjectPool = false /* Metadata: 0x00AFA5DF */) => default; // 0x0000000184645540-0x0000000184645A00
	// [XID] // 0x000000018985F5B0-0x000000018985F5D0
	public static new ConfigPinballBulletMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA5E0 */, bool useObjectPool = false /* Metadata: 0x00AFA5E4 */) => default; // 0x0000000184646190-0x00000001846463B0
	[BlackList] // 0x0000000189866E50-0x0000000189866E90
	// [XID] // 0x0000000189866E50-0x0000000189866E90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184644D00-0x0000000184644FD0
	// [XID] // 0x0000000189871250-0x0000000189871270
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001846471E0-0x0000000184647690
	[BlackList] // 0x0000000189878BB0-0x0000000189878BF0
	// [XID] // 0x0000000189878BB0-0x0000000189878BF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184646790-0x0000000184646880
	[BlackList] // 0x0000000189882C50-0x0000000189882C90
	// [XID] // 0x0000000189882C50-0x0000000189882C90
	public override void AutoAllocTypeFields() {} // 0x0000000184644FD0-0x0000000184645070
	[BlackList] // 0x000000018988D260-0x000000018988D2A0
	// [XID] // 0x000000018988D260-0x000000018988D2A0
	public override void AutoRecycleTypeFields() {} // 0x0000000184645070-0x0000000184645190
	[BlackList] // 0x0000000189897720-0x0000000189897760
	// [XID] // 0x0000000189897720-0x0000000189897760
	public override void ReturnToObjectPool() {} // 0x00000001846479A0-0x0000000184647A40
}

