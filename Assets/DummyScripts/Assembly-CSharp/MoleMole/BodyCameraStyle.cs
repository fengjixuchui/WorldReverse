/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x00000001897447F0-0x0000000189744830
	public class BodyCameraStyle : ScriptableObject // TypeDefIndex: 19608
	{
		// Fields
		public Style[] styles; // 0x18
	
		// Nested types
		[Serializable]
		public struct Style // TypeDefIndex: 19609
		{
			// Fields
			public BodyType type; // 0x00
			public Vector3 defaultCameraPos; // 0x04
			public Vector3 defaultCameraTarget; // 0x10
			public Vector3 equipCameraPos; // 0x1C
			public Vector3 equipCameraTarget; // 0x28
			public Vector3 relicCameraPos; // 0x34
			public Vector3 relicCameraTarget; // 0x40
			public Vector3 skillCameraPos; // 0x4C
			public Vector3 skillCameraTarget; // 0x58
			public Vector3 talentCameraPos; // 0x64
			public Vector3 talentCameraTarget; // 0x70
			public Vector3 teamCameraPos; // 0x7C
			public Vector3 teamCameraTarget; // 0x88
			public Vector3 fetterCameraPos; // 0x94
			public Vector3 fetterCameraTarget; // 0xA0
			public Vector3 fetterStoryVoiceCameraPos; // 0xAC
			public Vector3 fetterStoryVoiceCameraTarget; // 0xB8
			public Vector3 previewCameraPosOffset; // 0xC4
			public Vector3 previewCameraTargetOffset; // 0xD0
			public Vector3 starUpCameraPos; // 0xDC
			public Vector3 starUpCameraTarget; // 0xE8
			public Vector3 flycloakCameraPos; // 0xF4
			public Vector3 flycloakCameraTarget; // 0x100
		}
	
		// Constructors
		public BodyCameraStyle() {} // 0x0000000181AD71C0-0x0000000181AD7220
	
		// Methods
		// [XID] // 0x000000018974DCB0-0x000000018974DCD0
		public Style GetBodyCameraStyle(BodyType bodyType) => default; // 0x0000000181AD6DF0-0x0000000181AD71C0
	}
}
