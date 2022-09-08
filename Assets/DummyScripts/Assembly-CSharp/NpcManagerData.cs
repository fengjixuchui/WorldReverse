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

public struct NpcManagerData : ITaskData // TypeDefIndex: 26619
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C6F8
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<NpcManagerData> _datas; // 0x10
	private static Queue<int> _freeIndex; // 0x18
	public const int staticTypeId = 17; // Metadata: 0x00B0C6FC
	private int _uid; // 0x04

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001899FF590-0x00000001899FF5B0 */ get => default; } // 0x0000000181A9A4F0-0x0000000181A9A970 
	public int nodeIndex { get; set; } // 0x0000000181A9AC70-0x0000000181A9AD70 0x0000000181A9AE30-0x0000000181A9AE90
	public int typeId { /* [XID] */ /* 0x0000000189A15AC0-0x0000000189A15AE0 */ get => default; } // 0x0000000181A9AD70-0x0000000181A9AE20 
	public int uid { /* [XID] */ /* 0x0000000189A3A8B0-0x0000000189A3A8D0 */ get => default; } // 0x0000000181A9AE20-0x0000000181A9AE30 

	// Constructors
	static NpcManagerData() {
		_dataIdentifies = default;
		_nextDataId = default;
		_datas = default;
		_freeIndex = default;
	} // 0x0000000181A9AB70-0x0000000181A9AC70

	// Methods
	// [XID] // 0x0000000189A1CF40-0x0000000189A1CF60
	public static NpcManagerData Read(int id) => default; // 0x0000000181A9A970-0x0000000181A9AB60
	// [XID] // 0x0000000189A24560-0x0000000189A24580
	public void Init() {} // 0x0000000181A9A4E0-0x0000000181A9A4F0
	// [XID] // 0x0000000189A2B960-0x0000000189A2B980
	public void Write() {} // 0x0000000181A9AB60-0x0000000181A9AB70
	// [XID] // 0x0000000189A32FA0-0x0000000189A32FC0
	public void Free() {} // 0x0000000181A9A360-0x0000000181A9A410
	// [XID] // 0x0000000189A421E0-0x0000000189A42200
	private void Clear() {} // 0x0000000181A9A410-0x0000000181A9A4E0
}

