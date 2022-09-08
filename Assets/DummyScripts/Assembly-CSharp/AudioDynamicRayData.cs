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

public struct AudioDynamicRayData : ITaskData // TypeDefIndex: 26568
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C50A
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<AudioDynamicRayData> _datas; // 0x10
	private static Queue<int> _freeIndex; // 0x18
	public const int staticTypeId = 23; // Metadata: 0x00B0C50E
	private int _uid; // 0x04

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001897176D0-0x00000001897176F0 */ get => default; } // 0x00000001839D8B40-0x00000001839D8FC0 
	public int nodeIndex { get; set; } // 0x00000001839D92C0-0x00000001839D93C0 0x00000001839D9480-0x00000001839D94E0
	public int typeId { /* [XID] */ /* 0x000000018972DD90-0x000000018972DDB0 */ get => default; } // 0x00000001839D93C0-0x00000001839D9470 
	public int uid { /* [XID] */ /* 0x0000000189753450-0x0000000189753470 */ get => default; } // 0x00000001839D9470-0x00000001839D9480 

	// Constructors
	static AudioDynamicRayData() {
		_dataIdentifies = default;
		_nextDataId = default;
		_datas = default;
		_freeIndex = default;
	} // 0x00000001839D91C0-0x00000001839D92C0

	// Methods
	// [XID] // 0x0000000189735430-0x0000000189735450
	public static AudioDynamicRayData Read(int id) => default; // 0x00000001839D8FC0-0x00000001839D91B0
	// [XID] // 0x000000018973CF20-0x000000018973CF40
	public void Init() {} // 0x00000001839D8B30-0x00000001839D8B40
	// [XID] // 0x00000001897444D0-0x00000001897444F0
	public void Write() {} // 0x00000001839D91B0-0x00000001839D91C0
	// [XID] // 0x000000018974C160-0x000000018974C180
	public void Free() {} // 0x00000001839D89B0-0x00000001839D8A60
	// [XID] // 0x000000018975A8F0-0x000000018975A910
	private void Clear() {} // 0x00000001839D8A60-0x00000001839D8B30
}

