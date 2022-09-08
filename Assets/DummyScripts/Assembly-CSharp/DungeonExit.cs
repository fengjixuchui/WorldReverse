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
public class DungeonExit : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 14977
{
	// Fields
	private SimpleSafeUInt32 entryPointIdRawNum; // 0x60

	// Properties
	public override RealScenePointType pointType { /* [XID] */ /* 0x0000000189780D80-0x0000000189780DA0 */ get => default; } // 0x000000018130BB30-0x000000018130BBD0 
	public uint entryPointId { /* [XID] */ /* 0x00000001897882E0-0x0000000189788300 */ get => default; /* [XID] */ /* 0x000000018978F8E0-0x000000018978F900 */ private set {} } // 0x000000018130B150-0x000000018130B220 0x000000018130A8A0-0x000000018130A980

	// Constructors
	public DungeonExit() {} // 0x000000018130C3C0-0x000000018130C420

	// Methods
	// [XID] // 0x00000001897970D0-0x00000001897970F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018130C230-0x000000018130C320
	// [XID] // 0x000000018979F0F0-0x000000018979F110
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018130BEE0-0x000000018130BF90
	// [XID] // 0x00000001897A6780-0x00000001897A67A0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD38 */) => default; // 0x000000018130BA50-0x000000018130BB30
	// [XID] // 0x00000001897ADDB0-0x00000001897ADDD0
	public override int GetHashNum() => default; // 0x000000018130A7D0-0x000000018130A8A0
	// [XID] // 0x00000001897B5ED0-0x00000001897B5EF0
	public override void InitEmpty() {} // 0x000000018130B4B0-0x000000018130B580
	[BlackList] // 0x00000001897BDC80-0x00000001897BDCC0
	// [XID] // 0x00000001897BDC80-0x00000001897BDCC0
	public override bool FromJson(JSONNode node) => default; // 0x000000018130ADD0-0x000000018130B150
	// [XID] // 0x00000001897C84B0-0x00000001897C84D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018130A000-0x000000018130A260
	[BlackList] // 0x00000001897CF8D0-0x00000001897CF910
	// [XID] // 0x00000001897CF8D0-0x00000001897CF910
	public static new DungeonExit ParseFromJson(JSONNode node) => default; // 0x000000018130BC30-0x000000018130BE80
	// [XID] // 0x00000001897DA5B0-0x00000001897DA5D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD39 */, bool useObjectPool = false /* Metadata: 0x00AEFD3D */) => default; // 0x000000018130B750-0x000000018130BA50
	// [XID] // 0x00000001897E1A00-0x00000001897E1A20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD3E */, bool useObjectPool = false /* Metadata: 0x00AEFD42 */) => default; // 0x000000018130AA60-0x000000018130ACD0
	// [XID] // 0x00000001897E9210-0x00000001897E9230
	public static new DungeonExit ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD43 */, bool useObjectPool = false /* Metadata: 0x00AEFD47 */) => default; // 0x000000018130B220-0x000000018130B440
	[BlackList] // 0x00000001897F0DA0-0x00000001897F0DE0
	// [XID] // 0x00000001897F0DA0-0x00000001897F0DE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018130A260-0x000000018130A530
	// [XID] // 0x00000001897FB810-0x00000001897FB830
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018130C000-0x000000018130C230
	[BlackList] // 0x0000000189802CC0-0x0000000189802D00
	// [XID] // 0x0000000189802CC0-0x0000000189802D00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018130B660-0x000000018130B750
	[BlackList] // 0x000000018980CF90-0x000000018980CFD0
	// [XID] // 0x000000018980CF90-0x000000018980CFD0
	public override void AutoAllocTypeFields() {} // 0x000000018130A530-0x000000018130A5D0
	[BlackList] // 0x0000000189817AA0-0x0000000189817AE0
	// [XID] // 0x0000000189817AA0-0x0000000189817AE0
	public override void AutoRecycleTypeFields() {} // 0x000000018130A5D0-0x000000018130A6B0
	[BlackList] // 0x0000000189822390-0x00000001898223D0
	// [XID] // 0x0000000189822390-0x00000001898223D0
	public override void ReturnToObjectPool() {} // 0x000000018130C320-0x000000018130C3C0
}

