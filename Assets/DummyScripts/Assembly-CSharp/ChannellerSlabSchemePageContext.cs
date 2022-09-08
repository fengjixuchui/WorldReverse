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

public sealed class ChannellerSlabSchemePageContext : BasePageContext // TypeDefIndex: 30032
{
	// Fields
	private List<uint> _purpleBuffList; // 0x190
	private List<uint> _normalBuffList; // 0x198
	private uint _selectedBuffId; // 0x1A0
	private uint _selectedSlot; // 0x1A4
	private bool _isLastSelectedNormal; // 0x1A8
	private int _lastSelectedIndex; // 0x1AC
	private BagItemSlot _batItemSlot; // 0x1B0
	private bool _isEquiped; // 0x1B8
	private bool _isReplace; // 0x1B9
	private int _equipedNormalIndex; // 0x1BC
	private bool _isSlabUnlocked; // 0x1C0
	private MonoJoypadSimpleResuableListHandler _purpleJoypadHandler; // 0x1C8
	private MonoJoypadSimpleResuableListHandler _normalJoypadHandler; // 0x1D0
	private MonoChannellerSlabSchemePage _pageMono; // 0x1D8
	private ChannellerSlabPlateComponent _plateCom; // 0x1E0
	private MonoShopMaterial _energyMaterial; // 0x1E8
	private bool _isMultiPlayerScheme; // 0x1F0
	private bool _hasBuff; // 0x1F1
	private SLAB_PAGE_FROM _openFromType; // 0x1F4
	private uint _remainEnergy; // 0x1F8

	// Nested types
	public enum SLAB_PAGE_FROM // TypeDefIndex: 30033
	{
		FromDungeon = 0,
		FromInter = 1,
		FromPage = 2
	}

	// Constructors
	public ChannellerSlabSchemePageContext() {} // Dummy constructor
	public ChannellerSlabSchemePageContext(SLAB_PAGE_FROM from = SLAB_PAGE_FROM.FromDungeon /* Metadata: 0x00B10791 */) {} // 0x0000000181689A50-0x0000000181689B70

	// Methods
	// [XID] // 0x0000000189ACF200-0x0000000189ACF220
	private void RefreshBuffChoosePage() {} // 0x0000000181686480-0x00000001816867C0
	// [XID] // 0x0000000189AD70D0-0x0000000189AD70F0
	private void AutoSelectBuff() {} // 0x0000000181689400-0x0000000181689600
	// [XID] // 0x0000000189ADEA90-0x0000000189ADEAB0
	private int SortCompate(uint left, uint right) => default; // 0x0000000181687A50-0x0000000181687C00
	// [XID] // 0x0000000189AE6480-0x0000000189AE64A0
	private void ClearBuffChoosePage() {} // 0x0000000181689060-0x0000000181689180
	// [XID] // 0x0000000189AEDC10-0x0000000189AEDC30
	private void RefreshPurpleBuffList() {} // 0x0000000181688720-0x00000001816888C0
	// [XID] // 0x0000000189AF54A0-0x0000000189AF54C0
	private void RefreshPurpleBuffItem(Transform trans, int index) {} // 0x0000000181687C00-0x00000001816880C0
	// [XID] // 0x0000000189AFC990-0x0000000189AFC9B0
	private void RefreshNormalBuffList() {} // 0x0000000181685AB0-0x0000000181685CA0
	// [XID] // 0x0000000189B04150-0x0000000189B04170
	private void RefreshNormalBuffItem(Transform trans, int index) {} // 0x0000000181687480-0x0000000181687940
	// [XID] // 0x0000000189B0B9F0-0x0000000189B0BA10
	private void OnClickOrangeBuff(uint buffID) {} // 0x00000001816863D0-0x0000000181686480
	// [XID] // 0x0000000189B12EC0-0x0000000189B12EE0
	private void OnClickNormalBuff(uint buffID) {} // 0x00000001816879A0-0x0000000181687A50
	// [XID] // 0x0000000189B1A5D0-0x0000000189B1A5F0
	private void SelectBuff(bool isNormal, int index) {} // 0x0000000181688D40-0x0000000181689060
	// [XID] // 0x0000000189B21B20-0x0000000189B21B40
	private void OnChooseBuff(uint buffID) {} // 0x0000000181686EB0-0x00000001816871D0
	// [XID] // 0x0000000189B29220-0x0000000189B29240
	private void RefreshSelectedBuff() {} // 0x00000001816869A0-0x0000000181686BC0
	// [XID] // 0x0000000189B305F0-0x0000000189B30610
	private void OnClickWear() {} // 0x0000000181689180-0x0000000181689400
	// [XID] // 0x0000000189B37F10-0x0000000189B37F30
	public void WearBuff(uint slotId, uint buffID) {} // 0x00000001816867C0-0x00000001816869A0
	// [XID] // 0x0000000189B3F920-0x0000000189B3F940
	public void TakeOffBuff(uint slotId, uint buffID) {} // 0x00000001816880C0-0x00000001816882A0
	// [XID] // 0x0000000189B47180-0x0000000189B471A0
	public bool CanEquipBuff(uint buffID) => default; // 0x00000001816883C0-0x00000001816884A0
	// [XID] // 0x0000000189B4E900-0x0000000189B4E920
	private bool CanReplace() => default; // 0x00000001816884A0-0x0000000181688570
	// [XID] // 0x0000000189B56140-0x0000000189B56160
	public override void SetupView() {} // 0x0000000181689600-0x0000000181689A50
	// [XID] // 0x0000000189B5DA00-0x0000000189B5DA20
	private void CreateEnergyMaterial() {} // 0x0000000181688570-0x00000001816886C0
	// [XID] // 0x0000000189B64F60-0x0000000189B64F80
	public override void ClearView() {} // 0x0000000181686190-0x0000000181686260
	// [XID] // 0x0000000189B6C540-0x0000000189B6C560
	protected override void OnEnable() {} // 0x0000000181688B80-0x0000000181688C30
	// [XID] // 0x0000000189B73C70-0x0000000189B73C90
	protected override void BindRedPoints() {} // 0x0000000181685CA0-0x0000000181685DC0
	// [XID] // 0x0000000189B7B2C0-0x0000000189B7B2E0
	private void CheckRedPoint() {} // 0x00000001816871D0-0x00000001816872D0
	// [XID] // 0x0000000189B82C20-0x0000000189B82C40
	protected override void BindViewCallbacks() {} // 0x0000000181685DC0-0x0000000181686080
	// [XID] // 0x0000000189B8A220-0x0000000189B8A240
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181688C30-0x0000000181688D40
	// [XID] // 0x0000000189B91880-0x0000000189B918A0
	private void UpdateActivity(uint activityId) {} // 0x00000001816888C0-0x00000001816889D0
	// [XID] // 0x0000000189B98C60-0x0000000189B98C80
	private void Refresh(bool setup = false /* Metadata: 0x00B10795 */) {} // 0x0000000181685590-0x0000000181685940
	// [XID] // 0x0000000189BA0040-0x0000000189BA0060
	private void OnTabClicked(int tabIndex) {} // 0x0000000181686C50-0x0000000181686E50
	// [XID] // 0x0000000189BA7880-0x0000000189BA78A0
	private void ToPrevTab() {} // 0x0000000181686080-0x0000000181686190
	// [XID] // 0x0000000189BAEBD0-0x0000000189BAEBF0
	private void ToNextTab() {} // 0x0000000181686260-0x0000000181686370
	// [XID] // 0x0000000189BB62C0-0x0000000189BB62E0
	private void OnClickBuffDetail() {} // 0x00000001816889D0-0x0000000181688AF0
	// [XID] // 0x0000000189BBD900-0x0000000189BBD920
	private void OnClickDrive() {} // 0x00000001816882A0-0x00000001816883C0
	// [XID] // 0x0000000189BC5660-0x0000000189BC5680
	private void OnClickDesc() {} // 0x0000000181685940-0x0000000181685A50
	// [XID] // 0x0000000189BCD040-0x0000000189BCD060
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001816872D0-0x0000000181687480
}

