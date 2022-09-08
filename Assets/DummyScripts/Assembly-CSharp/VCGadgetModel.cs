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

public sealed class VCGadgetModel : VCBaseModel // TypeDefIndex: 11871
{
	// Fields
	private uint _occlusionTexResHandle; // 0x1E0
	private AsyncJob _job; // 0x1E8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B824D0-0x0000000189B824F0 */ get => default; } // 0x00000001822486A0-0x0000000182248740 

	// Constructors
	public VCGadgetModel() {} // 0x0000000182248640-0x00000001822486A0

	// Methods
	// [XID] // 0x0000000189B4E470-0x0000000189B4E490
	public override void Init() {} // 0x0000000182247A90-0x0000000182247CB0
	// [XID] // 0x0000000189B912C0-0x0000000189B912E0
	public override void Destroy() {} // 0x0000000182247770-0x0000000182247820
	// [XID] // 0x0000000189B98550-0x0000000189B98570
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001822476B0-0x0000000182247770
	// [XID] // 0x0000000189B6BF60-0x0000000189B6BF80
	public override void PostReInit() {} // 0x0000000182248450-0x0000000182248640
	// [XID] // 0x0000000189BA7310-0x0000000189BA7330
	private void LoadBackedOcclusionTexture() {} // 0x0000000182247D10-0x0000000182247F20
	// [XID] // 0x0000000189BAE420-0x0000000189BAE440
	public override void OnEntityReady() {} // 0x0000000182248060-0x0000000182248250
	// [XID] // 0x00000001896B8610-0x00000001896B8630
	private void AsyncLoadCallback(ulong hash, bool loadSucceeded, uint handle, Texture2D asset) {} // 0x0000000182247880-0x0000000182247A90
	// [XID] // 0x0000000189BBD330-0x0000000189BBD350
	private void ReleaseBackedOcclusionTexture() {} // 0x0000000182248250-0x0000000182248450
}

