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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelAvatarFirstSightPageContext : BaseDialogContext // TypeDefIndex: 30148
{
	// Fields
	private MonoInLevelAvatarFirstSightPage _pageMono; // 0x178
	private List<Action> _finishCBList; // 0x180
	private uint _npcID; // 0x188
	private bool _isLogicallyShow; // 0x18C
	private ulong CLOSE_DIALOG_DELAY; // 0x190
	private ulong _setupTimeStamp; // 0x198

	// Constructors
	public InLevelAvatarFirstSightPageContext() {} // Dummy constructor
	public InLevelAvatarFirstSightPageContext(uint npcID) {} // 0x00000001833C38D0-0x00000001833C3A00

	// Methods
	// [XID] // 0x0000000189BC6BF0-0x0000000189BC6C10
	public static void ShowFirstSightDialog(uint npcID) {} // 0x00000001833C35A0-0x00000001833C3760
	// [XID] // 0x0000000189BCE8E0-0x0000000189BCE900
	public static void AddFinishCallback(Action finishCB) {} // 0x00000001833C2DB0-0x00000001833C2F20
	// [XID] // 0x0000000189BD5BA0-0x0000000189BD5BC0
	public static bool IsLogicallyShow() => default; // 0x00000001833C2BE0-0x00000001833C2CD0
	// [XID] // 0x0000000189BDD850-0x0000000189BDD870
	public override void SetupView() {} // 0x00000001833C3760-0x00000001833C38D0
	// [XID] // 0x00000001895EA3B0-0x00000001895EA3D0
	public override void ClearView() {} // 0x00000001833C2AE0-0x00000001833C2BE0
	// [XID] // 0x00000001895F1830-0x00000001895F1850
	protected override void BindViewCallbacks() {} // 0x00000001833C2990-0x00000001833C2AE0
	// [XID] // 0x00000001895F92D0-0x00000001895F92F0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001833C3010-0x00000001833C3180
	// [XID] // 0x0000000189600900-0x0000000189600920
	public override void CloseDialog() {} // 0x00000001833C2CD0-0x00000001833C2DB0
	// [XID] // 0x0000000189608220-0x0000000189608240
	private void Refresh() {} // 0x00000001833C24D0-0x00000001833C2990
	// [XID] // 0x000000018960FBC0-0x000000018960FBE0
	private void OnBGClick() {} // 0x00000001833C3240-0x00000001833C3320
	// [XID] // 0x0000000189616E60-0x0000000189616E80
	private void InvokeCBAndClosePage() {} // 0x00000001833C3320-0x00000001833C3470
	// [XID] // 0x000000018961E9C0-0x000000018961E9E0
	private void AddFinishCallbackInternal(Action finishCB) {} // 0x00000001833C3470-0x00000001833C3540
}

