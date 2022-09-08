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

public sealed class VCManekin : VCBase // TypeDefIndex: 11894
{
	// Fields
	private AvatarDataItem _avatarData; // 0x108
	public Action<BaseEntity> onManekinReadyCallBack; // 0x110
	private Animator _animator; // 0x118
	private uint _animatorHandler; // 0x120
	private UnityEngine.Object _manekinAnimatorPref; // 0x128

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018964F750-0x000000018964F770 */ get => default; } // 0x00000001836B91F0-0x00000001836B9290 

	// Constructors
	public VCManekin() {} // 0x00000001836B9160-0x00000001836B91F0

	// Methods
	// [XID] // 0x0000000189657100-0x0000000189657120
	public void InitAvatarData(AvatarDataItem avatarData) {} // 0x00000001836B8A90-0x00000001836B8B40
	// [XID] // 0x000000018965E7F0-0x000000018965E810
	public override void OnEntityReady() {} // 0x00000001836B8F90-0x00000001836B9060
	// [XID] // 0x000000018978CE10-0x000000018978CE30
	private void InitManekinAnimator() {} // 0x00000001836B8D00-0x00000001836B8EC0
	// [XID] // 0x000000018966D5D0-0x000000018966D5F0
	public void RefreshAvatarEquip() {} // 0x00000001836B8990-0x00000001836B8A30
	// [XID] // 0x00000001897942E0-0x0000000189794300
	private void InitManekinAvatarEquip(bool bindCallback = true /* Metadata: 0x00AEAE53 */) {} // 0x00000001836B8B40-0x00000001836B8D00
	// [XID] // 0x000000018967CC60-0x000000018967CC80
	private void InitManekinFlyAttachment() {} // 0x00000001836B8610-0x00000001836B86F0
	// [XID] // 0x0000000189684200-0x0000000189684220
	private void InitManekinElementColor() {} // 0x00000001836B9060-0x00000001836B9160
	// [XID] // 0x000000018968BEB0-0x000000018968BED0
	public void ShowEquipOnManekin(ulong guid) {} // 0x00000001836B87E0-0x00000001836B8990
	// [XID] // 0x0000000189693A50-0x0000000189693A70
	public override void Destroy() {} // 0x00000001836B86F0-0x00000001836B87E0
}

