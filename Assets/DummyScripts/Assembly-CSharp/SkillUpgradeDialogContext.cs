/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;
using MoleMole;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SkillUpgradeDialogContext : BaseDialogContext // TypeDefIndex: 29302
{
	// Fields
	private Regex skillPropRegex; // 0x178
	private MonoSkillUpgradeDialog _dialogMono; // 0x180
	private CharacterPageContext.SkillBaseStruct _skillInfo; // 0x188
	private uint _currLevel; // 0x198
	private uint _baseLevel; // 0x19C
	private bool _haveExtraLevel; // 0x1A0
	private AvatarDataItem _avatarItem; // 0x1A8
	private int _currPropIndex; // 0x1B0
	private int _currNeedItemIndex; // 0x1B4
	private bool _isFocusProp; // 0x1B8
	private bool _isFocusNeedItem; // 0x1B9
	private List<Tuple<BagItemSlot, uint>> _needItemList; // 0x1C0
	private List<SkillPropStruct> _propChangeList; // 0x1C8

	// Nested types
	public struct SkillPropStruct // TypeDefIndex: 29303
	{
		// Fields
		public string name; // 0x00
		public string desc; // 0x08
		public string oldDesc; // 0x10
		public bool isChanged; // 0x18
		public bool isUnlock; // 0x19
	}

	// Constructors
	public SkillUpgradeDialogContext() {} // Dummy constructor
	public SkillUpgradeDialogContext(CharacterPageContext.SkillBaseStruct skillInfo, uint currLevel, AvatarDataItem avatarItem) {} // 0x0000000182862730-0x00000001828628C0

	// Methods
	// [XID] // 0x000000018971C1B0-0x000000018971C1D0
	public override void SetupView() {} // 0x0000000182862660-0x0000000182862730
	// [XID] // 0x0000000189723600-0x0000000189723620
	protected override void BindViewCallbacks() {} // 0x00000001828602F0-0x00000001828605A0
	// [XID] // 0x000000018972ADA0-0x000000018972ADC0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182860C50-0x0000000182860E90
	// [XID] // 0x0000000189732450-0x0000000189732470
	private void SetSkillUpgradeView() {} // 0x0000000182861650-0x00000001828619C0
	// [XID] // 0x0000000189739B80-0x0000000189739BA0
	private void RefreshNeedItems(ProudSkillExcelConfig postSkillConfig) {} // 0x000000018285FD70-0x00000001828602F0
	// [XID] // 0x0000000189741780-0x00000001897417A0
	private void RefreshNeedItemSlot(Transform trans, int index) {} // 0x000000018285FB40-0x000000018285FD70
	// [XID] // 0x0000000189749060-0x0000000189749080
	private void OnNeedItemSlotClicked(int index) {} // 0x0000000182861D10-0x0000000182861E90
	// [XID] // 0x00000001897504D0-0x00000001897504F0
	private void RefreshSkillProps(ProudSkillExcelConfig postSkillConfig) {} // 0x0000000182860800-0x0000000182860BF0
	// [XID] // 0x0000000189757A70-0x0000000189757A90
	private void RefreshCurrentProp(bool prevOrNext) {} // 0x00000001828619C0-0x0000000182861D10
	// [XID] // 0x000000018975F490-0x000000018975F4B0
	private void ClearCurrentProp() {} // 0x000000018285F680-0x000000018285F850
	// [XID] // 0x0000000189766980-0x00000001897669A0
	private void RefreshCurrentNeedItem(bool prevOrNext) {} // 0x00000001828622D0-0x0000000182862660
	// [XID] // 0x000000018976DF30-0x000000018976DF50
	private void ClearCurrentNeedItem() {} // 0x00000001828605A0-0x0000000182860770
	// [XID] // 0x0000000189775690-0x00000001897756B0
	private void RefreshSkillPropItem(Transform trans, int index) {} // 0x0000000182861EF0-0x00000001828622D0
	// [XID] // 0x000000018977CF10-0x000000018977CF30
	private SkillPropStruct GetSkillPropDescStruct(string desc, ProudSkillExcelConfig proudSkillConfig) => default; // 0x0000000182860E90-0x0000000182861650
	// [XID] // 0x0000000189784910-0x0000000189784930
	private void OnOkBtnClick() {} // 0x000000018285F850-0x000000018285FB40
}

