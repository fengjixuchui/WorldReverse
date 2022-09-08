/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public static class pb_Projection // TypeDefIndex: 3422
	{
		// Fields
		private static Vector3 t_uaxis; // 0x00
		private static Vector3 t_vaxis; // 0x0C
	
		// Constructors
		static pb_Projection() {} // 0x0000000186BB8DE0-0x0000000186BB8EB0
	
		// Methods
		public static Vector2[] PlanarProject(IList<Vector3> verts, Vector3 planeNormal) => default; // 0x0000000186BB7DD0-0x0000000186BB7EE0
		public static Vector2[] PlanarProject(pb_Object pb, pb_Face face) => default; // 0x0000000186BB74D0-0x0000000186BB7940
		public static Vector2[] PlanarProject(IList<pb_Vertex> vertices, IList<int> indices) => default; // 0x0000000186BB7EE0-0x0000000186BB81B0
		public static Vector2[] PlanarProject(Vector3[] verts, Vector3 planeNormal, ProjectionAxis projectionAxis, int[] indices = null) => default; // 0x0000000186BB70F0-0x0000000186BB74D0
		public static void PlanarProject(Vector3[] verts, Vector2[] uvs, int[] indices, Vector3 planeNormal, ProjectionAxis projectionAxis) {} // 0x0000000186BB7940-0x0000000186BB7DD0
		public static Vector2[] SphericalProject(IList<Vector3> vertices, IList<int> indices = null) => default; // 0x0000000186BB8860-0x0000000186BB8B60
		public static IList<Vector2> Sort(IList<Vector2> verts, SortMethod method = SortMethod.CounterClockwise /* Metadata: 0x00AC3CD8 */) => default; // 0x0000000186BB8490-0x0000000186BB8860
		public static Vector3 ProjectionAxisToVector(ProjectionAxis axis) => default; // 0x0000000186BB81B0-0x0000000186BB8490
		public static ProjectionAxis VectorToProjectionAxis(Vector3 plane) => default; // 0x0000000186BB8C70-0x0000000186BB8DE0
		public static Plane FindBestPlane<T>(IList<T> points, Func<T, Vector3> selector, IList<int> indices = null) => default;
		public static Plane FindBestPlane(Vector3[] points, int[] indices = null) => default; // 0x0000000186BB6B20-0x0000000186BB70F0
	}
}
