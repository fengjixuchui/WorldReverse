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

namespace MoleMole.SimpleLightProbePlacer
{
	// [AddComponentMenu] // 0x000000018991CDF0-0x000000018991CE20
	public class MHYLightProbeVolume : MHYTransformVolume // TypeDefIndex: 31723
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LightProbeVolumeType m_type; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 m_densityFixed; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 m_densityFloat; // 0x40
	
		// Properties
		public LightProbeVolumeType Type { /* [XID] */ /* 0x000000018993C3A0-0x000000018993C3C0 */ get => default; /* [XID] */ /* 0x00000001899439F0-0x0000000189943A10 */ set {} } // 0x0000000184EE0E90-0x0000000184EE0F30 0x0000000184EE1010-0x0000000184EE10C0
		public Vector3 Density { /* [XID] */ /* 0x000000018994AF50-0x000000018994AF70 */ get => default; /* [XID] */ /* 0x00000001899528D0-0x00000001899528F0 */ set {} } // 0x0000000184EE0CB0-0x0000000184EE0DA0 0x0000000184EE0F30-0x0000000184EE1010
		public static Color EditorColor { /* [XID] */ /* 0x0000000189959EB0-0x0000000189959ED0 */ get => default; } // 0x0000000184EE0DA0-0x0000000184EE0E90 
	
		// Constructors
		public MHYLightProbeVolume() {} // 0x0000000184EE0BE0-0x0000000184EE0CB0
	
		// Methods
		// [IDTag] // 0x00000001899618C0-0x0000000189961900
		// [XID] // 0x00000001899618C0-0x0000000189961900
		public List<Vector3> CreatePositions() => default; // 0x0000000184EE0930-0x0000000184EE09E0
		// [IDTag] // 0x000000018996BDB0-0x000000018996BDF0
		// [XID] // 0x000000018996BDB0-0x000000018996BDF0
		public List<Vector3> CreatePositions(LightProbeVolumeType type) => default; // 0x0000000184EE09E0-0x0000000184EE0BE0
		// [XID] // 0x0000000189976710-0x0000000189976730
		public static List<Vector3> CreatePositionsFixed(Transform volumeTransform, Vector3 origin, Vector3 size, Vector3 density) => default; // 0x0000000184EE0080-0x0000000184EE04D0
		// [XID] // 0x000000018997DAF0-0x000000018997DB10
		public static List<Vector3> CreatePositionsFloat(Transform volumeTransform, Vector3 origin, Vector3 size, Vector3 density) => default; // 0x0000000184EE04D0-0x0000000184EE0930
	}
}
