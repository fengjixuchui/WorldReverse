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
public class ConfigFireGrassAirflowField : ConfigAirflowField, IAutoAllocRecycle // TypeDefIndex: 18920
{
	// Fields
	private bool _enable; // 0x88
	private SimpleSafeUInt32 triggerNumRawNum; // 0x8C
	private SimpleSafeFloat heightRawNum; // 0x90
	private SimpleSafeFloat heightSpeedRawNum; // 0x94

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189ADDA50-0x0000000189ADDA70 */ get => default; /* [XID] */ /* 0x0000000189AE5320-0x0000000189AE5340 */ private set {} } // 0x0000000183ED4C90-0x0000000183ED4D40 0x0000000183ED5A20-0x0000000183ED5AD0
	public uint triggerNum { /* [XID] */ /* 0x0000000189AEC8E0-0x0000000189AEC900 */ get => default; /* [XID] */ /* 0x0000000189AF4370-0x0000000189AF4390 */ private set {} } // 0x0000000183ED5700-0x0000000183ED57D0 0x0000000183ED3F40-0x0000000183ED4020
	public float height { /* [XID] */ /* 0x0000000189AFBAC0-0x0000000189AFBAE0 */ get => default; /* [XID] */ /* 0x0000000189B031F0-0x0000000189B03210 */ private set {} } // 0x0000000183ED6180-0x0000000183ED6260 0x0000000183ED5AD0-0x0000000183ED5BB0
	public float heightSpeed { /* [XID] */ /* 0x0000000189B0A910-0x0000000189B0A930 */ get => default; /* [XID] */ /* 0x0000000189B11FE0-0x0000000189B12000 */ private set {} } // 0x0000000183ED60A0-0x0000000183ED6180 0x0000000183ED4210-0x0000000183ED42F0

	// Constructors
	public ConfigFireGrassAirflowField() {} // 0x0000000183ED6450-0x0000000183ED64C0

	// Methods
	// [XID] // 0x0000000189B19390-0x0000000189B193B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183ED6260-0x0000000183ED63B0
	// [XID] // 0x0000000189B209B0-0x0000000189B209D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183ED5C10-0x0000000183ED5CC0
	// [XID] // 0x0000000189B28030-0x0000000189B28050
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AFB3AB */) => default; // 0x0000000183ED55C0-0x0000000183ED56A0
	// [XID] // 0x0000000189B2F410-0x0000000189B2F430
	public override int GetHashNum() => default; // 0x0000000183ED4140-0x0000000183ED4210
	// [XID] // 0x0000000189B36CD0-0x0000000189B36CF0
	public override void InitEmpty() {} // 0x0000000183ED4FD0-0x0000000183ED50F0
	[BlackList] // 0x0000000189B3E520-0x0000000189B3E560
	// [XID] // 0x0000000189B3E520-0x0000000189B3E560
	public override bool FromJson(JSONNode node) => default; // 0x0000000183ED4910-0x0000000183ED4C90
	// [XID] // 0x0000000189B49140-0x0000000189B49160
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183ED3520-0x0000000183ED3AA0
	[BlackList] // 0x0000000189B50780-0x0000000189B507C0
	// [XID] // 0x0000000189B50780-0x0000000189B507C0
	public static new ConfigFireGrassAirflowField ParseFromJson(JSONNode node) => default; // 0x0000000183ED57D0-0x0000000183ED5A20
	// [XID] // 0x0000000189B5AF10-0x0000000189B5AF30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3AC */, bool useObjectPool = false /* Metadata: 0x00AFB3B0 */) => default; // 0x0000000183ED52C0-0x0000000183ED55C0
	// [XID] // 0x0000000189B62350-0x0000000189B62370
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3B1 */, bool useObjectPool = false /* Metadata: 0x00AFB3B5 */) => default; // 0x0000000183ED43D0-0x0000000183ED4810
	// [XID] // 0x0000000189B69FF0-0x0000000189B6A010
	public static new ConfigFireGrassAirflowField ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB3B6 */, bool useObjectPool = false /* Metadata: 0x00AFB3BA */) => default; // 0x0000000183ED4D40-0x0000000183ED4F60
	[BlackList] // 0x0000000189B71610-0x0000000189B71650
	// [XID] // 0x0000000189B71610-0x0000000189B71650
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183ED3AA0-0x0000000183ED3D70
	// [XID] // 0x0000000189B7B8F0-0x0000000189B7B910
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183ED5CC0-0x0000000183ED60A0
	[BlackList] // 0x0000000189B83280-0x0000000189B832C0
	// [XID] // 0x0000000189B83280-0x0000000189B832C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183ED51D0-0x0000000183ED52C0
	[BlackList] // 0x0000000189B8D490-0x0000000189B8D4D0
	// [XID] // 0x0000000189B8D490-0x0000000189B8D4D0
	public override void AutoAllocTypeFields() {} // 0x0000000183ED3D70-0x0000000183ED3E10
	[BlackList] // 0x0000000189B97A60-0x0000000189B97AA0
	// [XID] // 0x0000000189B97A60-0x0000000189B97AA0
	public override void AutoRecycleTypeFields() {} // 0x0000000183ED3E10-0x0000000183ED3F40
	[BlackList] // 0x0000000189BA2150-0x0000000189BA2190
	// [XID] // 0x0000000189BA2150-0x0000000189BA2190
	public override void ReturnToObjectPool() {} // 0x0000000183ED63B0-0x0000000183ED6450
}

