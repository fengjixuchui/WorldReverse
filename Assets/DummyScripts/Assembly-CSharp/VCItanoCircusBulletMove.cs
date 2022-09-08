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

public sealed class VCItanoCircusBulletMove : VCBulletMove // TypeDefIndex: 11886
{
	// Fields
	private Vector3 _itanoCircusStartEular; // 0x298
	private bool _guidanceSpeedChange; // 0x2A4
	private float _guidanceDelay; // 0x2A8
	private float _guidanceDuration; // 0x2AC
	private float _guidanceMinAnglerVelocity; // 0x2B0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898F25C0-0x00000001898F25E0 */ get => default; } // 0x000000018167B810-0x000000018167B8B0 

	// Constructors
	public VCItanoCircusBulletMove() {} // 0x000000018167B790-0x000000018167B810

	// Methods
	// [XID] // 0x00000001898F9D20-0x00000001898F9D40
	protected override void InitBulletData() {} // 0x000000018167B210-0x000000018167B6C0
	// [XID] // 0x0000000189901740-0x0000000189901760
	protected override void CalculateVelocity(BaseEntityHandle targetHandle, Transform tarTrans, Vector3 curPos, float moveDist, float acceleration, float accelerationTime, float deltaTime, ref Vector3 velocity) {} // 0x000000018167A840-0x000000018167B100
}

