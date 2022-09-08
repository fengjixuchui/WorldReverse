/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	[CustomObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	internal interface IPS4ControllerExtensionSourceVibrator // TypeDefIndex: 4224
	{
		// Properties
		bool supportsVibration { get; }
		int vibrationMotorCount { get; }
	
		// Methods
		void SetVibration(int motorIndex, float value);
		void StopVibration();
	}
}
