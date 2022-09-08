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
public class LampProgressControlConfig : IAutoAllocRecycle // TypeDefIndex: 15178
{
	// Fields
	protected SimpleSafeUInt32 hourRawNum; // 0x10
	protected SimpleSafeUInt32 minProgressRawNum; // 0x14
	protected SimpleSafeUInt32 maxProgressRawNum; // 0x18

	// Properties
	public uint hour { /* [XID] */ /* 0x000000018983FB50-0x000000018983FB70 */ get => default; /* [XID] */ /* 0x0000000189847190-0x00000001898471B0 */ protected set {} } // 0x0000000182CB5960-0x0000000182CB5A30 0x0000000182CB5A30-0x0000000182CB5B10
	public uint minProgress { /* [XID] */ /* 0x000000018984E860-0x000000018984E880 */ get => default; /* [XID] */ /* 0x0000000189855870-0x0000000189855890 */ protected set {} } // 0x0000000182CB5890-0x0000000182CB5960 0x0000000182CB6650-0x0000000182CB6730
	public uint maxProgress { /* [XID] */ /* 0x000000018985CCF0-0x000000018985CD10 */ get => default; /* [XID] */ /* 0x00000001898646D0-0x00000001898646F0 */ protected set {} } // 0x0000000182CB6170-0x0000000182CB6240 0x0000000182CB6090-0x0000000182CB6170

	// Constructors
	public LampProgressControlConfig() {} // 0x0000000182CB6910-0x0000000182CB6970

	// Methods
	// [IDTag] // 0x000000018986BCA0-0x000000018986BCE0
	// [XID] // 0x000000018986BCA0-0x000000018986BCE0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182CB5DB0-0x0000000182CB6090
	// [IDTag] // 0x00000001898760A0-0x00000001898760E0
	// [XID] // 0x00000001898760A0-0x00000001898760E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182CB5B10-0x0000000182CB5DB0
	// [XID] // 0x00000001898807C0-0x00000001898807E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0303 */, bool useObjectPool = false /* Metadata: 0x00AF0307 */) => default; // 0x0000000182CB6240-0x0000000182CB6650
	[BlackList] // 0x0000000189887D40-0x0000000189887D80
	// [XID] // 0x0000000189887D40-0x0000000189887D80
	public virtual void AutoAllocTypeFields() {} // 0x0000000182CB5700-0x0000000182CB57A0
	[BlackList] // 0x0000000189891F00-0x0000000189891F40
	// [XID] // 0x0000000189891F00-0x0000000189891F40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182CB57A0-0x0000000182CB5890
	[BlackList] // 0x000000018989C560-0x000000018989C5A0
	// [XID] // 0x000000018989C560-0x000000018989C5A0
	public virtual void ReturnToObjectPool() {} // 0x0000000182CB6870-0x0000000182CB6910
	[BlackList] // 0x00000001898A6C80-0x00000001898A6CC0
	// [XID] // 0x00000001898A6C80-0x00000001898A6CC0
	public virtual void OnPoolAllocated() {} // 0x0000000182CB67D0-0x0000000182CB6870
	[BlackList] // 0x00000001898B12A0-0x00000001898B12E0
	// [XID] // 0x00000001898B12A0-0x00000001898B12E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182CB6730-0x0000000182CB67D0
}

