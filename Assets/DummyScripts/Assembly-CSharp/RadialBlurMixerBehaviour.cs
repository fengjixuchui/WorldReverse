/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RadialBlurMixerBehaviour : PlayableBehaviour // TypeDefIndex: 26234
{
	// Fields
	private MotionBlur _motionBlur; // 0x10
	private Vector2 _rCenter; // 0x18
	private float _rRadius; // 0x20
	private float _rAmount; // 0x24

	// Constructors
	public RadialBlurMixerBehaviour() {} // 0x0000000180F19230-0x0000000180F192A0

	// Methods
	// [XID] // 0x00000001898D7970-0x00000001898D7990
	private void InitResetParam() {} // 0x0000000180F18B40-0x0000000180F18CA0
	// [XID] // 0x00000001898DF5E0-0x00000001898DF600
	public override void OnPlayableDestroy(Playable playable) {} // 0x0000000180F18DC0-0x0000000180F18EB0
	// [XID] // 0x00000001898E70A0-0x00000001898E70C0
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000180F18EB0-0x0000000180F19230
	// [XID] // 0x00000001898EE850-0x00000001898EE870
	private MotionBlur GetMotionBlur(object playerData) => default; // 0x0000000180F18CA0-0x0000000180F18DC0
	// [XID] // 0x00000001898F5FD0-0x00000001898F5FF0
	private void PerformRadialBlurParam(bool enabled, Vector2 center, float radius, float amount) {} // 0x0000000180F18970-0x0000000180F18B40
}

