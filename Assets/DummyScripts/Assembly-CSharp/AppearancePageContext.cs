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

public sealed class AppearancePageContext : BasePageContext // TypeDefIndex: 28795
{
	// Fields
	private ulong _curAvatarGuid; // 0x190
	private MonoAppearancePage _pageMono; // 0x198
	private AppearanceUISceneComponent _uiSceneComp; // 0x1A0
	private int _curFlyCloakIndex; // 0x1A8
	private int _curFlySrcIndex; // 0x1AC
	private List<uint> _avatarFlycloakList; // 0x1B0
	private List<string> _dungeonNameList; // 0x1B8
	private Dictionary<string, List<uint>> _dungeonNameToIDsDict; // 0x1C0
	private List<SourceJumpConfig> _jumpIDList; // 0x1C8
	private List<string> _textList; // 0x1D0
	private uint _dungeonID; // 0x1D8

	// Constructors
	public AppearancePageContext() {} // Dummy constructor
	public AppearancePageContext(ulong guid) {} // 0x00000001851D0210-0x00000001851D03B0

	// Methods
	// [XID] // 0x00000001896BFED0-0x00000001896BFEF0
	public override void SetupView() {} // 0x00000001851D00F0-0x00000001851D0210
	// [XID] // 0x00000001896C77D0-0x00000001896C77F0
	private void PrepareFlyCloak() {} // 0x00000001851CE550-0x00000001851CE7F0
	// [XID] // 0x00000001896CEF70-0x00000001896CEF90
	private void SetupConfig() {} // 0x00000001851CD4F0-0x00000001851CD7A0
	// [XID] // 0x00000001896D6370-0x00000001896D6390
	public override void ClearView() {} // 0x00000001851CBC30-0x00000001851CBD40
	// [XID] // 0x00000001896DD990-0x00000001896DD9B0
	public override void ClosePage() {} // 0x00000001851CB3F0-0x00000001851CB4B0
	// [XID] // 0x00000001896E5040-0x00000001896E5060
	protected override void BindViewCallbacks() {} // 0x00000001851CB5B0-0x00000001851CB7B0
	// [XID] // 0x00000001896EC4E0-0x00000001896EC500
	private void SetFlyCloakReplaceButtonEnable(bool enable) {} // 0x00000001851CB970-0x00000001851CBB00
	// [XID] // 0x00000001896F3CB0-0x00000001896F3CD0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001851CFB50-0x00000001851CFE40
	// [XID] // 0x00000001896FB420-0x00000001896FB440
	protected override void OnEnable() {} // 0x00000001851CFA40-0x00000001851CFB50
	// [XID] // 0x0000000189702BB0-0x0000000189702BD0
	private void Refresh() {} // 0x00000001851CAF70-0x00000001851CB030
	// [XID] // 0x000000018970A2F0-0x000000018970A310
	private void OnBackButton() {} // 0x00000001851CF160-0x00000001851CF210
	// [XID] // 0x0000000189711E10-0x0000000189711E30
	private void OnFlyCloakSrcSelectorChange(Transform trans, int index) {} // 0x00000001851CE7F0-0x00000001851CEA40
	// [XID] // 0x0000000189719210-0x0000000189719230
	private void OnFlyCloakDetailsButton() {} // 0x00000001851CF6D0-0x00000001851CF870
	// [XID] // 0x00000001897208D0-0x00000001897208F0
	private void OnFlyCloakReplaceButton() {} // 0x00000001851CB850-0x00000001851CB970
	// [XID] // 0x0000000189727E80-0x0000000189727EA0
	private void SetupViewFlyCloak() {} // 0x00000001851CE340-0x00000001851CE550
	// [XID] // 0x000000018972F4C0-0x000000018972F4E0
	private void RefreshFlyCloakItem(Transform trans, int index) {} // 0x00000001851CF270-0x00000001851CF6D0
	// [XID] // 0x0000000189736F00-0x0000000189736F20
	private void SetItemSelectedView(Transform trans, bool selected) {} // 0x00000001851CBB00-0x00000001851CBC30
	// [XID] // 0x000000018973EAC0-0x000000018973EAE0
	private void OnFlyCloakSelect(int index) {} // 0x00000001851CEA40-0x00000001851CF160
	// [XID] // 0x0000000189745D80-0x0000000189745DA0
	private void RefreshItemSource(uint materialId, MonoGridScroller sourceScroller) {} // 0x00000001851CD7A0-0x00000001851CE1C0
	// [XID] // 0x000000018974D870-0x000000018974D890
	private void RefreshSourceDungeonListItem(Transform trans, int index) {} // 0x00000001851CC130-0x00000001851CC8A0
	// [XID] // 0x0000000189754EB0-0x0000000189754ED0
	private string GetJumpTitle(SourceJumpType type) => default; // 0x00000001851CB4B0-0x00000001851CB5B0
	// [XID] // 0x000000018975C040-0x000000018975C060
	private void OnJumpEntry(SourceJumpConfig jumpConfig) {} // 0x00000001851CD310-0x00000001851CD4F0
	// [XID] // 0x00000001897639F0-0x0000000189763A10
	private void OnDungeonEntryInfoRsp(DungeonEntryInfoRsp rsp) {} // 0x00000001851CFE40-0x00000001851D00F0
	// [XID] // 0x000000018976B1B0-0x000000018976B1D0
	private void OnDungeonEntry(uint dungeonID) {} // 0x00000001851CB030-0x00000001851CB350
	// [XID] // 0x0000000189772800-0x0000000189772820
	private void UpTab() {} // 0x00000001851CB7B0-0x00000001851CB850
	// [XID] // 0x0000000189779E30-0x0000000189779E50
	private void DownTab() {} // 0x00000001851CB350-0x00000001851CB3F0
	// [XID] // 0x0000000189781A90-0x0000000189781AB0
	private void ToDetail() {} // 0x00000001851CE1C0-0x00000001851CE340
	// [XID] // 0x0000000189788F90-0x0000000189788FB0
	private void ToDefault() {} // 0x00000001851CBE30-0x00000001851CC130
	// [XID] // 0x0000000189790580-0x00000001897905A0
	private void RotateModelByDelta(Vector2 delta) {} // 0x00000001851CF870-0x00000001851CF9B0
	// [XID] // 0x0000000189797F70-0x0000000189797F90
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001851CCFF0-0x00000001851CD2B0
	// [XID] // 0x000000018979FC90-0x000000018979FCB0
	private bool HandleFlyCloakPanelEvent(InputActionEvent actionEvent) => default; // 0x00000001851CC8A0-0x00000001851CCF30
}

