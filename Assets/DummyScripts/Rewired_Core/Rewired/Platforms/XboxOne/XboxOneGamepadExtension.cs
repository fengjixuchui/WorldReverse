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

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Platforms.XboxOne
{
	public sealed class XboxOneGamepadExtension : Controller.Extension, IControllerVibrator // TypeDefIndex: 4422
	{
		// Fields
		private QoxnqedNaRRwbtmYzpLCDBISzMH WVeuvvGVKxuwIVofyhIJOpLcDjb; // 0x28
		private TimerAbs[] pSngNFXjFJqIDusOVrrEyDkmFgW; // 0x30
	
		// Properties
		private Joystick joystick { get => default; } // 0x0000000185BEBB60-0x0000000185BEBBD0 
		public ulong xboxOneJoystickId { get => default; } // 0x0000000185BEBC90-0x0000000185BEBE40 
		public int vibrationMotorCount { get => default; } // 0x0000000185BEBBD0-0x0000000185BEBC90 
	
		// Nested types
		private class QoxnqedNaRRwbtmYzpLCDBISzMH : IControllerExtensionSource // TypeDefIndex: 4423
		{
			// Fields
			public lSVDqDVnIqWqaQvJeLzQNKaiGHr NdFdLJgqEkQANUgOMbcjvMhqVCpT; // 0x10
			public readonly IXboxOneInputSource xtEqWpphJfrugPgKOKqLznSjqto; // 0x28
			public readonly bool wweKDPecOEKQRjeLwREKUOeenHA; // 0x30
	
			// Constructors
			public QoxnqedNaRRwbtmYzpLCDBISzMH() {} // Dummy constructor
			public QoxnqedNaRRwbtmYzpLCDBISzMH(bool supportsVibration, IXboxOneInputSource xboxOneInputSource, lSVDqDVnIqWqaQvJeLzQNKaiGHr vibrationData) {} // 0x0000000185BE7B90-0x0000000185BE7C20
		}
	
		// Constructors
		public XboxOneGamepadExtension() {} // Dummy constructor
		internal XboxOneGamepadExtension(bool supportsVibration, IXboxOneInputSource xboxOneInputSource) {} // 0x0000000185BEB990-0x0000000185BEBB60
		private XboxOneGamepadExtension(XboxOneGamepadExtension source) {} // 0x0000000185BEB8D0-0x0000000185BEB990
	
		// Methods
		public void SetVibration(int motorIndex, float motorLevel, float duration) {} // 0x0000000185BEAEF0-0x0000000185BEAF90
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) {} // 0x0000000185BEB540-0x0000000185BEB5E0
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) {} // 0x0000000185BEB300-0x0000000185BEB540
		public void StopVibration() {} // 0x0000000185BEB690-0x0000000185BEB870
		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors) {} // 0x0000000185BEAF90-0x0000000185BEB300
		internal override void UpdateData(UpdateLoopType param_00009338) {} // 0x0000000185BEB870-0x0000000185BEB8D0
		internal override void SourceUpdated(IControllerExtensionSource param_00009339) {} // 0x0000000185BEB5E0-0x0000000185BEB690
		internal override Controller.Extension Clone() => default; // 0x0000000185BEAAF0-0x0000000185BEAB70
		private void qxBgmSGduLZblrclmRJKaMoDcVOA() {} // 0x0000000185BEBE40-0x0000000185BEBFB0
		private void PkvIixiBJQgzJxQXdAWDrKLgpHX(XboxOneGamepadMotorType param_0000933a, float param_0000933b, float param_0000933c) {} // 0x0000000185BEACE0-0x0000000185BEAEF0
		private void JTAhuXWSuaNKiVjtBONLbjGlAMIj() {} // 0x0000000185BEAB70-0x0000000185BEACE0
	}
}
