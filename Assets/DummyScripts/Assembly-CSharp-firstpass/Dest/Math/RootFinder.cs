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
	public static class RootFinder // TypeDefIndex: 8129
	{
		// Fields
		private const float third = 0.33333334f; // Metadata: 0x00ADF5DC
		private const float twentySeventh = 0.037037037f; // Metadata: 0x00ADF5E0
		private static float sqrt3; // 0x00
	
		// Nested types
		private class PolyRootFinder // TypeDefIndex: 8130
		{
			// Fields
			private int _count; // 0x10
			private int _maxRoot; // 0x14
			private float[] _roots; // 0x18
			private float _epsilon; // 0x20
	
			// Properties
			public float[] Roots { /* [XID] */ /* 0x000000018963F030-0x000000018963F050 */ get => default; } // 0x00000001874A4560-0x00000001874A4600 
	
			// Constructors
			public PolyRootFinder() {} // Dummy constructor
			public PolyRootFinder(float epsilon) {} // 0x00000001874A44B0-0x00000001874A4560
	
			// Methods
			// [XID] // 0x0000000189637DE0-0x0000000189637E00
			public bool Bisection(Polynomial poly, float xMin, float xMax, int digits, out float root) {
				root = default;
				return default;
			} // 0x00000001874A3B70-0x00000001874A3E60
			// [XID] // 0x000000018973FA20-0x000000018973FA40
			public bool Find(Polynomial poly, float xMin, float xMax, int digits) => default; // 0x00000001874A3E60-0x00000001874A44B0
		}
	
		// Constructors
		static RootFinder() {} // 0x00000001874AD310-0x00000001874AD500
	
		// Methods
		// [XID] // 0x000000018965D3C0-0x000000018965D3E0
		public static bool BrentsMethod(Func<float, float> function, float x0, float x1, out BrentsRoot root, int maxIterations = 128 /* Metadata: 0x00ADF5A4 */, float negativeTolerance = -1E-05f /* Metadata: 0x00ADF5A8 */, float positiveTolerance = 1E-05f /* Metadata: 0x00ADF5AC */, float stepTolerance = 1E-05f /* Metadata: 0x00ADF5B0 */, float segmentTolerance = 1E-05f /* Metadata: 0x00ADF5B4 */) {
			root = default;
			return default;
		} // 0x00000001874AB670-0x00000001874ABC60
		// [XID] // 0x00000001896649D0-0x00000001896649F0
		public static bool Linear(float c0, float c1, out float root, float epsilon = 1E-05f /* Metadata: 0x00ADF5B8 */) {
			root = default;
			return default;
		} // 0x00000001874AC280-0x00000001874AC3B0
		// [XID] // 0x00000001897CE680-0x00000001897CE6A0
		public static bool Quadratic(float c0, float c1, float c2, out QuadraticRoots roots, float epsilon = 1E-05f /* Metadata: 0x00ADF5BC */) {
			roots = default;
			return default;
		} // 0x00000001874AC8E0-0x00000001874ACBE0
		// [XID] // 0x0000000189673E40-0x0000000189673E60
		public static bool Cubic(float c0, float c1, float c2, float c3, out CubicRoots roots, float epsilon = 1E-05f /* Metadata: 0x00ADF5C0 */) {
			roots = default;
			return default;
		} // 0x00000001874ABC60-0x00000001874AC280
		// [XID] // 0x000000018967B5E0-0x000000018967B600
		public static bool Quartic(float c0, float c1, float c2, float c3, float c4, out QuarticRoots roots, float epsilon = 1E-05f /* Metadata: 0x00ADF5C4 */) {
			roots = default;
			return default;
		} // 0x00000001874ACBE0-0x00000001874AD310
		// [XID] // 0x0000000189682D90-0x0000000189682DB0
		public static float PolynomialBound(Polynomial poly, float epsilon = 1E-05f /* Metadata: 0x00ADF5C8 */) => default; // 0x00000001874AC3B0-0x00000001874AC580
		// [IDTag] // 0x000000018968A920-0x000000018968A960
		// [XID] // 0x000000018968A920-0x000000018968A960
		public static bool Polynomial(Polynomial poly, float xMin, float xMax, out float[] roots, int digits = 6 /* Metadata: 0x00ADF5CC */, float epsilon = 1E-05f /* Metadata: 0x00ADF5D0 */) {
			roots = default;
			return default;
		} // 0x00000001874AC580-0x00000001874AC730
		// [IDTag] // 0x0000000189695310-0x0000000189695350
		// [XID] // 0x0000000189695310-0x0000000189695350
		public static bool Polynomial(Polynomial poly, out float[] roots, int digits = 6 /* Metadata: 0x00ADF5D4 */, float epsilon = 1E-05f /* Metadata: 0x00ADF5D8 */) {
			roots = default;
			return default;
		} // 0x00000001874AC730-0x00000001874AC8E0
	}
}
