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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairMusicGameMainPage : BasePageContext // TypeDefIndex: 29088
{
	// Fields
	private InLevelCountDown _countDown; // 0x190
	private bool _start; // 0x198
	private bool _paused; // 0x199
	private MonoFleurFairMusicGameMainPage _pageMono; // 0x1A0
	private float _playTime; // 0x1A8
	private ConfigMusicGameKey[] musicKeyList; // 0x1B0
	public static uint comboCount; // 0x00
	private List<MonoMusicGameButton> _musicBtnList; // 0x1B8
	private MusicGameBasicConfig _musicConfig; // 0x1C0
	private ConfigMusicGame _configMusicGame; // 0x1C8
	private uint _curScore; // 0x1D0
	private uint _musicID; // 0x1D4
	private uint _musicLevel; // 0x1D8
	private uint _musicTime; // 0x1DC
	private uint _correctHit; // 0x1E0
	private uint _maxCombo; // 0x1E4
	private ComboConfig[] _comboConfig; // 0x1E8
	private int padIndex; // 0x1F0
	private float _lastRealtime; // 0x1F4

	// Properties
	public bool pause { /* [XID] */ /* 0x0000000189854D00-0x0000000189854D20 */ get => default; } // 0x00000001845036B0-0x0000000184503760 
	public float playTime { /* [XID] */ /* 0x000000018985C4C0-0x000000018985C4E0 */ get => default; } // 0x0000000184504910-0x00000001845049C0 
	public MusicGameBasicConfig musicConfig { /* [XID] */ /* 0x0000000189863E20-0x0000000189863E40 */ get => default; } // 0x00000001845032E0-0x0000000184503390 
	public ConfigMusicGame musicGameConfig { /* [XID] */ /* 0x000000018986B170-0x000000018986B190 */ get => default; } // 0x0000000184503760-0x0000000184503810 
	private string MusicJsonConfigPath { /* [XID] */ /* 0x0000000189872520-0x0000000189872540 */ get => default; } // 0x0000000184502BE0-0x0000000184502C90 

	// Constructors
	public FleurFairMusicGameMainPage() {} // Dummy constructor
	public FleurFairMusicGameMainPage(uint musicID, uint level) {} // 0x0000000184506820-0x0000000184506A10
	static FleurFairMusicGameMainPage() {} // 0x00000001845067C0-0x0000000184506820

	// Methods
	// [XID] // 0x000000018987A190-0x000000018987A1B0
	private void LoadJsonConfig() {} // 0x0000000184502980-0x0000000184502BE0
	// [XID] // 0x0000000189881330-0x0000000189881350
	public override void SetupView() {} // 0x0000000184505DD0-0x00000001845062C0
	// [XID] // 0x0000000189888900-0x0000000189888920
	protected override void BindViewCallbacks() {} // 0x0000000184502C90-0x0000000184502FF0
	// [XID] // 0x000000018988FC40-0x000000018988FC60
	private void ShowPausePanel(bool show) {} // 0x0000000184505B50-0x0000000184505DD0
	// [XID] // 0x0000000189897100-0x0000000189897120
	private void DisablePauseButton(bool disable) {} // 0x0000000184504C50-0x0000000184504E20
	// [XID] // 0x000000018989E640-0x000000018989E660
	private void UpdateMusicTimeProgress() {} // 0x0000000184503F00-0x0000000184503FE0
	// [XID] // 0x00000001898A6160-0x00000001898A6180
	private void OnClickBtnPause() {} // 0x00000001845046D0-0x00000001845047A0
	// [XID] // 0x00000001898AD790-0x00000001898AD7B0
	private void OnClickBtnResume() {} // 0x0000000184503100-0x0000000184503250
	// [XID] // 0x00000001898B4CD0-0x00000001898B4CF0
	private void OnClickBtnExit() {} // 0x0000000184503440-0x0000000184503570
	// [XID] // 0x00000001898BC7E0-0x00000001898BC800
	private void OnClickBtnReStart() {} // 0x0000000184505130-0x0000000184505430
	// [XID] // 0x00000001898C3E60-0x00000001898C3E80
	private void RefreshComboAndScore() {} // 0x0000000184503810-0x0000000184503F00
	// [XID] // 0x00000001898CB640-0x00000001898CB660
	public void Success(int index) {} // 0x0000000184505430-0x0000000184505560
	// [XID] // 0x00000001898D2D50-0x00000001898D2D70
	public void Fail(int index) {} // 0x00000001845049C0-0x0000000184504AB0
	// [XID] // 0x00000001898DA6E0-0x00000001898DA700
	public override void UpdateView() {} // 0x00000001845062C0-0x00000001845067C0
	// [XID] // 0x00000001898E2310-0x00000001898E2330
	private void SendResultToServer() {} // 0x0000000184504040-0x0000000184504170
	// [XID] // 0x00000001898E9EF0-0x00000001898E9F10
	private void ReSet() {} // 0x00000001845043F0-0x0000000184504500
	// [XID] // 0x00000001898F16A0-0x00000001898F16C0
	public void OnReStart() {} // 0x0000000184503570-0x00000001845036B0
	// [XID] // 0x00000001898F8E80-0x00000001898F8EA0
	public void OnStart() {} // 0x0000000184504560-0x00000001845046D0
	// [XID] // 0x0000000189900800-0x0000000189900820
	public void OnPause() {} // 0x00000001845047A0-0x0000000184504910
	// [XID] // 0x0000000189907F90-0x0000000189907FB0
	public void OnResume() {} // 0x00000001845058C0-0x0000000184505A50
	// [XID] // 0x000000018990F780-0x000000018990F7A0
	public void OnStop() {} // 0x0000000184505780-0x00000001845058C0
	// [XID] // 0x0000000189917170-0x0000000189917190
	public override void ClearView() {} // 0x0000000184502FF0-0x0000000184503100
	// [XID] // 0x000000018991E890-0x000000018991E8B0
	private void CloseMusicPage() {} // 0x0000000184504E20-0x0000000184504F60
	// [XID] // 0x0000000189926110-0x0000000189926130
	public override bool OnNotify(Notify ntf) => default; // 0x00000001845055F0-0x0000000184505780
	// [XID] // 0x000000018992D820-0x000000018992D840
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000184504170-0x0000000184504390
	// [XID] // 0x0000000189934CB0-0x0000000189934CD0
	private void ClickMusicBtn(MusicKeyType key) {} // 0x0000000184505A50-0x0000000184505B50
	// [XID] // 0x000000018993C780-0x000000018993C7A0
	private void Return() {} // 0x0000000184503390-0x0000000184503440
	// [XID] // 0x0000000189943DB0-0x0000000189943DD0
	private void MusicPosStart() {} // 0x0000000184504AB0-0x0000000184504C50
	// [XID] // 0x000000018994B2D0-0x000000018994B2F0
	private void MusicPosEnd() {} // 0x0000000184504F60-0x00000001845050D0
}

