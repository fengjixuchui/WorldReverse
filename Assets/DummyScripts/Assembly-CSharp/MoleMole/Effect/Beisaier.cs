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

namespace MoleMole.Effect
{
	[ExecuteInEditMode] // 0x000000018990FB30-0x000000018990FB90
	// [RequireComponent] // 0x000000018990FB30-0x000000018990FB90
	public class Beisaier : MonoBehaviour // TypeDefIndex: 19768
	{
		// Fields
		public LineRenderer lineRenderer; // 0x18
		public List<Transform> controlp; // 0x20
		private int layerOrder; // 0x28
		public int _segmentNum; // 0x2C
	
		// Constructors
		public Beisaier() {} // 0x0000000181492CA0-0x0000000181492D10
	
		// Methods
		// [XID] // 0x000000018991EC20-0x000000018991EC40
		private void Start() {} // 0x0000000181492B00-0x0000000181492C00
		// [XID] // 0x0000000189926520-0x0000000189926540
		private void Update() {} // 0x0000000181492C00-0x0000000181492CA0
		// [XID] // 0x000000018992DBD0-0x000000018992DBF0
		private void DrawCurve() {} // 0x00000001814929A0-0x0000000181492B00
		// [XID] // 0x0000000189934FF0-0x0000000189935010
		private Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2) => default; // 0x0000000181492700-0x00000001814929A0
		// [IDTag] // 0x000000018993CB50-0x000000018993CB90
		// [XID] // 0x000000018993CB50-0x000000018993CB90
		public Vector3 Bezier(float t, List<Vector3> p) => default; // 0x0000000181492200-0x00000001814924E0
		// [IDTag] // 0x0000000189947100-0x0000000189947140
		// [XID] // 0x0000000189947100-0x0000000189947140
		public Vector3 Bezier(float t, List<Transform> p) => default; // 0x00000001814924E0-0x0000000181492700
	}
}
