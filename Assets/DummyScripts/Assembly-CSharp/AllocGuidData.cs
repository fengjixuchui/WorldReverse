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

public struct AllocGuidData : ITaskData // TypeDefIndex: 26566
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C4F5
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<AllocGuidData> _datas; // 0x10
	private static Queue<int> _freeIndex; // 0x18
	public const int staticTypeId = 4; // Metadata: 0x00B0C4F9
	private int _uid; // 0x04

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001896B4920-0x00000001896B4940 */ get => default; } // 0x000000018399EC20-0x000000018399F0A0 
	public int nodeIndex { get; set; } // 0x000000018399F3A0-0x000000018399F4A0 0x000000018399F560-0x000000018399F620
	public int typeId { /* [XID] */ /* 0x00000001896CA4C0-0x00000001896CA4E0 */ get => default; } // 0x000000018399F4A0-0x000000018399F550 
	public int uid { /* [XID] */ /* 0x00000001896EF5B0-0x00000001896EF5D0 */ get => default; } // 0x000000018399F550-0x000000018399F560 

	// Constructors
	static AllocGuidData() {
		_dataIdentifies = default;
		_nextDataId = default;
		_datas = default;
		_freeIndex = default;
	} // 0x000000018399F2A0-0x000000018399F3A0

	// Methods
	// [XID] // 0x00000001896D1B30-0x00000001896D1B50
	public static AllocGuidData Read(int id) => default; // 0x000000018399F0A0-0x000000018399F290
	// [XID] // 0x00000001896D9360-0x00000001896D9380
	public void Init() {} // 0x000000018399EC10-0x000000018399EC20
	// [XID] // 0x00000001896E0BE0-0x00000001896E0C00
	public void Write() {} // 0x000000018399F290-0x000000018399F2A0
	// [XID] // 0x00000001896E7E00-0x00000001896E7E20
	public void Free() {} // 0x000000018399EA90-0x000000018399EB40
	// [XID] // 0x00000001896F6EA0-0x00000001896F6EC0
	private void Clear() {} // 0x000000018399EB40-0x000000018399EC10
}

