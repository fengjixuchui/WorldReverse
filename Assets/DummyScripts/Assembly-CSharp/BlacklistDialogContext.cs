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

public sealed class BlacklistDialogContext : BaseDialogContext // TypeDefIndex: 28851
{
	// Fields
	private MonoBlacklistDialog _dialogMono; // 0x178
	private List<uint> _blacklist; // 0x180

	// Constructors
	public BlacklistDialogContext() {} // 0x0000000182453F80-0x0000000182454060

	// Methods
	// [XID] // 0x0000000189666540-0x0000000189666560
	public override void SetupView() {} // 0x0000000182453D70-0x0000000182453F80
	// [XID] // 0x000000018966DD40-0x000000018966DD60
	protected override void BindViewCallbacks() {} // 0x0000000182452BF0-0x0000000182452CF0
	// [XID] // 0x0000000189675B60-0x0000000189675B80
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182453C90-0x0000000182453D70
	// [XID] // 0x000000018967D3F0-0x000000018967D410
	private void RefreshBlacklist() {} // 0x00000001824526F0-0x0000000182452BF0
	// [XID] // 0x0000000189684AC0-0x0000000189684AE0
	private List<uint> GetBlacklist() => default; // 0x0000000182452D80-0x0000000182452E60
	// [XID] // 0x000000018968C690-0x000000018968C6B0
	private void RefreshBlacklistRow(Transform trans, int index) {} // 0x00000001824533C0-0x0000000182453850
	// [XID] // 0x00000001896940E0-0x0000000189694100
	private void OnIconBtnClick(uint uid) {} // 0x0000000182453850-0x0000000182453940
	// [XID] // 0x000000018969B670-0x000000018969B690
	private void OnRemoveBtnClick(uint uid) {} // 0x0000000182453B10-0x0000000182453C00
	// [XID] // 0x00000001896A2DD0-0x00000001896A2DF0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182452EC0-0x00000001824533C0
	// [XID] // 0x00000001896AA2A0-0x00000001896AA2C0
	private static void OnBlacklistJoypadSelectChange(RectTransform trans, bool select) {} // 0x00000001824525D0-0x00000001824526F0
	// [XID] // 0x00000001896B10E0-0x00000001896B1100
	private void RefreshBlacklistRowSelectState(MonoBlacklistRow item, int index) {} // 0x00000001824539A0-0x0000000182453B10
}

