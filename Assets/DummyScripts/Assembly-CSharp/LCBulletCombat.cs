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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCBulletCombat : LCGadgetCombat // TypeDefIndex: 11719
{
	// Fields
	private CollisionPlugin _collisionPlugin; // 0x1C0
	private bool _needCreateGW; // 0x1C8
	private Vector3 _colOffsetPos; // 0x1CC
	private Vector3 _colHalfSize; // 0x1D8
	private float _colRadius; // 0x1E4
	private EntityTimer _checkGWTimer; // 0x1E8
	private Func<Vector3, bool> _checkGWFunc; // 0x1F0
	private Func<Vector3, List<CollisionResult>> _checkAndCreateGWFunc; // 0x1F8
	private List<CollisionResult> _checkColResults; // 0x200
	private float _triggerGWInterval; // 0x208
	private Vector3 _bornPos; // 0x210
	private float _enableCollisionTriggerTime; // 0x21C
	private bool _alreadyEnableDelayedCollision; // 0x220
	private bool _hasAlreadyHit; // 0x221
	private bool _isDeactive; // 0x222

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B22DD0-0x0000000189B22DF0 */ get => default; } // 0x00000001830BB1F0-0x00000001830BB290 
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public ConfigBulletPattern bulletPatternConfig { /* [XID] */ /* 0x0000000189B2A460-0x0000000189B2A480 */ get => default; } // 0x00000001830B9FB0-0x00000001830BA070 
	public float flyTime { /* [XID] */ /* 0x0000000189B3BE70-0x0000000189B3BEB0 */ get; /* [XID] */ /* 0x0000000189B31980-0x0000000189B319C0 */ private set; } // 0x00000001830B9410-0x00000001830B9480 0x00000001830B9F40-0x00000001830B9FB0

	// Constructors
	public LCBulletCombat() {} // 0x00000001830BB160-0x00000001830BB1F0

	// Methods
	// [XID] // 0x0000000189B46AE0-0x0000000189B46B00
	public override void PreInit() {} // 0x00000001830BAA70-0x00000001830BAB60
	// [XID] // 0x0000000189B4E2B0-0x0000000189B4E2D0
	public override void Init() {} // 0x00000001830B9110-0x00000001830B9390
	// [XID] // 0x00000001897A0BD0-0x00000001897A0BF0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001830BAB60-0x00000001830BAD80
	// [XID] // 0x0000000189B5D330-0x0000000189B5D350
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001830B73E0-0x00000001830B7590
	// [XID] // 0x0000000189B64AD0-0x0000000189B64AF0
	private void InitCheckGW() {} // 0x00000001830B8360-0x00000001830B8AF0
	// [XID] // 0x0000000189B6BEE0-0x0000000189B6BF00
	protected override void Tick(float inDeltaTime) {} // 0x00000001830BAD80-0x00000001830BB160
	// [XID] // 0x0000000189B737F0-0x0000000189B73810
	private void CheckGW() {} // 0x00000001830B79B0-0x00000001830B7B60
	// [XID] // 0x0000000189B7AC30-0x0000000189B7AC50
	private bool NeedCheckGW(Vector3 curPos) => default; // 0x00000001830BA420-0x00000001830BA630
	// [XID] // 0x0000000189B82550-0x0000000189B82570
	private void CheckGWOnly(Vector3 curPos) {} // 0x00000001830B80A0-0x00000001830B81A0
	// [XID] // 0x0000000189B89D30-0x0000000189B89D50
	private void CheckAndCreateGW(Vector3 curPos) {} // 0x00000001830B7640-0x00000001830B7830
	// [XID] // 0x0000000189B91320-0x0000000189B91340
	private bool CheckGWBySphere(Vector3 curPos) => default; // 0x00000001830B7D20-0x00000001830B7F30
	// [XID] // 0x000000018992FE50-0x000000018992FE70
	private bool CheckGWByBox(Vector3 curPos) => default; // 0x00000001830BA750-0x00000001830BAA70
	// [XID] // 0x0000000189B9FA80-0x0000000189B9FAA0
	private List<CollisionResult> CheckAndCreateGWByBox(Vector3 curPos) => default; // 0x00000001830B9480-0x00000001830B9840
	// [XID] // 0x0000000189BA7350-0x0000000189BA7370
	private List<CollisionResult> CheckAndCreateGWBySphere(Vector3 curPos) => default; // 0x00000001830B8BA0-0x00000001830B8DE0
	// [XID] // 0x0000000189BAE460-0x0000000189BAE480
	public override void Destroy() {} // 0x00000001830B7F30-0x00000001830B80A0
	// [XID] // 0x0000000189BB5D10-0x0000000189BB5D30
	private void DoAfterHitLocal() {} // 0x00000001830BA310-0x00000001830BA3B0
	// [XID] // 0x0000000189BBD370-0x0000000189BBD390
	public void DoAfterHit(bool hitFromOtherPeer = false /* Metadata: 0x00AEA757 */) {} // 0x00000001830B8DE0-0x00000001830B9110
	// [XID] // 0x0000000189BC4F00-0x0000000189BC4F20
	private bool RemoteBulletNeedSyncBulletHit(BaseEntity hitEntity) => default; // 0x00000001830BA220-0x00000001830BA310
	// [XID] // 0x0000000189BCCAA0-0x0000000189BCCAC0
	public override void SafeDestroySelfEntity(bool forceDestroy = false /* Metadata: 0x00AEA758 */) {} // 0x00000001830B7590-0x00000001830B7640
	// [XID] // 0x0000000189BD4150-0x0000000189BD4170
	public override void KillByOther() {} // 0x00000001830B82A0-0x00000001830B8360
	// [XID] // 0x0000000189BDBA70-0x0000000189BDBA90
	public override void KillByTimer() {} // 0x00000001830B9B50-0x00000001830B9C10
	// [XID] // 0x00000001895E8330-0x00000001895E8350
	private void KillByDist() {} // 0x00000001830BA690-0x00000001830BA750
	// [XID] // 0x00000001895EFC20-0x00000001895EFC40
	private void SafeDestroySelfEntityInner(bool checkKillByOther) {} // 0x00000001830B7B60-0x00000001830B7D20
	// [XID] // 0x00000001895F7610-0x00000001895F7630
	private void FireEventKill() {} // 0x00000001830B98A0-0x00000001830B99A0
	// [XID] // 0x00000001895FE970-0x00000001895FE990
	public void TrySyncDeactiveBullet() {} // 0x00000001830B9A00-0x00000001830B9B50
	// [XID] // 0x0000000189662E60-0x0000000189662E80
	public void DeactiveBullet() {} // 0x00000001830B70D0-0x00000001830B7380
	// [XID] // 0x00000001895F2A80-0x00000001895F2AA0
	private void FireAISoundEvent() {} // 0x00000001830BA070-0x00000001830BA1B0
	// [XID] // 0x0000000189615370-0x0000000189615390
	public CollisionPlugin GetCollisionPlugin() => default; // 0x00000001830B8AF0-0x00000001830B8BA0
	// [XID] // 0x000000018961CAC0-0x000000018961CAE0
	public override ConfigBaseGadgetTriggerAction GetGadgetTriggerAction(int actionIdx) => default; // 0x00000001830B9C10-0x00000001830B9F40
	// [XID] // 0x0000000189623FC0-0x0000000189623FE0
	private void DelayEnableCollision(float inDeltaTime) {} // 0x00000001830B7830-0x00000001830B79B0
}

