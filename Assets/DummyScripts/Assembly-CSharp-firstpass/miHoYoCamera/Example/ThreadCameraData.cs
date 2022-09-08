/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using miHoYoCamera;
using miHoYoThread;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera.Example
{
	public struct ThreadCameraData : ITaskData // TypeDefIndex: 8981
	{
		// Fields
		private const int INIT_MAX_NUM = 10; // Metadata: 0x00AE4F85
		private static bool[] _dataIdentifies; // 0x00
		private static int _nextDataId; // 0x08
		private static ThreadList<ThreadCameraData> _datas; // 0x10
		private static Queue<int> _freeIndex; // 0x18
		public const int staticTypeId = 0; // Metadata: 0x00AE4F89
		private int _uid; // 0x04
		public ICameraState state; // 0x08
	
		// Properties
		public static int nextDataId { /* [XID] */ /* 0x0000000189B37A00-0x0000000189B37A20 */ get => default; } // 0x00000001873357C0-0x0000000187335C40 
		public int nodeIndex { get; set; } // 0x0000000187335C40-0x0000000187335D40 0x0000000187335E00-0x0000000187335E80
		public int typeId { /* [XID] */ /* 0x0000000189B4E4D0-0x0000000189B4E4F0 */ get => default; } // 0x0000000187335D40-0x0000000187335DF0 
		public int uid { /* [XID] */ /* 0x0000000189767780-0x00000001897677A0 */ get => default; } // 0x0000000187335DF0-0x0000000187335E00 
	
		// Constructors
		static ThreadCameraData() {
			_dataIdentifies = default;
			_nextDataId = default;
			_datas = default;
			_freeIndex = default;
		} // 0x00000001873356C0-0x00000001873357C0
	
		// Methods
		// [XID] // 0x0000000189B55B00-0x0000000189B55B20
		public static ThreadCameraData Read(int id) => default; // 0x00000001873354A0-0x00000001873356B0
		// [XID] // 0x0000000189B5D560-0x0000000189B5D580
		public void Init() {} // 0x0000000187335490-0x00000001873354A0
		// [XID] // 0x0000000189B64D00-0x0000000189B64D20
		public void Write() {} // 0x00000001873356B0-0x00000001873356C0
		// [XID] // 0x0000000189B6C0B0-0x0000000189B6C0D0
		public void Free() {} // 0x00000001873353C0-0x0000000187335490
		// [XID] // 0x0000000189B7AE60-0x0000000189B7AE80
		private void Clear() {} // 0x0000000187335240-0x00000001873353C0
	}
}
