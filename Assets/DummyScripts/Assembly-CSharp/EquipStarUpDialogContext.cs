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

public sealed class EquipStarUpDialogContext : BaseDialogContext // TypeDefIndex: 29050
{
	// Fields
	private const string PROPERTY_ITEM_PREFAB_PATH = "ART/UI/Menus/Widget/EquipOverview/EquipPropertyItem"; // Metadata: 0x00B0EA60
	private const string MAIN_PROP_ITEM_PREFAB_PATH = "ART/UI/Menus/Widget/EquipOverview/EquipMainPropertyItem"; // Metadata: 0x00B0EA97
	private MonoAvatarPropertyItem _propertyItemPrefab; // 0x178
	private uint _propertyItemPrefabHandle; // 0x180
	private uint _mainPropItemPrefabHandle; // 0x184
	private MonoEquipStarUpDialog _dialogMono; // 0x188
	private BagItem _equip; // 0x190
	private uint _prevBreakLevel; // 0x198
	private uint _currBreakLevel; // 0x19C
	private List<PropertyChange> _propertyChange; // 0x1A0
	private ItemType _equipType; // 0x1A8
	private bool _canClose; // 0x1AC

	// Constructors
	public EquipStarUpDialogContext() {} // Dummy constructor
	public EquipStarUpDialogContext(BagItem equip, uint prevBreakLevel, uint currBreakLevel, List<uint> oldAppendPropList = null, List<uint> curAppendPropList = null) {} // 0x00000001821E8BD0-0x00000001821E8D60

	// Methods
	// [XID] // 0x0000000189850A10-0x0000000189850A30
	public override void SetupView() {} // 0x00000001821E81F0-0x00000001821E8BD0
	// [XID] // 0x0000000189857DA0-0x0000000189857DC0
	protected override void BindViewCallbacks() {} // 0x00000001821E6D80-0x00000001821E6E80
	// [XID] // 0x000000018985EE90-0x000000018985EEB0
	public override void ClearView() {} // 0x00000001821E6E80-0x00000001821E6FB0
	// [XID] // 0x0000000189866690-0x00000001898666B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001821E7CB0-0x00000001821E7E20
	// [XID] // 0x000000018986DF90-0x000000018986DFB0
	private void ScrollScroller(float delta) {} // 0x00000001821E6BF0-0x00000001821E6D80
	// [XID] // 0x0000000189875360-0x0000000189875380
	private void InitWeaponPropChange() {} // 0x00000001821E7EE0-0x00000001821E8190
	// [XID] // 0x000000018987CF10-0x000000018987CF30
	private void InitReliquaryPropChange(List<uint> oldAppendPropList, List<uint> curAppendPropList) {} // 0x00000001821E6FB0-0x00000001821E7590
	// [XID] // 0x0000000189883ED0-0x0000000189883EF0
	private void SetViewStyle() {} // 0x00000001821E7620-0x00000001821E7C50
}

