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
public class ConfigLuaSafetyCheckSwitch : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18115
{
	// Fields
	private bool _tickWorld; // 0x10
	private SimpleSafeUInt32 tickWorldCDRawNum; // 0x14
	private bool _tickChest; // 0x18
	private bool _tickMonster; // 0x19

	// Properties
	public bool tickWorld { /* [XID] */ /* 0x00000001899054A0-0x00000001899054C0 */ get => default; /* [XID] */ /* 0x000000018990CD50-0x000000018990CD70 */ private set {} } // 0x00000001828FD120-0x00000001828FD1C0 0x00000001828FDE80-0x00000001828FDF30
	public uint tickWorldCD { /* [XID] */ /* 0x0000000189914520-0x0000000189914540 */ get => default; /* [XID] */ /* 0x000000018991C0A0-0x000000018991C0C0 */ private set {} } // 0x00000001828FD5C0-0x00000001828FD690 0x00000001828FD040-0x00000001828FD120
	public bool tickChest { /* [XID] */ /* 0x0000000189923760-0x0000000189923780 */ get => default; /* [XID] */ /* 0x000000018992AE20-0x000000018992AE40 */ private set {} } // 0x00000001828FCEF0-0x00000001828FCF90 0x00000001828FD510-0x00000001828FD5C0
	public bool tickMonster { /* [XID] */ /* 0x0000000189932440-0x0000000189932460 */ get => default; /* [XID] */ /* 0x0000000189939E50-0x0000000189939E70 */ private set {} } // 0x00000001828FDA10-0x00000001828FDAB0 0x00000001828FCF90-0x00000001828FD040

	// Constructors
	public ConfigLuaSafetyCheckSwitch() {} // 0x00000001828FE5D0-0x00000001828FE670

	// Methods
	// [XID] // 0x0000000189941040-0x0000000189941060
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828FE2B0-0x00000001828FE3F0
	// [XID] // 0x0000000189948B00-0x0000000189948B20
	public void InitEmpty() {} // 0x00000001828FDAB0-0x00000001828FDB80
	[BlackList] // 0x0000000189950270-0x00000001899502B0
	// [XID] // 0x0000000189950270-0x00000001899502B0
	public bool FromJson(JSONNode node) => default; // 0x00000001828FD690-0x00000001828FDA10
	// [XID] // 0x000000018995A8D0-0x000000018995A8F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001828FC680-0x00000001828FCAB0
	// [XID] // 0x00000001899623F0-0x0000000189962410
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B95 */, bool useObjectPool = false /* Metadata: 0x00AF8B99 */) => default; // 0x00000001828FDB80-0x00000001828FDE80
	// [XID] // 0x0000000189969880-0x00000001899698A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B9A */, bool useObjectPool = false /* Metadata: 0x00AF8B9E */) => default; // 0x00000001828FD1C0-0x00000001828FD510
	[BlackList] // 0x00000001899715C0-0x0000000189971600
	// [XID] // 0x00000001899715C0-0x0000000189971600
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001828FCAB0-0x00000001828FCD80
	// [XID] // 0x000000018997B900-0x000000018997B920
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828FDF30-0x00000001828FE2B0
	[BlackList] // 0x0000000189983450-0x0000000189983490
	// [XID] // 0x0000000189983450-0x0000000189983490
	public virtual void AutoAllocTypeFields() {} // 0x00000001828FCD80-0x00000001828FCE20
	[BlackList] // 0x000000018998DB60-0x000000018998DBA0
	// [XID] // 0x000000018998DB60-0x000000018998DBA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001828FCE20-0x00000001828FCEF0
	[BlackList] // 0x0000000189998750-0x0000000189998790
	// [XID] // 0x0000000189998750-0x0000000189998790
	public virtual void ReturnToObjectPool() {} // 0x00000001828FE530-0x00000001828FE5D0
	[BlackList] // 0x00000001899A2F90-0x00000001899A2FD0
	// [XID] // 0x00000001899A2F90-0x00000001899A2FD0
	public virtual void OnPoolAllocated() {} // 0x00000001828FE490-0x00000001828FE530
	[BlackList] // 0x00000001899AD9A0-0x00000001899AD9E0
	// [XID] // 0x00000001899AD9A0-0x00000001899AD9E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001828FE3F0-0x00000001828FE490
}

