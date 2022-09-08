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

public sealed class VCReboundAttract : VCBasePickable // TypeDefIndex: 11938
{
	// Fields
	private float _lastCheckTime; // 0x190
	private Vector3 _controlVelocity; // 0x194
	public Vector3 initVelocity; // 0x1A0
	public bool isMonsterDrop; // 0x1AC
	private uint _dropSound; // 0x1B0
	private float _bounceCheckThreshold; // 0x1B4
	private Vector3 _lastPredictPos; // 0x1B8
	private float _lastVelocityY; // 0x1C4
	private int _dropSoundPlayedCount; // 0x1C8
	private readonly int DROP_SOUND_LIMIT; // 0x1CC
	public Action onPickup; // 0x1D0
	private float _curDelayTime; // 0x1D8
	private float _attractAdd; // 0x1DC
	private float _attractSpeed; // 0x1E0
	private Vector3 _targetPos; // 0x1E4
	private AvatarEntity _avatar; // 0x1F0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A9BC00-0x0000000189A9BC20 */ get => default; } // 0x000000018299E3B0-0x000000018299E450 

	// Constructors
	public VCReboundAttract() {} // 0x000000018299E280-0x000000018299E3B0

	// Methods
	// [XID] // 0x0000000189AA3160-0x0000000189AA3180
	public override void Init() {} // 0x000000018299D5A0-0x000000018299D680
	// [XID] // 0x0000000189AC8D60-0x0000000189AC8D80
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018299E030-0x000000018299E120
	// [XID] // 0x0000000189AAA650-0x0000000189AAA670
	public void CheckConfigCollider() {} // 0x000000018299A830-0x000000018299ABA0
	// [XID] // 0x0000000189AD0520-0x0000000189AD0540
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x000000018299AC90-0x000000018299AD40
	// [XID] // 0x0000000189AD8250-0x0000000189AD8270
	public override void Destroy() {} // 0x000000018299AD40-0x000000018299AE70
	// [XID] // 0x0000000189ADFF20-0x0000000189ADFF40
	protected override Vector3 GetInitVelocity() => default; // 0x000000018299A2A0-0x000000018299A6D0
	// [XID] // 0x0000000189A108A0-0x0000000189A108C0
	protected override Vector3 GetInitAngularVelocity() => default; // 0x000000018299C980-0x000000018299D130
	// [XID] // 0x0000000189A17F50-0x0000000189A17F70
	protected override void InitPickComponents() {} // 0x000000018299B9B0-0x000000018299BE90
	// [XID] // 0x0000000189A1F570-0x0000000189A1F590
	protected override void RemovePickableComponents() {} // 0x000000018299DCC0-0x000000018299DD60
	// [XID] // 0x0000000189A26A90-0x0000000189A26AB0
	private void CheckPlayDropEffect() {} // 0x000000018299D740-0x000000018299D880
	// [XID] // 0x0000000189B360B0-0x0000000189B360D0
	private void CheckPlayLandSound(float deltaTime) {} // 0x000000018299B370-0x000000018299B860
	// [XID] // 0x0000000189B54260-0x0000000189B54280
	protected override void Tick(float inDeltaTime) {} // 0x000000018299E120-0x000000018299E280
	// [XID] // 0x0000000189BDFF40-0x0000000189BDFF60
	private bool HandleState() => default; // 0x000000018299BE90-0x000000018299C1E0
	// [XID] // 0x0000000189603480-0x00000001896034A0
	private bool NeedSelfRotate() => default; // 0x000000018299DD60-0x000000018299DE50
	// [XID] // 0x0000000189A4BF30-0x0000000189A4BF50
	private void CheckInitRotation() {} // 0x000000018299C370-0x000000018299C730
	// [XID] // 0x0000000189626F50-0x0000000189626F70
	public override void ResetPickComponents(bool forceReset = false /* Metadata: 0x00AEAF7D */) {} // 0x000000018299D880-0x000000018299D980
	// [XID] // 0x0000000189852C10-0x0000000189852C30
	public override void OnSceneLoad() {} // 0x000000018299C2C0-0x000000018299C370
	// [XID] // 0x0000000189AB24D0-0x0000000189AB24F0
	private void InitDropSound() {} // 0x000000018299D980-0x000000018299DB50
	// [XID] // 0x0000000189B45600-0x0000000189B45620
	private void PlayDropSound() {} // 0x000000018299C790-0x000000018299C980
	// [XID] // 0x0000000189B79750-0x0000000189B79770
	private void PlayAttractSound() {} // 0x000000018299D130-0x000000018299D3A0
	// [XID] // 0x0000000189982720-0x0000000189982740
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x000000018299C1E0-0x000000018299C2C0
	// [XID] // 0x0000000189A80940-0x0000000189A80960
	protected override bool OnEvent(BaseEvent e) => default; // 0x000000018299DEC0-0x000000018299DFD0
	// [XID] // 0x0000000189A88420-0x0000000189A88440
	private void AppearFromServer(EvtAppearFromServer evt) {} // 0x000000018299B860-0x000000018299B930
	// [XID] // 0x0000000189AC1510-0x0000000189AC1530
	private void InitPickUp() {} // 0x000000018299ABA0-0x000000018299AC90
	// [XID] // 0x0000000189A973F0-0x0000000189A97410
	private void InitGrandChildTransform() {} // 0x000000018299D3A0-0x000000018299D5A0
	// [XID] // 0x0000000189A9E790-0x0000000189A9E7B0
	public bool UpdateAttract() => default; // 0x000000018299AF00-0x000000018299B370
	// [XID] // 0x0000000189AA6180-0x0000000189AA61A0
	public void Pickup() {} // 0x0000000182999F80-0x000000018299A2A0
}

