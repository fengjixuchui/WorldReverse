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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class DungeonQuitPoint : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 14979
{
	// Fields
	private MoleMole.Config.Vector _size; // 0x60

	// Properties
	public override RealScenePointType pointType { /* [XID] */ /* 0x0000000189911AE0-0x0000000189911B00 */ get => default; } // 0x000000018376D660-0x000000018376D700 
	public MoleMole.Config.Vector size { /* [XID] */ /* 0x0000000189919640-0x0000000189919660 */ get => default; /* [XID] */ /* 0x0000000189920B10-0x0000000189920B30 */ private set {} } // 0x000000018376DD90-0x000000018376DE70 0x000000018376D1B0-0x000000018376D280

	// Constructors
	public DungeonQuitPoint() {} // 0x000000018376E000-0x000000018376E060

	// Methods
	// [XID] // 0x0000000189928590-0x00000001899285B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018376DE70-0x000000018376DF60
	// [XID] // 0x000000018992F9E0-0x000000018992FA00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018376DA10-0x000000018376DAC0
	// [XID] // 0x0000000189936F50-0x0000000189936F70
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD58 */) => default; // 0x000000018376D580-0x000000018376D660
	// [XID] // 0x000000018993EB10-0x000000018993EB30
	public override int GetHashNum() => default; // 0x000000018376C400-0x000000018376C4D0
	// [XID] // 0x00000001899461C0-0x00000001899461E0
	public override void InitEmpty() {} // 0x000000018376CF10-0x000000018376CFE0
	[BlackList] // 0x000000018994D6F0-0x000000018994D730
	// [XID] // 0x000000018994D6F0-0x000000018994D730
	public override bool FromJson(JSONNode node) => default; // 0x000000018376C900-0x000000018376CC80
	// [XID] // 0x0000000189957FC0-0x0000000189957FE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018376BC90-0x000000018376BEB0
	[BlackList] // 0x000000018995F7D0-0x000000018995F810
	// [XID] // 0x000000018995F7D0-0x000000018995F810
	public static new DungeonQuitPoint ParseFromJson(JSONNode node) => default; // 0x000000018376D760-0x000000018376D9B0
	// [XID] // 0x0000000189969E00-0x0000000189969E20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD59 */, bool useObjectPool = false /* Metadata: 0x00AEFD5D */) => default; // 0x000000018376D280-0x000000018376D580
	// [XID] // 0x0000000189971BC0-0x0000000189971BE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD5E */, bool useObjectPool = false /* Metadata: 0x00AEFD62 */) => default; // 0x000000018376C5B0-0x000000018376C800
	// [XID] // 0x0000000189979430-0x0000000189979450
	public static new DungeonQuitPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD63 */, bool useObjectPool = false /* Metadata: 0x00AEFD67 */) => default; // 0x000000018376CC80-0x000000018376CEA0
	[BlackList] // 0x0000000189980560-0x00000001899805A0
	// [XID] // 0x0000000189980560-0x00000001899805A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018376BEB0-0x000000018376C180
	// [XID] // 0x000000018998B140-0x000000018998B160
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018376DB30-0x000000018376DD90
	[BlackList] // 0x0000000189992C90-0x0000000189992CD0
	// [XID] // 0x0000000189992C90-0x0000000189992CD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018376D0C0-0x000000018376D1B0
	[BlackList] // 0x000000018999D5F0-0x000000018999D630
	// [XID] // 0x000000018999D5F0-0x000000018999D630
	public override void AutoAllocTypeFields() {} // 0x000000018376C180-0x000000018376C220
	[BlackList] // 0x00000001899A8140-0x00000001899A8180
	// [XID] // 0x00000001899A8140-0x00000001899A8180
	public override void AutoRecycleTypeFields() {} // 0x000000018376C220-0x000000018376C2E0
	[BlackList] // 0x00000001899B2BD0-0x00000001899B2C10
	// [XID] // 0x00000001899B2BD0-0x00000001899B2C10
	public override void ReturnToObjectPool() {} // 0x000000018376DF60-0x000000018376E000
}

