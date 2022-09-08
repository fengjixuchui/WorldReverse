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

public sealed class MotionBlurMixerBehaviour : PlayableBehaviour // TypeDefIndex: 26230
{
	// Fields
	private MotionBlur _motionBlur; // 0x10
	private bool rEnabled; // 0x18
	private float rShutterSpd; // 0x1C
	private MotionBlur.MotionBlurQuality rQuality; // 0x20

	// Constructors
	public MotionBlurMixerBehaviour() {} // 0x000000018224E440-0x000000018224E4B0

	// Methods
	// [XID] // 0x000000018987B710-0x000000018987B730
	private void InitResetParam() {} // 0x000000018224DDE0-0x000000018224DF30
	// [XID] // 0x00000001898828D0-0x00000001898828F0
	public override void OnPlayableDestroy(Playable playable) {} // 0x000000018224E050-0x000000018224E140
	// [XID] // 0x000000018988A0A0-0x000000018988A0C0
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x000000018224E140-0x000000018224E440
	// [XID] // 0x0000000189891560-0x0000000189891580
	public MotionBlur GetMotionBlur(object playerData) => default; // 0x000000018224DF30-0x000000018224E050
	// [XID] // 0x0000000189898D60-0x0000000189898D80
	private void PerformMotionBlurParam(bool enabled, float shutterSpeed, MotionBlur.MotionBlurQuality quality) {} // 0x000000018224DAE0-0x000000018224DC90
}

