/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCAirflowField : LCForceFieldBase // TypeDefIndex: 11693
{
	// Fields
	public bool isLocalEntity; // 0x158
	public uint id; // 0x15C
	public bool useCollider; // 0x160
	public Vector3 floorPos; // 0x164
	public float height; // 0x170
	public float radius; // 0x174
	public float heightSpeed; // 0x178
	private float TOP_HEIGHT_START; // 0x17C
	private float TOP_HEIGHT_END; // 0x180
	private const float PUSH_CENTER_V = 10f; // Metadata: 0x00AEA6E3
	private bool _forceAir; // 0x184
	private bool _up; // 0x185
	private bool _sendMsg; // 0x186
	private bool _autoFly; // 0x187
	private int _horEffectsIx; // 0x188
	private MonoEffectProxy _horEffectProxy; // 0x190
	private int _stayEffectsIx; // 0x198
	private float _enterTime; // 0x19C
	private List<VCNonHumanoidMoveBase> _others; // 0x1A0
	private BaseEntity _cacheAvatar; // 0x1A8
	private float _lastNotifyTime; // 0x1B0
	private bool _lastFly; // 0x1B4

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897F5820-0x00000001897F5840 */ get => default; } // 0x0000000183320B80-0x0000000183320C20 

	// Constructors
	public LCAirflowField() {} // 0x0000000183320AE0-0x0000000183320B80

	// Methods
	// [XID] // 0x00000001897FCFE0-0x00000001897FD000
	public override void Init() {} // 0x000000018331E9D0-0x000000018331EF90
	// [XID] // 0x0000000189A2FB90-0x0000000189A2FBB0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018331F760-0x000000018331FAC0
	// [XID] // 0x0000000189A37480-0x0000000189A374A0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x000000018331E200-0x000000018331E300
	// [XID] // 0x0000000189813320-0x0000000189813340
	public override void Destroy() {} // 0x000000018331E300-0x000000018331E3F0
	// [XID] // 0x000000018981AE70-0x000000018981AE90
	public override void OnDisable() {} // 0x000000018331F690-0x000000018331F760
	// [XID] // 0x0000000189822650-0x0000000189822670
	private void CheckCachedAvatar() {} // 0x000000018331F0F0-0x000000018331F2D0
	// [XID] // 0x0000000189BA5DC0-0x0000000189BA5DE0
	public void EntityEnter(BaseEntity other) {} // 0x000000018331E3F0-0x000000018331E4A0
	// [XID] // 0x0000000189BAD120-0x0000000189BAD140
	protected override void OnFieldEnter(BaseEntity other) {} // 0x000000018331E100-0x000000018331E200
	// [XID] // 0x0000000189B8F9A0-0x0000000189B8F9C0
	private void DoOnFieldEnter(BaseEntity other) {} // 0x000000018331E630-0x000000018331E9D0
	// [XID] // 0x000000018983FEE0-0x000000018983FF00
	public void EntityExit(BaseEntity other) {} // 0x000000018331E4A0-0x000000018331E550
	// [XID] // 0x00000001895FEA50-0x00000001895FEA70
	protected override void OnFieldExit(BaseEntity other) {} // 0x000000018331E030-0x000000018331E100
	// [XID] // 0x000000018984EBE0-0x000000018984EC00
	private void DoOnFieldExit(BaseEntity other) {} // 0x000000018331F3B0-0x000000018331F690
	// [XID] // 0x0000000189855D30-0x0000000189855D50
	private void NotifyUI(bool jumpFly) {} // 0x000000018331DDE0-0x000000018331E030
	// [XID] // 0x0000000189BC9AC0-0x0000000189BC9AE0
	protected override void Tick(float inDeltaTime) {} // 0x000000018331FAC0-0x0000000183320AE0
	// [XID] // 0x0000000189864B10-0x0000000189864B30
	public void Unlock() {} // 0x000000018331DCA0-0x000000018331DD70
}

