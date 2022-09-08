/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ControllerExtensions
{
	public interface IDualShock4Extension : IControllerVibrator // TypeDefIndex: 3643
	{
		// Properties
		int maxTouches { get; }
	
		// Methods
		Vector3 GetAccelerometerValue();
		Quaternion GetOrientation();
		void ResetOrientation();
		void SetLightColor(Color color);
		int GetTouchId(int index);
		bool GetTouchPosition(int index, out Vector2 position);
		bool IsTouching(int index);
		bool IsTouchingByTouchId(int touchId);
	}
}
