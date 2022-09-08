/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x0000000189983FD0-0x0000000189984020
	public class MonoModelRenderImage : MonoUIManekinCtrl // TypeDefIndex: 30836
	{
		// Fields
		public ModelType type; // 0x58
		private int _rtWidth; // 0x5C
		private int _rtHeight; // 0x60
		private int _rtDepth; // 0x64
		private RenderTextureFormat _rtFormat; // 0x68
		private RenderTextureWrapper _renderTexture; // 0x70
		private RenderTexture _originalTexture; // 0x78
		private MonoSceneUISetup _setupGo; // 0x80
		private PostProcessLayer _processLayer; // 0x88
		private RawImage _rawImage; // 0x90
	
		// Nested types
		public enum ModelType // TypeDefIndex: 30837
		{
			Avatar = 0,
			Weapon = 1,
			Team = 2
		}
	
		// Constructors
		public MonoModelRenderImage() {} // 0x0000000182F15DF0-0x0000000182F15E90
	
		// Methods
		// [XID] // 0x0000000189990340-0x0000000189990360
		public override void OnEnable() {} // 0x0000000182F15B70-0x0000000182F15C60
		// [XID] // 0x0000000189997F30-0x0000000189997F50
		public override void OnDisable() {} // 0x0000000182F15AA0-0x0000000182F15B70
		// [XID] // 0x000000018999F600-0x000000018999F620
		public void SetupView(AvatarDataItem avatarData) {} // 0x0000000182F15C60-0x0000000182F15DF0
		// [XID] // 0x00000001899A7170-0x00000001899A7190
		public void ClearView() {} // 0x0000000182F15420-0x0000000182F15520
		// [XID] // 0x00000001899AEAC0-0x00000001899AEAE0
		public void CleanUp() {} // 0x0000000182F152E0-0x0000000182F15420
		// [XID] // 0x00000001899B5E40-0x00000001899B5E60
		private void TuneMaterialFloat(UnityEngine.Material material, string name, float scale) {} // 0x0000000182F15180-0x0000000182F152E0
		// [XID] // 0x00000001899BDB60-0x00000001899BDB80
		private void DisableRenderTexture() {} // 0x0000000182F159A0-0x0000000182F15AA0
		// [XID] // 0x00000001899C52A0-0x00000001899C52C0
		private void EnableRenderTexture() {} // 0x0000000182F15520-0x0000000182F158E0
	}
}
