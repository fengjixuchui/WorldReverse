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

public sealed class MEventMgr : GlobalManager // TypeDefIndex: 21169
{
	// Fields
	private MGlobalEventDispathcher _globalEvent; // 0x10

	// Nested types
	private class DoDelayDispatchHandle : TimerManager.TimerEventHandler // TypeDefIndex: 21170
	{
		// Fields
		private Action<float, IEventDispatcher<BaseEvent>, BaseEvent> _func; // 0x20
		private IEventDispatcher<BaseEvent> _dispatcher; // 0x28
		private BaseEvent _event; // 0x30

		// Properties
		public override bool autoRecycle { /* [XID] */ /* 0x0000000189BC42A0-0x0000000189BC42C0 */ get => default; } // 0x00000001831A48C0-0x00000001831A4960 

		// Constructors
		public DoDelayDispatchHandle() {} // 0x00000001831A4860-0x00000001831A48C0

		// Methods
		// [XID] // 0x0000000189BBC640-0x0000000189BBC660
		public void Refine(Action<float, IEventDispatcher<BaseEvent>, BaseEvent> func, IEventDispatcher<BaseEvent> dispatcher, BaseEvent @event) {} // 0x00000001831A45F0-0x00000001831A46E0
		// [XID] // 0x0000000189BCBC40-0x0000000189BCBC60
		protected override bool Invoke(float delay) => default; // 0x00000001831A46E0-0x00000001831A47A0
		// [XID] // 0x0000000189BD3190-0x0000000189BD31B0
		public override void Recycle() {} // 0x00000001831A47A0-0x00000001831A4860
	}

	// Constructors
	public MEventMgr() {} // 0x000000018318E2C0-0x000000018318E350

	// Methods
	// [XID] // 0x0000000189B72AB0-0x0000000189B72AD0
	public override void Init() {} // 0x000000018318DFB0-0x000000018318E050
	// [XID] // 0x0000000189B7A030-0x0000000189B7A050
	public override void Destroy() {} // 0x000000018318DD80-0x000000018318DE20
	// [XID] // 0x0000000189B81790-0x0000000189B817B0
	public override void ReloadRes() {} // 0x000000018318E220-0x000000018318E2C0
	// [XID] // 0x0000000189B88E30-0x0000000189B88E50
	public void FireEvent(IEventDispatcher<BaseEvent> firer, BaseEvent args = null) {} // 0x000000018318E140-0x000000018318E220
	// [XID] // 0x0000000189B90380-0x0000000189B903A0
	public void FireGlobalEvent(BaseEvent args = null) {} // 0x000000018318DEE0-0x000000018318DFB0
	public void RegisterGlobalEvent<T>(Action<T> eventHandler)
		where T : BaseEvent {}
	public void RemoveGlobalEvent<T>(Action<T> eventHandler)
		where T : BaseEvent {}
	// [XID] // 0x0000000189B977F0-0x0000000189B97810
	public uint FireEventDelay(IEventDispatcher<BaseEvent> firer, float delay, BaseEvent args) => default; // 0x000000018318DA30-0x000000018318DBF0
	// [XID] // 0x0000000189B9EC50-0x0000000189B9EC70
	public void CancelDelayEvent(uint token) {} // 0x000000018318DBF0-0x000000018318DCE0
	// [XID] // 0x0000000189BA6560-0x0000000189BA6580
	public void Clear() {} // 0x000000018318DE20-0x000000018318DEE0
	// [XID] // 0x0000000189BAD880-0x0000000189BAD8A0
	private void dispatchDelayEvent(float delay, IEventDispatcher<BaseEvent> evetDispathcer, BaseEvent e) {} // 0x000000018318E050-0x000000018318E140
	// [XID] // 0x0000000189BB5000-0x0000000189BB5020
	public override void ClearOnLevelDestroy() {} // 0x000000018318DCE0-0x000000018318DD80
}

