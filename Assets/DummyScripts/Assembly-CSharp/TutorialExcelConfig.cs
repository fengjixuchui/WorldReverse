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
public class TutorialExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16248
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _detailIdList; // 0x18
	protected bool _pauseGame; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189677ED0-0x0000000189677EF0 */ get => default; /* [XID] */ /* 0x000000018967F4A0-0x000000018967F4C0 */ protected set {} } // 0x00000001843BD430-0x00000001843BD500 0x00000001843BCE00-0x00000001843BCEE0
	public SimpleSafeUInt32[] detailIdList { /* [XID] */ /* 0x0000000189686CD0-0x0000000189686CF0 */ get => default; /* [XID] */ /* 0x000000018968EBF0-0x000000018968EC10 */ protected set {} } // 0x00000001843BCC10-0x00000001843BCCB0 0x00000001843BC220-0x00000001843BC2D0
	public bool pauseGame { /* [XID] */ /* 0x00000001896965F0-0x0000000189696610 */ get => default; /* [XID] */ /* 0x000000018969DB90-0x000000018969DBB0 */ protected set {} } // 0x00000001843BCD60-0x00000001843BCE00 0x00000001843BCCB0-0x00000001843BCD60

	// Constructors
	public TutorialExcelConfig() {} // 0x00000001843BD5A0-0x00000001843BD770

	// Methods
	// [IDTag] // 0x00000001896A4BC0-0x00000001896A4C00
	// [XID] // 0x00000001896A4BC0-0x00000001896A4C00
	public virtual bool ParseFromLine(string line) => default; // 0x00000001843BC750-0x00000001843BCC10
	// [IDTag] // 0x00000001896AF050-0x00000001896AF090
	// [XID] // 0x00000001896AF050-0x00000001896AF090
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843BC2D0-0x00000001843BC750
	// [XID] // 0x00000001896B94F0-0x00000001896B9510
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF357B */, bool useObjectPool = false /* Metadata: 0x00AF357F */) => default; // 0x00000001843BCEE0-0x00000001843BD2F0
	[BlackList] // 0x00000001896C0880-0x00000001896C08C0
	// [XID] // 0x00000001896C0880-0x00000001896C08C0
	public virtual void AutoAllocTypeFields() {} // 0x00000001843BC0A0-0x00000001843BC140
	[BlackList] // 0x00000001896CAD50-0x00000001896CAD90
	// [XID] // 0x00000001896CAD50-0x00000001896CAD90
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843BC140-0x00000001843BC220
	[BlackList] // 0x00000001896D5520-0x00000001896D5560
	// [XID] // 0x00000001896D5520-0x00000001896D5560
	public virtual void ReturnToObjectPool() {} // 0x00000001843BD500-0x00000001843BD5A0
	[BlackList] // 0x00000001896DFCC0-0x00000001896DFD00
	// [XID] // 0x00000001896DFCC0-0x00000001896DFD00
	public virtual void OnPoolAllocated() {} // 0x00000001843BD390-0x00000001843BD430
	[BlackList] // 0x00000001896EA0E0-0x00000001896EA120
	// [XID] // 0x00000001896EA0E0-0x00000001896EA120
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843BD2F0-0x00000001843BD390
}

