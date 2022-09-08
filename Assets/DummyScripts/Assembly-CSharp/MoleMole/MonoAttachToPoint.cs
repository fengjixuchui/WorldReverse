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
	public class MonoAttachToPoint : MonoBehaviour // TypeDefIndex: 30690
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AttachType type; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string attachPoint; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 offset; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 rangeScale; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 rangeDistance; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UpdateMethod _updateMethod; // 0x44
		// [Range] // 0x0000000189B266B0-0x0000000189B266F0
		[SerializeField] // 0x0000000189B266B0-0x0000000189B266F0
		private float _smoothTime; // 0x48
		// [Range] // 0x00000001899A72B0-0x00000001899A72F0
		[SerializeField] // 0x00000001899A72B0-0x00000001899A72F0
		private float _smoothFrame; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _currentVelocity; // 0x50
		private Action updatePosition; // 0x60
		private bool isActive; // 0x68
		private BaseEntity _attachEntity; // 0x70
		private bool _wrapOneFrame; // 0x78
	
		// Nested types
		public enum AttachType // TypeDefIndex: 30691
		{
			Avatar = 0,
			Entity = 1
		}
	
		private enum UpdateMethod // TypeDefIndex: 30692
		{
			DeltaTime = 0,
			FrameCount = 1
		}
	
		// Constructors
		public MonoAttachToPoint() {} // 0x0000000184C99B50-0x0000000184C99BE0
	
		// Methods
		// [XID] // 0x00000001899F7D00-0x00000001899F7D20
		public void Awake() {} // 0x0000000184C98A40-0x0000000184C98B20
		// [XID] // 0x00000001899FF350-0x00000001899FF370
		public void OnEnable() {} // 0x0000000184C99790-0x0000000184C99830
		// [XID] // 0x0000000189A06B70-0x0000000189A06B90
		public void OnDisable() {} // 0x0000000184C996F0-0x0000000184C99790
		// [XID] // 0x0000000189A0E280-0x0000000189A0E2A0
		public void Update() {} // 0x0000000184C99A10-0x0000000184C99B50
		// [XID] // 0x0000000189A15880-0x0000000189A158A0
		public void SetAttachEntity(BaseEntity entity, bool warpToTarget = false /* Metadata: 0x00B11489 */) {} // 0x0000000184C99830-0x0000000184C99920
		// [XID] // 0x0000000189A1CD20-0x0000000189A1CD40
		public void SetAttachParam(string attachPoint, Vector3 offset) {} // 0x0000000184C99920-0x0000000184C99A10
		// [XID] // 0x0000000189A24260-0x0000000189A24280
		private BaseEntity GetAttachEntity() => default; // 0x0000000184C99310-0x0000000184C99440
		// [XID] // 0x0000000189A2B6D0-0x0000000189A2B6F0
		private void WarpToAttachTarget() {} // 0x0000000184C99440-0x0000000184C996F0
		// [XID] // 0x0000000189A32D20-0x0000000189A32D40
		private void UpdateOnAttach() {} // 0x0000000184C98B20-0x0000000184C99050
		// [XID] // 0x0000000189A3A5B0-0x0000000189A3A5D0
		private Vector3 ChangeOffsetPos(Transform trans, Transform baseTrans) => default; // 0x0000000184C99050-0x0000000184C99310
	}
}
