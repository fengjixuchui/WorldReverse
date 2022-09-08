/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class LCTrigger : LCBase // TypeDefIndex: 11775
	{
		// Fields
		private BaseEntity _baseEntity; // 0x130
		public TimerLimitType lifeType; // 0x138
		public float lifeTime; // 0x13C
		public float checkCD; // 0x140
		public float startCheckTime; // 0x144
		public TimerLimitType triggerType; // 0x148
		public int configTriggerTimesLeft; // 0x14C
		public int triggerTimesLeft; // 0x150
		public int configCheckTimesLeft; // 0x154
		public int checkTimesLeft; // 0x158
		public string shapeName; // 0x160
		public TargetType targetType; // 0x168
		private Dictionary<uint, bool> _isEntityInArea; // 0x170
		public Vector3 shapeOffset; // 0x178
		public Vector3 shapeEularOffset; // 0x184
		public bool overWriteHeight; // 0x190
		public float shapeHeight; // 0x194
		public LCTimer lcTimer; // 0x198
		public bool useCollider; // 0x1A0
		private bool _isStop; // 0x1A1
		public bool checkPoint; // 0x1A2
		public bool useSurfaceHeight; // 0x1A3
		[NonSerialized]
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public int defaultColliderLayer; // 0x1A4
		public bool changeLayer; // 0x1A8
		public BaseShape2d shape; // 0x1B0
		private MonoCollisionHelper _collisionComponent; // 0x1B8
		private GameObject _colliderObj; // 0x1C0
		private Collider _collider; // 0x1C8
		private bool _isExternalCollider; // 0x1D0
		private bool _externalColliderDefaultEnable; // 0x1D1
		private List<BaseEntity> _triggerEntities; // 0x1D8
		[NonSerialized]
		public Action<List<BaseEntity>> onTriggerEvent; // 0x1E0
		[NonSerialized]
		public Action<BaseEntity> onFieldEnter; // 0x1E8
		[NonSerialized]
		public Action<BaseEntity> onFieldExit; // 0x1F0
		[NonSerialized]
		public Action onTriggerLifeOver; // 0x1F8
		public ConcernType concernType; // 0x200
		private Action<BaseEntity> _onEntityDestroyCheck; // 0x208
		private Action<BaseEntity, bool> _onSetActiveCheck; // 0x210
		private float _checkInterval; // 0x218
	
		// Properties
		public override int metaTypeID { /* [XID] */ /* 0x00000001899BECA0-0x00000001899BECC0 */ get => default; } // 0x0000000183A34450-0x0000000183A34530 
	
		// Constructors
		public LCTrigger() {} // 0x0000000183A34210-0x0000000183A34450
	
		// Methods
		// [XID] // 0x00000001899C6780-0x00000001899C67A0
		private void ClearShape() {} // 0x0000000183A314D0-0x0000000183A31590
		// [XID] // 0x00000001899CDBA0-0x00000001899CDBC0
		public override void Init() {} // 0x0000000183A31890-0x0000000183A32820
		// [XID] // 0x0000000189B0FAB0-0x0000000189B0FAD0
		public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183A33D80-0x0000000183A34210
		// [XID] // 0x0000000189B16CA0-0x0000000189B16CC0
		private void EnableCollider(bool b) {} // 0x0000000183A32820-0x0000000183A32950
		// [XID] // 0x0000000189B1E4E0-0x0000000189B1E500
		private void UpdateCheck() {} // 0x0000000183A31090-0x0000000183A31160
		// [XID] // 0x00000001899E4080-0x00000001899E40A0
		private void UpdateShape() {} // 0x0000000183A2FFC0-0x0000000183A30270
		// [XID] // 0x0000000189B2D110-0x0000000189B2D130
		public void StopTrigger(bool isStop, bool clear) {} // 0x0000000183A33940-0x0000000183A33A40
		// [XID] // 0x0000000189B34670-0x0000000189B34690
		public bool IsEntityInArea(uint runtimeID) => default; // 0x0000000183A31790-0x0000000183A31890
		// [XID] // 0x0000000189B3BE50-0x0000000189B3BE70
		public Dictionary<uint, bool> AreaEntities() => default; // 0x0000000183A32C30-0x0000000183A32CE0
		// [XID] // 0x0000000189B43A60-0x0000000189B43A80
		public List<BaseEntity> AllEntities() => default; // 0x0000000183A30500-0x0000000183A305B0
		// [XID] // 0x0000000189B4B0C0-0x0000000189B4B0E0
		private float GetSurfaceHeight(Vector3 pos) => default; // 0x0000000183A30AE0-0x0000000183A30CF0
		// [XID] // 0x0000000189B52900-0x0000000189B52920
		public bool IsInPositionByPoint(BaseEntity e) => default; // 0x0000000183A2F980-0x0000000183A2FBB0
		// [XID] // 0x0000000189B5A320-0x0000000189B5A340
		public bool IsInPosition(BaseEntity e) => default; // 0x0000000183A33120-0x0000000183A338D0
		// [XID] // 0x0000000189B617C0-0x0000000189B617E0
		public void OnFieldCheck() {} // 0x0000000183A2F710-0x0000000183A2F980
		// [XID] // 0x0000000189B693B0-0x0000000189B693D0
		private void CheckEntities(IList<BaseEntity> entities) {} // 0x0000000183A31160-0x0000000183A312D0
		// [XID] // 0x0000000189B70850-0x0000000189B70870
		private void CheckOneEntity(BaseEntity e) {} // 0x0000000183A305B0-0x0000000183A30910
		// [XID] // 0x0000000189B77CC0-0x0000000189B77CE0
		private bool CheckEntity(BaseEntity e) => default; // 0x0000000183A30910-0x0000000183A30A80
		// [XID] // 0x0000000189B7F340-0x0000000189B7F360
		private bool CheckEntityCamp(BaseEntity e) => default; // 0x0000000183A31330-0x0000000183A314D0
		private void OnInvokeAction<T>(Action<T> action, T entity) {}
		// [XID] // 0x0000000189B86F10-0x0000000189B86F30
		public void OnFieldEnterCheck(Collider collider) {} // 0x0000000183A32D40-0x0000000183A32E50
		// [XID] // 0x0000000189B8E0A0-0x0000000189B8E0C0
		public void OnFieldExitCheck(Collider collider) {} // 0x0000000183A32FA0-0x0000000183A330B0
		// [XID] // 0x0000000189B95500-0x0000000189B95520
		private void OnEntityEnterCheck(BaseEntity entity) {} // 0x0000000183A30270-0x0000000183A30500
		// [XID] // 0x0000000189B9CB90-0x0000000189B9CBB0
		private void OntEntityReadyPost(EvtEntityReadyPost evt) {} // 0x0000000183A32E50-0x0000000183A32FA0
		// [XID] // 0x0000000189BA4240-0x0000000189BA4260
		private void OnSetActiveCheck(BaseEntity entity, bool isActive) {} // 0x0000000183A31590-0x0000000183A31790
		// [XID] // 0x0000000189BAB850-0x0000000189BAB870
		private void OnEntityDestroyCheck(BaseEntity entity) {} // 0x0000000183A33CC0-0x0000000183A33D80
		// [XID] // 0x0000000189BB2DD0-0x0000000189BB2DF0
		public void OnEntityExitCheck(BaseEntity entity, bool forceTriggerExit = false /* Metadata: 0x00AEA7EC */) {} // 0x0000000183A2F2E0-0x0000000183A2F520
		// [XID] // 0x0000000189BBA1A0-0x0000000189BBA1C0
		private void OnStayCheck(Collider collider) {} // 0x0000000183A2F5F0-0x0000000183A2F710
		// [XID] // 0x0000000189BC22E0-0x0000000189BC2300
		private void OnFieldEnter(BaseEntity entity) {} // 0x0000000183A2FCC0-0x0000000183A2FE20
		// [XID] // 0x0000000189BC9870-0x0000000189BC9890
		private void OnFieldExit(BaseEntity entity) {} // 0x0000000183A2FBB0-0x0000000183A2FCC0
		// [XID] // 0x0000000189BD1030-0x0000000189BD1050
		private void OnTrigger() {} // 0x0000000183A33A40-0x0000000183A33B50
		// [XID] // 0x0000000189BD8660-0x0000000189BD8680
		public override void OnDisable() {} // 0x0000000183A33B50-0x0000000183A33C10
		// [XID] // 0x0000000189BDFEE0-0x0000000189BDFF00
		public override void OnEnable() {} // 0x0000000183A33C10-0x0000000183A33CC0
		// [XID] // 0x00000001895ECC40-0x00000001895ECC60
		public void ClearArea() {} // 0x0000000183A32950-0x0000000183A32C30
		// [XID] // 0x00000001895F4290-0x00000001895F42B0
		public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183A2FE20-0x0000000183A2FFC0
		// [XID] // 0x00000001895FBAA0-0x00000001895FBAC0
		public override void Destroy() {} // 0x0000000183A30CF0-0x0000000183A31090
	}
}
