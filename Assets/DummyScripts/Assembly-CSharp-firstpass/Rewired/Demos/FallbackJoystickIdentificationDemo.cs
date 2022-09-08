/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos
{
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public class FallbackJoystickIdentificationDemo : MonoBehaviour // TypeDefIndex: 9780
	{
		// Fields
		private const float windowWidth = 250f; // Metadata: 0x00AE62A2
		private const float windowHeight = 250f; // Metadata: 0x00AE62A6
		private const float inputDelay = 1f; // Metadata: 0x00AE62AA
		private bool identifyRequired; // 0x18
		private Queue<Joystick> joysticksToIdentify; // 0x20
		private float nextInputAllowedTime; // 0x28
		private GUIStyle style; // 0x30
	
		// Constructors
		public FallbackJoystickIdentificationDemo() {} // 0x000000018654E350-0x000000018654E3B0
	
		// Methods
		// [XID] // 0x0000000189B16E40-0x0000000189B16E60
		private void Awake() {} // 0x000000018654D800-0x000000018654D980
		// [XID] // 0x0000000189AD1030-0x0000000189AD1050
		private void JoystickConnected(ControllerStatusChangedEventArgs args) {} // 0x000000018654DDA0-0x000000018654DE50
		// [XID] // 0x0000000189B26050-0x0000000189B26070
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args) {} // 0x000000018654DE50-0x000000018654DF00
		// [XID] // 0x00000001899422C0-0x00000001899422E0
		public void IdentifyAllJoysticks() {} // 0x000000018654DC20-0x000000018654DDA0
		// [XID] // 0x000000018980B6A0-0x000000018980B6C0
		private void SetInputDelay() {} // 0x000000018654E2A0-0x000000018654E350
		// [XID] // 0x0000000189B3C090-0x0000000189B3C0B0
		private void OnGUI() {} // 0x000000018654DF00-0x000000018654E200
		// [XID] // 0x0000000189785300-0x0000000189785320
		private void DrawDialogWindow(int windowId) {} // 0x000000018654D980-0x000000018654DC20
		// [XID] // 0x0000000189B4B260-0x0000000189B4B280
		private void Reset() {} // 0x000000018654E200-0x000000018654E2A0
	}
}
