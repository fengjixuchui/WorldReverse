/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TeamPageContext : BaseTeamPageContext // TypeDefIndex: 29934
{
	// Fields
	private const int MAX_TEAM_COUNT = 4; // Metadata: 0x00B102DA
	private bool _chooseTeamResponsed; // 0x2A8
	private bool _chooseTeamSuccess; // 0x2A9

	// Constructors
	public TeamPageContext() {} // Dummy constructor
	public TeamPageContext(TeamPageStyle style = TeamPageStyle.Default /* Metadata: 0x00B102D2 */) {} // 0x0000000183125300-0x00000001831253A0
	public TeamPageContext(bool showExit, uint showTutorialId = 0 /* Metadata: 0x00B102D6 */, Action callback = null) {} // 0x0000000183125250-0x0000000183125300

	// Methods
	// [XID] // 0x0000000189B26650-0x0000000189B26670
	protected override void BindViewCallbacks() {} // 0x0000000183123730-0x0000000183123BB0
	// [XID] // 0x0000000189B2D8E0-0x0000000189B2D900
	protected override void SetupDefaultTitle() {} // 0x0000000183124CA0-0x0000000183124EC0
	// [XID] // 0x0000000189B34D00-0x0000000189B34D20
	protected override void OnSetupView() {} // 0x0000000183124380-0x0000000183124740
	// [XID] // 0x0000000189B3C5B0-0x0000000189B3C5D0
	private void OnShowNextTeam() {} // 0x0000000183124FE0-0x00000001831250A0
	// [XID] // 0x0000000189B44210-0x0000000189B44230
	private void OnShowPreTeam() {} // 0x00000001831242C0-0x0000000183124380
	// [XID] // 0x0000000189B4B900-0x0000000189B4B920
	private void OnRefreshTeamPage() {} // 0x0000000183124BD0-0x0000000183124CA0
	// [XID] // 0x0000000189B52F30-0x0000000189B52F50
	protected override void RefreshTryChangeTeamBtn() {} // 0x0000000183123BB0-0x0000000183123F10
	// [XID] // 0x0000000189B5A8E0-0x0000000189B5A900
	protected override void OnRefreshTeamShown() {} // 0x0000000183124EC0-0x0000000183124F80
	// [XID] // 0x0000000189B61D90-0x0000000189B61DB0
	protected override bool TeamContainElementType(ElementType elementType) => default; // 0x0000000183123510-0x0000000183123730
	// [XID] // 0x0000000189B699E0-0x0000000189B69A00
	private new void OnStartDungeonButtonClicked() {} // 0x0000000183124140-0x0000000183124240
	[DebuggerHidden] // 0x0000000189B70FC0-0x0000000189B71000
	// [XID] // 0x0000000189B70FC0-0x0000000189B71000
	private IEnumerator StartDungeon() => default; // 0x0000000183123320-0x0000000183123430
	// [XID] // 0x0000000189B7B320-0x0000000189B7B340
	protected override void RegisterHandlePacket() {} // 0x00000001831251A0-0x0000000183125250
	// [XID] // 0x0000000189B82C40-0x0000000189B82C60
	public override bool OnPacket(Packet packet) => default; // 0x00000001831250A0-0x00000001831251A0
	// [XID] // 0x0000000189B8A240-0x0000000189B8A260
	private void OnChooseCurAvatarTeamRsp(ChooseCurAvatarTeamRsp rsp) {} // 0x0000000183124060-0x0000000183124140
	// [XID] // 0x0000000189B918A0-0x0000000189B918C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183124740-0x0000000183124B70
}

