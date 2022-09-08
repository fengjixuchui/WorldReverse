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
public class ConfigSimpleMove : ConfigMove, IAutoAllocRecycle // TypeDefIndex: 18576
{
	// Fields
	private SimpleSafeFloat constSpeedRatioRawNum; // 0x18
	private bool _followReferenceSystem; // 0x1C

	// Properties
	public float constSpeedRatio { /* [XID] */ /* 0x000000018979D550-0x000000018979D570 */ get => default; /* [XID] */ /* 0x00000001897A4850-0x00000001897A4870 */ private set {} } // 0x00000001825ECD90-0x00000001825ECE70 0x00000001825EE760-0x00000001825EE840
	public bool followReferenceSystem { /* [XID] */ /* 0x00000001897ABE00-0x00000001897ABE20 */ get => default; /* [XID] */ /* 0x00000001897B3D70-0x00000001897B3D90 */ private set {} } // 0x00000001825EE320-0x00000001825EE3C0 0x00000001825ECB30-0x00000001825ECBE0

	// Constructors
	public ConfigSimpleMove() {} // 0x00000001825EE8E0-0x00000001825EE950

	// Methods
	// [XID] // 0x00000001897BBB50-0x00000001897BBB70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001825EE650-0x00000001825EE760
	// [XID] // 0x00000001897C3390-0x00000001897C33B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001825EE270-0x00000001825EE320
	// [XID] // 0x00000001897CAB10-0x00000001897CAB30
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA49B */) => default; // 0x00000001825EDE80-0x00000001825EDF60
	// [XID] // 0x00000001897D2170-0x00000001897D2190
	public override int GetHashNum() => default; // 0x00000001825ECC60-0x00000001825ECD30
	// [XID] // 0x00000001897DA030-0x00000001897DA050
	public override void InitEmpty() {} // 0x00000001825ED8E0-0x00000001825ED9B0
	[BlackList] // 0x00000001897E12A0-0x00000001897E12E0
	// [XID] // 0x00000001897E12A0-0x00000001897E12E0
	public override bool FromJson(JSONNode node) => default; // 0x00000001825ED2D0-0x00000001825ED650
	// [XID] // 0x00000001897EBEA0-0x00000001897EBEC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001825EC310-0x00000001825EC640
	[BlackList] // 0x00000001897F37F0-0x00000001897F3830
	// [XID] // 0x00000001897F37F0-0x00000001897F3830
	public static new ConfigSimpleMove ParseFromJson(JSONNode node) => default; // 0x00000001825EDFC0-0x00000001825EE210
	// [XID] // 0x00000001897FDC00-0x00000001897FDC20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA49C */, bool useObjectPool = false /* Metadata: 0x00AFA4A0 */) => default; // 0x00000001825EDB80-0x00000001825EDE80
	// [XID] // 0x0000000189805350-0x0000000189805370
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA4A1 */, bool useObjectPool = false /* Metadata: 0x00AFA4A5 */) => default; // 0x00000001825ECEF0-0x00000001825ED1D0
	// [XID] // 0x000000018980C970-0x000000018980C990
	public static new ConfigSimpleMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA4A6 */, bool useObjectPool = false /* Metadata: 0x00AFA4AA */) => default; // 0x00000001825ED650-0x00000001825ED870
	[BlackList] // 0x00000001898140D0-0x0000000189814110
	// [XID] // 0x00000001898140D0-0x0000000189814110
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001825EC640-0x00000001825EC910
	// [XID] // 0x000000018981EC60-0x000000018981EC80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001825EE3C0-0x00000001825EE650
	[BlackList] // 0x0000000189826130-0x0000000189826170
	// [XID] // 0x0000000189826130-0x0000000189826170
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001825EDA90-0x00000001825EDB80
	[BlackList] // 0x0000000189830800-0x0000000189830840
	// [XID] // 0x0000000189830800-0x0000000189830840
	public override void AutoAllocTypeFields() {} // 0x00000001825EC910-0x00000001825EC9B0
	[BlackList] // 0x000000018983AE20-0x000000018983AE60
	// [XID] // 0x000000018983AE20-0x000000018983AE60
	public override void AutoRecycleTypeFields() {} // 0x00000001825EC9B0-0x00000001825ECA90
	[BlackList] // 0x0000000189845410-0x0000000189845450
	// [XID] // 0x0000000189845410-0x0000000189845450
	public override void ReturnToObjectPool() {} // 0x00000001825EE840-0x00000001825EE8E0
}

