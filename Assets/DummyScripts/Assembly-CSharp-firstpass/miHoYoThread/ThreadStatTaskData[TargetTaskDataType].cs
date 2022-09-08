/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public struct ThreadStatTaskData<TargetTaskDataType> : ITaskData // TypeDefIndex: 9107
		where TargetTaskDataType : ITaskData, new()
	{
		// Fields
		private const int INIT_MAX_NUM = 100; // Metadata: 0x00AE528E
		private static bool[] _dataIdentifies;
		private static int _nextDataId;
		private static ThreadList<ThreadStatTaskData<TargetTaskDataType>> _datas;
		public const int staticTypeId = -100; // Metadata: 0x00AE5292
		private int _uid;
		public TargetTaskDataType targetTaskData;
		public long timeCost;
	
		// Properties
		public static int nextDataId { get => default; }
		public int nodeIndex { get; set; }
		public int typeId { get => default; }
		public int uid { get => default; }
	
		// Constructors
		static ThreadStatTaskData() {
			_dataIdentifies = default;
			_nextDataId = default;
			_datas = default;
		}
	
		// Methods
		public static ThreadStatTaskData<TargetTaskDataType> Read(int id) => default;
		public void Init() {}
		public void Write() {}
		public void Free() {}
	}
}
