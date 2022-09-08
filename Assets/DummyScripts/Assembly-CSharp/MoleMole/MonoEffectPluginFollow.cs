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
	public sealed class MonoEffectPluginFollow : BaseMonoEffectPlugin // TypeDefIndex: 19715
	{
		// Fields
		// [Header] // 0x0000000189902390-0x00000001899023C0
		public string FollowTargetPath; // 0x28
		// [Header] // 0x0000000189BB5160-0x0000000189BB5190
		public bool FollowYAxisOnly; // 0x30
		// [Header] // 0x0000000189BBDE60-0x0000000189BBDE90
		public string FollowYOverrideTarget; // 0x38
		// [Header] // 0x0000000189BC71F0-0x0000000189BC7220
		public string CustomSimluationSpacePath; // 0x40
		// [Header] // 0x0000000189BD04C0-0x0000000189BD04F0
		public ParticleSystem[] particleSystems; // 0x48
		// [Header] // 0x0000000189BD9390-0x0000000189BD93C0
		public bool IsNotAttachPoint; // 0x50
		// [Header] // 0x00000001895E75A0-0x00000001895E75D0
		public bool FollowRotation; // 0x51
		// [Header] // 0x00000001897106A0-0x00000001897106D0
		public float FollowRotationDampTime; // 0x54
		// [Header] // 0x00000001895F97B0-0x00000001895F97E0
		public bool FollowYRotation; // 0x58
		// [Header] // 0x00000001896026E0-0x0000000189602710
		public bool FollowScale; // 0x59
		// [Header] // 0x000000018960B990-0x000000018960B9C0
		public bool FollowAvatarHipOffset; // 0x5A
		// [Header] // 0x00000001896144B0-0x00000001896144E0
		public bool ForceUponGround; // 0x5B
		// [Header] // 0x00000001899110D0-0x0000000189911100
		public bool NoFollowDestory; // 0x5C
		// [Header] // 0x00000001896262E0-0x0000000189626310
		public bool OnlyFirstFrame; // 0x5D
		// [Header] // 0x000000018962F4B0-0x000000018962F4E0
		public float FollowInTime; // 0x60
		// [Header] // 0x0000000189638960-0x0000000189638990
		public bool FollowByInitPos; // 0x64
		// [Header] // 0x0000000189918CB0-0x0000000189918CE0
		public GameObject ActivateOnStart; // 0x68
		// [Header] // 0x000000018964A4D0-0x000000018964A500
		public bool FollowWhenDestroying; // 0x70
		// [Header] // 0x0000000189717A80-0x0000000189717AB0
		public float FollowPositionDampTime; // 0x74
		private Vector3 _FollowPositionDampVelocity; // 0x78
		// [Header] // 0x000000018965C4B0-0x000000018965C4E0
		public Transform tiltRoot; // 0x88
		private Vector3 _additionalOffset; // 0x90
		private Transform _followTarget; // 0xA0
		private Transform _followYTarget; // 0xA8
		private Transform _root; // 0xB0
		private float _initRotationYOffset; // 0xB8
		private Vector3 _followYAxisOnlyInitPos; // 0xBC
		private bool _firstFrameUpdated; // 0xC8
		private bool _doFollowInTime; // 0xC9
		private float _followInTime; // 0xCC
		private BaseEntity _followEntity; // 0xD0
		private VCHumanoidMove _followAvatarMove; // 0xD8
		private bool _hasCleared; // 0xE0
		private float _angleDampVelocity; // 0xE4
		private float _curTilt; // 0xE8
		private bool _tilt; // 0xEC
		private bool _fastDecrease; // 0xED
		private float _tiltPlusMinus; // 0xF0
		private float _stopTiltTime; // 0xF4
		// [Header] // 0x0000000189665260-0x0000000189665290
		public float tiltUpdateSpeedIncrease; // 0xF8
		// [Header] // 0x000000018966E230-0x000000018966E260
		public float tiltUpdateSpeedDecreaseFast; // 0xFC
		// [Header] // 0x00000001896778E0-0x0000000189677910
		public float tiltUpdateSpeedDecreaseSlow; // 0x100
		// [Header] // 0x00000001896808D0-0x0000000189680900
		public float stopTiltYawDiff; // 0x104
		// [Header] // 0x00000001896899E0-0x0000000189689A10
		public float stopTiltTime; // 0x108
		// [Header] // 0x0000000189693030-0x0000000189693060
		public float startTiltYawDiff; // 0x10C
		// [Header] // 0x000000018969BB50-0x000000018969BB80
		public float maxTiltAngle; // 0x110
	
		// Constructors
		public MonoEffectPluginFollow() {} // 0x0000000184E44CD0-0x0000000184E44E80
	
		// Methods
		// [XID] // 0x00000001896A45A0-0x00000001896A45C0
		public override void Awaked() {} // 0x0000000184E41D80-0x0000000184E41E80
		// [XID] // 0x00000001896ABDB0-0x00000001896ABDD0
		public override void Init() {} // 0x0000000184E43420-0x0000000184E43520
		// [XID] // 0x00000001896B2F70-0x00000001896B2F90
		public override void SetFollowParentTarget(Transform parent) {} // 0x0000000184E44070-0x0000000184E44CD0
		// [XID] // 0x00000001896BA790-0x00000001896BA7B0
		private void FollowPosition() {} // 0x0000000184E42240-0x0000000184E432A0
		// [XID] // 0x00000001896C1860-0x00000001896C1880
		private void CalcTilt() {} // 0x0000000184E43640-0x0000000184E43CF0
		// [XID] // 0x00000001896C8F80-0x00000001896C8FA0
		public override void LateTick(float inDeltaTime) {} // 0x0000000184E43CF0-0x0000000184E43E70
		// [XID] // 0x00000001896D0960-0x00000001896D0980
		public override bool IsToBeDeallocated() => default; // 0x0000000184E43520-0x0000000184E43640
		// [XID] // 0x00000001896D7EB0-0x00000001896D7ED0
		public Transform GetFollowTarget() => default; // 0x0000000184E432A0-0x0000000184E43350
		// [XID] // 0x00000001896DF780-0x00000001896DF7A0
		public override void Clear() {} // 0x0000000184E41EE0-0x0000000184E41F80
		// [XID] // 0x00000001896E6B20-0x00000001896E6B40
		public override void OnDeallocate() {} // 0x0000000184E43FB0-0x0000000184E44070
		// [XID] // 0x00000001896EE0B0-0x00000001896EE0D0
		public override void Disabled() {} // 0x0000000184E42000-0x0000000184E42240
	}
}
