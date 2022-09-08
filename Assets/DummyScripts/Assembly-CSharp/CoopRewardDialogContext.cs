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

public sealed class CoopRewardDialogContext : BaseDialogContext // TypeDefIndex: 30130
{
	// Fields
	private MonoCoopRewardDialog _dialogMono; // 0x178
	private List<uint> _rewardUnlockList; // 0x180
	private List<uint> _rewardLockList; // 0x188
	private List<uint> _rewardTakenList; // 0x190
	private uint _chapterId; // 0x198
	private List<RewardItemConfig> _tempRewardList; // 0x1A0

	// Constructors
	public CoopRewardDialogContext() {} // Dummy constructor
	public CoopRewardDialogContext(uint chapterId) {} // 0x000000018320CF30-0x000000018320D010

	// Methods
	// [XID] // 0x000000018962BC90-0x000000018962BCB0
	public void CoopRewardUpdateChapterId(uint chapterId) {} // 0x000000018320B700-0x000000018320B7B0
	// [XID] // 0x00000001896337B0-0x00000001896337D0
	public override void SetupView() {} // 0x000000018320CE10-0x000000018320CF30
	// [XID] // 0x000000018963B070-0x000000018963B090
	public override void ClearView() {} // 0x000000018320B080-0x000000018320B140
	// [XID] // 0x0000000189642760-0x0000000189642780
	protected override void BindViewCallbacks() {} // 0x000000018320AF10-0x000000018320B080
	// [XID] // 0x0000000189649E70-0x0000000189649E90
	public override bool OnNotify(Notify ntf) => default; // 0x000000018320CBA0-0x000000018320CCE0
	// [XID] // 0x0000000189651590-0x00000001896515B0
	private void OnItemAdded(List<SimpleItemStruct> items) {} // 0x000000018320C360-0x000000018320C460
	// [XID] // 0x0000000189658DD0-0x0000000189658DF0
	private void OnBtnReceiveClick() {} // 0x000000018320B480-0x000000018320B670
	// [XID] // 0x0000000189660500-0x0000000189660520
	private int SortFunc(uint x, uint y) => default; // 0x000000018320C270-0x000000018320C360
	// [XID] // 0x0000000189667E40-0x0000000189667E60
	private void InitRewardsList() {} // 0x000000018320BF00-0x000000018320C060
	// [XID] // 0x000000018966F8B0-0x000000018966F8D0
	private void ClearRewardsList() {} // 0x000000018320CCE0-0x000000018320CE10
	// [XID] // 0x0000000189677200-0x0000000189677220
	private void RefreshRewardsList() {} // 0x000000018320B9C0-0x000000018320BF00
	// [XID] // 0x000000018967E7B0-0x000000018967E7D0
	private void RefreshRewardRow(Transform trans, int index) {} // 0x000000018320AD70-0x000000018320AF10
	// [XID] // 0x0000000189686000-0x0000000189686020
	private void SetupUnlockRow(Transform trans, int index) {} // 0x000000018320C6B0-0x000000018320C950
	// [XID] // 0x000000018968DDD0-0x000000018968DDF0
	private void SetupLockRow(Transform trans, int index) {} // 0x000000018320C4C0-0x000000018320C6B0
	// [XID] // 0x0000000189695740-0x0000000189695760
	private void SetupTakenRow(Transform trans, int index) {} // 0x000000018320AB80-0x000000018320AD70
	// [XID] // 0x000000018969CD70-0x000000018969CD90
	private void ShowRowCommonInfo(MonoCoopRewardDialogRow rowMono, uint configId) {} // 0x000000018320C060-0x000000018320C270
	// [XID] // 0x00000001896A40A0-0x00000001896A40C0
	private void RefreshRewardItems(Transform trans, int index) {} // 0x000000018320B140-0x000000018320B3E0
	// [XID] // 0x00000001896AB680-0x00000001896AB6A0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B1081A */) {} // 0x000000018320C9E0-0x000000018320CBA0
	// [XID] // 0x00000001896B28D0-0x00000001896B28F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018320B810-0x000000018320B960
}

