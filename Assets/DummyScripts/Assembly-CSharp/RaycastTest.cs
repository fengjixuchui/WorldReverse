/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using FullInspector;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[fiInspectorOnly] // 0x0000000189ABD060-0x0000000189ABD070
public class RaycastTest : MonoBehaviour // TypeDefIndex: 27688
{
	// Fields
	public string dir; // 0x18
	public int framecountPerT; // 0x20
	public GameObject pointlistRoot; // 0x28
	private int testTick; // 0x30
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public List<RayCastTestCase> raycastTests; // 0x38
	private Transform[] testpoints; // 0x40
	private string path; // 0x48

	// Nested types
	[Serializable]
	public class RayCastTestCase : ICloneable // TypeDefIndex: 27689
	{
		// Fields
		public string name; // 0x10
		public float distance; // 0x18
		public Vector3 dir; // 0x1C
		public GameObject toActiveGo; // 0x28
		public Transform[] castPoints; // 0x30
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int id; // 0x38
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int currentFrameIndex; // 0x3C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public RaycastHit hit; // 0x40
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public ResultCol[] subcase; // 0x80
		private static Stopwatch sw; // 0x00
		private static int nameid; // 0x08

		// Nested types
		public class ResultCol // TypeDefIndex: 27690
		{
			// Fields
			public double[] timeInMs; // 0x10
			public Transform testpoint; // 0x18
			public double averageTime; // 0x20

			// Constructors
			public ResultCol() {} // 0x0000000181B55600-0x0000000181B55660

			// Methods
			public void Reset(int framecount) {} // 0x0000000181B55560-0x0000000181B55600
			public string GetName() => default; // 0x0000000181B554D0-0x0000000181B55560
		}

		// Constructors
		public RayCastTestCase() {} // 0x0000000181B53E80-0x0000000181B53FE0
		static RayCastTestCase() {} // 0x0000000181B53DE0-0x0000000181B53E80

		// Methods
		public void Reset(int framecount, Transform[] points) {} // 0x0000000181B53A80-0x0000000181B53D40
		public object Clone() => default; // 0x0000000181B53730-0x0000000181B537A0
		public void DoRaycast(int ti) {} // 0x0000000181B537A0-0x0000000181B53A80
		public void ToCSV(ref StringBuilder sb) {} // 0x0000000181B53D40-0x0000000181B53D90
		public void TotalToCSV(ref StringBuilder sb, int nframe) {} // 0x0000000181B53D90-0x0000000181B53DE0
	}

	// Constructors
	public RaycastTest() {} // 0x0000000181B553B0-0x0000000181B55460

	// Methods
	private void InitCSVFilePath() {} // 0x0000000181B54FC0-0x0000000181B55260
	[InspectorButton] // 0x00000001896EC5C0-0x00000001896EC5D0
	private void BeginTest() {} // 0x0000000181B53FE0-0x0000000181B54140
	[InspectorButton] // 0x00000001896EC5C0-0x00000001896EC5D0
	private void CloneNewCase() {} // 0x0000000181B54140-0x0000000181B542D0
	private void FinailizeTest(ref StringBuilder sb) {} // 0x0000000181B54810-0x0000000181B54C00
	private void CombineToCVS(List<RayCastTestCase> cases, ref StringBuilder sb, int framecount, int pointscount) {} // 0x0000000181B542D0-0x0000000181B54810
	private void FixedUpdate() {} // 0x0000000181B54C00-0x0000000181B54FC0
}

