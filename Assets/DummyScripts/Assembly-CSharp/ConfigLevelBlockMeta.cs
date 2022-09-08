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
public class ConfigLevelBlockMeta : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18492
{
	// Fields
	private SimpleSafeUInt32 blockIDRawNum; // 0x10
	private bool _isIgnoreBlockPosition; // 0x14
	private SimpleSafeInt16 blockCenterXRawNum; // 0x16
	private SimpleSafeInt16 blockCenterZRawNum; // 0x18
	private string _blockLevelMonsterDataPath; // 0x20
	private string _blockLevelRouteDataPath; // 0x28
	public ulong blockLevelMonsterDataPathHash; // 0x30
	public ulong blockLevelRouteDataPathHash; // 0x38

	// Properties
	public uint blockID { /* [XID] */ /* 0x000000018977DFE0-0x000000018977E000 */ get => default; /* [XID] */ /* 0x00000001899E36F0-0x00000001899E3710 */ private set {} } // 0x00000001833A6EB0-0x00000001833A6F80 0x00000001833A8660-0x00000001833A8740
	public bool isIgnoreBlockPosition { /* [XID] */ /* 0x00000001899EAAA0-0x00000001899EAAC0 */ get => default; /* [XID] */ /* 0x00000001899F2680-0x00000001899F26A0 */ private set {} } // 0x00000001833A6F80-0x00000001833A7020 0x00000001833A8020-0x00000001833A80D0
	public short blockCenterX { /* [XID] */ /* 0x00000001899F9BB0-0x00000001899F9BD0 */ get => default; /* [XID] */ /* 0x0000000189A00FD0-0x0000000189A00FF0 */ private set {} } // 0x00000001833A89F0-0x00000001833A8AC0 0x00000001833A7A40-0x00000001833A7B20
	public short blockCenterZ { /* [XID] */ /* 0x0000000189A08950-0x0000000189A08970 */ get => default; /* [XID] */ /* 0x0000000189A0FED0-0x0000000189A0FEF0 */ private set {} } // 0x00000001833A61C0-0x00000001833A6290 0x00000001833A7020-0x00000001833A7100
	public string blockLevelMonsterDataPath { /* [XID] */ /* 0x0000000189A17390-0x0000000189A173B0 */ get => default; /* [XID] */ /* 0x0000000189A1EAF0-0x0000000189A1EB10 */ private set {} } // 0x00000001833A79A0-0x00000001833A7A40 0x00000001833A7F70-0x00000001833A8020
	public string blockLevelRouteDataPath { /* [XID] */ /* 0x0000000189A26180-0x0000000189A261A0 */ get => default; /* [XID] */ /* 0x0000000189A2D4D0-0x0000000189A2D4F0 */ private set {} } // 0x00000001833A80D0-0x00000001833A8170 0x00000001833A6E00-0x00000001833A6EB0

	// Constructors
	public ConfigLevelBlockMeta() {} // 0x00000001833A8B60-0x00000001833A8BD0

	// Methods
	// [XID] // 0x0000000189A34FD0-0x0000000189A34FF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833A8740-0x00000001833A88B0
	// [XID] // 0x0000000189A3C430-0x0000000189A3C450
	public void InitEmpty() {} // 0x00000001833A7B20-0x00000001833A7C70
	[BlackList] // 0x0000000189A43F90-0x0000000189A43FD0
	// [XID] // 0x0000000189A43F90-0x0000000189A43FD0
	public bool FromJson(JSONNode node) => default; // 0x00000001833A7620-0x00000001833A79A0
	// [XID] // 0x0000000189A4E6A0-0x0000000189A4E6C0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001833A6290-0x00000001833A6950
	// [XID] // 0x0000000189A55D60-0x0000000189A55D80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F45 */, bool useObjectPool = false /* Metadata: 0x00AF9F49 */) => default; // 0x00000001833A7C70-0x00000001833A7F70
	// [XID] // 0x0000000189A5D6E0-0x0000000189A5D700
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F4A */, bool useObjectPool = false /* Metadata: 0x00AF9F4E */) => default; // 0x00000001833A7100-0x00000001833A7620
	[BlackList] // 0x0000000189A64F20-0x0000000189A64F60
	// [XID] // 0x0000000189A64F20-0x0000000189A64F60
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001833A6950-0x00000001833A6C20
	// [XID] // 0x0000000189A6F660-0x0000000189A6F680
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833A8170-0x00000001833A8660
	[BlackList] // 0x0000000189A76DF0-0x0000000189A76E30
	// [XID] // 0x0000000189A76DF0-0x0000000189A76E30
	public virtual void AutoAllocTypeFields() {} // 0x00000001833A6C20-0x00000001833A6CC0
	[BlackList] // 0x0000000189A81870-0x0000000189A818B0
	// [XID] // 0x0000000189A81870-0x0000000189A818B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833A6CC0-0x00000001833A6E00
	[BlackList] // 0x0000000189A8C2B0-0x0000000189A8C2F0
	// [XID] // 0x0000000189A8C2B0-0x0000000189A8C2F0
	public virtual void ReturnToObjectPool() {} // 0x00000001833A8AC0-0x00000001833A8B60
	[BlackList] // 0x0000000189A96880-0x0000000189A968C0
	// [XID] // 0x0000000189A96880-0x0000000189A968C0
	public virtual void OnPoolAllocated() {} // 0x00000001833A8950-0x00000001833A89F0
	[BlackList] // 0x0000000189AA0C20-0x0000000189AA0C60
	// [XID] // 0x0000000189AA0C20-0x0000000189AA0C60
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833A88B0-0x00000001833A8950
}

