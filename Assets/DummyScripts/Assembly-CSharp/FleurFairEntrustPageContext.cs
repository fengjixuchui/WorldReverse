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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairEntrustPageContext : BasePageContext // TypeDefIndex: 29645
{
	// Fields
	private MonoFleurFairEntrustPage _pageMono; // 0x190
	private FleurFairActivityDetailInfo _detailInfo; // 0x198
	private FleurFairChapterInfo _selectChapterInfo; // 0x1A0
	private int _selectChapterIndex; // 0x1A8
	private uint _acceptedQuestID; // 0x1AC
	private InputState _currentInputState; // 0x1B0
	private List<MonoFleurFairTaskRow> _currentTaskRows; // 0x1B8
	private int _selectRowIndex; // 0x1C0

	// Nested types
	private enum InputState // TypeDefIndex: 29646
	{
		Invalid = 0,
		ChapterList = 1,
		DetailInfo = 2
	}

	// Constructors
	public FleurFairEntrustPageContext() {} // Dummy constructor
	public FleurFairEntrustPageContext(uint activityID) {} // 0x00000001832DFA70-0x00000001832DFBF0

	// Methods
	// [XID] // 0x0000000189901DA0-0x0000000189901DC0
	public override void SetupView() {} // 0x00000001832DF900-0x00000001832DFA70
	// [XID] // 0x0000000189909630-0x0000000189909650
	protected override void OnEnable() {} // 0x00000001832DF590-0x00000001832DF760
	// [XID] // 0x0000000189910AC0-0x0000000189910AE0
	private void Refresh(bool forceRefresh) {} // 0x00000001832DA2F0-0x00000001832DA3C0
	// [XID] // 0x00000001899186A0-0x00000001899186C0
	private void RefreshCredit() {} // 0x00000001832DC860-0x00000001832DC9D0
	// [XID] // 0x000000018991FEA0-0x000000018991FEC0
	private void RefreshChapterList(bool forceRefresh) {} // 0x00000001832DE920-0x00000001832DEB30
	// [XID] // 0x0000000189927700-0x0000000189927720
	private void RefreshChapterInfoItem(Transform trans, int index) {} // 0x00000001832DDF80-0x00000001832DE3F0
	// [XID] // 0x000000018992EE80-0x000000018992EEA0
	private static FleurFairChapterExcelConfig GetChapterConfigData(uint chapterID) => default; // 0x00000001832DE3F0-0x00000001832DE630
	// [XID] // 0x0000000189936290-0x00000001899362B0
	private void OnChapterInfoItemClicked(int index, bool forceRefresh = false /* Metadata: 0x00B0FAE5 */) {} // 0x00000001832DA7D0-0x00000001832DAB40
	// [XID] // 0x000000018993DC70-0x000000018993DC90
	private void RefreshSelectedEffectActive() {} // 0x00000001832DF250-0x00000001832DF590
	// [XID] // 0x00000001899453C0-0x00000001899453E0
	private void RefreshChapterDetailPanel() {} // 0x00000001832DD5C0-0x00000001832DDBE0
	// [IDTag] // 0x000000018994C8E0-0x000000018994C920
	// [XID] // 0x000000018994C8E0-0x000000018994C920
	private void RefreshQuestItemRow(Transform trans, int index) {} // 0x00000001832DADA0-0x00000001832DAFF0
	// [IDTag] // 0x0000000189956FD0-0x0000000189957010
	// [XID] // 0x0000000189956FD0-0x0000000189957010
	private void RefreshQuestItemRow(MonoFleurFairTaskRow questItemRow, uint subQuestID, uint prevQuestID, bool isMainLine) {} // 0x00000001832DAFF0-0x00000001832DBA60
	// [XID] // 0x0000000189961B80-0x0000000189961BA0
	private bool IsQuestFinished(uint subQuestID) => default; // 0x00000001832DED90-0x00000001832DEEB0
	// [XID] // 0x0000000189969210-0x0000000189969230
	private void OnSetSelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x00000001832DC130-0x00000001832DC230
	// [XID] // 0x0000000189970CB0-0x0000000189970CD0
	private void UpdateSelectState(Transform item, bool isSelect) {} // 0x00000001832DE630-0x00000001832DE920
	// [XID] // 0x00000001899785F0-0x0000000189978610
	private void RefreshRewardItem(Transform trans, int index, List<SimpleItemStruct> itemList) {} // 0x00000001832DBB70-0x00000001832DBE30
	// [XID] // 0x000000018997F710-0x000000018997F730
	public override void ClearView() {} // 0x00000001832DBA60-0x00000001832DBB10
	// [XID] // 0x0000000189987060-0x0000000189987080
	protected override void BindViewCallbacks() {} // 0x00000001832DAB40-0x00000001832DAC60
	// [XID] // 0x000000018998EB30-0x000000018998EB50
	public override bool OnNotify(Notify ntf) => default; // 0x00000001832DF760-0x00000001832DF830
	// [XID] // 0x0000000189996710-0x0000000189996730
	private void OnQuestStateUpdated() {} // 0x00000001832DA5D0-0x00000001832DA7D0
	// [XID] // 0x000000018999E230-0x000000018999E250
	private void OnBtnReturnClick() {} // 0x00000001832DC230-0x00000001832DC2E0
	// [XID] // 0x00000001899A5BF0-0x00000001899A5C10
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001832DD0E0-0x00000001832DD200
	// [XID] // 0x00000001899AD2B0-0x00000001899AD2D0
	private bool HandleInputActionEventChapterList(InputActionEvent actionEvent) => default; // 0x00000001832DD360-0x00000001832DD560
	// [XID] // 0x00000001899B4AF0-0x00000001899B4B10
	private bool HandleInputActionEventDetailInfo(InputActionEvent actionEvent) => default; // 0x00000001832DBEC0-0x00000001832DC130
	// [XID] // 0x00000001899BC1F0-0x00000001899BC210
	private MonoSimpleReusableList GetCurrentRewardList() => default; // 0x00000001832DEC70-0x00000001832DED90
	// [XID] // 0x00000001899C3C30-0x00000001899C3C50
	private void SelectRewardItem(bool next) {} // 0x00000001832DD200-0x00000001832DD360
	// [XID] // 0x00000001899CB330-0x00000001899CB350
	private void CheckRewardItemDetail() {} // 0x00000001832DEEB0-0x00000001832DF0C0
	// [XID] // 0x00000001899D2860-0x00000001899D2880
	private void SelectRow(bool next) {} // 0x00000001832DAC60-0x00000001832DADA0
	// [XID] // 0x00000001899D9F70-0x00000001899D9F90
	private void SwitchToDetailInfoState() {} // 0x00000001832DEB90-0x00000001832DEC70
	// [XID] // 0x00000001899E1850-0x00000001899E1870
	private void SwitchToChapterListState() {} // 0x00000001832DF830-0x00000001832DF900
	// [XID] // 0x00000001899E8E00-0x00000001899E8E20
	private void RefreshButtonActiveOnInputStateChange() {} // 0x00000001832DA3C0-0x00000001832DA5D0
	// [XID] // 0x00000001899F0780-0x00000001899F07A0
	private bool IsCurrentSelectChapterLocked() => default; // 0x00000001832DF0C0-0x00000001832DF1C0
	// [XID] // 0x00000001899F7DC0-0x00000001899F7DE0
	private void OnSelectRowChanged() {} // 0x00000001832DC2E0-0x00000001832DC860
	// [XID] // 0x00000001899FF470-0x00000001899FF490
	private void RefreshConfirmButtonTextForJoystick() {} // 0x00000001832DCA30-0x00000001832DD0E0
	// [XID] // 0x0000000189A06CB0-0x0000000189A06CD0
	public static bool HasUnAcceptedQuest(uint activityID) => default; // 0x00000001832DDBE0-0x00000001832DDF80
}

