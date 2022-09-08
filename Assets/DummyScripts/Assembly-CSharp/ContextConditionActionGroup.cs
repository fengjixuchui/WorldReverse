/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct ContextConditionActionGroup // TypeDefIndex: 29459
{
	// Fields
	public IContextCondition condition; // 0x00
	public IContextAction action; // 0x08

	// Constructors
	public ContextConditionActionGroup(IContextCondition[] conditions, IContextAction[] actions) {
		condition = default;
		action = default;
	} // 0x0000000184A8D160-0x0000000184A8D210
	public ContextConditionActionGroup(IContextCondition condition, IContextAction[] actions) {
		this.condition = default;
		action = default;
	} // 0x0000000184A8D000-0x0000000184A8D010
	public ContextConditionActionGroup(IContextCondition[] conditions, IContextAction action) {
		condition = default;
		this.action = default;
	} // 0x0000000184A8D210-0x0000000184A8D240
	public ContextConditionActionGroup(IContextCondition condition, IContextAction action) {
		this.condition = default;
		this.action = default;
	} // 0x0000000184A8D010-0x0000000184A8D160

	// Methods
	// [XID] // 0x0000000189A1FD40-0x0000000189A1FD60
	public bool TryExecute() => default; // 0x0000000184A8CF50-0x0000000184A8D000
}

