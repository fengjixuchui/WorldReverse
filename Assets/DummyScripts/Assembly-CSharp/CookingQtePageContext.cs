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

public sealed class CookingQtePageContext : BasePageContext // TypeDefIndex: 28899
{
	// Fields
	private MonoCookingQTEPage _pageMono; // 0x190
	private uint _recipeId; // 0x198
	private uint _avatarId; // 0x19C
	private float _goodRangeStart; // 0x1A0
	private float _goodRangeEnd; // 0x1A4
	private float _perfectRangeStart; // 0x1A8
	private float _perfectRangeEnd; // 0x1AC
	private bool _qteStart; // 0x1B0
	private float _qteTime; // 0x1B4
	private float _qteBonusRange; // 0x1B8
	private bool _isAuto; // 0x1BC
	private int _foodKind; // 0x1C0
	private uint _oldProficiency; // 0x1C4
	private uint _newProficiency; // 0x1C8
	private uint _maxProficiency; // 0x1CC
	private uint _curProficiency; // 0x1D0
	private bool _upProficiencyStart; // 0x1D4
	private float _upProficiencyTime; // 0x1D8
	private bool _focusOnNeedItem; // 0x1DC
	private int _needItemIndex; // 0x1E0
	private bool canAutoCook; // 0x1E4
	private List<SimpleItemStruct> _itemGotList; // 0x1E8
	private bool _isAvatarPanelOpen; // 0x1F0
	private uint _toSelectAvatarId; // 0x1F4
	private int _toSelectAvatarIndex; // 0x1F8
	private List<uint> _avatarList; // 0x200

	// Constructors
	public CookingQtePageContext() {} // Dummy constructor
	public CookingQtePageContext(uint recipeId, uint avatarId) {} // 0x000000018124A980-0x000000018124ABA0

	// Methods
	// [XID] // 0x00000001898B07E0-0x00000001898B0800
	public override void SetupView() {} // 0x000000018124A6B0-0x000000018124A8D0
	// [XID] // 0x00000001898B7E10-0x00000001898B7E30
	public override void ClearView() {} // 0x00000001812432F0-0x00000001812433B0
	// [XID] // 0x00000001898BF4A0-0x00000001898BF4C0
	public override void UpdateView() {} // 0x000000018124A8D0-0x000000018124A980
	// [XID] // 0x00000001898C6D60-0x00000001898C6D80
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001812455C0-0x0000000181245D80
	// [XID] // 0x00000001898CE340-0x00000001898CE360
	private void FocusOnFoodGrp(bool force = false /* Metadata: 0x00B0E86D */) {} // 0x00000001812425A0-0x0000000181242790
	// [XID] // 0x00000001898D5D90-0x00000001898D5DB0
	private void FocusOnNeedGrp() {} // 0x0000000181246CA0-0x0000000181246E00
	// [XID] // 0x00000001898DDA80-0x00000001898DDAA0
	private void SelectNeedItem(bool next) {} // 0x000000018124A390-0x000000018124A550
	// [XID] // 0x00000001898E53B0-0x00000001898E53D0
	protected override void BindViewCallbacks() {} // 0x0000000181242790-0x0000000181242C20
	// [XID] // 0x00000001898ECAC0-0x00000001898ECAE0
	private void OnClickReturnBtn() {} // 0x0000000181245500-0x00000001812455C0
	// [XID] // 0x00000001898F44F0-0x00000001898F4510
	public override bool OnNotify(Notify ntf) => default; // 0x000000018124A0F0-0x000000018124A250
	// [XID] // 0x00000001898FBC80-0x00000001898FBCA0
	private void OnGetCookQTEArgsNotify(float qteBonusRange) {} // 0x00000001812422D0-0x00000001812423B0
	// [XID] // 0x00000001899036F0-0x0000000189903710
	private void SetCookQteView() {} // 0x0000000181244700-0x0000000181244800
	// [XID] // 0x000000018990ABE0-0x000000018990AC00
	private void SetRecipeInfo() {} // 0x0000000181249170-0x0000000181249360
	// [XID] // 0x0000000189912910-0x0000000189912930
	private void SetProficiencyInfo() {} // 0x0000000181249920-0x0000000181249C50
	// [XID] // 0x000000018991A1E0-0x000000018991A200
	private void SetCurRecipeFoodNum() {} // 0x0000000181249D10-0x0000000181249F10
	// [XID] // 0x00000001899219E0-0x0000000189921A00
	private void OnRecipeIconClicked() {} // 0x000000018124A550-0x000000018124A6B0
	// [XID] // 0x0000000189929100-0x0000000189929120
	private void GetQteRange(string qteStr) {} // 0x0000000181248E20-0x0000000181249170
	// [XID] // 0x0000000189930650-0x0000000189930670
	private void SetQteRangeView() {} // 0x0000000181248A70-0x0000000181248C30
	// [XID] // 0x0000000189937BE0-0x0000000189937C00
	private float GetAvatarBonusRatio() => default; // 0x0000000181242220-0x00000001812422D0
	// [XID] // 0x000000018993F650-0x000000018993F670
	private void SetFoodPanel(IdCountConfig[] inputList) {} // 0x0000000181244330-0x0000000181244700
	// [XID] // 0x0000000189946C60-0x0000000189946C80
	private void SetAvatarBonusView() {} // 0x0000000181242C20-0x00000001812430F0
	// [XID] // 0x000000018994E2E0-0x000000018994E300
	private void SetAutoMakeBtnShow(CookRecipeExcelConfig cookConfig) {} // 0x0000000181247870-0x0000000181247BB0
	// [XID] // 0x0000000189955940-0x0000000189955960
	private bool CheckItemNumEnough(uint recipeId) => default; // 0x0000000181248490-0x0000000181248660
	// [XID] // 0x000000018995D3E0-0x000000018995D400
	private void OnMakeBtnClick() {} // 0x0000000181243EB0-0x00000001812442A0
	// [XID] // 0x0000000189964AD0-0x0000000189964AF0
	private void OnAutoMakeBtnClick() {} // 0x0000000181246770-0x0000000181246910
	// [XID] // 0x000000018996C150-0x000000018996C170
	public void OnAutoMakeConfirm(uint selectCount) {} // 0x0000000181245130-0x00000001812454A0
	// [XID] // 0x0000000189973C00-0x0000000189973C20
	private void PlayQteAnimation(bool showQte) {} // 0x0000000181244B80-0x0000000181244DB0
	// [XID] // 0x000000018997B270-0x000000018997B290
	private void PlayQtePerformAnimation() {} // 0x0000000181247BB0-0x0000000181247EA0
	// [XID] // 0x0000000189982D60-0x0000000189982D80
	private void StartUpdateProficiency() {} // 0x0000000181249C50-0x0000000181249D10
	// [XID] // 0x000000018998A510-0x000000018998A530
	private void UpdateProficiency() {} // 0x0000000181245D80-0x0000000181246010
	// [XID] // 0x0000000189991E40-0x0000000189991E60
	private void ShowUnlockTips() {} // 0x0000000181248020-0x00000001812481A0
	// [XID] // 0x0000000189999B10-0x0000000189999B30
	private void StartQte() {} // 0x0000000181248C30-0x0000000181248CF0
	// [XID] // 0x00000001899A1220-0x00000001899A1240
	private void UpdateQte() {} // 0x00000001812449E0-0x0000000181244B80
	// [XID] // 0x00000001899A8CB0-0x00000001899A8CD0
	private void EndQte() {} // 0x00000001812433B0-0x0000000181243580
	// [XID] // 0x00000001899B05F0-0x00000001899B0610
	private void OnRefreshCookPageNotify(PlayerCookRsp rsp) {} // 0x00000001812423B0-0x00000001812425A0
	// [XID] // 0x00000001899B7920-0x00000001899B7940
	private void ShowQteResult(PlayerCookRsp rsp) {} // 0x0000000181248660-0x0000000181248A70
	// [XID] // 0x00000001899BF300-0x00000001899BF320
	private void SetAutoQteView(bool isAuto) {} // 0x000000018124A250-0x000000018124A390
	// [XID] // 0x00000001899C6CF0-0x00000001899C6D10
	private void SetupCookGotPanel(PlayerCookRsp rsp, List<SimpleItemStruct> itemList) {} // 0x0000000181246120-0x0000000181246770
	// [XID] // 0x00000001899CE220-0x00000001899CE240
	private void OnSelectRewardStateChange(Transform trans, bool isSelect) {} // 0x0000000181248CF0-0x0000000181248E20
	// [XID] // 0x00000001899D5A20-0x00000001899D5A40
	private void RefreshItemGotSlot(Transform trans, int index) {} // 0x0000000181243870-0x0000000181243BF0
	// [XID] // 0x00000001899DCD30-0x00000001899DCD50
	private void OpenItemGotPanel(PlayerCookRsp rsp, List<SimpleItemStruct> itemList) {} // 0x00000001812431B0-0x00000001812432F0
	// [XID] // 0x00000001899E4950-0x00000001899E4970
	private void CloseItemGotPanel() {} // 0x0000000181243730-0x0000000181243870
	// [XID] // 0x00000001899EBDC0-0x00000001899EBDE0
	private void OnAvatarPanelOpen(bool bOpen) {} // 0x0000000181246070-0x0000000181246120
	// [XID] // 0x00000001899F37F0-0x00000001899F3810
	private void OpenAvatarSelectPanel() {} // 0x0000000181244800-0x00000001812449E0
	// [XID] // 0x00000001899FB130-0x00000001899FB150
	private void CloseAvatarSelectPanel() {} // 0x0000000181243BF0-0x0000000181243EB0
	// [XID] // 0x0000000189A02360-0x0000000189A02380
	private void SetAvatarSelectView() {} // 0x00000001812481A0-0x0000000181248490
	// [XID] // 0x0000000189A09B70-0x0000000189A09B90
	private void RefreshAvatarList(uint recipeId) {} // 0x0000000181246910-0x0000000181246CA0
	// [XID] // 0x0000000189A11330-0x0000000189A11350
	private void RefreshAvatarRow(Transform trans, int index) {} // 0x0000000181246E00-0x00000001812471E0
	// [XID] // 0x0000000189A18740-0x0000000189A18760
	private void RefreshSelectedAvatarState() {} // 0x00000001812471E0-0x00000001812474D0
	// [XID] // 0x0000000189A1FDA0-0x0000000189A1FDC0
	private void OnAvatarRowClick(int index) {} // 0x0000000181244DB0-0x0000000181245130
	// [XID] // 0x0000000189A27110-0x0000000189A27130
	private int CheckIsBonusAvatar(uint recipeId, AvatarDataItem avatarData) => default; // 0x0000000181247EA0-0x0000000181248020
	// [XID] // 0x0000000189A2E970-0x0000000189A2E990
	public static uint GetAvatarBonusSkillId(uint recipeId, AvatarDataItem avatarData) => default; // 0x0000000181249360-0x00000001812497E0
	// [XID] // 0x0000000189A36280-0x0000000189A362A0
	private bool CheckHaveBonusAvatar(uint recipeId) => default; // 0x0000000181243580-0x0000000181243730
	// [XID] // 0x0000000189A3D880-0x0000000189A3D8A0
	private void OnSelectAvatarBtnClick() {} // 0x0000000181249F70-0x000000018124A060
	// [XID] // 0x0000000189A44FE0-0x0000000189A45000
	private void OnSelectAvatar() {} // 0x00000001812430F0-0x00000001812431B0
	// [XID] // 0x0000000189A4C740-0x0000000189A4C760
	private void SetSelectAvatar() {} // 0x00000001812474D0-0x0000000181247810
}

