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

public class VCMoveCollider // TypeDefIndex: 32181
{
	// Fields
	protected bool _enabled; // 0x10
	protected bool _enableAir; // 0x11
	protected bool _passThrough; // 0x12
	protected Collider[] _moveCols; // 0x18
	protected Collider[] _pushCols; // 0x20
	protected Collider[] _pushColsExtra; // 0x28
	private float _radius; // 0x30

	// Properties
	public Collider[] moveCols { /* [XID] */ /* 0x00000001897EAF20-0x00000001897EAF40 */ get => default; } // 0x00000001812090E0-0x0000000181209180 
	public Collider[] pushCols { /* [XID] */ /* 0x0000000189A376D0-0x0000000189A376F0 */ get => default; } // 0x0000000181209040-0x00000001812090E0 
	public Collider[] pushColsExtra { /* [XID] */ /* 0x0000000189618100-0x0000000189618120 */ get => default; } // 0x0000000181209420-0x00000001812094C0 
	public virtual Collider airDummyMoveCol { /* [XID] */ /* 0x00000001896A2900-0x00000001896A2920 */ get => default; } // 0x0000000181208B70-0x0000000181208C10 
	public float radius { /* [XID] */ /* 0x0000000189A73540-0x0000000189A73560 */ get => default; } // 0x0000000181209370-0x0000000181209420 

	// Constructors
	public VCMoveCollider() {} // Dummy constructor
	public VCMoveCollider(Collider[] moveCols, Collider[] pushCols, Collider[] pushColsExtra, float radius) {} // 0x0000000181209570-0x0000000181209670

	// Methods
	// [XID] // 0x0000000189726120-0x0000000189726140
	public virtual void SetMoveColEnabled(bool enabled) {} // 0x0000000181209180-0x0000000181209370
	// [XID] // 0x000000018970E270-0x000000018970E290
	public virtual void SetMoveColToTrigger(bool isTrigger) {} // 0x0000000181208C10-0x0000000181208D90
	// [XID] // 0x0000000189A5CD30-0x0000000189A5CD50
	public virtual void SetPassThroughCharacter(bool passThrough) {} // 0x0000000181208E30-0x0000000181209040
	// [XID] // 0x0000000189A645C0-0x0000000189A645E0
	public virtual void SetAirColEnable(bool enabled) {} // 0x00000001812094C0-0x0000000181209570
	// [XID] // 0x0000000189A6BE80-0x0000000189A6BEA0
	public bool CanPassThroughCharacter() => default; // 0x0000000181208D90-0x0000000181208E30
}

