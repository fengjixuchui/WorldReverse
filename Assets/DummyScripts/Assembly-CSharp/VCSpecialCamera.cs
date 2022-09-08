/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCSpecialCamera : VCBase // TypeDefIndex: 11960
{
	// Fields
	private float _checkTimer; // 0x108
	private const float CHECK_TIME = 0.5f; // Metadata: 0x00AEAF8E
	private ConfigSpecialCamera _config; // 0x110
	private bool _inState; // 0x118

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189941930-0x0000000189941950 */ get => default; } // 0x0000000183A579A0-0x0000000183A57A40 

	// Constructors
	public VCSpecialCamera() {} // 0x0000000183A57920-0x0000000183A579A0

	// Methods
	// [XID] // 0x00000001899493F0-0x0000000189949410
	public override void Init() {} // 0x0000000183A56ED0-0x0000000183A56F70
	// [XID] // 0x0000000189950CB0-0x0000000189950CD0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183A576D0-0x0000000183A57810
	// [XID] // 0x00000001899584D0-0x00000001899584F0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183A56BC0-0x0000000183A56C90
	// [XID] // 0x000000018995FB50-0x000000018995FB70
	public override void OnEntityReady() {} // 0x0000000183A57590-0x0000000183A576D0
	// [XID] // 0x0000000189967470-0x0000000189967490
	public override void Destroy() {} // 0x0000000183A56C90-0x0000000183A56D40
	// [XID] // 0x000000018996E6C0-0x000000018996E6E0
	protected override void Tick(float inDeltaTime) {} // 0x0000000183A57810-0x0000000183A57920
	// [XID] // 0x00000001899761D0-0x00000001899761F0
	private void CheckAdjustCamera() {} // 0x0000000183A56FD0-0x0000000183A57270
	// [XID] // 0x000000018997D460-0x000000018997D480
	private void EnterCameraAdjust() {} // 0x0000000183A57270-0x0000000183A573B0
	// [XID] // 0x0000000189985000-0x0000000189985020
	private void ExitCameraAdjust() {} // 0x0000000183A56DC0-0x0000000183A56ED0
	// [XID] // 0x000000018998CC00-0x000000018998CC20
	public void ClearState() {} // 0x0000000183A573B0-0x0000000183A57450
}

