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

public class VCHitableCombat : VCBaseCombat // TypeDefIndex: 11879
{
	// Fields
	protected EntityFrameHaltPlugin _frameHalt; // 0x188
	private string _hitBloodEffect; // 0x190
	private bool _hitAutoRedirect; // 0x198
	private bool _muteAllHitAnim; // 0x199
	private bool _muteAllHitEffect; // 0x19A
	private bool _muteAllHitText; // 0x19B
	private int _targetMuteHitEffectCount; // 0x19C
	protected string _cureEffectPatternName; // 0x1A0
	private bool _hasBlendShake; // 0x1A8
	private Dictionary<uint, float> _hitShakeMap; // 0x1B0
	public bool isHitAir; // 0x1B8
	public int hitAirFrameCount; // 0x1BC

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897BA540-0x00000001897BA560 */ get => default; } // 0x000000018280FBA0-0x000000018280FC40 
	public int targetMuteHitEffectCount { /* [XID] */ /* 0x0000000189625830-0x0000000189625850 */ get => default; /* [XID] */ /* 0x000000018960F3D0-0x000000018960F3F0 */ set {} } // 0x000000018280DD80-0x000000018280DE20 0x000000018280F0E0-0x000000018280F190
	public bool hasBlendShake { /* [XID] */ /* 0x00000001897D1270-0x00000001897D1290 */ get => default; } // 0x000000018280B2A0-0x000000018280B350 

	// Constructors
	public VCHitableCombat() {} // 0x000000018280FAF0-0x000000018280FBA0

	// Methods
	// [XID] // 0x0000000189685B90-0x0000000189685BB0
	public override void Init() {} // 0x000000018280D440-0x000000018280D5D0
	// [XID] // 0x00000001897E0580-0x00000001897E05A0
	protected void InitCureEffSetting() {} // 0x000000018280F9F0-0x000000018280FAF0
	// [XID] // 0x00000001897E7C50-0x00000001897E7C70
	protected void InitHitEffSetting() {} // 0x000000018280F8B0-0x000000018280F9F0
	// [XID] // 0x00000001897EF820-0x00000001897EF840
	public override void OnEntityReady() {} // 0x000000018280F4B0-0x000000018280F8B0
	// [XID] // 0x000000018983D1C0-0x000000018983D1E0
	public override void Destroy() {} // 0x000000018280B740-0x000000018280B7E0
	// [XID] // 0x00000001897FE540-0x00000001897FE560
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x000000018280B350-0x000000018280B410
	// [XID] // 0x0000000189805C50-0x0000000189805C70
	private GameObject GetClosetHitObject(Collider hitCollider, Vector3 hitPoint, ref float radius) => default; // 0x000000018280CD50-0x000000018280D280
	// [XID] // 0x000000018980D4C0-0x000000018980D4E0
	private NamedCollider GetHitBoxByCollder(Collider hitCollider) => default; // 0x000000018280F190-0x000000018280F280
	// [XID] // 0x0000000189814B50-0x0000000189814B70
	private Vector3 GetRandomPointInHitObject(GameObject hitObject, float radius) => default; // 0x000000018280EC20-0x000000018280EED0
	// [XID] // 0x00000001898C3630-0x00000001898C3650
	private Vector3 GetDamageEffectRelativePosition(AttackResult attackResult) => default; // 0x000000018280B500-0x000000018280B740
	// [XID] // 0x00000001898CAFF0-0x00000001898CB010
	protected virtual bool IsInDamageAnimationValidState() => default; // 0x000000018280DCE0-0x000000018280DD80
	// [XID] // 0x0000000189900110-0x0000000189900130
	protected virtual void DamgeRetreat(Vector3 retreatDir) {} // 0x000000018280D280-0x000000018280D340
	// [XID] // 0x00000001898328E0-0x0000000189832900
	protected virtual void HitAir(Vector3 retreatDir) {} // 0x000000018280C680-0x000000018280C740
	// [XID] // 0x0000000189839F50-0x0000000189839F70
	protected virtual void BeHit(AttackResult attackResult) {} // 0x000000018280C740-0x000000018280CD50
	// [XID] // 0x0000000189841480-0x00000001898414A0
	protected void HitShake(AttackResult attackResult) {} // 0x000000018280D760-0x000000018280D9B0
	// [XID] // 0x0000000189848940-0x0000000189848960
	public void SetHitAutoRedirect(bool setEnable) {} // 0x000000018280D6B0-0x000000018280D760
	// [XID] // 0x00000001898E99F0-0x00000001898E9A10
	public override void DoCure(float addHP) {} // 0x000000018280F280-0x000000018280F4B0
	// [XID] // 0x0000000189857460-0x0000000189857480
	public virtual void FrameHalt(float haltTimeScale, float haltTime) {} // 0x000000018280D5D0-0x000000018280D6B0
	// [XID] // 0x000000018985E680-0x000000018985E6A0
	public override void DoDamageResolved(EvtBeingHit evtBeingHit) {} // 0x000000018280B180-0x000000018280B240
	// [XID] // 0x0000000189970100-0x0000000189970120
	public override void DoDamageResolvedReconcile(AttackResult attackResult) {} // 0x000000018280EFB0-0x000000018280F070
	// [XID] // 0x000000018986D590-0x000000018986D5B0
	public override void DoDamageResolvedRemote(EvtBeingHit evtBeingHit) {} // 0x000000018280B410-0x000000018280B500
	// [XID] // 0x0000000189943510-0x0000000189943530
	private string GetHitBloodEffect(EvtBeingHit evtBeingHit) => default; // 0x000000018280C3F0-0x000000018280C680
	// [XID] // 0x000000018987C5E0-0x000000018987C600
	protected void DoDamageResolvedCommon(EvtBeingHit evtBeingHit) {} // 0x000000018280B7E0-0x000000018280C3F0
	// [XID] // 0x0000000189977F10-0x0000000189977F30
	protected void DoDamageResolvedShowDamageText(AttackResult attackResult) {} // 0x000000018280DA10-0x000000018280DCE0
	// [XID] // 0x000000018988AE90-0x000000018988AEB0
	private void DoDamageResolvedAnimation(EvtBeingHit evtBeingHit) {} // 0x000000018280DEA0-0x000000018280EBB0
}

