/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using PigeonCoopToolkit.Utillities;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace PigeonCoopToolkit.Effects.Trails
{
	public sealed class StaticTrail : TrailRenderer_Base // TypeDefIndex: 26293
	{
		// Fields
		public int PointsBetweenControlPoints; // 0x68
		private CircularBuffer<ControlPoint> _controlPoints; // 0x70
		private float _timer; // 0x7C
		private float _appearDuration; // 0x80
		private AnimationCurve _appearCurve; // 0x88
		private float _vanishDuration; // 0x90
		private AnimationCurve _vanishCurve; // 0x98
		[NonSerialized]
		public UnityEngine.Material firstInstancedMaterial; // 0xA0
	
		// Properties
		public bool IsActive { /* [XID] */ /* 0x00000001897565C0-0x0000000189756600 */ get; set; } // 0x00000001852AE4B0-0x00000001852AE510 0x00000001852AE570-0x00000001852AE700
		public PCTrail activeTrail { get => default; } // 0x00000001852AE510-0x00000001852AE570 
	
		// Nested types
		private class ControlPoint // TypeDefIndex: 26294
		{
			// Fields
			public Vector3 p; // 0x10
			public Vector3 forward; // 0x1C
	
			// Constructors
			public ControlPoint() {} // 0x000000018528A6F0-0x000000018528A7B0
		}
	
		// Constructors
		public StaticTrail() {} // 0x00000001852AE420-0x00000001852AE4B0
	
		// Methods
		protected override void Awake() {} // 0x00000001852A9870-0x00000001852A9AA0
		protected override void OnDestroy() {} // 0x00000001852AD620-0x00000001852AD7B0
		protected override void Update() {} // 0x00000001852AE3D0-0x00000001852AE420
		public void PlayAnimation(float deltaTime) {} // 0x00000001852AD800-0x00000001852ADC80
		public void ResetAnimation(float appearDuration, AnimationCurve appearCurve, float vanishDuration, AnimationCurve vanishCurve) {} // 0x00000001852ADC80-0x00000001852AE140
		protected override void LateUpdate() {} // 0x00000001852AD420-0x00000001852AD620
		protected override void OnStartEmit() {} // 0x00000001852AD7B0-0x00000001852AD800
		public void Init(Vector3[] controlPoints) {} // 0x00000001852AD280-0x00000001852AD420
		private void AddControlPoint(Vector3 position, bool isEndPoint = false /* Metadata: 0x00B0BDA8 */) {} // 0x00000001852A9330-0x00000001852A9510
		private new void AddPoint(PCTrailPoint newPoint, Vector3 pos) {} // 0x00000001852A9510-0x00000001852A9870
		private void GenerateTrail(PCTrail trail) {} // 0x00000001852ABB10-0x00000001852AC9F0
		private Vector3[] CalcExpandingDir(PCTrail trail, Vector3 camForward) => default; // 0x00000001852AA570-0x00000001852AA8C0
		private Vector3[] CalcTangents(PCTrail trail) => default; // 0x00000001852AA8C0-0x00000001852AABA0
		private static Vector3[] CalcExpandingDirAdvanced(PCTrail trail, Vector3 camForward, Vector3 camUp, Vector3 camRight) => default; // 0x00000001852A9AA0-0x00000001852AA570
		private static Vector3[] SmoothDirections(Vector3[] dirs) => default; // 0x00000001852AE140-0x00000001852AE3D0
		private new void GenerateMesh(PCTrail trail) {} // 0x00000001852AABA0-0x00000001852ABB10
		public Vector3 GetPointAlongCurve(Vector3 curveStart, Vector3 curveStartHandle, Vector3 curveEnd, Vector3 curveEndHandle, float t, float crease) => default; // 0x00000001852ACA60-0x00000001852ACE90
		public Vector3 GetPointAlongTrail(float t) => default; // 0x00000001852ACE90-0x00000001852AD280
		protected override int GetMaxNumberOfPoints() => default; // 0x00000001852AC9F0-0x00000001852ACA60
	}
}
