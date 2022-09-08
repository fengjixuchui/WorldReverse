/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Data.Mapping;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class HardwareJoystickMap_InputManager // TypeDefIndex: 4147
	{
		// Fields
		public string controllerName; // 0x10
		public readonly HardwareControllerMapIdentifier hardwareMapIdentifier; // 0x18
		public readonly HardwareJoystickMap.Platform map; // 0x38
		public readonly int buttonCount; // 0x40
		public readonly int axisCount; // 0x44
		public readonly ControllerElementIdentifier[] elementIdentifiers; // 0x48
		public readonly HardwareJoystickMap.CompoundElement[] compoundElements; // 0x50
		public bool useSystemName; // 0x58
		public readonly bool isUnknownController; // 0x59
		public readonly JoystickType[] joystickTypes; // 0x60
	
		// Constructors
		public HardwareJoystickMap_InputManager() {} // Dummy constructor
		public HardwareJoystickMap_InputManager(HardwareControllerMapIdentifier hardwareMapIdentifier, JoystickType[] joystickTypes, HardwareJoystickMap.Platform hardwarePlatformMap, string controllerName, int buttonCount, int axisCount, int elementIdentifierCount, HardwareJoystickMap.CompoundElement[] compoundElements) {} // 0x0000000185831E30-0x0000000185831F90
	
		// Methods
		public HardwareControllerMap_Game ToGameHardwareControllerMap() => default; // 0x0000000185831350-0x0000000185831E30
	}
}
