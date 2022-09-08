/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class FaceAnimationSettingItem // TypeDefIndex: 19820
	{
		// Fields
		public string avatarTypeFullName; // 0x10
		public string avatarTypeShortName; // 0x18
		public UnityEngine.Material leftEyeMaterial; // 0x20
		public UnityEngine.Material rightEyeMaterial; // 0x28
		public UnityEngine.Material mouthMaterial; // 0x30
		public string leftEyeOriginName; // 0x38
		public string rightEyeOriginName; // 0x40
		public string mouthOriginName; // 0x48
		public AtlasMatInfoProvider eyeAtlas; // 0x50
		public AtlasMatInfoProvider mouthAtlas; // 0x58
		public GameObject[] UIAvatars; // 0x60
		[NonSerialized]
		public bool convertAtlas; // 0x70
	
		// Properties
		public ConfigFaceAnimation faceAnimation { /* [XID] */ /* 0x00000001898A0210-0x00000001898A0250 */ get; /* [XID] */ /* 0x00000001898AA7C0-0x00000001898AA800 */ set; } // 0x0000000181F7A900-0x0000000181F7A960 0x0000000181F7A960-0x0000000181F7A9C0
	
		// Constructors
		public FaceAnimationSettingItem() {} // 0x0000000181F7A850-0x0000000181F7A900
	}
}
