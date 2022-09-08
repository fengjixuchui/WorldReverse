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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BasePopUpDialogContext : BaseDialogContext // TypeDefIndex: 29217
{
	// Fields
	private Queue<NewItemStruct> _itemIDs; // 0x178
	private Coroutine _coroutine; // 0x180
	private bool _canInterrupt; // 0x188
	protected NewItemStruct _item; // 0x18C
	protected float _minDuration; // 0x194
	protected float _completeDuration; // 0x198
	protected bool _isAsyncLoading; // 0x19C
	private const float _maxAsyncWaitTime = 5f; // Metadata: 0x00B0EE26

	// Constructors
	public BasePopUpDialogContext() {} // Dummy constructor
	public BasePopUpDialogContext(NewItemStruct item) {} // 0x0000000183E20210-0x0000000183E20300

	// Methods
	// [XID] // 0x000000018988CDE0-0x000000018988CE00
	public override void SetupView() {} // 0x0000000183E20110-0x0000000183E20210
	// [XID] // 0x00000001898944D0-0x00000001898944F0
	public override void ClearView() {} // 0x0000000183E1F940-0x0000000183E1FA30
	[DebuggerHidden] // 0x000000018989BA80-0x000000018989BAC0
	// [XID] // 0x000000018989BA80-0x000000018989BAC0
	private IEnumerator Show(bool needFadeOut = false /* Metadata: 0x00B0EE25 */) => default; // 0x0000000183E1FBB0-0x0000000183E1FCD0
	// [XID] // 0x00000001898A6140-0x00000001898A6160
	protected virtual float FadeOutAction() => default; // 0x0000000183E1F890-0x0000000183E1F940
	// [XID] // 0x00000001898AD770-0x00000001898AD790
	protected virtual void ShowItemAction(NewItemStruct item) {} // 0x0000000183E1FE40-0x0000000183E1FEE0
	// [XID] // 0x00000001898B4CB0-0x00000001898B4CD0
	public void AddShowItem(NewItemStruct item) {} // 0x0000000183E1FCD0-0x0000000183E1FE40
	// [XID] // 0x00000001898BC7C0-0x00000001898BC7E0
	protected override void OnEnable() {} // 0x0000000183E1FFD0-0x0000000183E20110
	// [XID] // 0x00000001898C3E40-0x00000001898C3E60
	protected override void OnDisable() {} // 0x0000000183E1FEE0-0x0000000183E1FFD0
}

