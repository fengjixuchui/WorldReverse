/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCBaseBillboardPlugin : BaseComponentPlugin // TypeDefIndex: 12157
{
	// Fields
	protected VCBillboard _vcBillboard; // 0x58
	protected MonoBillboard _monoBillboard; // 0x60
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _showDistance; // 0x68
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float markShowDistance; // 0x6C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _nameShowDistance; // 0x70
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _ditherDistance; // 0x74
	protected float _deadline; // 0x7C
	private const float CACHE_DURATION = 5f; // Metadata: 0x00AEB585
	private bool _enableScaleAdapt; // 0x80

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189AC2D30-0x0000000189AC2D50 */ get => default; } // 0x000000018327EF00-0x000000018327EFA0 
	public float showDistance { /* [XID] */ /* 0x0000000189ACA400-0x0000000189ACA420 */ get => default; /* [XID] */ /* 0x0000000189AD1DE0-0x0000000189AD1E00 */ protected set {} } // 0x000000018327EA90-0x000000018327EB40 0x000000018327E360-0x000000018327E410
	public float ditherDistance { /* [XID] */ /* 0x0000000189AD9950-0x0000000189AD9970 */ get => default; /* [XID] */ /* 0x0000000189AE1570-0x0000000189AE1590 */ protected set {} } // 0x000000018327DFF0-0x000000018327E0A0 0x000000018327E2B0-0x000000018327E360
	public bool forceHideUI { /* [XID] */ /* 0x0000000189AE89B0-0x0000000189AE89F0 */ get; /* [XID] */ /* 0x0000000189AF36A0-0x0000000189AF36E0 */ set; } // 0x000000018327DE60-0x000000018327DEC0 0x000000018327E410-0x000000018327E470
	public virtual bool isValid { /* [XID] */ /* 0x0000000189B0C980-0x0000000189B0C9A0 */ get => default; } // 0x000000018327E8D0-0x000000018327E970 
	public float deadline { /* [XID] */ /* 0x0000000189B13F80-0x0000000189B13FA0 */ get => default; /* [XID] */ /* 0x0000000189B1B7B0-0x0000000189B1B7D0 */ set {} } // 0x000000018327DF20-0x000000018327DFF0 0x000000018327E820-0x000000018327E8D0
	public virtual bool isActive { /* [XID] */ /* 0x0000000189B2A3E0-0x0000000189B2A400 */ get => default; } // 0x000000018327EC50-0x000000018327ECF0 
	public bool enableScaleAdapt { /* [XID] */ /* 0x0000000189B31940-0x0000000189B31960 */ get => default; /* [XID] */ /* 0x0000000189B38DD0-0x0000000189B38DF0 */ protected set {} } // 0x000000018327E550-0x000000018327E600 0x000000018327E150-0x000000018327E200

	// Constructors
	public VCBaseBillboardPlugin() {} // 0x000000018327EE70-0x000000018327EF00

	// Methods
	// [XID] // 0x0000000189AFDB70-0x0000000189AFDB90
	public override void Init() {} // 0x000000018327E600-0x000000018327E820
	// [XID] // 0x0000000189B052D0-0x0000000189B052F0
	public override void Destroy() {} // 0x000000018327E200-0x000000018327E2B0
	// [XID] // 0x00000001899C04E0-0x00000001899C0500
	public void DelayDeadline(float delay = 5f /* Metadata: 0x00AEB581 */) {} // 0x000000018327E9D0-0x000000018327EA90
	// [XID] // 0x0000000189B408F0-0x0000000189B40910
	public virtual void LateUpdateView(Vector3 cameraPosition, Vector3 billboardPosition) {} // 0x000000018327E470-0x000000018327E550
	// [XID] // 0x0000000189B48270-0x0000000189B48290
	public virtual void RefreshViewOnEnable() {} // 0x000000018327EB40-0x000000018327EBE0
	// [XID] // 0x0000000189B4FA70-0x0000000189B4FA90
	protected void UpdateScale(Transform transformToRescale) {} // 0x000000018327ECF0-0x000000018327EE70
	// [XID] // 0x0000000189B57160-0x0000000189B57180
	public void SetMarkShowDistance(float distance) {} // 0x000000018327E0A0-0x000000018327E150
}

