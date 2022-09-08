/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCBaseCameraMove : VCBaseMove // TypeDefIndex: 11806
{
	// Fields
	public bool isFollowTargetStand; // 0x1E0
	public bool isCameraControl; // 0x1E1

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897812C0-0x00000001897812E0 */ get => default; } // 0x000000018226DC50-0x000000018226DCF0 
	public BaseEntity followTarget { get; /* [XID] */ /* 0x0000000189ACEC50-0x0000000189ACEC90 */ set; } // 0x000000018226D8D0-0x000000018226D930 0x000000018226DA30-0x000000018226DAA0

	// Constructors
	public VCBaseCameraMove() {} // 0x000000018226DBD0-0x000000018226DC50

	// Methods
	// [XID] // 0x0000000189788800-0x0000000189788820
	public void SetFollowTarget(BaseEntity followTarget) {} // 0x000000018226D7E0-0x000000018226D8D0
	// [XID] // 0x000000018979F6B0-0x000000018979F6D0
	public bool GetCameraMoveState() => default; // 0x000000018226DB10-0x000000018226DBD0
	// [XID] // 0x0000000189AE8A30-0x0000000189AE8A50
	protected override void InitVelocityForce() {} // 0x000000018226D990-0x000000018226DA30
}

