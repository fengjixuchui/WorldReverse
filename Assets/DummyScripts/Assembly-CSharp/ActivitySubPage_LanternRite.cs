/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivitySubPage_LanternRite : BaseSubPageContext // TypeDefIndex: 29403
{
	// Fields
	private MonoActivitySubPageLanternRite _pageMono; // 0x178
	private MonoJoypadItemNavigator _joypadItemNavigator; // 0x180
	private uint _activityID; // 0x188
	private ActivityInfo _activityInfo; // 0x190
	private uint _maxPopularity; // 0x198
	private Color lockedColor; // 0x19C
	private bool _isLampOpen; // 0x1AC
	private int _startEntryIndex; // 0x1B0
	private int _endEntryIndex; // 0x1B4
	private const uint LAMP_ID = 200004; // Metadata: 0x00B0F77A
	private const uint COMBINE_ID = 200004; // Metadata: 0x00B0F77E
	private const uint LAMP_QUEST_ID = 4131111; // Metadata: 0x00B0F782
	private uint mechanicusOpenQuestID; // 0x1B8

	// Constructors
	public ActivitySubPage_LanternRite() {} // Dummy constructor
	public ActivitySubPage_LanternRite(uint activityId, BasePageContext _parent, Transform _mountTrans) {} // 0x0000000183301920-0x0000000183301AE0

	// Methods
	// [XID] // 0x000000018964B8B0-0x000000018964B8D0
	public override void SetupView() {} // 0x0000000183301660-0x0000000183301920
	// [XID] // 0x0000000189653040-0x0000000189653060
	protected override void BindRedPoints() {} // 0x00000001832FD850-0x00000001832FDB80
	// [XID] // 0x000000018965A700-0x000000018965A720
	protected override void BindViewCallbacks() {} // 0x00000001832FDB80-0x00000001832FDF80
	// [XID] // 0x0000000189661D30-0x0000000189661D50
	public override bool OnNotify(Notify ntf) => default; // 0x00000001833014B0-0x0000000183301660
	// [XID] // 0x0000000189669910-0x0000000189669930
	private void Refresh() {} // 0x00000001832FD180-0x00000001832FD660
	// [XID] // 0x0000000189671440-0x0000000189671460
	private bool CheckContentClosed(MonoCommonListRow item) => default; // 0x00000001833005A0-0x0000000183300770
	// [XID] // 0x0000000189678D00-0x0000000189678D20
	private void CheckMainQuest() {} // 0x0000000183300920-0x0000000183300AA0
	// [XID] // 0x0000000189680410-0x0000000189680430
	private void CheckMiniQuest() {} // 0x00000001832FF280-0x00000001832FF3B0
	// [XID] // 0x0000000189687F10-0x0000000189687F30
	private void CheckChess() {} // 0x0000000183300E00-0x0000000183301030
	// [XID] // 0x000000018968F970-0x000000018968F990
	private void CheckShop() {} // 0x00000001832FF3B0-0x00000001832FF590
	// [XID] // 0x0000000189697370-0x0000000189697390
	private void CheckLamp() {} // 0x00000001832FED80-0x00000001832FF280
	// [XID] // 0x000000018969E8C0-0x000000018969E8E0
	private void CheckContract() {} // 0x00000001832FF590-0x00000001832FF930
	// [XID] // 0x00000001896A58B0-0x00000001896A58D0
	private void OnClickDesc() {} // 0x00000001832FD6E0-0x00000001832FD7F0
	// [XID] // 0x00000001896AD130-0x00000001896AD150
	private void OnMainQuest() {} // 0x00000001832FE1A0-0x00000001832FE530
	// [XID] // 0x00000001896B4760-0x00000001896B4780
	private void OnMiniQuest() {} // 0x0000000183300210-0x00000001833005A0
	// [XID] // 0x00000001896BB9D0-0x00000001896BB9F0
	private void OnChess() {} // 0x00000001832FE530-0x00000001832FEC70
	// [XID] // 0x00000001896C2E90-0x00000001896C2EB0
	private void OnShop() {} // 0x0000000183300AA0-0x0000000183300E00
	// [XID] // 0x00000001896CA320-0x00000001896CA340
	private void UpdateActivityRPShow() {} // 0x0000000183300770-0x0000000183300920
	// [XID] // 0x00000001896D19D0-0x00000001896D19F0
	private void OnContract() {} // 0x00000001832FF990-0x00000001832FFC60
	// [XID] // 0x00000001896D91E0-0x00000001896D9200
	private void OnMakeLamp() {} // 0x00000001832FDF80-0x00000001832FE140
	// [XID] // 0x00000001896E09B0-0x00000001896E09D0
	protected override void OnEnable() {} // 0x0000000183301120-0x0000000183301310
	// [XID] // 0x00000001896E7C60-0x00000001896E7C80
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001832FFC60-0x00000001832FFEC0
	// [XID] // 0x00000001896EF350-0x00000001896EF370
	public override void OnJoypadUIModuleFocus(MonoJoypadUIModule focusModule) {} // 0x0000000183301310-0x00000001833014B0
	// [XID] // 0x00000001896F6D20-0x00000001896F6D40
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x00000001832FFEC0-0x0000000183300210
}

