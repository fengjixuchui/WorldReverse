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

public sealed class BlinkDialogContext : BaseDialogContext // TypeDefIndex: 28853
{
	// Fields
	private float _autoCloseTime; // 0x178
	private Coroutine _closeCoroutine; // 0x180

	// Constructors
	public BlinkDialogContext() {} // 0x0000000181729010-0x00000001817290F0

	// Methods
	// [XID] // 0x00000001896DD970-0x00000001896DD990
	public override void SetupView() {} // 0x0000000181728EC0-0x0000000181729010
	// [XID] // 0x00000001896E5020-0x00000001896E5040
	public override void ClearView() {} // 0x00000001817289B0-0x0000000181728A50
	// [XID] // 0x00000001896EC4C0-0x00000001896EC4E0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181728D60-0x0000000181728EC0
	// [XID] // 0x00000001896F3C90-0x00000001896F3CB0
	private void OnClose() {} // 0x0000000181728A50-0x0000000181728B10
	// [XID] // 0x00000001896FB400-0x00000001896FB420
	private void StopCloseCoroutine() {} // 0x0000000181728BD0-0x0000000181728CD0
}

