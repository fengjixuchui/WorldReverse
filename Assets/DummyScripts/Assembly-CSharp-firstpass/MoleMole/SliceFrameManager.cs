/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class SliceFrameManager // TypeDefIndex: 10622
	{
		// Fields
		private static List<SliceFrameBlock> _slices; // 0x00
		private Dictionary<string, SliceFrameWatch> frameDict; // 0x10
		public static bool sharedSliceUsing; // 0x08
		private SliceFrameWatch _sharedSliceFrameGameSystemWatch; // 0x18
		private static SliceFrameWatch _sliceFrameBlockWatch; // 0x10
		private static Dictionary<string, MMAField> _fieldDict; // 0x18
		private static float _lastDumpTime; // 0x20
		private WeightedRoundRobin _wrrGameSystemWatch; // 0x20
	
		// Nested types
		public class SliceFrameBlock // TypeDefIndex: 10623
		{
			// Properties
			public long tickThreshold { /* [XID] */ /* 0x0000000189A253B0-0x0000000189A253F0 */ get; /* [XID] */ /* 0x0000000189A2F9D0-0x0000000189A2FA10 */ set; } // 0x00000001868A4FD0-0x00000001868A5030 0x00000001868A51C0-0x00000001868A5220
			public float radio { /* [XID] */ /* 0x0000000189A3A1F0-0x0000000189A3A230 */ get; /* [XID] */ /* 0x0000000189A44910-0x0000000189A44950 */ set; } // 0x00000001868A4F60-0x00000001868A4FD0 0x00000001868A5150-0x00000001868A51C0
			public string name { /* [XID] */ /* 0x0000000189A4F090-0x0000000189A4F0D0 */ get; /* [XID] */ /* 0x0000000189A598F0-0x0000000189A59930 */ set; } // 0x00000001868A4DB0-0x00000001868A4E10 0x00000001868A50F0-0x00000001868A5150
			public int hash { /* [XID] */ /* 0x0000000189A64330-0x0000000189A64370 */ get; /* [XID] */ /* 0x0000000189A6EA80-0x0000000189A6EAC0 */ set; } // 0x00000001868A4CF0-0x00000001868A4D50 0x00000001868A5030-0x00000001868A5090
			public long nowTickThreshold { /* [XID] */ /* 0x0000000189A3AEE0-0x0000000189A3AF00 */ get => default; } // 0x00000001868A4E10-0x00000001868A4F60 
			public long leftTickThreshold { /* [XID] */ /* 0x0000000189A80B40-0x0000000189A80B80 */ get; /* [XID] */ /* 0x0000000189A8B760-0x0000000189A8B7A0 */ set; } // 0x00000001868A4D50-0x00000001868A4DB0 0x00000001868A5090-0x00000001868A50F0
	
			// Constructors
			public SliceFrameBlock() {} // 0x00000001868A4C90-0x00000001868A4CF0
	
			// Methods
			// [XID] // 0x0000000189A95B90-0x0000000189A95BB0
			public void Refresh() {} // 0x00000001868A4BA0-0x00000001868A4C90
		}
	
		// Constructors
		public SliceFrameManager() {} // 0x00000001868A7A40-0x00000001868A7B30
		static SliceFrameManager() {} // 0x00000001868A7930-0x00000001868A7A40
	
		// Methods
		// [XID] // 0x0000000189A29A00-0x0000000189A29A20
		public static void RecordDump() {} // 0x00000001868A65C0-0x00000001868A6BA0
		// [XID] // 0x0000000189726000-0x0000000189726020
		public static void GiveBackSlice(int index, SliceFrameWatch watch) {} // 0x00000001868A6370-0x00000001868A65C0
		// [XID] // 0x0000000189980A20-0x0000000189980A40
		public static long GetSliceLeftTick(int index) => default; // 0x00000001868A61D0-0x00000001868A6370
		// [XID] // 0x0000000189988310-0x0000000189988330
		public static void SetSliceLeftTick(int index, long inTick) {} // 0x00000001868A7590-0x00000001868A7740
		// [XID] // 0x000000018998FDA0-0x000000018998FDC0
		public static void ReduceSliceLeftTick(int index, long inTick) {} // 0x00000001868A6BA0-0x00000001868A6D50
		// [XID] // 0x0000000189997690-0x00000001899976B0
		public static int RegisterSliceBlock(float inMs, string name) => default; // 0x00000001868A6D50-0x00000001868A7070
		// [XID] // 0x000000018999F210-0x000000018999F230
		public static IEnumerable<SliceFrameBlock> GetOptimizeContext() => default; // 0x00000001868A5AB0-0x00000001868A5B80
		// [XID] // 0x00000001897D02A0-0x00000001897D02C0
		public static void UnRegisterSliceBlock(int index) {} // 0x00000001868A7740-0x00000001868A7930
		// [XID] // 0x0000000189B05750-0x0000000189B05770
		public static long GetSFWatchThisFrameTickThreshold(int watchHandle) => default; // 0x00000001868A5B80-0x00000001868A5D20
		// [XID] // 0x00000001897CB580-0x00000001897CB5A0
		public static SliceFrameWatch GetSharedGameSystemWatch(int index) => default; // 0x00000001868A5D20-0x00000001868A6120
		// [XID] // 0x00000001899BD3C0-0x00000001899BD3E0
		public static void DisableSliceFrameGameSystemWatch() {} // 0x00000001868A5780-0x00000001868A5840
		// [XID] // 0x00000001899C4D90-0x00000001899C4DB0
		public void ResetSliceFrameGameSystemWatch() {} // 0x00000001868A7070-0x00000001868A7590
		// [XID] // 0x00000001896A3CB0-0x00000001896A3CD0
		public static SliceFrameWatch GetSharedSliceFrameGameSystemWatch() => default; // 0x00000001868A6120-0x00000001868A61D0
		// [XID] // 0x0000000189B32E90-0x0000000189B32EB0
		public static IWRRHandle AddWeightedRoundRobinHandle(int inWeight) => default; // 0x00000001868A55B0-0x00000001868A56C0
		// [XID] // 0x0000000189B58C80-0x0000000189B58CA0
		public static void ClearAllWRRHandles() {} // 0x00000001868A56C0-0x00000001868A5780
		// [XID] // 0x00000001899E27E0-0x00000001899E2800
		public static SliceFrameWatch GetLessTickSharedGameSystemWatch(out SliceFrameWatch globalSystemWatch, SliceFrameWatch selfWatch) {
			globalSystemWatch = default;
			return default;
		} // 0x00000001868A5990-0x00000001868A5AB0
		// [XID] // 0x0000000189849540-0x0000000189849560
		public SliceFrameWatch GetFrameWatch(string name) => default; // 0x00000001868A5840-0x00000001868A5990
	}
}
