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
	public abstract class SplineBase : MonoBehaviour // TypeDefIndex: 8176
	{
		// Fields
		protected ArcLengthParametrization _parametrization; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected List<ItemData> _data; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected SplineTypes _type; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected bool _recalcSegmentsLength; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Color _renderColor; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected SplinePlaneTypes _creationPlane; // 0x40
	
		// Properties
		protected int SegmentCount { /* [XID] */ /* 0x00000001898B02E0-0x00000001898B0300 */ get; } // 0x00000001874B5440-0x00000001874B5520 
		public int VertexCount { /* [XID] */ /* 0x00000001898EA1B0-0x00000001898EA1D0 */ get; } // 0x00000001874B55E0-0x00000001874B57F0 
		public bool Valid { /* [XID] */ /* 0x0000000189AEC5C0-0x0000000189AEC5E0 */ get; } // 0x00000001874B5520-0x00000001874B55E0 
		public abstract SplineTypes SplineType { get; set; }
	
		// Nested types
		[Serializable]
		protected class ItemData // TypeDefIndex: 8177
		{
			// Fields
			public Vector3 Position; // 0x10
			public Vector3 A; // 0x1C
			public Vector3 B; // 0x28
			public Vector3 C; // 0x34
			public Vector3 D; // 0x40
			public float Length; // 0x4C
			public float AccumulatedLength; // 0x50
			private const int SegmentCount = 10; // Metadata: 0x00ADF6B0
			private const int SegmentCountPlus1 = 11; // Metadata: 0x00ADF6B4
			private const float DeltaTime = 0.1f; // Metadata: 0x00ADF6B8
			public Vector3[] RenderPoints; // 0x58
	
			// Constructors
			public ItemData() {} // 0x000000018749F630-0x000000018749F690
	
			// Methods
			// [XID] // 0x00000001899B4720-0x00000001899B4740
			public bool EnsureRenderPointsValidity() => default; // 0x000000018749E4E0-0x000000018749E5C0
			// [XID] // 0x00000001899BBCA0-0x00000001899BBCC0
			public void UpdateRenderPoints() {} // 0x000000018749F500-0x000000018749F630
			// [XID] // 0x00000001899C3880-0x00000001899C38A0
			public Vector3 EvalPosition(float t) => default; // 0x000000018749EA50-0x000000018749ECC0
			// [XID] // 0x00000001899CAD30-0x00000001899CAD50
			public Vector3 EvalFirstDerivative(float t) => default; // 0x000000018749E5C0-0x000000018749E7F0
			// [XID] // 0x00000001896CEC90-0x00000001896CECB0
			public Vector3 EvalSecondDerivative(float t) => default; // 0x000000018749ECC0-0x000000018749EE80
			// [XID] // 0x000000018994C7B0-0x000000018994C7D0
			public Vector3 EvalThirdDerivative(float t) => default; // 0x000000018749F2F0-0x000000018749F430
			// [XID] // 0x00000001899E1160-0x00000001899E1180
			public float EvalSpeed(float t) => default; // 0x000000018749EE80-0x000000018749F0A0
			// [XID] // 0x00000001899E8BD0-0x00000001899E8BF0
			public Vector3 EvalTangent(float t) => default; // 0x000000018749F0A0-0x000000018749F2F0
			// [IDTag] // 0x00000001899F03C0-0x00000001899F0400
			// [XID] // 0x00000001899F03C0-0x00000001899F0400
			public float EvalLength() => default; // 0x000000018749E930-0x000000018749EA50
			// [IDTag] // 0x00000001899FAAB0-0x00000001899FAAF0
			// [XID] // 0x00000001899FAAB0-0x00000001899FAAF0
			public float EvalLength(float t0, float t1) => default; // 0x000000018749E7F0-0x000000018749E930
			// [XID] // 0x0000000189A04E60-0x0000000189A04E80
			public float ProcessLength(float currentLength) => default; // 0x000000018749F430-0x000000018749F500
		}
	
		protected class ArcLengthParametrization // TypeDefIndex: 8178
		{
			// Fields
			public float[] sSample; // 0x10
			public float[] tSample; // 0x18
			public float[] tsSlope; // 0x20
			public float L; // 0x28
	
			// Constructors
			public ArcLengthParametrization() {} // 0x000000018749E320-0x000000018749E380
	
			// Methods
			// [XID] // 0x0000000189A0C530-0x0000000189A0C550
			public float GetApproximateTimeParameter(float s) => default; // 0x000000018749E1A0-0x000000018749E320
		}
	
		// Constructors
		protected SplineBase() {} // 0x00000001874B5390-0x00000001874B5440
	
		// Methods
		// [XID] // 0x00000001898C6850-0x00000001898C6870
		private void Awake() {} // 0x00000001874B2350-0x00000001874B23F0
		// [XID] // 0x0000000189907F30-0x0000000189907F50
		protected void GetSegmentIndexAndTime(float time, out int segmentIndex, out float segmentTime) {
			segmentIndex = default;
			segmentTime = default;
		} // 0x00000001874B46D0-0x00000001874B4810
		// [XID] // 0x0000000189AC7FB0-0x0000000189AC7FD0
		protected void PrepareForRuntime() {} // 0x00000001874B5130-0x00000001874B5230
		// [XID] // 0x00000001898DD260-0x00000001898DD280
		protected void RecalcSegmentsLength() {} // 0x00000001874B5230-0x00000001874B5390
		public abstract void AddVertexFirst(Vector3 position);
		public abstract void AddVertexLast(Vector3 position);
		public abstract void RemoveVertex(int index);
		public abstract void Clear();
		public abstract void InsertBefore(int vertexIndex, Vector3 position);
		public abstract void InsertAfter(int vertexIndex, Vector3 position);
		public abstract Vector3 GetVertex(int vertexIndex);
		public abstract void SetVertex(int vertexIndex, Vector3 position);
		// [IDTag] // 0x00000001898E4C70-0x00000001898E4CB0
		// [XID] // 0x00000001898E4C70-0x00000001898E4CB0
		public Vector3 EvalPosition(float time) => default; // 0x00000001874B39B0-0x00000001874B3B10
		// [IDTag] // 0x00000001898EF8A0-0x00000001898EF8E0
		// [XID] // 0x00000001898EF8A0-0x00000001898EF8E0
		public Vector3 EvalTangent(float time) => default; // 0x00000001874B3F30-0x00000001874B4090
		// [IDTag] // 0x00000001898F9ED0-0x00000001898F9F10
		// [XID] // 0x00000001898F9ED0-0x00000001898F9F10
		public PositionTangent EvalPositionTangent(float time) => default; // 0x00000001874B3690-0x00000001874B3840
		// [IDTag] // 0x0000000189904900-0x0000000189904940
		// [XID] // 0x0000000189904900-0x0000000189904940
		public void EvalPosition(float time, out Vector3 position) {
			position = default;
		} // 0x00000001874B3B10-0x00000001874B3C50
		// [IDTag] // 0x000000018990F2A0-0x000000018990F2E0
		// [XID] // 0x000000018990F2A0-0x000000018990F2E0
		public void EvalTangent(float time, out Vector3 tangent) {
			tangent = default;
		} // 0x00000001874B4090-0x00000001874B41D0
		// [IDTag] // 0x0000000189919C30-0x0000000189919C70
		// [XID] // 0x0000000189919C30-0x0000000189919C70
		public void EvalPositionTangent(float time, out PositionTangent positionTangent) {
			positionTangent = default;
		} // 0x00000001874B3840-0x00000001874B39B0
		// [XID] // 0x00000001896D6090-0x00000001896D60B0
		public void EvalFrame(float time, out CurveFrame frame) {
			frame = default;
		} // 0x00000001874B2D20-0x00000001874B3050
		// [XID] // 0x00000001898810F0-0x0000000189881110
		public float EvalCurvature(float time) => default; // 0x00000001874B2780-0x00000001874B29D0
		// [XID] // 0x0000000189945300-0x0000000189945320
		public float EvalTorsion(float time) => default; // 0x00000001874B4460-0x00000001874B46D0
		// [IDTag] // 0x000000018993AB30-0x000000018993AB70
		// [XID] // 0x000000018993AB30-0x000000018993AB70
		public Vector3 EvalPositionParametrized(float length) => default; // 0x00000001874B31B0-0x00000001874B3330
		// [IDTag] // 0x0000000189944E50-0x0000000189944E90
		// [XID] // 0x0000000189944E50-0x0000000189944E90
		public Vector3 EvalTangentParametrized(float length) => default; // 0x00000001874B3DB0-0x00000001874B3F30
		// [IDTag] // 0x000000018994F4C0-0x000000018994F500
		// [XID] // 0x000000018994F4C0-0x000000018994F500
		public PositionTangent EvalPositionTangentParametrized(float length) => default; // 0x00000001874B3330-0x00000001874B3500
		// [IDTag] // 0x0000000189959C50-0x0000000189959C90
		// [XID] // 0x0000000189959C50-0x0000000189959C90
		public void EvalPositionParametrized(float length, out Vector3 position) {
			position = default;
		} // 0x00000001874B3050-0x00000001874B31B0
		// [IDTag] // 0x0000000189964470-0x00000001899644B0
		// [XID] // 0x0000000189964470-0x00000001899644B0
		public void EvalTangentParametrized(float length, out Vector3 tangent) {
			tangent = default;
		} // 0x00000001874B3C50-0x00000001874B3DB0
		// [IDTag] // 0x000000018996E8D0-0x000000018996E910
		// [XID] // 0x000000018996E8D0-0x000000018996E910
		public void EvalPositionTangentParametrized(float length, out PositionTangent positionTangent) {
			positionTangent = default;
		} // 0x00000001874B3500-0x00000001874B3690
		// [XID] // 0x0000000189979960-0x0000000189979980
		public void EvalFrameParametrized(float length, out CurveFrame frame) {
			frame = default;
		} // 0x00000001874B29D0-0x00000001874B2D20
		// [XID] // 0x00000001896C7530-0x00000001896C7550
		public float EvalCurvatureParametrized(float length) => default; // 0x00000001874B2510-0x00000001874B2780
		// [XID] // 0x0000000189988420-0x0000000189988440
		public float EvalTorsionParametrized(float length) => default; // 0x00000001874B41D0-0x00000001874B4460
		// [XID] // 0x000000018998FEF0-0x000000018998FF10
		public float CalcTotalLength() => default; // 0x00000001874B23F0-0x00000001874B2510
		// [IDTag] // 0x0000000189997850-0x0000000189997890
		// [XID] // 0x0000000189997850-0x0000000189997890
		public float LengthToTime(float length, int iterations, float tolerance) => default; // 0x00000001874B48E0-0x00000001874B4CB0
		// [IDTag] // 0x00000001899A2570-0x00000001899A25B0
		// [XID] // 0x00000001899A2570-0x00000001899A25B0
		public float LengthToTime(float length) => default; // 0x00000001874B4810-0x00000001874B48E0
		// [XID] // 0x00000001899ACF90-0x00000001899ACFB0
		public float ParametrizeByArcLength(int pointCount) => default; // 0x00000001874B4CB0-0x00000001874B5130
	}
}
