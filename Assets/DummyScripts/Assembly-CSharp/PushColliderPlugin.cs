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

public sealed class PushColliderPlugin : BaseComponentPlugin // TypeDefIndex: 12149
{
	// Fields
	private EntityTimer _timer; // 0x58
	private CapsuleCollider _pushCollider; // 0x60
	private float _radiusScale; // 0x68
	private float _offset; // 0x6C
	private float _stay; // 0x70
	private Vector3 _initCenter; // 0x74
	private float _initRadius; // 0x80

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898AB300-0x00000001898AB320 */ get => default; } // 0x0000000182C0CFE0-0x0000000182C0D080 

	// Constructors
	public PushColliderPlugin() {} // 0x0000000182C0CF80-0x0000000182C0CFE0

	// Methods
	// [XID] // 0x00000001898B2C60-0x00000001898B2C80
	public override void Init() {} // 0x0000000182C0C810-0x0000000182C0C9F0
	// [XID] // 0x00000001898BAB60-0x00000001898BAB80
	public override void Destroy() {} // 0x0000000182C0C590-0x0000000182C0C670
	// [XID] // 0x00000001898C1CF0-0x00000001898C1D10
	public void PushCollider(AnimatorEventPushCollider evt) {} // 0x0000000182C0C400-0x0000000182C0C590
	// [XID] // 0x00000001898C96E0-0x00000001898C9700
	private void StateIDChanged(EvtStateIDChanged evt) {} // 0x0000000182C0C750-0x0000000182C0C810
	// [XID] // 0x00000001898D0FA0-0x00000001898D0FC0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000182C0C270-0x0000000182C0C400
	// [XID] // 0x00000001898D8580-0x00000001898D85A0
	public override void Tick(float inDeltaTime) {} // 0x0000000182C0CBE0-0x0000000182C0CF80
	// [XID] // 0x00000001898E03E0-0x00000001898E0400
	public override void OnDisable() {} // 0x0000000182C0CB30-0x0000000182C0CBE0
}

