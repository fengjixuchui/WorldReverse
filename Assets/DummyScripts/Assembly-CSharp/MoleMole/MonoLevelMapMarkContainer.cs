/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoLevelMapMarkContainer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 31249
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _swipeThreshold; // 0x18
		private Vector2 _downPosition; // 0x1C
		private Action<Vector2> _onClick; // 0x28
	
		// Properties
		public Action<Vector2> onClick { /* [XID] */ /* 0x0000000189822980-0x00000001898229A0 */ set {} } // 0x000000018427ADB0-0x000000018427AE60
	
		// Constructors
		public MonoLevelMapMarkContainer() {} // 0x000000018427AD40-0x000000018427ADB0
	
		// Methods
		// [XID] // 0x000000018982A330-0x000000018982A350
		public void OnPointerDown(PointerEventData eventData) {} // 0x000000018427AAB0-0x000000018427AB70
		// [XID] // 0x00000001898315F0-0x0000000189831610
		public void OnPointerUp(PointerEventData eventData) {} // 0x000000018427AB70-0x000000018427AD40
	}
}
