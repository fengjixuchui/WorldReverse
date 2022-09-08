/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class SECTR_VolumeBattleArea : SECTR_DynamicVolume // TypeDefIndex: 31916
	{
		// Fields
		public SECTR_VolumeShape battleArea; // 0x30
		public bool removeExistLayer; // 0x38
		public bool disableLOD; // 0x39
		public bool fixCenterPos; // 0x3A
		public float fixCenterRadius; // 0x3C
		public float disableCenterRadius; // 0x40
		private bool enableFixCenter; // 0x44
	
		// Constructors
		public SECTR_VolumeBattleArea() {} // 0x0000000184EE8CE0-0x0000000184EE8E00
	
		// Methods
		// [XID] // 0x000000018990F440-0x000000018990F460
		public override void Load() {} // 0x0000000184EE8880-0x0000000184EE8A70
		// [XID] // 0x0000000189916ED0-0x0000000189916EF0
		public override bool ShouldFilterStreamPos() => default; // 0x0000000184EE8C40-0x0000000184EE8CE0
		// [XID] // 0x000000018991E610-0x000000018991E630
		public override Vector3 FilterStreamPos(Vector3 pos) => default; // 0x0000000184EE8350-0x0000000184EE85A0
		// [XID] // 0x0000000189925E10-0x0000000189925E30
		public override bool FilterLod(ISECTR_LODLoader lod, LODType type) => default; // 0x0000000184EE81C0-0x0000000184EE8350
		// [XID] // 0x000000018992D3A0-0x000000018992D3C0
		public override bool IsPosInVolume(Vector3 pos) => default; // 0x0000000184EE86C0-0x0000000184EE87B0
		// [XID] // 0x00000001899348D0-0x00000001899348F0
		public override bool FilterLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EE80D0-0x0000000184EE81C0
		// [XID] // 0x000000018993C380-0x000000018993C3A0
		public override bool RemoveLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EE8B60-0x0000000184EE8C40
		// [XID] // 0x00000001899439D0-0x00000001899439F0
		public override Type GetVolumeType() => default; // 0x0000000184EE85A0-0x0000000184EE8640
	}
}
