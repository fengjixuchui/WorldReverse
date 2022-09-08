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
	public abstract class OdeSolver // TypeDefIndex: 8136
	{
		// Fields
		protected int _dim; // 0x10
		protected float _step; // 0x14
		protected OdeFunction _function; // 0x18
		protected float[] _FValue; // 0x20
	
		// Properties
		public virtual float Step { /* [XID] */ /* 0x0000000189781510-0x0000000189781530 */ get; /* [XID] */ /* 0x00000001897889E0-0x0000000189788A00 */ set; } // 0x0000000188D30440-0x0000000188D304F0 0x0000000188D304F0-0x0000000188D30730
	
		// Constructors
		protected OdeSolver() {} // Dummy constructor
		public OdeSolver(int dim, float step, OdeFunction function) {} // 0x0000000188D30390-0x0000000188D30440
	
		// Methods
		public abstract void Update(float tIn, float[] yIn, ref float tOut, float[] yOut);
	}
}
