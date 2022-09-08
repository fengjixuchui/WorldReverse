/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Dest.Math
{
	public static class Integrator // TypeDefIndex: 8133
	{
		// Fields
		private const int _degree = 5; // Metadata: 0x00ADF5E4
		private static float[] root; // 0x00
		private static float[] coeff; // 0x08
	
		// Constructors
		static Integrator() {} // 0x00000001872CCBD0-0x00000001872CCCB0
	
		// Methods
		// [XID] // 0x0000000189655970-0x0000000189655990
		public static float TrapezoidRule(Func<float, float> function, float a, float b, int sampleCount) => default; // 0x00000001872CCA10-0x00000001872CCBD0
		// [XID] // 0x000000018972A820-0x000000018972A840
		public static float RombergIntegral(Func<float, float> function, float a, float b, int order) => default; // 0x00000001872CC690-0x00000001872CCA10
		// [XID] // 0x0000000189731F20-0x0000000189731F40
		public static float GaussianQuadrature(Func<float, float> function, float a, float b) => default; // 0x00000001872CC4B0-0x00000001872CC690
	}
}
