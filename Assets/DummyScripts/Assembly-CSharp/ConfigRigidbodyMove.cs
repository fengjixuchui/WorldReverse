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
public class ConfigRigidbodyMove : ConfigMove, IAutoAllocRecycle // TypeDefIndex: 18578
{
	// Fields
	private SimpleSafeFloat constSpeedRatioRawNum; // 0x18
	private bool _startCloseToGround; // 0x1C
	private bool _enableCloseToGroundWhenTick; // 0x1D
	private bool _followReferenceSystem; // 0x1E

	// Properties
	public float constSpeedRatio { /* [XID] */ /* 0x0000000189856A00-0x0000000189856A20 */ get => default; /* [XID] */ /* 0x000000018985DC30-0x000000018985DC50 */ private set {} } // 0x000000018560BB90-0x000000018560BC70 0x000000018560DA40-0x000000018560DB20
	public bool startCloseToGround { /* [XID] */ /* 0x00000001898656B0-0x00000001898656D0 */ get => default; /* [XID] */ /* 0x000000018986CB10-0x000000018986CB30 */ private set {} } // 0x000000018560C540-0x000000018560C5E0 0x000000018560CFF0-0x000000018560D0A0
	public bool enableCloseToGroundWhenTick { /* [XID] */ /* 0x0000000189873FC0-0x0000000189873FE0 */ get => default; /* [XID] */ /* 0x000000018987BAE0-0x000000018987BB00 */ private set {} } // 0x000000018560C800-0x000000018560C8A0 0x000000018560D400-0x000000018560D4B0
	public bool followReferenceSystem { /* [XID] */ /* 0x0000000189882C90-0x0000000189882CB0 */ get => default; /* [XID] */ /* 0x000000018988A470-0x000000018988A490 */ private set {} } // 0x000000018560D4B0-0x000000018560D550 0x000000018560B930-0x000000018560B9E0

	// Constructors
	public ConfigRigidbodyMove() {} // 0x000000018560DBC0-0x000000018560DC30

	// Methods
	// [XID] // 0x00000001898918C0-0x00000001898918E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018560D8F0-0x000000018560DA40
	// [XID] // 0x0000000189899250-0x0000000189899270
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018560D350-0x000000018560D400
	// [XID] // 0x00000001898A03F0-0x00000001898A0410
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA4AB */) => default; // 0x000000018560CEB0-0x000000018560CF90
	// [XID] // 0x00000001898A7B30-0x00000001898A7B50
	public override int GetHashNum() => default; // 0x000000018560BA60-0x000000018560BB30
	// [XID] // 0x00000001898AF6D0-0x00000001898AF6F0
	public override void InitEmpty() {} // 0x000000018560C910-0x000000018560C9E0
	[BlackList] // 0x00000001898B6AF0-0x00000001898B6B30
	// [XID] // 0x00000001898B6AF0-0x00000001898B6B30
	public override bool FromJson(JSONNode node) => default; // 0x000000018560C1C0-0x000000018560C540
	// [XID] // 0x00000001898C1380-0x00000001898C13A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018560AF90-0x000000018560B440
	[BlackList] // 0x00000001898C8CE0-0x00000001898C8D20
	// [XID] // 0x00000001898C8CE0-0x00000001898C8D20
	public static new ConfigRigidbodyMove ParseFromJson(JSONNode node) => default; // 0x000000018560D0A0-0x000000018560D2F0
	// [XID] // 0x00000001898D3250-0x00000001898D3270
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA4AC */, bool useObjectPool = false /* Metadata: 0x00AFA4B0 */) => default; // 0x000000018560CBB0-0x000000018560CEB0
	// [XID] // 0x00000001898DAB80-0x00000001898DABA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA4B1 */, bool useObjectPool = false /* Metadata: 0x00AFA4B5 */) => default; // 0x000000018560BCF0-0x000000018560C0C0
	// [XID] // 0x00000001898E2A00-0x00000001898E2A20
	public static new ConfigRigidbodyMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA4B6 */, bool useObjectPool = false /* Metadata: 0x00AFA4BA */) => default; // 0x000000018560C5E0-0x000000018560C800
	[BlackList] // 0x00000001898EA4B0-0x00000001898EA4F0
	// [XID] // 0x00000001898EA4B0-0x00000001898EA4F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018560B440-0x000000018560B710
	// [XID] // 0x00000001898F4A80-0x00000001898F4AA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018560D550-0x000000018560D8F0
	[BlackList] // 0x00000001898FC310-0x00000001898FC350
	// [XID] // 0x00000001898FC310-0x00000001898FC350
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018560CAC0-0x000000018560CBB0
	[BlackList] // 0x0000000189906A70-0x0000000189906AB0
	// [XID] // 0x0000000189906A70-0x0000000189906AB0
	public override void AutoAllocTypeFields() {} // 0x000000018560B710-0x000000018560B7B0
	[BlackList] // 0x0000000189911200-0x0000000189911240
	// [XID] // 0x0000000189911200-0x0000000189911240
	public override void AutoRecycleTypeFields() {} // 0x000000018560B7B0-0x000000018560B890
	[BlackList] // 0x000000018991BFA0-0x000000018991BFE0
	// [XID] // 0x000000018991BFA0-0x000000018991BFE0
	public override void ReturnToObjectPool() {} // 0x000000018560DB20-0x000000018560DBC0
}

