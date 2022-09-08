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
public class WorldExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16094
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected WorldType _type; // 0x14
	protected SimpleSafeUInt32 mainSceneIdRawNum; // 0x18
	protected SimpleSafeUInt32[] _subSceneIdVec; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898353F0-0x0000000189835410 */ get => default; /* [XID] */ /* 0x000000018983CB30-0x000000018983CB50 */ protected set {} } // 0x00000001825354D0-0x00000001825355A0 0x0000000182534D50-0x0000000182534E30
	public WorldType type { /* [XID] */ /* 0x0000000189844240-0x0000000189844260 */ get => default; /* [XID] */ /* 0x000000018984B6B0-0x000000018984B6D0 */ protected set {} } // 0x00000001825355A0-0x0000000182535640 0x00000001825352E0-0x0000000182535390
	public uint mainSceneId { /* [XID] */ /* 0x0000000189852720-0x0000000189852740 */ get => default; /* [XID] */ /* 0x000000018985A1B0-0x000000018985A1D0 */ protected set {} } // 0x0000000182535640-0x0000000182535710 0x0000000182534180-0x0000000182534260
	public SimpleSafeUInt32[] subSceneIdVec { /* [XID] */ /* 0x0000000189861350-0x0000000189861370 */ get => default; /* [XID] */ /* 0x0000000189868AF0-0x0000000189868B10 */ protected set {} } // 0x0000000182533F50-0x0000000182533FF0 0x0000000182534CA0-0x0000000182534D50

	// Constructors
	public WorldExcelConfig() {} // 0x00000001825357B0-0x0000000182535810

	// Methods
	// [IDTag] // 0x000000018986FF60-0x000000018986FFA0
	// [XID] // 0x000000018986FF60-0x000000018986FFA0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182534260-0x00000001825347A0
	// [IDTag] // 0x000000018987AAF0-0x000000018987AB30
	// [XID] // 0x000000018987AAF0-0x000000018987AB30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001825347A0-0x0000000182534CA0
	// [XID] // 0x0000000189884A10-0x0000000189884A30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3018 */, bool useObjectPool = false /* Metadata: 0x00AF301C */) => default; // 0x0000000182534E30-0x00000001825352E0
	[BlackList] // 0x000000018988C0C0-0x000000018988C100
	// [XID] // 0x000000018988C0C0-0x000000018988C100
	public virtual void AutoAllocTypeFields() {} // 0x0000000182533FF0-0x0000000182534090
	[BlackList] // 0x0000000189896420-0x0000000189896460
	// [XID] // 0x0000000189896420-0x0000000189896460
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182534090-0x0000000182534180
	[BlackList] // 0x00000001898A07F0-0x00000001898A0830
	// [XID] // 0x00000001898A07F0-0x00000001898A0830
	public virtual void ReturnToObjectPool() {} // 0x0000000182535710-0x00000001825357B0
	[BlackList] // 0x00000001898AADE0-0x00000001898AAE20
	// [XID] // 0x00000001898AADE0-0x00000001898AAE20
	public virtual void OnPoolAllocated() {} // 0x0000000182535430-0x00000001825354D0
	[BlackList] // 0x00000001898B5810-0x00000001898B5850
	// [XID] // 0x00000001898B5810-0x00000001898B5850
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182535390-0x0000000182535430
}

