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

public sealed class LanternRiteEntrustTaskDialogContext : BaseDialogContext // TypeDefIndex: 29618
{
	// Fields
	private MonoLanternRiteEntrustTaskDialog _dialogMono; // 0x178
	private List<uint> _questList; // 0x180
	private int _index; // 0x188
	private List<RewardItemConfig> _tempRewardList; // 0x190
	private bool _questAccept; // 0x198
	private string _title; // 0x1A0

	// Constructors
	public LanternRiteEntrustTaskDialogContext() {} // Dummy constructor
	public LanternRiteEntrustTaskDialogContext(List<uint> questList, int index, string title) {} // 0x000000018217E250-0x000000018217E350

	// Methods
	// [XID] // 0x000000018985EDF0-0x000000018985EE10
	public override void SetupView() {} // 0x000000018217E150-0x000000018217E250
	// [XID] // 0x00000001898665D0-0x00000001898665F0
	protected override void BindViewCallbacks() {} // 0x000000018217CF00-0x000000018217D180
	// [XID] // 0x000000018986DED0-0x000000018986DEF0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018217E080-0x000000018217E150
	// [XID] // 0x00000001898752A0-0x00000001898752C0
	private void CheckQuestState() {} // 0x000000018217D180-0x000000018217D480
	// [XID] // 0x000000018987CE70-0x000000018987CE90
	private void OnSwitchPrev() {} // 0x000000018217D820-0x000000018217D950
	// [XID] // 0x0000000189883DF0-0x0000000189883E10
	private void OnSwitchNext() {} // 0x000000018217D6D0-0x000000018217D820
	// [XID] // 0x000000018988B490-0x000000018988B4B0
	private void CheckPreNextState() {} // 0x000000018217CCE0-0x000000018217CF00
	// [XID] // 0x0000000189892C50-0x0000000189892C70
	private void RefreshView() {} // 0x000000018217D9B0-0x000000018217DD10
	// [XID] // 0x000000018989A2B0-0x000000018989A2D0
	private void RefreshRewardItems(Transform trans, int index) {} // 0x000000018217D480-0x000000018217D6D0
	// [XID] // 0x00000001898A1510-0x00000001898A1530
	private void OnGotoButton() {} // 0x000000018217DD10-0x000000018217DF90
}

