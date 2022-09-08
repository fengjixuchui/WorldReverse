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

public sealed class PeriodicMultiPositionEventTicker : AudioStuffTicker<PeriodicMultiPositionEventSpot> // TypeDefIndex: 11497
{
	// Fields
	private readonly CommandThreadContext _context; // 0x18
	private readonly Dictionary<uint, PeriodicMultiPositionEvent> _events; // 0x20

	// Constructors
	public PeriodicMultiPositionEventTicker() {} // Dummy constructor
	public PeriodicMultiPositionEventTicker(CommandThreadContext context) {} // 0x0000000183346970-0x0000000183346A30

	// Methods
	// [XID] // 0x00000001896E9300-0x00000001896E9320
	public void AddSpot(uint startEventId, float duration, Vector3 position, uint endEventId, AkMultiPositionType multiPositionType) {} // 0x0000000183345E30-0x0000000183346030
	// [IDTag] // 0x00000001897A8120-0x00000001897A8160
	// [XID] // 0x00000001897A8120-0x00000001897A8160
	public override void Tick(float deltaTime) {} // 0x0000000183345BB0-0x0000000183345DB0
	// [XID] // 0x00000001897B2AF0-0x00000001897B2B10
	protected override void Added(PeriodicMultiPositionEventSpot t) {} // 0x0000000183345910-0x00000001833459D0
	// [IDTag] // 0x00000001897BA5E0-0x00000001897BA620
	// [XID] // 0x00000001897BA5E0-0x00000001897BA620
	protected override void Tick(float deltaTime, PeriodicMultiPositionEventSpot t) {} // 0x0000000183345AC0-0x0000000183345BB0
	// [XID] // 0x00000001897C5730-0x00000001897C5750
	protected override bool IsFinished(PeriodicMultiPositionEventSpot t) => default; // 0x00000001833464B0-0x0000000183346580
	// [XID] // 0x00000001897CCE40-0x00000001897CCE60
	protected override void Terminate(PeriodicMultiPositionEventSpot t, bool natural) {} // 0x0000000183346720-0x0000000183346970
	// [XID] // 0x00000001897F8C10-0x00000001897F8C30
	protected override void Removed(PeriodicMultiPositionEventSpot t) {} // 0x0000000183346030-0x00000001833460F0
	// [XID] // 0x00000001897DBBD0-0x00000001897DBBF0
	protected override void Destroyed() {} // 0x0000000183346580-0x0000000183346620
	// [XID] // 0x0000000189770AA0-0x0000000189770AC0
	private PeriodicMultiPositionEvent GetEventById(uint eventId) => default; // 0x00000001833459D0-0x0000000183345AC0
	// [XID] // 0x00000001897EAE20-0x00000001897EAE40
	private PeriodicMultiPositionEvent StartEvent(uint startEventId, uint endEventId, AkMultiPositionType multiPositionType) => default; // 0x0000000183345390-0x0000000183345570
	// [XID] // 0x0000000189778390-0x00000001897783B0
	private void PlayEvent(PeriodicMultiPositionEvent e) {} // 0x00000001833460F0-0x00000001833462D0
	// [XID] // 0x00000001897FA3D0-0x00000001897FA3F0
	private void StopEvent(PeriodicMultiPositionEvent e) {} // 0x00000001833462D0-0x00000001833464B0
	// [XID] // 0x00000001898019D0-0x00000001898019F0
	private void SetEventPositions(PeriodicMultiPositionEvent e) {} // 0x0000000183345570-0x0000000183345760
	// [XID] // 0x0000000189808DF0-0x0000000189808E10
	private void EndEvent(PeriodicMultiPositionEvent e) {} // 0x0000000183345760-0x0000000183345910
	// [Conditional] // 0x00000001898106A0-0x00000001898106F0
	// [XID] // 0x00000001898106A0-0x00000001898106F0
	private void SetEventNameAsSyncName(ref SyncId syncId, uint eventId) {} // 0x0000000183346620-0x0000000183346720
}

