/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class UnifiedTriangleClipper // TypeDefIndex: 14724
{
	// Fields
	private const int TOP = 1; // Metadata: 0x00AEBE62
	private const int BOTTOM = 2; // Metadata: 0x00AEBE66
	private const int LEFT = 4; // Metadata: 0x00AEBE6A
	private const int RIGHT = 8; // Metadata: 0x00AEBE6E
	private const int NEAR = 16; // Metadata: 0x00AEBE72
	private const int REAR = 32; // Metadata: 0x00AEBE76
	private static readonly SideClipper _leftClipper; // 0x00
	private static readonly SideClipper _rightClipper; // 0x08
	private static readonly SideClipper _topClipper; // 0x10
	private static readonly SideClipper _bottomClipper; // 0x18
	private static readonly SideClipper _nearClipper; // 0x20
	private static readonly SideClipper _rearClipper; // 0x28
	private static List<Vector3> _clipFeed; // 0x30
	private static List<Vector3> _clipTemp; // 0x38

	// Nested types
	private class SideClipper // TypeDefIndex: 14725
	{
		// Fields
		private Boundary boundary; // 0x10
		private VectorComponentPicker picker; // 0x18

		// Constructors
		public SideClipper() {} // Dummy constructor
		public SideClipper(Boundary boundary, VectorComponentPicker picker) {} // 0x0000000184AB76A0-0x0000000184AB7730

		// Methods
		// [XID] // 0x0000000189751190-0x00000001897511B0
		public bool CountIn(Vector3 v) => default; // 0x0000000184AB70F0-0x0000000184AB7220
		// [XID] // 0x0000000189758630-0x0000000189758650
		public bool BearlyOnBound(Vector3 v) => default; // 0x0000000184AB73F0-0x0000000184AB7570
		// [XID] // 0x00000001897602B0-0x00000001897602D0
		public int First(List<Vector3> vertices) => default; // 0x0000000184AB7570-0x0000000184AB76A0
		// [XID] // 0x00000001897675E0-0x0000000189767600
		public float Delta(Vector3 a, Vector3 b) => default; // 0x0000000184AB7220-0x0000000184AB73F0
	}

	private abstract class VectorComponentPicker // TypeDefIndex: 14726
	{
		// Constructors
		protected VectorComponentPicker() {} // 0x0000000184AD8FA0-0x0000000184AD9000

		// Methods
		public abstract float Pick(Vector3 p);
	}

	private class XPick : VectorComponentPicker // TypeDefIndex: 14727
	{
		// Constructors
		public XPick() {} // 0x0000000184AB6C30-0x0000000184AB6CD0

		// Methods
		// [XID] // 0x000000018976ECF0-0x000000018976ED10
		public override float Pick(Vector3 p) => default; // 0x0000000184AB6B60-0x0000000184AB6C30
	}

	private class YPick : VectorComponentPicker // TypeDefIndex: 14728
	{
		// Constructors
		public YPick() {} // 0x0000000184AB6AC0-0x0000000184AB6B60

		// Methods
		// [XID] // 0x00000001897768E0-0x0000000189776900
		public override float Pick(Vector3 p) => default; // 0x0000000184AB69F0-0x0000000184AB6AC0
	}

	private class ZPick : VectorComponentPicker // TypeDefIndex: 14729
	{
		// Constructors
		public ZPick() {} // 0x0000000184AB6950-0x0000000184AB69F0

		// Methods
		// [XID] // 0x000000018977DD30-0x000000018977DD50
		public override float Pick(Vector3 p) => default; // 0x0000000184AB6880-0x0000000184AB6950
	}

	private abstract class Boundary // TypeDefIndex: 14730
	{
		// Properties
		public abstract float Value { get; }

		// Constructors
		protected Boundary() {} // 0x0000000184AD8F40-0x0000000184AD8FA0

		// Methods
		public abstract bool IsWithin(float value);
	}

	private class PositiveBoundary : Boundary // TypeDefIndex: 14731
	{
		// Properties
		public override float Value { /* [XID] */ /* 0x0000000189785680-0x00000001897856A0 */ get => default; } // 0x0000000184AB6EE0-0x0000000184AB6F90 

		// Constructors
		public PositiveBoundary() {} // 0x0000000184AB7050-0x0000000184AB70F0

		// Methods
		// [XID] // 0x000000018978CB20-0x000000018978CB40
		public override bool IsWithin(float value) => default; // 0x0000000184AB6F90-0x0000000184AB7050
	}

	private class NegativeBoundary : Boundary // TypeDefIndex: 14732
	{
		// Properties
		public override float Value { /* [XID] */ /* 0x0000000189793FE0-0x0000000189794000 */ get => default; } // 0x0000000184AB6CD0-0x0000000184AB6D80 

		// Constructors
		public NegativeBoundary() {} // 0x0000000184AB6E40-0x0000000184AB6EE0

		// Methods
		// [XID] // 0x000000018979C3F0-0x000000018979C410
		public override bool IsWithin(float value) => default; // 0x0000000184AB6D80-0x0000000184AB6E40
	}

	// Constructors
	static UnifiedTriangleClipper() {} // 0x0000000184ABCAF0-0x0000000184ABCD70

	// Methods
	// [XID] // 0x000000018973AAB0-0x000000018973AAD0
	public static void Clip(List<Vector3> clipped, Vector3 v1, Vector3 v2, Vector3 v3) {} // 0x0000000184ABBE50-0x0000000184ABC580
	// [XID] // 0x0000000189742200-0x0000000189742220
	private static int CohenSutherlandCode(float x, float y, float z) => default; // 0x0000000184ABBD30-0x0000000184ABBE50
	// [XID] // 0x0000000189749E10-0x0000000189749E30
	private static void ClipAgainstSide(ref List<Vector3> vertices, SideClipper clipper, ref List<Vector3> results) {} // 0x0000000184ABC580-0x0000000184ABCAF0
}

