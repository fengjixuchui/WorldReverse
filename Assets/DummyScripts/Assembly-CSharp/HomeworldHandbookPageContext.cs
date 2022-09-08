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

public sealed class HomeworldHandbookPageContext : BasePageContext // TypeDefIndex: 29151
{
	// Fields
	private MonoHomeworldHandbookPage _pageMono; // 0x190
	private int _curSelectChapterIndex; // 0x198
	private int _lastMaxChapterNum; // 0x19C
	private uint _selectInvestigationTargetId; // 0x1A0
	private List<RewardItemConfig> _tempRewardList; // 0x1A8
	private List<RewardItemConfig> _investigationRewardList; // 0x1B0
	private List<InvestigationTargetStruct> _investigationTargetList; // 0x1B8
	private int _selectInvestigationTargetIndex; // 0x1C0
	private ItemGotBigDialogContext _itemGotDialog; // 0x1C8

	// Constructors
	public HomeworldHandbookPageContext() {} // 0x0000000183C4A090-0x0000000183C4A1C0

	// Methods
	// [XID] // 0x00000001896B5EF0-0x00000001896B5F10
	public override void SetupView() {} // 0x0000000183C49F70-0x0000000183C4A090
	// [XID] // 0x00000001896BD0B0-0x00000001896BD0D0
	public override void ClearView() {} // 0x0000000183C47AF0-0x0000000183C47B90
	// [XID] // 0x00000001896C45B0-0x00000001896C45D0
	protected override void BindViewCallbacks() {} // 0x0000000183C473F0-0x0000000183C476B0
	// [XID] // 0x00000001896CBBD0-0x00000001896CBBF0
	protected override void BindRedPoints() {} // 0x0000000183C472B0-0x0000000183C473F0
	// [XID] // 0x00000001896D2EB0-0x00000001896D2ED0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183C49BA0-0x0000000183C49CF0
	// [XID] // 0x00000001896DAA80-0x00000001896DAAA0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183C48220-0x0000000183C48480
	// [XID] // 0x00000001896E21B0-0x00000001896E21D0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0ECF7 */) {} // 0x0000000183C49990-0x0000000183C49BA0
	// [XID] // 0x00000001896E96D0-0x00000001896E96F0
	private void SetInvestigationView() {} // 0x0000000183C47F70-0x0000000183C48020
	// [XID] // 0x00000001896F0910-0x00000001896F0930
	private void RefreshData() {} // 0x0000000183C480B0-0x0000000183C481C0
	// [XID] // 0x00000001896F8120-0x00000001896F8140
	private void RefreshView() {} // 0x0000000183C48480-0x0000000183C48690
	// [XID] // 0x00000001896FFA80-0x00000001896FFAA0
	private void RefreshInvestigationTargetView(InvestigationStruct investigationData) {} // 0x0000000183C46950-0x0000000183C470C0
	// [XID] // 0x0000000189707130-0x0000000189707150
	private void RefreshRewardItems(Transform trans, int index) {} // 0x0000000183C47B90-0x0000000183C47E10
	// [XID] // 0x000000018970E9F0-0x000000018970EA10
	private void RefreshInvestigationRewardItems(Transform trans, int index) {} // 0x0000000183C49CF0-0x0000000183C49F70
	// [XID] // 0x0000000189715DF0-0x0000000189715E10
	private int CompareInvestigationTarget(InvestigationTargetStruct xData, InvestigationTargetStruct yData) => default; // 0x0000000183C486F0-0x0000000183C48830
	// [XID] // 0x000000018971D850-0x000000018971D870
	private void RefreshInvestigationRow(Transform trans, int index) {} // 0x0000000183C48D40-0x0000000183C49250
	// [XID] // 0x0000000189724BF0-0x0000000189724C10
	private void ReceiveTargetReward(uint questId) {} // 0x0000000183C476B0-0x0000000183C477A0
	// [XID] // 0x000000018972C420-0x000000018972C440
	private void OnInvestigationRowClick(int index) {} // 0x0000000183C48AA0-0x0000000183C48D40
	// [XID] // 0x0000000189733B40-0x0000000189733B60
	private void OnInvestigationReceiveBtnClick() {} // 0x0000000183C49480-0x0000000183C49630
	// [XID] // 0x000000018973B260-0x000000018973B280
	private void OnRewardDetailsBtnClick() {} // 0x0000000183C48830-0x0000000183C48AA0
	// [XID] // 0x0000000189742C10-0x0000000189742C30
	private void OnNextChapterBtnClick() {} // 0x0000000183C49250-0x0000000183C49360
	// [XID] // 0x000000018974A910-0x000000018974A930
	private void OnPrevChapterBtnClick() {} // 0x0000000183C47E10-0x0000000183C47ED0
	// [XID] // 0x0000000189751A30-0x0000000189751A50
	private void RefreshChapterBtnShowState() {} // 0x0000000183C478E0-0x0000000183C47AF0
	// [XID] // 0x0000000189759000-0x0000000189759020
	private void OnItemAddedNotify(List<SimpleItemStruct> items) {} // 0x0000000183C477A0-0x0000000183C478E0
	// [XID] // 0x0000000189760C70-0x0000000189760C90
	private void OnInvestigationChangeNotify() {} // 0x0000000183C49690-0x0000000183C49900
	// [XID] // 0x0000000189767FB0-0x0000000189767FD0
	private void PlayNewTabAnim() {} // 0x0000000183C49360-0x0000000183C49480
	// [XID] // 0x000000018976F500-0x000000018976F520
	private void OnInvestigationChangeTargetNotify() {} // 0x0000000183C470C0-0x0000000183C47250
}

