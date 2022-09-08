/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class CustomDecalDepth : MonoBehaviour // TypeDefIndex: 26487
	{
		// Fields
		private static int _ScaledDepthForDecalPropID; // 0x00
		private static int _worldClipPlanePropID; // 0x04
		private static int _viewClipPlanePropID; // 0x08
		private static int _ExtraObjectDepthPropID; // 0x0C
		private static int DepthOnlyPassID; // 0x10
		private static int MergeDecalDepthPassID; // 0x14
		private bool _haveInitial; // 0x18
		private MeshRenderer _curMeshRD; // 0x20
		private Camera _mainCam; // 0x28
		private CommandBuffer _cmd; // 0x30
		private bool _haveAddCommand; // 0x38
		private int _prevWidth; // 0x3C
		private int _preveHeight; // 0x40
		private RenderTexture _exteraObjectsDepthRT; // 0x48
		private RenderTexture _scaledDepthWithExtraForDecalRT; // 0x50
		private static readonly Vector3 _worldPlaneNormal; // 0x18
		private static readonly Matrix4x4 _shaderScale; // 0x24
		private Vector3 _worldPlanePos; // 0x58
		private Vector4 _worldClipPlane; // 0x64
		private Vector4 _viewClipPlane; // 0x74
		private MHYRenderResourcesSetting _renderResourcesSetting; // 0x88
		private UnityEngine.Material m_CopyMaterial; // 0x90
	
		// Constructors
		public CustomDecalDepth() {} // 0x0000000184D7AE00-0x0000000184D7AF30
		static CustomDecalDepth() {} // 0x0000000184D7AC30-0x0000000184D7AE00
	
		// Methods
		// [XID] // 0x0000000189742DE0-0x0000000189742E00
		private void LateUpdate() {} // 0x0000000184D7A3D0-0x0000000184D7A570
		// [XID] // 0x000000018974AAC0-0x000000018974AAE0
		private void OnDisable() {} // 0x0000000184D7A990-0x0000000184D7AC30
		// [XID] // 0x0000000189751B80-0x0000000189751BA0
		private void InitShaderPropID() {} // 0x0000000184D799D0-0x0000000184D79C40
		// [XID] // 0x0000000189759280-0x00000001897592A0
		private void UpdateViewSpaceClipPlaneInfo() {} // 0x0000000184D79C40-0x0000000184D79F10
		// [XID] // 0x0000000189760D90-0x0000000189760DB0
		private void InitialResources() {} // 0x0000000184D7A570-0x0000000184D7A990
		// [XID] // 0x00000001897680F0-0x0000000189768110
		private void UpdateCommandBuffer() {} // 0x0000000184D79F10-0x0000000184D7A3D0
	}
}
