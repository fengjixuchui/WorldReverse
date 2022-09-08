/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class LockFreeNode // TypeDefIndex: 10574
	{
		// Fields
		[ThreadStatic] // 0x0000000189823E60-0x0000000189823E70
		private static LockFreeNodeQueue _queue; // 0xFFFFFFFF
		public LockFreeNode Next; // 0x10
		public object Item; // 0x18
	
		// Nested types
		private class LockFreeNodeQueue // TypeDefIndex: 10575
		{
			// Fields
			private LockFreeNode _head; // 0x10
			private int _count; // 0x18
	
			// Constructors
			public LockFreeNodeQueue() {} // 0x0000000189BFB2A0-0x0000000189BFB310
	
			// Methods
			// [XID] // 0x00000001898502C0-0x00000001898502E0
			public LockFreeNode Get() => default; // 0x0000000189BFB060-0x0000000189BFB1C0
			// [XID] // 0x0000000189857560-0x0000000189857580
			public void Release(LockFreeNode node) {} // 0x0000000189BFB1C0-0x0000000189BFB2A0
		}
	
		// Constructors
		public LockFreeNode() {} // 0x0000000189BFB730-0x0000000189BFB790
	
		// Methods
		// [XID] // 0x0000000189832A20-0x0000000189832A40
		public override string ToString() => default; // 0x0000000189BFB600-0x0000000189BFB6C0
		// [XID] // 0x0000000189850200-0x0000000189850220
		public static bool CAS(ref LockFreeNode location, LockFreeNode newValue, LockFreeNode comparand) => default; // 0x0000000189BFB310-0x0000000189BFB3F0
		// [XID] // 0x0000000189857440-0x0000000189857460
		public static LockFreeNode Get() => default; // 0x0000000189BFB3F0-0x0000000189BFB4F0
		// [XID] // 0x000000018986D570-0x000000018986D590
		public static void Release(LockFreeNode node) {} // 0x0000000189BFB4F0-0x0000000189BFB600
	}
}
