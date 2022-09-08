/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public static class JobProxy // TypeDefIndex: 9005
	{
		// Fields
		public const int SCHEDULE_BITS = 3; // Metadata: 0x00AE5035
		public const int SCHEDULE_TYPE_BITS = 4; // Metadata: 0x00AE5039
		public const int NODE_ID_BITS = 9; // Metadata: 0x00AE503D
		public const int SCHEDULE_SHIFT = 13; // Metadata: 0x00AE5041
		public const int SCHEDULE_TYPE_SHIFT = 9; // Metadata: 0x00AE5045
		public const int NODE_ID_SHIFT = 0; // Metadata: 0x00AE5049
		public const int SCHEDULE_MASK = 57344; // Metadata: 0x00AE504D
		public const int SCHEDULE_TYPE_MASK = 7680; // Metadata: 0x00AE5051
		public const int NODE_ID_MASK = 511; // Metadata: 0x00AE5055
		public const int SCHEDULER_GLOBAL = 0; // Metadata: 0x00AE5059
		public const int SCHEDULER_INLEVEL = 1; // Metadata: 0x00AE505D
		public const int SCHEDULER_BACKGROUND = 2; // Metadata: 0x00AE5061
		public const int SCHEDULER_COUNT = 3; // Metadata: 0x00AE5065
		private const int MAX_INLEVEL_STABLE = 64; // Metadata: 0x00AE5069
		private const int MAX_INLEVEL_DYNAMIC = 256; // Metadata: 0x00AE506D
		private static int[] _globalNextNodeIds; // 0x00
		private static int[] _inlevelNextNodeIds; // 0x08
		private static int[] _backgroundNextNodeIds; // 0x10
		public static bool USE_INVOKE; // 0x18
		private const int DEFAULT_CAPCITY = 31; // Metadata: 0x00AE5071
		private static Dictionary<int, INode>[][] _nodeDic; // 0x20
		private static List<int> _nodesToBeRemove; // 0x28
		private static bool _inited; // 0x30
		public static bool groupBalenceToken; // 0x31
		private static JobExecuteDelegate _executeJobDelegate; // 0x38
		public static IntPtr executeJobPtr; // 0x40
		public static Physics.DelegateCallback executeJobInvoke; // 0x48
		private const int EXECUTE_POOL_SIZE = 31; // Metadata: 0x00AE5075
		private static IntPtr[][] _executeJobPtrPool; // 0x50
		private static Queue<int[]>[] _executeJobIdPool; // 0x58
		private static Queue<string[]>[] _executeJobProfileNamePool; // 0x60
		private static Physics.DelegateCallback[][] _executeJobInvokePool; // 0x68
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void JobExecuteDelegate(int nodeId); // TypeDefIndex: 9006; 0x0000000187623680-0x0000000187623810
	
		// Constructors
		static JobProxy() {} // 0x00000001876305E0-0x0000000187630850
	
		// Methods
		// [XID] // 0x0000000189976410-0x0000000189976430
		public static int GetNextNodeID(int schedule, int scheduleType) => default; // 0x000000018762F5B0-0x000000018762F690
		// [XID] // 0x00000001897BE0E0-0x00000001897BE100
		private static int GetRawNextNodeID(int schedule, int scheduleType) => default; // 0x000000018762F690-0x000000018762F840
		// [XID] // 0x00000001899852D0-0x00000001899852F0
		public static int ParseSchedule(int nodeId) => default; // 0x0000000187630000-0x00000001876300A0
		// [XID] // 0x0000000189995450-0x0000000189995470
		public static int ParseScheduleType(int nodeId) => default; // 0x000000018762FF60-0x0000000187630000
		// [XID] // 0x00000001899D1760-0x00000001899D1780
		public static int ParseNodeId(int nodeId) => default; // 0x000000018762FEC0-0x000000018762FF60
		// [XID] // 0x00000001896976C0-0x00000001896976E0
		public static INode Get(int nodeId) => default; // 0x000000018762F840-0x000000018762F960
		// [XID] // 0x00000001899A3C80-0x00000001899A3CA0
		public static void Add(INode node) {} // 0x000000018762DB90-0x000000018762DCD0
		// [XID] // 0x00000001899AB890-0x00000001899AB8B0
		public static void Remove(INode node) {} // 0x00000001876304B0-0x00000001876305E0
		// [XID] // 0x00000001899B3130-0x00000001899B3150
		private static void RemoveNodeInternal(int nodeId) {} // 0x00000001876303A0-0x00000001876304B0
		// [XID] // 0x00000001899BA420-0x00000001899BA440
		public static void FrameReset() {} // 0x000000018762E4F0-0x000000018762E5B0
		// [XID] // 0x00000001899C1E70-0x00000001899C1E90
		public static void FlushRemoveNode() {} // 0x000000018762E360-0x000000018762E4F0
		// [XID] // 0x000000018963D010-0x000000018963D030
		private static Dictionary<int, INode> GetInnerNodeDic(int nodeId) => default; // 0x000000018762F470-0x000000018762F5B0
		// [XID] // 0x00000001899D0E10-0x00000001899D0E30
		public static void Init() {} // 0x000000018762FAD0-0x000000018762FEC0
		// [XID] // 0x00000001899D8250-0x00000001899D8270
		private static Dictionary<int, INode>[] InitJobDic(int count) => default; // 0x000000018762F960-0x000000018762FAD0
		// [XID] // 0x00000001899DF8C0-0x00000001899DF8E0
		public static void ClearInLevel() {} // 0x000000018762DCD0-0x000000018762DF10
		// [XID] // 0x00000001899E73D0-0x00000001899E73F0
		public static void Clear() {} // 0x000000018762DF10-0x000000018762E160
		// [MonoPInvokeCallback] // 0x00000001899EE860-0x00000001899EE8C0
		// [XID] // 0x00000001899EE860-0x00000001899EE8C0
		public static void ExecuteJob(int nodeId) {} // 0x000000018762E260-0x000000018762E360
		// [MonoPInvokeCallback] // 0x00000001899FD710-0x00000001899FD770
		// [XID] // 0x00000001899FD710-0x00000001899FD770
		public static void ExecuteInvokeJob(int nodeId) {} // 0x000000018762E160-0x000000018762E260
		// [XID] // 0x0000000189A0C4B0-0x0000000189A0C4D0
		public static void GetExecuteArray(List<INode> nodes, out IntPtr[] intPtrs, out int[] nodeIds, out string[] profileNames) {
			intPtrs = default;
			nodeIds = default;
			profileNames = default;
		} // 0x000000018762E5B0-0x000000018762ED10
		// [XID] // 0x0000000189869210-0x0000000189869230
		public static void GetExecuteInvokeArray(List<INode> nodes, out Physics.DelegateCallback[] invokes, out int[] nodeIds, out string[] profileNames) {
			invokes = default;
			nodeIds = default;
			profileNames = default;
		} // 0x000000018762ED10-0x000000018762F470
		// [XID] // 0x0000000189A1B080-0x0000000189A1B0A0
		public static void ReleaseExecuteArray(int[] nodeIds, string[] profileNames) {} // 0x00000001876300A0-0x00000001876303A0
	}
}
