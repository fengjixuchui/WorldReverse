/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data.Mapping
{
	[Serializable]
	public class AxisCalibrationInfo : IDeepCloneable // TypeDefIndex: 3945
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _applyRangeCalibration; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _invert; // 0x11
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _deadZone; // 0x14
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _zero; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _min; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _max; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AxisSensitivityType _sensitivityType; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _sensitivity; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AnimationCurve _sensitivityCurve; // 0x30
	
		// Properties
		public bool applyRangeCalibration { get => default; } // 0x00000001869B28B0-0x00000001869B2910 
		public bool invert { get => default; } // 0x00000001869B2980-0x00000001869B29E0 
		public float deadZone { get => default; } // 0x00000001869B2910-0x00000001869B2980 
		public float zero { get => default; } // 0x00000001869B2BF0-0x00000001869B2C60 
		public float min { get => default; } // 0x00000001869B2A50-0x00000001869B2AC0 
		public float max { get => default; } // 0x00000001869B29E0-0x00000001869B2A50 
		public AxisSensitivityType sensitivityType { get => default; } // 0x00000001869B2B20-0x00000001869B2B80 
		public float sensitivity { get => default; } // 0x00000001869B2B80-0x00000001869B2BF0 
		public AnimationCurve sensitivityCurve { get => default; } // 0x00000001869B2AC0-0x00000001869B2B20 
	
		// Constructors
		public AxisCalibrationInfo() {} // 0x00000001869B2720-0x00000001869B2790
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal AxisCalibrationInfo(float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) {} // 0x00000001869B2790-0x00000001869B28B0
	
		// Methods
		public object DeepClone() => default; // 0x00000001869B25C0-0x00000001869B2720
		internal static AxisCalibrationInfo BNYbzazGtsWWlyXpclpCOdPuKOD(AxisCalibrationData param_000084c0) => default; // 0x00000001869B2490-0x00000001869B25C0
	}
}
