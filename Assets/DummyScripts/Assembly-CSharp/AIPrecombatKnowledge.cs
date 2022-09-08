/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AIPrecombatKnowledge : IAutoAllocRecycle // TypeDefIndex: 19967
{
	// Fields
	public float bioClockSleepFrom; // 0x18
	public float bioClockSleepTo; // 0x1C
	public float lastEatTime; // 0x20
	public Dictionary<ConfigWeatherType, NeuronName[]> weatherNeuronMapping; // 0x28
	public ConfigWeatherType? weather; // 0x30
	public TacticActionPoint? candidateActionPoint; // 0x38
	public TacticActionPoint? executingActionPoint; // 0x50

	// Properties
	public ConfigAIPrecombatSetting config { /* [XID] */ /* 0x0000000189BBF570-0x0000000189BBF5B0 */ get; /* [XID] */ /* 0x0000000189BCA750-0x0000000189BCA790 */ private set; } // 0x000000018401BFB0-0x000000018401C010 0x000000018401B8A0-0x000000018401B900

	// Nested types
	public struct TacticActionPoint // TypeDefIndex: 19968
	{
		// Fields
		public LevelActionPoint levelActionPoint; // 0x00
		public AIMoveSpeedLevel speedLevel; // 0x08
		public uint skillID; // 0x0C
	}

	// Constructors
	public AIPrecombatKnowledge() {} // 0x000000018401C1F0-0x000000018401C280

	// Methods
	[BlackList] // 0x0000000189B8BBA0-0x0000000189B8BBE0
	// [XID] // 0x0000000189B8BBA0-0x0000000189B8BBE0
	public virtual void AutoAllocTypeFields() {} // 0x000000018401B6C0-0x000000018401B760
	[BlackList] // 0x0000000189B95FE0-0x0000000189B96020
	// [XID] // 0x0000000189B95FE0-0x0000000189B96020
	public virtual void AutoRecycleTypeFields() {} // 0x000000018401B760-0x000000018401B8A0
	[BlackList] // 0x0000000189BA04B0-0x0000000189BA04F0
	// [XID] // 0x0000000189BA04B0-0x0000000189BA04F0
	public virtual void ReturnToObjectPool() {} // 0x000000018401C150-0x000000018401C1F0
	[BlackList] // 0x0000000189BAAC00-0x0000000189BAAC40
	// [XID] // 0x0000000189BAAC00-0x0000000189BAAC40
	public virtual void OnPoolAllocated() {} // 0x000000018401C0B0-0x000000018401C150
	[BlackList] // 0x0000000189BB50E0-0x0000000189BB5120
	// [XID] // 0x0000000189BB50E0-0x0000000189BB5120
	public virtual void OnBeforePoolRecycled() {} // 0x000000018401C010-0x000000018401C0B0
	// [XID] // 0x00000001896D7440-0x00000001896D7460
	public void ReInitByConfigID(BaseEntity.ReInitReason reason) {} // 0x000000018401BBB0-0x000000018401BDB0
	// [XID] // 0x0000000189BDC580-0x0000000189BDC5A0
	public void InitPrecombat(ConfigAIPrecombatSetting precombatConfig) {} // 0x000000018401BDB0-0x000000018401BFB0
	// [XID] // 0x00000001895E8E90-0x00000001895E8EB0
	public void StartExecutingActionPoint(BaseEntity executor) {} // 0x000000018401B900-0x000000018401BA70
	// [XID] // 0x00000001895F06E0-0x00000001895F0700
	public void FinishExecutingActionPoint(BaseEntity executor) {} // 0x000000018401BA70-0x000000018401BBB0
}

