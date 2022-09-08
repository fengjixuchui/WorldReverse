/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Utils
{
	// [EditorBrowsable] // 0x00000001897918D0-0x00000001897918F0
	public class ExternalTools : IExternalTools // TypeDefIndex: 9836
	{
		// Fields
		private bool _isEditorPaused; // 0x10
		private Action<bool> _EditorPausedStateChangedEvent; // 0x18
	
		// Properties
		public bool isEditorPaused { /* [XID] */ /* 0x00000001895FF390-0x00000001895FF3B0 */ get => default; } // 0x0000000187344B40-0x0000000187344BE0 
		public bool UnityInput_IsTouchPressureSupported { /* [XID] */ /* 0x00000001896FA030-0x00000001896FA050 */ get => default; } // 0x0000000187344A70-0x0000000187344B40 
	
		// Events
		public event Action<bool> EditorPausedStateChangedEvent;
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange;
	
		// Constructors
		public ExternalTools() {} // 0x0000000187344810-0x0000000187344870
	
		// Methods
		// [XID] // 0x0000000189A71950-0x0000000189A71970
		public void Destroy() {} // 0x0000000187341F70-0x0000000187342010
		// [XID] // 0x0000000189A8FEF0-0x0000000189A8FF10
		public object GetPlatformInitializer() => default; // 0x0000000187342420-0x00000001873424D0
		// [XID] // 0x0000000189A97690-0x0000000189A976B0
		public string GetFocusedEditorWindowTitle() => default; // 0x0000000187342350-0x0000000187342420
		// [XID] // 0x0000000189818A50-0x0000000189818A70
		public bool IsEditorSceneViewFocused() => default; // 0x00000001873424D0-0x0000000187342570
		// [XID] // 0x00000001898580C0-0x00000001898580E0
		public bool LinuxInput_IsJoystickPreconfigured(string name) => default; // 0x0000000187342570-0x0000000187342620
		// [XID] // 0x0000000189ABCE30-0x0000000189ABCE50
		public int XboxOneInput_GetUserIdForGamepad(uint id) => default; // 0x0000000187344420-0x00000001873444D0
		// [XID] // 0x0000000189AC4750-0x0000000189AC4770
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId) => default; // 0x00000001873441E0-0x0000000187344290
		// [XID] // 0x0000000189606C40-0x0000000189606C60
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId) => default; // 0x00000001873444D0-0x0000000187344580
		// [XID] // 0x0000000189AD37D0-0x0000000189AD37F0
		public string XboxOneInput_GetControllerType(ulong xboxControllerId) => default; // 0x0000000187344290-0x0000000187344370
		// [XID] // 0x0000000189ADB2B0-0x0000000189ADB2D0
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId) => default; // 0x0000000187344370-0x0000000187344420
		// [XID] // 0x0000000189AE2B20-0x0000000189AE2B40
		public void XboxOne_Gamepad_UpdatePlugin() {} // 0x0000000187344770-0x0000000187344810
		// [XID] // 0x0000000189AEA590-0x0000000189AEA5B0
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel) => default; // 0x0000000187344670-0x0000000187344770
		// [XID] // 0x00000001899CB850-0x00000001899CB870
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS) {} // 0x0000000187344580-0x0000000187344670
		// [XID] // 0x00000001898F0180-0x00000001898F01A0
		public Vector3 PS4Input_GetLastAcceleration(int id) => default; // 0x0000000187342780-0x00000001873428A0
		// [XID] // 0x0000000189B66FA0-0x0000000189B66FC0
		public Vector3 PS4Input_GetLastGyro(int id) => default; // 0x00000001873428A0-0x00000001873429C0
		// [XID] // 0x0000000189B083C0-0x0000000189B083E0
		public Vector4 PS4Input_GetLastOrientation(int id) => default; // 0x0000000187342C20-0x0000000187342D30
		// [XID] // 0x0000000189B0FCD0-0x0000000189B0FCF0
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id) {
			touchNum = default;
			touch0x = default;
			touch0y = default;
			touch0id = default;
			touch1x = default;
			touch1y = default;
			touch1id = default;
		} // 0x0000000187342D30-0x0000000187342E80
		// [XID] // 0x0000000189B16E00-0x0000000189B16E20
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType) {
			touchpixelDensity = default;
			touchResolutionX = default;
			touchResolutionY = default;
			analogDeadZoneLeft = default;
			analogDeadZoneright = default;
			connectionType = default;
		} // 0x0000000187342E80-0x0000000187342FB0
		// [XID] // 0x000000018982D520-0x000000018982D540
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable) {} // 0x0000000187343A60-0x0000000187343B20
		// [XID] // 0x0000000189B26010-0x0000000189B26030
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable) {} // 0x0000000187343B20-0x0000000187343BE0
		// [XID] // 0x000000018988C720-0x000000018988C740
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable) {} // 0x00000001873438C0-0x0000000187343980
		// [XID] // 0x0000000189B34810-0x0000000189B34830
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue) {} // 0x0000000187343980-0x0000000187343A60
		// [XID] // 0x0000000189B26D80-0x0000000189B26DA0
		public void PS4Input_PadResetLightBar(int id) {} // 0x0000000187343760-0x0000000187343810
		// [XID] // 0x0000000189B43C90-0x0000000189B43CB0
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor) {} // 0x0000000187343BE0-0x0000000187343CB0
		// [XID] // 0x0000000189B4B220-0x0000000189B4B240
		public void PS4Input_PadResetOrientation(int id) {} // 0x0000000187343810-0x00000001873438C0
		// [XID] // 0x0000000189B52A70-0x0000000189B52A90
		public bool PS4Input_PadIsConnected(int id) => default; // 0x00000001873436B0-0x0000000187343760
		// [XID] // 0x00000001896838B0-0x00000001896838D0
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser) {} // 0x0000000187342FB0-0x0000000187343070
		// [XID] // 0x000000018991BCA0-0x000000018991BCC0
		public int PS4Input_GetDeviceClassForHandle(int handle) => default; // 0x0000000187342620-0x00000001873426D0
		// [XID] // 0x0000000189B3B450-0x0000000189B3B470
		public string PS4Input_GetDeviceClassString(int intValue) => default; // 0x00000001873426D0-0x0000000187342780
		// [XID] // 0x0000000189B42CD0-0x0000000189B42CF0
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles) => default; // 0x00000001873435E0-0x00000001873436B0
		// [XID] // 0x0000000189A76BA0-0x0000000189A76BC0
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index) => default; // 0x00000001873429C0-0x0000000187342AF0
		// [XID] // 0x00000001899C40A0-0x00000001899C40C0
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index) => default; // 0x0000000187342AF0-0x0000000187342C20
		// [XID] // 0x00000001899D2D10-0x00000001899D2D30
		public int PS4Input_MoveGetButtons(int id, int index) => default; // 0x0000000187343140-0x0000000187343210
		// [XID] // 0x0000000189867D70-0x0000000189867D90
		public int PS4Input_MoveGetAnalogButton(int id, int index) => default; // 0x0000000187343070-0x0000000187343140
		// [XID] // 0x0000000189B957A0-0x0000000189B957C0
		public bool PS4Input_MoveIsConnected(int id, int index) => default; // 0x0000000187343510-0x00000001873435E0
		// [IDTag] // 0x0000000189B9CC50-0x0000000189B9CC90
		// [XID] // 0x0000000189B9CC50-0x0000000189B9CC90
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles) => default; // 0x00000001873432B0-0x0000000187343390
		// [IDTag] // 0x0000000189BA7490-0x0000000189BA74D0
		// [XID] // 0x0000000189BA7490-0x0000000189BA74D0
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles) => default; // 0x0000000187343390-0x0000000187343460
		// [IDTag] // 0x0000000189BB1A40-0x0000000189BB1A80
		// [XID] // 0x0000000189BB1A40-0x0000000189BB1A80
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers) => default; // 0x0000000187343460-0x0000000187343510
		// [XID] // 0x0000000189BBBE60-0x0000000189BBBE80
		public IntPtr PS4Input_MoveGetControllerInputForTracking() => default; // 0x0000000187343210-0x00000001873432B0
		// [XID] // 0x0000000189689390-0x00000001896893B0
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids) {
			vids = default;
			pids = default;
		} // 0x0000000187342250-0x0000000187342350
		// [XID] // 0x0000000189BCB460-0x0000000189BCB480
		public int GetAndroidAPILevel() => default; // 0x0000000187342010-0x00000001873420B0
		// [XID] // 0x0000000189BD29F0-0x0000000189BD2A10
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic) => default; // 0x0000000187343E30-0x0000000187344000
		// [XID] // 0x0000000189744990-0x00000001897449B0
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value) {} // 0x0000000187344000-0x00000001873441E0
		// [XID] // 0x00000001895EE650-0x00000001895EE670
		public float UnityInput_GetTouchPressure(ref Touch touch) => default; // 0x0000000187343D70-0x0000000187343E30
		// [XID] // 0x00000001895F5EB0-0x00000001895F5ED0
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch) => default; // 0x0000000187343CB0-0x0000000187343D70
		// [XID] // 0x00000001895FD350-0x00000001895FD370
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload) => default; // 0x0000000187341E60-0x0000000187341F70
		// [XID] // 0x0000000189604BD0-0x0000000189604BF0
		public System.Type[] GetControllerTemplateTypes() => default; // 0x0000000187342180-0x0000000187342250
		// [XID] // 0x000000018960C460-0x000000018960C480
		public System.Type[] GetControllerTemplateInterfaceTypes() => default; // 0x00000001873420B0-0x0000000187342180
	}
}
