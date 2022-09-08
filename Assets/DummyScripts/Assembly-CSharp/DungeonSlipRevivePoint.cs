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
public class DungeonSlipRevivePoint : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 14983
{
	// Fields
	private MoleMole.Config.Vector _size; // 0x60
	private bool _isActive; // 0x6C
	private SimpleSafeUInt32[] _groupIds; // 0x70

	// Properties
	public override RealScenePointType pointType { /* [XID] */ /* 0x0000000189647C10-0x0000000189647C30 */ get => default; } // 0x000000018382DD30-0x000000018382DDD0 
	public MoleMole.Config.Vector size { /* [XID] */ /* 0x000000018964F320-0x000000018964F340 */ get => default; /* [XID] */ /* 0x0000000189656CD0-0x0000000189656CF0 */ private set {} } // 0x000000018382E7C0-0x000000018382E8A0 0x000000018382D880-0x000000018382D950
	public bool isActive { /* [XID] */ /* 0x000000018965E3D0-0x000000018965E3F0 */ get => default; /* [XID] */ /* 0x0000000189665B10-0x0000000189665B30 */ private set {} } // 0x000000018382E720-0x000000018382E7C0 0x000000018382CE80-0x000000018382CF30
	public SimpleSafeUInt32[] groupIds { /* [XID] */ /* 0x000000018966D1E0-0x000000018966D200 */ get => default; /* [XID] */ /* 0x0000000189675190-0x00000001896751B0 */ private set {} } // 0x000000018382E230-0x000000018382E2D0 0x000000018382E670-0x000000018382E720

	// Constructors
	public DungeonSlipRevivePoint() {} // 0x000000018382EA90-0x000000018382EB80

	// Methods
	// [XID] // 0x000000018967C8A0-0x000000018967C8C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018382E8A0-0x000000018382E9F0
	// [XID] // 0x0000000189683F30-0x0000000189683F50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018382E0E0-0x000000018382E1C0
	// [XID] // 0x000000018968BAF0-0x000000018968BB10
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD98 */) => default; // 0x000000018382DC50-0x000000018382DD30
	// [XID] // 0x0000000189693700-0x0000000189693720
	public override int GetHashNum() => default; // 0x000000018382C8D0-0x000000018382C9A0
	// [XID] // 0x000000018969AA50-0x000000018969AA70
	public override void InitEmpty() {} // 0x000000018382D5C0-0x000000018382D6B0
	[BlackList] // 0x00000001896A24A0-0x00000001896A24E0
	// [XID] // 0x00000001896A24A0-0x00000001896A24E0
	public override bool FromJson(JSONNode node) => default; // 0x000000018382CFB0-0x000000018382D330
	// [XID] // 0x00000001896AC6D0-0x00000001896AC6F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018382BFB0-0x000000018382C380
	[BlackList] // 0x00000001896B3990-0x00000001896B39D0
	// [XID] // 0x00000001896B3990-0x00000001896B39D0
	public static new DungeonSlipRevivePoint ParseFromJson(JSONNode node) => default; // 0x000000018382DE30-0x000000018382E080
	// [XID] // 0x00000001896BDB40-0x00000001896BDB60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD99 */, bool useObjectPool = false /* Metadata: 0x00AEFD9D */) => default; // 0x000000018382D950-0x000000018382DC50
	// [XID] // 0x00000001896C5370-0x00000001896C5390
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD9E */, bool useObjectPool = false /* Metadata: 0x00AEFDA2 */) => default; // 0x000000018382CA80-0x000000018382CE00
	// [XID] // 0x00000001896CC910-0x00000001896CC930
	public static new DungeonSlipRevivePoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDA3 */, bool useObjectPool = false /* Metadata: 0x00AEFDA7 */) => default; // 0x000000018382D330-0x000000018382D550
	[BlackList] // 0x00000001896D3BC0-0x00000001896D3C00
	// [XID] // 0x00000001896D3BC0-0x00000001896D3C00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018382C380-0x000000018382C650
	// [XID] // 0x00000001896DE5E0-0x00000001896DE600
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018382E2D0-0x000000018382E670
	[BlackList] // 0x00000001896E5990-0x00000001896E59D0
	// [XID] // 0x00000001896E5990-0x00000001896E59D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018382D790-0x000000018382D880
	[BlackList] // 0x00000001896EFDC0-0x00000001896EFE00
	// [XID] // 0x00000001896EFDC0-0x00000001896EFE00
	public override void AutoAllocTypeFields() {} // 0x000000018382C650-0x000000018382C6F0
	[BlackList] // 0x00000001896FA7D0-0x00000001896FA810
	// [XID] // 0x00000001896FA7D0-0x00000001896FA810
	public override void AutoRecycleTypeFields() {} // 0x000000018382C6F0-0x000000018382C7B0
	[BlackList] // 0x0000000189704E30-0x0000000189704E70
	// [XID] // 0x0000000189704E30-0x0000000189704E70
	public override void ReturnToObjectPool() {} // 0x000000018382E9F0-0x000000018382EA90
}

