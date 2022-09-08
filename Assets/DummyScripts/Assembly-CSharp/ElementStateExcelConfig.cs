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
public class ElementStateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16169
{
	// Fields
	protected ElementType _elementType; // 0x10
	protected string _elementIcon; // 0x18
	protected SimpleSafeUInt32 rankRawNum; // 0x20

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x0000000189862EF0-0x0000000189862F10 */ get => default; /* [XID] */ /* 0x000000018986A360-0x000000018986A380 */ protected set {} } // 0x000000018476B4B0-0x000000018476B550 0x000000018476BAE0-0x000000018476BB90
	public string elementIcon { /* [XID] */ /* 0x0000000189871790-0x00000001898717B0 */ get => default; /* [XID] */ /* 0x0000000189878F70-0x0000000189878F90 */ protected set {} } // 0x000000018476B550-0x000000018476B5F0 0x000000018476BC60-0x000000018476BD10
	public uint rank { /* [XID] */ /* 0x0000000189880600-0x0000000189880620 */ get => default; /* [XID] */ /* 0x0000000189887B80-0x0000000189887BA0 */ protected set {} } // 0x000000018476BB90-0x000000018476BC60 0x000000018476BA00-0x000000018476BAE0

	// Constructors
	public ElementStateExcelConfig() {} // 0x000000018476BEF0-0x000000018476BF50

	// Methods
	// [IDTag] // 0x000000018988EE60-0x000000018988EEA0
	// [XID] // 0x000000018988EE60-0x000000018988EEA0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018476AF00-0x000000018476B1F0
	// [IDTag] // 0x0000000189899610-0x0000000189899650
	// [XID] // 0x0000000189899610-0x0000000189899650
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018476B1F0-0x000000018476B4B0
	// [XID] // 0x00000001898A3AE0-0x00000001898A3B00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3326 */, bool useObjectPool = false /* Metadata: 0x00AF332A */) => default; // 0x000000018476B5F0-0x000000018476BA00
	[BlackList] // 0x00000001898AADA0-0x00000001898AADE0
	// [XID] // 0x00000001898AADA0-0x00000001898AADE0
	public virtual void AutoAllocTypeFields() {} // 0x000000018476AD80-0x000000018476AE20
	[BlackList] // 0x00000001898B57B0-0x00000001898B57F0
	// [XID] // 0x00000001898B57B0-0x00000001898B57F0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018476AE20-0x000000018476AF00
	[BlackList] // 0x00000001898C0040-0x00000001898C0080
	// [XID] // 0x00000001898C0040-0x00000001898C0080
	public virtual void ReturnToObjectPool() {} // 0x000000018476BE50-0x000000018476BEF0
	[BlackList] // 0x00000001898CA8A0-0x00000001898CA8E0
	// [XID] // 0x00000001898CA8A0-0x00000001898CA8E0
	public virtual void OnPoolAllocated() {} // 0x000000018476BDB0-0x000000018476BE50
	[BlackList] // 0x00000001898D5130-0x00000001898D5170
	// [XID] // 0x00000001898D5130-0x00000001898D5170
	public virtual void OnBeforePoolRecycled() {} // 0x000000018476BD10-0x000000018476BDB0
}

