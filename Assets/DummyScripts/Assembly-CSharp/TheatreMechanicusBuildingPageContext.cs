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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TheatreMechanicusBuildingPageContext : BasePageContext // TypeDefIndex: 29936
{
	// Fields
	private MonoTheatreMechanicusBuildingPage _pageMono; // 0x190
	private FoundationInfo _foundationInfo; // 0x198
	private List<BuildingSlotStruct> _buildingList; // 0x1A0
	private int _selectedIndex; // 0x1A8
	private uint _entityId; // 0x1AC
	private bool _isRebuild; // 0x1B0
	private int _selectedBtnActiveIndex; // 0x1B4
	private InLevelQuestHintDialogContext _questHintDialog; // 0x1B8

	// Properties
	public bool isRebuild { /* [XID] */ /* 0x0000000189BDC130-0x0000000189BDC150 */ get => default; } // 0x0000000183547970-0x0000000183547A20 
	public int selectIndex { /* [XID] */ /* 0x00000001895E8970-0x00000001895E8990 */ get => default; } // 0x0000000183546320-0x00000001835463C0 

	// Nested types
	public enum BuildingEditBtnType // TypeDefIndex: 29937
	{
		Build = 0,
		Rebuild = 1,
		Rotate = 2,
		Demolish = 3,
		Close = 4
	}

	private struct BuildingSlotStruct // TypeDefIndex: 29938
	{
		// Fields
		public uint buildingId; // 0x00
		public uint level; // 0x04
		public uint cost; // 0x08
		public uint refund; // 0x0C
		public bool isUnlocked; // 0x10
		public string name; // 0x18
	}

	// Constructors
	public TheatreMechanicusBuildingPageContext() {} // Dummy constructor
	public TheatreMechanicusBuildingPageContext(FoundationInfo foundationInfo, uint entityId) {} // 0x0000000183547C30-0x0000000183547DA0

	// Methods
	// [XID] // 0x00000001895F01C0-0x00000001895F01E0
	public override void SetupView() {} // 0x0000000183547A20-0x0000000183547C30
	// [XID] // 0x00000001895F7C90-0x00000001895F7CB0
	public override void ClearView() {} // 0x0000000183544150-0x0000000183544250
	// [XID] // 0x00000001895FEFF0-0x00000001895FF010
	protected override void BindViewCallbacks() {} // 0x0000000183543B80-0x0000000183543DE0
	// [XID] // 0x0000000189606890-0x00000001896068B0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183546E40-0x0000000183546F70
	// [XID] // 0x000000018960E210-0x000000018960E230
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183545550-0x00000001835458D0
	// [XID] // 0x00000001896158A0-0x00000001896158C0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B102DE */) {} // 0x0000000183546B30-0x0000000183546E40
	// [XID] // 0x000000018961D080-0x000000018961D0A0
	public override void OnJoypadUIModuleDeSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B102E2 */) {} // 0x0000000183546830-0x0000000183546B30
	// [XID] // 0x00000001896245B0-0x00000001896245D0
	private void OnClose() {} // 0x0000000183545440-0x00000001835454F0
	// [XID] // 0x000000018962BCF0-0x000000018962BD10
	private void RefreshView() {} // 0x00000001835458D0-0x0000000183546320
	// [XID] // 0x0000000189633810-0x0000000189633830
	private void RefreshMechanicusSlot(Transform trans, int index) {} // 0x0000000183547130-0x0000000183547740
	// [XID] // 0x000000018963B0F0-0x000000018963B110
	private void OnMechanicusSlotClick(int index, bool focusOnFirstEditBtn) {} // 0x0000000183544520-0x0000000183545050
	// [XID] // 0x00000001896427E0-0x0000000189642800
	private int FindFirstActiveBtn() => default; // 0x0000000183544360-0x0000000183544520
	// [XID] // 0x0000000189649ED0-0x0000000189649EF0
	private int FinActiveBtnBySelectedIndex() => default; // 0x0000000183546580-0x0000000183546740
	// [XID] // 0x00000001896515F0-0x0000000189651610
	private int GetAcitveIndex(int index) => default; // 0x0000000183546F70-0x0000000183547130
	// [XID] // 0x0000000189658E70-0x0000000189658E90
	private MonoUIContainer GetButtonByIndex(int index) => default; // 0x0000000183546420-0x0000000183546580
	// [XID] // 0x0000000189660540-0x0000000189660560
	private void SetupSelectItem() {} // 0x0000000183543DE0-0x0000000183544150
	// [XID] // 0x0000000189667E80-0x0000000189667EA0
	private void SetupButton(MonoUIContainer btnContainer, string text) {} // 0x0000000183543760-0x00000001835438F0
	// [XID] // 0x000000018966F8F0-0x000000018966F910
	private void OnBuildBtnClick() {} // 0x00000001835477E0-0x0000000183547970
	// [XID] // 0x0000000189677240-0x0000000189677260
	private void OnRebuildBtnClick() {} // 0x00000001835438F0-0x0000000183543A80
	// [XID] // 0x000000018967E7F0-0x000000018967E810
	private void OnDemolishBtnClick() {} // 0x0000000183543A80-0x0000000183543B80
	// [XID] // 0x0000000189686060-0x0000000189686080
	private void OnRotateBtnClick() {} // 0x00000001835450F0-0x00000001835451E0
	// [XID] // 0x000000018968DE70-0x000000018968DE90
	private void OnInBattleMechanicusBegin() {} // 0x0000000183545270-0x0000000183545440
	// [XID] // 0x00000001896957C0-0x00000001896957E0
	private void OnInBattleMechanicusUpdate(MechanicusModule.MechanicusRefreshType type) {} // 0x0000000183544250-0x0000000183544360
}

