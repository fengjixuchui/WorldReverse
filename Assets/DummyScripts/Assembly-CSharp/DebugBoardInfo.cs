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
public sealed class DebugBoardInfo : DebugBlletinInfo, IAutoAllocRecycle // TypeDefIndex: 14933
{
	// Fields
	private SimpleSafeUInt32 typeRawNum; // 0x30
	private string _title; // 0x38
	private string _location; // 0x40
	private SimpleSafeUInt32 scene_idRawNum; // 0x48
	private Vector3? _pos; // 0x4C

	// Properties
	public uint type { /* [XID] */ /* 0x00000001899B6DB0-0x00000001899B6DD0 */ get => default; /* [XID] */ /* 0x00000001899BE870-0x00000001899BE890 */ private set {} } // 0x00000001847E9C80-0x00000001847E9D50 0x00000001847E95C0-0x00000001847E96A0
	public string title { /* [XID] */ /* 0x00000001899C60D0-0x00000001899C60F0 */ get => default; /* [XID] */ /* 0x00000001899CD850-0x00000001899CD870 */ private set {} } // 0x00000001847E91A0-0x00000001847E9240 0x00000001847E8930-0x00000001847E89E0
	public string location { /* [XID] */ /* 0x00000001899D4D50-0x00000001899D4D70 */ get => default; /* [XID] */ /* 0x00000001899DC430-0x00000001899DC450 */ private set {} } // 0x00000001847E96A0-0x00000001847E9740 0x00000001847E7FC0-0x00000001847E8070
	public uint scene_id { /* [XID] */ /* 0x00000001899E3C50-0x00000001899E3C70 */ get => default; /* [XID] */ /* 0x00000001899EB060-0x00000001899EB080 */ private set {} } // 0x00000001847E7940-0x00000001847E7A10 0x00000001847E7860-0x00000001847E7940
	public Vector3 pos { /* [XID] */ /* 0x0000000189A86690-0x0000000189A866B0 */ get => default; } // 0x00000001847E8470-0x00000001847E8740 

	// Constructors
	public DebugBoardInfo(uint type, string title, string content, string author, string location, uint scene_id) {} // 0x00000001847E9DF0-0x00000001847E9EB0
	public DebugBoardInfo() {} // 0x00000001847E9EB0-0x00000001847E9F10

	// Methods
	// [XID] // 0x00000001899F2C80-0x00000001899F2CA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001847E9B30-0x00000001847E9C80
	// [XID] // 0x00000001899FA310-0x00000001899FA330
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847E94C0-0x00000001847E95C0
	// [XID] // 0x0000000189A01690-0x0000000189A016B0
	public override DebugBlletinInfo Clone(bool useObjectPool = false /* Metadata: 0x00AEFA96 */) => default; // 0x00000001847E9050-0x00000001847E9140
	// [XID] // 0x0000000189A09110-0x0000000189A09130
	public override int GetHashNum() => default; // 0x00000001847E7790-0x00000001847E7860
	// [XID] // 0x0000000189A105F0-0x0000000189A10610
	public override void InitEmpty() {} // 0x00000001847E8A50-0x00000001847E8B80
	[BlackList] // 0x0000000189A17C10-0x0000000189A17C50
	// [XID] // 0x0000000189A17C10-0x0000000189A17C50
	public override bool FromJson(JSONNode node) => default; // 0x00000001847E80F0-0x00000001847E8470
	// [XID] // 0x0000000189A22350-0x0000000189A22370
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001847E6CC0-0x00000001847E71F0
	[BlackList] // 0x0000000189A296E0-0x0000000189A29720
	// [XID] // 0x0000000189A296E0-0x0000000189A29720
	public static new DebugBoardInfo ParseFromJson(JSONNode node) => default; // 0x00000001847E9240-0x00000001847E9460
	// [XID] // 0x0000000189A33C20-0x0000000189A33C40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA97 */, bool useObjectPool = false /* Metadata: 0x00AEFA9B */) => default; // 0x00000001847E8D50-0x00000001847E9050
	// [XID] // 0x0000000189A3B380-0x0000000189A3B3A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA9C */, bool useObjectPool = false /* Metadata: 0x00AEFAA0 */) => default; // 0x00000001847E7AF0-0x00000001847E7F40
	// [XID] // 0x0000000189A42E50-0x0000000189A42E70
	public static new DebugBoardInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAA1 */, bool useObjectPool = false /* Metadata: 0x00AEFAA5 */) => default; // 0x00000001847E8740-0x00000001847E8930
	[BlackList] // 0x0000000189A4A2A0-0x0000000189A4A2E0
	// [XID] // 0x0000000189A4A2A0-0x0000000189A4A2E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001847E71F0-0x00000001847E74C0
	// [XID] // 0x0000000189A54BF0-0x0000000189A54C10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001847E9740-0x00000001847E9B30
	[BlackList] // 0x0000000189A5C680-0x0000000189A5C6C0
	// [XID] // 0x0000000189A5C680-0x0000000189A5C6C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001847E8C60-0x00000001847E8D50
	[BlackList] // 0x0000000189A66F20-0x0000000189A66F60
	// [XID] // 0x0000000189A66F20-0x0000000189A66F60
	public override void AutoAllocTypeFields() {} // 0x00000001847E74C0-0x00000001847E7560
	[BlackList] // 0x0000000189A71420-0x0000000189A71460
	// [XID] // 0x0000000189A71420-0x0000000189A71460
	public override void AutoRecycleTypeFields() {} // 0x00000001847E7560-0x00000001847E7670
	[BlackList] // 0x0000000189A7BF80-0x0000000189A7BFC0
	// [XID] // 0x0000000189A7BF80-0x0000000189A7BFC0
	public override void ReturnToObjectPool() {} // 0x00000001847E9D50-0x00000001847E9DF0
}

