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
public class PointInfo : IAutoAllocRecycle // TypeDefIndex: 15660
{
	// Fields
	protected SimpleSafeUInt32 pointIDRawNum; // 0x10
	protected SimpleSafeUInt32 pointTypeRawNum; // 0x14
	protected SimpleSafeFloat offsetXRawNum; // 0x18
	protected SimpleSafeFloat offsetYRawNum; // 0x1C
	protected SimpleSafeFloat offsetZRawNum; // 0x20
	protected SimpleSafeFloat rotXRawNum; // 0x24
	protected SimpleSafeFloat rotYRawNum; // 0x28
	protected SimpleSafeFloat rotZRawNum; // 0x2C

	// Properties
	public uint pointID { /* [XID] */ /* 0x00000001899475A0-0x00000001899475C0 */ get => default; /* [XID] */ /* 0x000000018994EE40-0x000000018994EE60 */ protected set {} } // 0x0000000183941960-0x0000000183941A30 0x0000000183941A30-0x0000000183941B10
	public uint pointType { /* [XID] */ /* 0x0000000189956400-0x0000000189956420 */ get => default; /* [XID] */ /* 0x000000018995DE50-0x000000018995DE70 */ protected set {} } // 0x00000001839426D0-0x00000001839427A0 0x0000000183941E90-0x0000000183941F70
	public float offsetX { /* [XID] */ /* 0x0000000189965650-0x0000000189965670 */ get => default; /* [XID] */ /* 0x000000018996CCF0-0x000000018996CD10 */ protected set {} } // 0x0000000183941BF0-0x0000000183941CD0 0x0000000183941290-0x0000000183941370
	public float offsetY { /* [XID] */ /* 0x0000000189974630-0x0000000189974650 */ get => default; /* [XID] */ /* 0x000000018997BC20-0x000000018997BC40 */ protected set {} } // 0x0000000183942AA0-0x0000000183942B80 0x0000000183941CD0-0x0000000183941DB0
	public float offsetZ { /* [XID] */ /* 0x00000001899837D0-0x00000001899837F0 */ get => default; /* [XID] */ /* 0x000000018998B080-0x000000018998B0A0 */ protected set {} } // 0x0000000183942880-0x0000000183942960 0x00000001839427A0-0x0000000183942880
	public float rotX { /* [XID] */ /* 0x0000000189992AB0-0x0000000189992AD0 */ get => default; /* [XID] */ /* 0x000000018999A730-0x000000018999A750 */ protected set {} } // 0x00000001839410D0-0x00000001839411B0 0x0000000183941B10-0x0000000183941BF0
	public float rotY { /* [XID] */ /* 0x00000001899A1DF0-0x00000001899A1E10 */ get => default; /* [XID] */ /* 0x00000001899A9740-0x00000001899A9760 */ protected set {} } // 0x00000001839411B0-0x0000000183941290 0x0000000183941DB0-0x0000000183941E90
	public float rotZ { /* [XID] */ /* 0x00000001899B1150-0x00000001899B1170 */ get => default; /* [XID] */ /* 0x00000001899B83F0-0x00000001899B8410 */ protected set {} } // 0x0000000183942B80-0x0000000183942C60 0x0000000183941880-0x0000000183941960

	// Constructors
	public PointInfo() {} // 0x0000000183942D00-0x0000000183942D60

	// Methods
	// [XID] // 0x00000001899BFF30-0x00000001899BFF50
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183941370-0x0000000183941880
	// [XID] // 0x00000001899C7710-0x00000001899C7730
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF221F */, bool useObjectPool = false /* Metadata: 0x00AF2223 */) => default; // 0x0000000183941F70-0x00000001839426D0
	[BlackList] // 0x00000001899CECE0-0x00000001899CED20
	// [XID] // 0x00000001899CECE0-0x00000001899CED20
	public virtual void AutoAllocTypeFields() {} // 0x0000000183940EB0-0x0000000183940F50
	[BlackList] // 0x00000001899D91F0-0x00000001899D9230
	// [XID] // 0x00000001899D91F0-0x00000001899D9230
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183940F50-0x00000001839410D0
	[BlackList] // 0x00000001899E3AB0-0x00000001899E3AF0
	// [XID] // 0x00000001899E3AB0-0x00000001899E3AF0
	public virtual void ReturnToObjectPool() {} // 0x0000000183942C60-0x0000000183942D00
	[BlackList] // 0x00000001899EE180-0x00000001899EE1C0
	// [XID] // 0x00000001899EE180-0x00000001899EE1C0
	public virtual void OnPoolAllocated() {} // 0x0000000183942A00-0x0000000183942AA0
	[BlackList] // 0x00000001899F89B0-0x00000001899F89F0
	// [XID] // 0x00000001899F89B0-0x00000001899F89F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183942960-0x0000000183942A00
}

