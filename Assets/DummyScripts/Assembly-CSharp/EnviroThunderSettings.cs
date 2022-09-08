/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[Serializable]
public class EnviroThunderSettings // TypeDefIndex: 31479
{
	// Fields
	public string profileName; // 0x10
	[NonSerialized]
	public Config config; // 0x18
	// [Tooltip] // 0x000000018992BCD0-0x000000018992BD00
	public EnviroConfigFloat lightningMinInterval; // 0x58
	public EnviroConfigFloat lightningMaxInterval; // 0x88
	public EnviroConfigFloat lightningMinNum; // 0xB8
	public EnviroConfigFloat lightningMaxNum; // 0xE8
	public EnviroConfigFloat lightningMinRange; // 0x118
	public EnviroConfigFloat lightningMaxRange; // 0x148
	public EnviroConfigFloat farLightningMinRange; // 0x178
	public EnviroConfigFloat farLightningMaxRange; // 0x1A8
	public EnviroConfigFloat lightningBeginHeight; // 0x1D8
	public EnviroConfigFloat lightningHeightRatio; // 0x208
	public EnviroConfigFloat lightningMaxHeight; // 0x238
	public EnviroConfigFloat lightningRatio; // 0x268
	public EnviroConfigFloat lightningAngle; // 0x298
	public EnviroConfigFloat farLightningAngle; // 0x2C8
	public string lightningPrefab; // 0x2F8
	public string lightningCloudPrefab; // 0x300
	public string lightningImpactPrefab; // 0x308
	public string simpleLightningPrefab; // 0x310
	public string simpleLightningCloudPrefab; // 0x318
	public string simpleLightningImpactPrefab; // 0x320
	public AnimationClip thunderShakeCurve; // 0x328
	// [Tooltip] // 0x000000018992BCD0-0x000000018992BD00
	public EnviroConfigFloat lightningFlashTime; // 0x330
	public EnviroConfigColor lightningFlashColor; // 0x360
	// [Tooltip] // 0x000000018992BCD0-0x000000018992BD00
	public EnviroConfigFloat lightningFlashIntensity; // 0x380

	// Nested types
	public struct Config // TypeDefIndex: 31480
	{
		// Fields
		public float lightningMinInterval; // 0x00
		public float lightningMaxInterval; // 0x04
		public int lightningMinNum; // 0x08
		public int lightningMaxNum; // 0x0C
		public float lightningMinRange; // 0x10
		public float lightningMaxRange; // 0x14
		public float farLightningMinRange; // 0x18
		public float farLightningMaxRange; // 0x1C
		public float lightningBeginHeight; // 0x20
		public float lightningMaxHeight; // 0x24
		public float lightningHeightRatio; // 0x28
		public float lightningFlashTime; // 0x2C
		public float lightningRatio; // 0x30
		public float lightningAngle; // 0x34
		public float farLightningAngle; // 0x38
	}

	// Constructors
	public EnviroThunderSettings() {} // 0x00000001836A0540-0x00000001836A0CB0

	// Methods
	public void Evaluate(float time) {} // 0x00000001836A00A0-0x00000001836A02B0
	public void Lerp(EnviroThunderSettings targetSetting, float effectRatio) {} // 0x00000001836A02B0-0x00000001836A0540
}

