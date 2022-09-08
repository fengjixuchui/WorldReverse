/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public struct TaskCData : ITaskData // TypeDefIndex: 9099
	{
		// Fields
		private const int INIT_MAX_NUM = 10; // Metadata: 0x00AE525F
		private static bool[] _dataIdentifies; // 0x00
		private static int _nextDataId; // 0x08
		private static ThreadList<TaskCData> _datas; // 0x10
		public const int staticTypeId = -97; // Metadata: 0x00AE5263
		private int _uid; // 0x04
		public Vector3 pos; // 0x08
	
		// Properties
		public static int nextDataId { /* [XID] */ /* 0x000000018970B170-0x000000018970B190 */ get => default; } // 0x000000018763D260-0x000000018763D5D0 
		public int nodeIndex { get; set; } // 0x000000018763D5D0-0x000000018763D6D0 0x000000018763D790-0x000000018763D7F0
		public int typeId { /* [XID] */ /* 0x00000001898E6520-0x00000001898E6540 */ get => default; } // 0x000000018763D6D0-0x000000018763D780 
		public int uid { /* [XID] */ /* 0x0000000189838920-0x0000000189838940 */ get => default; } // 0x000000018763D780-0x000000018763D790 
	
		// Constructors
		static TaskCData() {
			_dataIdentifies = default;
			_nextDataId = default;
			_datas = default;
		} // 0x000000018763D190-0x000000018763D260
	
		// Methods
		// [XID] // 0x0000000189935B00-0x0000000189935B20
		public static TaskCData Read(int id) => default; // 0x000000018763CF40-0x000000018763D180
		// [XID] // 0x0000000189B03C50-0x0000000189B03C70
		public void Init() {} // 0x000000018763CF30-0x000000018763CF40
		// [XID] // 0x00000001898FCF20-0x00000001898FCF40
		public void Write() {} // 0x000000018763D180-0x000000018763D190
		// [XID] // 0x00000001897F10E0-0x00000001897F1100
		public void Free() {} // 0x000000018763CE60-0x000000018763CF30
	}
}
