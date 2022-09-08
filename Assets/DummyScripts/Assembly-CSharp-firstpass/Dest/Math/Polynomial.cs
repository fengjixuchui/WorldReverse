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
	public class Polynomial // TypeDefIndex: 8042
	{
		// Fields
		private int _degree; // 0x10
		private float[] _coeffs; // 0x18
	
		// Properties
		public int Degree { /* [XID] */ /* 0x0000000189AF0AD0-0x0000000189AF0AF0 */ get => default; /* [XID] */ /* 0x0000000189AF80D0-0x0000000189AF80F0 */ set {} } // 0x0000000188D3B450-0x0000000188D3B4F0 0x0000000188D3B5D0-0x0000000188D3B6A0
		public float this[int index] { /* [XID] */ /* 0x0000000189AFF710-0x0000000189AFF730 */ get => default; /* [XID] */ /* 0x0000000189B06DB0-0x0000000189B06DD0 */ set {} } // 0x0000000188D3B4F0-0x0000000188D3B5D0 0x0000000188D3B6A0-0x0000000188D3B870
	
		// Constructors
		public Polynomial() {} // Dummy constructor
		public Polynomial(int degree) {} // 0x0000000188D3B3D0-0x0000000188D3B450
	
		// Methods
		// [XID] // 0x0000000189B0E630-0x0000000189B0E650
		public Polynomial DeepCopy() => default; // 0x0000000188D3B150-0x0000000188D3B2A0
		// [XID] // 0x00000001895F8E20-0x00000001895F8E40
		public Polynomial CalcDerivative() => default; // 0x0000000188D3AC30-0x0000000188D3ADE0
		// [XID] // 0x0000000189B1D1C0-0x0000000189B1D1E0
		public Polynomial CalcInversion() => default; // 0x0000000188D3ADE0-0x0000000188D3AF30
		// [XID] // 0x000000018980A660-0x000000018980A680
		public void Compress(float epsilon = 1E-05f /* Metadata: 0x00ADF497 */) {} // 0x0000000188D3AF30-0x0000000188D3B150
		// [XID] // 0x0000000189BA1300-0x0000000189BA1320
		public float Eval(float t) => default; // 0x0000000188D3B2A0-0x0000000188D3B3D0
	}
}
