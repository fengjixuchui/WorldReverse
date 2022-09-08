/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CollisionPlugin : BaseComponentPlugin // TypeDefIndex: 12040
{
	// Fields
	public EventType eventType; // 0x58
	public Action afterHitCallback; // 0x60
	private VCBaseMove _moveComponent; // 0x70
	private VCCollision _collisionComponent; // 0x78
	private CCDType _ccdType; // 0x80
	private float _ccdDetectCD; // 0x84
	private float _ccdTimeLeft; // 0x88
	private const float FIND_COLLISION_POINT_RAYCAST_EXTRA_DIST = 0.1f; // Metadata: 0x00AEB38A
	private Vector3 _lastPosition; // 0x8C
	private Vector3 _lastLastPosition; // 0x98
	private Quaternion _lastRotation; // 0xA4
	private Quaternion _lastLastRotation; // 0xB4
	private RaycastHit[] _collisionCache; // 0xC8
	private LCBaseCombat _baseCombat; // 0xD0
	private VCBaseAudio _vcAudio; // 0xD8
	private Collider _col; // 0xE0
	private ColliderType _colType; // 0xE8
	private BoxCollider _box; // 0xF0
	private SphereCollider _sphere; // 0xF8
	private CapsuleCollider _capsule; // 0x100
	private Vector3 _centerOriginalOffset; // 0x108
	private Rigidbody _rigidbody; // 0x118
	private bool _enableTrigger; // 0x120

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B57180-0x0000000189B571A0 */ get => default; } // 0x0000000183EDAE80-0x0000000183EDAF20 
	public ConfigCollision collisionConfig { /* [XID] */ /* 0x0000000189B5EBA0-0x0000000189B5EBE0 */ get; /* [XID] */ /* 0x0000000189B692F0-0x0000000189B69330 */ set; } // 0x0000000183ED6E80-0x0000000183ED6EE0 0x0000000183ED78F0-0x0000000183ED7950
	public bool enableTrigger { /* [XID] */ /* 0x0000000189B73770-0x0000000189B73790 */ get => default; /* [XID] */ /* 0x0000000189B7ABD0-0x0000000189B7ABF0 */ set {} } // 0x0000000183EDA120-0x0000000183EDA1D0 0x0000000183ED6EE0-0x0000000183ED6FA0

	// Nested types
	public enum EventType // TypeDefIndex: 12041
	{
		TRIGGER_ENTER = 1,
		TRIGGER_STAY = 2
	}

	// Constructors
	public CollisionPlugin() {} // 0x0000000183EDAE00-0x0000000183EDAE80

	// Methods
	// [XID] // 0x0000000189B82470-0x0000000189B82490
	public override void Init() {} // 0x0000000183ED9460-0x0000000183ED9E10
	// [XID] // 0x0000000189B89CD0-0x0000000189B89CF0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183EDA890-0x0000000183EDAB50
	// [XID] // 0x0000000189B91260-0x0000000189B91280
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183ED7140-0x0000000183ED72E0
	// [XID] // 0x0000000189B984B0-0x0000000189B984D0
	public void ResetLastPos() {} // 0x0000000183ED9FD0-0x0000000183EDA120
	// [XID] // 0x0000000189B9FA00-0x0000000189B9FA20
	public override void Tick(float inDeltaTime) {} // 0x0000000183EDAB50-0x0000000183EDAE00
	// [XID] // 0x0000000189BA7290-0x0000000189BA72B0
	public override void Destroy() {} // 0x0000000183ED76D0-0x0000000183ED78F0
	// [XID] // 0x0000000189BAE3C0-0x0000000189BAE3E0
	private void UpdateContinousCollision(float deltaTime) {} // 0x0000000183ED6770-0x0000000183ED6E10
	// [XID] // 0x0000000189BB5CD0-0x0000000189BB5CF0
	private void OnTriggerStay(Collider collider) {} // 0x0000000183ED6FA0-0x0000000183ED7140
	// [XID] // 0x0000000189BBD2D0-0x0000000189BBD2F0
	private bool IsClosestPointCollider(Collider collider) => default; // 0x0000000183ED8E80-0x0000000183ED8F80
	// [XID] // 0x0000000189BC4EA0-0x0000000189BC4EC0
	private void OnTriggerEnter(Collider collider) {} // 0x0000000183ED7950-0x0000000183ED8E00
	// [XID] // 0x0000000189BCCA20-0x0000000189BCCA40
	private void HandleCollider(Collider collider, Vector3 point, Vector3 normal, int triangleIndex) {} // 0x0000000183EDA240-0x0000000183EDA5B0
	// [XID] // 0x0000000189BD40B0-0x0000000189BD40D0
	private bool IgnoreCollider(Collider collider, int triangleIndex) => default; // 0x0000000183ED9E10-0x0000000183ED9F70
	// [XID] // 0x0000000189BDB9D0-0x0000000189BDB9F0
	private void OnHittingScene(Collider collider, Vector3 point, Vector3 normal) {} // 0x0000000183EDA620-0x0000000183EDA890
	// [XID] // 0x00000001895E82D0-0x00000001895E82F0
	private void OnHittingOther(Collider collider, Vector3 point, Vector3 normal, BaseEntity entity) {} // 0x0000000183ED72E0-0x0000000183ED76D0
	// [XID] // 0x00000001895EFBA0-0x00000001895EFBC0
	private void OnRealHittingOther(Collider collider, Vector3 point, Vector3 normal, BaseEntity entity) {} // 0x0000000183ED8F80-0x0000000183ED92D0
	// [XID] // 0x00000001895F75B0-0x00000001895F75D0
	private bool CheckEntityCanTriggerBullet(BaseEntity entity) => default; // 0x0000000183ED64C0-0x0000000183ED6710
	// [XID] // 0x00000001895FE910-0x00000001895FE930
	private void DoAfterHit() {} // 0x0000000183ED92D0-0x0000000183ED9460
}

