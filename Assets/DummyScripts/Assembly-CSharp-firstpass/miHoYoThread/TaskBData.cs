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
	public struct TaskBData : ITaskData // TypeDefIndex: 9098
	{
		// Fields
		private const int INIT_MAX_NUM = 10; // Metadata: 0x00AE5257
		private static bool[] _dataIdentifies; // 0x00
		private static int _nextDataId; // 0x08
		private static ThreadList<TaskBData> _datas; // 0x10
		public const int staticTypeId = -98; // Metadata: 0x00AE525B
		private int _uid; // 0x04
		public Vector3 euler; // 0x08
	
		// Properties
		public static int nextDataId { /* [XID] */ /* 0x0000000189A326B0-0x0000000189A326D0 */ get => default; } // 0x000000018763C830-0x000000018763CBA0 
		public int nodeIndex { get; set; } // 0x000000018763CBA0-0x000000018763CCA0 0x000000018763CD60-0x000000018763CE60
		public int typeId { /* [XID] */ /* 0x0000000189764840-0x0000000189764860 */ get => default; } // 0x000000018763CCA0-0x000000018763CD50 
		public int uid { /* [XID] */ /* 0x00000001898BD7A0-0x00000001898BD7C0 */ get => default; } // 0x000000018763CD50-0x000000018763CD60 
	
		// Constructors
		static TaskBData() {
			_dataIdentifies = default;
			_nextDataId = default;
			_datas = default;
		} // 0x000000018763C760-0x000000018763C830
	
		// Methods
		// [XID] // 0x00000001898B0030-0x00000001898B0050
		public static TaskBData Read(int id) => default; // 0x000000018763C510-0x000000018763C750
		// [XID] // 0x0000000189A85450-0x0000000189A85470
		public void Init() {} // 0x000000018763C500-0x000000018763C510
		// [XID] // 0x0000000189904580-0x00000001899045A0
		public void Write() {} // 0x000000018763C750-0x000000018763C760
		// [XID] // 0x00000001898B5E10-0x00000001898B5E30
		public void Free() {} // 0x000000018763C430-0x000000018763C500
	}
}
