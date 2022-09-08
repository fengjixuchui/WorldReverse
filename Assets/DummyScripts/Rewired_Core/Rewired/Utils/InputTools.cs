/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data.Mapping;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x0000000189823DB0-0x0000000189823E00
	[CustomObfuscation] // 0x0000000189823DB0-0x0000000189823E00
	internal static class InputTools // TypeDefIndex: 4376
	{
		// Methods
		public static float TransformAxis2DComponentValue(float value, float zero, float min, float max) => default; // 0x00000001862E4830-0x00000001862E49B0
		public static float GetCalibratedAxisValueClamped(float value, float zero, float min, float max, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) => default; // 0x00000001862E3ED0-0x00000001862E4270
		public static float GetCalibratedAxisValue(float value, float deadZone, bool invert, bool applySensitivity, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) => default; // 0x00000001862E4270-0x00000001862E44C0
		public static Vector2 ApplyRadialDeadZone(float xValue, float yValue, float deadzone) => default; // 0x00000001862E35D0-0x00000001862E3750
		public static float ApplySensitivity(float value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) => default; // 0x00000001862E3AA0-0x00000001862E3CB0
		private static bool LVGLpLUSMJQnNnrJupUjKtKwGrX(AnimationCurve param_00009183) => default; // 0x00000001862E4710-0x00000001862E4830
		public static void ApplyRadialSensitivity(ref Vector2 value, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve) {} // 0x00000001862E3750-0x00000001862E3AA0
		public static string FormatHardwareIdentifierString(string str) => default; // 0x00000001862E3DD0-0x00000001862E3ED0
		public static AxisRange InvertAxisRange(AxisRange axisRange) => default; // 0x00000001862E45A0-0x00000001862E4650
		public static void CompareLastActiveController(Controller controller, ref Controller lastController, ref float lastTime) {} // 0x00000001862E3CB0-0x00000001862E3DD0
		public static bool IsMappableType(ControllerElementType type) => default; // 0x00000001862E46B0-0x00000001862E4710
		public static bool IsMappableType(ControllerTemplateElementType type) => default; // 0x00000001862E4650-0x00000001862E46B0
		public static bool HandleForced4WayHatsOnUnknownControllers(int direction, ref HatType hatType) => default; // 0x00000001862E44C0-0x00000001862E45A0
	}
}
