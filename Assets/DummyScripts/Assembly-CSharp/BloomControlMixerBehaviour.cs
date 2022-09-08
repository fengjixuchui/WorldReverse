/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine.Playables;
using UnityEngine.Rendering.PostProcessing;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BloomControlMixerBehaviour : PlayableBehaviour // TypeDefIndex: 26135
{
	// Fields
	private MHYBloom _bloom; // 0x10
	private float _glareThreshold; // 0x18
	private float _glareScaler; // 0x1C
	private float _glareIntensity; // 0x20
	private float _exposure; // 0x24
	private EnviroSky _enviroSky; // 0x28
	private bool _disableSky; // 0x30

	// Constructors
	public BloomControlMixerBehaviour() {} // 0x0000000183480510-0x0000000183480580

	// Methods
	// [XID] // 0x000000018970EBF0-0x000000018970EC10
	private void InitResetParam() {} // 0x000000018347FB10-0x000000018347FC90
	// [XID] // 0x0000000189716020-0x0000000189716040
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x00000001834801D0-0x0000000183480510
	// [XID] // 0x000000018971DA70-0x000000018971DA90
	private MHYBloom GetMHYBloom(object playerData) => default; // 0x000000018347F9F0-0x000000018347FB10
	// [XID] // 0x0000000189724ED0-0x0000000189724EF0
	private void PerformBloomParam(float glareThreshold, float glareScaler, float glareIntensity, float exposure) {} // 0x000000018347FDA0-0x000000018347FF70
	// [XID] // 0x000000018972C620-0x000000018972C640
	public override void OnGraphStart(Playable playable) {} // 0x000000018347FF70-0x00000001834800B0
	// [XID] // 0x0000000189733D40-0x0000000189733D60
	public override void OnGraphStop(Playable playable) {} // 0x00000001834800B0-0x00000001834801D0
	// [XID] // 0x000000018973B4C0-0x000000018973B4E0
	private void SetSkyControlEnable(bool enable) {} // 0x000000018347FC90-0x000000018347FDA0
}

