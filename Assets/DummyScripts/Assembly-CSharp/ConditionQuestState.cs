/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct ConditionQuestState : IContextCondition // TypeDefIndex: 29442
{
	// Fields
	public uint questId; // 0x00
	public QuestState state; // 0x04
	public bool match; // 0x08

	// Constructors
	public ConditionQuestState(uint questId, QuestState state, bool match = true /* Metadata: 0x00B0F808 */) {
		this.questId = default;
		this.state = default;
		this.match = default;
	} // 0x0000000181613540-0x0000000181613550

	// Methods
	// [XID] // 0x00000001899A8C90-0x00000001899A8CB0
	public bool Evaluate() => default; // 0x00000001816134B0-0x0000000181613540
}

