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
	// [AddComponentMenu] // 0x00000001897D77F0-0x00000001897D7820
	public class MuscleCollisionBroadcaster : MonoBehaviour // TypeDefIndex: 9894
	{
		// Fields
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		public PuppetMaster puppetMaster; // 0x18
		[HideInInspector] // 0x00000001896ACE20-0x00000001896ACE50
		[SerializeField] // 0x00000001896ACE20-0x00000001896ACE50
		public int muscleIndex; // 0x20
		private const string onMuscleHit = "OnMuscleHit"; // Metadata: 0x00AE6C0A
		private const string onMuscleCollision = "OnMuscleCollision"; // Metadata: 0x00AE6C19
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit"; // Metadata: 0x00AE6C2E
		private MuscleCollisionBroadcaster otherBroadcaster; // 0x28
	
		// Constructors
		public MuscleCollisionBroadcaster() {} // 0x00000001876D9440-0x00000001876D9520
	
		// Methods
		// [XID] // 0x0000000189A0AB30-0x0000000189A0AB50
		public void Hit(float unPin, Vector3 force, Vector3 position) {} // 0x00000001876D8890-0x00000001876D8AF0
		// [XID] // 0x00000001897FD170-0x00000001897FD190
		private void OnCollisionEnter(Collision collision) {} // 0x00000001876D8AF0-0x00000001876D8DA0
		// [XID] // 0x00000001898047E0-0x0000000189804800
		private void OnCollisionStay(Collision collision) {} // 0x00000001876D90F0-0x00000001876D9440
		// [XID] // 0x0000000189A197B0-0x0000000189A197D0
		private void OnCollisionExit(Collision collision) {} // 0x00000001876D8DA0-0x00000001876D90F0
	}
}
