/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct MtrManagerData : ITaskData // TypeDefIndex: 26615
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C6DE
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<MtrManagerData> _datas; // 0x10
	private static Queue<int> _freeIndex; // 0x18
	public const int staticTypeId = 24; // Metadata: 0x00B0C6E2
	private int _uid; // 0x04

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001898EB620-0x00000001898EB640 */ get => default; } // 0x0000000182208520-0x00000001822089A0 
	public int nodeIndex { get; set; } // 0x0000000182208CA0-0x0000000182208DA0 0x0000000182208E60-0x0000000182208EC0
	public int typeId { /* [XID] */ /* 0x0000000189901F00-0x0000000189901F20 */ get => default; } // 0x0000000182208DA0-0x0000000182208E50 
	public int uid { /* [XID] */ /* 0x0000000189927840-0x0000000189927860 */ get => default; } // 0x0000000182208E50-0x0000000182208E60 

	// Constructors
	static MtrManagerData() {
		_dataIdentifies = default;
		_nextDataId = default;
		_datas = default;
		_freeIndex = default;
	} // 0x0000000182208BA0-0x0000000182208CA0

	// Methods
	// [XID] // 0x0000000189909750-0x0000000189909770
	public static MtrManagerData Read(int id) => default; // 0x00000001822089A0-0x0000000182208B90
	// [XID] // 0x0000000189910C80-0x0000000189910CA0
	public void Init() {} // 0x0000000182208510-0x0000000182208520
	// [XID] // 0x0000000189918820-0x0000000189918840
	public void Write() {} // 0x0000000182208B90-0x0000000182208BA0
	// [XID] // 0x000000018991FFE0-0x0000000189920000
	public void Free() {} // 0x0000000182208390-0x0000000182208440
	// [XID] // 0x000000018992EFC0-0x000000018992EFE0
	private void Clear() {} // 0x0000000182208440-0x0000000182208510
}

