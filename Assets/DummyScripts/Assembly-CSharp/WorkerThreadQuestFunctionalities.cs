/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorkerThreadQuestFunctionalities : WorkerThreadFunctionalities<SharedQuestFunctionalities> // TypeDefIndex: 11398
{
	// Fields
	private readonly List<QuestStatusChange> _delayedStatusChanges; // 0x20

	// Nested types
	private struct QuestStatusChange // TypeDefIndex: 11399
	{
		// Properties
		public uint id { /* [XID] */ /* 0x0000000189A7DC20-0x0000000189A7DC60 */ get; /* [XID] */ /* 0x0000000189A884E0-0x0000000189A88520 */ set; } // 0x0000000183751410-0x0000000183751470 0x00000001837513B0-0x0000000183751410
		public QState state { /* [XID] */ /* 0x0000000189A92CE0-0x0000000189A92D20 */ get; /* [XID] */ /* 0x0000000189A9D340-0x0000000189A9D380 */ set; } // 0x0000000183751350-0x00000001837513B0 0x00000001837512F0-0x0000000183751350
	}

	// Constructors
	public WorkerThreadQuestFunctionalities() {} // Dummy constructor
	public WorkerThreadQuestFunctionalities(WorkerThreadContext context, SharedQuestFunctionalities shared) {} // 0x000000018374B730-0x000000018374B7E0

	// Methods
	// [XID] // 0x0000000189A094F0-0x0000000189A09510
	public override void Init() {} // 0x000000018374AA70-0x000000018374AB10
	// [XID] // 0x0000000189A109E0-0x0000000189A10A00
	public override void Tick(TimeSpan deltaTime) {} // 0x000000018374AB10-0x000000018374ABC0
	// [XID] // 0x0000000189A17FD0-0x0000000189A17FF0
	public override void Destroy() {} // 0x000000018374A8D0-0x000000018374A980
	// [XID] // 0x0000000189A1F630-0x0000000189A1F650
	public void RespondToQuestStatusChange(uint id, QState state) {} // 0x000000018374ADF0-0x000000018374AFB0
	// [XID] // 0x0000000189953BD0-0x0000000189953BF0
	private void TickDelayedStatusChanges() {} // 0x000000018374AFB0-0x000000018374B1B0
	// [IDTag] // 0x0000000189A2E140-0x0000000189A2E180
	// [XID] // 0x0000000189A2E140-0x0000000189A2E180
	private void ExecuteOps(uint questId, QState state) {} // 0x000000018374B630-0x000000018374B730
	// [XID] // 0x0000000189628BC0-0x0000000189628BE0
	private void ExecuteStartOps(uint questId) {} // 0x000000018374ABC0-0x000000018374ACD0
	// [XID] // 0x0000000189A40180-0x0000000189A401A0
	private void ExecuteFinishOps(uint questId) {} // 0x000000018374B1B0-0x000000018374B2C0
	// [XID] // 0x0000000189A47800-0x0000000189A47820
	private ConfigAudioQuestOps GetConfigById(uint questId) => default; // 0x000000018374A980-0x000000018374AA70
	// [IDTag] // 0x0000000189A4EFF0-0x0000000189A4F030
	// [XID] // 0x0000000189A4EFF0-0x0000000189A4F030
	private void ExecuteOps(AudioStateOp[] stateOps, ConfigWwiseString[] eventOps) {} // 0x000000018374B410-0x000000018374B630
	// [XID] // 0x000000018993DA50-0x000000018993DA70
	private void UpdateMusicGameParams(bool start, uint questId) {} // 0x000000018374B2C0-0x000000018374B410
	// [XID] // 0x0000000189A610B0-0x0000000189A610D0
	private void PostMusicStimulus(bool start, uint questId) {} // 0x000000018374ACD0-0x000000018374ADF0
}

