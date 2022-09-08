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
public class RecordRendererGlobalParameters : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18872
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private RendererFloat[] _floats; // 0x10

	// Properties
	public RendererFloat[] floats { /* [XID] */ /* 0x00000001898D4B30-0x00000001898D4B50 */ get => default; /* [XID] */ /* 0x00000001898DC570-0x00000001898DC590 */ private set {} } // 0x0000000183DA8510-0x0000000183DA85B0 0x0000000183DA76F0-0x0000000183DA77A0

	// Constructors
	public RecordRendererGlobalParameters() {} // 0x0000000183DA8650-0x0000000183DA86B0

	// Methods
	// [XID] // 0x00000001898E3FE0-0x00000001898E4000
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183DA82F0-0x0000000183DA83D0
	// [XID] // 0x00000001898EBA50-0x00000001898EBA70
	public void InitEmpty() {} // 0x0000000183DA7D30-0x0000000183DA7E00
	[BlackList] // 0x00000001898F3260-0x00000001898F32A0
	// [XID] // 0x00000001898F3260-0x00000001898F32A0
	public bool FromJson(JSONNode node) => default; // 0x0000000183DA79B0-0x0000000183DA7D30
	// [XID] // 0x00000001898FDB60-0x00000001898FDB80
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183DA7100-0x0000000183DA72E0
	// [XID] // 0x0000000189905380-0x00000001899053A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1D5 */, bool useObjectPool = false /* Metadata: 0x00AFB1D9 */) => default; // 0x0000000183DA7E00-0x0000000183DA8100
	// [XID] // 0x000000018990CCF0-0x000000018990CD10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1DA */, bool useObjectPool = false /* Metadata: 0x00AFB1DE */) => default; // 0x0000000183DA77A0-0x0000000183DA79B0
	[BlackList] // 0x0000000189914440-0x0000000189914480
	// [XID] // 0x0000000189914440-0x0000000189914480
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183DA72E0-0x0000000183DA75B0
	// [XID] // 0x000000018991ECE0-0x000000018991ED00
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183DA8100-0x0000000183DA82F0
	[BlackList] // 0x00000001899265C0-0x0000000189926600
	// [XID] // 0x00000001899265C0-0x0000000189926600
	public virtual void AutoAllocTypeFields() {} // 0x0000000183DA75B0-0x0000000183DA7650
	[BlackList] // 0x0000000189930CC0-0x0000000189930D00
	// [XID] // 0x0000000189930CC0-0x0000000189930D00
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183DA7650-0x0000000183DA76F0
	[BlackList] // 0x000000018993B570-0x000000018993B5B0
	// [XID] // 0x000000018993B570-0x000000018993B5B0
	public virtual void ReturnToObjectPool() {} // 0x0000000183DA85B0-0x0000000183DA8650
	[BlackList] // 0x0000000189945A00-0x0000000189945A40
	// [XID] // 0x0000000189945A00-0x0000000189945A40
	public virtual void OnPoolAllocated() {} // 0x0000000183DA8470-0x0000000183DA8510
	[BlackList] // 0x00000001899500B0-0x00000001899500F0
	// [XID] // 0x00000001899500B0-0x00000001899500F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183DA83D0-0x0000000183DA8470
}

