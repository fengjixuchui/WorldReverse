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
public class ConfigPointArray : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18513
{
	// Fields
	private SimpleSafeUInt32 pointArrayIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigPoint[] _platformPointList; // 0x18

	// Properties
	public uint pointArrayId { /* [XID] */ /* 0x00000001898B6B30-0x00000001898B6B50 */ get => default; /* [XID] */ /* 0x00000001898BE2E0-0x00000001898BE300 */ private set {} } // 0x00000001835F8C10-0x00000001835F8CE0 0x00000001835F7F90-0x00000001835F8070
	public ConfigPoint[] platformPointList { /* [XID] */ /* 0x00000001898C5B90-0x00000001898C5BB0 */ get => default; /* [XID] */ /* 0x00000001898CD2A0-0x00000001898CD2C0 */ private set {} } // 0x00000001835F8770-0x00000001835F8810 0x00000001835F86C0-0x00000001835F8770

	// Constructors
	public ConfigPointArray() {} // 0x00000001835F9270-0x00000001835F92D0

	// Methods
	// [XID] // 0x00000001898D4B50-0x00000001898D4B70
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835F8F80-0x00000001835F9090
	// [XID] // 0x00000001898DC590-0x00000001898DC5B0
	public void InitEmpty() {} // 0x00000001835F8810-0x00000001835F8910
	[BlackList] // 0x00000001898E4020-0x00000001898E4060
	// [XID] // 0x00000001898E4020-0x00000001898E4060
	public bool FromJson(JSONNode node) => default; // 0x00000001835F8340-0x00000001835F86C0
	// [XID] // 0x00000001898EEC00-0x00000001898EEC20
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001835F7840-0x00000001835F7B40
	// [XID] // 0x00000001898F6440-0x00000001898F6460
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9FF7 */, bool useObjectPool = false /* Metadata: 0x00AF9FFB */) => default; // 0x00000001835F8910-0x00000001835F8C10
	// [XID] // 0x00000001898FDC20-0x00000001898FDC40
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9FFC */, bool useObjectPool = false /* Metadata: 0x00AFA000 */) => default; // 0x00000001835F8070-0x00000001835F8340
	[BlackList] // 0x00000001899053A0-0x00000001899053E0
	// [XID] // 0x00000001899053A0-0x00000001899053E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001835F7B40-0x00000001835F7E10
	// [XID] // 0x000000018990FC30-0x000000018990FC50
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835F8CE0-0x00000001835F8F80
	[BlackList] // 0x0000000189917720-0x0000000189917760
	// [XID] // 0x0000000189917720-0x0000000189917760
	public virtual void AutoAllocTypeFields() {} // 0x00000001835F7E10-0x00000001835F7EB0
	[BlackList] // 0x0000000189921FA0-0x0000000189921FE0
	// [XID] // 0x0000000189921FA0-0x0000000189921FE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835F7EB0-0x00000001835F7F90
	[BlackList] // 0x000000018992C4A0-0x000000018992C4E0
	// [XID] // 0x000000018992C4A0-0x000000018992C4E0
	public virtual void ReturnToObjectPool() {} // 0x00000001835F91D0-0x00000001835F9270
	[BlackList] // 0x0000000189936870-0x00000001899368B0
	// [XID] // 0x0000000189936870-0x00000001899368B0
	public virtual void OnPoolAllocated() {} // 0x00000001835F9130-0x00000001835F91D0
	[BlackList] // 0x0000000189940F80-0x0000000189940FC0
	// [XID] // 0x0000000189940F80-0x0000000189940FC0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835F9090-0x00000001835F9130
}

