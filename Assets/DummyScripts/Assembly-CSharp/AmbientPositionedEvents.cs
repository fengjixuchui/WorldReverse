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

public class AmbientPositionedEvents // TypeDefIndex: 11226
{
	// Fields
	private const uint TRANSFORM_UPDATE_INTERNAL = 15; // Metadata: 0x00AE94A1
	private readonly CommandThreadContext _context; // 0x10
	private readonly List<PositionedEvent> _allEvents; // 0x18
	private readonly EventArray _timeWaitingEvents; // 0x20
	private readonly List<PositionedEvent> _postPendingEvents; // 0x28
	private uint _transformUpdateCounter; // 0x30
	private SyncTransform[] _positionedSyncs; // 0x38
	private bool _followlistenerOrientation; // 0x40

	// Properties
	public bool followListenerOrientation { /* [XID] */ /* 0x0000000189696BB0-0x0000000189696BD0 */ get => default; /* [XID] */ /* 0x000000018969E160-0x000000018969E180 */ set {} } // 0x000000018568E700-0x000000018568E7A0 0x000000018568E0D0-0x000000018568E180

	// Nested types
	private class PositionedEvent // TypeDefIndex: 11227
	{
		// Fields
		private const float MINIMAL_COUNTDOWN_TIME = 0.1f; // Metadata: 0x00AE94A5
		private static readonly EventCallback _eventCallback; // 0x00
		private readonly AmbientPositionedEvents _host; // 0x10
		private readonly AudioAmbiencePositionedEvent _config; // 0x18
		private float _dueTime; // 0x20
		private AudioPostedEventStatus _postedEventStatus; // 0x24

		// Properties
		public bool due { /* [XID] */ /* 0x0000000189734C70-0x0000000189734C90 */ get => default; } // 0x00000001856A3AC0-0x00000001856A3B80 
		public bool pending { /* [XID] */ /* 0x000000018980F0B0-0x000000018980F0D0 */ get => default; } // 0x00000001856A3430-0x00000001856A34E0 
		public bool playing { /* [XID] */ /* 0x0000000189743CE0-0x0000000189743D00 */ get => default; } // 0x00000001856A2ED0-0x00000001856A2F80 

		// Constructors
		public PositionedEvent() {} // Dummy constructor
		static PositionedEvent() {} // 0x00000001856A3C80-0x00000001856A3D20
		public PositionedEvent(AudioAmbiencePositionedEvent config, AmbientPositionedEvents host) {} // 0x00000001856A3D20-0x00000001856A3F80

		// Methods
		// [XID] // 0x000000018995CC60-0x000000018995CC80
		public void TickPostedEvent() {} // 0x00000001856A3B80-0x00000001856A3C80
		// [XID] // 0x0000000189752CF0-0x0000000189752D10
		public void PlayOnSync(SyncId syncId) {} // 0x00000001856A35D0-0x00000001856A37D0
		// [XID] // 0x0000000189A0C5D0-0x0000000189A0C5F0
		public void StopIfPlaying() {} // 0x00000001856A3890-0x00000001856A3A10
		// [XID] // 0x00000001897E2100-0x00000001897E2120
		public void SetInitialCountdownTimer() {} // 0x00000001856A2C40-0x00000001856A2D30
		// [XID] // 0x000000018996BD00-0x000000018996BD20
		public void RestartCountdownTimer() {} // 0x00000001856A34E0-0x00000001856A35D0
		// [XID] // 0x0000000189770870-0x0000000189770890
		private static void EventCallback(object cookie, AkCallbackType type, MmoronCallbackInfo info) {} // 0x00000001856A30B0-0x00000001856A3270
		// [XID] // 0x00000001897F1540-0x00000001897F1560
		private void SetRandomCountdownTime(float min, float max) {} // 0x00000001856A2F80-0x00000001856A30B0
		// [XID] // 0x000000018977F5C0-0x000000018977F5E0
		private void SetCountdownTime(float time) {} // 0x00000001856A37D0-0x00000001856A3890
		// [XID] // 0x0000000189786F80-0x0000000189786FA0
		private void WaitInLine() {} // 0x00000001856A3A10-0x00000001856A3AC0
		// [XID] // 0x000000018978E600-0x000000018978E620
		public static bool operator <(PositionedEvent lhs, PositionedEvent rhs) => default; // 0x00000001856A2E00-0x00000001856A2ED0
		// [XID] // 0x0000000189795D60-0x0000000189795D80
		public static bool operator >(PositionedEvent lhs, PositionedEvent rhs) => default; // 0x00000001856A2D30-0x00000001856A2E00
		// [XID] // 0x000000018994DE00-0x000000018994DE20
		public static bool operator >=(PositionedEvent lhs, PositionedEvent rhs) => default; // 0x00000001856A3270-0x00000001856A3350
		// [XID] // 0x0000000189AFDDF0-0x0000000189AFDE10
		public static bool operator <=(PositionedEvent lhs, PositionedEvent rhs) => default; // 0x00000001856A3350-0x00000001856A3430
	}

	private class EventArray // TypeDefIndex: 11228
	{
		// Fields
		private const int DEFAULT_CAPACITY = 4; // Metadata: 0x00AE94A9
		private PositionedEvent[] _events; // 0x10
		private int _usedCount; // 0x18

		// Constructors
		public EventArray(int capacity) {} // 0x0000000185684AD0-0x0000000185684BA0
		public EventArray() {} // 0x0000000185684BA0-0x0000000185684C70

		// Methods
		// [XID] // 0x00000001897ACB00-0x00000001897ACB20
		public void Add(PositionedEvent e) {} // 0x0000000185684860-0x0000000185684AD0
		// [XID] // 0x00000001897B4900-0x00000001897B4920
		public bool TryPickEarliest(out PositionedEvent e) {
			e = default;
			return default;
		} // 0x0000000185684710-0x0000000185684860
		// [XID] // 0x00000001897BC810-0x00000001897BC830
		public void Clear() {} // 0x0000000185684630-0x0000000185684710
		// [XID] // 0x00000001897F8C90-0x00000001897F8CB0
		private void ExpandCapacity() {} // 0x0000000185684520-0x0000000185684630
	}

	// Constructors
	public AmbientPositionedEvents() {} // Dummy constructor
	public AmbientPositionedEvents(CommandThreadContext context) {} // 0x000000018568E7A0-0x000000018568E880

	// Methods
	// [XID] // 0x00000001896A5210-0x00000001896A5230
	public void Start() {} // 0x000000018568D5B0-0x000000018568D6C0
	// [XID] // 0x0000000189955460-0x0000000189955480
	public void Tick() {} // 0x000000018568DA60-0x000000018568DB20
	// [XID] // 0x00000001896B3DF0-0x00000001896B3E10
	public void Stop() {} // 0x000000018568CE00-0x000000018568CEF0
	// [XID] // 0x00000001896BB420-0x00000001896BB440
	public void StartFollowingListenerOrientation() {} // 0x000000018568E440-0x000000018568E4E0
	// [XID] // 0x00000001896C2660-0x00000001896C2680
	public void StopFollowingListenerOrientation() {} // 0x000000018568CBD0-0x000000018568CC70
	// [XID] // 0x00000001896C9BF0-0x00000001896C9C10
	private void LineUp(PositionedEvent e) {} // 0x000000018568DCE0-0x000000018568DDA0
	// [XID] // 0x0000000189807A20-0x0000000189807A40
	private void TickPostPendingEvents() {} // 0x000000018568CC70-0x000000018568CE00
	// [XID] // 0x00000001896D8AE0-0x00000001896D8B00
	private void TickTimeWaitingEvents() {} // 0x000000018568D6C0-0x000000018568D7B0
	// [XID] // 0x00000001896E0310-0x00000001896E0330
	private void TickTransforms() {} // 0x000000018568CEF0-0x000000018568D260
	// [XID] // 0x00000001896E7620-0x00000001896E7640
	private void CreatePositionSyncs() {} // 0x000000018568D7B0-0x000000018568DA60
	// [XID] // 0x00000001896EEC60-0x00000001896EEC80
	private void RegisterSyncs() {} // 0x000000018568DB20-0x000000018568DCE0
	// [XID] // 0x0000000189A7B070-0x0000000189A7B090
	private void UnregisterSyncs() {} // 0x000000018568D260-0x000000018568D420
	// [XID] // 0x00000001896FDD90-0x00000001896FDDB0
	private void RemovePositionSyncs() {} // 0x000000018568DF90-0x000000018568E0D0
	// [XID] // 0x0000000189705190-0x00000001897051B0
	private void CreatePositionedEvents() {} // 0x000000018568E4E0-0x000000018568E700
	// [XID] // 0x0000000189A04EE0-0x0000000189A04F00
	private void StopPlayingEvents() {} // 0x000000018568E320-0x000000018568E440
	// [XID] // 0x00000001897140D0-0x00000001897140F0
	private void PlayEvent(PositionedEvent e) {} // 0x000000018568DDA0-0x000000018568DF90
	// [XID] // 0x0000000189816860-0x0000000189816880
	private void MakeEventWait(PositionedEvent e) {} // 0x000000018568E180-0x000000018568E250
	// [XID] // 0x0000000189722E90-0x0000000189722EB0
	private uint GetCurrentSceneId() => default; // 0x000000018568E250-0x000000018568E320
	// [Conditional] // 0x000000018972A500-0x000000018972A550
	// [XID] // 0x000000018972A500-0x000000018972A550
	private void SetSyncName(SyncTransform st, int ordinal) {} // 0x000000018568D420-0x000000018568D5B0
}

