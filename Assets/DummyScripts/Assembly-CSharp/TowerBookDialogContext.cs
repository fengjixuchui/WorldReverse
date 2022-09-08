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

public sealed class TowerBookDialogContext : BaseDialogContext // TypeDefIndex: 28980
{
	// Fields
	private const int MAX_AVATAR_NUM = 4; // Metadata: 0x00B0E8E6
	private const int MAX_RECORD_NUM = 5; // Metadata: 0x00B0E8EA
	private MonoTowerBookDialog _dialogMono; // 0x178
	private int _curTowerScheduleIndex; // 0x180
	private List<string> _recordName; // 0x188
	private List<TowerFightRecordPair> _record; // 0x190
	private Color _rowColorWhite; // 0x198
	private Color _rowColorBlack; // 0x1A8
	private bool _showDetailBtn; // 0x1B8

	// Constructors
	public TowerBookDialogContext() {} // 0x00000001844FB420-0x00000001844FB630

	// Methods
	// [XID] // 0x00000001896FFAE0-0x00000001896FFB00
	public override void SetupView() {} // 0x00000001844FB350-0x00000001844FB420
	// [XID] // 0x0000000189707190-0x00000001897071B0
	protected override void BindViewCallbacks() {} // 0x00000001844F9170-0x00000001844F9280
	// [XID] // 0x000000018970EA50-0x000000018970EA70
	private void RefreshDialogView() {} // 0x00000001844F9280-0x00000001844F94B0
	// [XID] // 0x0000000189715E50-0x0000000189715E70
	public static string GetTowerChallengeDateStr(string openTime) => default; // 0x00000001844F9820-0x00000001844F9A70
	// [XID] // 0x000000018971D8B0-0x000000018971D8D0
	private void RefreshTotalItem(Transform trans, int index) {} // 0x00000001844FAD70-0x00000001844FB350
	// [XID] // 0x0000000189724C50-0x0000000189724C70
	private void RestButtonHighlight() {} // 0x00000001844F9080-0x00000001844F9170
	// [XID] // 0x000000018972C480-0x000000018972C4A0
	private void SetButtonHighlight(int index, bool highlight) {} // 0x00000001844F9670-0x00000001844F9820
	// [XID] // 0x0000000189733BA0-0x0000000189733BC0
	private void RefreshDetailView() {} // 0x00000001844F9ED0-0x00000001844FA8E0
	// [XID] // 0x000000018973B2C0-0x000000018973B2E0
	private void OnCloseButton() {} // 0x00000001844FAAB0-0x00000001844FAB80
	// [XID] // 0x0000000189742C70-0x0000000189742C90
	private void ChangeStateID(int newId) {} // 0x00000001844F94B0-0x00000001844F9670
	// [XID] // 0x000000018974A990-0x000000018974A9B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844FA8E0-0x00000001844FAAB0
	// [XID] // 0x0000000189751A70-0x0000000189751A90
	private bool HandleListInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844F9B00-0x00000001844F9E70
	// [XID] // 0x0000000189759040-0x0000000189759060
	private bool HandleDetailInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844FABE0-0x00000001844FAD70
}

