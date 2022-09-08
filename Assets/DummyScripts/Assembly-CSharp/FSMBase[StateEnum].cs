/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FSMBase<StateEnum> // TypeDefIndex: 31974
	where StateEnum : struct, IComparable, IFormattable, IConvertible
{
	// Fields
	public StateEnum state;
	public StateEnum nextState;
	public EnterStateDelegate preEnterStateFunc;
	public LeaveStateDelegate leaveStateFunc;
	public UpdateStateDelegate updateStateFunc;
	private float delayTime;

	// Nested types
	public delegate void EnterStateDelegate(StateEnum state); // TypeDefIndex: 31975; 0x00000000-0x00000000

	public delegate void LeaveStateDelegate(StateEnum state); // TypeDefIndex: 31976; 0x00000000-0x00000000

	public delegate void UpdateStateDelegate(StateEnum state); // TypeDefIndex: 31977; 0x00000000-0x00000000

	// Constructors
	public FSMBase() {}

	// Methods
	public void InitilizeState(StateEnum initState) {}
	public void FinilizeState() {}
	public void UpdateFSM() {}
	private void DochangeMode(StateEnum s) {}
	private void EnterState(StateEnum state) {}
	protected void LeaveState(StateEnum state) {}
	protected void UpdateState(StateEnum state) {}
	protected virtual void UpdateStateChange() {}
	public virtual void SetState(StateEnum s, float delay = 0.001f /* Metadata: 0x00B13A72 */) {}
}

