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

public sealed class EquipLevelUpDialogContext : BaseDialogContext // TypeDefIndex: 29021
{
	// Fields
	private const string PROPERTY_ITEM_PREFAB_PATH = "ART/UI/Menus/Widget/EquipOverview/EquipPropertyItem"; // Metadata: 0x00B0E92A
	private const string MAIN_PROP_ITEM_PREFAB_PATH = "ART/UI/Menus/Widget/EquipOverview/EquipMainPropertyItem"; // Metadata: 0x00B0E961
	private MonoAvatarPropertyItem _propertyItemPrefab; // 0x178
	private uint _propertyItemPrefabHandle; // 0x180
	private uint _mainPropItemPrefabHandle; // 0x184
	private MonoEquipLevelUpDialog _dialogMono; // 0x188
	private BagItem _equip; // 0x190
	private uint _prevLevel; // 0x198
	private uint _currLevel; // 0x19C
	private uint _powerUpRate; // 0x1A0
	private List<PropertyChange> _propertyChange; // 0x1A8
	private ItemType _equipType; // 0x1B0
	private bool _canClose; // 0x1B4
	private RepeatedMessageField<ItemParam> _returnedMaterialList; // 0x1B8

	// Constructors
	public EquipLevelUpDialogContext() {} // Dummy constructor
	public EquipLevelUpDialogContext(BagItem equip, uint prevLevel, uint currLevel, RepeatedMessageField<ItemParam> returnedMaterialList = null, uint powerUpRate = 1 /* Metadata: 0x00B0E926 */, List<uint> oldAppendPropList = null, List<uint> curAppendPropList = null) {} // 0x000000018204BDD0-0x000000018204BF80

	// Methods
	// [XID] // 0x0000000189926130-0x0000000189926150
	public override void SetupView() {} // 0x000000018204B560-0x000000018204BDD0
	// [XID] // 0x000000018992D860-0x000000018992D880
	protected override void BindViewCallbacks() {} // 0x0000000182049170-0x0000000182049270
	// [XID] // 0x0000000189934CF0-0x0000000189934D10
	private void ShowReturnedMaterialAndCloseDialog() {} // 0x000000018204AB30-0x000000018204AE40
	// [XID] // 0x000000018993C7E0-0x000000018993C800
	public override void ClearView() {} // 0x0000000182049270-0x00000001820493A0
	// [XID] // 0x0000000189943E10-0x0000000189943E30
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018204AEA0-0x000000018204B0D0
	// [XID] // 0x000000018994B330-0x000000018994B350
	private void ScrollScroller(float delta) {} // 0x0000000182048FE0-0x0000000182049170
	// [XID] // 0x0000000189952CE0-0x0000000189952D00
	private void InitWeaponPropChange() {} // 0x000000018204B190-0x000000018204B500
	// [IDTag] // 0x000000018995A290-0x000000018995A2D0
	// [XID] // 0x000000018995A290-0x000000018995A2D0
	private void InitReliquaryPropChange(List<uint> oldAppendPropList, List<uint> curAppendPropList) {} // 0x0000000182049A80-0x000000018204A290
	// [IDTag] // 0x0000000189964A90-0x0000000189964AD0
	// [XID] // 0x0000000189964A90-0x0000000189964AD0
	private void InitReliquaryPropChange() {} // 0x0000000182049580-0x0000000182049A80
	// [XID] // 0x000000018996EE70-0x000000018996EE90
	private void SetPowerUpText() {} // 0x000000018204A890-0x000000018204AB30
	// [XID] // 0x0000000189976A50-0x0000000189976A70
	private void SetPowerUpLight(int index) {} // 0x00000001820493A0-0x0000000182049580
	// [XID] // 0x000000018997DE90-0x000000018997DEB0
	private void SetViewStyle() {} // 0x000000018204A320-0x000000018204A890
}

