/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using miHoYoThread;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread.Example
{
	public struct SimpleMoveData : ITaskData // TypeDefIndex: 9083
	{
		// Fields
		private const int INIT_MAX_NUM = 10; // Metadata: 0x00AE5217
		private static bool[] _dataIdentifies; // 0x00
		private static int _nextDataId; // 0x08
		private static ThreadList<SimpleMoveData> _datas; // 0x10
		public const int staticTypeId = 1; // Metadata: 0x00AE521B
		private int _uid; // 0x04
		public float spdX; // 0x08
		public float spdY; // 0x0C
		public float spdZ; // 0x10
		public Vector3 pos; // 0x14
		[MainThreadOnly] // 0x0000000189613C10-0x0000000189613C20
		public Transform moveTrans; // 0x20
	
		// Properties
		public static int nextDataId { /* [XID] */ /* 0x000000018961B370-0x000000018961B390 */ get => default; } // 0x000000018726BD90-0x000000018726C100 
		public int nodeIndex { get; set; } // 0x000000018726C100-0x000000018726C200 0x000000018726C2C0-0x000000018726C340
		public int typeId { /* [XID] */ /* 0x00000001896319C0-0x00000001896319E0 */ get => default; } // 0x000000018726C200-0x000000018726C2B0 
		public int uid { /* [XID] */ /* 0x000000018999C6F0-0x000000018999C710 */ get => default; } // 0x000000018726C2B0-0x000000018726C2C0 
	
		// Constructors
		static SimpleMoveData() {
			_dataIdentifies = default;
			_nextDataId = default;
			_datas = default;
		} // 0x000000018726BCC0-0x000000018726BD90
	
		// Methods
		// [XID] // 0x0000000189639450-0x0000000189639470
		public static SimpleMoveData Read(int id) => default; // 0x000000018726BA00-0x000000018726BCB0
		// [XID] // 0x0000000189640A30-0x0000000189640A50
		public void Init() {} // 0x000000018726B9F0-0x000000018726BA00
		// [XID] // 0x0000000189648320-0x0000000189648340
		public void Write() {} // 0x000000018726BCB0-0x000000018726BCC0
		// [XID] // 0x000000018964F910-0x000000018964F930
		public void Free() {} // 0x000000018726B920-0x000000018726B9F0
	}
}
