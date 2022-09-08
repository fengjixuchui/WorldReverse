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
	public sealed class MonoEffectPluginFollowLocalAvatar : BaseMonoEffectPlugin // TypeDefIndex: 19716
	{
		// Fields
		private Vector3 _heightoffset; // 0x28
		private BaseEntity _currentAvatar; // 0x38
		// [Header] // 0x00000001896F58D0-0x00000001896F5900
		public FollowRotationType rotationType; // 0x40
		// [Header] // 0x00000001896FEA60-0x00000001896FEA90
		public string attachPoint; // 0x48
		// [Header] // 0x0000000189707640-0x0000000189707670
		public bool fixedHeightWhenFollowAvatar; // 0x50
		// [Header] // 0x00000001897106A0-0x00000001897106D0
		public float FollowRotationDampTime; // 0x54
		private float _angleDampVelocity; // 0x58
		// [Header] // 0x0000000189717A80-0x0000000189717AB0
		public float FollowPositionDampTime; // 0x5C
		private Vector3 _FollowPositionDampVelocity; // 0x60
		private Transform _followedTrans; // 0x70
		private Action<EvtAvatarChanged> _onAvatarChanged; // 0x78
		private float _initRotationYOffset; // 0x80
	
		// Nested types
		public enum FollowRotationType // TypeDefIndex: 19717
		{
			None = 0,
			AvatarRootRotation = 1,
			AttachPointRotation = 2,
			AttachPointYRotation = 3
		}
	
		// Constructors
		public MonoEffectPluginFollowLocalAvatar() {} // 0x0000000184E41C10-0x0000000184E41D20
	
		// Methods
		// [XID] // 0x000000018971F590-0x000000018971F5B0
		public override void Awaked() {} // 0x0000000184E40710-0x0000000184E40800
		// [XID] // 0x0000000189726B20-0x0000000189726B40
		public override void Init() {} // 0x0000000184E40FC0-0x0000000184E41280
		// [XID] // 0x000000018972E110-0x000000018972E130
		public override void Destroied() {} // 0x0000000184E40930-0x0000000184E40AA0
		// [XID] // 0x0000000189735800-0x0000000189735820
		public override void Tick(float inDeltaTime) {} // 0x0000000184E41B60-0x0000000184E41C10
		// [XID] // 0x000000018973D350-0x000000018973D370
		public override void LateTick(float inDeltaTime) {} // 0x0000000184E41280-0x0000000184E41330
		// [XID] // 0x00000001897447D0-0x00000001897447F0
		private void OnAvatarChanged(EvtAvatarChanged evt) {} // 0x0000000184E40800-0x0000000184E408B0
		// [XID] // 0x000000018974C4F0-0x000000018974C510
		private bool IsEntityValid() => default; // 0x0000000184E41AA0-0x0000000184E41B60
		// [XID] // 0x0000000189753740-0x0000000189753760
		private void UpdateAvatar(bool changeAvatar = false /* Metadata: 0x00AFCCB0 */) {} // 0x0000000184E40B00-0x0000000184E40EE0
		// [XID] // 0x000000018975ACE0-0x000000018975AD00
		private void UpdateShieldEffect() {} // 0x0000000184E41330-0x0000000184E41AA0
	}
}
