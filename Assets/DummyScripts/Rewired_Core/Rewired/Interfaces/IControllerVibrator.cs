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

namespace Rewired.Interfaces
{
	[CustomClassObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	[CustomObfuscation] // 0x00000001896B9DB0-0x00000001896B9E00
	public interface IControllerVibrator // TypeDefIndex: 3642
	{
		// Properties
		int vibrationMotorCount { get; }
	
		// Methods
		void SetVibration(int motorIndex, float motorLevel, float duration);
		void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors);
		void StopVibration();
	}
}
