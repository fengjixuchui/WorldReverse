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

public struct SignificanceData : ITaskData // TypeDefIndex: 26639
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C7A5
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<SignificanceData> _datas; // 0x10
	private static Queue<int> _freeIndex; // 0x18
	public const int staticTypeId = 5; // Metadata: 0x00B0C7A9
	private int _uid; // 0x04

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001899172F0-0x0000000189917310 */ get => default; } // 0x0000000184549840-0x0000000184549CC0 
	public int nodeIndex { get; set; } // 0x0000000184549FC0-0x000000018454A0C0 0x000000018454A180-0x000000018454A1E0
	public int typeId { /* [XID] */ /* 0x000000018992D940-0x000000018992D960 */ get => default; } // 0x000000018454A0C0-0x000000018454A170 
	public int uid { /* [XID] */ /* 0x0000000189952DE0-0x0000000189952E00 */ get => default; } // 0x000000018454A170-0x000000018454A180 

	// Constructors
	static SignificanceData() {
		_dataIdentifies = default;
		_nextDataId = default;
		_datas = default;
		_freeIndex = default;
	} // 0x0000000184549EC0-0x0000000184549FC0

	// Methods
	// [XID] // 0x0000000189934E10-0x0000000189934E30
	public static SignificanceData Read(int id) => default; // 0x0000000184549CC0-0x0000000184549EB0
	// [XID] // 0x000000018993C920-0x000000018993C940
	public void Init() {} // 0x0000000184549830-0x0000000184549840
	// [XID] // 0x0000000189943ED0-0x0000000189943EF0
	public void Write() {} // 0x0000000184549EB0-0x0000000184549EC0
	// [XID] // 0x000000018994B4C0-0x000000018994B4E0
	public void Free() {} // 0x00000001845496B0-0x0000000184549760
	// [XID] // 0x000000018995A330-0x000000018995A350
	private void Clear() {} // 0x0000000184549760-0x0000000184549830
}

