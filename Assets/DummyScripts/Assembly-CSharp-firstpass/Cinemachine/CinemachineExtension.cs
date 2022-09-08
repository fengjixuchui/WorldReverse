/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [DocumentationSorting] // 0x0000000189AD9BC0-0x0000000189AD9BE0
	public abstract class CinemachineExtension : MonoBehaviour // TypeDefIndex: 6836
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x00ADDF40
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
		private Dictionary<ICinemachineCamera, object> mExtraState; // 0x20
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { /* [XID] */ /* 0x0000000189BA5B30-0x0000000189BA5B50 */ get; } // 0x0000000186CB4EF0-0x0000000186CB4FF0 
	
		// Constructors
		protected CinemachineExtension() {} // 0x0000000186CB4E90-0x0000000186CB4EF0
	
		// Methods
		// [XID] // 0x0000000189A2B1E0-0x0000000189A2B200
		protected virtual void Awake() {} // 0x0000000186CB4B10-0x0000000186CB4BB0
		// [XID] // 0x0000000189AF0B10-0x0000000189AF0B30
		protected virtual void OnDestroy() {} // 0x0000000186CB4D40-0x0000000186CB4E90
		// [XID] // 0x0000000189AF8150-0x0000000189AF8170
		private void ConnectToVcam() {} // 0x0000000186CB4BB0-0x0000000186CB4D40
		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);
		protected T GetExtraState<T>(ICinemachineCamera vcam)
			where T : class, new() => default;
		protected List<T> GetAllExtraStates<T>()
			where T : class, new() => default;
	}
}
