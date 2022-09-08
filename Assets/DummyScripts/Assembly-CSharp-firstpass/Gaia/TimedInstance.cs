/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public class TimedInstance : Stopwatch // TypeDefIndex: 9341
	{
		// Fields
		public long nanosecPerTick; // 0x28
		public string m_name; // 0x30
		public int m_iterations; // 0x38
	
		// Constructors
		public TimedInstance() {} // Dummy constructor
		public TimedInstance(string name, bool start = true /* Metadata: 0x00AE5767 */) {} // 0x0000000185A411C0-0x0000000185A412A0
	
		// Methods
		// [XID] // 0x00000001896E8FB0-0x00000001896E8FD0
		public new void Start() {} // 0x0000000185A40F40-0x0000000185A40FF0
		// [XID] // 0x0000000189AD05E0-0x0000000189AD0600
		public new void Reset() {} // 0x0000000185A40E90-0x0000000185A40F40
		// [XID] // 0x0000000189AD83E0-0x0000000189AD8400
		public void IncIterations() {} // 0x0000000185A40DF0-0x0000000185A40E90
		// [XID] // 0x0000000189AE0020-0x0000000189AE0040
		public float GetAvgMs() => default; // 0x0000000185A40C50-0x0000000185A40D20
		// [XID] // 0x0000000189B414F0-0x0000000189B41510
		public float GetAvgS() => default; // 0x0000000185A40D20-0x0000000185A40DF0
		// [XID] // 0x0000000189AEF390-0x0000000189AEF3B0
		public override string ToString() => default; // 0x0000000185A40FF0-0x0000000185A41150
	}
}
