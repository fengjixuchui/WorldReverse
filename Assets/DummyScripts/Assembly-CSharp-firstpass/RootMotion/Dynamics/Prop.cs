/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using RootMotion;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	public abstract class Prop : MonoBehaviour // TypeDefIndex: 9897
	{
		// Fields
		// [Tooltip] // 0x000000018992CF30-0x000000018992CF60
		public int propType; // 0x18
		// [LargeHeader] // 0x0000000189935CA0-0x0000000189935D00
		// [Tooltip] // 0x0000000189935CA0-0x0000000189935D00
		public ConfigurableJoint muscle; // 0x20
		// [Tooltip] // 0x0000000189943590-0x00000001899435C0
		public Muscle.Props muscleProps; // 0x28
		// [Tooltip] // 0x000000018994C3E0-0x000000018994C410
		public bool forceLayers; // 0x30
		// [LargeHeader] // 0x0000000189955320-0x0000000189955380
		// [Tooltip] // 0x0000000189955320-0x0000000189955380
		public ConfigurableJoint additionalPin; // 0x38
		// [Tooltip] // 0x0000000189962F30-0x0000000189962F60
		public Transform additionalPinTarget; // 0x40
		// [Range] // 0x000000018996BAD0-0x000000018996BB20
		// [Tooltip] // 0x000000018996BAD0-0x000000018996BB20
		public float additionalPinWeight; // 0x48
		private ConfigurableJointMotion xMotion; // 0x58
		private ConfigurableJointMotion yMotion; // 0x5C
		private ConfigurableJointMotion zMotion; // 0x60
		private ConfigurableJointMotion angularXMotion; // 0x64
		private ConfigurableJointMotion angularYMotion; // 0x68
		private ConfigurableJointMotion angularZMotion; // 0x6C
		private Collider[] colliders; // 0x70
	
		// Properties
		public bool isPickedUp { /* [XID] */ /* 0x0000000189982760-0x0000000189982780 */ get; } // 0x000000018777F700-0x000000018777F810 
		public PropRoot propRoot { /* [XID] */ /* 0x0000000189989F50-0x0000000189989F90 */ get; /* [XID] */ /* 0x0000000189994A00-0x0000000189994A40 */ private set; } // 0x000000018777F810-0x000000018777F870 0x000000018777F870-0x000000018777F8D0
	
		// Constructors
		protected Prop() {} // 0x000000018777F650-0x000000018777F700
	
		// Methods
		// [XID] // 0x0000000189B737D0-0x0000000189B737F0
		public void PickUp(PropRoot propRoot) {} // 0x000000018777EFA0-0x000000018777F290
		// [XID] // 0x00000001899A6CB0-0x00000001899A6CD0
		public void Drop() {} // 0x000000018777EA00-0x000000018777EAF0
		// [XID] // 0x00000001899AE4D0-0x00000001899AE4F0
		public void StartPickedUp(PropRoot propRoot) {} // 0x000000018777F4B0-0x000000018777F590
		// [XID] // 0x00000001899B5B60-0x00000001899B5B80
		protected virtual void OnPickUp(PropRoot propRoot) {} // 0x000000018777EE50-0x000000018777EF00
		// [XID] // 0x00000001899BD400-0x00000001899BD420
		protected virtual void OnDrop() {} // 0x000000018777EDB0-0x000000018777EE50
		// [XID] // 0x0000000189743160-0x0000000189743180
		protected virtual void OnStart() {} // 0x000000018777EF00-0x000000018777EFA0
		// [XID] // 0x00000001897B39A0-0x00000001897B39C0
		protected virtual void Awake() {} // 0x000000018777E780-0x000000018777EA00
		// [XID] // 0x0000000189694D00-0x0000000189694D20
		private void Start() {} // 0x000000018777F590-0x000000018777F650
		// [XID] // 0x0000000189A93430-0x0000000189A93450
		private void ReleaseJoint() {} // 0x000000018777F290-0x000000018777F4B0
		// [XID] // 0x0000000189AA2290-0x0000000189AA22B0
		private void OnDrawGizmos() {} // 0x000000018777EAF0-0x000000018777EDB0
	}
}
