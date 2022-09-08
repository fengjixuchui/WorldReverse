/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cinemachine;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.PostProcessing;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine.PostFX
{
	// [AddComponentMenu] // 0x000000018998B8B0-0x000000018998B930
	// [DocumentationSorting] // 0x000000018998B8B0-0x000000018998B930
	[ExecuteInEditMode] // 0x000000018998B8B0-0x000000018998B930
	[SaveDuringPlay] // 0x000000018998B8B0-0x000000018998B930
	public class CinemachinePostProcessing : CinemachineExtension // TypeDefIndex: 6866
	{
		// Fields
		// [Tooltip] // 0x000000018999C4A0-0x000000018999C4D0
		public bool m_FocusTracksTarget; // 0x28
		// [Tooltip] // 0x00000001899A5670-0x00000001899A56A0
		public float m_FocusOffset; // 0x2C
		// [Tooltip] // 0x00000001899AE640-0x00000001899AE670
		public PostProcessProfile m_Profile; // 0x30
		private bool mCachedProfileIsInvalid; // 0x38
		private PostProcessProfile mProfileCopy; // 0x40
		private static string sVolumeOwnerName; // 0x00
		private static List<PostProcessVolume> sVolumes; // 0x08
	
		// Properties
		public PostProcessProfile Profile { /* [XID] */ /* 0x00000001899CDE30-0x00000001899CDE50 */ get => default; } // 0x0000000186697A90-0x0000000186697B80 
		public bool IsValid { /* [XID] */ /* 0x00000001899D5320-0x00000001899D5340 */ get => default; } // 0x0000000186697980-0x0000000186697A90 
	
		// Constructors
		public CinemachinePostProcessing() {} // 0x0000000186697910-0x0000000186697980
		static CinemachinePostProcessing() {} // 0x0000000186697870-0x0000000186697910
	
		// Methods
		// [XID] // 0x00000001899DC880-0x00000001899DC8A0
		public void InvalidateCachedProfile() {} // 0x0000000186696FF0-0x0000000186697090
		// [XID] // 0x00000001899E4350-0x00000001899E4370
		private void CreateProfileCopy() {} // 0x0000000186696520-0x0000000186696790
		// [XID] // 0x0000000189BB4770-0x0000000189BB4790
		private void DestroyProfileCopy() {} // 0x0000000186696790-0x00000001866968A0
		// [XID] // 0x00000001899DDF50-0x00000001899DDF70
		protected override void OnDestroy() {} // 0x00000001866971C0-0x0000000186697270
		// [XID] // 0x00000001899FABB0-0x00000001899FABD0
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000186697270-0x0000000186697540
		// [XID] // 0x0000000189A01D20-0x0000000189A01D40
		private static void OnCameraCut(CinemachineBrain brain) {} // 0x0000000186697090-0x00000001866971C0
		// [XID] // 0x0000000189A09690-0x0000000189A096B0
		private static void ApplyPostFX(CinemachineBrain brain) {} // 0x0000000186696130-0x0000000186696520
		// [XID] // 0x0000000189A550B0-0x0000000189A550D0
		private static List<PostProcessVolume> GetDynamicBrainVolumes(CinemachineBrain brain, PostProcessLayer ppLayer, int minVolumes) => default; // 0x00000001866968A0-0x0000000186696D40
		[RuntimeInitializeOnLoadMethod] // 0x0000000189A18210-0x0000000189A18250
		// [XID] // 0x0000000189A18210-0x0000000189A18250
		public static void InitializeModule() {} // 0x0000000186696D40-0x0000000186696FF0
		// [XID] // 0x0000000189A22B60-0x0000000189A22B80
		private static void StaticPostFXHandler(CinemachineBrain brain) {} // 0x0000000186697540-0x0000000186697810
	}
}
