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
	public class OdeRungeKutta4 : OdeSolver // TypeDefIndex: 8139
	{
		// Fields
		private float _halfStep; // 0x28
		private float _sixthStep; // 0x2C
		private float[] _temp1; // 0x30
		private float[] _temp2; // 0x38
		private float[] _temp3; // 0x40
		private float[] _temp4; // 0x48
		private float[] _yTemp; // 0x50
	
		// Properties
		public override float Step { /* [XID] */ /* 0x00000001897AE570-0x00000001897AE590 */ get => default; /* [XID] */ /* 0x00000001896C57F0-0x00000001896C5810 */ set {} } // 0x0000000188D30210-0x0000000188D302C0 0x0000000188D302C0-0x0000000188D30390
	
		// Constructors
		public OdeRungeKutta4() {} // Dummy constructor
		public OdeRungeKutta4(int dim, float step, OdeFunction function) {} // 0x0000000188D300B0-0x0000000188D30210
	
		// Methods
		// [XID] // 0x00000001896D4020-0x00000001896D4040
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut) {} // 0x0000000188D2FBF0-0x0000000188D300B0
	}
}
