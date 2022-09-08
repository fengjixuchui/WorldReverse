/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExDrivenAudioEvents3D : ExDrivenAudioEvents // TypeDefIndex: 11020
{
	// Fields
	private readonly MultiPositionEvent _multiPositionEvent; // 0x68
	private readonly bool _enableSpatial; // 0x70
	private OngoingMultiPositionEvent _ongoingMultiPositionEvent; // 0x78
	private float _timeScale; // 0x80

	// Properties
	protected override float timeScale { /* [XID] */ /* 0x00000001896F37E0-0x00000001896F3800 */ get => default; } // 0x000000018402F020-0x000000018402F0D0 

	// Nested types
	[Serializable]
	public class DurableEvent : ExDrivenAudioEvents.Event // TypeDefIndex: 11021
	{
		// Fields
		public float duration; // 0x30

		// Constructors
		public DurableEvent() {} // 0x0000000184044040-0x00000001840440A0
	}

	[Serializable]
	public class MultiPositionEvent : ExDrivenAudioEvents.Event // TypeDefIndex: 11022
	{
		// Fields
		public int auxGoIndex; // 0x30
		public float radius; // 0x34
		public string stopper; // 0x38
		private uint _stopperHashId; // 0x40
		private bool _hasConvertedStopper; // 0x44

		// Properties
		public uint stopperHashId { /* [XID] */ /* 0x0000000189851BA0-0x0000000189851BC0 */ get => default; } // 0x0000000184044100-0x0000000184044220 

		// Constructors
		public MultiPositionEvent() {} // 0x00000001840440A0-0x0000000184044100
	}

	private static class MultiPositionEventPlayer // TypeDefIndex: 11023
	{
		// Fields
		private static readonly EventCallback _eventCallback; // 0x00

		// Constructors
		static MultiPositionEventPlayer() {} // 0x0000000184044DE0-0x0000000184045190

		// Methods
		// [XID] // 0x0000000189883790-0x00000001898837B0
		public static OngoingMultiPositionEvent Play(ExDrivenAudioEvents3D host, MultiPositionEvent @event) => default; // 0x0000000184044960-0x0000000184044DE0
		// [XID] // 0x000000018988AFD0-0x000000018988AFF0
		public static void Stop(OngoingMultiPositionEvent multiPositionEvent) {} // 0x0000000184044370-0x00000001840446A0
		// [XID] // 0x0000000189702570-0x0000000189702590
		public static void ClearOnStageExit() {} // 0x00000001840446A0-0x0000000184044730
		// [XID] // 0x00000001899436D0-0x00000001899436F0
		private static void EventCallback(object cookie, AkCallbackType type, MmoronCallbackInfo info) {} // 0x0000000184044730-0x0000000184044960
	}

	// Constructors
	public ExDrivenAudioEvents3D() {} // Dummy constructor
	public ExDrivenAudioEvents3D(MonoBehaviour mono, GameObject[] placeholders, TimedEvent[] tickEvents, Event[] enableEvents, Event[] disableEvents, MultiPositionEvent multiPositionEvent, bool enableSpatial) {} // 0x00000001840300B0-0x00000001840301A0

	// Methods
	// [XID] // 0x000000018981C6E0-0x000000018981C700
	public static void ClearOnStageExit() {} // 0x000000018402EE00-0x000000018402EEC0
	// [XID] // 0x0000000189823BE0-0x0000000189823C00
	public override void Enable() {} // 0x000000018402EEC0-0x000000018402EF70
	// [XID] // 0x0000000189819BE0-0x0000000189819C00
	public override void Disable() {} // 0x000000018402FF50-0x0000000184030000
	// [XID] // 0x00000001898329E0-0x0000000189832A00
	public override void Tick() {} // 0x000000018402F5A0-0x000000018402F650
	// [XID] // 0x0000000189880E90-0x0000000189880EB0
	public void SetTimeScale(float value) {} // 0x0000000184030000-0x00000001840300B0
	// [XID] // 0x0000000189841520-0x0000000189841540
	public void PostDurableEvents(DurableEvent[] events) {} // 0x000000018402F400-0x000000018402F5A0
	// [XID] // 0x0000000189848A00-0x0000000189848A20
	protected override void PostEvent(Event e) {} // 0x000000018402F710-0x000000018402F930
	// [XID] // 0x000000018988F840-0x000000018988F860
	private void PostOneTimeEvent(DurableEvent e) {} // 0x000000018402F0D0-0x000000018402F400
	// [XID] // 0x0000000189857540-0x0000000189857560
	private void PostMultiPositionEvent() {} // 0x000000018402FA50-0x000000018402FB30
	// [XID] // 0x0000000189872100-0x0000000189872120
	private void TickMultiPositionEvent() {} // 0x000000018402EF70-0x000000018402F020
	// [XID] // 0x0000000189865F70-0x0000000189865F90
	private void StopMultiPositionEvent() {} // 0x000000018402FDB0-0x000000018402FE90
	// [XID] // 0x000000018986D670-0x000000018986D690
	protected override void RegisterSyncs() {} // 0x000000018402F930-0x000000018402F9E0
	// [XID] // 0x0000000189874BB0-0x0000000189874BD0
	private void RegisterSpatialSyncs() {} // 0x000000018402FB30-0x000000018402FDB0
}

