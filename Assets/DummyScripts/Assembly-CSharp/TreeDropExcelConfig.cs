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
public class TreeDropExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16231
{
	// Fields
	protected TreeType _treeType; // 0x10
	protected SimpleSafeUInt32 dropIdRawNum; // 0x14

	// Properties
	public TreeType treeType { /* [XID] */ /* 0x0000000189B1DE70-0x0000000189B1DE90 */ get => default; /* [XID] */ /* 0x0000000189B25760-0x0000000189B25780 */ protected set {} } // 0x0000000182C4F370-0x0000000182C4F410 0x0000000182C4F410-0x0000000182C4F4C0
	public uint dropId { /* [XID] */ /* 0x0000000189B2CBF0-0x0000000189B2CC10 */ get => default; /* [XID] */ /* 0x0000000189B340E0-0x0000000189B34100 */ protected set {} } // 0x0000000182C4F2A0-0x0000000182C4F370 0x0000000182C4F820-0x0000000182C4F900

	// Constructors
	public TreeDropExcelConfig() {} // 0x0000000182C4FAE0-0x0000000182C4FB40

	// Methods
	// [IDTag] // 0x0000000189B3B9D0-0x0000000189B3BA10
	// [XID] // 0x0000000189B3B9D0-0x0000000189B3BA10
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182C4F010-0x0000000182C4F2A0
	// [IDTag] // 0x0000000189B46520-0x0000000189B46560
	// [XID] // 0x0000000189B46520-0x0000000189B46560
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182C4EDD0-0x0000000182C4F010
	// [XID] // 0x0000000189B50D80-0x0000000189B50DA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3510 */, bool useObjectPool = false /* Metadata: 0x00AF3514 */) => default; // 0x0000000182C4F4C0-0x0000000182C4F820
	[BlackList] // 0x0000000189B58550-0x0000000189B58590
	// [XID] // 0x0000000189B58550-0x0000000189B58590
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C4EC60-0x0000000182C4ED00
	[BlackList] // 0x0000000189B628A0-0x0000000189B628E0
	// [XID] // 0x0000000189B628A0-0x0000000189B628E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C4ED00-0x0000000182C4EDD0
	[BlackList] // 0x0000000189B6D0E0-0x0000000189B6D120
	// [XID] // 0x0000000189B6D0E0-0x0000000189B6D120
	public virtual void ReturnToObjectPool() {} // 0x0000000182C4FA40-0x0000000182C4FAE0
	[BlackList] // 0x0000000189B776B0-0x0000000189B776F0
	// [XID] // 0x0000000189B776B0-0x0000000189B776F0
	public virtual void OnPoolAllocated() {} // 0x0000000182C4F9A0-0x0000000182C4FA40
	[BlackList] // 0x0000000189B81ED0-0x0000000189B81F10
	// [XID] // 0x0000000189B81ED0-0x0000000189B81F10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C4F900-0x0000000182C4F9A0
}

