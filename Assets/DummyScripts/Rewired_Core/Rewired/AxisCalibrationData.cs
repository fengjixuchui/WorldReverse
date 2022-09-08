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
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public struct AxisCalibrationData // TypeDefIndex: 4109
	{
		// Fields
		public bool enabled; // 0x00
		public float deadZone; // 0x04
		public float zero; // 0x08
		public float min; // 0x0C
		public float max; // 0x10
		public bool invert; // 0x14
		public AxisSensitivityType sensitivityType; // 0x18
		public float sensitivity; // 0x1C
		public AnimationCurve sensitivityCurve; // 0x20
		public bool applyRangeCalibration; // 0x28
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal Dictionary<int, AxisCalibrationInfo> calibrations; // 0x30
	
		// Properties
		public static AxisCalibrationData Default { get => default; } // 0x0000000185A97550-0x0000000185A97710 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static AxisCalibrationData Raw { get => default; } // 0x0000000185A97710-0x0000000185A978F0 
	
		// Constructors
		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) : this() {
			this.enabled = default;
			this.deadZone = default;
			this.zero = default;
			this.min = default;
			this.max = default;
			this.invert = default;
			this.sensitivityType = default;
			this.sensitivity = default;
			this.sensitivityCurve = default;
			this.applyRangeCalibration = default;
			calibrations = default;
		} // 0x0000000185A97530-0x0000000185A97550
	}
}
