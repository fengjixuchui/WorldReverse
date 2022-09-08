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
	public class PoissonDiskSampler // TypeDefIndex: 8181
	{
		// Fields
		private static readonly float one_div_sqrtTwo; // 0x00
		private Rand _rand; // 0x10
		private List<int> _activeList; // 0x18
		private List<Vector2> _points; // 0x20
		private int?[,] _grid; // 0x28
		private float _r; // 0x30
		private float _rSquared; // 0x34
		private float _rTwo; // 0x38
		private float _rMin; // 0x3C
		private Vector2 _min; // 0x40
		private Vector2 _max; // 0x48
		private Vector2 _size; // 0x50
		private float _cellSize; // 0x58
		private int _cellsX; // 0x5C
		private int _cellsY; // 0x60
		public PointDelegate DistanceFilter; // 0x68
		public int PointsPerStep; // 0x70
	
		// Properties
		public int MaxPoints { /* [XID] */ /* 0x0000000189A49190-0x0000000189A491D0 */ get; set; } // 0x0000000188D34E90-0x0000000188D34EF0 0x0000000188D34EF0-0x0000000188D34F50
	
		// Nested types
		public delegate float PointDelegate(ref Vector2 point); // TypeDefIndex: 8182; 0x0000000188D33D50-0x0000000188D33EF0
	
		// Constructors
		public PoissonDiskSampler() {} // Dummy constructor
		static PoissonDiskSampler() {} // 0x0000000188D34B50-0x0000000188D34BF0
		public PoissonDiskSampler(Rand rand, Vector2 minCorner, Vector2 maxCorner, float minDistanceOuter, float minDistanceInner = 1f /* Metadata: 0x00ADF6BC */) {} // 0x0000000188D34BF0-0x0000000188D34E90
	
		// Methods
		// [XID] // 0x0000000189A5B0C0-0x0000000189A5B0E0
		private void CalcGridIndices(ref Vector2 point, out int i, out int j) {
			i = default;
			j = default;
		} // 0x0000000188D345E0-0x0000000188D346E0
		// [XID] // 0x0000000189A62920-0x0000000189A62940
		private void InsertIntoGrid(ref Vector2 point, int index) {} // 0x0000000188D346E0-0x0000000188D34840
		// [XID] // 0x0000000189A6A6A0-0x0000000189A6A6C0
		private bool AddPoint(ref Vector2 center) => default; // 0x0000000188D340D0-0x0000000188D345E0
		// [XID] // 0x0000000189915710-0x0000000189915730
		public List<Vector2> Sample() => default; // 0x0000000188D34840-0x0000000188D34B50
	}
}
