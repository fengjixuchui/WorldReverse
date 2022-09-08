/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class SECTR_VolumePortal : SECTR_BaseVolume // TypeDefIndex: 31923
	{
		// Fields
		public List<SECTR_VolumeShape> insideAreas; // 0x30
		public List<Vector3> inPosOffsets; // 0x38
		public List<Vector3> inForwardOffsets; // 0x40
		public List<SECTR_VolumeShape> outsideAreas; // 0x48
		public List<Vector3> outPosOffsets; // 0x50
		public List<Vector3> outForwardOffsets; // 0x58
		public List<string> cityNames; // 0x60
		public SECTR_PortalBehaviourType inAreaType; // 0x68
		public SECTR_PortalBehaviourType outAreaType; // 0x6C
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private SECTR_PortalType playerState; // 0x70
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private bool _isLoaded; // 0x74
		public List<uint> _cityTypeIDs; // 0x78
	
		// Constructors
		public SECTR_VolumePortal() {} // 0x0000000184EED2C0-0x0000000184EED450
	
		// Methods
		// [XID] // 0x0000000189A06A50-0x0000000189A06A70
		private void InitAreas() {} // 0x0000000184EEB9F0-0x0000000184EEC3E0
		// [XID] // 0x0000000189A0E140-0x0000000189A0E160
		public override void Load() {} // 0x0000000184EECEC0-0x0000000184EECF90
		// [XID] // 0x0000000189A15700-0x0000000189A15720
		public override void Unload() {} // 0x0000000184EED210-0x0000000184EED2C0
		// [XID] // 0x0000000189A1CBC0-0x0000000189A1CBE0
		public override void ActiveVolume() {} // 0x0000000184EEB530-0x0000000184EEB5D0
		// [XID] // 0x0000000189A24160-0x0000000189A24180
		public override void DeactiveVolume() {} // 0x0000000184EEB950-0x0000000184EEB9F0
		// [XID] // 0x0000000189A2B5B0-0x0000000189A2B5D0
		public override bool IsPosInVolume(Vector3 pos) => default; // 0x0000000184EECB10-0x0000000184EECD00
		// [XID] // 0x0000000189A32B70-0x0000000189A32B90
		private bool IsPosInArea(List<SECTR_VolumeShape> areas, Vector3 pos) => default; // 0x0000000184EEC910-0x0000000184EECA70
		// [XID] // 0x0000000189A3A490-0x0000000189A3A4B0
		private bool IsAreaIntersects(List<SECTR_VolumeShape> areas, Bounds bounds) => default; // 0x0000000184EECD00-0x0000000184EECE60
		// [XID] // 0x0000000189A41D90-0x0000000189A41DB0
		private bool IsInvalidInsideArea(List<SECTR_VolumeShape> areas, SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EEB720-0x0000000184EEB950
		// [XID] // 0x0000000189A493A0-0x0000000189A493C0
		public override bool InvalidInLoading() => default; // 0x0000000184EECA70-0x0000000184EECB10
		// [XID] // 0x0000000189A50C80-0x0000000189A50CA0
		public override bool FilterLod(ISECTR_LODLoader lod, LODType type) => default; // 0x0000000184EEC580-0x0000000184EEC780
		// [XID] // 0x0000000189A581C0-0x0000000189A581E0
		public override bool FilterLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EEC470-0x0000000184EEC580
		// [XID] // 0x0000000189A5FD00-0x0000000189A5FD20
		public override bool RemoveLayer(SECTR_BaseLayerProxy proxy) => default; // 0x0000000184EED0E0-0x0000000184EED210
		// [XID] // 0x0000000189A67920-0x0000000189A67940
		public override Type GetVolumeType() => default; // 0x0000000184EEC780-0x0000000184EEC820
	}
}
