/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MoveVelocityForce // TypeDefIndex: 14685
{
	// Fields
	protected BaseEntity owner; // 0x18
	public int priority; // 0x20
	public float attenuation; // 0x24
	public bool ignoreAirGY; // 0x38
	protected float _vOnStart; // 0x3C
	protected float _startedTime; // 0x40
	public bool isInAir; // 0x44

	// Properties
	public VelocityForceType forceType { get; /* [XID] */ /* 0x0000000189BD9CD0-0x0000000189BD9D10 */ protected set; } // 0x000000018498C760-0x000000018498C7C0 0x000000018498D140-0x000000018498D1A0
	public float v { /* [XID] */ /* 0x00000001895E9A60-0x00000001895E9AA0 */ get; /* [XID] */ /* 0x00000001895F4090-0x00000001895F40D0 */ protected set; } // 0x000000018498C900-0x000000018498C970 0x000000018498CEA0-0x000000018498CF10
	public Vector3 direction { /* [XID] */ /* 0x00000001895FE790-0x00000001895FE7D0 */ get; /* [XID] */ /* 0x00000001896092A0-0x00000001896092E0 */ protected set; } // 0x000000018498CF80-0x000000018498CFF0 0x000000018498CF10-0x000000018498CF80

	// Constructors
	public MoveVelocityForce() {} // 0x000000018498D530-0x000000018498D5A0
	public MoveVelocityForce(VelocityForceType forceType, int priority) {} // 0x000000018498D5A0-0x000000018498D640

	// Methods
	public static T Allocate<T>(VelocityForceType forceType, int priority)
		where T : MoveVelocityForce, new() => default;
	// [XID] // 0x0000000189613860-0x0000000189613880
	public virtual void Init(VelocityForceType forceType, int priority) {} // 0x000000018498C7C0-0x000000018498C900
	// [XID] // 0x000000018961B0D0-0x000000018961B0F0
	public void setOwner(BaseEntity entity) {} // 0x000000018498D090-0x000000018498D140
	// [IDTag] // 0x00000001896225C0-0x0000000189622600
	// [XID] // 0x00000001896225C0-0x0000000189622600
	public virtual void SetForce(Vector3 dir, float attenuation) {} // 0x000000018498CC30-0x000000018498CE00
	// [IDTag] // 0x000000018962CDF0-0x000000018962CE30
	// [XID] // 0x000000018962CDF0-0x000000018962CE30
	public virtual void SetForce(Vector3 dir, float attenuation, Vector3 targetPos, HashSet<int> animatorStateIDs, bool needSetIsInAir, bool disableForceByAnimFirstFrame, bool checkAnimatorStateOnExitOnly) {} // 0x000000018498C970-0x000000018498CC30
	// [XID] // 0x0000000189637BC0-0x0000000189637BE0
	public virtual bool OnEvent(BaseEvent evt) => default; // 0x000000018498D1A0-0x000000018498D250
	// [XID] // 0x000000018963EE30-0x000000018963EE50
	public virtual void OnMove(float inDeltaTime, float ownerTimeScale) {} // 0x000000018498D250-0x000000018498D390
	// [XID] // 0x0000000189646740-0x0000000189646760
	public virtual bool IsInForce() => default; // 0x000000018498D480-0x000000018498D530
	// [XID] // 0x000000018964DEE0-0x000000018964DF00
	public virtual bool IsPositiveForce() => default; // 0x000000018498CFF0-0x000000018498D090
	// [XID] // 0x0000000189655750-0x0000000189655770
	public virtual void Stop() {} // 0x000000018498C680-0x000000018498C760
	// [XID] // 0x000000018965CF20-0x000000018965CF40
	public virtual void Clear() {} // 0x000000018498CE00-0x000000018498CEA0
	// [XID] // 0x0000000189B3AB70-0x0000000189B3AB90
	public virtual bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x000000018498D390-0x000000018498D480
}

