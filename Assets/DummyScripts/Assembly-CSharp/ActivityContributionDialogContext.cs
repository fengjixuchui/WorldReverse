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

public sealed class ActivityContributionDialogContext : BaseDialogContext // TypeDefIndex: 28399
{
	// Fields
	private const uint DIALOG_ID = 720290203; // Metadata: 0x00B0D731
	private MonoActivityContributionDialog _dialogMono; // 0x178
	private LampPhaseExcelConfig _lampPhaseData; // 0x180
	private Dictionary<uint, uint> _itemParams; // 0x188
	private uint _thisAdd; // 0x190
	private ActivityInfo _seaLampActivityInfo; // 0x198

	// Constructors
	public ActivityContributionDialogContext() {} // Dummy constructor
	public ActivityContributionDialogContext(uint npcId = 0 /* Metadata: 0x00B0D72D */) {} // 0x0000000183CF05D0-0x0000000183CF06E0

	// Methods
	// [XID] // 0x000000018974D8F0-0x000000018974D910
	public override void SetupView() {} // 0x0000000183CF0500-0x0000000183CF05D0
	// [XID] // 0x0000000189754F30-0x0000000189754F50
	protected override void BindViewCallbacks() {} // 0x0000000183CEE6A0-0x0000000183CEE830
	// [XID] // 0x000000018975C0C0-0x000000018975C0E0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000183CF0340-0x0000000183CF0500
	// [XID] // 0x0000000189763A90-0x0000000189763AB0
	private void OnOKBtn() {} // 0x0000000183CEEBE0-0x0000000183CEED50
	// [XID] // 0x000000018976B250-0x000000018976B270
	private void OnContributeFinish() {} // 0x0000000183CEE560-0x0000000183CEE6A0
	// [XID] // 0x00000001897728A0-0x00000001897728C0
	private void Refresh() {} // 0x0000000183CEDBF0-0x0000000183CEDFF0
	// [XID] // 0x0000000189779F90-0x0000000189779FB0
	private void RefreshContriItem(Transform trans, int index) {} // 0x0000000183CEDFF0-0x0000000183CEE560
	// [XID] // 0x0000000189781B30-0x0000000189781B50
	private void OnNumChanged(MonoQuantityWidget quantity) {} // 0x0000000183CEEDE0-0x0000000183CEF0C0
	// [XID] // 0x0000000189789010-0x0000000189789030
	private void RefreshContributionRowSelectState(RectTransform trans, bool selected) {} // 0x0000000183CEE830-0x0000000183CEEBE0
	// [XID] // 0x0000000189790620-0x0000000189790640
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183CEF120-0x0000000183CF0250
}

