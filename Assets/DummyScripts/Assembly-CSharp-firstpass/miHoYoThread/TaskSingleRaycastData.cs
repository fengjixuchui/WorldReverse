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
	public struct TaskSingleRaycastData : ITaskData // TypeDefIndex: 9075
	{
		// Fields
		private const int INIT_MAX_NUM = 10; // Metadata: 0x00AE520F
		private static bool[] _dataIdentifies; // 0x00
		private static int _nextDataId; // 0x08
		private static ThreadList<TaskSingleRaycastData> _datas; // 0x10
		public const int staticTypeId = -1000; // Metadata: 0x00AE5213
		private int _uid; // 0x04
		public bool isHit; // 0x08
		public Vector3 hitPos; // 0x0C
		public string traceName; // 0x18
	
		// Properties
		public static int nextDataId { /* [XID] */ /* 0x0000000189B301D0-0x0000000189B301F0 */ get => default; } // 0x00000001854041E0-0x0000000185404550 
		public int nodeIndex { get; set; } // 0x0000000185404550-0x0000000185404650 0x0000000185404710-0x00000001854047F0
		public int typeId { /* [XID] */ /* 0x0000000189B46CC0-0x0000000189B46CE0 */ get => default; } // 0x0000000185404650-0x0000000185404700 
		public int uid { /* [XID] */ /* 0x0000000189B6C050-0x0000000189B6C070 */ get => default; } // 0x0000000185404700-0x0000000185404710 
	
		// Constructors
		static TaskSingleRaycastData() {
			_dataIdentifies = default;
			_nextDataId = default;
			_datas = default;
		} // 0x0000000185404110-0x00000001854041E0
	
		// Methods
		// [XID] // 0x0000000189831100-0x0000000189831120
		public static TaskSingleRaycastData Read(int id) => default; // 0x0000000185403E90-0x0000000185404100
		// [XID] // 0x0000000189B55AA0-0x0000000189B55AC0
		public void Init() {} // 0x0000000185403E80-0x0000000185403E90
		// [XID] // 0x0000000189864AB0-0x0000000189864AD0
		public void Write() {} // 0x0000000185404100-0x0000000185404110
		// [XID] // 0x0000000189B64CA0-0x0000000189B64CC0
		public void Free() {} // 0x0000000185403DB0-0x0000000185403E80
	}
}
