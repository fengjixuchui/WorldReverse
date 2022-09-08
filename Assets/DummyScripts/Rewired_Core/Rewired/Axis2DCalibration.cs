/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
	public sealed class Axis2DCalibration // TypeDefIndex: 4110
	{
		// Fields
		[CustomObfuscation] // 0x00000001896EEE70-0x00000001896EEED0
		[SerializeField] // 0x00000001896EEE70-0x00000001896EEED0
		// [Tooltip] // 0x00000001896EEE70-0x00000001896EEED0
		private DeadZone2DType _deadZoneType; // 0x10
		[CustomObfuscation] // 0x00000001896FE080-0x00000001896FE0E0
		[SerializeField] // 0x00000001896FE080-0x00000001896FE0E0
		// [Tooltip] // 0x00000001896FE080-0x00000001896FE0E0
		private AxisSensitivity2DType _sensitivityType; // 0x14
	
		// Properties
		public DeadZone2DType deadZoneType { set {} } // 0x0000000185A97380-0x0000000185A973E0
		public AxisSensitivity2DType sensitivityType { set {} } // 0x0000000185A973E0-0x0000000185A97530
	
		// Constructors
		internal Axis2DCalibration() {} // 0x0000000185A97310-0x0000000185A97380
	
		// Methods
		internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis) => default; // 0x0000000185A96410-0x0000000185A964E0
		internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType) => default; // 0x0000000185A964E0-0x0000000185A97310
	}
}
