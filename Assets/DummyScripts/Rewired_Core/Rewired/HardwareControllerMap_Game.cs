/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal class HardwareControllerMap_Game // TypeDefIndex: 4146
	{
		// Fields
		public readonly string controllerName; // 0x10
		public readonly HardwareControllerMapIdentifier hardwareMapIdentifier; // 0x18
		public readonly int customControllerSourceId; // 0x34
		public readonly ADictionary<int, ControllerElementIdentifier> elementIdentifiers; // 0x38
		public readonly ControllerElementIdentifier[] elementIdentifiers_cache; // 0x40
		public readonly ControllerElementIdentifier[] buttonElementIdentifiers_cache; // 0x48
		public readonly ControllerElementIdentifier[] axisElementIdentifiers_cache; // 0x50
		public readonly ControllerElementIdentifier[] axis2DElementIdentifiers_cache; // 0x58
		public readonly ControllerElementIdentifier[] hatElementIdentifiers_cache; // 0x60
		public readonly IList<ControllerElementIdentifier> elementIdentifiers_readOnly; // 0x68
		public readonly IList<ControllerElementIdentifier> buttonElementIdentifiers_readOnly; // 0x70
		public readonly IList<ControllerElementIdentifier> axisElementIdentifiers_readOnly; // 0x78
		public readonly IList<ControllerElementIdentifier> axis2DElementIdentifiers_readOnly; // 0x80
		public readonly IList<ControllerElementIdentifier> hatElementIdentifiers_readOnly; // 0x88
		public readonly int[] buttonElementIdentifierIds; // 0x90
		public readonly int[] axisElementIdentifierIds; // 0x98
		public readonly int[] axis2DElementIdentifierIds; // 0xA0
		public readonly int[] hatElementIdentifierIds; // 0xA8
		public readonly int elementIdentifierCount; // 0xB0
		public readonly int axisCount; // 0xB4
		public readonly int buttonCount; // 0xB8
		public readonly int compoundElementCount; // 0xBC
		public readonly int axis2DCount; // 0xC0
		public readonly int hatCount; // 0xC4
		public readonly JoystickType[] joystickTypes; // 0xC8
		public readonly AxisCalibrationData[] hwAxisCalibrationData; // 0xD0
		public readonly AxisRange[] hwAxisRanges; // 0xD8
		public readonly HardwareAxisInfo[] hwAxisInfo; // 0xE0
		public readonly HardwareButtonInfo[] hwButtonInfo; // 0xE8
		public readonly HardwareJoystickMap.CompoundElement[] compoundElements; // 0xF0
	
		// Constructors
		public HardwareControllerMap_Game() {} // Dummy constructor
		private HardwareControllerMap_Game(string controllerName) {} // 0x000000018582FFE0-0x0000000185830050
		public HardwareControllerMap_Game(string controllerName, int customControllerSourceId, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements) {} // 0x0000000185830190-0x0000000185830280
		public HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, JoystickType[] joystickTypes, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements) {} // 0x0000000185830050-0x0000000185830190
		public HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements) {} // 0x00000001858311D0-0x0000000185831350
		private HardwareControllerMap_Game(string controllerName, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements) {} // 0x0000000185830280-0x00000001858311D0
	
		// Methods
		public string GetElementIdentifierName(int elementIdentifierId) => default; // 0x000000018582FA00-0x000000018582FB00
		public string GetElementIdentifierPositiveName(int elementIdentifierId) => default; // 0x000000018582FC00-0x000000018582FD00
		public string GetElementIdentifierNegativeName(int elementIdentifierId) => default; // 0x000000018582FB00-0x000000018582FC00
		public int GetAxisIndex(int elementIdentifierId) => default; // 0x000000018582F6E0-0x000000018582F7C0
		public int GetButtonIndex(int elementIdentifierId) => default; // 0x000000018582F7C0-0x000000018582F8A0
		public ControllerElementIdentifier GetElementIdentifierById(int id) => default; // 0x000000018582F8A0-0x000000018582FA00
		public HardwareJoystickMap.CompoundElement GetAxis2DData(int index) => default; // 0x000000018582F530-0x000000018582F6E0
		public HardwareJoystickMap.CompoundElement GetHatData(int index) => default; // 0x000000018582FD00-0x000000018582FED0
		private int JJqmxHxPKYaPbztuToXPTZiExSg(ControllerElementIdentifier[] param_00008ab2, int param_00008ab3) => default; // 0x000000018582FED0-0x000000018582FFE0
	}
}
