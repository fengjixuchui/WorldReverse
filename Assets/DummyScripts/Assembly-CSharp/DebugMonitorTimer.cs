/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class DebugMonitorTimer // TypeDefIndex: 27712
{
	// Fields
	private float _updateTime; // 0x10
	private float _timer; // 0x14
	private bool _enable; // 0x18

	// Properties
	public float updateTime { /* [XID] */ /* 0x0000000189B98E40-0x0000000189B98E60 */ get; /* [XID] */ /* 0x0000000189BA0280-0x0000000189BA02A0 */ set; } // 0x00000001835E45F0-0x00000001835E46A0 0x00000001835E4490-0x00000001835E4540

	// Constructors
	protected DebugMonitorTimer() {} // 0x00000001835E46A0-0x00000001835E4710

	// Methods
	// [XID] // 0x0000000189BA7AA0-0x0000000189BA7AC0
	public virtual void SetEnable(bool value) {} // 0x00000001835E4540-0x00000001835E45F0
	// [XID] // 0x0000000189BAEE30-0x0000000189BAEE50
	public void Tick() {} // 0x00000001835E4390-0x00000001835E4490
	public abstract void Update(bool overtime);
}

