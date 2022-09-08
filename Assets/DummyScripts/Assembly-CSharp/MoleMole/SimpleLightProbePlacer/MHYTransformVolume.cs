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

namespace MoleMole.SimpleLightProbePlacer
{
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public class MHYTransformVolume : MonoBehaviour // TypeDefIndex: 31724
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MHYVolume m_volume; // 0x18
	
		// Properties
		public MHYVolume Volume { /* [XID] */ /* 0x000000018999C5D0-0x000000018999C5F0 */ get => default; /* [XID] */ /* 0x00000001899A4060-0x00000001899A4080 */ set {} } // 0x0000000184EE2FA0-0x0000000184EE3090 0x0000000184EE3090-0x0000000184EE3290
		public Vector3 Origin { /* [XID] */ /* 0x00000001899ABA30-0x00000001899ABA50 */ get => default; } // 0x0000000184EE2DC0-0x0000000184EE2EB0 
		public Vector3 Size { /* [XID] */ /* 0x00000001899B33F0-0x00000001899B3410 */ get => default; } // 0x0000000184EE2EB0-0x0000000184EE2FA0 
	
		// Constructors
		public MHYTransformVolume() {} // 0x0000000184EE2C70-0x0000000184EE2DC0
	
		// Methods
		// [XID] // 0x00000001899BA750-0x00000001899BA770
		public bool IsInBounds(Vector3[] points) => default; // 0x0000000184EE25E0-0x0000000184EE2710
		// [XID] // 0x00000001899C2090-0x00000001899C20B0
		public bool IsOnBorder(Vector3[] points) => default; // 0x0000000184EE2990-0x0000000184EE2AE0
		// [IDTag] // 0x00000001899C9770-0x00000001899C97B0
		// [XID] // 0x00000001899C9770-0x00000001899C97B0
		public bool IsInVolume(Vector3[] points) => default; // 0x0000000184EE2710-0x0000000184EE2810
		// [IDTag] // 0x00000001899D3EC0-0x00000001899D3F00
		// [XID] // 0x00000001899D3EC0-0x00000001899D3F00
		public bool IsInVolume(Vector3 position) => default; // 0x0000000184EE2810-0x0000000184EE2990
		// [XID] // 0x00000001899DE2E0-0x00000001899DE300
		public Vector3[] GetCorners() => default; // 0x0000000184EE14A0-0x0000000184EE1A00
		// [IDTag] // 0x00000001899E5FC0-0x00000001899E6000
		// [XID] // 0x00000001899E5FC0-0x00000001899E6000
		public Bounds GetBounds() => default; // 0x0000000184EE1390-0x0000000184EE14A0
		// [IDTag] // 0x00000001899F0600-0x00000001899F0640
		// [XID] // 0x00000001899F0600-0x00000001899F0640
		public Bounds GetBounds(Vector3[] points) => default; // 0x0000000184EE10C0-0x0000000184EE1390
		// [XID] // 0x00000001899FADD0-0x00000001899FADF0
		public GameObject[] GetGameObjectsInBounds(LayerMask layerMask) => default; // 0x0000000184EE1A00-0x0000000184EE1DC0
		// [XID] // 0x0000000189A01FD0-0x0000000189A01FF0
		public Vector3 GetSideDirection(int side) => default; // 0x0000000184EE1DC0-0x0000000184EE20F0
		// [XID] // 0x0000000189A097D0-0x0000000189A097F0
		public Vector3 GetSidePosition(int side) => default; // 0x0000000184EE20F0-0x0000000184EE2490
		// [XID] // 0x0000000189A10F70-0x0000000189A10F90
		public float GetSizeAxis(int side) => default; // 0x0000000184EE2490-0x0000000184EE25E0
	}
}
