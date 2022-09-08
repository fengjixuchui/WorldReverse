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

public struct ConditionChapterQuestState : IContextCondition // TypeDefIndex: 29445
{
	// Fields
	public uint chapterId; // 0x00
	public QuestState state; // 0x04
	public bool startOrEndQuest; // 0x08

	// Constructors
	public ConditionChapterQuestState(uint chapterId, QuestState state, bool startOrEndQuest) {
		this.chapterId = default;
		this.state = default;
		this.startOrEndQuest = default;
	} // 0x0000000181953360-0x0000000181953370

	// Methods
	// [XID] // 0x00000001899BF280-0x00000001899BF2A0
	public bool Evaluate() => default; // 0x00000001819532D0-0x0000000181953360
}

