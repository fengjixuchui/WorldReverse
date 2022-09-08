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

public class AudioSyncInfluencer // TypeDefIndex: 11435
{
	// Fields
	private readonly List<uint> _reusedSwitchList; // 0x10
	private readonly List<uint> _reusedStateList; // 0x18
	private readonly List<AffectionPair> _reusedAffectinoPairList; // 0x20
	private readonly AVLTreeOnArray<AffectionPair> _stateAffectedEventInstances; // 0x28
	private readonly AVLTreeOnArray<AffectionPair> _switchAffectedEventInstances; // 0x30

	// Nested types
	private struct AffectionPair // TypeDefIndex: 11436
	{
		// Properties
		public uint groupId { /* [XID] */ /* 0x0000000189690B00-0x0000000189690B40 */ get; /* [XID] */ /* 0x000000018969AE70-0x000000018969AEB0 */ set; } // 0x0000000180F71AF0-0x0000000180F71B50 0x0000000180F71B50-0x0000000180F71C40
		public EventInstance eventInstance { /* [XID] */ /* 0x00000001896A51D0-0x00000001896A5210 */ get; /* [XID] */ /* 0x00000001896AF5E0-0x00000001896AF620 */ set; } // 0x0000000180F71A60-0x0000000180F71AF0 0x0000000180F719E0-0x0000000180F71A60
	}

	private class AffectionPairComparer : IComparer<AffectionPair> // TypeDefIndex: 11437
	{
		// Fields
		private readonly IComparer<EventInstance> _eventInstanceComparer; // 0x10

		// Constructors
		public AffectionPairComparer() {} // Dummy constructor
		public AffectionPairComparer(IComparer<EventInstance> eventInstanceComparer) {} // 0x0000000180F71970-0x0000000180F719E0

		// Methods
		// [XID] // 0x0000000189761F40-0x0000000189761F60
		public int Compare(AffectionPair x, AffectionPair y) => default; // 0x0000000180F716B0-0x0000000180F71970
	}

	// Constructors
	public AudioSyncInfluencer() {} // 0x0000000180F909A0-0x0000000180F90B30

	// Methods
	// [IDTag] // 0x000000018963AB10-0x000000018963AB50
	// [XID] // 0x000000018963AB10-0x000000018963AB50
	public void AddEvent(EventInstance eventInstance) {} // 0x0000000180F90180-0x0000000180F90360
	// [IDTag] // 0x00000001896450E0-0x0000000189645120
	// [XID] // 0x00000001896450E0-0x0000000189645120
	public void RemoveEvent(EventInstance eventInstance) {} // 0x0000000180F90590-0x0000000180F90770
	// [XID] // 0x000000018964F770-0x000000018964F790
	public void GetStateAffectedEvents(uint groupId, List<EventInstance> events) {} // 0x0000000180F8FCE0-0x0000000180F90180
	// [XID] // 0x0000000189844BD0-0x0000000189844BF0
	public void GetSwitchAffectedEvents(uint groupId, SyncId syncId, List<EventInstance> events) {} // 0x0000000180F8F6D0-0x0000000180F8FB90
	// [XID] // 0x00000001899BEE50-0x00000001899BEE70
	private void PrepareLists(EventInstance eventInstance) {} // 0x0000000180F8FB90-0x0000000180F8FCE0
	// [IDTag] // 0x0000000189665E20-0x0000000189665E60
	// [XID] // 0x0000000189665E20-0x0000000189665E60
	private void AddEvent(List<uint> groupIds, EventInstance eventInstance, AVLTreeOnArray<AffectionPair> tree) {} // 0x0000000180F90360-0x0000000180F90590
	// [IDTag] // 0x0000000189670B80-0x0000000189670BC0
	// [XID] // 0x0000000189670B80-0x0000000189670BC0
	private void RemoveEvent(List<uint> groupIds, EventInstance eventInstance, AVLTreeOnArray<AffectionPair> tree) {} // 0x0000000180F90770-0x0000000180F909A0
}

