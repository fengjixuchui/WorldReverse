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
public class ConfigEffectAttachMesh : ConfigEffectAttachShape, IAutoAllocRecycle // TypeDefIndex: 17706
{
	// Fields
	private string _mesh; // 0x10

	// Properties
	public string mesh { /* [XID] */ /* 0x0000000189AD14F0-0x0000000189AD1510 */ get => default; /* [XID] */ /* 0x0000000189AD9230-0x0000000189AD9250 */ private set {} } // 0x0000000181C2DC10-0x0000000181C2DCB0 0x0000000181C2EDB0-0x0000000181C2EE60

	// Constructors
	public ConfigEffectAttachMesh() {} // 0x0000000181C2F1F0-0x0000000181C2F250

	// Methods
	// [XID] // 0x0000000189AE0D20-0x0000000189AE0D40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C2F060-0x0000000181C2F150
	// [XID] // 0x0000000189AE81D0-0x0000000189AE81F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181C2ECD0-0x0000000181C2EDB0
	// [XID] // 0x0000000189AF0050-0x0000000189AF0070
	public override ConfigEffectAttachShape Clone(bool useObjectPool = false /* Metadata: 0x00AF786B */) => default; // 0x0000000181C2E8E0-0x0000000181C2E9C0
	// [XID] // 0x0000000189AF7520-0x0000000189AF7540
	public override int GetHashNum() => default; // 0x0000000181C2D770-0x0000000181C2D840
	// [XID] // 0x0000000189AFEC10-0x0000000189AFEC30
	public override void InitEmpty() {} // 0x0000000181C2E340-0x0000000181C2E410
	[BlackList] // 0x0000000189B06380-0x0000000189B063C0
	// [XID] // 0x0000000189B06380-0x0000000189B063C0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181C2DD30-0x0000000181C2E0B0
	// [XID] // 0x0000000189B10BB0-0x0000000189B10BD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181C2D000-0x0000000181C2D230
	[BlackList] // 0x0000000189B17D80-0x0000000189B17DC0
	// [XID] // 0x0000000189B17D80-0x0000000189B17DC0
	public static new ConfigEffectAttachMesh ParseFromJson(JSONNode node) => default; // 0x0000000181C2EA20-0x0000000181C2EC70
	// [XID] // 0x0000000189B224D0-0x0000000189B224F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF786C */, bool useObjectPool = false /* Metadata: 0x00AF7870 */) => default; // 0x0000000181C2E5E0-0x0000000181C2E8E0
	// [XID] // 0x0000000189B29A00-0x0000000189B29A20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7871 */, bool useObjectPool = false /* Metadata: 0x00AF7875 */) => default; // 0x0000000181C2D920-0x0000000181C2DB90
	// [XID] // 0x0000000189B31050-0x0000000189B31070
	public static new ConfigEffectAttachMesh ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7876 */, bool useObjectPool = false /* Metadata: 0x00AF787A */) => default; // 0x0000000181C2E0B0-0x0000000181C2E2D0
	[BlackList] // 0x0000000189B38670-0x0000000189B386B0
	// [XID] // 0x0000000189B38670-0x0000000189B386B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C2D230-0x0000000181C2D500
	// [XID] // 0x0000000189B430F0-0x0000000189B43110
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C2EE60-0x0000000181C2F060
	[BlackList] // 0x0000000189B4A910-0x0000000189B4A950
	// [XID] // 0x0000000189B4A910-0x0000000189B4A950
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181C2E4F0-0x0000000181C2E5E0
	[BlackList] // 0x0000000189B55030-0x0000000189B55070
	// [XID] // 0x0000000189B55030-0x0000000189B55070
	public override void AutoAllocTypeFields() {} // 0x0000000181C2D500-0x0000000181C2D5A0
	[BlackList] // 0x0000000189B5FC20-0x0000000189B5FC60
	// [XID] // 0x0000000189B5FC20-0x0000000189B5FC60
	public override void AutoRecycleTypeFields() {} // 0x0000000181C2D5A0-0x0000000181C2D650
	[BlackList] // 0x0000000189B6A1D0-0x0000000189B6A210
	// [XID] // 0x0000000189B6A1D0-0x0000000189B6A210
	public override void ReturnToObjectPool() {} // 0x0000000181C2F150-0x0000000181C2F1F0
}

