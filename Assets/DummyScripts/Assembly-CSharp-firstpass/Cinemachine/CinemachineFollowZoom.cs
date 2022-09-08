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
	// [AddComponentMenu] // 0x00000001898108F0-0x0000000189810970
	// [DocumentationSorting] // 0x00000001898108F0-0x0000000189810970
	[ExecuteInEditMode] // 0x00000001898108F0-0x0000000189810970
	[SaveDuringPlay] // 0x00000001898108F0-0x0000000189810970
	public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 6771
	{
		// Fields
		// [Tooltip] // 0x0000000189821480-0x00000001898214B0
		public float m_Width; // 0x28
		// [Range] // 0x0000000189829F50-0x0000000189829FB0
		// [Tooltip] // 0x0000000189829F50-0x0000000189829FB0
		public float m_Damping; // 0x2C
		// [Range] // 0x0000000189835D90-0x0000000189835DE0
		// [Tooltip] // 0x0000000189835D90-0x0000000189835DE0
		public float m_MinFOV; // 0x30
		// [Range] // 0x00000001898417E0-0x0000000189841840
		// [Tooltip] // 0x00000001898417E0-0x0000000189841840
		public float m_MaxFOV; // 0x34
	
		// Nested types
		private class VcamExtraState // TypeDefIndex: 6772
		{
			// Fields
			public float m_previousFrameZoom; // 0x10
	
			// Constructors
			public VcamExtraState() {} // 0x0000000186CD8580-0x0000000186CD85F0
		}
	
		// Constructors
		public CinemachineFollowZoom() {} // 0x0000000186CB62E0-0x0000000186CB63A0
	
		// Methods
		// [XID] // 0x000000018984D770-0x000000018984D790
		private void OnValidate() {} // 0x0000000186CB5D50-0x0000000186CB5E80
		// [XID] // 0x0000000189B37920-0x0000000189B37940
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000186CB5E80-0x0000000186CB62E0
	}
}
