/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using PigeonCoopToolkit.Utillities;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace PigeonCoopToolkit.Effects.Trails
{
	// [AddComponentMenu] // 0x0000000189908FB0-0x0000000189908FE0
	public class SmoothTrail : TrailRenderer_Base // TypeDefIndex: 9451
	{
		// Fields
		public float MinControlPointDistance; // 0x68
		public int MaxControlPoints; // 0x6C
		public int PointsBetweenControlPoints; // 0x70
		public float DelayDistance; // 0x74
		private Vector3 _lastPosition; // 0x78
		private float _remainDelayDistance; // 0x84
		private float _distanceMoved; // 0x88
		private CircularBuffer<ControlPoint> _controlPoints; // 0x90
	
		// Nested types
		private class ControlPoint // TypeDefIndex: 9452
		{
			// Fields
			public Vector3 p; // 0x10
			public Vector3 forward; // 0x1C
	
			// Constructors
			public ControlPoint() {} // 0x000000018600AEE0-0x000000018600AF40
		}
	
		// Constructors
		public SmoothTrail() {} // 0x0000000186022060-0x0000000186022100
	
		// Methods
		// [XID] // 0x0000000189911FF0-0x0000000189912010
		protected override void Start() {} // 0x00000001860206D0-0x00000001860207B0
		// [XID] // 0x0000000189919B40-0x0000000189919B60
		protected override void Update() {} // 0x0000000186021C30-0x0000000186022060
		// [XID] // 0x0000000189AD8110-0x0000000189AD8130
		protected override void OnStartEmit() {} // 0x000000018601FFC0-0x00000001860200D0
		// [XID] // 0x0000000189685A70-0x0000000189685A90
		private void StartEmitAfterDelay() {} // 0x0000000186020400-0x00000001860206D0
		// [XID] // 0x000000018992FEF0-0x000000018992FF10
		protected override void UpdatePoints(PCTrail line, float deltaTime) {} // 0x0000000186020B40-0x0000000186020C10
		// [XID] // 0x0000000189937490-0x00000001899374B0
		protected override void UpdateTrail(PCTrail trail, float deltaTime) {} // 0x0000000186020C10-0x0000000186021C30
		// [XID] // 0x00000001896BAF30-0x00000001896BAF50
		protected override void Reset() {} // 0x0000000186020340-0x0000000186020400
		// [XID] // 0x00000001895FFDB0-0x00000001895FFDD0
		protected override void OnTranslate(Vector3 t) {} // 0x00000001860200D0-0x0000000186020340
		// [XID] // 0x000000018994DC60-0x000000018994DC80
		private void AddControlPoint(Vector3 position) {} // 0x000000018601F480-0x000000018601F7B0
		// [XID] // 0x0000000189AEF1F0-0x0000000189AEF210
		protected override int GetMaxNumberOfPoints() => default; // 0x000000018601F7B0-0x000000018601F860
		// [XID] // 0x0000000189AF65A0-0x0000000189AF65C0
		public bool HasStartAfterDelay() => default; // 0x000000018601FD90-0x000000018601FE40
		// [XID] // 0x00000001899643B0-0x00000001899643D0
		public Vector3 GetPointAlongCurve(Vector3 curveStart, Vector3 curveStartHandle, Vector3 curveEnd, Vector3 curveEndHandle, float t, float crease) => default; // 0x000000018601F860-0x000000018601FD90
		// [XID] // 0x000000018996BB40-0x000000018996BB60
		protected override void OnEnable() {} // 0x000000018601FEF0-0x000000018601FFC0
		// [XID] // 0x0000000189973650-0x0000000189973670
		private void OnDisable() {} // 0x000000018601FE40-0x000000018601FEF0
	}
}
