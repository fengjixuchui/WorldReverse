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

public sealed class CodexPushTipsPageContext : BasePageContext // TypeDefIndex: 28508
{
	// Fields
	private MonoCodexPushTipsPage _pageMono; // 0x190
	private PushTipsCodexType _currentCodexType; // 0x198
	private string _currentSearchStr; // 0x1A0
	private string _searchStyleStr; // 0x1A8
	private string _searchStyleStrRevert; // 0x1B0
	private string _searchNoResultStyleStr; // 0x1B8
	private List<CodexItemState> _currentPushTipsList; // 0x1C0
	private List<CodexItemState> _allPushTipsList; // 0x1C8
	private uint _currentSelectPushTipsId; // 0x1D0
	private int _currentSelectPushTipsIndex; // 0x1D4
	private MonoCodexPushTipsListRow _lastSelectedRow; // 0x1D8
	private CodexItemState _lastSelectedItem; // 0x1E0
	private JumpFrom _jumpFrom; // 0x1E8
	private bool _firstGPushRefresh; // 0x1EC
	private List<uint> _finishedPushTipsList; // 0x1F0
	private CodexPushTipsUISceneComponent _uiSceneComp; // 0x1F8
	private bool _firstRefreshDetail; // 0x200
	private SimpleSafeUInt32[] _tutorialDetailList; // 0x208
	private int _selectedTutorialIndex; // 0x210
	private HashSet<int> _viewedIndexSet; // 0x218
	private MonoPS4IMEProxy _proxy; // 0x220

	// Nested types
	public enum JumpFrom // TypeDefIndex: 28509
	{
		CodexHomePage = 0,
		GPush = 1
	}

	// Constructors
	public CodexPushTipsPageContext() {} // Dummy constructor
	public CodexPushTipsPageContext(JumpFrom from) {} // 0x0000000181904400-0x0000000181904590

	// Methods
	// [XID] // 0x0000000189BAEDF0-0x0000000189BAEE10
	private void RefreshView() {} // 0x00000001819026F0-0x0000000181902E90
	// [XID] // 0x0000000189BB64A0-0x0000000189BB64C0
	private void SetCurrentPushTisList() {} // 0x00000001818FF7E0-0x00000001818FF970
	// [XID] // 0x0000000189BBDB20-0x0000000189BBDB40
	private void SetInitClicked() {} // 0x00000001818FF970-0x00000001818FFC80
	// [XID] // 0x0000000189BC5800-0x0000000189BC5820
	private void RefreshPushTipsList(bool withAnimation) {} // 0x0000000181901170-0x0000000181901500
	// [XID] // 0x0000000189BCD260-0x0000000189BCD280
	private void RefreshPushTipsRow(Transform trans, int index) {} // 0x0000000181903C50-0x0000000181903FA0
	// [XID] // 0x0000000189BD4760-0x0000000189BD4780
	private void OnRowClick(MonoCodexPushTipsListRow ins, int index) {} // 0x00000001819006D0-0x00000001819009C0
	// [XID] // 0x0000000189BDC2D0-0x0000000189BDC2F0
	private void CheckSetViewed() {} // 0x0000000181900CE0-0x0000000181901170
	// [XID] // 0x00000001895E8B30-0x00000001895E8B50
	private void RefreshTutorialDetail() {} // 0x0000000181901C70-0x0000000181901EA0
	// [XID] // 0x00000001895F0380-0x00000001895F03A0
	private void ShowTutorialDetial(int index) {} // 0x0000000181902FC0-0x00000001819034B0
	// [XID] // 0x00000001895F7DF0-0x00000001895F7E10
	private string GetTipsTypeText() => default; // 0x0000000181903FA0-0x0000000181904110
	// [XID] // 0x00000001895FF1D0-0x00000001895FF1F0
	private string GetTipsIconKey(PushTipsCodexType type) => default; // 0x0000000181901EA0-0x0000000181901FC0
	// [XID] // 0x0000000189606A70-0x0000000189606A90
	private void OnPrevBtnClick() {} // 0x0000000181900190-0x0000000181900340
	// [XID] // 0x000000018960E3D0-0x000000018960E3F0
	private void OnNextBtnClick() {} // 0x00000001818FFC80-0x00000001818FFE70
	// [XID] // 0x00000001896159E0-0x0000000189615A00
	private void OnTabPrevBtnClick() {} // 0x0000000181903650-0x0000000181903720
	// [XID] // 0x000000018961D1C0-0x000000018961D1E0
	private void OnTabNextBtnClick() {} // 0x0000000181902EF0-0x0000000181902FC0
	// [XID] // 0x00000001896246F0-0x0000000189624710
	private void OnClearBtnClick() {} // 0x0000000181900BE0-0x0000000181900CE0
	// [XID] // 0x000000018962BE50-0x000000018962BE70
	protected override void BindViewCallbacks() {} // 0x0000000181900340-0x00000001819006D0
	// [XID] // 0x00000001896339B0-0x00000001896339D0
	private void OnReturn() {} // 0x0000000181901BC0-0x0000000181901C70
	// [XID] // 0x000000018963B2D0-0x000000018963B2F0
	private void OnSearchChanged(string text) {} // 0x0000000181901790-0x0000000181901920
	// [XID] // 0x0000000189642A00-0x0000000189642A20
	private void OnTabClicked(int index) {} // 0x0000000181901920-0x0000000181901A90
	// [XID] // 0x000000018964A130-0x000000018964A150
	private string ConverSearchStyleText(string text) => default; // 0x0000000181901A90-0x0000000181901BC0
	// [XID] // 0x00000001896517F0-0x0000000189651810
	private string ConverSearchStyleRevertText(string text) => default; // 0x00000001819034B0-0x00000001819035E0
	// [XID] // 0x0000000189658FF0-0x0000000189659010
	private void SetMenuTab() {} // 0x0000000181903780-0x0000000181903AC0
	// [XID] // 0x00000001896606E0-0x0000000189660700
	private void CheckAllTabRedPoint() {} // 0x0000000181903AC0-0x0000000181903C50
	// [XID] // 0x0000000189668060-0x0000000189668080
	private void CheckPrevButtonNextButtonRedPoint() {} // 0x00000001818FFE70-0x0000000181900190
	// [XID] // 0x000000018966FAE0-0x000000018966FB00
	public override void SetupView() {} // 0x0000000181904110-0x0000000181904400
	// [XID] // 0x0000000189677420-0x0000000189677440
	public override void ClearView() {} // 0x00000001819009C0-0x0000000181900B30
	// [XID] // 0x000000018967E970-0x000000018967E990
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181902020-0x00000001819026F0
}

