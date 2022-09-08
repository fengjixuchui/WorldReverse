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

public sealed class VCAutoAttract : VCBasePickable, IAutoAttract // TypeDefIndex: 11786
{
	// Fields
	private const float MAX_ATTRACT_DISTANCE = 30f; // Metadata: 0x00AEAB43
	private const float FAN_ANGLE = 360f; // Metadata: 0x00AEAB47
	private const float UP_SPEED = 8f; // Metadata: 0x00AEAB4B
	private const float BACK_SPEED = 4.8f; // Metadata: 0x00AEAB4F
	private const float ATTACK_ADD_SPEED = 8f; // Metadata: 0x00AEAB53
	private float upSpeed; // 0x190
	private float backSpeed; // 0x194
	private float attactAddSpeed; // 0x198
	private float curDelayTime; // 0x19C
	private float attactSpeed; // 0x1A0
	public float attractDelayTime; // 0x1A4
	private const float GRAVITY_ADD_SPEED = 16f; // Metadata: 0x00AEAB57
	private const float BACK_ADD_SPEED = 12f; // Metadata: 0x00AEAB5B
	private const float ATTRACT_ADD_ADD_SPEED = 16f; // Metadata: 0x00AEAB5F
	private const float MAX_ATTRACT_ADD_SPEED = 20f; // Metadata: 0x00AEAB63
	private const float MAX_ATTRACT_SPEED = 50f; // Metadata: 0x00AEAB67
	private const float MIN_DISTANCE = 0.2f; // Metadata: 0x00AEAB6B
	private Vector3 _backVelocityDir; // 0x1A8
	private Vector3 _upVelocityDir; // 0x1B4
	public Action onPickup; // 0x1C0
	private bool initialized; // 0x1C8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189BBA180-0x0000000189BBA1A0 */ get => default; } // 0x0000000182A4DBE0-0x0000000182A4DC80 

	// Constructors
	public VCAutoAttract() {} // 0x0000000182A4DB60-0x0000000182A4DBE0

	// Methods
	// [XID] // 0x0000000189BC22C0-0x0000000189BC22E0
	public override void Init() {} // 0x0000000182A4D2A0-0x0000000182A4D360
	// [XID] // 0x0000000189BC9850-0x0000000189BC9870
	public override void Destroy() {} // 0x0000000182A4CE80-0x0000000182A4CF30
	// [XID] // 0x0000000189BD1010-0x0000000189BD1030
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000182A4DA90-0x0000000182A4DB60
	// [XID] // 0x0000000189BD8640-0x0000000189BD8660
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000182A4CCB0-0x0000000182A4CD70
	// [XID] // 0x0000000189BDFEC0-0x0000000189BDFEE0
	private void ResetAutoAttract() {} // 0x0000000182A4D0C0-0x0000000182A4D2A0
	// [XID] // 0x00000001895ECC20-0x00000001895ECC40
	private void ReleaseAutoAttract() {} // 0x0000000182A4CD70-0x0000000182A4CE80
	// [XID] // 0x000000018977B050-0x000000018977B070
	protected override void InitPickComponents() {} // 0x0000000182A4CFC0-0x0000000182A4D060
	// [XID] // 0x0000000189782C00-0x0000000189782C20
	protected override Vector3 GetInitVelocity() => default; // 0x0000000182A4C7F0-0x0000000182A4CBE0
	// [XID] // 0x0000000189603220-0x0000000189603240
	public bool SetTarget(Vector3 targetPos) => default; // 0x0000000182A4D3C0-0x0000000182A4D9B0
	// [XID] // 0x000000018960AC00-0x000000018960AC20
	public void Pickup() {} // 0x0000000182A4C4C0-0x0000000182A4C7F0
}

