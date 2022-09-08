/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public class Joystick : ControllerWithAxes // TypeDefIndex: 3650
	{
		// Fields
		private const int LEFT_MOTOR_INDEX = 0; // Metadata: 0x00AC4111
		private const int RIGHT_MOTOR_INDEX = 1; // Metadata: 0x00AC4115
		private IInputManagerJoystickPublic _sourceJoystick; // 0x148
		private readonly JoystickType[] _joystickTypes; // 0x150
		private readonly ReadOnlyCollection<JoystickType> _joystickTypes_readOnly; // 0x158
		private readonly bool _supportsVibration; // 0x160
		private readonly bool _supportsLocalVibration; // 0x161
		private readonly bool _supportsVoice; // 0x162
		private readonly int _localVibrationMotorCount; // 0x164
		private readonly float[] _localVibrationMotorValues; // 0x168
		private readonly TimerAbs[] _localVibrationStopTimers; // 0x170
		private readonly int _hatCount; // 0x178
		private readonly Hat[] _hats; // 0x180
		private readonly ReadOnlyCollection<Hat> hats_readOnly; // 0x188
	
		// Properties
		public long? systemId { get => default; } // 0x00000001852F9250-0x00000001852F93F0 
		public int unityId { get => default; } // 0x00000001852F94C0-0x00000001852F95B0 
		public override Guid deviceInstanceGuid { get => default; } // 0x00000001852F8D00-0x00000001852F8EB0 
		public bool supportsVibration { get => default; } // 0x00000001852F9180-0x00000001852F9250 
		public int vibrationMotorCount { get => default; } // 0x00000001852F95B0-0x00000001852F96F0 
		public int hatCount { get => default; } // 0x00000001852F8FD0-0x00000001852F90A0 
		internal int inputManagerId { get => default; } // 0x00000001852F90A0-0x00000001852F9120 
		internal HardwareControllerMapIdentifier hardwareJoystickMapIdentifier { get => default; } // 0x00000001852F8F10-0x00000001852F8FD0 
	
		// Constructors
		public Joystick() {} // Dummy constructor
		internal Joystick(BridgedController controller) {} // 0x00000001852F82C0-0x00000001852F8B60
		private Joystick(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, Guid hardwareTypeGuid, int axisCount, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater) {} // 0x00000001852F7520-0x00000001852F7E40
	
		// Methods
		public JoystickCalibrationMapSaveData GetCalibrationMapSaveData() => default; // 0x00000001852F6570-0x00000001852F66E0
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) {} // 0x00000001852F6A60-0x00000001852F6B00
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) {} // 0x00000001852F6B00-0x00000001852F6D10
		public void StopVibration() {} // 0x00000001852F6D10-0x00000001852F6F60
		internal override void UpdateData(UpdateLoopType updateLoop) {} // 0x00000001852F7240-0x00000001852F73C0
		internal void UpdateControllerInfo(UpdateControllerInfoEventArgs args) {} // 0x00000001852F7000-0x00000001852F7080
		internal void UpdateControllerInfo(BridgedController controller) {} // 0x00000001852F6F60-0x00000001852F7000
		private void UpdateControllerInfo(IInputManagerJoystickPublic joystick) {} // 0x00000001852F7080-0x00000001852F7240
		internal override void Clear() {} // 0x00000001852F6130-0x00000001852F61A0
		protected override void Disconnected() {} // 0x00000001852F6280-0x00000001852F63E0
		private void CheckVibrationTimeout() {} // 0x00000001852F5FA0-0x00000001852F6130
		private void SetLocalVibration(int motorIndex, float motorLevel, float motorDuration, bool stopOtherMotors, bool updateNow) {} // 0x00000001852F66E0-0x00000001852F6A60
		private void UpdateLocalControllerVibration() {} // 0x00000001852F73C0-0x00000001852F7520
		internal static int CompareById_Ascending(Joystick a, Joystick b) => default; // 0x00000001852F61A0-0x00000001852F6280
	}
}
