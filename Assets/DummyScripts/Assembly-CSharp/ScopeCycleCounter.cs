/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct ScopeCycleCounter : IDisposable // TypeDefIndex: 27864
{
	// Fields
	public CycleStat cycleStat; // 0x00
	public EntityManager.TickType tickType; // 0x08
	public long startTick; // 0x10
	public ComponentManager.HandleEventActionType handleType; // 0x18
	public uint handleCount; // 0x1C
	private static Dictionary<ComponentManager.HandleEventActionType, string> eventTypeToNameMap; // 0x00

	// Properties
	private bool isHandleEventMode { /* [XID] */ /* 0x000000018993AAB0-0x000000018993AAD0 */ get => default; } // 0x0000000183ADA630-0x0000000183ADA640 

	// Nested types
	public class HandleEventActionTypeComparer : IEqualityComparer<ComponentManager.HandleEventActionType> // TypeDefIndex: 27865
	{
		// Constructors
		public HandleEventActionTypeComparer() {} // 0x0000000183AD0590-0x0000000183AD05F0

		// Methods
		// [XID] // 0x0000000189A5EA40-0x0000000189A5EA60
		public bool Equals(ComponentManager.HandleEventActionType x, ComponentManager.HandleEventActionType y) => default; // 0x0000000183AD0410-0x0000000183AD04E0
		// [XID] // 0x0000000189A66180-0x0000000189A661A0
		public int GetHashCode(ComponentManager.HandleEventActionType obj) => default; // 0x0000000183AD04E0-0x0000000183AD0590
	}

	// Constructors
	public ScopeCycleCounter(CycleStat inStat, EntityManager.TickType inTickType) : this() {
		cycleStat = default;
		tickType = default;
		startTick = default;
		handleType = default;
		handleCount = default;
	} // 0x0000000183ADAE70-0x0000000183ADAEA0
	public ScopeCycleCounter(string tickModuleName, BaseManager inManager, EntityManager.TickType inTickType) : this() {
		cycleStat = default;
		tickType = default;
		startTick = default;
		handleType = default;
		handleCount = default;
	} // 0x0000000183ADA7A0-0x0000000183ADA870
	public ScopeCycleCounter(string tickModuleName, EntityManager inManager, EntityManager.TickType inTickType) : this() {
		cycleStat = default;
		tickType = default;
		startTick = default;
		handleType = default;
		handleCount = default;
	} // 0x0000000183ADA870-0x0000000183ADA940
	public ScopeCycleCounter(string tickModuleName, MonoBehaviour inBehaviour, EntityManager.TickType inTickType) : this() {
		cycleStat = default;
		tickType = default;
		startTick = default;
		handleType = default;
		handleCount = default;
	} // 0x0000000183ADAA10-0x0000000183ADAC00
	public ScopeCycleCounter(string tickModuleName, IThreadTask inTask, EntityManager.TickType inTickType) : this() {
		cycleStat = default;
		tickType = default;
		startTick = default;
		handleType = default;
		handleCount = default;
	} // 0x0000000183ADACD0-0x0000000183ADAE70
	public ScopeCycleCounter(string tickModuleName, object inTask, EntityManager.TickType inTickType) : this() {
		cycleStat = default;
		tickType = default;
		startTick = default;
		handleType = default;
		handleCount = default;
	} // 0x0000000183ADA940-0x0000000183ADAA10
	public ScopeCycleCounter(CycleStat inStat, ComponentManager.HandleEventActionType inHandleType) : this() {
		cycleStat = default;
		tickType = default;
		startTick = default;
		handleType = default;
		handleCount = default;
	} // 0x0000000183ADAC00-0x0000000183ADACD0
	static ScopeCycleCounter() {
		eventTypeToNameMap = default;
	} // 0x0000000183ADA640-0x0000000183ADA7A0

	// Methods
	// [XID] // 0x0000000189A0CA50-0x0000000189A0CA70
	private static void ConditionalFlushCycleStat(CycleStat inStat) {} // 0x0000000183AD8F00-0x0000000183AD9170
	// [XID] // 0x0000000189A14380-0x0000000189A143A0
	private void Init(CycleStat inStat, EntityManager.TickType inTickType) {} // 0x0000000183ADA150-0x0000000183ADA330
	// [XID] // 0x0000000189A1B630-0x0000000189A1B650
	private static bool ShouldSampleStat(int cycleStatOwnerType, ComponentManager.HandleEventActionType inHEAT = ComponentManager.HandleEventActionType.None /* Metadata: 0x00B0D0B2 */) => default; // 0x0000000183AD9180-0x0000000183AD93B0
	// [XID] // 0x0000000189A23000-0x0000000189A23020
	private void InitWithCreatedCycleStat(string tickModuleName, int targetSOT, object owner, EntityManager.TickType inTickType) {} // 0x0000000183ADA570-0x0000000183ADA630
	// [XID] // 0x0000000189A316A0-0x0000000189A316C0
	private string GetHandleEventActionTypeName(ComponentManager.HandleEventActionType inType) => default; // 0x0000000183ADA330-0x0000000183ADA340
	// [XID] // 0x0000000189757630-0x0000000189757650
	public void IncreaseHandleCount() {} // 0x0000000183AD93B0-0x0000000183AD93C0
	// [XID] // 0x000000018990A720-0x000000018990A740
	public static double GetDeltaMilliseconds(long inStartTick) => default; // 0x0000000183ADA340-0x0000000183ADA570
	// [XID] // 0x0000000189A47FD0-0x0000000189A47FF0
	public static double GetDeltaSeconds(long inStartTick) => default; // 0x0000000183AD93C0-0x0000000183AD9DD0
	// [XID] // 0x0000000189A4F7F0-0x0000000189A4F810
	private double ConditionalStatComponentExecution() => default; // 0x0000000183AD9170-0x0000000183AD9180
	// [XID] // 0x00000001898C3790-0x00000001898C37B0
	public void Dispose() {} // 0x0000000183AD9DD0-0x0000000183ADA150
}

