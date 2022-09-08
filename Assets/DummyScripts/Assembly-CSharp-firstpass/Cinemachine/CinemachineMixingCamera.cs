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
	// [AddComponentMenu] // 0x00000001899E4370-0x00000001899E43F0
	[DisallowMultipleComponent] // 0x00000001899E4370-0x00000001899E43F0
	// [DocumentationSorting] // 0x00000001899E4370-0x00000001899E43F0
	[ExecuteInEditMode] // 0x00000001899E4370-0x00000001899E43F0
	public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 6777
	{
		// Fields
		public const int MaxCameras = 8; // Metadata: 0x00ADDE2F
		// [Tooltip] // 0x00000001899F6200-0x00000001899F6230
		public float m_Weight0; // 0x78
		// [Tooltip] // 0x00000001899FF0F0-0x00000001899FF120
		public float m_Weight1; // 0x7C
		// [Tooltip] // 0x0000000189A07EB0-0x0000000189A07EE0
		public float m_Weight2; // 0x80
		// [Tooltip] // 0x0000000189A10CF0-0x0000000189A10D20
		public float m_Weight3; // 0x84
		// [Tooltip] // 0x0000000189A19A60-0x0000000189A19A90
		public float m_Weight4; // 0x88
		// [Tooltip] // 0x0000000189A22B80-0x0000000189A22BB0
		public float m_Weight5; // 0x8C
		// [Tooltip] // 0x0000000189A2B3D0-0x0000000189A2B400
		public float m_Weight6; // 0x90
		// [Tooltip] // 0x0000000189A342D0-0x0000000189A34300
		public float m_Weight7; // 0x94
		private CameraState m_State; // 0x98
		private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x180
		private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x188
	
		// Properties
		private ICinemachineCamera LiveChild { /* [XID] */ /* 0x0000000189A917C0-0x0000000189A91800 */ get; /* [XID] */ /* 0x0000000189A86D60-0x0000000189A86DA0 */ set; } // 0x0000000186CC2860-0x0000000186CC28C0 0x0000000186CC2BF0-0x0000000186CC2C60
		public override CameraState State { /* [XID] */ /* 0x0000000189A9BE70-0x0000000189A9BE90 */ get => default; } // 0x0000000186CC2920-0x0000000186CC2B80 
		public override Transform LookAt { get; set; } // 0x0000000186CC28C0-0x0000000186CC2920 0x0000000186CC2C60-0x0000000186CC2CD0
		public override Transform Follow { get; set; } // 0x0000000186CC2720-0x0000000186CC2780 0x0000000186CC2B80-0x0000000186CC2BF0
		public override ICinemachineCamera LiveChildOrSelf { /* [XID] */ /* 0x0000000189BD4230-0x0000000189BD4250 */ get => default; } // 0x0000000186CC2780-0x0000000186CC2860 
		public CinemachineVirtualCameraBase[] ChildCameras { /* [XID] */ /* 0x0000000189AEF430-0x0000000189AEF450 */ get => default; } // 0x0000000186CC2670-0x0000000186CC2720 
	
		// Constructors
		public CinemachineMixingCamera() {} // 0x0000000186CC2500-0x0000000186CC2670
	
		// Methods
		// [IDTag] // 0x0000000189A5CC70-0x0000000189A5CCB0
		// [XID] // 0x0000000189A5CC70-0x0000000189A5CCB0
		public float GetWeight(int index) => default; // 0x0000000186CC0F10-0x0000000186CC10E0
		// [IDTag] // 0x0000000189A67740-0x0000000189A67780
		// [XID] // 0x0000000189A67740-0x0000000189A67780
		public void SetWeight(int index, float w) {} // 0x0000000186CC16B0-0x0000000186CC1890
		// [IDTag] // 0x0000000189A71C90-0x0000000189A71CD0
		// [XID] // 0x0000000189A71C90-0x0000000189A71CD0
		public float GetWeight(CinemachineVirtualCameraBase vcam) => default; // 0x0000000186CC0D50-0x0000000186CC0F10
		// [IDTag] // 0x0000000189A7C6E0-0x0000000189A7C720
		// [XID] // 0x0000000189A7C6E0-0x0000000189A7C720
		public void SetWeight(CinemachineVirtualCameraBase vcam, float w) {} // 0x0000000186CC1890-0x0000000186CC1A60
		// [XID] // 0x0000000189AC8F10-0x0000000189AC8F30
		public override void RemovePostPipelineStageHook(OnPostPipelineStageDelegate d) {} // 0x0000000186CC1590-0x0000000186CC16B0
		// [XID] // 0x0000000189AD0640-0x0000000189AD0660
		protected override void OnEnable() {} // 0x0000000186CC1330-0x0000000186CC13E0
		// [XID] // 0x0000000189AD8480-0x0000000189AD84A0
		public void OnTransformChildrenChanged() {} // 0x0000000186CC13E0-0x0000000186CC1480
		// [XID] // 0x000000018994C300-0x000000018994C320
		protected override void OnValidate() {} // 0x0000000186CC1480-0x0000000186CC1590
		// [XID] // 0x0000000189AE77B0-0x0000000189AE77D0
		public override bool IsLiveChild(ICinemachineCamera vcam) => default; // 0x0000000186CC11D0-0x0000000186CC1330
		// [XID] // 0x0000000189AF6870-0x0000000189AF6890
		protected void InvalidateListOfChildren() {} // 0x0000000186CC10E0-0x0000000186CC11D0
		// [XID] // 0x0000000189B96E00-0x0000000189B96E20
		protected void ValidateListOfChildren() {} // 0x0000000186CC22A0-0x0000000186CC2500
		// [XID] // 0x0000000189B05650-0x0000000189B05670
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186CC1C90-0x0000000186CC22A0
	}
}
