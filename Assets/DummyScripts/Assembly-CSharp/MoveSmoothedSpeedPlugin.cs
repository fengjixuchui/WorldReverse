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

public sealed class MoveSmoothedSpeedPlugin : BaseComponentPlugin // TypeDefIndex: 12137
{
	// Fields
	private ConfigMoveSmoothedSpeed _config; // 0x58
	private Vector3 _speedVelocity; // 0x60
	private Vector3 _targetSpeed; // 0x6C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899825B0-0x00000001899825D0 */ get => default; } // 0x0000000181FB3A00-0x0000000181FB3AA0 
	public Vector3 speedVelocity { /* [XID] */ /* 0x0000000189989D10-0x0000000189989D30 */ get => default; /* [XID] */ /* 0x0000000189991630-0x0000000189991650 */ set {} } // 0x0000000181FB31E0-0x0000000181FB32C0 0x0000000181FB3360-0x0000000181FB3420
	public float maxSpeed { /* [XID] */ /* 0x000000018980D560-0x000000018980D580 */ get => default; } // 0x0000000181FB3120-0x0000000181FB31E0 

	// Constructors
	public MoveSmoothedSpeedPlugin() {} // Dummy constructor
	public MoveSmoothedSpeedPlugin(VCAnimatorMove move, ConfigMoveSmoothedSpeed config) {} // 0x0000000181FB3950-0x0000000181FB3A00

	// Methods
	// [XID] // 0x00000001899A0970-0x00000001899A0990
	public override void Init() {} // 0x0000000181FB32C0-0x0000000181FB3360
	// [XID] // 0x00000001899A8440-0x00000001899A8460
	public override void Tick(float inDeltaTime) {} // 0x0000000181FB3490-0x0000000181FB3950
	// [XID] // 0x00000001899AFC50-0x00000001899AFC70
	public void SetSpeed(Vector3 dir, float speed) {} // 0x0000000181FB2F90-0x0000000181FB3120
}

