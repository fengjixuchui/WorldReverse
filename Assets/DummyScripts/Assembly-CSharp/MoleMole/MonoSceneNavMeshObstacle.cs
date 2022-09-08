/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.AI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoSceneNavMeshObstacle : MonoLightActiveBase // TypeDefIndex: 31786
	{
		// Fields
		private const float TIME_TO_STATIONARY = 0.5f; // Metadata: 0x00B136F5
		public int checkMoveListIndex; // 0x18
		public NavMeshObstacleShape shape; // 0x1C
		public Vector3 center; // 0x20
		public Vector3 extents; // 0x2C
		public ObstacleInfo pbInfo; // 0x38
		private bool _isValid; // 0x40
		private MoveStateType _moveState; // 0x44
		private float _stationaryTime; // 0x48
		private Vector3 _lastPosition; // 0x4C
		private Quaternion _lastRotation; // 0x58
		private Vector3 _lastScale; // 0x68
		private NavMeshObstacle obstacle; // 0x78
	
		// Nested types
		public enum MoveStateType // TypeDefIndex: 31787
		{
			Stationary = 0,
			StartMove = 1,
			Move = 2,
			EndMove = 3
		}
	
		// Constructors
		public MonoSceneNavMeshObstacle() {} // 0x0000000181438990-0x0000000181438A00
	
		// Methods
		// [XID] // 0x0000000189889B40-0x0000000189889B60
		private void Awake() {} // 0x0000000181437150-0x00000001814372B0
		// [XID] // 0x0000000189891160-0x0000000189891180
		private void OnDestroy() {} // 0x0000000181437DF0-0x0000000181437ED0
		// [XID] // 0x0000000189898720-0x0000000189898740
		private void OnEnable() {} // 0x0000000181438050-0x0000000181438400
		// [XID] // 0x000000018989F960-0x000000018989F980
		private void OnDisable() {} // 0x0000000181437ED0-0x0000000181438050
		// [XID] // 0x00000001898A7340-0x00000001898A7360
		public override void OnRegisterGameObjectLightweightActivate() {} // 0x0000000181438400-0x00000001814384A0
		// [XID] // 0x00000001898AED60-0x00000001898AED80
		public override void OnRegisterGameObjectLightweightDeactivate() {} // 0x00000001814384A0-0x0000000181438540
		// [XID] // 0x00000001898B6160-0x00000001898B6180
		private void SnapshotTransform() {} // 0x0000000181437420-0x0000000181437560
		// [XID] // 0x00000001898BD9B0-0x00000001898BD9D0
		private bool HasMoved() => default; // 0x00000001814378E0-0x0000000181437B20
		// [XID] // 0x00000001898C5300-0x00000001898C5320
		public MoveStateType CheckMoved(float time) => default; // 0x00000001814372B0-0x00000001814373C0
		// [XID] // 0x00000001898CC7F0-0x00000001898CC810
		public bool IsValid() => default; // 0x0000000181437560-0x00000001814378E0
		// [XID] // 0x00000001898D4250-0x00000001898D4270
		public void RefreshPbInfo() {} // 0x00000001814385F0-0x0000000181438990
		// [XID] // 0x00000001898DBA30-0x00000001898DBA50
		private Vector3 GetWorldExtents() => default; // 0x0000000181437B20-0x0000000181437DF0
		// [XID] // 0x00000001898E3650-0x00000001898E3670
		private ObstacleInfo.Types.ShapeType ToPbShapeType(NavMeshObstacleShape shape) => default; // 0x0000000181438540-0x00000001814385F0
	}
}
