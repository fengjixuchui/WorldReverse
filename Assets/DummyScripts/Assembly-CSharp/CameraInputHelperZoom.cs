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
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CameraInputHelperZoom // TypeDefIndex: 32051
{
	// Fields
	public UnityAction<float> cameraSetter; // 0x10
	private float zoomDeltaTotal; // 0x18
	private float zoomStep; // 0x1C

	// Properties
	private Coroutine zoomCoroutine { /* [XID] */ /* 0x000000018966AD90-0x000000018966ADD0 */ get; /* [XID] */ /* 0x0000000189660300-0x0000000189660340 */ set; } // 0x0000000182D7BCD0-0x0000000182D7BD30 0x0000000182D7C010-0x0000000182D7C070

	// Constructors
	public CameraInputHelperZoom() {} // 0x0000000182D7C070-0x0000000182D7C0E0

	// Methods
	// [XID] // 0x00000001896757E0-0x0000000189675800
	public void Stop() {} // 0x0000000182D7BA50-0x0000000182D7BBC0
	// [XID] // 0x000000018967D0B0-0x000000018967D0D0
	public void ZoomCamera(float delta) {} // 0x0000000182D7BBC0-0x0000000182D7BCD0
	// [XID] // 0x0000000189684760-0x0000000189684780
	private void TrySmoothZoom() {} // 0x0000000182D7BE40-0x0000000182D7C010
	[DebuggerHidden] // 0x000000018968C270-0x000000018968C2B0
	// [XID] // 0x000000018968C270-0x000000018968C2B0
	private IEnumerator ZoomCameraCorutine() => default; // 0x0000000182D7BD30-0x0000000182D7BE40
}

