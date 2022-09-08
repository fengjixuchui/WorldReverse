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
	public class FlexibleSlice // TypeDefIndex: 10624
	{
		// Fields
		protected static float TARGET_MAX_PROCESS_TIME; // 0x00
		protected static float MAX_TICK_TIME_LIMIT; // 0x04
		private static float _lastTime; // 0x08
		private float _timeLimitTickBase; // 0x10
		private float _timeLimitTickPeak; // 0x14
		private float _timeLimitTicks; // 0x18
		private static bool LowFrame; // 0x0C
	
		// Constructors
		public FlexibleSlice() {} // 0x0000000189BE44F0-0x0000000189BE4550
		static FlexibleSlice() {} // 0x0000000189BE4480-0x0000000189BE44F0
	
		// Methods
		// [XID] // 0x0000000189A9D380-0x0000000189A9D3A0
		public static void RefreshDeltaTime() {} // 0x0000000189BE4190-0x0000000189BE4280
		// [XID] // 0x0000000189A30EA0-0x0000000189A30EC0
		public void Init(float minTickTimeLimit, float maxTickTimeLimit) {} // 0x0000000189BE4010-0x0000000189BE4190
		// [XID] // 0x0000000189A38AD0-0x0000000189A38AF0
		public void Reset(float minTickTimeLimit, float maxTickTimeLimit) {} // 0x0000000189BE4280-0x0000000189BE4480
		// [XID] // 0x0000000189AB3A70-0x0000000189AB3A90
		public float GetTickTime() => default; // 0x0000000189BE3EC0-0x0000000189BE4010
	}
}
