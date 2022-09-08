/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [DocumentationSorting] // 0x00000001899D9BC0-0x00000001899D9BE0
	public abstract class CinemachineComponentBase : MonoBehaviour // TypeDefIndex: 6829
	{
		// Fields
		protected const float Epsilon = 0.0001f; // Metadata: 0x00ADDF1C
		private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
	
		// Properties
		public CinemachineVirtualCameraBase VirtualCamera { /* [XID] */ /* 0x00000001899E1210-0x00000001899E1230 */ get; } // 0x0000000186EEC100-0x0000000186EEC250 
		public Transform FollowTarget { /* [XID] */ /* 0x00000001899E8C10-0x00000001899E8C30 */ get; } // 0x0000000186EEBC10-0x0000000186EEBD10 
		public Transform LookAtTarget { /* [XID] */ /* 0x00000001899F04C0-0x00000001899F04E0 */ get; } // 0x0000000186EEBD10-0x0000000186EEBE10 
		public CameraState VcamState { /* [XID] */ /* 0x00000001899F79F0-0x00000001899F7A10 */ get; } // 0x0000000186EEBE10-0x0000000186EEC100 
		public abstract bool IsValid { get; }
		public abstract CinemachineCore.Stage Stage { get; }
	
		// Constructors
		protected CinemachineComponentBase() {} // 0x0000000186EEBBB0-0x0000000186EEBC10
	
		// Methods
		// [XID] // 0x00000001899FF0B0-0x00000001899FF0D0
		public virtual void PrePipelineMutateCameraState(ref CameraState state) {} // 0x0000000186EEBB00-0x0000000186EEBBB0
		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);
		// [XID] // 0x0000000189A06950-0x0000000189A06970
		public virtual void OnPositionDragged(Vector3 delta) {} // 0x0000000186EEBA40-0x0000000186EEBB00
	}
}
