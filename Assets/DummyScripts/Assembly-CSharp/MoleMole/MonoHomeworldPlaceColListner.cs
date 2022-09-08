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
	public class MonoHomeworldPlaceColListner : MonoBehaviour // TypeDefIndex: 20394
	{
		// Fields
		public Action<GameObject> onColliderEnterCallback; // 0x18
		public Action<GameObject> onColliderExitCallback; // 0x20
		public Collider attachCollider; // 0x28
		public ColliderType colliderType; // 0x30
	
		// Constructors
		public MonoHomeworldPlaceColListner() {} // 0x00000001846F7C70-0x00000001846F7CE0
	
		// Methods
		// [XID] // 0x000000018999B580-0x000000018999B5A0
		private void OnTriggerEnter(Collider other) {} // 0x00000001846F77D0-0x00000001846F7900
		// [XID] // 0x00000001899A2CD0-0x00000001899A2CF0
		private void OnTriggerExit(Collider other) {} // 0x00000001846F7900-0x00000001846F7A30
		// [XID] // 0x00000001899AA740-0x00000001899AA760
		public void RegisterListeners(Action<GameObject> enterAction, Action<GameObject> exitAction) {} // 0x00000001846F7A30-0x00000001846F7B00
		// [XID] // 0x00000001899B20C0-0x00000001899B20E0
		public void ClearListeners() {} // 0x00000001846F7730-0x00000001846F77D0
		// [XID] // 0x00000001899B94E0-0x00000001899B9500
		public void SetupCollider() {} // 0x00000001846F7B00-0x00000001846F7C70
	}
}
