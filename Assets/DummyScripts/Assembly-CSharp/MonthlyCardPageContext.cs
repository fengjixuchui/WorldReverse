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

public sealed class MonthlyCardPageContext : BasePageContext // TypeDefIndex: 29207
{
	// Fields
	private MonoMonthlyCardPage _pageMono; // 0x190
	private ItemConfig _rewardItem; // 0x198
	private uint _remainDays; // 0x1A0
	private uint _hcoin; // 0x1A4
	private Coroutine _fetchCoroutine; // 0x1A8
	private bool _canSkipAnimation; // 0x1B0
	private ShowState _showState; // 0x1B4
	private int _prevConfirmFrame; // 0x1B8
	private float _confirmStartTime; // 0x1BC

	// Nested types
	private enum ShowState // TypeDefIndex: 29208
	{
		Begin = 0,
		Fetching = 1,
		ShowReward = 2
	}

	// Constructors
	public MonthlyCardPageContext() {} // Dummy constructor
	public MonthlyCardPageContext(uint remainDays, uint hcoin) {} // 0x0000000182361040-0x0000000182361130

	// Methods
	// [XID] // 0x00000001896E7CE0-0x00000001896E7D00
	public override void SetupView() {} // 0x0000000182360DD0-0x0000000182361040
	// [XID] // 0x00000001896EF410-0x00000001896EF430
	public override void ClearView() {} // 0x000000018235FC60-0x000000018235FE60
	// [XID] // 0x00000001896F6DA0-0x00000001896F6DC0
	protected override void BindViewCallbacks() {} // 0x000000018235FAB0-0x000000018235FC60
	// [XID] // 0x00000001896FE6B0-0x00000001896FE6D0
	public override bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001823606C0-0x00000001823607C0
	// [XID] // 0x00000001897057E0-0x0000000189705800
	private void FetchReward() {} // 0x000000018235FE60-0x00000001823601D0
	// [XID] // 0x000000018970D320-0x000000018970D340
	private void OnSkip() {} // 0x0000000182360A40-0x0000000182360C90
	// [XID] // 0x00000001897147C0-0x00000001897147E0
	private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000182360300-0x0000000182360490
	// [XID] // 0x000000018971C1D0-0x000000018971C1F0
	private void ShowRewardItem() {} // 0x0000000182360C90-0x0000000182360D70
	// [XID] // 0x0000000189723660-0x0000000189723680
	private void ConfirmSkip() {} // 0x00000001823607C0-0x00000001823609E0
	// [XID] // 0x000000018972ADC0-0x000000018972ADE0
	private void OnConfirmSkipEnd() {} // 0x00000001823601D0-0x0000000182360300
}

