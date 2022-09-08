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

public sealed class ExUICameraRecoverState : ExUICameraBaseState // TypeDefIndex: 30627
{
	// Fields
	private RecoverType _type; // 0x20

	// Nested types
	public enum RecoverType // TypeDefIndex: 30628
	{
		Hard = 0,
		Soft = 1
	}

	// Constructors
	public ExUICameraRecoverState() {} // Dummy constructor
	public ExUICameraRecoverState(MonoExUICamera sm) {} // 0x00000001825ABED0-0x00000001825ABF50

	// Methods
	// [XID] // 0x000000018962D660-0x000000018962D680
	public override void Enter(ExUICameraBaseState lastState, object param = null) {} // 0x00000001825ABD60-0x00000001825ABE50
	// [XID] // 0x0000000189635220-0x0000000189635240
	public override void Update() {} // 0x00000001825ABB20-0x00000001825ABC10
	// [XID] // 0x000000018963C8A0-0x000000018963C8C0
	public override void OnSwipeStart(Gesture gesture) {} // 0x00000001825AB810-0x00000001825AB8E0
	// [XID] // 0x0000000189643FA0-0x0000000189643FC0
	public override void OnPinchStart(Gesture gesture) {} // 0x00000001825ABA00-0x00000001825ABB20
	// [XID] // 0x000000018964B750-0x000000018964B770
	public override void Clear() {} // 0x00000001825AB960-0x00000001825ABA00
}

