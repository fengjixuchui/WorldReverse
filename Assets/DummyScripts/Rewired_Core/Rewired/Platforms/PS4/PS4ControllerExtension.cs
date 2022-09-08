/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Platforms.PS4
{
	public class PS4ControllerExtension : Controller.Extension, IControllerVibrator // TypeDefIndex: 4229
	{
		// Fields
		private readonly TimerAbs[] pSngNFXjFJqIDusOVrrEyDkmFgW; // 0x28
	
		// Properties
		private IPS4ControllerExtensionSource Source { get => default; } // 0x0000000185304990-0x0000000185304A90 
		public int vibrationMotorCount { get => default; } // 0x0000000185304A90-0x0000000185304B80 
	
		// Nested types
		internal class IpBevHdFLSGMfSpPencGlqkvcLP : IControllerExtensionSource // TypeDefIndex: 4230
		{
			// Fields
			public readonly IPS4ControllerExtensionSource WVeuvvGVKxuwIVofyhIJOpLcDjb; // 0x10
	
			// Constructors
			public IpBevHdFLSGMfSpPencGlqkvcLP() {} // Dummy constructor
			public IpBevHdFLSGMfSpPencGlqkvcLP(IPS4ControllerExtensionSource source) {} // 0x00000001852F5BB0-0x00000001852F5C60
		}
	
		// Constructors
		public PS4ControllerExtension() {} // Dummy constructor
		internal PS4ControllerExtension(IPS4ControllerExtensionSource source) {} // 0x0000000185304890-0x0000000185304990
		protected PS4ControllerExtension(PS4ControllerExtension source) {} // 0x0000000185304790-0x0000000185304890
	
		// Methods
		public void SetVibration(int motorIndex, float motorLevel, float duration) {} // 0x0000000185304400-0x00000001853044A0
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) {} // 0x0000000185304010-0x00000001853040B0
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) {} // 0x00000001853040B0-0x0000000185304400
		public void StopVibration() {} // 0x00000001853044F0-0x0000000185304730
		public Vector3 GetAccelerometerValue() => default; // 0x0000000185303510-0x00000001853036D0
		public Quaternion GetOrientation() => default; // 0x00000001853036D0-0x0000000185303880
		public void ResetOrientation() {} // 0x0000000185303A30-0x0000000185303B20
		public void SetLightColor(Color color) {} // 0x0000000185303F10-0x0000000185304010
		public void SetLightColor(float red, float green, float blue, float intensity) {} // 0x0000000185303B20-0x0000000185303F10
		internal override void UpdateData(UpdateLoopType param_00008ce8) {} // 0x0000000185304730-0x0000000185304790
		internal override void SourceUpdated(IControllerExtensionSource param_00008ce9) {} // 0x00000001853044A0-0x00000001853044F0
		internal override Controller.Extension Clone() => default; // 0x0000000185303490-0x0000000185303510
		private void qxBgmSGduLZblrclmRJKaMoDcVOA() {} // 0x0000000185304B80-0x0000000185304D40
		private void PkvIixiBJQgzJxQXdAWDrKLgpHX(int param_00008cea, float param_00008ceb, float param_00008cec) {} // 0x0000000185303880-0x0000000185303A30
	}
}
