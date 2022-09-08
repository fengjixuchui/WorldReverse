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
	// [AddComponentMenu] // 0x0000000189885330-0x0000000189885390
	// [HelpURL] // 0x0000000189885330-0x0000000189885390
	public class RagdollEditor : MonoBehaviour // TypeDefIndex: 9930
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Rigidbody selectedRigidbody; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Collider selectedCollider; // 0x20
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool symmetry; // 0x28
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Mode mode; // 0x2C
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 9931
		{
			Colliders = 0,
			Joints = 1
		}
	
		// Constructors
		public RagdollEditor() {} // 0x000000018779AC70-0x000000018779ACE0
	
		// Methods
		// [ContextMenu] // 0x00000001898AEAE0-0x00000001898AEB30
		// [XID] // 0x00000001898AEAE0-0x00000001898AEB30
		private void OpenUserManual() {} // 0x000000018779ABC0-0x000000018779AC70
		// [ContextMenu] // 0x00000001898B9360-0x00000001898B93B0
		// [XID] // 0x00000001898B9360-0x00000001898B93B0
		private void OpenScriptReference() {} // 0x000000018779AA60-0x000000018779AB10
		// [ContextMenu] // 0x00000001898C3690-0x00000001898C36E0
		// [XID] // 0x00000001898C3690-0x00000001898C36E0
		private void OpenTutorial() {} // 0x000000018779AB10-0x000000018779ABC0
	}
}
