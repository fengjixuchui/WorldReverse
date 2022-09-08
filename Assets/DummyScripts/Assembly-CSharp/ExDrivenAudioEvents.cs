/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class ExDrivenAudioEvents : IAudioUnityMessageReceiver // TypeDefIndex: 11012
{
	// Fields
	private static readonly Dictionary<EnableMessageHeader, OnEnableMessageStub> _enableMessages; // 0x00
	private static readonly TimedEventReverseComparer _timedEventReverseComparer; // 0x08
	private readonly UnitySync _monoSync; // 0x10
	private readonly UnitySync[] _placeholders; // 0x30
	private readonly TimedEvent[] _tickEvents; // 0x38
	private readonly Event[] _enableEvents; // 0x40
	private readonly Event[] _disableEvents; // 0x48
	private bool _enabled; // 0x50
	private int _tickIndex; // 0x54
	private float _timer; // 0x58
	private bool _needUpdateTransformsAfterEnable; // 0x5C
	private bool _needPostEnableEventOnPlaceholders; // 0x5D
	private bool _hasRegisteredPlaceholders; // 0x5E
	private int _enableMessageOrdinal; // 0x60

	// Properties
	public ListenerPersonality listenerPersonality { /* [XID] */ /* 0x00000001896A8270-0x00000001896A82B0 */ get; /* [XID] */ /* 0x00000001896B21B0-0x00000001896B21F0 */ set; } // 0x0000000182F3AF50-0x0000000182F3AFB0 0x0000000182F3ADB0-0x0000000182F3AE10
	protected virtual float timeScale { /* [XID] */ /* 0x00000001896BC9E0-0x00000001896BCA00 */ get; } // 0x0000000182F392F0-0x0000000182F393A0 
	protected UnitySync monoSync { /* [XID] */ /* 0x00000001896C3F60-0x00000001896C3F80 */ get; } // 0x0000000182F3A310-0x0000000182F3A410 
	protected UnitySync[] placeholders { /* [XID] */ /* 0x00000001896CB3B0-0x00000001896CB3D0 */ get; } // 0x0000000182F396B0-0x0000000182F39750 
	protected TimedEvent[] tickEvents { /* [XID] */ /* 0x0000000189910650-0x0000000189910670 */ get; } // 0x0000000182F3AE10-0x0000000182F3AEB0 
	protected Event[] enableEvents { /* [XID] */ /* 0x00000001896DA440-0x00000001896DA460 */ get; } // 0x0000000182F3AEB0-0x0000000182F3AF50 
	protected Event[] disableEvents { /* [XID] */ /* 0x00000001896E1BA0-0x00000001896E1BC0 */ get; } // 0x0000000182F39570-0x0000000182F39610 
	protected int tickIndex { /* [XID] */ /* 0x00000001896E90D0-0x00000001896E90F0 */ get; /* [XID] */ /* 0x000000018992EA70-0x000000018992EA90 */ set; } // 0x0000000182F39750-0x0000000182F397F0 0x0000000182F39190-0x0000000182F39240
	protected float timer { /* [XID] */ /* 0x00000001896F7AB0-0x00000001896F7AD0 */ get; /* [XID] */ /* 0x00000001896FF5B0-0x00000001896FF5D0 */ set; } // 0x0000000182F39240-0x0000000182F392F0 0x0000000182F38EB0-0x0000000182F38F60
	protected bool hasRegisteredPlaceholders { /* [XID] */ /* 0x0000000189944EB0-0x0000000189944ED0 */ get; /* [XID] */ /* 0x000000018970E250-0x000000018970E270 */ set; } // 0x0000000182F39610-0x0000000182F396B0 0x0000000182F39030-0x0000000182F390E0

	// Nested types
	private struct EnableMessageHeader // TypeDefIndex: 11013
	{
		// Fields
		public int hashCode; // 0x00
		public int ordinal; // 0x04
	}

	private class EnableMessageHeaderEqualityComparer : IEqualityComparer<EnableMessageHeader> // TypeDefIndex: 11014
	{
		// Constructors
		public EnableMessageHeaderEqualityComparer() {} // 0x0000000182F26500-0x0000000182F26560

		// Methods
		// [XID] // 0x00000001897B2C10-0x00000001897B2C30
		public bool Equals(EnableMessageHeader x, EnableMessageHeader y) => default; // 0x0000000182F26370-0x0000000182F26450
		// [XID] // 0x00000001897BA720-0x00000001897BA740
		public int GetHashCode(EnableMessageHeader obj) => default; // 0x0000000182F26450-0x0000000182F26500
	}

	[Serializable]
	public class Event // TypeDefIndex: 11015
	{
		// Fields
		private bool _hasConverted; // 0x10
		private uint _hashId; // 0x14
		public string name; // 0x18
		public int goIndex; // 0x20
		public string comment; // 0x28

		// Properties
		public uint hashId { /* [XID] */ /* 0x00000001897C2500-0x00000001897C2520 */ get => default; } // 0x0000000182F26060-0x0000000182F26180 

		// Constructors
		public Event() {} // 0x0000000182F26000-0x0000000182F26060
	}

	internal struct OnEnableMessageStub // TypeDefIndex: 11016
	{
		// Properties
		public AudioUnityMessageType messageType { get; /* [XID] */ /* 0x00000001897E6670-0x00000001897E66B0 */ set; } // 0x0000000182F26180-0x0000000182F261E0 0x0000000182F26240-0x0000000182F262A0
		public object cookie { /* [XID] */ /* 0x00000001897F12E0-0x00000001897F1320 */ get; /* [XID] */ /* 0x00000001897FBD80-0x00000001897FBDC0 */ set; } // 0x0000000182F261E0-0x0000000182F26240 0x0000000182F262A0-0x0000000182F26370
	}

	[Serializable]
	public class TimedEvent : Event // TypeDefIndex: 11017
	{
		// Fields
		public float time; // 0x30

		// Constructors
		public TimedEvent() {} // 0x0000000182F47A40-0x0000000182F47AF0
	}

	protected class TimedEventReverseComparer : IComparer<TimedEvent> // TypeDefIndex: 11018
	{
		// Constructors
		public TimedEventReverseComparer() {} // 0x0000000182F471C0-0x0000000182F47220

		// Methods
		// [XID] // 0x00000001895EFEF0-0x00000001895EFF10
		public int Compare(TimedEvent x, TimedEvent y) => default; // 0x0000000182F470A0-0x0000000182F471C0
	}

	// Constructors
	protected ExDrivenAudioEvents() {} // Dummy constructor
	static ExDrivenAudioEvents() {} // 0x0000000182F3B5D0-0x0000000182F3B720
	public ExDrivenAudioEvents(MonoBehaviour mono, GameObject[] placeholders, TimedEvent[] tickEvents, Event[] enableEvents, Event[] disableEvents) {} // 0x0000000182F3B720-0x0000000182F3B9A0

	// Methods
	// [XID] // 0x00000001897156B0-0x00000001897156D0
	public virtual void ReceiveMessage(AudioUnityMessageType messageType, object cookie) {} // 0x0000000182F3B0C0-0x0000000182F3B3A0
	// [XID] // 0x000000018971D290-0x000000018971D2B0
	public virtual void Init() {} // 0x0000000182F397F0-0x0000000182F398B0
	// [XID] // 0x0000000189724630-0x0000000189724650
	public virtual void Enable() {} // 0x0000000182F38F60-0x0000000182F39030
	// [XID] // 0x0000000189B34910-0x0000000189B34930
	public virtual void Disable() {} // 0x0000000182F3B3A0-0x0000000182F3B480
	// [XID] // 0x0000000189733430-0x0000000189733450
	public virtual void Tick() {} // 0x0000000182F398B0-0x0000000182F39A90
	public virtual void PostEvents<T>(T[] events)
		where T : Event {}
	// [XID] // 0x000000018973AC30-0x000000018973AC50
	public virtual void SetListenerPersonalityForGameObjects() {} // 0x0000000182F3AAE0-0x0000000182F3ACD0
	// [XID] // 0x0000000189A611B0-0x0000000189A611D0
	public virtual UnitySync GetPlaceholderAtIndex(int index) => default; // 0x0000000182F38BF0-0x0000000182F38DA0
	protected abstract void PostEvent(Event e);
	// [XID] // 0x000000018974A030-0x000000018974A050
	protected virtual void SortTickEvents() {} // 0x0000000182F3ACD0-0x0000000182F3ADB0
	// [XID] // 0x0000000189751430-0x0000000189751450
	protected virtual void RegisterPlaceholderActivenessCallbacks() {} // 0x0000000182F3A000-0x0000000182F3A0D0
	// [XID] // 0x00000001897587B0-0x00000001897587D0
	protected virtual void RegisterPlaceholderCallbacks(Event[] events, AudioUnityMessageType messageType) {} // 0x0000000182F39A90-0x0000000182F39CE0
	// [XID] // 0x0000000189760470-0x0000000189760490
	protected virtual void RegisterSyncs() {} // 0x0000000182F3A410-0x0000000182F3A4C0
	// [XID] // 0x0000000189767840-0x0000000189767860
	protected virtual void UnregisterSyncs() {} // 0x0000000182F390E0-0x0000000182F39190
	// [XID] // 0x000000018976EF30-0x000000018976EF50
	protected virtual void CommitWwiseSyncs(bool register) {} // 0x0000000182F3A4C0-0x0000000182F3A970
	// [XID] // 0x00000001896573A0-0x00000001896573C0
	protected virtual void SetListenerPersonalityOnSync(AudioManager audioManager, UnitySync unitySync) {} // 0x0000000182F393A0-0x0000000182F39570
	// [XID] // 0x0000000189B98910-0x0000000189B98930
	protected virtual void PostRootSyncOnEnableEvents() {} // 0x0000000182F38DA0-0x0000000182F38EB0
	// [XID] // 0x0000000189785880-0x00000001897858A0
	protected virtual void PostRootGameObjectOnDisableEvents() {} // 0x0000000182F3AFB0-0x0000000182F3B0C0
	// [XID] // 0x000000018978CD60-0x000000018978CD80
	protected virtual void PostUnityMessageEvent(Event e) {} // 0x0000000182F39CE0-0x0000000182F39DA0
	// [XID] // 0x0000000189B9FDA0-0x0000000189B9FDC0
	protected virtual void MakeUpForOnEnableMessageStubs() {} // 0x0000000182F3A0D0-0x0000000182F3A310
	// [XID] // 0x000000018979C5F0-0x000000018979C610
	protected virtual void RemovePendingEnableMessages() {} // 0x0000000182F3B480-0x0000000182F3B5D0
	// [XID] // 0x00000001897A3AF0-0x00000001897A3B10
	protected virtual UnitySync GetPlaceholderForEvent(Event e) => default; // 0x0000000182F3A970-0x0000000182F3AAE0
	// [XID] // 0x00000001897AAF60-0x00000001897AAF80
	protected virtual void UpdateTransforms() {} // 0x0000000182F39DA0-0x0000000182F3A000
}

