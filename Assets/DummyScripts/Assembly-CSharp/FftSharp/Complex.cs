/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace FftSharp
{
	public struct Complex // TypeDefIndex: 32208
	{
		// Fields
		public double Real; // 0x00
		public double Imaginary; // 0x08
	
		// Properties
		public double MagnitudeSquared { get => default; } // 0x0000000182149460-0x0000000182149530 
		public double Magnitude { get => default; } // 0x0000000182149530-0x0000000182149540 
	
		// Constructors
		public Complex(double real, double imaginary) : this() {
			Real = default;
			Imaginary = default;
		} // 0x0000000182149360-0x0000000182149460
	
		// Methods
		public override string ToString() => default; // 0x00000001821492D0-0x0000000182149360
		public static Complex operator +(Complex a, Complex b) => default; // 0x0000000182149540-0x0000000182149650
		public static Complex operator -(Complex a, Complex b) => default; // 0x0000000182149870-0x0000000182149980
		public static Complex operator *(Complex a, Complex b) => default; // 0x0000000182149650-0x0000000182149780
		public static Complex operator *(Complex a, double b) => default; // 0x0000000182149780-0x0000000182149870
		public static Complex[] FromReal(double[] real) => default; // 0x0000000182148F90-0x0000000182149090
		public static double[] GetMagnitudes(Complex[] input) => default; // 0x0000000182149090-0x00000001821492D0
	}
}
