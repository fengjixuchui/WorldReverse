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

namespace PigeonCoopToolkit.Effects.Trails
{
	// [AddComponentMenu] // 0x00000001898C36E0-0x00000001898C3710
	public class SmokeTrail : TrailRenderer_Base // TypeDefIndex: 9449
	{
		// Fields
		public float MinVertexDistance; // 0x68
		public int MaxNumberOfPoints; // 0x6C
		private Vector3 _lastPosition; // 0x70
		private float _distanceMoved; // 0x7C
		public float RandomForceScale; // 0x80
	
		// Constructors
		public SmokeTrail() {} // 0x000000018601F3E0-0x000000018601F480
	
		// Methods
		// [XID] // 0x0000000189AA3020-0x0000000189AA3040
		protected override void Start() {} // 0x000000018601EE70-0x000000018601EF40
		// [XID] // 0x00000001899975F0-0x0000000189997610
		protected override void Update() {} // 0x000000018601F1D0-0x000000018601F3E0
		// [XID] // 0x00000001898DB6F0-0x00000001898DB710
		protected override void OnStartEmit() {} // 0x000000018601EB90-0x000000018601EC60
		// [XID] // 0x00000001898E3320-0x00000001898E3340
		protected override void Reset() {} // 0x000000018601EDC0-0x000000018601EE70
		// [XID] // 0x00000001898EAFA0-0x00000001898EAFC0
		protected override void InitialiseNewPoint(PCTrailPoint newPoint) {} // 0x000000018601EA20-0x000000018601EB90
		// [XID] // 0x0000000189AC1390-0x0000000189AC13B0
		protected override void OnTranslate(Vector3 t) {} // 0x000000018601EC60-0x000000018601EDC0
		// [XID] // 0x0000000189AC8CA0-0x0000000189AC8CC0
		protected override int GetMaxNumberOfPoints() => default; // 0x000000018601E980-0x000000018601EA20
	}
}
