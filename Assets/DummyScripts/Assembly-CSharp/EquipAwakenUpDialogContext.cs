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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EquipAwakenUpDialogContext : BaseDialogContext // TypeDefIndex: 29020
{
	// Fields
	private MonoEquipAwakenUpDialog _dialogMono; // 0x178
	private WeaponItem _equip; // 0x180
	private Dictionary<uint, uint> _newAffixDic; // 0x188
	private uint _targetWeaponAwakenLevel; // 0x190
	private bool _canClose; // 0x194

	// Constructors
	public EquipAwakenUpDialogContext() {} // Dummy constructor
	public EquipAwakenUpDialogContext(WeaponItem equip, Dictionary<uint, uint> newAffixDic, uint targetWeaponAwakenLevel) {} // 0x00000001823DA770-0x00000001823DA870

	// Methods
	// [XID] // 0x00000001898EE690-0x00000001898EE6B0
	public override void SetupView() {} // 0x00000001823DA5D0-0x00000001823DA770
	// [XID] // 0x00000001898F5E20-0x00000001898F5E40
	protected override void BindViewCallbacks() {} // 0x00000001823D96C0-0x00000001823D97C0
	// [XID] // 0x00000001898FD660-0x00000001898FD680
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001823DA3A0-0x00000001823DA510
	// [XID] // 0x0000000189904F20-0x0000000189904F40
	private void ScrollScroller(float delta) {} // 0x00000001823D9530-0x00000001823D96C0
	// [XID] // 0x000000018990C720-0x000000018990C740
	private void ShowWeaponAffix() {} // 0x00000001823D9B70-0x00000001823DA340
	// [XID] // 0x0000000189913FD0-0x0000000189913FF0
	private void SetViewStyle() {} // 0x00000001823D9850-0x00000001823D9B70
}

