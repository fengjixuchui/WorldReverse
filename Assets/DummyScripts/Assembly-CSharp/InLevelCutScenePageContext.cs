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

public sealed class InLevelCutScenePageContext : BasePageContext // TypeDefIndex: 29789
{
	// Fields
	private MonoInLevelCutScenePage _pageMono; // 0x190
	private TalkDialogContext _talkDialog; // 0x198
	private Image _backImg; // 0x1A0
	private GameObject _loadingAnim; // 0x1A8
	private Animator _textAnimator; // 0x1B0
	private bool _needFreeClick; // 0x1B8
	private bool _isChangingColor; // 0x1B9
	private Coroutine _wait2ShowLoadingDialog; // 0x1C0
	private bool _talking; // 0x1C8
	private uint _inteeID; // 0x1CC
	private bool _skipBtnShow; // 0x1D0
	private Coroutine _hideCoroutine; // 0x1D8
	private float _durationToHide; // 0x1E0
	private Vector2 _lastMousePos; // 0x1E4
	private float _lastMouseMoveTime; // 0x1EC
	private bool _firstUpdate; // 0x1F0
	private bool _needHideMouse; // 0x1F1
	private BaseInterAction _uiAction; // 0x1F8

	// Properties
	public bool isTalking { /* [XID] */ /* 0x000000018995D2E0-0x000000018995D300 */ get => default; } // 0x00000001837C4780-0x00000001837C4830 
	public uint inteeID { /* [XID] */ /* 0x0000000189964990-0x00000001899649B0 */ set {} } // 0x00000001837C4830-0x00000001837C48E0

	// Constructors
	public InLevelCutScenePageContext() {} // 0x00000001837C7A40-0x00000001837C7C40

	// Methods
	// [XID] // 0x000000018996C070-0x000000018996C090
	public void ClearTalk() {} // 0x00000001837C6230-0x00000001837C6310
	// [XID] // 0x0000000189973B00-0x0000000189973B20
	public void HideTalk() {} // 0x00000001837C48E0-0x00000001837C49B0
	// [XID] // 0x000000018997B150-0x000000018997B170
	public void FreeChangingColor() {} // 0x00000001837C6B80-0x00000001837C6C20
	// [XID] // 0x0000000189982C60-0x0000000189982C80
	public void UpdateColorManual(Color color, bool isChanging = false /* Metadata: 0x00B0FF1C */) {} // 0x00000001837C56B0-0x00000001837C5800
	// [XID] // 0x000000018998A450-0x000000018998A470
	public void UpdateNeedFreeClick(bool needFreeClick) {} // 0x00000001837C51E0-0x00000001837C5290
	// [XID] // 0x0000000189991D40-0x0000000189991D60
	public override void SetupView() {} // 0x00000001837C7340-0x00000001837C7720
	// [XID] // 0x0000000189999A70-0x0000000189999A90
	public override void UpdateView() {} // 0x00000001837C7720-0x00000001837C7A40
	// [XID] // 0x00000001899A1100-0x00000001899A1120
	protected override void BindViewCallbacks() {} // 0x00000001837C4A20-0x00000001837C4B80
	// [XID] // 0x00000001899A8C30-0x00000001899A8C50
	private void ShowLoadingDialog() {} // 0x00000001837C6660-0x00000001837C6760
	// [XID] // 0x00000001899B0550-0x00000001899B0570
	public override bool OnNotify(Notify ntf) => default; // 0x00000001837C7180-0x00000001837C7340
	// [XID] // 0x00000001899B7880-0x00000001899B78A0
	private void OnAvatarDead(uint runtimeID) {} // 0x00000001837C59F0-0x00000001837C5B70
	// [XID] // 0x00000001899BF220-0x00000001899BF240
	protected override void OnEnable() {} // 0x00000001837C7030-0x00000001837C7180
	// [XID] // 0x00000001899C6C20-0x00000001899C6C40
	public override void ClearView() {} // 0x00000001837C5080-0x00000001837C51E0
	// [XID] // 0x00000001899CE160-0x00000001899CE180
	public void ShowTalk(DialogAction dialogAction, uint mainQuestId) {} // 0x00000001837C4F90-0x00000001837C5080
	// [XID] // 0x00000001899D5940-0x00000001899D5960
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001837C5D40-0x00000001837C5F30
	// [XID] // 0x00000001899DCC50-0x00000001899DCC70
	private void OnCountDownFinish() {} // 0x00000001837C52F0-0x00000001837C5410
	// [XID] // 0x00000001899E4890-0x00000001899E48B0
	private void OnFreeClick() {} // 0x00000001837C4C50-0x00000001837C4EC0
	// [XID] // 0x00000001899EBC80-0x00000001899EBCA0
	private void ShowSkipBtn(bool showBtn) {} // 0x00000001837C69A0-0x00000001837C6B80
	// [XID] // 0x00000001899F3750-0x00000001899F3770
	private void RealShowSkipBtn(bool showBtn) {} // 0x00000001837C5800-0x00000001837C59F0
	// [XID] // 0x00000001899FB070-0x00000001899FB090
	private void OnSkipBtnClick() {} // 0x00000001837C6310-0x00000001837C6660
	// [XID] // 0x0000000189A022C0-0x0000000189A022E0
	private void OnDrag(Vector2 delta) {} // 0x00000001837C6F00-0x00000001837C7030
	// [XID] // 0x0000000189A09AB0-0x0000000189A09AD0
	private void OnEndDrag() {} // 0x00000001837C6D50-0x00000001837C6E70
	// [XID] // 0x0000000189A11250-0x0000000189A11270
	private bool TriggerUI(BaseInterAction interAction) => default; // 0x00000001837C6760-0x00000001837C6940
	// [XID] // 0x0000000189A18620-0x0000000189A18640
	public void EnableLoadingAnim(bool value) {} // 0x00000001837C6C20-0x00000001837C6D50
	// [XID] // 0x0000000189A1FCE0-0x0000000189A1FD00
	public void SetText(string textMapID) {} // 0x00000001837C5410-0x00000001837C5620
	// [XID] // 0x0000000189A27070-0x0000000189A27090
	public void EnableTextAnimator(bool enable) {} // 0x00000001837C5B70-0x00000001837C5CE0
	// [XID] // 0x0000000189A2E890-0x0000000189A2E8B0
	private void ActiveTalkDialog() {} // 0x00000001837C5FF0-0x00000001837C6160
	// [XID] // 0x0000000189A361C0-0x0000000189A361E0
	private void ShowCoopSelectItem(List<SelectItemParam> selectParamList) {} // 0x00000001837C4EC0-0x00000001837C4F90
	// [XID] // 0x0000000189788880-0x00000001897888A0
	public void UpdateNeedHideMouse(bool needHideMouse) {} // 0x00000001837C6160-0x00000001837C6230
}

