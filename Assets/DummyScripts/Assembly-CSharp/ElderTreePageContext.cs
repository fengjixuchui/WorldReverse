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

public sealed class ElderTreePageContext : BasePageContext // TypeDefIndex: 29010
{
	// Fields
	private MonoElderTreePage _pageMono; // 0x190
	private List<RewardItemConfig> _tempRewardList; // 0x198
	private List<IdCountConfig> _tempConsumeList; // 0x1A0
	private bool _canLevelUp; // 0x1A8
	private WorldRoutineTypeInfo _routineInfo; // 0x1B0
	public bool ReleaseCallbackReseted; // 0x1B8
	private bool _isEventCameraMove; // 0x1B9

	// Properties
	private bool IsEventPart { /* [XID] */ /* 0x00000001897C5F20-0x00000001897C5F40 */ get => default; } // 0x0000000181BE12B0-0x0000000181BE1390 

	// Constructors
	public ElderTreePageContext() {} // 0x0000000181BE5270-0x0000000181BE5330

	// Methods
	// [XID] // 0x000000018972F440-0x000000018972F460
	public override void SetupView() {} // 0x0000000181BE50F0-0x0000000181BE5270
	// [XID] // 0x0000000189736E80-0x0000000189736EA0
	private void RefreshView() {} // 0x0000000181BE2810-0x0000000181BE2E10
	// [XID] // 0x000000018973EA40-0x000000018973EA60
	private void CheckRewardButtonRedPoint() {} // 0x0000000181BE4720-0x0000000181BE4940
	// [XID] // 0x0000000189745D00-0x0000000189745D20
	private void SetEventInfo(uint curLevel) {} // 0x0000000181BE37F0-0x0000000181BE3FF0
	// [XID] // 0x000000018974D7F0-0x000000018974D810
	private void RefreshRewardItems(Transform trans, int index) {} // 0x0000000181BE1800-0x0000000181BE1A50
	// [XID] // 0x0000000189754E50-0x0000000189754E70
	private void RefreshConsumeItems(Transform trans, int index) {} // 0x0000000181BE1AB0-0x0000000181BE1D70
	// [XID] // 0x000000018975BFE0-0x000000018975C000
	private void RefreshEventItems(Transform trans, int index) {} // 0x0000000181BE1F10-0x0000000181BE22B0
	// [XID] // 0x0000000189763970-0x0000000189763990
	private void OnRoutinePositionClick(uint routineId) {} // 0x0000000181BE2F80-0x0000000181BE3150
	// [XID] // 0x000000018976B130-0x000000018976B150
	private void RefreshEventRewardItems(Transform trans, int index) {} // 0x0000000181BE34C0-0x0000000181BE3710
	// [XID] // 0x0000000189772780-0x00000001897727A0
	protected override void OnEnable() {} // 0x0000000181BE4C10-0x0000000181BE4DD0
	// [XID] // 0x0000000189779DD0-0x0000000189779DF0
	public override void ClearView() {} // 0x0000000181BE1760-0x0000000181BE1800
	// [XID] // 0x0000000189781A10-0x0000000189781A30
	protected override void BindViewCallbacks() {} // 0x0000000181BE1390-0x0000000181BE1760
	// [XID] // 0x0000000189788F10-0x0000000189788F30
	private void OnRead() {} // 0x0000000181BE3710-0x0000000181BE37F0
	// [XID] // 0x0000000189790500-0x0000000189790520
	private void OnBackEventList() {} // 0x0000000181BE22B0-0x0000000181BE2370
	// [XID] // 0x0000000189797EF0-0x0000000189797F10
	private void OnEventList() {} // 0x0000000181BE49A0-0x0000000181BE4B80
	// [XID] // 0x000000018979FC10-0x000000018979FC30
	private void OnRewards() {} // 0x0000000181BE4EB0-0x0000000181BE4FC0
	// [XID] // 0x00000001897A7190-0x00000001897A71B0
	private void OnOffering() {} // 0x0000000181BE3150-0x0000000181BE3230
	// [XID] // 0x00000001897AEB40-0x00000001897AEB60
	private void OnDetail() {} // 0x0000000181BE1E00-0x0000000181BE1F10
	// [XID] // 0x00000001897B69D0-0x00000001897B69F0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181BE4DD0-0x0000000181BE4EB0
	// [XID] // 0x00000001897BE810-0x00000001897BE830
	public void OnOfferingLevelChange() {} // 0x0000000181BE4FC0-0x0000000181BE50F0
	// [XID] // 0x00000001897CD700-0x00000001897CD720
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181BE23D0-0x0000000181BE2810
	// [XID] // 0x00000001897D4C80-0x00000001897D4CA0
	private void EventCameraMove() {} // 0x0000000181BE40F0-0x0000000181BE4720
	// [XID] // 0x00000001897DC3C0-0x00000001897DC3E0
	private void BackEventCameraMove() {} // 0x0000000181BE3230-0x0000000181BE34C0
}

