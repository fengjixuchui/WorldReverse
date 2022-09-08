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
public class WeaponCurveExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15681
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected GrowCurveInfo[] _curveInfos; // 0x18

	// Properties
	public uint level { /* [XID] */ /* 0x0000000189792840-0x0000000189792860 */ get => default; /* [XID] */ /* 0x0000000189799E10-0x0000000189799E30 */ protected set {} } // 0x00000001822DD6A0-0x00000001822DD770 0x00000001822DD5C0-0x00000001822DD6A0
	public GrowCurveInfo[] curveInfos { /* [XID] */ /* 0x00000001897A1D20-0x00000001897A1D40 */ get => default; /* [XID] */ /* 0x00000001897A9540-0x00000001897A9560 */ protected set {} } // 0x00000001822DD1B0-0x00000001822DD250 0x00000001822DD770-0x00000001822DD820

	// Constructors
	public WeaponCurveExcelConfig() {} // 0x00000001822DDA00-0x00000001822DDA60

	// Methods
	// [IDTag] // 0x00000001897B0CA0-0x00000001897B0CE0
	// [XID] // 0x00000001897B0CA0-0x00000001897B0CE0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001822DCE50-0x00000001822DD1B0
	// [IDTag] // 0x00000001897BC1B0-0x00000001897BC1F0
	// [XID] // 0x00000001897BC1B0-0x00000001897BC1F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001822DCB70-0x00000001822DCE50
	// [XID] // 0x00000001897C6AA0-0x00000001897C6AC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF22D8 */, bool useObjectPool = false /* Metadata: 0x00AF22DC */) => default; // 0x00000001822DD250-0x00000001822DD5C0
	[BlackList] // 0x00000001897CE260-0x00000001897CE2A0
	// [XID] // 0x00000001897CE260-0x00000001897CE2A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001822DC9F0-0x00000001822DCA90
	[BlackList] // 0x00000001897D8EB0-0x00000001897D8EF0
	// [XID] // 0x00000001897D8EB0-0x00000001897D8EF0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001822DCA90-0x00000001822DCB70
	[BlackList] // 0x00000001897E3100-0x00000001897E3140
	// [XID] // 0x00000001897E3100-0x00000001897E3140
	public virtual void ReturnToObjectPool() {} // 0x00000001822DD960-0x00000001822DDA00
	[BlackList] // 0x00000001897EDBB0-0x00000001897EDBF0
	// [XID] // 0x00000001897EDBB0-0x00000001897EDBF0
	public virtual void OnPoolAllocated() {} // 0x00000001822DD8C0-0x00000001822DD960
	[BlackList] // 0x00000001897F84E0-0x00000001897F8520
	// [XID] // 0x00000001897F84E0-0x00000001897F8520
	public virtual void OnBeforePoolRecycled() {} // 0x00000001822DD820-0x00000001822DD8C0
}

