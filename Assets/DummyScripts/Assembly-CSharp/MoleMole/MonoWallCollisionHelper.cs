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
	public class MonoWallCollisionHelper : MonoBehaviour // TypeDefIndex: 31768
	{
		// Fields
		public Action<Collision, GameObject> collisionStayCallback; // 0x18
		public Action<Collision, GameObject> collisionEnterCallback; // 0x20
		public Action<Collision, GameObject> collisionExitCallback; // 0x28
		public Action<Collider, GameObject> triggerEnterCallback; // 0x30
		public Action<Collider, GameObject> triggerStayCallback; // 0x38
		public Action<Collider, GameObject> triggerExitCallback; // 0x40
	
		// Constructors
		public MonoWallCollisionHelper() {} // 0x00000001824A5F10-0x00000001824A5F90
	
		// Methods
		// [XID] // 0x0000000189AD58F0-0x0000000189AD5910
		public void OnCollisionEnter(Collision collision) {} // 0x00000001824A5970-0x00000001824A5A60
		// [XID] // 0x0000000189ADD370-0x0000000189ADD390
		public void OnCollisionExit(Collision collision) {} // 0x00000001824A5A60-0x00000001824A5B50
		// [XID] // 0x0000000189AE4A60-0x0000000189AE4A80
		public void OnTriggerEnter(Collider other) {} // 0x00000001824A5C40-0x00000001824A5D30
		// [XID] // 0x0000000189AEC170-0x0000000189AEC190
		public void OnTriggerStay(Collider other) {} // 0x00000001824A5E20-0x00000001824A5F10
		// [XID] // 0x0000000189AF3BD0-0x0000000189AF3BF0
		public void OnTriggerExit(Collider other) {} // 0x00000001824A5D30-0x00000001824A5E20
		// [XID] // 0x0000000189AFB300-0x0000000189AFB320
		public void OnCollisionStay(Collision collision) {} // 0x00000001824A5B50-0x00000001824A5C40
	}
}
