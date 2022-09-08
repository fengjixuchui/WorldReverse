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

public struct LevelAiManagerData : ITaskData // TypeDefIndex: 26606
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C688
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<LevelAiManagerData> _datas; // 0x10
	private static Queue<int> _freeIndex; // 0x18
	public const int staticTypeId = 15; // Metadata: 0x00B0C68C
	private int _uid; // 0x04
	public LCAIManager aiManager; // 0x08

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001896AE810-0x00000001896AE830 */ get => default; } // 0x0000000183CD1B10-0x0000000183CD1F90 
	public int nodeIndex { get; set; } // 0x0000000183CD22D0-0x0000000183CD23D0 0x0000000183CD2490-0x0000000183CD2510
	public int typeId { /* [XID] */ /* 0x00000001896C47B0-0x00000001896C47D0 */ get => default; } // 0x0000000183CD23D0-0x0000000183CD2480 
	public int uid { /* [XID] */ /* 0x00000001896E9870-0x00000001896E9890 */ get => default; } // 0x0000000183CD2480-0x0000000183CD2490 

	// Constructors
	static LevelAiManagerData() {
		_dataIdentifies = default;
		_nextDataId = default;
		_datas = default;
		_freeIndex = default;
	} // 0x0000000183CD21D0-0x0000000183CD22D0

	// Methods
	// [XID] // 0x00000001896CBD10-0x00000001896CBD30
	public static LevelAiManagerData Read(int id) => default; // 0x0000000183CD1F90-0x0000000183CD21C0
	// [XID] // 0x00000001896D3070-0x00000001896D3090
	public void Init() {} // 0x0000000183CD1B00-0x0000000183CD1B10
	// [XID] // 0x00000001896DAC00-0x00000001896DAC20
	public void Write() {} // 0x0000000183CD21C0-0x0000000183CD21D0
	// [XID] // 0x00000001896E22F0-0x00000001896E2310
	public void Free() {} // 0x0000000183CD1980-0x0000000183CD1A30
	// [XID] // 0x00000001896F0A90-0x00000001896F0AB0
	private void Clear() {} // 0x0000000183CD1A30-0x0000000183CD1B00
}

