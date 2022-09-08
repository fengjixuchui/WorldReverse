/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	public interface ICinemachineCamera // TypeDefIndex: 6853
	{
		// Properties
		string Name { get; }
		string Description { get; }
		int Priority { get; set; }
		Transform LookAt { get; set; }
		Transform Follow { get; set; }
		CameraState State { get; }
		GameObject VirtualCameraGameObject { get; }
		ICinemachineCamera LiveChildOrSelf { get; }
		ICinemachineCamera ParentCamera { get; }
	
		// Methods
		bool IsLiveChild(ICinemachineCamera vcam);
		void UpdateCameraState(Vector3 worldUp, float deltaTime);
		void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime);
	}
}
