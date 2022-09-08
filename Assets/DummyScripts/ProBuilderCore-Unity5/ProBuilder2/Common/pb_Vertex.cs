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
	public class pb_Vertex : IEquatable<ProBuilder2.Common.pb_Vertex> // TypeDefIndex: 3456
	{
		// Fields
		public Vector3 position; // 0x10
		public Color color; // 0x1C
		public Vector3 normal; // 0x2C
		public Vector4 tangent; // 0x38
		public Vector2 uv0; // 0x48
		public Vector2 uv2; // 0x50
		public Vector4 uv3; // 0x58
		public Vector4 uv4; // 0x68
		public bool hasPosition; // 0x78
		public bool hasColor; // 0x79
		public bool hasNormal; // 0x7A
		public bool hasTangent; // 0x7B
		public bool hasUv0; // 0x7C
		public bool hasUv2; // 0x7D
		public bool hasUv3; // 0x7E
		public bool hasUv4; // 0x7F
	
		// Constructors
		public pb_Vertex() {} // Dummy constructor
		public pb_Vertex(bool hasAllValues = false /* Metadata: 0x00AC3D96 */) {} // 0x00000001894D4870-0x00000001894D4900
		public pb_Vertex(pb_Vertex v) {} // 0x00000001894D4900-0x00000001894D4A10
	
		// Methods
		public override bool Equals(object other) => default; // 0x00000001894D1B70-0x00000001894D1C60
		public bool Equals(pb_Vertex other) => default; // 0x00000001894D1C60-0x00000001894D1E60
		public override int GetHashCode() => default; // 0x00000001894D2570-0x00000001894D2710
		public static pb_Vertex operator +(pb_Vertex a, pb_Vertex b) => default; // 0x00000001894D4A10-0x00000001894D4AC0
		public void Add(pb_Vertex b) {} // 0x00000001894D0E90-0x00000001894D1110
		public static pb_Vertex operator -(pb_Vertex a, pb_Vertex b) => default; // 0x00000001894D4C20-0x00000001894D4CD0
		public void Subtract(pb_Vertex b) {} // 0x00000001894D4580-0x00000001894D4800
		public static pb_Vertex operator *(pb_Vertex a, float value) => default; // 0x00000001894D4B70-0x00000001894D4C20
		public void Multiply(float value) {} // 0x00000001894D3FB0-0x00000001894D41D0
		public static pb_Vertex operator /(pb_Vertex a, float value) => default; // 0x00000001894D4AC0-0x00000001894D4B70
		public void Divide(float value) {} // 0x00000001894D1950-0x00000001894D1B70
		public void Normalize() {} // 0x00000001894D41D0-0x00000001894D42F0
		public override string ToString() => default; // 0x00000001894D4800-0x00000001894D4870
		public static pb_Vertex[] GetVertices(pb_Object pb, IList<int> indices = null) => default; // 0x00000001894D2FF0-0x00000001894D3970
		public static pb_Vertex[] GetVertices(Mesh m) => default; // 0x00000001894D2710-0x00000001894D2FF0
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4) {
			position = default;
			color = default;
			uv0 = default;
			normal = default;
			tangent = default;
			uv2 = default;
			uv3 = default;
			uv4 = default;
		} // 0x00000001894D2480-0x00000001894D2570
		public static void GetArrays(IList<pb_Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, AttributeType attributes) {
			position = default;
			color = default;
			uv0 = default;
			normal = default;
			tangent = default;
			uv2 = default;
			uv3 = default;
			uv4 = default;
		} // 0x00000001894D1E60-0x00000001894D2480
		public static void SetMesh(Mesh m, IList<pb_Vertex> vertices) {} // 0x00000001894D42F0-0x00000001894D4580
		public static pb_Vertex Average(IList<pb_Vertex> vertices, IList<int> indices = null) => default; // 0x00000001894D1110-0x00000001894D1950
		public static pb_Vertex Mix(pb_Vertex x, pb_Vertex y, float a) => default; // 0x00000001894D3970-0x00000001894D3FB0
	}
}
