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

public sealed class EquipAwayFromHandControllerPlugin : BaseEquipControllerPlugin // TypeDefIndex: 12046
{
	// Fields
	private Dictionary<int, WeaponAwayFromHandState> _animStateToEquipAwayFromHandData; // 0x90
	private float _delayAppearTime; // 0x98
	private float _dissolveShowTime; // 0x9C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896B20F0-0x00000001896B2110 */ get => default; } // 0x0000000184947100-0x00000001849471A0 

	// Constructors
	public EquipAwayFromHandControllerPlugin() {} // Dummy constructor
	public EquipAwayFromHandControllerPlugin(VCAvatarEquipController vcEquipController, ConfigCharacter config) {} // 0x0000000184947060-0x0000000184947100

	// Methods
	// [XID] // 0x00000001896B9B40-0x00000001896B9B60
	public override void Init() {} // 0x0000000184946C00-0x0000000184946F30
	// [XID] // 0x00000001896C0F20-0x00000001896C0F40
	public override void Destroy() {} // 0x00000001849465F0-0x00000001849466B0
	// [XID] // 0x00000001896C84C0-0x00000001896C84E0
	protected override void OnAnimatorChanged() {} // 0x0000000184946A40-0x0000000184946C00
	// [XID] // 0x00000001896CFE70-0x00000001896CFE90
	protected override void UpdateEquipController() {} // 0x00000001849466B0-0x0000000184946850
	// [XID] // 0x00000001896D7200-0x00000001896D7220
	private void ShowEquip(float dissolveTime) {} // 0x00000001849462F0-0x0000000184946530
	// [XID] // 0x00000001896DEAF0-0x00000001896DEB10
	private void HideEquip(float dissolveTime) {} // 0x0000000184946850-0x0000000184946A40
}

