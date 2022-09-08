/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Drivers.Interfaces;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ControllerExtensions
{
	public sealed class DualShock4Extension : Controller.Extension, IDualShock4Extension // TypeDefIndex: 3644
	{
		// Fields
		private KrXnTiadYcUSOCDdyHYMgnVlgaq PESlCqcuFEdCgwfIyyIoKbUwani; // 0x28
		private bool jTKQutBMGFjJXeKoLKVbSPcEzifU; // 0x30
		private TimerAbs[] pSngNFXjFJqIDusOVrrEyDkmFgW; // 0x38
	
		// Properties
		public int vibrationMotorCount { get => default; } // 0x0000000185E87E40-0x0000000185E87F20 
		public int maxTouches { get => default; } // 0x0000000185E87D40-0x0000000185E87E40 
	
		// Nested types
		private class KrXnTiadYcUSOCDdyHYMgnVlgaq : IControllerExtensionSource // TypeDefIndex: 3645
		{
			// Fields
			public readonly IDriver_DualShock4 rLHrbkzJrdcRLAiOSFvKCmkcJdEM; // 0x10
			public readonly bool wweKDPecOEKQRjeLwREKUOeenHA; // 0x18
			public readonly int dFeMnzRTSNcMYNGuAWZUeFGTLNj; // 0x1C
	
			// Constructors
			public KrXnTiadYcUSOCDdyHYMgnVlgaq() {} // Dummy constructor
			public KrXnTiadYcUSOCDdyHYMgnVlgaq(IDriver_DualShock4 driver, bool supportsVibration, int vibrationMotorCount) {} // 0x0000000185E8B420-0x0000000185E8B4B0
		}
	
		// Constructors
		public DualShock4Extension() {} // Dummy constructor
		internal DualShock4Extension(IDriver_DualShock4 driver) {} // 0x0000000185E87C00-0x0000000185E87D40
		private DualShock4Extension(DualShock4Extension source) {} // 0x0000000185E87B00-0x0000000185E87C00
	
		// Methods
		public void SetVibration(int motorIndex, float motorLevel, float duration) {} // 0x0000000185E87120-0x0000000185E871C0
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) {} // 0x0000000185E87080-0x0000000185E87120
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) {} // 0x0000000185E86DE0-0x0000000185E87080
		public void StopVibration() {} // 0x0000000185E877C0-0x0000000185E87A80
		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors) {} // 0x0000000185E871C0-0x0000000185E875B0
		public void SetLightColor(Color color) {} // 0x0000000185E86A20-0x0000000185E86C00
		public void SetLightFlash(float onDuration, float offDuration) {} // 0x0000000185E86C00-0x0000000185E86DE0
		public void StopLightFlash() {} // 0x0000000185E87670-0x0000000185E877C0
		public Vector3 GetAccelerometerValue() => default; // 0x0000000185E85BA0-0x0000000185E85E30
		public Quaternion GetOrientation() => default; // 0x0000000185E85E30-0x0000000185E86010
		public void ResetOrientation() {} // 0x0000000185E86870-0x0000000185E86A20
		public int GetTouchId(int index) => default; // 0x0000000185E86010-0x0000000185E86190
		public bool GetTouchPosition(int index, out Vector2 position) {
			position = default;
			return default;
		} // 0x0000000185E86190-0x0000000185E86350
		public bool IsTouching(int index) => default; // 0x0000000185E864B0-0x0000000185E86680
		public bool IsTouchingByTouchId(int touchId) => default; // 0x0000000185E86350-0x0000000185E864B0
		internal override void UpdateData(UpdateLoopType param_0000804f) {} // 0x0000000185E87A80-0x0000000185E87B00
		internal override void SourceUpdated(IControllerExtensionSource param_00008050) {} // 0x0000000185E875B0-0x0000000185E87670
		internal override Controller.Extension Clone() => default; // 0x0000000185E85B20-0x0000000185E85BA0
		private void qxBgmSGduLZblrclmRJKaMoDcVOA() {} // 0x0000000185E87F20-0x0000000185E88090
		private void PkvIixiBJQgzJxQXdAWDrKLgpHX(DualShock4MotorType param_00008051, float param_00008052, float param_00008053) {} // 0x0000000185E86680-0x0000000185E86870
	}
}
