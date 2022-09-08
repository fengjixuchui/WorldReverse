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

public struct SignificanceTickLODData : ITaskData // TypeDefIndex: 26645
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C7C1
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<SignificanceTickLODData> _datas; // 0x10
	private static Queue<int> _freeIndex; // 0x18
	public const int staticTypeId = 20; // Metadata: 0x00B0C7C5
	private int _uid; // 0x04

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001899FF570-0x00000001899FF590 */ get => default; } // 0x0000000182810EE0-0x0000000182811360 
	public int nodeIndex { get; set; } // 0x0000000182811660-0x0000000182811760 0x0000000182811820-0x0000000182811880
	public int typeId { /* [XID] */ /* 0x0000000189A15AA0-0x0000000189A15AC0 */ get => default; } // 0x0000000182811760-0x0000000182811810 
	public int uid { /* [XID] */ /* 0x0000000189A3A890-0x0000000189A3A8B0 */ get => default; } // 0x0000000182811810-0x0000000182811820 

	// Constructors
	static SignificanceTickLODData() {
		_dataIdentifies = default;
		_nextDataId = default;
		_datas = default;
		_freeIndex = default;
	} // 0x0000000182811560-0x0000000182811660

	// Methods
	// [XID] // 0x0000000189A1CF20-0x0000000189A1CF40
	public static SignificanceTickLODData Read(int id) => default; // 0x0000000182811360-0x0000000182811550
	// [XID] // 0x0000000189A24540-0x0000000189A24560
	public void Init() {} // 0x0000000182810ED0-0x0000000182810EE0
	// [XID] // 0x0000000189A2B940-0x0000000189A2B960
	public void Write() {} // 0x0000000182811550-0x0000000182811560
	// [XID] // 0x0000000189A32F80-0x0000000189A32FA0
	public void Free() {} // 0x0000000182810D50-0x0000000182810E00
	// [XID] // 0x0000000189A421C0-0x0000000189A421E0
	private void Clear() {} // 0x0000000182810E00-0x0000000182810ED0
}

