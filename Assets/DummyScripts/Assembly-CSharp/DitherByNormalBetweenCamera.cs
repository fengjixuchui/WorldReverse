/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DitherByNormalBetweenCamera : BaseDither // TypeDefIndex: 32047
{
	// Fields
	private VCStackCamera _cameraStack; // 0x10
	private BaseEntity _entity; // 0x18
	protected float _detectRange; // 0x20
	private bool _useHitBox; // 0x24

	// Properties
	protected virtual float DetechRange { /* [XID] */ /* 0x0000000189BA4770-0x0000000189BA4790 */ get => default; } // 0x00000001810F5150-0x00000001810F5200 
	protected virtual float DitherMinRange { /* [XID] */ /* 0x0000000189BABAB0-0x0000000189BABAD0 */ get => default; } // 0x00000001810F5B70-0x00000001810F5C70 
	protected virtual float DitherMaxRange { /* [XID] */ /* 0x0000000189BB31A0-0x0000000189BB31C0 */ get => default; } // 0x00000001810F4FB0-0x00000001810F50B0 

	// Constructors
	public DitherByNormalBetweenCamera() {} // Dummy constructor
	public DitherByNormalBetweenCamera(BaseEntity entity, float detectRange, bool useHitBox) {} // 0x00000001810F5C70-0x00000001810F5D70

	// Methods
	// [XID] // 0x0000000189BBA740-0x0000000189BBA760
	public override void Destroy() {} // 0x00000001810F50B0-0x00000001810F5150
	// [XID] // 0x0000000189BC27A0-0x0000000189BC27C0
	public override float UpdateDither(float inDeltaTime) => default; // 0x00000001810F5200-0x00000001810F5B70
}

