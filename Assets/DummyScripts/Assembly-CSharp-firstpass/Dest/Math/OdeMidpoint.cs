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
	public class OdeMidpoint : OdeSolver // TypeDefIndex: 8138
	{
		// Fields
		private float _halfStep; // 0x28
		private float[] _yTemp; // 0x30
	
		// Properties
		public override float Step { /* [XID] */ /* 0x0000000189949490-0x00000001899494B0 */ get => default; /* [XID] */ /* 0x00000001896B6CC0-0x00000001896B6CE0 */ set {} } // 0x0000000188D2F990-0x0000000188D2FA40 0x0000000188D2FA40-0x0000000188D2FB00
	
		// Constructors
		public OdeMidpoint() {} // Dummy constructor
		public OdeMidpoint(int dim, float step, OdeFunction function) {} // 0x0000000188D2F8C0-0x0000000188D2F990
	
		// Methods
		// [XID] // 0x00000001899419B0-0x00000001899419D0
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut) {} // 0x0000000188D2F630-0x0000000188D2F8C0
	}
}
