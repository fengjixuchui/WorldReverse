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
	public class FaceAnimationEditAvatar : MonoBehaviour // TypeDefIndex: 19819
	{
		// Fields
		private Animator _animator; // 0x18
		private FaceAnimation _faceAnimation; // 0x20
		private FacePartControl _leftEye; // 0x28
		private FacePartControl _rightEye; // 0x30
		private FacePartControl _mouth; // 0x38
		public Renderer leftEyeRenderer; // 0x40
		public Renderer rightEyeRenderer; // 0x48
		public Renderer mouthRenderer; // 0x50
		public AtlasMatInfoProvider eyeProviderAtlas; // 0x58
		public AtlasMatInfoProvider mouthProviderAtlas; // 0x60
		public Transform headRoot; // 0x68
		public string avatarName; // 0x70
		private string avatarPath; // 0x78
		private ConfigFaceAnimation _config; // 0x80
		private GameObject faceEffectPrototype; // 0x88
		private GameObject faceEffectInstance; // 0x90
	
		// Constructors
		public FaceAnimationEditAvatar() {} // 0x0000000181F71000-0x0000000181F710E0
	
		// Methods
		// [XID] // 0x0000000189827AF0-0x0000000189827B10
		private void Awake() {} // 0x0000000181F70110-0x0000000181F70410
		// [XID] // 0x000000018982ED50-0x000000018982ED70
		public void OnDestroy() {} // 0x0000000181F704B0-0x0000000181F70640
		// [XID] // 0x00000001898366B0-0x00000001898366D0
		public void SetupFaceAnimation(ConfigFaceAnimation config) {} // 0x0000000181F70DC0-0x0000000181F70EA0
		// [XID] // 0x000000018983DA40-0x000000018983DA60
		public void PlayBodyAnimation(string name) {} // 0x0000000181F70640-0x0000000181F70750
		// [XID] // 0x00000001898452D0-0x00000001898452F0
		public void PlayFaceAnimation(string name) {} // 0x0000000181F70750-0x0000000181F70810
		// [XID] // 0x000000018984C7E0-0x000000018984C800
		public void PrepareFaceAnimation(string name) {} // 0x0000000181F70810-0x0000000181F708D0
		// [XID] // 0x00000001898538C0-0x00000001898538E0
		public void SetLeftEyeImage(int index) {} // 0x0000000181F70B20-0x0000000181F70C00
		// [XID] // 0x000000018985B370-0x000000018985B390
		public void SetRightEyeImage(int index) {} // 0x0000000181F70CE0-0x0000000181F70DC0
		// [XID] // 0x00000001898628F0-0x0000000189862910
		public void SetMouthImage(int index) {} // 0x0000000181F70C00-0x0000000181F70CE0
		// [XID] // 0x0000000189869D20-0x0000000189869D40
		public void SetAnimationTime(float time) {} // 0x0000000181F70A60-0x0000000181F70B20
		// [XID] // 0x0000000189871020-0x0000000189871040
		public void SetAnimationTimePerFrame(float time) {} // 0x0000000181F709A0-0x0000000181F70A60
		// [XID] // 0x00000001898789F0-0x0000000189878A10
		public void RebuildFaceAnimation() {} // 0x0000000181F708D0-0x0000000181F709A0
		// [XID] // 0x000000018987FFA0-0x000000018987FFC0
		public void TriggerAudioPattern(string name) {} // 0x0000000181F70F50-0x0000000181F71000
		// [XID] // 0x0000000189887500-0x0000000189887520
		public void ShowFaceEffect(string name) {} // 0x0000000181F70EA0-0x0000000181F70F50
		// [XID] // 0x000000018988E840-0x000000018988E860
		public void HideFaceEffect() {} // 0x0000000181F70410-0x0000000181F704B0
	}
}
