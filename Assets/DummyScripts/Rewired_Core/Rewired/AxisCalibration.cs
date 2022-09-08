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
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
	public sealed class AxisCalibration // TypeDefIndex: 4108
	{
		// Fields
		private AlternateAxisCalibrationType _calibrationMode; // 0x10
		private Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations; // 0x18
		[CustomObfuscation] // 0x0000000189643B80-0x0000000189643BE0
		[SerializeField] // 0x0000000189643B80-0x0000000189643BE0
		// [Tooltip] // 0x0000000189643B80-0x0000000189643BE0
		private bool _enabled; // 0x20
		[CustomObfuscation] // 0x0000000189652AE0-0x0000000189652B40
		[SerializeField] // 0x0000000189652AE0-0x0000000189652B40
		// [Tooltip] // 0x0000000189652AE0-0x0000000189652B40
		private float _deadZone; // 0x24
		[CustomObfuscation] // 0x0000000189643B80-0x0000000189643BE0
		[SerializeField] // 0x0000000189643B80-0x0000000189643BE0
		// [Tooltip] // 0x0000000189643B80-0x0000000189643BE0
		private float _calibratedZero; // 0x28
		[CustomObfuscation] // 0x000000018966D8D0-0x000000018966D930
		[SerializeField] // 0x000000018966D8D0-0x000000018966D930
		// [Tooltip] // 0x000000018966D8D0-0x000000018966D930
		private float _calibratedMin; // 0x2C
		[CustomObfuscation] // 0x000000018967CF30-0x000000018967CF90
		[SerializeField] // 0x000000018967CF30-0x000000018967CF90
		// [Tooltip] // 0x000000018967CF30-0x000000018967CF90
		private float _calibratedMax; // 0x30
		[CustomObfuscation] // 0x000000018968C160-0x000000018968C1C0
		[SerializeField] // 0x000000018968C160-0x000000018968C1C0
		// [Tooltip] // 0x000000018968C160-0x000000018968C1C0
		private bool _invert; // 0x34
		[CustomObfuscation] // 0x000000018969B070-0x000000018969B0D0
		[SerializeField] // 0x000000018969B070-0x000000018969B0D0
		// [Tooltip] // 0x000000018969B070-0x000000018969B0D0
		private AxisSensitivityType _sensitivityType; // 0x38
		[CustomObfuscation] // 0x00000001896A9E00-0x00000001896A9E80
		// [FieldRange] // 0x00000001896A9E00-0x00000001896A9E80
		[SerializeField] // 0x00000001896A9E00-0x00000001896A9E80
		// [Tooltip] // 0x00000001896A9E00-0x00000001896A9E80
		private float _sensitivity; // 0x3C
		[CustomObfuscation] // 0x00000001896BB600-0x00000001896BB660
		[SerializeField] // 0x00000001896BB600-0x00000001896BB660
		// [Tooltip] // 0x00000001896BB600-0x00000001896BB660
		private AnimationCurve _sensitivityCurve; // 0x40
		[CustomObfuscation] // 0x00000001896C9E90-0x00000001896C9EF0
		[SerializeField] // 0x00000001896C9E90-0x00000001896C9EF0
		// [Tooltip] // 0x00000001896C9E90-0x00000001896C9EF0
		private bool _applyRangeCalibration; // 0x48
	
		// Properties
		public bool enabled { get => default; set {} } // 0x0000000185A99370-0x0000000185A993D0 0x0000000185A997D0-0x0000000185A99830
		public float deadZone { get => default; set {} } // 0x0000000185A99300-0x0000000185A99370 0x0000000185A99750-0x0000000185A997D0
		public float calibratedZero { get => default; set {} } // 0x0000000185A99290-0x0000000185A99300 0x0000000185A99640-0x0000000185A996B0
		public float calibratedMin { get => default; set {} } // 0x0000000185A99220-0x0000000185A99290 0x0000000185A995D0-0x0000000185A99640
		public float calibratedMax { get => default; set {} } // 0x0000000185A991B0-0x0000000185A99220 0x0000000185A99560-0x0000000185A995D0
		public bool invert { get => default; set {} } // 0x0000000185A993D0-0x0000000185A99430 0x0000000185A99830-0x0000000185A99890
		public AxisSensitivityType sensitivityType { get => default; } // 0x0000000185A99490-0x0000000185A994F0 
		public float sensitivity { get => default; } // 0x0000000185A994F0-0x0000000185A99560 
		public AnimationCurve sensitivityCurve { get => default; } // 0x0000000185A99430-0x0000000185A99490 
		public bool applyRangeCalibration { get => default; } // 0x0000000185A99150-0x0000000185A991B0 
		internal AlternateAxisCalibrationType calibrationMode { set {} } // 0x0000000185A996B0-0x0000000185A99750
	
		// Constructors
		internal AxisCalibration() {} // 0x0000000185A98E00-0x0000000185A98F60
		internal AxisCalibration(bool enabled, Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, float deadZone, float calibratedZero, float calibratedMin, float calibratedMax, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) {} // 0x0000000185A98F60-0x0000000185A99150
		internal AxisCalibration(AxisCalibrationData hardwareData) {} // 0x0000000185A98CA0-0x0000000185A98E00
	
		// Methods
		public float GetCalibratedValue(float value) => default; // 0x0000000185A98160-0x0000000185A981F0
		internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion) => default; // 0x0000000185A981F0-0x0000000185A98360
		public float GetCalibratedValue(float value, AxisRange axisRange) => default; // 0x0000000185A980C0-0x0000000185A98160
		internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion) => default; // 0x0000000185A97EB0-0x0000000185A980C0
		public AxisCalibrationData GetData() => default; // 0x0000000185A98360-0x0000000185A98520
		public void Reset() {} // 0x0000000185A98AA0-0x0000000185A98CA0
		internal SerializedObject ExportData() => default; // 0x0000000185A97C30-0x0000000185A97EB0
		internal void Import(SerializedObject serializedObject) {} // 0x0000000185A98620-0x0000000185A98820
		private void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData) {} // 0x0000000185A98820-0x0000000185A98AA0
		private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData) {} // 0x0000000185A978F0-0x0000000185A97A00
		private AxisCalibrationInfo GetHardwareDefault() => default; // 0x0000000185A98520-0x0000000185A98620
		internal static AxisCalibration CreateRelative() => default; // 0x0000000185A97A00-0x0000000185A97C30
	}
}
