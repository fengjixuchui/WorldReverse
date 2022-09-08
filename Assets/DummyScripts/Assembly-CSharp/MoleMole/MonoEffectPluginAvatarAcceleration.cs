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
	public sealed class MonoEffectPluginAvatarAcceleration : BaseMonoEffectPlugin // TypeDefIndex: 19687
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Renderer[] _renderers; // 0x28
		private int _avatarAccelerationId; // 0x30
		private Vector3 currentPos; // 0x34
		private Vector3 effectSpeed; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float accelerationScale; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float accelerateDist; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float minSpeed; // 0x54
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float maxSpeed; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float maxDistance; // 0x5C
		public AnimationCurve accelerationCurve; // 0x60
		public AnimationCurve decayRateCurve; // 0x68
		// [Header] // 0x0000000189827B10-0x0000000189827B40
		public float moveSpeed; // 0x70
		// [Header] // 0x0000000189830670-0x00000001898306A0
		public float distance; // 0x74
	
		// Constructors
		public MonoEffectPluginAvatarAcceleration() {} // 0x00000001846A1C00-0x00000001846A1D30
	
		// Methods
		// [XID] // 0x0000000189839420-0x0000000189839440
		public override void Init() {} // 0x00000001846A1280-0x00000001846A13E0
		// [XID] // 0x0000000189840A30-0x0000000189840A50
		public override void Tick(float inDeltaTime) {} // 0x00000001846A14E0-0x00000001846A1C00
		// [XID] // 0x0000000189847F40-0x0000000189847F60
		private Vector3 GetTargetPos() => default; // 0x00000001846A13E0-0x00000001846A14E0
		// [XID] // 0x000000018984F680-0x000000018984F6A0
		private void SetRendererAvatarAcceleration(Vector3 pos) {} // 0x00000001846A0FC0-0x00000001846A1200
	}
}
