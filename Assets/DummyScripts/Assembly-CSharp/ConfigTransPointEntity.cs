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
public class ConfigTransPointEntity : ConfigGadget, IAutoAllocRecycle // TypeDefIndex: 18037
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private TransPointUpdateMaterial[] _updateMaterialList; // 0x138

	// Properties
	public TransPointUpdateMaterial[] updateMaterialList { /* [XID] */ /* 0x00000001898797A0-0x00000001898797C0 */ get => default; /* [XID] */ /* 0x00000001898C5C30-0x00000001898C5C50 */ private set {} } // 0x00000001845274B0-0x0000000184527560 0x0000000184526AE0-0x0000000184526B90

	// Constructors
	public ConfigTransPointEntity() {} // 0x0000000184528D30-0x0000000184528D90

	// Methods
	// [XID] // 0x00000001898CD3C0-0x00000001898CD3E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184528BA0-0x0000000184528C90
	// [XID] // 0x00000001898D4C50-0x00000001898D4C70
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184528880-0x0000000184528960
	// [XID] // 0x00000001898DC690-0x00000001898DC6B0
	public override ConfigEntity Clone(bool useObjectPool = false /* Metadata: 0x00AF8769 */) => default; // 0x0000000184528490-0x0000000184528570
	// [XID] // 0x00000001898E4140-0x00000001898E4160
	public override int GetHashNum() => default; // 0x0000000184527300-0x00000001845273D0
	// [XID] // 0x00000001898EBC30-0x00000001898EBC50
	public override void InitEmpty() {} // 0x0000000184527EE0-0x0000000184527FC0
	[BlackList] // 0x00000001898F3440-0x00000001898F3480
	// [XID] // 0x00000001898F3440-0x00000001898F3480
	public override bool FromJson(JSONNode node) => default; // 0x00000001845278D0-0x0000000184527C50
	// [XID] // 0x00000001898FDCC0-0x00000001898FDCE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184526B90-0x0000000184526DC0
	[BlackList] // 0x00000001899054E0-0x0000000189905520
	// [XID] // 0x00000001899054E0-0x0000000189905520
	public static new ConfigTransPointEntity ParseFromJson(JSONNode node) => default; // 0x00000001845285D0-0x0000000184528820
	// [XID] // 0x000000018990FD10-0x000000018990FD30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF876A */, bool useObjectPool = false /* Metadata: 0x00AF876E */) => default; // 0x0000000184528190-0x0000000184528490
	// [XID] // 0x0000000189917820-0x0000000189917840
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF876F */, bool useObjectPool = false /* Metadata: 0x00AF8773 */) => default; // 0x0000000184527560-0x00000001845277D0
	// [XID] // 0x000000018991EE00-0x000000018991EE20
	public static new ConfigTransPointEntity ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8774 */, bool useObjectPool = false /* Metadata: 0x00AF8778 */) => default; // 0x0000000184527C50-0x0000000184527E70
	[BlackList] // 0x0000000189926800-0x0000000189926840
	// [XID] // 0x0000000189926800-0x0000000189926840
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184526DC0-0x0000000184527090
	// [XID] // 0x0000000189930EC0-0x0000000189930EE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184528960-0x0000000184528BA0
	[BlackList] // 0x00000001899381B0-0x00000001899381F0
	// [XID] // 0x00000001899381B0-0x00000001899381F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001845280A0-0x0000000184528190
	[BlackList] // 0x0000000189942850-0x0000000189942890
	// [XID] // 0x0000000189942850-0x0000000189942890
	public override void AutoAllocTypeFields() {} // 0x0000000184527090-0x0000000184527130
	[BlackList] // 0x000000018994D030-0x000000018994D070
	// [XID] // 0x000000018994D030-0x000000018994D070
	public override void AutoRecycleTypeFields() {} // 0x0000000184527130-0x00000001845271E0
	[BlackList] // 0x00000001899578E0-0x0000000189957920
	// [XID] // 0x00000001899578E0-0x0000000189957920
	public override void ReturnToObjectPool() {} // 0x0000000184528C90-0x0000000184528D30
}

