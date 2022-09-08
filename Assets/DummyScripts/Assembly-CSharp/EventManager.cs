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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EventManager : InLevelManager // TypeDefIndex: 20820
{
	// Fields
	private Dictionary<uint, Dictionary<System.Type, ListenerRegistry>> _runtimeId2ListenerDic; // 0x10
	private List<BaseEvent> _queuedFrameEvents; // 0x18
	private List<BaseEvent> _queuedNextEvents; // 0x20
	private List<BaseEvent> _queuedNextEventsToAdd; // 0x28
	private Dictionary<System.Type, IndexHandleObjectList<ListenerRegistry>> _evtListeners; // 0x30
	private bool _isStopped; // 0x38
	public Action<BaseEvent, int> onDispatchEvent; // 0x40
	public Action<BaseEvent, int> onDispatchEvent2; // 0x48
	private bool _dispatchPaused; // 0x50

	// Nested types
	private class ListenerRegistry // TypeDefIndex: 20821
	{
		// Fields
		public uint listenerID; // 0x10
		public uint listenTargetID; // 0x14
		public uint registerCount; // 0x18
		public int index; // 0x1C
		public ListenerRegistry preRegistry; // 0x20
		public ListenerRegistry nextRegistry; // 0x28

		// Constructors
		public ListenerRegistry() {} // 0x00000001845C64A0-0x00000001845C6520

		// Methods
		// [XID] // 0x0000000189940C60-0x0000000189940C80
		public static ListenerRegistry Create(uint listenerID, uint targetID = 0 /* Metadata: 0x00AFE569 */) => default; // 0x00000001845C6300-0x00000001845C63E0
		// [XID] // 0x0000000189948620-0x0000000189948640
		public static void Release(ListenerRegistry listener) {} // 0x00000001845C63E0-0x00000001845C64A0
		// [XID] // 0x000000018994FDB0-0x000000018994FDD0
		public void Init(uint listenerID, uint targetID = 0 /* Metadata: 0x00AFE56D */) {} // 0x00000001845C6170-0x00000001845C6250
		// [XID] // 0x0000000189957360-0x0000000189957380
		public void Clear() {} // 0x00000001845C6250-0x00000001845C6300
	}

	public enum DispatchType // TypeDefIndex: 20822
	{
		ALL = 0,
		FRAME = 1,
		NEXT = 2
	}

	// Constructors
	private EventManager() {} // 0x00000001845AB280-0x00000001845AB3C0

	// Methods
	// [XID] // 0x000000018989BD80-0x000000018989BDA0
	private void RegisterListenerWithRuntimeId(System.Type type, ListenerRegistry listener) {} // 0x00000001845A96D0-0x00000001845A98C0
	// [XID] // 0x00000001898A3260-0x00000001898A3280
	private void RemoveListenerWithRuntimeId(System.Type type, ListenerRegistry listener) {} // 0x00000001845A8580-0x00000001845A8B20
	// [XID] // 0x00000001898AA6A0-0x00000001898AA6C0
	private ListenerRegistry GetListenerWithRuntimeId(System.Type type, uint listenerId, uint targetId) => default; // 0x00000001845AB080-0x00000001845AB1E0
	// [XID] // 0x00000001898B2150-0x00000001898B2170
	public void OnRuntimeIDRetarget(uint oldID, uint newID) {} // 0x00000001845AA910-0x00000001845AAB70
	// [XID] // 0x00000001898B9E40-0x00000001898B9E60
	private void ClearEventListeners() {} // 0x00000001845A9E30-0x00000001845AA1D0
	// [XID] // 0x00000001898C11A0-0x00000001898C11C0
	public override void Init() {} // 0x00000001845A9A20-0x00000001845A9AC0
	// [XID] // 0x00000001898C8A80-0x00000001898C8AA0
	public override void Tick() {} // 0x00000001845AB1E0-0x00000001845AB280
	// [XID] // 0x00000001898D0480-0x00000001898D04A0
	private void AddEventToQueue(BaseEvent evt) {} // 0x00000001845AA1D0-0x00000001845AA350
	// [XID] // 0x00000001898D7A80-0x00000001898D7AA0
	public void DisptachEvents(DispatchType type) {} // 0x00000001845A8C00-0x00000001845A8E60
	// [XID] // 0x00000001898DF750-0x00000001898DF770
	private void DispatchEventQueue(List<BaseEvent> queueEvents) {} // 0x00000001845AAC70-0x00000001845AAE90
	// [XID] // 0x00000001898E71B0-0x00000001898E71D0
	private void DispatchEventOnce(BaseEvent evt) {} // 0x00000001845A9AC0-0x00000001845A9E30
	// [XID] // 0x00000001898EE9A0-0x00000001898EE9C0
	public override void Destroy() {} // 0x00000001845A9560-0x00000001845A9620
	// [XID] // 0x00000001898F61A0-0x00000001898F61C0
	private bool DispatchEvent(BaseEvent evt) => default; // 0x00000001845AA470-0x00000001845AA910
	// [XID] // 0x00000001898FDA20-0x00000001898FDA40
	private void HandleEventsUnResolved(BaseEntity entity, BaseEvent evt) {} // 0x00000001845A9330-0x00000001845A9560
	// [XID] // 0x0000000189905240-0x0000000189905260
	private void HandleEventsResolved(BaseEntity entity, BaseEvent evt) {} // 0x00000001845A9920-0x00000001845A9A20
	// [XID] // 0x000000018990CA50-0x000000018990CA70
	private void DispatchListenEvent(BaseEvent evt) {} // 0x00000001845A8E60-0x00000001845A9240
	// [XID] // 0x0000000189739660-0x0000000189739680
	private void DebugLogEvent(BaseEvent evt) {} // 0x00000001845A8B20-0x00000001845A8C00
	// [XID] // 0x000000018991BCC0-0x000000018991BCE0
	private string GetDebugEventString(BaseEvent evt) => default; // 0x00000001845AAE90-0x00000001845AB080
	// [XID] // 0x00000001899232E0-0x0000000189923300
	public void FireEvent(BaseEvent evt, bool immediately = false /* Metadata: 0x00AFE560 */) {} // 0x00000001845AA350-0x00000001845AA470
	public void RegisterEventListener<T>(uint id, uint targetId = 0 /* Metadata: 0x00AFE561 */) {}
	public void RemoveEventListener<T>(uint id, uint targetId = 0 /* Metadata: 0x00AFE565 */) {}
	// [XID] // 0x000000018992AAA0-0x000000018992AAC0
	public void DropEventsAndStop() {} // 0x00000001845A9240-0x00000001845A9330
	// [XID] // 0x00000001899320E0-0x0000000189932100
	public void SetPauseDispatching(bool paused) {} // 0x00000001845AAB70-0x00000001845AAC70
	// [XID] // 0x0000000189939A70-0x0000000189939A90
	private void InjectEvent(BaseEvent evt) {} // 0x00000001845A9620-0x00000001845A96D0
}

