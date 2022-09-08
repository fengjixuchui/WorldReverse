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
	[Serializable]
	public struct pb_BezierPoint // TypeDefIndex: 3436
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector3 tangentIn; // 0x0C
		public Vector3 tangentOut; // 0x18
		public Quaternion rotation; // 0x24
	
		// Constructors
		public pb_BezierPoint(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation) {
			this.position = default;
			this.tangentIn = default;
			this.tangentOut = default;
			this.rotation = default;
		} // 0x000000018770CCC0-0x000000018770CDA0
	
		// Methods
		public void EnforceTangentMode(pb_BezierTangentDirection master, pb_BezierTangentMode mode) {} // 0x000000018770BF50-0x000000018770BF60
		public void SetPosition(Vector3 position) {} // 0x000000018770CB50-0x000000018770CB80
		public void SetTangentIn(Vector3 tangent, pb_BezierTangentMode mode) {} // 0x000000018770CB80-0x000000018770CC20
		public void SetTangentOut(Vector3 tangent, pb_BezierTangentMode mode) {} // 0x000000018770CC20-0x000000018770CCC0
		public static Vector3 QuadraticPosition(pb_BezierPoint a, pb_BezierPoint b, float t) => default; // 0x000000018770C8B0-0x000000018770CB50
		public static Vector3 CubicPosition(pb_BezierPoint a, pb_BezierPoint b, float t) => default; // 0x000000018770B870-0x000000018770BF50
		public static Vector3 GetLookDirection(IList<pb_BezierPoint> points, int index, int previous, int next) => default; // 0x000000018770BF60-0x000000018770C8B0
	}
}
