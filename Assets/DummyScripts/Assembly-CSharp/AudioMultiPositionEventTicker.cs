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

public sealed class AudioMultiPositionEventTicker : AudioStuffTicker<AudioMultiPositionEvent> // TypeDefIndex: 11489
{
	// Fields
	private readonly Dictionary<uint, AudioMultiPositionEvent> _nameTable; // 0x18
	private readonly CommandThreadContext _context; // 0x20

	// Constructors
	public AudioMultiPositionEventTicker() {} // Dummy constructor
	public AudioMultiPositionEventTicker(CommandThreadContext context) {} // 0x0000000182659C30-0x0000000182659CE0

	// Methods
	// [XID] // 0x0000000189B77D40-0x0000000189B77D60
	public void Add(Transform t, uint eventId, AkMultiPositionType multiPositionType) {} // 0x0000000182659790-0x0000000182659900
	// [XID] // 0x0000000189B7F3C0-0x0000000189B7F3E0
	public void Remove(Transform t, uint eventId) {} // 0x00000001826594D0-0x00000001826595D0
	// [XID] // 0x0000000189B86FB0-0x0000000189B86FD0
	public AudioMultiPositionEvent Get(uint eventId) => default; // 0x00000001826595D0-0x00000001826596C0
	// [XID] // 0x00000001896A6BB0-0x00000001896A6BD0
	protected override void Added(AudioMultiPositionEvent t) {} // 0x00000001826591D0-0x0000000182659280
	// [XID] // 0x0000000189B955C0-0x0000000189B955E0
	protected override void Tick(float deltaTime, AudioMultiPositionEvent t) {} // 0x0000000182659280-0x0000000182659420
	// [XID] // 0x0000000189B9CC10-0x0000000189B9CC30
	protected override bool IsFinished(AudioMultiPositionEvent t) => default; // 0x00000001826596C0-0x0000000182659790
	// [XID] // 0x0000000189BA42A0-0x0000000189BA42C0
	protected override void Terminate(AudioMultiPositionEvent t, bool natural) {} // 0x0000000182659B70-0x0000000182659C30
	// [XID] // 0x0000000189BAB8D0-0x0000000189BAB8F0
	protected override void Removed(AudioMultiPositionEvent t) {} // 0x0000000182659420-0x00000001826594D0
	// [XID] // 0x0000000189BB2E10-0x0000000189BB2E30
	protected override void Destroyed() {} // 0x0000000182659AD0-0x0000000182659B70
	// [XID] // 0x00000001896CB620-0x00000001896CB640
	private void WarnAboutConflictingTypes(AudioMultiPositionEvent mpEvent, AkMultiPositionType incomingType, uint eventId) {} // 0x0000000182659900-0x0000000182659AD0
}

