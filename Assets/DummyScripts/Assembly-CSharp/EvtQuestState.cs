/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtQuestState : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20147
{
	// Fields
	public uint questId; // 0x30
	public QuestState state; // 0x34

	// Constructors
	public EvtQuestState() {} // 0x00000001820720F0-0x0000000182072150

	// Methods
	[BlackList] // 0x0000000189B9C0C0-0x0000000189B9C100
	// [XID] // 0x0000000189B9C0C0-0x0000000189B9C100
	public override void AutoAllocTypeFields() {} // 0x0000000182071BB0-0x0000000182071C50
	[BlackList] // 0x0000000189BA6620-0x0000000189BA6660
	// [XID] // 0x0000000189BA6620-0x0000000189BA6660
	public override void AutoRecycleTypeFields() {} // 0x0000000182071C50-0x0000000182071D00
	[BlackList] // 0x0000000189BB0C10-0x0000000189BB0C50
	// [XID] // 0x0000000189BB0C10-0x0000000189BB0C50
	public override void ReturnToObjectPool() {} // 0x0000000182071F70-0x0000000182072010
	// [XID] // 0x0000000189BBAF20-0x0000000189BBAF40
	public void Init(uint id, QuestState st) {} // 0x0000000182071DD0-0x0000000182071EB0
	// [XID] // 0x0000000189BC2F10-0x0000000189BC2F30
	public override string ToString() => default; // 0x0000000182072010-0x00000001820720F0
}

