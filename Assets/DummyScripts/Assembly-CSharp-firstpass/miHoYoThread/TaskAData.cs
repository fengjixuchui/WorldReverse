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
	public struct TaskAData : ITaskData // TypeDefIndex: 9097
	{
		// Fields
		private const int INIT_MAX_NUM = 10; // Metadata: 0x00AE524F
		private static bool[] _dataIdentifies; // 0x00
		private static int _nextDataId; // 0x08
		private static ThreadList<TaskAData> _datas; // 0x10
		public const int staticTypeId = -99; // Metadata: 0x00AE5253
		private int _uid; // 0x04
		public Vector3 pos; // 0x08
	
		// Properties
		public static int nextDataId { /* [XID] */ /* 0x0000000189835CB0-0x0000000189835CD0 */ get => default; } // 0x000000018763BE00-0x000000018763C170 
		public int nodeIndex { get; set; } // 0x000000018763C170-0x000000018763C270 0x000000018763C330-0x000000018763C430
		public int typeId { /* [XID] */ /* 0x000000018984BE70-0x000000018984BE90 */ get => default; } // 0x000000018763C270-0x000000018763C320 
		public int uid { /* [XID] */ /* 0x00000001898705F0-0x0000000189870610 */ get => default; } // 0x000000018763C320-0x000000018763C330 
	
		// Constructors
		static TaskAData() {
			_dataIdentifies = default;
			_nextDataId = default;
			_datas = default;
		} // 0x000000018763BD30-0x000000018763BE00
	
		// Methods
		// [XID] // 0x0000000189852D50-0x0000000189852D70
		public static TaskAData Read(int id) => default; // 0x000000018763BAE0-0x000000018763BD20
		// [XID] // 0x000000018985A9B0-0x000000018985A9D0
		public void Init() {} // 0x000000018763BAD0-0x000000018763BAE0
		// [XID] // 0x00000001898CDBD0-0x00000001898CDBF0
		public void Write() {} // 0x000000018763BD20-0x000000018763BD30
		// [XID] // 0x00000001898693A0-0x00000001898693C0
		public void Free() {} // 0x000000018763BA00-0x000000018763BAD0
	}
}
