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
	// [AddComponentMenu] // 0x0000000189886C10-0x0000000189886C40
	public class SmokePlume : TrailRenderer_Base // TypeDefIndex: 9448
	{
		// Fields
		public float TimeBetweenPoints; // 0x68
		public Vector3 ConstantForce; // 0x6C
		public float RandomForceScale; // 0x78
		public int MaxNumberOfPoints; // 0x7C
		private float _timeSincePoint; // 0x80
	
		// Constructors
		public SmokePlume() {} // 0x000000018601E5B0-0x000000018601E6C0
	
		// Methods
		// [XID] // 0x000000018988F760-0x000000018988F780
		protected override void Start() {} // 0x000000018601DE60-0x000000018601DF10
		// [XID] // 0x0000000189896C80-0x0000000189896CA0
		protected override void OnStartEmit() {} // 0x000000018601DB30-0x000000018601DBD0
		// [XID] // 0x000000018989E120-0x000000018989E140
		protected override void Reset() {} // 0x000000018601DBD0-0x000000018601DE60
		// [XID] // 0x00000001896031E0-0x0000000189603200
		protected override void Update() {} // 0x000000018601E450-0x000000018601E5B0
		// [XID] // 0x00000001898AD020-0x00000001898AD040
		protected override void InitialiseNewPoint(PCTrailPoint newPoint) {} // 0x000000018601D9C0-0x000000018601DB30
		// [XID] // 0x000000018998FCA0-0x000000018998FCC0
		protected override void UpdateTrail(PCTrail trail, float deltaTime) {} // 0x000000018601E1A0-0x000000018601E450
		// [XID] // 0x00000001898BC330-0x00000001898BC350
		protected override int GetMaxNumberOfPoints() => default; // 0x000000018601D920-0x000000018601D9C0
	}
}
