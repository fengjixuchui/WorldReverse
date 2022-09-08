/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [AddComponentMenu] // 0x00000001899C93D0-0x00000001899C9470
	// [DocumentationSorting] // 0x00000001899C93D0-0x00000001899C9470
	// [RequireComponent] // 0x00000001899C93D0-0x00000001899C9470
	[SaveDuringPlay] // 0x00000001899C93D0-0x00000001899C9470
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 6794
	{
		// Fields
		// [FormerlySerializedAs] // 0x00000001899DE0D0-0x00000001899DE140
		[HideInInspector] // 0x00000001899DE0D0-0x00000001899DE140
		// [Tooltip] // 0x00000001899DE0D0-0x00000001899DE140
		public NoiseSettings m_NoiseProfile; // 0x20
		// [Tooltip] // 0x00000001899EE9A0-0x00000001899EE9D0
		public float m_AmplitudeGain; // 0x28
		// [Tooltip] // 0x00000001899F7A30-0x00000001899F7A60
		public float m_FrequencyGain; // 0x2C
		private bool mInitialized; // 0x30
		private float mNoiseTime; // 0x34
		private Vector3 mNoiseOffsets; // 0x38
	
		// Properties
		public override bool IsValid { /* [XID] */ /* 0x0000000189A00620-0x0000000189A00640 */ get => default; } // 0x0000000186EDBA80-0x0000000186EDBB70 
		public override CinemachineCore.Stage Stage { /* [XID] */ /* 0x0000000189A07E90-0x0000000189A07EB0 */ get => default; } // 0x0000000186EDBB70-0x0000000186EDBC10 
	
		// Constructors
		public CinemachineBasicMultiChannelPerlin() {} // 0x0000000186EDB980-0x0000000186EDBA80
	
		// Methods
		// [XID] // 0x00000001897F42A0-0x00000001897F42C0
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000186EDB560-0x0000000186EDB980
		// [XID] // 0x00000001897FBDC0-0x00000001897FBDE0
		private void Initialize() {} // 0x0000000186EDB410-0x0000000186EDB560
		// [XID] // 0x0000000189A1DF00-0x0000000189A1DF20
		private static Vector3 GetCombinedFilterResults(NoiseSettings.TransformNoiseParams[] noiseParams, float time, Vector3 noiseOffsets) => default; // 0x0000000186EDB020-0x0000000186EDB410
	}
}
