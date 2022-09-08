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

public sealed class MailOverviewPageContext : BasePageContext // TypeDefIndex: 29192
{
	// Fields
	private bool _useMutiSelect; // 0x190
	private bool _hasSetupView; // 0x191
	private uint _selectedMailId; // 0x194
	private int _selectedIndex; // 0x198
	private int _mailState; // 0x19C
	private float _lastRefreshMailRemainTime; // 0x1A0
	private MonoMailOverviewPage _pageMono; // 0x1A8
	private MailDataItem _curMailData; // 0x1B0
	private List<MailDataItem> _mailList; // 0x1B8
	private List<MailDataItem> _tempMailList; // 0x1C0
	private List<uint> _mutiSelectIdList; // 0x1C8
	private List<uint> _tempMailIdList; // 0x1D0
	private List<uint> _tempMailIdList2; // 0x1D8

	// Constructors
	public MailOverviewPageContext() {} // 0x0000000183987B40-0x0000000183987CA0

	// Methods
	// [XID] // 0x000000018980F710-0x000000018980F730
	public override void SetupView() {} // 0x0000000183987950-0x0000000183987AA0
	// [XID] // 0x0000000189816DC0-0x0000000189816DE0
	protected override void BindViewCallbacks() {} // 0x0000000183982EF0-0x0000000183983410
	// [XID] // 0x000000018981E630-0x000000018981E650
	public override void UpdateView() {} // 0x0000000183987AA0-0x0000000183987B40
	// [XID] // 0x0000000189825B10-0x0000000189825B30
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183986D90-0x0000000183986EE0
	// [XID] // 0x000000018982D240-0x000000018982D260
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183985C90-0x0000000183985E50
	// [XID] // 0x00000001898349A0-0x00000001898349C0
	private void RefreshMailRemainTimeUI() {} // 0x0000000183986840-0x0000000183986A60
	// [XID] // 0x000000018983C070-0x000000018983C090
	private void SetMailStateUI(int newState) {} // 0x0000000183984B70-0x00000001839854B0
	// [XID] // 0x0000000189843680-0x00000001898436A0
	private void ModifyMailListItemMarkUI(int index, bool isMark) {} // 0x0000000183983E00-0x0000000183984030
	// [XID] // 0x000000018984ABE0-0x000000018984AC00
	private bool HandleMailListAction(InputActionEvent actionEvent) => default; // 0x00000001839836C0-0x0000000183983930
	// [XID] // 0x0000000189851F40-0x0000000189851F60
	private bool HandleMailContentAction(InputActionEvent actionEvent) => default; // 0x0000000183986230-0x0000000183986660
	// [XID] // 0x0000000189859800-0x0000000189859820
	private bool HandleMailItemAction(InputActionEvent actionEvent) => default; // 0x00000001839847F0-0x0000000183984AE0
	// [XID] // 0x0000000189860980-0x00000001898609A0
	private void OnTouchSelectMail(int index) {} // 0x0000000183982AC0-0x0000000183982C70
	// [XID] // 0x00000001898680B0-0x00000001898680D0
	private void ScrollScroller(float delta) {} // 0x0000000183982220-0x00000001839823C0
	// [XID] // 0x000000018986F670-0x000000018986F690
	private void OnRegionChange(MonoRegionJoypadController.RegionInfo from, MonoRegionJoypadController.RegionInfo to) {} // 0x0000000183984360-0x00000001839845C0
	// [XID] // 0x0000000189876C20-0x0000000189876C40
	private void RequestMailData() {} // 0x0000000183985F60-0x0000000183986090
	// [XID] // 0x000000018987E720-0x000000018987E740
	private void RefreshMailDataToView() {} // 0x00000001839874F0-0x0000000183987950
	// [XID] // 0x0000000189885B10-0x0000000189885B30
	private void RefreshMailListData(bool needSort = true /* Metadata: 0x00B0EDB3 */) {} // 0x0000000183987070-0x00000001839874F0
	// [XID] // 0x000000018988CE00-0x000000018988CE20
	private void RefreshMailItemUI(Transform trans, int index) {} // 0x0000000183986A60-0x0000000183986D00
	// [XID] // 0x00000001898944F0-0x0000000189894510
	private void OnMailItemClicked(int index) {} // 0x0000000183985E50-0x0000000183985F00
	// [XID] // 0x000000018989BAC0-0x000000018989BAE0
	private void SelectMailUI(int index) {} // 0x0000000183981A30-0x0000000183982030
	// [XID] // 0x00000001898A2F30-0x00000001898A2F50
	private void SetMutiSelectStateUI(bool isOn) {} // 0x0000000183982030-0x00000001839821A0
	// [XID] // 0x00000001898AA410-0x00000001898AA430
	private void SetNoMailTipActive(bool active) {} // 0x00000001839823C0-0x0000000183982540
	// [XID] // 0x00000001898B1E10-0x00000001898B1E30
	private void SetMailNumUI() {} // 0x00000001839866C0-0x0000000183986840
	// [XID] // 0x00000001898B9AB0-0x00000001898B9AD0
	private void OnDeleteAllReadBtnClick() {} // 0x00000001839854B0-0x0000000183985640
	// [XID] // 0x00000001898C0E90-0x00000001898C0EB0
	private void DeleteAllReadMail() {} // 0x00000001839845C0-0x00000001839847F0
	// [XID] // 0x00000001898C87D0-0x00000001898C87F0
	private void OnJoypadChangeMailStarBtnClick() {} // 0x0000000183983410-0x00000001839835A0
	// [XID] // 0x00000001898D0180-0x00000001898D01A0
	private void OnChangeMailStarBtnClick(bool isOn) {} // 0x0000000183982540-0x0000000183982770
	// [XID] // 0x00000001898D7710-0x00000001898D7730
	private void OnDeleteBtnClick() {} // 0x00000001839839B0-0x0000000183983E00
	// [XID] // 0x00000001898DF460-0x00000001898DF480
	private void DeleteSelectMail(uint selectedMailId) {} // 0x0000000183985640-0x0000000183985770
	// [XID] // 0x00000001898E6E20-0x00000001898E6E40
	private void DeleteMutiSelectMail() {} // 0x0000000183985770-0x00000001839858A0
	// [XID] // 0x00000001898EE5F0-0x00000001898EE610
	private void OnMutiSelectToggle() {} // 0x0000000183986F60-0x0000000183987070
	// [XID] // 0x00000001898F5D80-0x00000001898F5DA0
	private void OnGetAllBtnClick() {} // 0x0000000183985900-0x0000000183985C90
	// [XID] // 0x00000001898FD5C0-0x00000001898FD5E0
	private void OnGetBtnClick() {} // 0x0000000183982C70-0x0000000183982EF0
	// [XID] // 0x0000000189904E80-0x0000000189904EA0
	private void OnMailTipBtnClick() {} // 0x0000000183986120-0x0000000183986230
	// [XID] // 0x000000018990C680-0x000000018990C6A0
	private void OnRefreshMailPageNotify() {} // 0x0000000183984030-0x0000000183984360
	// [XID] // 0x0000000189913F30-0x0000000189913F50
	private void OnRefreshMailPageAfterDelNotify() {} // 0x00000001839835A0-0x00000001839836C0
	// [XID] // 0x000000018991B960-0x000000018991B980
	private void OnShowMailItemGetNotify(Notify ntf) {} // 0x0000000183982770-0x0000000183982AC0
}

