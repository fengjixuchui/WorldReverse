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

public sealed class MPTeamPageContext : BaseTeamPageContext // TypeDefIndex: 29779
{
	// Fields
	private List<MPTeamAvatarData> _teamData; // 0x2A8
	private List<uint> _squadUids; // 0x2B0
	private ChatPageContext chatPageContext; // 0x2B8
	private int _othersAvatarBtnDownIndex; // 0x2C0
	private List<ulong> _allAvatars; // 0x2C8

	// Constructors
	public MPTeamPageContext() {} // 0x0000000182ABC310-0x0000000182ABC410

	// Methods
	// [XID] // 0x0000000189B37F70-0x0000000189B37F90
	protected override void OnSetupView() {} // 0x0000000182AB7BC0-0x0000000182AB8200
	// [XID] // 0x0000000189B3F9A0-0x0000000189B3F9C0
	private bool CanRevive() => default; // 0x0000000182AB94F0-0x0000000182AB95E0
	// [XID] // 0x0000000189B471C0-0x0000000189B471E0
	public override void ClearView() {} // 0x0000000182AB5820-0x0000000182AB5960
	// [XID] // 0x0000000189B4E980-0x0000000189B4E9A0
	protected override void BindViewCallbacks() {} // 0x0000000182AB4B30-0x0000000182AB4E60
	// [XID] // 0x0000000189B561C0-0x0000000189B561E0
	private void OnChat() {} // 0x0000000182AB4240-0x0000000182AB4440
	// [XID] // 0x0000000189B5DA40-0x0000000189B5DA60
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182ABB9C0-0x0000000182ABBE40
	// [XID] // 0x0000000189B64FA0-0x0000000189B64FC0
	protected override void SetupDefaultTitle() {} // 0x0000000182AB9080-0x0000000182AB9270
	// [XID] // 0x0000000189B6C580-0x0000000189B6C5A0
	protected override void ShowAvatarInTeamView() {} // 0x0000000182AB5080-0x0000000182AB52D0
	// [XID] // 0x0000000189B73CF0-0x0000000189B73D10
	private void SetAvatarBtnMP(MonoTeamAvatarBtn ins, MPTeamAvatarData avatarData, int index) {} // 0x0000000182ABA2F0-0x0000000182ABA910
	// [XID] // 0x0000000189B7B360-0x0000000189B7B380
	private void OnOthersAvatarBtnDown(int index) {} // 0x0000000182AB71C0-0x0000000182AB7270
	// [XID] // 0x0000000189B82C80-0x0000000189B82CA0
	private void OnOthersAvatarBtnUp(int index) {} // 0x0000000182ABBE40-0x0000000182ABBFF0
	// [XID] // 0x0000000189B8A280-0x0000000189B8A2A0
	private void ToggleActionBtns(MonoTeamAvatarBtn ins) {} // 0x0000000182AB9900-0x0000000182AB9AD0
	// [XID] // 0x0000000189B918E0-0x0000000189B91900
	private void RefreshAvatarActionBtn(Transform trans, int index) {} // 0x0000000182AB7020-0x0000000182AB71C0
	// [XID] // 0x0000000189B98CA0-0x0000000189B98CC0
	protected override void BindTeamAvatarBtnCallbacks() {} // 0x0000000182ABC050-0x0000000182ABC310
	// [XID] // 0x0000000189BA00C0-0x0000000189BA00E0
	private bool HideAllAvatarActionList() => default; // 0x0000000182AB4E60-0x0000000182AB5080
	// [XID] // 0x0000000189BA7900-0x0000000189BA7920
	protected override void OnTeamAvatarBtnSelect(int index) {} // 0x0000000182AB5AA0-0x0000000182AB60E0
	// [XID] // 0x0000000189BAEC30-0x0000000189BAEC50
	protected override void ShowCurrentTeam() {} // 0x0000000182AB7890-0x0000000182AB7B40
	// [XID] // 0x0000000189BB6320-0x0000000189BB6340
	protected override void OnChange() {} // 0x0000000182AB6820-0x0000000182AB6D90
	// [XID] // 0x0000000189BBD920-0x0000000189BBD940
	private bool OnAdd(ulong nextGUID) => default; // 0x0000000182AB49D0-0x0000000182AB4AD0
	// [XID] // 0x0000000189BC5680-0x0000000189BC56A0
	private bool OnDel(ref ulong nextGUID) => default; // 0x0000000182ABA160-0x0000000182ABA2F0
	// [XID] // 0x0000000189BCD080-0x0000000189BCD0A0
	private bool OnChanging(ref ulong nextGUID) => default; // 0x0000000182AB9270-0x0000000182AB94F0
	// [XID] // 0x0000000189BD4600-0x0000000189BD4620
	private ulong FirstAliveAvatar(List<ulong> team, ulong excluded = 0 /* Metadata: 0x00B0FED2 */, ulong addition = 0 /* Metadata: 0x00B0FEDA */) => default; // 0x0000000182AB5570-0x0000000182AB5820
	// [XID] // 0x0000000189BDC170-0x0000000189BDC190
	protected override void DoChangeTeamMember() {} // 0x0000000182ABB370-0x0000000182ABB530
	// [XID] // 0x00000001895E89B0-0x00000001895E89D0
	protected override void OnAvatarPickUp() {} // 0x0000000182ABAAF0-0x0000000182ABACD0
	// [XID] // 0x00000001895F0200-0x00000001895F0220
	protected override bool ValidIndexForAvatarSwitch(int index) => default; // 0x0000000182AB6D90-0x0000000182AB6ED0
	// [XID] // 0x00000001895F7CD0-0x00000001895F7CF0
	protected override bool ValidIndexToDrag(int index, out ulong avatarGuid) {
		avatarGuid = default;
		return default;
	} // 0x0000000182AB8DD0-0x0000000182AB8F20
	// [XID] // 0x00000001895FF070-0x00000001895FF090
	protected override void ExchangeAvatar(int index) {} // 0x0000000182ABB590-0x0000000182ABB930
	// [XID] // 0x00000001896068D0-0x00000001896068F0
	protected override void OnRefreshTeamShown() {} // 0x0000000182ABACD0-0x0000000182ABAFA0
	// [XID] // 0x000000018960E250-0x000000018960E270
	protected override bool TeamContainElementType(ElementType elementType) => default; // 0x0000000182AB44B0-0x0000000182AB4710
	// [XID] // 0x00000001896158E0-0x0000000189615900
	private void ShowDungeonInviteDialog() {} // 0x0000000182AB8F80-0x0000000182AB9080
	// [XID] // 0x000000018961D0C0-0x000000018961D0E0
	private void DungeonGuestToReady() {} // 0x0000000182AB9AD0-0x0000000182AB9C30
	// [XID] // 0x00000001896245F0-0x0000000189624610
	private void CheckServerAnnounce() {} // 0x0000000182AB7270-0x0000000182AB7890
	// [XID] // 0x000000018962BD30-0x000000018962BD50
	private void RefreshInviteButtonText() {} // 0x0000000182AB89A0-0x0000000182AB8CE0
	// [XID] // 0x0000000189633850-0x0000000189633870
	private void RefreshGuestReadyState() {} // 0x0000000182AB8550-0x0000000182AB86E0
	// [XID] // 0x000000018963B150-0x000000018963B170
	protected override void ExitPage() {} // 0x0000000182AB8200-0x0000000182AB84F0
	// [XID] // 0x0000000189642880-0x00000001896428A0
	private void ExitPageNoLeave() {} // 0x0000000182AB4930-0x0000000182AB49D0
	// [XID] // 0x0000000189649F70-0x0000000189649F90
	private new void RefreshRecommendElementList() {} // 0x0000000182AB9E50-0x0000000182ABA060
	// [XID] // 0x0000000189651650-0x0000000189651670
	private void RefreshElement(Transform trans, int index) {} // 0x0000000182AB4710-0x0000000182AB4930
	// [XID] // 0x0000000189658ED0-0x0000000189658EF0
	protected override bool TeamContainUpAvatar(uint avatarId) => default; // 0x0000000182AB52D0-0x0000000182AB5570
	// [XID] // 0x00000001896605A0-0x00000001896605C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182AB8840-0x0000000182AB89A0
	// [XID] // 0x0000000189667EE0-0x0000000189667F00
	protected override void ResetIndex() {} // 0x0000000182AB4190-0x0000000182AB4240
	// [XID] // 0x000000018966F950-0x000000018966F970
	private void RefreshActionBtnState() {} // 0x0000000182ABB000-0x0000000182ABB370
	// [XID] // 0x00000001896772C0-0x00000001896772E0
	private bool HandleNormalInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182AB60E0-0x0000000182AB6820
	// [XID] // 0x000000018967E830-0x000000018967E850
	private bool HandleAvatarSelectInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182AB9D10-0x0000000182AB9E50
	// [XID] // 0x00000001896860E0-0x0000000189686100
	protected override void OnResonanceBtnClick() {} // 0x0000000182AB95E0-0x0000000182AB9830
		P1 = default;
		return default;
	} // 0x0000000182AB8D40-0x0000000182AB8DD0
}

