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

internal sealed class TopMPTipsWidgetContext : BaseWidgetContext // TypeDefIndex: 29329
{
	// Fields
	private MonoMPTipsBar _monoBar; // 0x168
	private Coroutine _coroutine; // 0x170
	private bool _waitLoadingFinish; // 0x178
	private bool _hasTriggeredPrepare; // 0x179
	private bool _toPrepare; // 0x17A
	private bool _toEnd; // 0x17B

	// Constructors
	public TopMPTipsWidgetContext() {} // 0x000000018121DBB0-0x000000018121DC70

	// Methods
	// [XID] // 0x000000018993C700-0x000000018993C720
	public override void SetupView() {} // 0x000000018121DA50-0x000000018121DBB0
	// [XID] // 0x0000000189943D30-0x0000000189943D50
	public override bool OnNotify(Notify ntf) => default; // 0x000000018121D940-0x000000018121DA50
	// [IDTag] // 0x000000018994B250-0x000000018994B290
	// [XID] // 0x000000018994B250-0x000000018994B290
	public void TriggerPrepare(bool waitLoadingFinish) {} // 0x000000018121D1D0-0x000000018121D2A0
	// [IDTag] // 0x00000001899558E0-0x0000000189955920
	// [XID] // 0x00000001899558E0-0x0000000189955920
	private void TriggerPrepare() {} // 0x000000018121CE30-0x000000018121D1D0
	// [XID] // 0x0000000189960190-0x00000001899601B0
	public void TriggerEnd() {} // 0x000000018121D520-0x000000018121D8B0
	// [XID] // 0x0000000189967C30-0x0000000189967C50
	private void OnHide() {} // 0x000000018121D2A0-0x000000018121D520
	// [XID] // 0x000000018996EE30-0x000000018996EE50
	private void OnClose() {} // 0x000000018121CD10-0x000000018121CDD0
	// [XID] // 0x0000000189976A10-0x0000000189976A30
	private void ResetState() {} // 0x000000018121CC70-0x000000018121CD10
}

