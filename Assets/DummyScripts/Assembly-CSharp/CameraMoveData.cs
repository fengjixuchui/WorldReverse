/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct CameraMoveData : ITaskData // TypeDefIndex: 26574
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C546
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<CameraMoveData> _datas; // 0x10
	public const int staticTypeId = 0; // Metadata: 0x00B0C54A
	private int _uid; // 0x04

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189875590-0x00000001898755B0 */ get => default; } // 0x00000001848DC980-0x00000001848DCCF0 
	public int nodeIndex { get; set; } // 0x00000001848DCFC0-0x00000001848DD0C0 0x00000001848DD180-0x00000001848DD1E0
	public int typeId { /* [XID] */ /* 0x000000018988B7A0-0x000000018988B7C0 */ get => default; } // 0x00000001848DD0C0-0x00000001848DD170 
	public int uid { /* [XID] */ /* 0x00000001898B0950-0x00000001898B0970 */ get => default; } // 0x00000001848DD170-0x00000001848DD180 

	// Constructors
	static CameraMoveData() {
		_dataIdentifies = default;
		_nextDataId = default;
		_datas = default;
	} // 0x00000001848DCEF0-0x00000001848DCFC0

	// Methods
	// [XID] // 0x0000000189892EA0-0x0000000189892EC0
	public static CameraMoveData Read(int id) => default; // 0x00000001848DCCF0-0x00000001848DCEE0
	// [XID] // 0x000000018989A510-0x000000018989A530
	public void Init() {} // 0x00000001848DC970-0x00000001848DC980
	// [XID] // 0x00000001898A1830-0x00000001898A1850
	public void Write() {} // 0x00000001848DCEE0-0x00000001848DCEF0
	// [XID] // 0x00000001898A8FE0-0x00000001898A9000
	public void Free() {} // 0x00000001848DC8A0-0x00000001848DC970
}

