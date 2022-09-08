/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class VRBrowserHand : MonoBehaviour // TypeDefIndex: 6602
	{
		// Fields
		// [Tooltip] // 0x00000001898B46E0-0x00000001898B4710
		public XRNode hand; // 0x18
		// [Tooltip] // 0x00000001898BD860-0x00000001898BD890
		public GameObject visualization; // 0x20
		private XRNodeState nodeState; // 0x40
		// [Tooltip] // 0x00000001898F1160-0x00000001898F1190
		public float scrollThreshold; // 0xA0
		// [Tooltip] // 0x00000001898F9F70-0x00000001898F9FA0
		public float trackpadScrollSpeed; // 0xA4
		// [Tooltip] // 0x00000001899031D0-0x0000000189903200
		public float joystickScrollSpeed; // 0xA8
		private Vector2 lastTouchPoint; // 0xAC
		private bool touchIsScrolling; // 0xB4
		private int lastFrame; // 0xB8
		private List<XRNodeState> states; // 0xC0
		private bool hasTouchpad; // 0xC8
	
		// Properties
		public bool Tracked { get; private set; } // 0x00000001856C2D90-0x00000001856C2DF0 0x00000001856C2F10-0x00000001856C2F70
		public MouseButton DepressedButtons { get; private set; } // 0x00000001856C2C60-0x00000001856C2CC0 0x00000001856C2DF0-0x00000001856C2E50
		public Vector2 ScrollDelta { get; private set; } // 0x00000001856C2D20-0x00000001856C2D90 0x00000001856C2EB0-0x00000001856C2F10
		public string Name { get; private set; } // 0x00000001856C2CC0-0x00000001856C2D20 0x00000001856C2E50-0x00000001856C2EB0
	
		// Constructors
		public VRBrowserHand() {} // 0x00000001856C2BA0-0x00000001856C2C60
	
		// Methods
		public void OnEnable() {} // 0x00000001856C1B00-0x00000001856C1C60
		public void OnDisable() {} // 0x00000001856C1A10-0x00000001856C1B00
		public virtual void Update() {} // 0x00000001856C2B30-0x00000001856C2BA0
		protected virtual void ReadInput() {} // 0x00000001856C1C60-0x00000001856C1FE0
		protected virtual void ReadTouchpad() {} // 0x00000001856C2390-0x00000001856C26B0
		protected virtual void ReadJoystick() {} // 0x00000001856C1FE0-0x00000001856C2390
		private void UpdatePreCull(Camera cam) {} // 0x00000001856C26B0-0x00000001856C2B30
	}
}
