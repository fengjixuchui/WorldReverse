/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Dest.Math
{
	public static class PointsFilter // TypeDefIndex: 8179
	{
		// Nested types
		private class Data // TypeDefIndex: 8180
		{
			// Fields
			private Vector3[] _points; // 0x10
			private List<int>[,,] _grid; // 0x18
			private Vector3 _min; // 0x20
			private Vector3 _max; // 0x2C
			private int _cellsX; // 0x38
			private int _cellsY; // 0x3C
			private int _cellsZ; // 0x40
			private float _cellSize; // 0x44
			private float _radius; // 0x48
			private Rand _rand; // 0x50
	
			// Constructors
			public Data() {} // Dummy constructor
			public Data(Vector3[] points, float radius, Rand rand, AAB3 aab) {} // 0x0000000188D1EA80-0x0000000188D1EE10
	
			// Methods
			// [IDTag] // 0x0000000189A1B100-0x0000000189A1B140
			// [XID] // 0x0000000189A1B100-0x0000000189A1B140
			private static int BinarySearch(List<int> array, int value) => default; // 0x0000000188D1DE00-0x0000000188D1DF40
			// [IDTag] // 0x0000000189A25590-0x0000000189A255D0
			// [XID] // 0x0000000189A25590-0x0000000189A255D0
			private static int BinarySearch(int[] array, int length, int value) => default; // 0x0000000188D1DCD0-0x0000000188D1DE00
			// [XID] // 0x00000001896D9300-0x00000001896D9320
			private void CalcGridIndices(ref Vector3 point, out int i, out int j, out int k) {
				i = default;
				j = default;
				k = default;
			} // 0x0000000188D1DF40-0x0000000188D1E070
			// [XID] // 0x0000000189653140-0x0000000189653160
			public List<int> Filter() => default; // 0x0000000188D1E070-0x0000000188D1EA80
		}
	
		// Methods
		// [XID] // 0x0000000189A13EF0-0x0000000189A13F10
		public static List<int> DistanceFilter(Vector3[] points, AAB3 pointsAAB, float radius, Rand rand) => default; // 0x0000000188D33F70-0x0000000188D340D0
	}
}
