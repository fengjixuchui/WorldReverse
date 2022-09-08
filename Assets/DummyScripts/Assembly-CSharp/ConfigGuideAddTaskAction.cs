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
public class ConfigGuideAddTaskAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18317
{
	// Fields
	private string _taskName; // 0x18

	// Properties
	public string taskName { /* [XID] */ /* 0x0000000189996D60-0x0000000189996D80 */ get => default; /* [XID] */ /* 0x000000018999E9B0-0x000000018999E9D0 */ private set {} } // 0x000000018313C9E0-0x000000018313CA80 0x000000018313C6E0-0x000000018313C790

	// Constructors
	public ConfigGuideAddTaskAction() {} // 0x000000018313CFD0-0x000000018313D030

	// Methods
	// [XID] // 0x00000001899A6350-0x00000001899A6370
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018313CE40-0x000000018313CF30
	// [XID] // 0x00000001899AD980-0x00000001899AD9A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018313CAE0-0x000000018313CBC0
	// [XID] // 0x00000001899B5260-0x00000001899B5280
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF93FB */) => default; // 0x000000018313C5A0-0x000000018313C680
	// [XID] // 0x00000001899BC910-0x00000001899BC930
	public override int GetHashNum() => default; // 0x000000018313B300-0x000000018313B3D0
	// [XID] // 0x00000001899C4320-0x00000001899C4340
	public override void InitEmpty() {} // 0x000000018313BF90-0x000000018313C060
	[BlackList] // 0x00000001899CBA80-0x00000001899CBAC0
	// [XID] // 0x00000001899CBA80-0x00000001899CBAC0
	public override bool FromJson(JSONNode node) => default; // 0x000000018313B980-0x000000018313BD00
	// [XID] // 0x00000001899D5F90-0x00000001899D5FB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018313AB90-0x000000018313ADC0
	[BlackList] // 0x00000001899DD3C0-0x00000001899DD400
	// [XID] // 0x00000001899DD3C0-0x00000001899DD400
	public static new ConfigGuideAddTaskAction ParseFromJson(JSONNode node) => default; // 0x000000018313C790-0x000000018313C9E0
	// [XID] // 0x00000001899E7F40-0x00000001899E7F60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93FC */, bool useObjectPool = false /* Metadata: 0x00AF9400 */) => default; // 0x000000018313C2A0-0x000000018313C5A0
	// [XID] // 0x00000001899EF3D0-0x00000001899EF3F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9401 */, bool useObjectPool = false /* Metadata: 0x00AF9405 */) => default; // 0x000000018313B610-0x000000018313B880
	// [XID] // 0x00000001899F6D50-0x00000001899F6D70
	public static new ConfigGuideAddTaskAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9406 */, bool useObjectPool = false /* Metadata: 0x00AF940A */) => default; // 0x000000018313BD00-0x000000018313BF20
	[BlackList] // 0x00000001899FE490-0x00000001899FE4D0
	// [XID] // 0x00000001899FE490-0x00000001899FE4D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018313ADC0-0x000000018313B090
	// [XID] // 0x0000000189A08970-0x0000000189A08990
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018313CC40-0x000000018313CE40
	[BlackList] // 0x0000000189A0FEF0-0x0000000189A0FF30
	// [XID] // 0x0000000189A0FEF0-0x0000000189A0FF30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018313C1B0-0x000000018313C2A0
	// [XID] // 0x0000000189A1A3B0-0x0000000189A1A3D0
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x000000018313B4B0-0x000000018313B610
	// [XID] // 0x0000000189A21A90-0x0000000189A21AB0
	protected override bool Stop() => default; // 0x000000018313AAF0-0x000000018313AB90
	[BlackList] // 0x0000000189A28FE0-0x0000000189A29020
	// [XID] // 0x0000000189A28FE0-0x0000000189A29020
	public override void AutoAllocTypeFields() {} // 0x000000018313B090-0x000000018313B130
	[BlackList] // 0x0000000189A33500-0x0000000189A33540
	// [XID] // 0x0000000189A33500-0x0000000189A33540
	public override void AutoRecycleTypeFields() {} // 0x000000018313B130-0x000000018313B1E0
	[BlackList] // 0x0000000189A3DE90-0x0000000189A3DED0
	// [XID] // 0x0000000189A3DE90-0x0000000189A3DED0
	public override void ReturnToObjectPool() {} // 0x000000018313CF30-0x000000018313CFD0
}

