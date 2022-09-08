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

public class CookingPageContext : BasePageContext // TypeDefIndex: 28890
{
	// Fields
	private List<uint> _compoundCookList; // 0x190
	private Dictionary<uint, CompoundItemData> _currCompoundDic; // 0x198
	private int _selectCompoundIndex; // 0x1A0
	private uint _selectCompoundId; // 0x1A4
	private Coroutine _refreshCoroutine; // 0x1A8
	private Dictionary<CookFoodType, List<CookRecipeData>> _recipeTypeDic; // 0x1B0
	private List<BagItemSlot> _foodRecipeList; // 0x1B8
	private int _selectedIndex; // 0x1C0
	private uint _selectedRecipeId; // 0x1C4
	private uint _selectRecipeItemId; // 0x1C8
	private List<uint> _avatarList; // 0x1D0
	private uint _selectedAvatarId; // 0x1D8
	private uint _toSelectAvatarId; // 0x1DC
	private CookFoodType _foodType; // 0x1E0
	private bool _isAsce; // 0x1E4
	private bool _screenOpen; // 0x1E5
	private bool _isAvatarPanelOpen; // 0x1E6
	private CookingPageType _type; // 0x1E8
	private MonoCookingPage _pageMono; // 0x1F0
	private bool _focusedOnItemDetail; // 0x1F8

	// Constructors
	public CookingPageContext() {} // Dummy constructor
	public CookingPageContext(CookingPageType pageType) {} // 0x00000001847B0010-0x00000001847B0160

	// Methods
	// [XID] // 0x0000000189B92E80-0x0000000189B92EA0
	private void SetCompoundView() {} // 0x00000001847A5A60-0x00000001847A5B30
	// [XID] // 0x0000000189B9A440-0x0000000189B9A460
	private void RefreshCompoundList() {} // 0x00000001847ADA90-0x00000001847ADCC0
	// [XID] // 0x0000000189BA1B70-0x0000000189BA1B90
	private void RefreshCurrentCompoundDic() {} // 0x00000001847AA3B0-0x00000001847AA690
	// [XID] // 0x0000000189BA8FF0-0x0000000189BA9010
	private void SetCompoundPanelview(bool isInit = true /* Metadata: 0x00B0E860 */) {} // 0x00000001847A5B30-0x00000001847A5EF0
	// [XID] // 0x0000000189BB0760-0x0000000189BB0780
	private void CheckNearestCompoundTime() {} // 0x00000001847A60C0-0x00000001847A6180
	// [XID] // 0x0000000189BB7AE0-0x0000000189BB7B00
	private void RefreshCompoundIcon(Transform trans, int index) {} // 0x00000001847A7330-0x00000001847A7580
	// [XID] // 0x0000000189BBF100-0x0000000189BBF120
	private void OnCompoundIconClick(int index) {} // 0x00000001847A6640-0x00000001847A66F0
	// [XID] // 0x0000000189BC6DD0-0x0000000189BC6DF0
	private void SelectCompound(int index) {} // 0x00000001847AC3B0-0x00000001847AC750
	// [XID] // 0x0000000189BCEA80-0x0000000189BCEAA0
	private void SetFetchBtnStyle(uint finishNum) {} // 0x00000001847AE680-0x00000001847AE880
	// [XID] // 0x0000000189BD5D60-0x0000000189BD5D80
	private void SetMakeNumLabel(uint compoundId) {} // 0x00000001847AFAF0-0x00000001847AFE30
	// [XID] // 0x0000000189BDD9F0-0x0000000189BDDA10
	private void OnFetchBtnClick() {} // 0x00000001847AEFD0-0x00000001847AF0C0
	// [XID] // 0x00000001895EA5D0-0x00000001895EA5F0
	private void OnCompoundBtnClick() {} // 0x00000001847A7880-0x00000001847A7AA0
	// [XID] // 0x00000001895F1A50-0x00000001895F1A70
	private uint CheckCompoundQueNaxNum(uint compoundId) => default; // 0x00000001847ACF80-0x00000001847AD0E0
	// [XID] // 0x00000001895F9430-0x00000001895F9450
	private int CompareCompoundItem(uint xCompoundId, uint yCompoundId) => default; // 0x00000001847AB720-0x00000001847AB8A0
	// [XID] // 0x0000000189600A80-0x0000000189600AA0
	private uint GetNearestCompoundTime() => default; // 0x00000001847AF2E0-0x00000001847AF550
	// [XID] // 0x00000001896083A0-0x00000001896083C0
	private void StartRefreshCompoundCoroutine(float duration) {} // 0x00000001847A66F0-0x00000001847A6850
	// [XID] // 0x000000018960FD20-0x000000018960FD40
	private void StopRefreshCompoundCoroutine() {} // 0x00000001847AD990-0x00000001847ADA90
	// [XID] // 0x0000000189617000-0x0000000189617020
	private void GetCompoundResult() {} // 0x00000001847ADE60-0x00000001847ADF40
	// [XID] // 0x000000018961EB80-0x000000018961EBA0
	private void OnRefreshCookCompoundPageNotify() {} // 0x00000001847AD7D0-0x00000001847AD8E0
	// [XID] // 0x0000000189625F80-0x0000000189625FA0
	private void OnGetCompoundOutputNotify(List<SimpleItemStruct> itemList) {} // 0x00000001847A86B0-0x00000001847A87A0
	// [XID] // 0x000000018962D940-0x000000018962D960
	private void SetCookingView() {} // 0x00000001847A9E30-0x00000001847A9F80
	// [XID] // 0x00000001896354C0-0x00000001896354E0
	private void RefreshRecipeList() {} // 0x00000001847A5460-0x00000001847A5A60
	// [XID] // 0x000000018963CBA0-0x000000018963CBC0
	private void SetFoodTab() {} // 0x00000001847A6180-0x00000001847A6560
	// [XID] // 0x00000001896441E0-0x0000000189644200
	private void OnFoodTabClicked(int index) {} // 0x00000001847A8BD0-0x00000001847A8E00
	// [XID] // 0x000000018964B990-0x000000018964B9B0
	private void SetFoodTypeView(CookFoodType foodType) {} // 0x00000001847A8EA0-0x00000001847A9A90
	// [XID] // 0x0000000189653120-0x0000000189653140
	private void RefreshRecipeItemIcon(Transform trans, int index) {} // 0x00000001847AA030-0x00000001847AA300
	// [XID] // 0x000000018965A7E0-0x000000018965A800
	private void RefreshRecipeAndItemIcon(Transform trans, int index) {} // 0x00000001847A8800-0x00000001847A8BD0
	// [XID] // 0x0000000189661E10-0x0000000189661E30
	private void RefreshRecipeIcon(Transform trans, int index) {} // 0x00000001847AF750-0x00000001847AF990
	// [XID] // 0x00000001896699F0-0x0000000189669A10
	private void OnRecipeAndItemIconClicked(int index) {} // 0x00000001847AE3C0-0x00000001847AE470
	// [XID] // 0x0000000189671520-0x0000000189671540
	private void OnRecipeIconClicked(int index) {} // 0x00000001847AF990-0x00000001847AFA40
	// [XID] // 0x0000000189678DE0-0x0000000189678E00
	private void OnRecipeItemIconClicked(int index) {} // 0x00000001847AD8E0-0x00000001847AD990
	// [XID] // 0x0000000189680530-0x0000000189680550
	private void SelectRecipeAndItem(int index) {} // 0x00000001847A7CB0-0x00000001847A81A0
	// [XID] // 0x0000000189688010-0x0000000189688030
	private void SelectRecipeItem(int index) {} // 0x00000001847A81A0-0x00000001847A8500
	// [XID] // 0x000000018968FA30-0x000000018968FA50
	private void SelectRecipe(int index) {} // 0x00000001847AC060-0x00000001847AC3B0
	// [XID] // 0x0000000189697430-0x0000000189697450
	private void SetSelectAvatar() {} // 0x00000001847ABC60-0x00000001847AC060
	// [XID] // 0x000000018969E980-0x000000018969E9A0
	private void OnAvatarPanelOpen(bool bOpen) {} // 0x00000001847AB5A0-0x00000001847AB720
	// [XID] // 0x00000001896A5970-0x00000001896A5990
	private void OpenAvatarSelectPanel() {} // 0x00000001847A9F80-0x00000001847AA030
	// [XID] // 0x00000001896AD1F0-0x00000001896AD210
	private void CloseAvatarSelectPanel() {} // 0x00000001847A8E00-0x00000001847A8EA0
	// [XID] // 0x00000001896B4800-0x00000001896B4820
	private void SetAvatarSelectView() {} // 0x00000001847AC8D0-0x00000001847AC9C0
	// [XID] // 0x00000001896BBAD0-0x00000001896BBAF0
	private void RefreshAvatarList(uint recipeId) {} // 0x00000001847AB8A0-0x00000001847ABBA0
	// [XID] // 0x00000001896C2F90-0x00000001896C2FB0
	private void RefreshAvatarRow(Transform trans, int index) {} // 0x00000001847ABBA0-0x00000001847ABC60
	// [XID] // 0x00000001896CA420-0x00000001896CA440
	private void OnAvatarRowClick(int index) {} // 0x00000001847AA300-0x00000001847AA3B0
	// [XID] // 0x00000001896D1A90-0x00000001896D1AB0
	private int CheckIsBonusAvatar(uint recipeId, AvatarDataItem avatarData) => default; // 0x00000001847AC750-0x00000001847AC8D0
	// [XID] // 0x00000001896D92C0-0x00000001896D92E0
	private bool CheckHaveBonusAvatar(uint recipeId) => default; // 0x00000001847A8500-0x00000001847A86B0
	// [XID] // 0x00000001896E0AD0-0x00000001896E0AF0
	private void OnSelectAvatarBtnClick() {} // 0x00000001847ADF40-0x00000001847ADFF0
	// [XID] // 0x00000001896E7D40-0x00000001896E7D60
	private void OnSelectAvatar() {} // 0x00000001847A71D0-0x00000001847A7290
	// [XID] // 0x00000001896EF470-0x00000001896EF490
	private void OnCookBtnClick() {} // 0x00000001847AD320-0x00000001847AD4C0
	// [XID] // 0x00000001896F6E00-0x00000001896F6E20
	private void OnLearnBtnClick() {} // 0x00000001847AD180-0x00000001847AD320
	// [XID] // 0x00000001896FE730-0x00000001896FE750
	private int CompareCookRecipe(CookRecipeData xRecipe, CookRecipeData yRecipe) => default; // 0x00000001847A7000-0x00000001847A71D0
	// [XID] // 0x0000000189705820-0x0000000189705840
	private int CompareCookRecipeItem(BagItemSlot xItem, BagItemSlot yItem) => default; // 0x00000001847A7580-0x00000001847A77D0
	// [XID] // 0x000000018970D360-0x000000018970D380
	private void SetScreeningView() {} // 0x00000001847AF550-0x00000001847AF750
	// [XID] // 0x0000000189714800-0x0000000189714820
	private void RefreshScreeninRow(Transform trans, int index) {} // 0x00000001847AEB80-0x00000001847AEF40
	// [XID] // 0x000000018971C210-0x000000018971C230
	private void OnScreeningRowClick(CookFoodType foodType) {} // 0x00000001847ADCC0-0x00000001847ADE00
	// [XID] // 0x00000001897236A0-0x00000001897236C0
	private void OnScreenBtnClick() {} // 0x00000001847A5EF0-0x00000001847A60C0
	// [XID] // 0x000000018972AE00-0x000000018972AE20
	private void OnScreenBackClick() {} // 0x00000001847ACD70-0x00000001847ACEC0
	// [XID] // 0x00000001897324D0-0x00000001897324F0
	private void ChangeSortOrder() {} // 0x00000001847AC9C0-0x00000001847ACC00
	// [XID] // 0x0000000189739BC0-0x0000000189739BE0
	public override void SetupView() {} // 0x00000001847AFF10-0x00000001847B0010
	// [XID] // 0x00000001897417C0-0x00000001897417E0
	public override bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001847AAB80-0x00000001847AAC40
	// [XID] // 0x00000001897490A0-0x00000001897490C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001847AAC40-0x00000001847AB540
	// [XID] // 0x0000000189750550-0x0000000189750570
	public override void ClearView() {} // 0x00000001847A7290-0x00000001847A7330
	// [XID] // 0x0000000189757AB0-0x0000000189757AD0
	protected override void BindViewCallbacks() {} // 0x00000001847A69F0-0x00000001847A7000
	// [XID] // 0x000000018975F530-0x000000018975F550
	protected override void OnEnable() {} // 0x00000001847AF0C0-0x00000001847AF180
	// [XID] // 0x00000001897669E0-0x0000000189766A00
	protected override void PostProcessOfSetActive() {} // 0x00000001847AFE30-0x00000001847AFF10
	// [XID] // 0x000000018976DF90-0x000000018976DFB0
	public override bool OnNotify(Notify ntf) => default; // 0x00000001847AF180-0x00000001847AF2E0
	// [XID] // 0x0000000189775710-0x0000000189775730
	private void SetCommonView() {} // 0x00000001847AA760-0x00000001847AA9B0
	// [XID] // 0x000000018977CF50-0x000000018977CF70
	private void RefreshWeightLabel(Notify ntf) {} // 0x00000001847ACC00-0x00000001847ACD70
	// [XID] // 0x0000000189784970-0x0000000189784990
	private void SetMenuTab() {} // 0x00000001847ADFF0-0x00000001847AE3C0
	// [XID] // 0x000000018978BF60-0x000000018978BF80
	private void OnTabClicked(int index) {} // 0x00000001847A9C70-0x00000001847A9E30
	// [XID] // 0x00000001897933B0-0x00000001897933D0
	private void SetContentView(CookingPageType type) {} // 0x00000001847AE880-0x00000001847AEB80
	// [XID] // 0x000000018979B600-0x000000018979B620
	private void ShowContentPanel(CookingPageType type) {} // 0x00000001847ACEC0-0x00000001847ACF80
	// [XID] // 0x00000001897A2AA0-0x00000001897A2AC0
	private void OnMakeBtnClick() {} // 0x00000001847A9A90-0x00000001847A9B50
	// [XID] // 0x00000001897AA080-0x00000001897AA0A0
	private void OnPrevBtnClick() {} // 0x00000001847A6910-0x00000001847A69F0
	// [XID] // 0x00000001897B1A50-0x00000001897B1A70
	private void OnNextBtnClick() {} // 0x00000001847A6560-0x00000001847A6640
	// [XID] // 0x00000001897B9470-0x00000001897B9490
	private void OnItemDetailFocusBtnClick() {} // 0x00000001847AFA40-0x00000001847AFAF0
	// [XID] // 0x00000001897C14C0-0x00000001897C14E0
	private void OnItemDetailBackBtnClick() {} // 0x00000001847A77D0-0x00000001847A7880
	// [XID] // 0x00000001897C8F20-0x00000001897C8F40
	private void OnItemDetailCheckBtnClick() {} // 0x00000001847AE470-0x00000001847AE510
	// [XID] // 0x00000001897D0580-0x00000001897D05A0
	private void FocusOnItemTip(bool focus) {} // 0x00000001847AD4C0-0x00000001847AD7D0
	// [XID] // 0x00000001897D82E0-0x00000001897D8300
	private void SetNoItemTipActive(bool active) {} // 0x00000001847A7AA0-0x00000001847A7CB0
	// [XID] // 0x00000001897DF360-0x00000001897DF380
	private void SetMakeNumActive(bool active) {} // 0x00000001847AA9B0-0x00000001847AAB20
	// [XID] // 0x00000001897E6C20-0x00000001897E6C40
	private void SwitchToLearnBtn(bool active) {} // 0x00000001847AE510-0x00000001847AE680
}

