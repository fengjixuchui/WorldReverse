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

public class CameraBlurSource // TypeDefIndex: 20753
{
	// Fields
	protected bool _toBeRemoved; // 0x32
	protected float _lifeTime; // 0x34

	// Properties
	public int handle { /* [XID] */ /* 0x0000000189705BA0-0x0000000189705BE0 */ get; private set; } // 0x00000001818CE0A0-0x00000001818CE100 0x00000001818CDED0-0x00000001818CDF30
	public Vector3 centerPos { /* [XID] */ /* 0x0000000189717980-0x00000001897179C0 */ get; /* [XID] */ /* 0x0000000189722060-0x00000001897220A0 */ private set; } // 0x00000001818CE3F0-0x00000001818CE460 0x00000001818CD900-0x00000001818CD970
	public float centerPower { /* [XID] */ /* 0x000000018972C840-0x000000018972C880 */ get; private set; } // 0x00000001818CE380-0x00000001818CE3F0 0x00000001818CDCD0-0x00000001818CDD40
	public float activeTime { get; private set; } // 0x00000001818CD970-0x00000001818CD9E0 0x00000001818CE310-0x00000001818CE380
	public float fadeTime { /* [XID] */ /* 0x000000018974DAB0-0x000000018974DAF0 */ get; private set; } // 0x00000001818CD790-0x00000001818CD800 0x00000001818CD9E0-0x00000001818CDA50
	public float effectRange { /* [XID] */ /* 0x000000018975F750-0x000000018975F790 */ get; private set; } // 0x00000001818CDE60-0x00000001818CDED0 0x00000001818CE2A0-0x00000001818CE310
	public bool IsInfinite { /* [XID] */ /* 0x00000001897712E0-0x0000000189771320 */ get; private set; } // 0x00000001818CDF30-0x00000001818CDF90 0x00000001818CE100-0x00000001818CE160
	public bool Active { get; set; } // 0x00000001818CD800-0x00000001818CD860 0x00000001818CD730-0x00000001818CD790

	// Constructors
	public CameraBlurSource() {} // 0x00000001818CE7A0-0x00000001818CE810
	public CameraBlurSource(Vector3 center, float power, float actTime, float effRange, float fdTime = 0f /* Metadata: 0x00AFE282 */, bool infinite = false /* Metadata: 0x00AFE286 */) {} // 0x00000001818CE460-0x00000001818CE7A0

	// Methods
	// [XID] // 0x0000000189791F60-0x0000000189791F80
	public virtual void Tick() {} // 0x00000001818CDD40-0x00000001818CDE60
	// [XID] // 0x0000000189799650-0x0000000189799670
	public void SetPosition(Vector3 pos) {} // 0x00000001818CDF90-0x00000001818CE0A0
	// [XID] // 0x00000001897A14C0-0x00000001897A14E0
	public virtual float? GetBlurValue(Vector3 listenerPos) => default; // 0x00000001818CDA50-0x00000001818CDCD0
	// [XID] // 0x00000001897A8C60-0x00000001897A8C80
	public virtual void Destroy() {} // 0x00000001818CD860-0x00000001818CD900
	// [XID] // 0x00000001897B0540-0x00000001897B0560
	public void Stop(bool force = false /* Metadata: 0x00AFE287 */) {} // 0x00000001818CD600-0x00000001818CD730
	// [XID] // 0x00000001897B8360-0x00000001897B8380
	private void SetToRemove() {} // 0x00000001818CE200-0x00000001818CE2A0
	// [XID] // 0x00000001897C0400-0x00000001897C0420
	public bool IsToBeRemove() => default; // 0x00000001818CE160-0x00000001818CE200
}

