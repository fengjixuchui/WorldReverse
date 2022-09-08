/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine.Playables;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DOFMixerBehaviour : PlayableBehaviour // TypeDefIndex: 26153
{
	// Fields
	public bool dontResetWhenDestroy; // 0x10
	private MotionBlur _motionBlur; // 0x18
	private MHYDepthOfField _mhyDepthOffield; // 0x20
	private bool rEnabled; // 0x28
	private float rFocusDistance; // 0x2C
	private float rFocusRange; // 0x30
	private float rNearFocalDistance; // 0x34
	private float rNearFocalTransDistance; // 0x38
	private float rDofBlurAmount; // 0x3C
	private MotionBlur.DofQuality rQuality; // 0x40

	// Constructors
	public DOFMixerBehaviour() {} // 0x00000001843B6900-0x00000001843B6970

	// Methods
	// [XID] // 0x0000000189870C70-0x0000000189870C90
	private void InitMotionBlurResetParam() {} // 0x00000001843B5760-0x00000001843B5990
	// [XID] // 0x0000000189878700-0x0000000189878720
	private void InitMHYDepthOfFieldResetParam() {} // 0x00000001843B5F20-0x00000001843B6130
	// [XID] // 0x000000018987FC70-0x000000018987FC90
	public override void OnPlayableDestroy(Playable playable) {} // 0x00000001843B6370-0x00000001843B64C0
	// [XID] // 0x00000001898872A0-0x00000001898872C0
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x00000001843B64C0-0x00000001843B6900
	// [XID] // 0x000000018988E3D0-0x000000018988E3F0
	public MotionBlur GetMotionBlur(object playerData) => default; // 0x00000001843B6250-0x00000001843B6370
	// [XID] // 0x0000000189895A20-0x0000000189895A40
	public MHYDepthOfField GetMHYDepthOfField(object playerData) => default; // 0x00000001843B6130-0x00000001843B6250
	// [XID] // 0x000000018989D0C0-0x000000018989D0E0
	private void PerformDofParam(bool enabled, float focusDistance, float focusRange, float nearFocalDistance, float nearFocalTransDistance, float dofBlurAmount, MotionBlur.DofQuality quality) {} // 0x00000001843B5A60-0x00000001843B5F20
}

