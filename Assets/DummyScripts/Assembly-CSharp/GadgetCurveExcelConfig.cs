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
public class GadgetCurveExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15679
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected GrowCurveInfo[] _curveInfos; // 0x18

	// Properties
	public uint level { /* [XID] */ /* 0x00000001896A22C0-0x00000001896A22E0 */ get => default; /* [XID] */ /* 0x00000001896A9540-0x00000001896A9560 */ protected set {} } // 0x0000000182B65370-0x0000000182B65440 0x0000000182B65290-0x0000000182B65370
	public GrowCurveInfo[] curveInfos { /* [XID] */ /* 0x00000001896B0690-0x00000001896B06B0 */ get => default; /* [XID] */ /* 0x00000001896B80B0-0x00000001896B80D0 */ protected set {} } // 0x0000000182B64E80-0x0000000182B64F20 0x0000000182B65440-0x0000000182B654F0

	// Constructors
	public GadgetCurveExcelConfig() {} // 0x0000000182B656D0-0x0000000182B65730

	// Methods
	// [IDTag] // 0x00000001896BF150-0x00000001896BF190
	// [XID] // 0x00000001896BF150-0x00000001896BF190
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182B64840-0x0000000182B64BA0
	// [IDTag] // 0x00000001896C9630-0x00000001896C9670
	// [XID] // 0x00000001896C9630-0x00000001896C9670
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182B64BA0-0x0000000182B64E80
	// [XID] // 0x00000001896D3AC0-0x00000001896D3AE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF22C9 */, bool useObjectPool = false /* Metadata: 0x00AF22CD */) => default; // 0x0000000182B64F20-0x0000000182B65290
	[BlackList] // 0x00000001896DB4C0-0x00000001896DB500
	// [XID] // 0x00000001896DB4C0-0x00000001896DB500
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B646C0-0x0000000182B64760
	[BlackList] // 0x00000001896E58B0-0x00000001896E58F0
	// [XID] // 0x00000001896E58B0-0x00000001896E58F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B64760-0x0000000182B64840
	[BlackList] // 0x00000001896EFD00-0x00000001896EFD40
	// [XID] // 0x00000001896EFD00-0x00000001896EFD40
	public virtual void ReturnToObjectPool() {} // 0x0000000182B65630-0x0000000182B656D0
	[BlackList] // 0x00000001896FA6B0-0x00000001896FA6F0
	// [XID] // 0x00000001896FA6B0-0x00000001896FA6F0
	public virtual void OnPoolAllocated() {} // 0x0000000182B65590-0x0000000182B65630
	[BlackList] // 0x0000000189704CD0-0x0000000189704D10
	// [XID] // 0x0000000189704CD0-0x0000000189704D10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B654F0-0x0000000182B65590
}

