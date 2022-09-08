/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CasualState : State<CasualState> // TypeDefIndex: 11327
{
	// Properties
	public override uint audioStateValue { /* [XID] */ /* 0x0000000189665E60-0x0000000189665E80 */ get => default; } // 0x00000001818756F0-0x00000001818757D0 

	// Constructors
	public CasualState() {} // 0x0000000181875B00-0x0000000181875B70

	// Methods
	// [XID] // 0x000000018966D610-0x000000018966D630
	public override void Enter(IContext context) {} // 0x00000001818758E0-0x00000001818759B0
	// [XID] // 0x00000001896755F0-0x0000000189675610
	public override IState Input(Input input) => default; // 0x0000000181875380-0x00000001818754A0
	// [XID] // 0x00000001897AFE10-0x00000001897AFE30
	private IState TryTransitByEnemyStatus(Input input) => default; // 0x00000001818750E0-0x0000000181875280
	// [XID] // 0x0000000189684220-0x0000000189684240
	private IState TryCrossMapArea(Input input) => default; // 0x00000001818757D0-0x00000001818758E0
	// [XID] // 0x000000018968BF30-0x000000018968BF50
	private IState TryCrossCityBlockBoundary(Input input) => default; // 0x0000000181875590-0x0000000181875670
	// [XID] // 0x0000000189693A90-0x0000000189693AB0
	private void SetAreaAndBoundaryStates() {} // 0x00000001818754A0-0x0000000181875590
	// [XID] // 0x000000018969AEB0-0x000000018969AED0
	private void SetAreaState(uint stateValue) {} // 0x0000000181875280-0x0000000181875380
	// [XID] // 0x00000001896A28E0-0x00000001896A2900
	private void SetBoundaryState(string boundaryName) {} // 0x00000001818759B0-0x0000000181875B00
}

