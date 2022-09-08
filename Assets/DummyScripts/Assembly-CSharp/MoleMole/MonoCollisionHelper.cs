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
	public class MonoCollisionHelper : MonoBehaviour // TypeDefIndex: 31731
	{
		// Fields
		public Action<Collision> collisionEnterCallback; // 0x18
		public Action<Collision> collisionExitCallback; // 0x20
		public Action<Collider> triggerEnterCallback; // 0x28
		public Action<Collider> triggerStayCallback; // 0x30
		public Action<Collider> triggerExitCallback; // 0x38
	
		// Constructors
		public MonoCollisionHelper() {} // 0x0000000184BACEF0-0x0000000184BACF70
	
		// Methods
		// [XID] // 0x0000000189B0CF40-0x0000000189B0CF60
		public void OnCollisionEnter(Collision collision) {} // 0x0000000184BACB30-0x0000000184BACBF0
		// [XID] // 0x0000000189B14570-0x0000000189B14590
		public void OnCollisionExit(Collision collision) {} // 0x0000000184BACBF0-0x0000000184BACCB0
		// [XID] // 0x0000000189B1BD70-0x0000000189B1BD90
		public void OnTriggerEnter(Collider other) {} // 0x0000000184BACCB0-0x0000000184BACD70
		// [XID] // 0x0000000189B234F0-0x0000000189B23510
		public void OnTriggerStay(Collider other) {} // 0x0000000184BACE30-0x0000000184BACEF0
		// [XID] // 0x0000000189B2A770-0x0000000189B2A790
		public void OnTriggerExit(Collider other) {} // 0x0000000184BACD70-0x0000000184BACE30
	}
}
