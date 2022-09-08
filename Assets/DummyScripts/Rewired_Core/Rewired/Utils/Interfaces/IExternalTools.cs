/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Interfaces
{
	public interface IExternalTools // TypeDefIndex: 4005
	{
		// Properties
		bool isEditorPaused { get; }
	
		// Events
		event Action<bool> EditorPausedStateChangedEvent;
		event Action<uint, bool> XboxOneInput_OnGamepadStateChange;
	
		// Methods
		void Destroy();
		object GetPlatformInitializer();
		string GetFocusedEditorWindowTitle();
		bool IsEditorSceneViewFocused();
		bool LinuxInput_IsJoystickPreconfigured(string name);
		ulong XboxOneInput_GetControllerId(uint unityJoystickId);
		bool XboxOneInput_IsGamepadActive(uint unityJoystickId);
		string XboxOneInput_GetControllerType(ulong xboxControllerId);
		uint XboxOneInput_GetJoystickId(ulong xboxControllerId);
		void XboxOne_Gamepad_UpdatePlugin();
		bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel);
		Vector3 PS4Input_GetLastAcceleration(int id);
		Vector3 PS4Input_GetLastGyro(int id);
		Vector4 PS4Input_GetLastOrientation(int id);
		void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id);
		void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType);
		void PS4Input_PadSetMotionSensorState(int id, bool bEnable);
		void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable);
		void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable);
		void PS4Input_PadSetLightBar(int id, int red, int green, int blue);
		void PS4Input_PadResetLightBar(int id);
		void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor);
		void PS4Input_PadResetOrientation(int id);
		bool PS4Input_PadIsConnected(int id);
		int PS4Input_GetDeviceClassForHandle(int handle);
		int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles);
		void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids);
		int GetAndroidAPILevel();
		bool UnityUI_Graphic_GetRaycastTarget(object graphic);
		void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value);
		IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload);
		System.Type[] GetControllerTemplateTypes();
		System.Type[] GetControllerTemplateInterfaceTypes();
	}
}
