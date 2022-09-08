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
public class SelectActionPointByID : ConfigActionPointSelectType, IAutoAllocRecycle // TypeDefIndex: 17883
{
	// Fields
	private SimpleSafeUInt32 actionPointIDRawNum; // 0x10

	// Properties
	public uint actionPointID { /* [XID] */ /* 0x0000000189A8C370-0x0000000189A8C390 */ get => default; /* [XID] */ /* 0x0000000189A93850-0x0000000189A93870 */ private set {} } // 0x0000000183AC3380-0x0000000183AC3450 0x0000000183AC1A40-0x0000000183AC1B20

	// Constructors
	public SelectActionPointByID() {} // 0x0000000183AC35E0-0x0000000183AC3690

	// Methods
	// [XID] // 0x0000000189A9B460-0x0000000189A9B480
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AC3450-0x0000000183AC3540
	// [XID] // 0x0000000189AA2780-0x0000000189AA27A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183AC30A0-0x0000000183AC3150
	// [XID] // 0x0000000189AA9CE0-0x0000000189AA9D00
	public override ConfigActionPointSelectType Clone(bool useObjectPool = false /* Metadata: 0x00AF8019 */) => default; // 0x0000000183AC2CB0-0x0000000183AC2D90
	// [XID] // 0x0000000189AB1C40-0x0000000189AB1C60
	public override int GetHashNum() => default; // 0x0000000183AC1890-0x0000000183AC1960
	// [XID] // 0x0000000189AB8F30-0x0000000189AB8F50
	public override void InitEmpty() {} // 0x0000000183AC2710-0x0000000183AC27E0
	[BlackList] // 0x0000000189AC0A30-0x0000000189AC0A70
	// [XID] // 0x0000000189AC0A30-0x0000000189AC0A70
	public override bool FromJson(JSONNode node) => default; // 0x0000000183AC1E50-0x0000000183AC21D0
	// [XID] // 0x0000000189ACB3D0-0x0000000189ACB3F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183AC10F0-0x0000000183AC1330
	[BlackList] // 0x0000000189AD2E60-0x0000000189AD2EA0
	// [XID] // 0x0000000189AD2E60-0x0000000189AD2EA0
	public static new SelectActionPointByID ParseFromJson(JSONNode node) => default; // 0x0000000183AC2DF0-0x0000000183AC3040
	// [XID] // 0x0000000189ADDC20-0x0000000189ADDC40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF801A */, bool useObjectPool = false /* Metadata: 0x00AF801E */) => default; // 0x0000000183AC29B0-0x0000000183AC2CB0
	// [XID] // 0x0000000189AE55A0-0x0000000189AE55C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF801F */, bool useObjectPool = false /* Metadata: 0x00AF8023 */) => default; // 0x0000000183AC1B20-0x0000000183AC1D50
	// [XID] // 0x0000000189AECA60-0x0000000189AECA80
	public static new SelectActionPointByID ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8024 */, bool useObjectPool = false /* Metadata: 0x00AF8028 */) => default; // 0x0000000183AC23F0-0x0000000183AC2610
	[BlackList] // 0x0000000189AF4450-0x0000000189AF4490
	// [XID] // 0x0000000189AF4450-0x0000000189AF4490
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AC1330-0x0000000183AC1600
	// [XID] // 0x0000000189AFEB90-0x0000000189AFEBB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AC3150-0x0000000183AC3380
	[BlackList] // 0x0000000189B06320-0x0000000189B06360
	// [XID] // 0x0000000189B06320-0x0000000189B06360
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183AC28C0-0x0000000183AC29B0
	// [XID] // 0x0000000189B10B50-0x0000000189B10B70
	public override LevelActionPoint GetActionPoint(ActionPointType actionPointType, BaseEntity targetEntity, BaseEntity selfEntity) => default; // 0x0000000183AC21D0-0x0000000183AC23F0
	[BlackList] // 0x0000000189B17CE0-0x0000000189B17D20
	// [XID] // 0x0000000189B17CE0-0x0000000189B17D20
	public override void AutoAllocTypeFields() {} // 0x0000000183AC1600-0x0000000183AC16A0
	[BlackList] // 0x0000000189B22450-0x0000000189B22490
	// [XID] // 0x0000000189B22450-0x0000000189B22490
	public override void AutoRecycleTypeFields() {} // 0x0000000183AC16A0-0x0000000183AC1770
	[BlackList] // 0x0000000189B2C9B0-0x0000000189B2C9F0
	// [XID] // 0x0000000189B2C9B0-0x0000000189B2C9F0
	public override void ReturnToObjectPool() {} // 0x0000000183AC3540-0x0000000183AC35E0
}

