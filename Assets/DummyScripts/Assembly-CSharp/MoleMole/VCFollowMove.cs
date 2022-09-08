/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class VCFollowMove : VCBaseMove // TypeDefIndex: 11865
	{
		// Fields
		private FollowTarget _targetType; // 0x1D8
		private string _attachPoint; // 0x1E0
		private bool _followRotation; // 0x1E8
		private Vector3 _offset; // 0x1EC
		private Vector3 _forward; // 0x1F8
		private bool _followOwnerInvisible; // 0x204
		private float? _fixedY; // 0x208
		private BaseEntity _targetEntity; // 0x210
		private Transform _targetTrans; // 0x218
		private uint _groupId; // 0x220
		private uint _groupTargetInstId; // 0x224
		private List<Collider> _curSelfColliders; // 0x230
		private List<Collider> _curIgnoreColliders; // 0x238
		private List<Collider> _moveDisableColliders; // 0x240
		private bool _gettedDisableCollider; // 0x248
		private Vector3 _lastPosition; // 0x24C
		private bool _isDisableCollision; // 0x258
		private float _staticStartTime; // 0x25C
		private ConfigMoveDisableCollision _moveDisableConfig; // 0x260
	
		// Properties
		public override int metaTypeID { /* [XID] */ /* 0x0000000189A8CF00-0x0000000189A8CF20 */ get => default; } // 0x0000000183BE9740-0x0000000183BE97E0 
		public uint chasedTargetRuntimeID { /* [XID] */ /* 0x0000000189986890-0x00000001899868D0 */ get; /* [XID] */ /* 0x00000001899916B0-0x00000001899916F0 */ set; } // 0x0000000183BE96E0-0x0000000183BE9740 0x0000000183BE97E0-0x0000000183BE9850
	
		// Constructors
		public VCFollowMove() {} // 0x0000000183BE9600-0x0000000183BE96E0
	
		// Methods
		// [XID] // 0x0000000189A57EA0-0x0000000189A57EC0
		public override void Init() {} // 0x0000000183BE82A0-0x0000000183BE8660
		// [XID] // 0x00000001899A3A40-0x00000001899A3A60
		public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183BE9460-0x0000000183BE9530
		// [XID] // 0x00000001899AB510-0x00000001899AB530
		public override void ResetTarget(uint targetRuntimeID, uint targetLockPointIndex) {} // 0x0000000183BE8920-0x0000000183BE8A30
		// [XID] // 0x00000001898AB4E0-0x00000001898AB500
		protected override void InitVelocityForce() {} // 0x0000000183BE86E0-0x0000000183BE8780
		// [XID] // 0x00000001899BA150-0x00000001899BA170
		protected override void Tick(float inDeltaTime) {} // 0x0000000183BE9530-0x0000000183BE9600
		// [XID] // 0x00000001899C1CC0-0x00000001899C1CE0
		public override void OnEntityReady() {} // 0x0000000183BE8FA0-0x0000000183BE9050
		// [XID] // 0x0000000189931720-0x0000000189931740
		public override void PostReInit() {} // 0x0000000183BE93B0-0x0000000183BE9460
		// [XID] // 0x00000001899D0C00-0x00000001899D0C20
		private void ResetTargetTransByType() {} // 0x0000000183BE75F0-0x0000000183BE7820
		// [XID] // 0x00000001899D7FD0-0x00000001899D7FF0
		public override void Destroy() {} // 0x0000000183BE7900-0x0000000183BE79D0
		// [XID] // 0x0000000189A35A80-0x0000000189A35AA0
		public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183BE7820-0x0000000183BE7900
		// [XID] // 0x00000001899E7130-0x00000001899E7150
		private void UpdateFollowTarget() {} // 0x0000000183BE6830-0x0000000183BE72E0
		// [XID] // 0x00000001899EE510-0x00000001899EE530
		private void TargetTrans(BaseEntity curTarget, BaseEntity lastTarget) {} // 0x0000000183BE7B20-0x0000000183BE7D20
		// [XID] // 0x00000001899F5E60-0x00000001899F5E80
		private void OnTargetReadyCB(BaseEntity entity) {} // 0x0000000183BE79D0-0x0000000183BE7B20
		// [XID] // 0x00000001899FD4F0-0x00000001899FD510
		private void UpdateVisible() {} // 0x0000000183BE9050-0x0000000183BE9170
		// [XID] // 0x0000000189A04C20-0x0000000189A04C40
		private void SetIgnoreCollision(bool ignore) {} // 0x0000000183BE7ED0-0x0000000183BE8240
		// [XID] // 0x00000001897DBCD0-0x00000001897DBCF0
		private void ClearIgnoreCollision() {} // 0x0000000183BE7DA0-0x0000000183BE7E70
		// [XID] // 0x0000000189A13C30-0x0000000189A13C50
		private void IgnoreTargetCollision(BaseEntity target) {} // 0x0000000183BE7340-0x0000000183BE7580
		// [XID] // 0x0000000189A1AE10-0x0000000189A1AE30
		private void GetColliders(BaseEntity target, ConfigEntityCollider[] configList, ref List<Collider> list) {} // 0x0000000183BE8CA0-0x0000000183BE8FA0
		// [XID] // 0x000000018982E440-0x000000018982E460
		private void SetMoveDisableCollision(bool isDisable) {} // 0x0000000183BE8A30-0x0000000183BE8CA0
		// [XID] // 0x0000000189A29A20-0x0000000189A29A40
		private void ClearMoveDisableCollision() {} // 0x0000000183BE9170-0x0000000183BE93B0
	}
}
