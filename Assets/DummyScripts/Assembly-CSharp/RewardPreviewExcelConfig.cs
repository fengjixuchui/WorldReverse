/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class RewardPreviewExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14911
{
	// Fields
	private List<IdCountStrConfig> _processedDropItems; // 0x10
	private uint _transformFormat; // 0x18
	protected SimpleSafeUInt32 idRawNum; // 0x1C
	protected string _Desc; // 0x20
	protected IdCountStrConfig[] _previewItems; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B4C780-0x0000000189B4C7A0 */ get => default; /* [XID] */ /* 0x0000000189B53E40-0x0000000189B53E60 */ protected set {} } // 0x00000001817F6C30-0x00000001817F6D00 0x00000001817F6260-0x00000001817F6340
	public string Desc { /* [XID] */ /* 0x0000000189B5B790-0x0000000189B5B7B0 */ get => default; /* [XID] */ /* 0x0000000189B62BC0-0x0000000189B62BE0 */ protected set {} } // 0x00000001817F6750-0x00000001817F67F0 0x00000001817F6DA0-0x00000001817F6E50
	public IdCountStrConfig[] previewItems { /* [XID] */ /* 0x0000000189B6A690-0x0000000189B6A6B0 */ get => default; /* [XID] */ /* 0x0000000189B71E30-0x0000000189B71E50 */ protected set {} } // 0x00000001817F6D00-0x00000001817F6DA0 0x00000001817F5A80-0x00000001817F5B30

	// Constructors
	public RewardPreviewExcelConfig() {} // 0x00000001817F6EF0-0x00000001817F6F60

	// Methods
	// [XID] // 0x0000000189B44FD0-0x0000000189B44FF0
	public List<IdCountStrConfig> GetProcessedDropItemList() => default; // 0x00000001817F67F0-0x00000001817F6AF0
	// [IDTag] // 0x0000000189B79220-0x0000000189B79260
	// [XID] // 0x0000000189B79220-0x0000000189B79260
	public virtual bool ParseFromLine(string line) => default; // 0x00000001817F5E80-0x00000001817F6260
	// [IDTag] // 0x0000000189B83AE0-0x0000000189B83B20
	// [XID] // 0x0000000189B83AE0-0x0000000189B83B20
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001817F5B30-0x00000001817F5E80
	// [XID] // 0x0000000189B8DCD0-0x0000000189B8DCF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF9B0 */, bool useObjectPool = false /* Metadata: 0x00AEF9B4 */) => default; // 0x00000001817F6340-0x00000001817F6750
	[BlackList] // 0x0000000189B951B0-0x0000000189B951F0
	// [XID] // 0x0000000189B951B0-0x0000000189B951F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001817F5900-0x00000001817F59A0
	[BlackList] // 0x0000000189B9F670-0x0000000189B9F6B0
	// [XID] // 0x0000000189B9F670-0x0000000189B9F6B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817F59A0-0x00000001817F5A80
	[BlackList] // 0x0000000189BA9E00-0x0000000189BA9E40
	// [XID] // 0x0000000189BA9E00-0x0000000189BA9E40
	public virtual void ReturnToObjectPool() {} // 0x00000001817F6E50-0x00000001817F6EF0
	[BlackList] // 0x0000000189BB42D0-0x0000000189BB4310
	// [XID] // 0x0000000189BB42D0-0x0000000189BB4310
	public virtual void OnPoolAllocated() {} // 0x00000001817F6B90-0x00000001817F6C30
	[BlackList] // 0x0000000189BBE570-0x0000000189BBE5B0
	// [XID] // 0x0000000189BBE570-0x0000000189BBE5B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817F6AF0-0x00000001817F6B90
}

