/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VelocityDetectPlugin : BaseComponentPlugin // TypeDefIndex: 12175
{
	// Fields
	private float SPEED_THRESHOLD; // 0x58
	private const float FACTOR_Y = 1.8f; // Metadata: 0x00AEB715
	private const float CD = 0.06666667f; // Metadata: 0x00AEB719
	private Vector3 _lastVelocity; // 0x5C
	private float _lastRushVelocity; // 0x68
	private float _checkTime; // 0x6C
	private VCBaseMove _move; // 0x70
	private Collider _collider; // 0x78
	private bool _enableDetect; // 0x80

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896EA620-0x00000001896EA640 */ get => default; } // 0x0000000181F53FC0-0x0000000181F54060 

	// Constructors
	public VelocityDetectPlugin() {} // 0x0000000181F53F50-0x0000000181F53FC0

	// Methods
	// [XID] // 0x00000001896F1610-0x00000001896F1630
	public void EnableCrashDamage(bool enable) {} // 0x0000000181F53C60-0x0000000181F53D10
	// [XID] // 0x00000001896F8FE0-0x00000001896F9000
	public override void Init() {} // 0x0000000181F53D10-0x0000000181F53EE0
	// [XID] // 0x00000001897009F0-0x0000000189700A10
	public void DetectRigidbodyVelocity(Vector3 v, int tagHash) {} // 0x0000000181F53470-0x0000000181F53C60
}

