/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ExUICameraBaseState // TypeDefIndex: 30621
{
	// Fields
	protected MonoExUICamera _sm; // 0x10
	protected State _state; // 0x18

	// Properties
	public State state { /* [XID] */ /* 0x0000000189B5F190-0x0000000189B5F1B0 */ get => default; } // 0x000000018491FFD0-0x0000000184920070 

	// Nested types
	public enum State // TypeDefIndex: 30622
	{
		None = 0,
		Damping = 1,
		Focus = 2,
		Idle = 3,
		Recover = 4,
		Swipe = 5,
		ZoomDamping = 6,
		ZoomRecover = 7
	}

	// Constructors
	public ExUICameraBaseState() {} // 0x0000000184920690-0x0000000184920700

	// Methods
	// [XID] // 0x0000000189B66760-0x0000000189B66780
	public virtual void Update() {} // 0x00000001849201C0-0x0000000184920260
	// [XID] // 0x0000000189B6DD00-0x0000000189B6DD20
	public virtual void Enter(ExUICameraBaseState lastState, object param = null) {} // 0x0000000184920470-0x0000000184920530
	// [XID] // 0x0000000189B75390-0x0000000189B753B0
	public virtual void Exit(ExUICameraBaseState nextState) {} // 0x0000000184920310-0x00000001849203C0
	// [XID] // 0x0000000189B7C800-0x0000000189B7C820
	public virtual void OnSwipeStart(Gesture gesture) {} // 0x000000018491FE70-0x000000018491FF20
	// [XID] // 0x0000000189B84640-0x0000000189B84660
	public virtual void OnSwipe(Gesture gesture) {} // 0x00000001849205E0-0x0000000184920690
	// [XID] // 0x0000000189B8B4B0-0x0000000189B8B4D0
	public virtual void OnSwipeEnd(Gesture gesture) {} // 0x0000000184920530-0x00000001849205E0
	// [XID] // 0x0000000189B92BE0-0x0000000189B92C00
	public virtual void OnPinchStart(Gesture gesture) {} // 0x0000000184920110-0x00000001849201C0
	// [XID] // 0x0000000189B9A1C0-0x0000000189B9A1E0
	public virtual void OnPinchIn(Gesture gesture) {} // 0x00000001849203C0-0x0000000184920470
	// [XID] // 0x0000000189BA18D0-0x0000000189BA18F0
	public virtual void OnPinchOut(Gesture gesture) {} // 0x000000018491FF20-0x000000018491FFD0
	// [XID] // 0x0000000189BA8CF0-0x0000000189BA8D10
	public virtual void OnPinchEnd(Gesture gesture) {} // 0x0000000184920260-0x0000000184920310
	// [XID] // 0x0000000189BB0440-0x0000000189BB0460
	public virtual void Clear() {} // 0x0000000184920070-0x0000000184920110
}

