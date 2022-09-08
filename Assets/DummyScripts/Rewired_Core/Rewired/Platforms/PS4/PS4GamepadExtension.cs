/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ControllerExtensions;
using Rewired.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Platforms.PS4
{
	public sealed class PS4GamepadExtension : PS4ControllerExtension, IDualShock4Extension // TypeDefIndex: 4231
	{
		// Properties
		private new IPS4GamepadExtensionSource Source { get => default; } // 0x0000000185305340-0x0000000185305450 
		public int maxTouches { get => default; } // 0x0000000185305450-0x0000000185305540 
	
		// Constructors
		public PS4GamepadExtension() {} // Dummy constructor
		internal PS4GamepadExtension(IPS4GamepadExtensionSource source) {} // 0x0000000185305240-0x00000001853052C0
		private PS4GamepadExtension(PS4GamepadExtension source) {} // 0x00000001853052C0-0x0000000185305340
	
		// Methods
		public int GetTouchId(int index) => default; // 0x0000000185304E00-0x0000000185304F00
		public bool GetTouchPosition(int index, out Vector2 position) {
			position = default;
			return default;
		} // 0x0000000185304F00-0x0000000185305040
		public bool IsTouching(int index) => default; // 0x0000000185305140-0x0000000185305240
		public bool IsTouchingByTouchId(int touchId) => default; // 0x0000000185305040-0x0000000185305140
		internal override Controller.Extension Clone() => default; // 0x0000000185304D40-0x0000000185304E00
	}
}
