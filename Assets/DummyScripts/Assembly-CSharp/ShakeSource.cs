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

public class ShakeSource // TypeDefIndex: 21004
{
	// Fields
	public CameraShakeType shakeType; // 0x14
	private Vector3 _shakeDir; // 0x3C
	private bool _firstFrame; // 0x4A
	protected bool _toBeRemoved; // 0x4B
	protected float _lifeTime; // 0x4C
	protected float _endTime; // 0x50
	private float _curValue; // 0x54
	private float _curValueEnergy; // 0x58
	private float _curCycle; // 0x5C
	private float _curSinCurve; // 0x60
	private bool _baseOnCamera; // 0x64
	private bool _afterShake; // 0x65
	private bool _isStoped; // 0x66

	// Properties
	public int handle { /* [XID] */ /* 0x0000000189AB8A40-0x0000000189AB8A80 */ get; private set; } // 0x000000018337DA80-0x000000018337DAE0 0x000000018337D5D0-0x000000018337D630
	public Vector3 centerPos { /* [XID] */ /* 0x0000000189ACB040-0x0000000189ACB080 */ get; /* [XID] */ /* 0x0000000189AD5E60-0x0000000189AD5EA0 */ private set; } // 0x000000018337E1F0-0x000000018337E260 0x000000018337CE00-0x000000018337CE70
	public float centerValue { get; private set; } // 0x000000018337CF50-0x000000018337CFC0 0x000000018337DB40-0x000000018337DBB0
	public float activeTime { get; private set; } // 0x000000018337CE70-0x000000018337CEE0 0x000000018337E180-0x000000018337E1F0
	public float effectRange { /* [XID] */ /* 0x0000000189AFE650-0x0000000189AFE690 */ get; private set; } // 0x000000018337D3A0-0x000000018337D410 0x000000018337E110-0x000000018337E180
	public float baseCycle { get; private set; } // 0x000000018337CEE0-0x000000018337CF50 0x000000018337CC20-0x000000018337CC90
	public float cycleDamping { /* [XID] */ /* 0x0000000189B1F1E0-0x0000000189B1F220 */ get; private set; } // 0x000000018337D480-0x000000018337D4F0 0x000000018337D410-0x000000018337D480
	public float rangeAttenuation { /* [XID] */ /* 0x0000000189B30C10-0x0000000189B30C50 */ get; private set; } // 0x000000018337CC90-0x000000018337CD00 0x000000018337E260-0x000000018337E2D0
	public bool IsInfinite { /* [XID] */ /* 0x0000000189B42C70-0x0000000189B42CB0 */ get; private set; } // 0x000000018337D630-0x000000018337D690 0x000000018337DAE0-0x000000018337DB40
	public bool Active { get; set; } // 0x000000018337CD00-0x000000018337CD60 0x000000018337CBC0-0x000000018337CC20

	// Constructors
	public ShakeSource() {} // 0x000000018337E2D0-0x000000018337E350
	public ShakeSource(CameraShakeType shakeType, Vector3 center, Vector3 dir, float value, float actTime, float effRange, float baseCycle = 0.12f /* Metadata: 0x00AFEC51 */, bool infinite = false /* Metadata: 0x00AFEC55 */, float cycleDamping = 0.12f /* Metadata: 0x00AFEC56 */, float rangeAttenuation = 0.5f /* Metadata: 0x00AFEC5A */, bool baseOnCamera = false /* Metadata: 0x00AFEC5E */, bool afterShake = true /* Metadata: 0x00AFEC5F */) {} // 0x000000018337E350-0x000000018337E710

	// Methods
	// [XID] // 0x0000000189B63D30-0x0000000189B63D50
	public virtual void Tick(float deltaTime) {} // 0x000000018337CFC0-0x000000018337D2E0
	// [XID] // 0x0000000189B6B4C0-0x0000000189B6B4E0
	public void SetPosition(Vector3 pos) {} // 0x000000018337D690-0x000000018337D7A0
	// [XID] // 0x0000000189B72B10-0x0000000189B72B30
	public virtual Vector3 GetShakeWorldOffSet(Vector3 listenerPos) => default; // 0x000000018337DCF0-0x000000018337DF80
	// [XID] // 0x0000000189B7A050-0x0000000189B7A070
	public virtual Vector3 GetShakeCameraOffSet() => default; // 0x000000018337DF80-0x000000018337E110
	// [XID] // 0x0000000189B817B0-0x0000000189B817D0
	public virtual float GetRatio(Vector3 listenerPos) => default; // 0x000000018337D890-0x000000018337DA80
	// [XID] // 0x0000000189B88E50-0x0000000189B88E70
	public virtual float? GetShakeEnergy() => default; // 0x000000018337D2E0-0x000000018337D3A0
	// [XID] // 0x0000000189B903E0-0x0000000189B90400
	public virtual void Destroy() {} // 0x000000018337CD60-0x000000018337CE00
	// [XID] // 0x0000000189B97810-0x0000000189B97830
	public void StopShake() {} // 0x000000018337D4F0-0x000000018337D5D0
	// [XID] // 0x0000000189B9EC70-0x0000000189B9EC90
	public void SetToRemove() {} // 0x000000018337DC50-0x000000018337DCF0
	// [XID] // 0x0000000189BA6580-0x0000000189BA65A0
	public bool IsToBeRemove() => default; // 0x000000018337DBB0-0x000000018337DC50
	// [XID] // 0x0000000189BAD8A0-0x0000000189BAD8C0
	public void CheckFirst() {} // 0x000000018337D7A0-0x000000018337D890
}

