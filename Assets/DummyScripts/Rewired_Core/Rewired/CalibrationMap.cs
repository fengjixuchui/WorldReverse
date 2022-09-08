/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001899D6C00-0x00000001899D6C30
	public sealed class CalibrationMap // TypeDefIndex: 4107
	{
		// Fields
		private AxisCalibration[] PbFORHCAibynPVwQMVeRWSjVVbJ; // 0x10
		private IList<AxisCalibration> bErbZdGrOSfEhkpkfbRJQtnforXI; // 0x18
		private readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x20
	
		// Properties
		public IList<AxisCalibration> Axes { get => default; } // 0x0000000185A9C980-0x0000000185A9C9E0 
		public int axisCount { get => default; } // 0x0000000185A9C9E0-0x0000000185A9CA50 
	
		// Constructors
		private CalibrationMap() {} // 0x0000000185A9C710-0x0000000185A9C7A0
		internal CalibrationMap(AxisCalibrationData[] hardwareAxisCalibrationData) {} // 0x0000000185A9C7A0-0x0000000185A9C980
	
		// Methods
		public AxisCalibration GetAxis(int index) => default; // 0x0000000185A9C160-0x0000000185A9C290
		public string ToXmlString() => default; // 0x0000000185A9C540-0x0000000185A9C710
		public bool ImportXmlString(string xmlString) => default; // 0x0000000185A9C370-0x0000000185A9C540
		private SerializedObject wGWQXZtIQyRkZMrIKWqTSlWZlQY() => default; // 0x0000000185A9CA50-0x0000000185A9D160
		private void DzhGtommJNlpRFKUAFaKGOCHKTz(SerializedObject param_000088e4) {} // 0x0000000185A9BE80-0x0000000185A9C160
		internal Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType) => default; // 0x0000000185A9C290-0x0000000185A9C370
	}
}
