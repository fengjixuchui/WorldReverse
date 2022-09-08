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

public class AIEventScheduler // TypeDefIndex: 20448
{
	// Fields
	private Dictionary<Category, UnscheduledQueue> _aiEventQueue; // 0x10
	private static readonly int FIRING_RATE_HIGH; // 0x00
	private static readonly int FIRING_RATE_LOW; // 0x04

	// Nested types
	public enum Category // TypeDefIndex: 20449
	{
		General = 0,
		AlertnessBroadcast = 1
	}

	private class UnscheduledQueue // TypeDefIndex: 20450
	{
		// Fields
		public int capacity; // 0x10
		public Queue<BaseEvent> queue; // 0x18

		// Constructors
		public UnscheduledQueue() {} // Dummy constructor
		public UnscheduledQueue(int capacityPerTick) {} // 0x0000000182C2C8C0-0x0000000182C2C960

		// Methods
		// [XID] // 0x0000000189A8A780-0x0000000189A8A7A0
		public void Enqueue(BaseEvent e) {} // 0x0000000182C2C7F0-0x0000000182C2C8C0
		// [XID] // 0x0000000189A91FC0-0x0000000189A91FE0
		public BaseEvent Dequeue() => default; // 0x0000000182C2C730-0x0000000182C2C7F0
	}

	// Constructors
	public AIEventScheduler() {} // 0x0000000182C259B0-0x0000000182C25B20
	static AIEventScheduler() {} // 0x0000000182C25930-0x0000000182C259B0

	// Methods
	// [XID] // 0x0000000189991920-0x0000000189991940
	public void ScheduleEventSync(BaseEvent e, Category c) {} // 0x0000000182C25830-0x0000000182C25930
	// [XID] // 0x0000000189A44A60-0x0000000189A44A80
	public void Clear() {} // 0x0000000182C25780-0x0000000182C25830
	// [XID] // 0x0000000189A82DE0-0x0000000189A82E00
	public void UpdateScheduler() {} // 0x0000000182C25540-0x0000000182C25780
}

