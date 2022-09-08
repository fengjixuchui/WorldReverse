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

public sealed class InLevelClockPageContext : BasePageContext // TypeDefIndex: 29786
{
	// Fields
	private MonoInLevelClockPage _pageMono; // 0x190
	private ClockState curState; // 0x198
	private Coroutine _moveCoroutine; // 0x1A0
	private bool _changingTime; // 0x1A8

	// Nested types
	private enum ClockState // TypeDefIndex: 29787
	{
		Move = 0,
		Back = 1
	}

	// Constructors
	public InLevelClockPageContext() {} // 0x0000000182E015C0-0x0000000182E016A0

	// Methods
	// [XID] // 0x000000018986F570-0x000000018986F590
	public override void SetupView() {} // 0x0000000182E012F0-0x0000000182E014D0
	// [XID] // 0x0000000189876B80-0x0000000189876BA0
	public override void ClearView() {} // 0x0000000182DFECA0-0x0000000182DFED50
	// [XID] // 0x000000018987E680-0x000000018987E6A0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182DFF3B0-0x0000000182DFF640
	// [XID] // 0x0000000189885A70-0x0000000189885A90
	protected override void BindViewCallbacks() {} // 0x0000000182DFEAC0-0x0000000182DFECA0
	// [XID] // 0x000000018988CD60-0x000000018988CD80
	private void ClickClose() {} // 0x0000000182DFDA40-0x0000000182DFDAF0
	// [XID] // 0x0000000189894450-0x0000000189894470
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182E010F0-0x0000000182E01220
	// [XID] // 0x000000018989BA00-0x000000018989BA20
	public override void UpdateView() {} // 0x0000000182E014D0-0x0000000182E015C0
	// [XID] // 0x00000001898A2E90-0x00000001898A2EB0
	private void InitClockNowTime() {} // 0x0000000182DFFF70-0x0000000182E00110
	// [XID] // 0x00000001898AA3B0-0x00000001898AA3D0
	private void SetNowTimeHand() {} // 0x0000000182DFF140-0x0000000182DFF2F0
	// [XID] // 0x00000001898B1D90-0x00000001898B1DB0
	private void SetWorldTime() {} // 0x0000000182DFF7B0-0x0000000182DFFAB0
	// [XID] // 0x00000001898B9A10-0x00000001898B9A30
	public override void ClosePage() {} // 0x0000000182DFDAF0-0x0000000182DFDD30
	// [XID] // 0x00000001898C0E10-0x00000001898C0E30
	private void FinalClosePage() {} // 0x0000000182DFEE00-0x0000000182DFEEB0
	// [XID] // 0x00000001898C8750-0x00000001898C8770
	public void MoveDialog() {} // 0x0000000182E00F60-0x0000000182E01000
	// [XID] // 0x00000001898D0100-0x00000001898D0120
	private void MoveDialogNew() {} // 0x0000000182DFDDD0-0x0000000182DFEAC0
	// [XID] // 0x00000001898D76D0-0x00000001898D76F0
	public void BackMoveDialog() {} // 0x0000000182DFDD30-0x0000000182DFDDD0
	// [XID] // 0x00000001898DF420-0x00000001898DF440
	private void BackMoveDialogNew() {} // 0x0000000182E00BC0-0x0000000182E00F60
	// [XID] // 0x00000001898E6DA0-0x00000001898E6DC0
	public void ChangeLevelTime(float levelTime) {} // 0x0000000182DFFD40-0x0000000182DFFDF0
	// [XID] // 0x00000001898EE570-0x00000001898EE590
	private void ChangeLevelTimeNew(float levelTime) {} // 0x0000000182DFFDF0-0x0000000182DFFF70
	// [XID] // 0x00000001898F5D40-0x00000001898F5D60
	private void UpdateLevelTimeWithCameraElevate(float levelTime) {} // 0x0000000182E002D0-0x0000000182E00B60
	// [XID] // 0x00000001898FD500-0x00000001898FD520
	private void UpdateLevelTimeWithoutCameraElevate(float levelTime) {} // 0x0000000182DFEFC0-0x0000000182DFF140
	// [XID] // 0x0000000189904E00-0x0000000189904E20
	private void ClearCoroutine() {} // 0x0000000182E00110-0x0000000182E002D0
	// [XID] // 0x000000018990C640-0x000000018990C660
	public override void SetActive(bool enabled) {} // 0x0000000182E01220-0x0000000182E012F0
	// [XID] // 0x0000000189913EF0-0x0000000189913F10
	public override void Hide() {} // 0x0000000182DFF640-0x0000000182DFF6F0
	// [XID] // 0x000000018991B8E0-0x000000018991B900
	public override void DestroyForce() {} // 0x0000000182DFED50-0x0000000182DFEE00
}

