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

namespace Rewired.Drivers.Interfaces
{
	[CustomClassObfuscation] // 0x0000000189658AB0-0x0000000189658B00
	[CustomObfuscation] // 0x0000000189658AB0-0x0000000189658B00
	internal interface IDriver_DualShock4 : IControllerDriver // TypeDefIndex: 4014
	{
		// Properties
		float LeftMotor { get; set; }
		float RightMotor { get; set; }
		float LightColorR { get; set; }
		float LightColorG { get; set; }
		float LightColorB { get; set; }
		float LightFlashOnDuration { get; set; }
		float LightFlashOffDuration { get; set; }
		Vector3 AccelerometerValue { get; }
		Quaternion Orientation { get; }
		int MaxTouches { get; }
	
		// Methods
		void ResetOrientation();
		bool IsTouchingAtTouchId(int touchId);
		bool IsTouchingAtIndex(int index);
		int GetTouchIdAtIndex(int index);
		bool GetTouchPositionByIndex(int index, out Vector2 position);
		void StopLightFlash();
		void StopVibration();
	}
}
