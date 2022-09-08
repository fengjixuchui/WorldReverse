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
	public sealed class CinemachineCore // TypeDefIndex: 6830
	{
		// Fields
		public static readonly int kStreamingVersion; // 0x00
		public static readonly string kVersionString; // 0x08
		private static CinemachineCore sInstance; // 0x10
		public static bool sShowHiddenObjects; // 0x18
		public static AxisInputDelegate GetInputAxis; // 0x20
		private List<CinemachineBrain> mActiveBrains; // 0x10
		private List<ICinemachineCamera> mActiveCameras; // 0x18
		private List<List<ICinemachineCamera>> mChildCameras; // 0x20
		private Dictionary<ICinemachineCamera, UpdateStatus> mUpdateStatus; // 0x28
	
		// Properties
		public static CinemachineCore Instance { /* [XID] */ /* 0x0000000189A1F880-0x0000000189A1F8A0 */ get => default; } // 0x0000000186CB4470-0x0000000186CB45B0 
		public int BrainCount { /* [XID] */ /* 0x0000000189A26D20-0x0000000189A26D40 */ get => default; } // 0x0000000186CB4350-0x0000000186CB4410 
		public int VirtualCameraCount { /* [XID] */ /* 0x0000000189A44BA0-0x0000000189A44BC0 */ get => default; } // 0x0000000186CB45B0-0x0000000186CB4670 
		internal UpdateFilter CurrentUpdateFilter { /* [XID] */ /* 0x0000000189A80E90-0x0000000189A80ED0 */ get; /* [XID] */ /* 0x0000000189A8B9B0-0x0000000189A8B9F0 */ set; } // 0x0000000186CB4410-0x0000000186CB4470 0x0000000186CB4670-0x0000000186CB46D0
	
		// Nested types
		public enum Stage // TypeDefIndex: 6831
		{
			Body = 0,
			Aim = 1,
			Noise = 2
		}
	
		public delegate float AxisInputDelegate(string axisName); // TypeDefIndex: 6832; 0x0000000186CB2310-0x0000000186CB2580
	
		private struct UpdateStatus // TypeDefIndex: 6833
		{
			// Fields
			private const int kWindowSize = 30; // Metadata: 0x00ADDF2C
			public int lastUpdateFrame; // 0x00
			public int lastUpdateSubframe; // 0x04
			public int windowStart; // 0x08
			public int numWindowLateUpdateMoves; // 0x0C
			public int numWindowFixedUpdateMoves; // 0x10
			public int numWindows; // 0x14
			public UpdateFilter preferredUpdate; // 0x18
			public Matrix4x4 targetPos; // 0x1C
	
			// Constructors
			public UpdateStatus(int currentFrame) {
				lastUpdateFrame = default;
				lastUpdateSubframe = default;
				windowStart = default;
				numWindowLateUpdateMoves = default;
				numWindowFixedUpdateMoves = default;
				numWindows = default;
				preferredUpdate = default;
				targetPos = default;
			} // 0x0000000186CD8510-0x0000000186CD8520
	
			// Methods
			// [XID] // 0x0000000189AC30B0-0x0000000189AC30D0
			public UpdateFilter ChoosePreferredUpdate(int currentFrame, Matrix4x4 pos, UpdateFilter updateFilter) => default; // 0x0000000186CD83E0-0x0000000186CD8510
		}
	
		public enum UpdateFilter // TypeDefIndex: 6834
		{
			Fixed = 0,
			ForcedFixed = 1,
			Late = 2,
			ForcedLate = 3
		}
	
		// Constructors
		public CinemachineCore() {} // 0x0000000186CB4280-0x0000000186CB4350
		static CinemachineCore() {} // 0x0000000186CB4130-0x0000000186CB4280
	
		// Methods
		// [XID] // 0x0000000189676B30-0x0000000189676B50
		public CinemachineBrain GetActiveBrain(int index) => default; // 0x0000000186CB2FB0-0x0000000186CB3080
		// [XID] // 0x0000000189A35D60-0x0000000189A35D80
		internal void AddActiveBrain(CinemachineBrain brain) {} // 0x0000000186CB2600-0x0000000186CB26D0
		// [XID] // 0x0000000189A3D370-0x0000000189A3D390
		internal void RemoveActiveBrain(CinemachineBrain brain) {} // 0x0000000186CB36E0-0x0000000186CB37B0
		// [XID] // 0x0000000189AF4DC0-0x0000000189AF4DE0
		public ICinemachineCamera GetVirtualCamera(int index) => default; // 0x0000000186CB34B0-0x0000000186CB3580
		// [XID] // 0x0000000189A53AD0-0x0000000189A53AF0
		internal void AddActiveCamera(ICinemachineCamera vcam) {} // 0x0000000186CB26D0-0x0000000186CB2860
		// [XID] // 0x0000000189A5B160-0x0000000189A5B180
		internal void RemoveActiveCamera(ICinemachineCamera vcam) {} // 0x0000000186CB37B0-0x0000000186CB3880
		// [XID] // 0x0000000189A62A40-0x0000000189A62A60
		internal void AddChildCamera(ICinemachineCamera vcam) {} // 0x0000000186CB2860-0x0000000186CB2A80
		// [XID] // 0x0000000189A55090-0x0000000189A550B0
		internal void RemoveChildCamera(ICinemachineCamera vcam) {} // 0x0000000186CB3880-0x0000000186CB39B0
		// [XID] // 0x0000000189A71C70-0x0000000189A71C90
		internal void UpdateAllActiveVirtualCameras(Vector3 worldUp, float deltaTime) {} // 0x0000000186CB39B0-0x0000000186CB3BF0
		// [XID] // 0x0000000189A795F0-0x0000000189A79610
		internal bool UpdateVirtualCamera(ICinemachineCamera vcam, Vector3 worldUp, float deltaTime) => default; // 0x0000000186CB3BF0-0x0000000186CB4130
		// [XID] // 0x0000000189A95E20-0x0000000189A95E40
		private static bool GetTargetPosition(ICinemachineCamera vcam, out Matrix4x4 targetPos) {
			targetPos = default;
			return default;
		} // 0x0000000186CB3080-0x0000000186CB33B0
		// [XID] // 0x0000000189BACE60-0x0000000189BACE80
		public UpdateFilter GetVcamUpdateStatus(ICinemachineCamera vcam) => default; // 0x0000000186CB33B0-0x0000000186CB34B0
		// [XID] // 0x0000000189AA4D60-0x0000000189AA4D80
		public bool IsLive(ICinemachineCamera vcam) => default; // 0x0000000186CB3580-0x0000000186CB36E0
		// [XID] // 0x0000000189AAC360-0x0000000189AAC380
		public void GenerateCameraActivationEvent(ICinemachineCamera vcam) {} // 0x0000000186CB2CD0-0x0000000186CB2E40
		// [XID] // 0x0000000189AB3CA0-0x0000000189AB3CC0
		public void GenerateCameraCutEvent(ICinemachineCamera vcam) {} // 0x0000000186CB2E40-0x0000000186CB2FB0
		// [XID] // 0x0000000189734C50-0x0000000189734C70
		public CinemachineBrain FindPotentialTargetBrain(ICinemachineCamera vcam) => default; // 0x0000000186CB2A80-0x0000000186CB2CD0
	}
}
