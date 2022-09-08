/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	[CustomObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	internal interface IPS4ControllerExtensionSourceTouchPad // TypeDefIndex: 4227
	{
		// Properties
		int maxTouches { get; }
	
		// Methods
		int GetTouchId(int index);
		bool GetTouchPositionByIndex(int index, out Vector2 position);
		bool IsTouchingByIndex(int index);
		bool IsTouchingByTouchId(int touchId);
	}
}
