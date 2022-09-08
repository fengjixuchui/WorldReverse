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

public sealed class CameraBlurManager : InLevelManager // TypeDefIndex: 20754
{
	// Fields
	private int _curHandle; // 0x10
	private List<CameraBlurSource> _blurSources; // 0x18
	private int _lastBlurSourceCount; // 0x20
	private CameraEntity _camera; // 0x28
	private VCCameraMiscs _cameraMisc; // 0x30
	private VCStackCamera _vcStackCamera; // 0x38
	private float? _power; // 0x40

	// Constructors
	public CameraBlurManager() {} // 0x0000000182F50F90-0x0000000182F51040

	// Methods
	// [XID] // 0x00000001897C7C70-0x00000001897C7C90
	public override void Init() {} // 0x0000000182F505A0-0x0000000182F50640
	// [XID] // 0x00000001897CEEE0-0x00000001897CEF00
	public override void Tick() {} // 0x0000000182F50DB0-0x0000000182F50F90
	// [XID] // 0x00000001897D66E0-0x00000001897D6700
	public override void Destroy() {} // 0x0000000182F50120-0x0000000182F501E0
	// [XID] // 0x00000001897DDE70-0x00000001897DDE90
	public int AddBlur(Vector3 center, float pwoer, float actTime, float effRange, float fadeTime, bool infinite = false /* Metadata: 0x00AFE288 */) => default; // 0x0000000182F50640-0x0000000182F50860
	// [XID] // 0x00000001897E5920-0x00000001897E5940
	public CameraBlurSource GetBlur(int handle) => default; // 0x0000000182F50860-0x0000000182F50A30
	// [XID] // 0x00000001897ED410-0x00000001897ED430
	public int GetNextHadle() => default; // 0x0000000182F50010-0x0000000182F500C0
	// [XID] // 0x00000001897F4B90-0x00000001897F4BB0
	public void StopBlur(int handle, bool force = false /* Metadata: 0x00AFE289 */) {} // 0x0000000182F503E0-0x0000000182F505A0
	// [XID] // 0x00000001897FC640-0x00000001897FC660
	public override void LateTick() {} // 0x0000000182F50A30-0x0000000182F50DB0
	// [XID] // 0x0000000189803BF0-0x0000000189803C10
	private float? GetMaxFloatValue(float? f1, float? f2) => default; // 0x0000000182F501E0-0x0000000182F50380
}

