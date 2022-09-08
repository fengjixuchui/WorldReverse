/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_ShapeGenerator // TypeDefIndex: 3424
	{
		// Fields
		private static readonly Vector3[] ICOSAHEDRON_VERTICES; // 0x00
		private static readonly int[] ICOSAHEDRON_TRIANGLES; // 0x08
	
		// Constructors
		public pb_ShapeGenerator() {} // 0x0000000186BC7D40-0x0000000186BC7DA0
		static pb_ShapeGenerator() {} // 0x0000000186BC7870-0x0000000186BC7D40
	
		// Methods
		public static pb_Object StairGenerator(Vector3 size, int steps, bool buildSides) => default; // 0x0000000186BC57B0-0x0000000186BC6A90
		public static pb_Object CurvedStairGenerator(float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides) => default; // 0x0000000186BBE580-0x0000000186BBFFE0
		public static pb_Object StairGenerator(int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly) => default; // 0x0000000186BC4E80-0x0000000186BC57B0
		public static pb_Object CubeGenerator(Vector3 size) => default; // 0x0000000186BBE2B0-0x0000000186BBE580
		public static pb_Object CylinderGenerator(int axisDivisions, float radius, float height, int heightCuts, int smoothing = -1 /* Metadata: 0x00AC3D04 */) => default; // 0x0000000186BBFFE0-0x0000000186BC0ED0
		public static pb_Object PrismGenerator(Vector3 size) => default; // 0x0000000186BC4270-0x0000000186BC4E80
		public static pb_Object DoorGenerator(float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth) => default; // 0x0000000186BC0ED0-0x0000000186BC2240
		public static pb_Object PlaneGenerator(float _width, float _height, int widthCuts, int heightCuts, Axis axis, bool smooth) => default; // 0x0000000186BC3650-0x0000000186BC4270
		public static pb_Object PipeGenerator(float radius, float height, float thickness, int subdivAxis, int subdivHeight) => default; // 0x0000000186BC2A50-0x0000000186BC3650
		public static pb_Object ConeGenerator(float radius, float height, int subdivAxis) => default; // 0x0000000186BBDC20-0x0000000186BBE2B0
		public static pb_Object ArchGenerator(float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps) => default; // 0x0000000186BBC500-0x0000000186BBD530
		public static pb_Object IcosahedronGenerator(float radius, int subdivisions) => default; // 0x0000000186BC2240-0x0000000186BC2A50
		private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) => default; // 0x0000000186BC6A90-0x0000000186BC7170
		private static Vector3[] CircleVertices(int segments, float radius, float circumference, Quaternion rotation, float offset) => default; // 0x0000000186BBD530-0x0000000186BBDC20
		public static pb_Object TorusGenerator(int InRows, int InColumns, float InRadius, float InTubeRadius, bool InSmooth, float InHorizontalCircumference, float InVerticalCircumference) => default; // 0x0000000186BC7170-0x0000000186BC7870
	}
}
