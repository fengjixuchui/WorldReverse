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

public class TalkDialogContext : BaseDialogContext // TypeDefIndex: 29320
{
	// Fields
	private const int COOP_TEMPERAMENT_ADD_VALUE = 10; // Metadata: 0x00B0F5CD
	private bool _inCoopSelect; // 0x178
	private bool _inCoopTemperamentSelect; // 0x179
	private bool _coopSelectShow; // 0x17A
	private int _selectCoopIndex; // 0x17C
	private DialogAction _currDialogAction; // 0x180
	private DialogSelectAction _currDialogSelectAction; // 0x188
	private MonoTalkDialog _dialogMono; // 0x190
	private ConfigDialogScheme _currDialog; // 0x198
	private float _protectTime; // 0x1A0
	private bool _autoClick; // 0x1A4
	private readonly string CountDownProgressPrefab; // 0x1A8
	private uint _handle; // 0x1B0
	private GameObject _countDownGo; // 0x1B8
	private MonoTalkCountDownProgress _countDownScript; // 0x1C0
	private List<SelectItemParam> _selectParamList; // 0x1C8
	private Action _onFreeClick; // 0x1D0
	private float _interactableTime; // 0x1D8
	private Coroutine _showClickTipCoroutine; // 0x1E0
	private bool _differentRole; // 0x1E8
	private Coroutine _showSelectOptionsCoroutine; // 0x1F0
	private bool _inSelect; // 0x1F8
	private Coroutine WaitDialogSelectCoroutine; // 0x200

	// Properties
	public bool autoClick { /* [XID] */ /* 0x0000000189736DE0-0x0000000189736E00 */ get => default; /* [XID] */ /* 0x000000018973E9A0-0x000000018973E9C0 */ set {} } // 0x00000001837FE0D0-0x00000001837FE180 0x00000001837FE7E0-0x00000001837FE890
	public Action onFreeClick { /* [XID] */ /* 0x000000018976B0D0-0x000000018976B0F0 */ get => default; /* [XID] */ /* 0x0000000189772720-0x0000000189772740 */ set {} } // 0x00000001837FD960-0x00000001837FDA10 0x00000001837FCAC0-0x00000001837FCB70
	public bool canClick { /* [XID] */ /* 0x0000000189779D50-0x0000000189779D70 */ get => default; } // 0x00000001837FD280-0x00000001837FD3D0 
	private float showSelctOptionsDelay { /* [XID] */ /* 0x00000001897A7130-0x00000001897A7150 */ get => default; } // 0x00000001837FF370-0x00000001837FF460 

	// Constructors
	public TalkDialogContext() {} // 0x00000001838026C0-0x0000000183802830

	// Methods
	// [XID] // 0x000000018968C5F0-0x000000018968C610
	private void CheckCoopStyleShow() {} // 0x00000001837FDFE0-0x00000001837FE0D0
	// [XID] // 0x0000000189694040-0x0000000189694060
	private void SetupCoopView() {} // 0x00000001837FF970-0x00000001837FFBE0
	// [XID] // 0x000000018969B5B0-0x000000018969B5D0
	public void OnCoopSelectNotify(List<SelectItemParam> selectParamList) {} // 0x0000000183800250-0x0000000183800330
	// [XID] // 0x00000001896A2D30-0x00000001896A2D50
	private void SetupCoopSelectItem(List<SelectItemParam> selectParamList, bool isTalk = true /* Metadata: 0x00B0F5C8 */) {} // 0x00000001837FB0F0-0x00000001837FBA20
	// [XID] // 0x00000001896AA1E0-0x00000001896AA200
	private string GetCoopCondDesc(CoopCond condition, bool condEnable) => default; // 0x0000000183800470-0x0000000183800810
	// [XID] // 0x00000001896B0FC0-0x00000001896B0FE0
	private void OnCoopSelectItemClick(int index) {} // 0x00000001837FF200-0x00000001837FF370
	// [XID] // 0x00000001896B8BF0-0x00000001896B8C10
	private void SetAllCoopSelectItemActive(bool active) {} // 0x00000001838009F0-0x0000000183800B60
	// [XID] // 0x00000001896BFE10-0x00000001896BFE30
	private void SetAllCoopSelectItemInteractable(bool active) {} // 0x00000001837FE670-0x00000001837FE7E0
	// [XID] // 0x00000001896C7710-0x00000001896C7730
	private void SetAllCoopSelectItemState(bool selected) {} // 0x0000000183801760-0x0000000183801940
	// [XID] // 0x00000001896CEE90-0x00000001896CEEB0
	private void SetCoopSelectBgImgActive(int selectItemCount) {} // 0x00000001837FCD50-0x00000001837FCFB0
	// [XID] // 0x00000001896D62B0-0x00000001896D62D0
	private void RefreshConfidenceSlider() {} // 0x0000000183802290-0x00000001838023D0
	// [XID] // 0x00000001896DD890-0x00000001896DD8B0
	private void PlayConfidenceChangeEffect(float oldValue, float currValue) {} // 0x00000001837FEDA0-0x00000001837FF1A0
	// [XID] // 0x00000001896E4F00-0x00000001896E4F20
	private void RefreshTemperamentSlider(int type = -1 /* Metadata: 0x00B0F5C9 */) {} // 0x0000000183801CF0-0x0000000183802290
	// [XID] // 0x00000001896EC400-0x00000001896EC420
	private void RefreshAvatarIcon() {} // 0x00000001837FAED0-0x00000001837FB0F0
	// [XID] // 0x00000001896F3B90-0x00000001896F3BB0
	private void ShowCoopTemperamentSelectStyle() {} // 0x00000001837FA7D0-0x00000001837FAED0
	// [XID] // 0x00000001896FB300-0x00000001896FB320
	private void CoopTemperamentSelect(int index) {} // 0x0000000183800810-0x00000001838009F0
	// [XID] // 0x0000000189702AB0-0x0000000189702AD0
	private CoopTemperamentType GetCoopTemperamentTypeByIndex(int index) => default; // 0x00000001837FF890-0x00000001837FF970
	// [XID] // 0x000000018970A1D0-0x000000018970A1F0
	private string GetCoopTemperamentNameByType(CoopTemperamentType type) => default; // 0x0000000183800E80-0x0000000183800FA0
	// [XID] // 0x0000000189711CB0-0x0000000189711CD0
	private string GetOrderingTypeString(OrderingType type) => default; // 0x0000000183800330-0x0000000183800470
	// [XID] // 0x0000000189719110-0x0000000189719130
	private void SelectCoopSelectItem(int index) {} // 0x0000000183800FA0-0x0000000183801290
	// [XID] // 0x00000001897207B0-0x00000001897207D0
	private int GetNewCoopSelectIndex(ContextEventType eventType) => default; // 0x00000001837FF6A0-0x00000001837FF890
	// [XID] // 0x0000000189727D60-0x0000000189727D80
	private void ChangeCoopSelection(ContextEventType eventType) {} // 0x00000001838023D0-0x00000001838024A0
	// [XID] // 0x000000018972F3E0-0x000000018972F400
	private void ConfirmCoopSelection() {} // 0x00000001837FBBB0-0x00000001837FBDB0
	// [XID] // 0x0000000189745CA0-0x0000000189745CC0
	public override void SetupView() {} // 0x00000001838024A0-0x00000001838026C0
	// [XID] // 0x000000018974D750-0x000000018974D770
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001837FE890-0x00000001837FEDA0
	// [XID] // 0x0000000189754D90-0x0000000189754DB0
	public override void ClearView() {} // 0x00000001837FC950-0x00000001837FCAC0
	// [XID] // 0x000000018975BF80-0x000000018975BFA0
	protected override void BindViewCallbacks() {} // 0x00000001837FBA20-0x00000001837FBBB0
	// [XID] // 0x00000001897638F0-0x0000000189763910
	public override bool OnNotify(Notify ntf) => default; // 0x00000001838019D0-0x0000000183801CF0
	// [XID] // 0x00000001897819D0-0x00000001897819F0
	private void CancelShowClickTip() {} // 0x0000000183800B60-0x0000000183800C60
	// [XID] // 0x0000000189788ED0-0x0000000189788EF0
	private void SetCurrDialog(ConfigDialogScheme value, uint mainQuestId) {} // 0x00000001837FD100-0x00000001837FD220
	// [XID] // 0x00000001897904C0-0x00000001897904E0
	public void ShowTalk(DialogAction dialogAction, uint mainQuestId) {} // 0x00000001837FC280-0x00000001837FC950
	// [XID] // 0x0000000189797EB0-0x0000000189797ED0
	public bool ShowAllDialogContent() => default; // 0x00000001837FD890-0x00000001837FD960
	// [XID] // 0x000000018979FB90-0x000000018979FBB0
	private void CancelShowSelectOptions() {} // 0x0000000183800D80-0x0000000183800E80
	// [XID] // 0x00000001897AEAE0-0x00000001897AEB00
	private bool IsUsingJoypad() => default; // 0x0000000183800C60-0x0000000183800D80
	// [XID] // 0x00000001897B6970-0x00000001897B6990
	private void OnDialogSelectNotify(Notify ntf) {} // 0x00000001837FFBE0-0x0000000183800250
	// [XID] // 0x00000001897BE7B0-0x00000001897BE7D0
	private void SetSelectOptionsStyle() {} // 0x0000000183801460-0x0000000183801760
	// [XID] // 0x00000001897C5EC0-0x00000001897C5EE0
	private void ClearInSelect() {} // 0x00000001837FA480-0x00000001837FA590
	// [XID] // 0x00000001897CD660-0x00000001897CD680
	private void OnDialogSelectFinishNotify() {} // 0x00000001837FDD10-0x00000001837FDEB0
	// [XID] // 0x00000001897D4C20-0x00000001897D4C40
	public void OnDialogFinishNotify() {} // 0x00000001837FDEB0-0x00000001837FDFE0
	// [XID] // 0x00000001897DC340-0x00000001897DC360
	private void OnDialogSelectItemTimeOut() {} // 0x00000001837FBDB0-0x00000001837FC0B0
	// [XID] // 0x00000001897E3C90-0x00000001897E3CB0
	private void OnDialogSelectItem(Notify ntf) {} // 0x00000001837FDA10-0x00000001837FDD10
	// [XID] // 0x00000001897EB8C0-0x00000001897EB8E0
	private void OnDialogSelectTalkItem(int index) {} // 0x00000001837FD590-0x00000001837FD890
	// [XID] // 0x00000001897F31A0-0x00000001897F31C0
	private void OnDialogSelectDialogItem(int index) {} // 0x00000001837FE180-0x00000001837FE4A0
	// [XID] // 0x00000001897FAA10-0x00000001897FAA30
	public void TriggerClickTips() {} // 0x00000001837FC0B0-0x00000001837FC160
	// [XID] // 0x0000000189801FE0-0x0000000189802000
	public void HideView(bool hide) {} // 0x00000001837FD3D0-0x00000001837FD500
	// [XID] // 0x0000000189809450-0x0000000189809470
	private void ShowCountDownProgress(float time) {} // 0x00000001837FF460-0x00000001837FF6A0
	// [XID] // 0x0000000189810C60-0x0000000189810C80
	private void StopCoutDownProgress() {} // 0x00000001837FC160-0x00000001837FC280
	// [XID] // 0x0000000189818710-0x0000000189818730
	private void SetupAutoTalkBtn() {} // 0x00000001837FCB70-0x00000001837FCD50
	// [XID] // 0x000000018981FFE0-0x0000000189820000
	private void RefreshAutoTalkBtn() {} // 0x00000001837FE4A0-0x00000001837FE610
	// [XID] // 0x00000001898275E0-0x0000000189827600
	private void SetAutoTalkBtnInteractive(bool interactive) {} // 0x00000001837FA5F0-0x00000001837FA7D0
	// [XID] // 0x000000018982E820-0x000000018982E840
	private void OnAutoTalkBtnClick() {} // 0x0000000183801290-0x0000000183801400
}

