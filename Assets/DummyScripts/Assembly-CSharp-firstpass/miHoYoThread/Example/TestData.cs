/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using miHoYoThread;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread.Example
{
	public struct TestData : ITaskData // TypeDefIndex: 9091
	{
		// Fields
		private const int INIT_MAX_NUM = 10; // Metadata: 0x00AE523F
		private static bool[] _dataIdentifies; // 0x00
		private static int _nextDataId; // 0x08
		private static ThreadList<TestData> _datas; // 0x10
		public const int staticTypeId = 0; // Metadata: 0x00AE5243
		private int _uid; // 0x04
	
		// Properties
		public static int nextDataId { /* [XID] */ /* 0x0000000189747110-0x0000000189747130 */ get => default; } // 0x000000018726E1D0-0x000000018726E540 
		public int nodeIndex { get; set; } // 0x000000018726E540-0x000000018726E640 0x000000018726E700-0x000000018726E760
		public int typeId { /* [XID] */ /* 0x000000018975D340-0x000000018975D360 */ get => default; } // 0x000000018726E640-0x000000018726E6F0 
		public int uid { /* [XID] */ /* 0x0000000189782C90-0x0000000189782CB0 */ get => default; } // 0x000000018726E6F0-0x000000018726E700 
	
		// Constructors
		static TestData() {
			_dataIdentifies = default;
			_nextDataId = default;
			_datas = default;
		} // 0x000000018726E100-0x000000018726E1D0
	
		// Methods
		// [XID] // 0x0000000189A5DBC0-0x0000000189A5DBE0
		public static TestData Read(int id) => default; // 0x000000018726DF00-0x000000018726E0F0
		// [XID] // 0x000000018976C450-0x000000018976C470
		public void Init() {} // 0x000000018726DEF0-0x000000018726DF00
		// [XID] // 0x000000018975B8D0-0x000000018975B8F0
		public void Write() {} // 0x000000018726E0F0-0x000000018726E100
		// [XID] // 0x000000018977B0F0-0x000000018977B110
		public void Free() {} // 0x000000018726DE20-0x000000018726DEF0
	}
}
