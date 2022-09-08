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
	public class PressureSensor : MonoBehaviour // TypeDefIndex: 9896
	{
		// Fields
		public bool visualize; // 0x18
		public LayerMask layers; // 0x1C
		private bool fixedFrame; // 0x48
		private Vector3 P; // 0x4C
		private int count; // 0x58
	
		// Properties
		public Vector3 center { /* [XID] */ /* 0x00000001898A2950-0x00000001898A2990 */ get; /* [XID] */ /* 0x00000001898ACF80-0x00000001898ACFC0 */ private set; } // 0x00000001876E2350-0x00000001876E23C0 0x00000001876E24F0-0x00000001876E2560
		public bool inContact { /* [XID] */ /* 0x00000001898B76D0-0x00000001898B7710 */ get; /* [XID] */ /* 0x00000001898C1E90-0x00000001898C1ED0 */ private set; } // 0x00000001876E23C0-0x00000001876E2420 0x00000001876E2560-0x00000001876E25C0
		public Vector3 bottom { get; private set; } // 0x00000001876E22E0-0x00000001876E2350 0x00000001876E2480-0x00000001876E24F0
		public Rigidbody r { /* [XID] */ /* 0x00000001898DB690-0x00000001898DB6D0 */ get; /* [XID] */ /* 0x00000001898E6490-0x00000001898E64D0 */ private set; } // 0x00000001876E2420-0x00000001876E2480 0x00000001876E25C0-0x00000001876E2620
	
		// Constructors
		public PressureSensor() {} // 0x00000001876E2280-0x00000001876E22E0
	
		// Methods
		// [XID] // 0x00000001898F0E80-0x00000001898F0EA0
		private void Awake() {} // 0x00000001876E1820-0x00000001876E1990
		// [XID] // 0x00000001898F8880-0x00000001898F88A0
		private void OnCollisionEnter(Collision c) {} // 0x00000001876E1C50-0x00000001876E1D00
		// [XID] // 0x0000000189900190-0x00000001899001B0
		private void OnCollisionStay(Collision c) {} // 0x00000001876E1DE0-0x00000001876E1E90
		// [XID] // 0x0000000189907780-0x00000001899077A0
		private void OnCollisionExit(Collision c) {} // 0x00000001876E1D00-0x00000001876E1DE0
		// [XID] // 0x000000018990F0D0-0x000000018990F0F0
		private void FixedUpdate() {} // 0x00000001876E1990-0x00000001876E1AD0
		// [XID] // 0x0000000189AA0140-0x0000000189AA0160
		private void LateUpdate() {} // 0x00000001876E1AD0-0x00000001876E1C50
		// [XID] // 0x000000018991E1D0-0x000000018991E1F0
		private void ProcessCollision(Collision c) {} // 0x00000001876E1FA0-0x00000001876E2280
		// [XID] // 0x0000000189AA7990-0x0000000189AA79B0
		private void OnDrawGizmos() {} // 0x00000001876E1E90-0x00000001876E1FA0
	}
}
