/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BaseDialogContext : BaseContext // TypeDefIndex: 28437
{
	// Fields
	public bool attachToPage; // 0x168
	protected bool _autoCloseDialogOnBackEvent; // 0x169

	// Properties
	public BasePageContext pageContext { /* [XID] */ /* 0x0000000189B50250-0x0000000189B50290 */ get; /* [XID] */ /* 0x0000000189B5AA40-0x0000000189B5AA80 */ private set; } // 0x00000001836854A0-0x0000000183685500 0x0000000183685560-0x00000001836855D0

	// Constructors
	protected BaseDialogContext() {} // 0x00000001836858F0-0x0000000183685990

	// Methods
	// [XID] // 0x0000000189B65100-0x0000000189B65120
	public void SetPageContext(BasePageContext context) {} // 0x0000000183685630-0x00000001836857B0
	// [XID] // 0x0000000189B6C6E0-0x0000000189B6C700
	public override void Destroy() {} // 0x0000000183684FF0-0x00000001836851D0
	// [XID] // 0x0000000189B73E70-0x0000000189B73E90
	public override void DestroyForce() {} // 0x0000000183684E10-0x0000000183684FF0
	// [XID] // 0x00000001897DBE40-0x00000001897DBE60
	public virtual void CloseDialog() {} // 0x00000001836851D0-0x0000000183685280
	// [XID] // 0x0000000189B82E60-0x0000000189B82E80
	public override void SetActive(bool enabled) {} // 0x0000000183685810-0x00000001836858F0
	// [XID] // 0x0000000189B8A440-0x0000000189B8A460
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183685390-0x00000001836854A0
	// [XID] // 0x0000000189B91A00-0x0000000189B91A20
	protected override void BindViewCallbacks() {} // 0x0000000183684C50-0x0000000183684E10
}

