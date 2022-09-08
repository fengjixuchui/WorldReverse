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

public sealed class VCPinballBulletMove : VCBulletMove // TypeDefIndex: 11930
{
	// Fields
	private float _pinballRadius; // 0x298
	private float _pinballRandomBackAngleAdded; // 0x29C
	private float _pinballReboundInterval; // 0x2A0
	private float _pinballOutOfRangeFixCD; // 0x2A4
	private bool _pinballIsInRange; // 0x2A8
	private float _pinballReboundTime; // 0x2AC
	private float _pinballOutOfRangeTime; // 0x2B0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189ADCE30-0x0000000189ADCE50 */ get => default; } // 0x0000000182CAA790-0x0000000182CAA830 

	// Constructors
	public VCPinballBulletMove() {} // 0x0000000182CAA6F0-0x0000000182CAA790

	// Methods
	// [XID] // 0x0000000189AE46C0-0x0000000189AE46E0
	protected override void InitBulletData() {} // 0x0000000182CA9F90-0x0000000182CAA620
	// [XID] // 0x00000001896ED3D0-0x00000001896ED3F0
	protected override void CalculateVelocity(BaseEntityHandle targetHandle, Transform tarTrans, Vector3 curPos, float moveDist, float acceleration, float accelerationTime, float deltaTime, ref Vector3 velocity) {} // 0x0000000182CA93A0-0x0000000182CA9E80
}

