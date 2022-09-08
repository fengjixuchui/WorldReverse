/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetNewCharacterPageContext : BasePageContext // TypeDefIndex: 29781
{
	// Fields
	private MonoGetNewCharacterPage _pageMono; // 0x190
	private List<MonoGachaItemPoster> _gachaPosterSlots; // 0x198
	private Coroutine _showItemCoroutine; // 0x1A0
	private int _currItemIndex; // 0x1A8
	private List<SimpleItemStruct> _cacheTransItems; // 0x1B0
	private AddNoGachaAvatarCardNotify _notify; // 0x1B8
	private bool _showFullBg; // 0x1C0

	// Constructors
	public GetNewCharacterPageContext() {} // Dummy constructor
	public GetNewCharacterPageContext(AddNoGachaAvatarCardNotify notify, bool showFullBg) {} // 0x0000000181F65800-0x0000000181F65950

	// Methods
	// [XID] // 0x00000001896DA9E0-0x00000001896DAA00
	public override void SetupView() {} // 0x0000000181F65720-0x0000000181F65800
	// [XID] // 0x00000001896E2110-0x00000001896E2130
	public void Refresh() {} // 0x0000000181F63E60-0x0000000181F64160
	// [XID] // 0x00000001896E9630-0x00000001896E9650
	public override void ClearView() {} // 0x0000000181F64490-0x0000000181F645C0
	// [XID] // 0x00000001896F0890-0x00000001896F08B0
	protected override void BindViewCallbacks() {} // 0x0000000181F64330-0x0000000181F64490
	// [XID] // 0x00000001896F8060-0x00000001896F8080
	public override void ClosePage() {} // 0x0000000181F64270-0x0000000181F64330
	// [XID] // 0x00000001896FFA20-0x00000001896FFA40
	public void ShowOneItem(bool isSettle) {} // 0x0000000181F649A0-0x0000000181F64EA0
	[DebuggerHidden] // 0x0000000189707090-0x00000001897070D0
	// [XID] // 0x0000000189707090-0x00000001897070D0
	private IEnumerator ShowPoster() => default; // 0x0000000181F64160-0x0000000181F64270
	// [XID] // 0x0000000189711C50-0x0000000189711C70
	public override bool BasePageHandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181F64F60-0x0000000181F65040
	// [XID] // 0x00000001897190D0-0x00000001897190F0
	private bool HandleOneItemInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181F645C0-0x0000000181F64890
	// [XID] // 0x0000000189720790-0x00000001897207B0
	private void RefreshCurrentPosterItem(MonoGachaItemPoster slot, bool prev) {} // 0x0000000181F650A0-0x0000000181F653C0
	// [XID] // 0x0000000189727D40-0x0000000189727D60
	public override void SetActive(bool enabled) {} // 0x0000000181F65420-0x0000000181F65720
}

