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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MPActivityAsterMiddlePageContext : BasePageContext // TypeDefIndex: 29209
{
	// Fields
	private MonoMPActivityAsterMiddlePage _pageMono; // 0x190
	private uint _gadgetId; // 0x198
	private static int _curIndex; // 0x00
	private Coroutine _updateRecoveryTextCoroutineOfResin; // 0x1A0

	// Constructors
	public MPActivityAsterMiddlePageContext() {} // Dummy constructor
	public MPActivityAsterMiddlePageContext(uint gadgetId) {} // 0x0000000185154560-0x0000000185154630
	static MPActivityAsterMiddlePageContext() {} // 0x0000000185154500-0x0000000185154560

	// Methods
	// [XID] // 0x0000000189744370-0x0000000189744390
	public override bool OnNotify(Notify ntf) => default; // 0x0000000185153C00-0x0000000185153D90
	// [XID] // 0x000000018974BFD0-0x000000018974BFF0
	public override void SetupView() {} // 0x0000000185154420-0x0000000185154500
	// [XID] // 0x0000000189753310-0x0000000189753330
	protected override void BindViewCallbacks() {} // 0x0000000185152410-0x0000000185152600
	// [XID] // 0x000000018975A6D0-0x000000018975A6F0
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0EE0D */) {} // 0x0000000185153AA0-0x0000000185153C00
	// [XID] // 0x0000000189762380-0x00000001897623A0
	private void OnSelectLevelClick(int index) {} // 0x0000000185153D90-0x0000000185154080
	// [XID] // 0x0000000189769980-0x00000001897699A0
	private void RefreshView() {} // 0x0000000185152BA0-0x00000001851536A0
	// [XID] // 0x0000000189770FB0-0x0000000189770FD0
	public static void TryShowAsterMidIntroduceDialog() {} // 0x00000001851538B0-0x00000001851539B0
	// [XID] // 0x0000000189778840-0x0000000189778860
	private void OnExplain() {} // 0x00000001851527C0-0x0000000185152880
	// [XID] // 0x000000018977FDC0-0x000000018977FDE0
	private void OnChallenge() {} // 0x00000001851536A0-0x00000001851538B0
	// [XID] // 0x00000001897876A0-0x00000001897876C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000185152A10-0x0000000185152BA0
	// [XID] // 0x000000018978ECD0-0x000000018978ECF0
	private void InitResinView() {} // 0x0000000185154080-0x0000000185154420
	// [XID] // 0x0000000189796440-0x0000000189796460
	private void RefreshResinView() {} // 0x0000000185152600-0x00000001851527C0
}

