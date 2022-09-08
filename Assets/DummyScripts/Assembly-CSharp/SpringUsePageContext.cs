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

public sealed class SpringUsePageContext : BasePageContext // TypeDefIndex: 29307
{
	// Fields
	private MonoSpringUsePage _pageMono; // 0x190
	private List<ulong> _teamList; // 0x198
	private List<ulong> _preparingList; // 0x1A0
	private uint _autoUsePercent; // 0x1A8
	private const uint AUTO_USE_PERCENT_MIN = 10; // Metadata: 0x00B0F5AA
	private const uint AUTO_USE_PERCENT_MAX = 100; // Metadata: 0x00B0F5AE
	private const uint AUTO_USE_PERCENT_STEP = 10; // Metadata: 0x00B0F5B2
	private bool _springAvailable; // 0x1AC
	private float _longPressThreshold; // 0x1B0
	private float _longPressInterval; // 0x1B4
	private int _selectedTeamIndex; // 0x1B8
	private int _selectedPrepareIndex; // 0x1BC
	private static MonoAudioEvent2D.Event _avatarSprintUseAudio; // 0x00
	private bool _autoUse; // 0x1C0
	private int _selectedIndex; // 0x1C4

	// Properties
	private int totalAvatarCount { /* [XID] */ /* 0x00000001898D2CF0-0x00000001898D2D10 */ get => default; } // 0x0000000182440BF0-0x0000000182440CE0 

	// Constructors
	public SpringUsePageContext() {} // 0x0000000182444350-0x00000001824444C0
	static SpringUsePageContext() {} // 0x00000001824442D0-0x0000000182444350

	// Methods
	// [XID] // 0x0000000189830100-0x0000000189830120
	public override void SetupView() {} // 0x0000000182443BA0-0x00000001824442D0
	// [XID] // 0x00000001898378C0-0x00000001898378E0
	protected override void BindViewCallbacks() {} // 0x0000000182440CE0-0x0000000182440F20
	// [XID] // 0x000000018983EFB0-0x000000018983EFD0
	private void RefreshTeamAvatar(Transform trans, int index) {} // 0x0000000182441AE0-0x0000000182441E50
	// [XID] // 0x00000001898465F0-0x0000000189846610
	private void RefreshAvatar(MonoAvatarIcon avatarIcon, AvatarDataItem curDataItem) {} // 0x0000000182441910-0x0000000182441AE0
	// [XID] // 0x000000018984DB80-0x000000018984DBA0
	private void OnTeamAvatarClicked(int index) {} // 0x0000000182442ED0-0x00000001824431A0
	// [XID] // 0x0000000189854CA0-0x0000000189854CC0
	private void RefreshPreparingAvatar(Transform trans, int index) {} // 0x0000000182441550-0x0000000182441910
	// [XID] // 0x000000018985C460-0x000000018985C480
	private void OnPreparingAvatarClicked(int index) {} // 0x00000001824411F0-0x0000000182441430
	// [XID] // 0x0000000189863DE0-0x0000000189863E00
	private void OnIncreaseButtonClicked() {} // 0x00000001824431A0-0x0000000182443280
	// [XID] // 0x000000018986B110-0x000000018986B130
	private void OnDecreaseButtonClicked() {} // 0x00000001824429F0-0x0000000182442AD0
	// [XID] // 0x00000001898724C0-0x00000001898724E0
	private void OnAutoUseToggleChanged(bool on) {} // 0x00000001824435D0-0x0000000182443710
	// [XID] // 0x000000018987A150-0x000000018987A170
	private void SetupAutoUseToggleView(bool on) {} // 0x0000000182440940-0x0000000182440A60
	// [XID] // 0x00000001898812D0-0x00000001898812F0
	private void CheckIncDecButton() {} // 0x0000000182442DC0-0x0000000182442ED0
	// [XID] // 0x00000001898888A0-0x00000001898888C0
	public override void ClearView() {} // 0x0000000182441430-0x0000000182441550
	// [XID] // 0x000000018988FC20-0x000000018988FC40
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182443A40-0x0000000182443BA0
	// [XID] // 0x00000001898970C0-0x00000001898970E0
	private void UpdateSpringVolume() {} // 0x0000000182440F20-0x00000001824411F0
	// [XID] // 0x000000018989E600-0x000000018989E620
	private void UpdateAvatarHP(ulong guid) {} // 0x0000000182442340-0x00000001824426B0
	// [XID] // 0x00000001898A6120-0x00000001898A6140
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182442710-0x0000000182442990
	// [XID] // 0x00000001898AD730-0x00000001898AD750
	private void ToLeft() {} // 0x0000000182442280-0x0000000182442340
	// [XID] // 0x00000001898B4C70-0x00000001898B4C90
	private void ToRight() {} // 0x0000000182443280-0x0000000182443340
	// [XID] // 0x00000001898BC7A0-0x00000001898BC7C0
	private void ToUp() {} // 0x00000001824438F0-0x00000001824439B0
	// [XID] // 0x00000001898C3E00-0x00000001898C3E20
	private void ToDown() {} // 0x00000001824437D0-0x0000000182443890
	// [XID] // 0x00000001898CB600-0x00000001898CB620
	private bool ChangeSelect(int index) => default; // 0x0000000182442AD0-0x0000000182442CF0
	// [XID] // 0x00000001898DA6A0-0x00000001898DA6C0
	private MonoAvatarIcon GetAvatarIconByIndex(int index) => default; // 0x0000000182441EE0-0x0000000182442100
	// [XID] // 0x00000001898E22D0-0x00000001898E22F0
	private void FocusScrollerByIndex(int index) {} // 0x0000000182442100-0x0000000182442280
	// [XID] // 0x00000001898E9ED0-0x00000001898E9EF0
	private int LeftIndex(int index) => default; // 0x0000000182443520-0x00000001824435D0
	// [XID] // 0x00000001898F1660-0x00000001898F1680
	private int RightIndex(int index) => default; // 0x0000000182443710-0x00000001824437D0
	// [XID] // 0x00000001898F8E40-0x00000001898F8E60
	private int DownIndex(int index) => default; // 0x0000000182443340-0x0000000182443520
	// [XID] // 0x00000001899007E0-0x0000000189900800
	private int UpIndex(int index) => default; // 0x0000000182440A60-0x0000000182440BF0
	// [XID] // 0x0000000189907F50-0x0000000189907F70
	private void UseSpring() {} // 0x0000000182442CF0-0x0000000182442DC0
}

