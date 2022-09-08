/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ThreadDebugDialogContext : BaseDialogContext // TypeDefIndex: 28676
{
	// Fields
	private float _barLength; // 0x178
	private RectTransform _renderUpdateBar; // 0x180
	private RectTransform _updateBufferBar; // 0x188
	private RectTransform _updateBar; // 0x190
	private float _originalBarX; // 0x198
	private float _originalUpdateBarY; // 0x19C
	private float _originalRenderUpdateBarY; // 0x1A0
	private ThreadDebugDrawData _drawData; // 0x1A8

	// Constructors
	public ThreadDebugDialogContext() {} // 0x0000000184FB3F00-0x0000000184FB3FF0

	// Methods
	// [XID] // 0x0000000189759080-0x00000001897590A0
	public override void SetupView() {} // 0x0000000184FB3CA0-0x0000000184FB3F00
	// [XID] // 0x0000000189760CD0-0x0000000189760CF0
	public void UpdateBarView(ThreadDebugDrawData debugData) {} // 0x0000000184FB3510-0x0000000184FB35D0
	// [XID] // 0x0000000189768030-0x0000000189768050
	private void UpdateBarViewInternal() {} // 0x0000000184FB3860-0x0000000184FB3A20
	// [XID] // 0x000000018976F5C0-0x000000018976F5E0
	private void UpdateBarX() {} // 0x0000000184FB3A20-0x0000000184FB3CA0
	// [XID] // 0x0000000189776FA0-0x0000000189776FC0
	private void UpdateBarY() {} // 0x0000000184FB35D0-0x0000000184FB3800
}

