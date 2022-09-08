/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x00000001899936F0-0x0000000189993740
	public class MonoToggler : MonoBehaviour // TypeDefIndex: 30951
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GameObject> listShowOn; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GameObject> listShowOff; // 0x20
		private UnityAction _callbackAfterStart; // 0x28
	
		// Properties
		public UnityAction callbackAfterStart { /* [XID] */ /* 0x00000001899AEAA0-0x00000001899AEAC0 */ set {} } // 0x000000018487FF60-0x0000000184880010
	
		// Constructors
		public MonoToggler() {} // 0x000000018487FEF0-0x000000018487FF60
	
		// Methods
		// [XID] // 0x00000001899B5E00-0x00000001899B5E20
		private void Start() {} // 0x000000018487FE30-0x000000018487FEF0
		// [XID] // 0x00000001899BDB20-0x00000001899BDB40
		private void onValueChanged(bool isOn) {} // 0x000000018487FA10-0x000000018487FCA0
		// [XID] // 0x00000001899C5260-0x00000001899C5280
		public void RebindListener() {} // 0x000000018487FCA0-0x000000018487FE30
		// [XID] // 0x00000001899CC930-0x00000001899CC950
		public void AddValueChanged(UnityAction<bool> callback) {} // 0x000000018487F900-0x000000018487FA10
	}
}
