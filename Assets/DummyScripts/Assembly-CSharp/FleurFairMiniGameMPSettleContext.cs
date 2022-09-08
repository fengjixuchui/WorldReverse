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

public sealed class FleurFairMiniGameMPSettleContext : BasePageContext // TypeDefIndex: 29080
{
	// Fields
	private MonoFleurFairMiniGameMPSettlePage _pageMono; // 0x190
	private List<BalloonSettleInfo> _balloonSettleInfoList; // 0x1A0
	private List<FallSettleInfo> _fallSettleInfoList; // 0x1A8
	private uint _curGameId; // 0x1B0

	// Properties
	public EFleurFairMiniGame MiniGame { /* [XID] */ /* 0x0000000189609AB0-0x0000000189609AF0 */ get; private set; } // 0x000000018152E550-0x000000018152E5B0 0x000000018152E400-0x000000018152E470

	// Constructors
	public FleurFairMiniGameMPSettleContext() {} // Dummy constructor
	public FleurFairMiniGameMPSettleContext(FleurFairBalloonSettleNotify notify) {} // 0x000000018152EDB0-0x000000018152F140
	public FleurFairMiniGameMPSettleContext(FleurFairFallSettleNotify notify) {} // 0x000000018152EA20-0x000000018152EDB0

	// Methods
	// [XID] // 0x000000018961B980-0x000000018961B9A0
	private void SetupConfig() {} // 0x000000018152DA50-0x000000018152DB20
	// [XID] // 0x0000000189622FC0-0x0000000189622FE0
	public override void SetupView() {} // 0x000000018152E950-0x000000018152EA20
	// [XID] // 0x000000018962A770-0x000000018962A790
	protected override void BindViewCallbacks() {} // 0x000000018152C790-0x000000018152C920
	// [XID] // 0x0000000189631EB0-0x0000000189631ED0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018152E840-0x000000018152E950
	// [XID] // 0x00000001896399F0-0x0000000189639A10
	private void OnGetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x000000018152E470-0x000000018152E550
	// [XID] // 0x0000000189640E80-0x0000000189640EA0
	private int CompareBallon(BalloonSettleInfo left, BalloonSettleInfo right) => default; // 0x000000018152CDF0-0x000000018152CEE0
	// [XID] // 0x0000000189648790-0x00000001896487B0
	private int CompareFall(FallSettleInfo left, FallSettleInfo right) => default; // 0x000000018152E010-0x000000018152E100
	// [XID] // 0x000000018964FEA0-0x000000018964FEC0
	private void Refresh() {} // 0x000000018152C200-0x000000018152C410
	// [XID] // 0x0000000189657760-0x0000000189657780
	private void RefreshBalloon() {} // 0x000000018152C920-0x000000018152CD60
	// [XID] // 0x000000018965EDC0-0x000000018965EDE0
	private void RefreshBalloonPlayerInfo(Transform trans, int index) {} // 0x000000018152E100-0x000000018152E400
	// [XID] // 0x00000001896664E0-0x0000000189666500
	private void RefreshFall() {} // 0x000000018152DC10-0x000000018152E010
	// [XID] // 0x000000018966DCE0-0x000000018966DD00
	private void RefreshFallPlayerInfo(Transform trans, int index) {} // 0x000000018152C410-0x000000018152C790
	// [XID] // 0x0000000189675B00-0x0000000189675B20
	private void RefreshPlayerInfo(MonoFleurFairMiniGameSettlePlayerListRow ins, uint headPortraitID, uint uid, string onlineID, string nickName) {} // 0x000000018152D120-0x000000018152D520
	// [XID] // 0x000000018967D390-0x000000018967D3B0
	private void OnIconBtnClick(uint uid) {} // 0x000000018152DB20-0x000000018152DC10
	// [XID] // 0x0000000189684A60-0x0000000189684A80
	private void OnItemJoyStickState(RectTransform item, bool select) {} // 0x000000018152D580-0x000000018152D6B0
	// [XID] // 0x000000018968C630-0x000000018968C650
	private void OnClickAgain() {} // 0x000000018152CEE0-0x000000018152D120
	// [XID] // 0x0000000189694080-0x00000001896940A0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018152D6B0-0x000000018152DA50
	// [XID] // 0x000000018969B5F0-0x000000018969B610
	private void CheckJoyPad() {} // 0x000000018152E5B0-0x000000018152E750
}

