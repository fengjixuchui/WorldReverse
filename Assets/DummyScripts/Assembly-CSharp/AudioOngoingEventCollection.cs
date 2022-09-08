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

public class AudioOngoingEventCollection // TypeDefIndex: 11284
{
	// Fields
	private readonly Dictionary<int, AudioOngoingEvent> _activeEvents; // 0x10
	private readonly AVLTreeOnArray<EventInstance, uint> _eventInstances; // 0x18
	private readonly SignedDumbAutoIncreaser _autoIncreaser; // 0x20

	// Constructors
	public AudioOngoingEventCollection() {} // 0x0000000181CF7F50-0x0000000181CF8050

	// Methods
	// [XID] // 0x00000001898882B0-0x00000001898882D0
	public AudioOngoingEvent IssueNewEvent(uint eventId, SyncId syncId, object cookie, AkCallbackType callbackMask, EventCallback callback, bool callbackFromCommand) => default; // 0x0000000181CF7590-0x0000000181CF7950
	// [XID] // 0x0000000189B829B0-0x0000000189B829D0
	public void UpdatePlayingId(int ordinal, uint playingId) {} // 0x0000000181CF7410-0x0000000181CF7590
	// [XID] // 0x000000018969E450-0x000000018969E470
	public void TrashEvent(AudioOngoingEvent ongoingEvent) {} // 0x0000000181CF7DF0-0x0000000181CF7F50
	// [XID] // 0x00000001897D7690-0x00000001897D76B0
	public bool TryGetOngoingEventByOridinal(int ordinal, out AudioOngoingEvent ongoingEvent) {
		ongoingEvent = default;
		return default;
	} // 0x0000000181CF7B30-0x0000000181CF7C10
	// [XID] // 0x00000001897DEBE0-0x00000001897DEC00
	public bool ShouldBeDeniedByMutualExclusion(SyncId syncId, uint eventId) => default; // 0x0000000181CF7060-0x0000000181CF72A0
	// [XID] // 0x00000001897E6610-0x00000001897E6630
	private void AddOngoingEvent(EventInstance eventInstance) {} // 0x0000000181CF7C10-0x0000000181CF7DF0
	// [XID] // 0x00000001897EE100-0x00000001897EE120
	private void RemoveOngoingEvent(EventInstance eventInstance) {} // 0x0000000181CF7950-0x0000000181CF7B30
	// [XID] // 0x00000001897F58A0-0x00000001897F58C0
	private void AddToOngoingEvent(EventInstance eventInstance) {} // 0x0000000181CF6EE0-0x0000000181CF7060
	// [XID] // 0x00000001896A5420-0x00000001896A5440
	private void RemoveFromOngoingEvent(EventInstance eventInstance) {} // 0x0000000181CF6D60-0x0000000181CF6EE0
	// [XID] // 0x0000000189804720-0x0000000189804740
	private bool HasEventOngoing(SyncId syncId, uint eventId) => default; // 0x0000000181CF72A0-0x0000000181CF7410
}

