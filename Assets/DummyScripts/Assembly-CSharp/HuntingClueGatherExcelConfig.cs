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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class HuntingClueGatherExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15752
{
	// Fields
	protected SimpleSafeUInt32 configIdRawNum; // 0x10
	protected SimpleSafeUInt32 gatherIdRawNum; // 0x14
	protected SimpleSafeUInt32 gatherGroupIdRawNum; // 0x18
	protected bool _isClueGather; // 0x1C

	// Properties
	public uint configId { /* [XID] */ /* 0x000000018962FAC0-0x000000018962FAE0 */ get => default; /* [XID] */ /* 0x00000001896376C0-0x00000001896376E0 */ protected set {} } // 0x00000001847E57B0-0x00000001847E5880 0x00000001847E5E10-0x00000001847E5EF0
	public uint gatherId { /* [XID] */ /* 0x000000018963EBC0-0x000000018963EBE0 */ get => default; /* [XID] */ /* 0x0000000189646340-0x0000000189646360 */ protected set {} } // 0x00000001847E5570-0x00000001847E5640 0x00000001847E5880-0x00000001847E5960
	public uint gatherGroupId { /* [XID] */ /* 0x000000018964DB40-0x000000018964DB60 */ get => default; /* [XID] */ /* 0x00000001896553A0-0x00000001896553C0 */ protected set {} } // 0x00000001847E5640-0x00000001847E5710 0x00000001847E5490-0x00000001847E5570
	public bool isClueGather { /* [XID] */ /* 0x000000018965CBC0-0x000000018965CBE0 */ get => default; /* [XID] */ /* 0x00000001896640E0-0x0000000189664100 */ protected set {} } // 0x00000001847E5710-0x00000001847E57B0 0x00000001847E6030-0x00000001847E60E0

	// Constructors
	public HuntingClueGatherExcelConfig() {} // 0x00000001847E6180-0x00000001847E61E0

	// Methods
	// [IDTag] // 0x000000018966B700-0x000000018966B740
	// [XID] // 0x000000018966B700-0x000000018966B740
	public virtual bool ParseFromLine(string line) => default; // 0x00000001847E4E20-0x00000001847E5170
	// [IDTag] // 0x00000001896765A0-0x00000001896765E0
	// [XID] // 0x00000001896765A0-0x00000001896765E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001847E5170-0x00000001847E5490
	// [XID] // 0x0000000189681020-0x0000000189681040
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2512 */, bool useObjectPool = false /* Metadata: 0x00AF2516 */) => default; // 0x00000001847E5960-0x00000001847E5E10
	[BlackList] // 0x0000000189688AC0-0x0000000189688B00
	// [XID] // 0x0000000189688AC0-0x0000000189688B00
	public virtual void AutoAllocTypeFields() {} // 0x00000001847E4C80-0x00000001847E4D20
	[BlackList] // 0x0000000189693620-0x0000000189693660
	// [XID] // 0x0000000189693620-0x0000000189693660
	public virtual void AutoRecycleTypeFields() {} // 0x00000001847E4D20-0x00000001847E4E20
	[BlackList] // 0x000000018969DC50-0x000000018969DC90
	// [XID] // 0x000000018969DC50-0x000000018969DC90
	public virtual void ReturnToObjectPool() {} // 0x00000001847E60E0-0x00000001847E6180
	[BlackList] // 0x00000001896A7D80-0x00000001896A7DC0
	// [XID] // 0x00000001896A7D80-0x00000001896A7DC0
	public virtual void OnPoolAllocated() {} // 0x00000001847E5F90-0x00000001847E6030
	[BlackList] // 0x00000001896B1BB0-0x00000001896B1BF0
	// [XID] // 0x00000001896B1BB0-0x00000001896B1BF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001847E5EF0-0x00000001847E5F90
}

