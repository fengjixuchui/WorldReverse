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

namespace RootMotion.Dynamics
{
	[Serializable]
	public class SubBehaviourCOM : SubBehaviourBase // TypeDefIndex: 9884
	{
		// Fields
		public Mode mode; // 0x18
		public float velocityDamper; // 0x1C
		public float velocityLerpSpeed; // 0x20
		public float velocityMax; // 0x24
		public float centerOfPressureSpeed; // 0x28
		public Vector3 offset; // 0x2C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool[] groundContacts; // 0x98
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3[] groundContactPoints; // 0xA0
		private LayerMask groundLayers; // 0xA8
	
		// Properties
		public Vector3 position { /* [XID] */ /* 0x00000001899ACE70-0x00000001899ACEB0 */ get; /* [XID] */ /* 0x00000001899B71F0-0x00000001899B7230 */ private set; } // 0x000000018779FA30-0x000000018779FAA0 0x000000018779FE20-0x000000018779FE90
		public Vector3 direction { /* [XID] */ /* 0x00000001899C1DA0-0x00000001899C1DE0 */ get; /* [XID] */ /* 0x00000001899CC3D0-0x00000001899CC410 */ private set; } // 0x000000018779F880-0x000000018779F8F0 0x000000018779FC60-0x000000018779FCD0
		public float angle { /* [XID] */ /* 0x00000001899D69D0-0x00000001899D6A10 */ get; /* [XID] */ /* 0x00000001899E0FA0-0x00000001899E0FE0 */ private set; } // 0x000000018779F7A0-0x000000018779F810 0x000000018779FB80-0x000000018779FBF0
		public Vector3 velocity { /* [XID] */ /* 0x00000001899EB550-0x00000001899EB590 */ get; /* [XID] */ /* 0x00000001899F5FB0-0x00000001899F5FF0 */ private set; } // 0x000000018779FB10-0x000000018779FB80 0x000000018779FF00-0x000000018779FF70
		public Vector3 centerOfPressure { /* [XID] */ /* 0x0000000189A00480-0x0000000189A004C0 */ get; /* [XID] */ /* 0x0000000189A0AC50-0x0000000189A0AC90 */ private set; } // 0x000000018779F810-0x000000018779F880 0x000000018779FBF0-0x000000018779FC60
		public Quaternion rotation { /* [XID] */ /* 0x0000000189A153C0-0x0000000189A15400 */ get; /* [XID] */ /* 0x0000000189A1F6F0-0x0000000189A1F730 */ private set; } // 0x000000018779FAA0-0x000000018779FB10 0x000000018779FE90-0x000000018779FF00
		public Quaternion inverseRotation { get; /* [XID] */ /* 0x0000000189A31000-0x0000000189A31040 */ private set; } // 0x000000018779F8F0-0x000000018779F960 0x000000018779FCD0-0x000000018779FD40
		public bool isGrounded { /* [XID] */ /* 0x0000000189A3B850-0x0000000189A3B890 */ get; /* [XID] */ /* 0x0000000189A462A0-0x0000000189A462E0 */ private set; } // 0x000000018779F960-0x000000018779F9C0 0x000000018779FD40-0x000000018779FDB0
		public float lastGroundedTime { get; /* [XID] */ /* 0x0000000189A57F00-0x0000000189A57F40 */ private set; } // 0x000000018779F9C0-0x000000018779FA30 0x000000018779FDB0-0x000000018779FE20
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 9885
		{
			FeetCentroid = 0,
			CenterOfPressure = 1
		}
	
		// Constructors
		public SubBehaviourCOM() {} // 0x000000018779F6E0-0x000000018779F7A0
	
		// Methods
		// [XID] // 0x000000018966FF70-0x000000018966FF90
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers) {} // 0x000000018779DD40-0x000000018779E190
		// [XID] // 0x0000000189A6A580-0x0000000189A6A5A0
		private void OnHierarchyChanged() {} // 0x000000018779E290-0x000000018779E3C0
		// [XID] // 0x0000000189A71930-0x0000000189A71950
		private void OnPreMuscleCollision(MuscleCollision c) {} // 0x000000018779F4D0-0x000000018779F6E0
		// [XID] // 0x0000000189A79400-0x0000000189A79420
		private void OnPreMuscleCollisionExit(MuscleCollision c) {} // 0x000000018779F310-0x000000018779F4D0
		// [XID] // 0x00000001896BEB30-0x00000001896BEB50
		private void OnPreActivate() {} // 0x000000018779E3C0-0x000000018779E740
		// [XID] // 0x00000001897A2F20-0x00000001897A2F40
		private void OnPreLateUpdate() {} // 0x000000018779E870-0x000000018779F310
		// [XID] // 0x0000000189B36CB0-0x0000000189B36CD0
		private void OnPreDeactivate() {} // 0x000000018779E740-0x000000018779E870
		// [XID] // 0x0000000189A97670-0x0000000189A97690
		private Vector3 GetCollisionCOP(Collision collision) => default; // 0x000000018779D440-0x000000018779D6C0
		// [XID] // 0x0000000189A9EA10-0x0000000189A9EA30
		private bool IsGrounded() => default; // 0x000000018779E190-0x000000018779E290
		// [XID] // 0x0000000189AA6340-0x0000000189AA6360
		private Vector3 GetCenterOfMass() => default; // 0x000000018779CED0-0x000000018779D1D0
		// [XID] // 0x0000000189AAD9A0-0x0000000189AAD9C0
		private Vector3 GetCenterOfMassVelocity() => default; // 0x000000018779CB00-0x000000018779CED0
		// [XID] // 0x000000018971EE50-0x000000018971EE70
		private Vector3 GetMomentum() => default; // 0x000000018779DA00-0x000000018779DD40
		// [XID] // 0x0000000189ABCE10-0x0000000189ABCE30
		private Vector3 GetCenterOfPressure() => default; // 0x000000018779D1D0-0x000000018779D440
		// [XID] // 0x0000000189AB5B60-0x0000000189AB5B80
		private Vector3 GetFeetCentroid() => default; // 0x000000018779D6C0-0x000000018779DA00
	}
}
