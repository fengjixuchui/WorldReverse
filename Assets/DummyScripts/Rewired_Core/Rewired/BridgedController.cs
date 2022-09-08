/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using Rewired.Platforms.Custom;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class BridgedController : BridgedControllerHWInfo // TypeDefIndex: 4018
	{
		// Fields
		public IInputManagerJoystickPublic sourceJoystick; // 0xB8
		public HardwareControllerMap_Game gameHardwareMap; // 0xC0
		public Guid controllerTypeGuid; // 0xC8
		public Controller.Extension controllerExtension; // 0xD8
		public string instanceName; // 0xE0
		public string productName; // 0xE8
		public bool isXInputDevice; // 0xF0
		public int axisCount; // 0xF4
		public int buttonCount; // 0xF8
		public bool[] isButtonPressureSensitive; // 0x100
		public UnknownControllerHat[] unknownControllerHats; // 0x108
		public CustomInputSource customInputSource; // 0x110
	
		// Constructors
		public BridgedController() {} // 0x0000000185A99B50-0x0000000185A99BF0
	}
}
