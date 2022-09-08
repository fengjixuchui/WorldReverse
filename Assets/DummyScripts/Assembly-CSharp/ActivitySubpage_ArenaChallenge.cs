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

public sealed class ActivitySubpage_ArenaChallenge : BaseSubPageContext // TypeDefIndex: 30267
{
	// Fields
	private ActivityInfo _activityInfo; // 0x178
	private MonoActivityArenaChallenge _pageMono; // 0x180
	private bool _guideQuestFinished; // 0x188
	private uint _activityID; // 0x18C
	private bool _isGuest; // 0x190
	private List<IdCountStrConfig> rewardList; // 0x198

	// Constructors
	public ActivitySubpage_ArenaChallenge() {} // Dummy constructor
	public ActivitySubpage_ArenaChallenge(uint activityID, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000182D3F1D0-0x0000000182D3F3B0

	// Methods
	// [XID] // 0x0000000189BCD000-0x0000000189BCD020
	public override void SetupView() {} // 0x0000000182D3EF50-0x0000000182D3F1D0
	// [XID] // 0x0000000189BD45A0-0x0000000189BD45C0
	protected override void OnEnable() {} // 0x0000000182D3EBE0-0x0000000182D3ECD0
	// [XID] // 0x0000000189BDC0D0-0x0000000189BDC0F0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182D3ECD0-0x0000000182D3EF50
	// [XID] // 0x00000001895E88B0-0x00000001895E88D0
	public override void ClearView() {} // 0x0000000182D3D160-0x0000000182D3D200
	// [XID] // 0x00000001895F0140-0x00000001895F0160
	private void Refresh() {} // 0x0000000182D3CA40-0x0000000182D3CB00
	// [XID] // 0x00000001895F7C30-0x00000001895F7C50
	private void RefreshTitleAndTime() {} // 0x0000000182D3E4D0-0x0000000182D3E6E0
	// [XID] // 0x00000001895FEF70-0x00000001895FEF90
	private void RefreshReward() {} // 0x0000000182D3E6E0-0x0000000182D3E8C0
	// [XID] // 0x00000001896067F0-0x0000000189606810
	private void InitRewardItem(Transform trans, int index) {} // 0x0000000182D3D660-0x0000000182D3D900
	// [XID] // 0x000000018960E190-0x000000018960E1B0
	protected override void BindViewCallbacks() {} // 0x0000000182D3CE70-0x0000000182D3D160
	// [XID] // 0x0000000189615800-0x0000000189615820
	protected override void BindRedPoints() {} // 0x0000000182D3CBE0-0x0000000182D3CE70
	// [XID] // 0x000000018961CFE0-0x000000018961D000
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000182D3E150-0x0000000182D3E4D0
	// [XID] // 0x0000000189624530-0x0000000189624550
	private void OnBtnGotoClick() {} // 0x0000000182D3D900-0x0000000182D3DC60
	// [XID] // 0x000000018962BC30-0x000000018962BC50
	private void OnBtnRewardClick() {} // 0x0000000182D3D480-0x0000000182D3D5D0
	// [XID] // 0x0000000189633750-0x0000000189633770
	private void OnBtnGotoQuestClick() {} // 0x0000000182D3E920-0x0000000182D3EB50
	// [XID] // 0x000000018963B010-0x000000018963B030
	private void OnDescButtonClick() {} // 0x0000000182D3E040-0x0000000182D3E150
	// [XID] // 0x0000000189642700-0x0000000189642720
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182D3DCC0-0x0000000182D3DFE0
	// [XID] // 0x0000000189649E10-0x0000000189649E30
	private void RefreshBtn() {} // 0x0000000182D3D260-0x0000000182D3D480
}

