/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public class MeshHelper // TypeDefIndex: 9685
	{
		// Fields
		private Mesh mesh; // 0x10
		private int[] triangles; // 0x18
		private Vector3[] vertices; // 0x20
		private Vector3[] normals; // 0x28
		private float[] normalizedAreaWeights; // 0x30
	
		// Properties
		public Mesh Mesh { /* [XID] */ /* 0x000000018991B400-0x000000018991B420 */ get => default; } // 0x000000018604D930-0x000000018604D9D0 
		public int[] Triangles { /* [XID] */ /* 0x0000000189922900-0x0000000189922920 */ get => default; } // 0x000000018604DA70-0x000000018604DB10 
		public Vector3[] Vertices { /* [XID] */ /* 0x000000018992A160-0x000000018992A180 */ get => default; } // 0x000000018604DB10-0x000000018604DBB0 
		public Vector3[] Normals { /* [XID] */ /* 0x0000000189931780-0x00000001899317A0 */ get => default; } // 0x000000018604D9D0-0x000000018604DA70 
	
		// Constructors
		public MeshHelper() {} // Dummy constructor
		public MeshHelper(Mesh mesh) {} // 0x000000018604D870-0x000000018604D930
	
		// Methods
		// [XID] // 0x000000018990C040-0x000000018990C060
		public void GenerateRandomPoint(ref RaycastHit hit, out int triangleIndex) {
			triangleIndex = default;
		} // 0x000000018604CF20-0x000000018604D000
		// [XID] // 0x0000000189913980-0x00000001899139A0
		public void GetRaycastFromTriangleIndex(int triangleIndex, ref RaycastHit hit) {} // 0x000000018604D000-0x000000018604D760
		// [XID] // 0x0000000189619F80-0x0000000189619FA0
		private float[] CalculateSurfaceAreas(out float totalSurfaceArea) {
			totalSurfaceArea = default;
			return default;
		} // 0x000000018604C820-0x000000018604CD00
		// [XID] // 0x0000000189940670-0x0000000189940690
		private void CalculateNormalizedAreaWeights() {} // 0x000000018604C6C0-0x000000018604C820
		// [XID] // 0x0000000189AD1EA0-0x0000000189AD1EC0
		private int SelectRandomTriangle() => default; // 0x000000018604D760-0x000000018604D870
		// [XID] // 0x000000018994F370-0x000000018994F390
		private Vector3 GenerateRandomBarycentricCoordinates() => default; // 0x000000018604CD00-0x000000018604CF20
	}
}
