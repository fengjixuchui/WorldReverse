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
public class TreeTypeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16233
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected string _treePattern; // 0x18
	protected TreeType _treeType; // 0x20

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189614C40-0x0000000189614C60 */ get => default; /* [XID] */ /* 0x000000018961C520-0x000000018961C540 */ protected set {} } // 0x00000001838FD150-0x00000001838FD220 0x00000001838FC7F0-0x00000001838FC8D0
	public string treePattern { /* [XID] */ /* 0x0000000189623920-0x0000000189623940 */ get => default; /* [XID] */ /* 0x000000018962B200-0x000000018962B220 */ protected set {} } // 0x00000001838FD220-0x00000001838FD2C0 0x00000001838FD000-0x00000001838FD0B0
	public TreeType treeType { /* [XID] */ /* 0x00000001896329C0-0x00000001896329E0 */ get => default; /* [XID] */ /* 0x000000018963A4D0-0x000000018963A4F0 */ protected set {} } // 0x00000001838FD0B0-0x00000001838FD150 0x00000001838FD2C0-0x00000001838FD370

	// Constructors
	public TreeTypeExcelConfig() {} // 0x00000001838FD960-0x00000001838FD9C0

	// Methods
	// [IDTag] // 0x0000000189641B00-0x0000000189641B40
	// [XID] // 0x0000000189641B00-0x0000000189641B40
	public virtual bool ParseFromLine(string line) => default; // 0x00000001838FCA50-0x00000001838FCD40
	// [IDTag] // 0x000000018964C470-0x000000018964C4B0
	// [XID] // 0x000000018964C470-0x000000018964C4B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001838FCD40-0x00000001838FD000
	// [XID] // 0x0000000189656A50-0x0000000189656A70
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF351F */, bool useObjectPool = false /* Metadata: 0x00AF3523 */) => default; // 0x00000001838FD370-0x00000001838FD780
	[BlackList] // 0x000000018965E090-0x000000018965E0D0
	// [XID] // 0x000000018965E090-0x000000018965E0D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001838FC8D0-0x00000001838FC970
	[BlackList] // 0x0000000189668B40-0x0000000189668B80
	// [XID] // 0x0000000189668B40-0x0000000189668B80
	public virtual void AutoRecycleTypeFields() {} // 0x00000001838FC970-0x00000001838FCA50
	[BlackList] // 0x00000001896733E0-0x0000000189673420
	// [XID] // 0x00000001896733E0-0x0000000189673420
	public virtual void ReturnToObjectPool() {} // 0x00000001838FD8C0-0x00000001838FD960
	[BlackList] // 0x000000018967DC80-0x000000018967DCC0
	// [XID] // 0x000000018967DC80-0x000000018967DCC0
	public virtual void OnPoolAllocated() {} // 0x00000001838FD820-0x00000001838FD8C0
	[BlackList] // 0x00000001896889A0-0x00000001896889E0
	// [XID] // 0x00000001896889A0-0x00000001896889E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001838FD780-0x00000001838FD820
}

