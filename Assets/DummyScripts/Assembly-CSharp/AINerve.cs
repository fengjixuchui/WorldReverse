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

public sealed class AINerve : BrainModuleBase // TypeDefIndex: 20433
{
	// Fields
	private LCAIBeta _lcai; // 0x30
	private AIThreatUpdater _threatUpdater; // 0x38
	private AIMixinUpdater _mixinUpdater; // 0x40
	private Action<BaseEvent> _processBroadcast; // 0x48
	private int MAX_HANDLE_COUNT_PER_TICK; // 0x50
	private List<ScheduledEventHandle> _scheduledEventHandles; // 0x58

	// Nested types
	private struct ScheduledEventHandle // TypeDefIndex: 20434
	{
		// Fields
		public BaseEvent handleEvent; // 0x00
		public float handleTick; // 0x08
		public Action<BaseEvent> handleCallback; // 0x10
	}

	// Constructors
	public AINerve() {} // Dummy constructor
	public AINerve(LCAIBeta brain, AIKnowledge knowledge, AIThreatUpdater threat, AIMixinUpdater mixin) {} // 0x00000001823E14B0-0x00000001823E15B0

	// Methods
	// [XID] // 0x0000000189850E30-0x0000000189850E50
	protected override void ClearInternal(BaseEntity.ClearReason reason) {} // 0x00000001823E0700-0x00000001823E07E0
	// [XID] // 0x00000001898582C0-0x00000001898582E0
	protected override void UpdateMainThreadInternal(float deltaTime) {} // 0x00000001823E07E0-0x00000001823E0A20
	// [XID] // 0x0000000189B141B0-0x0000000189B141D0
	public bool HandleEvent(BaseEvent evt) => default; // 0x00000001823E0D70-0x00000001823E14B0
	// [XID] // 0x0000000189866B30-0x0000000189866B50
	private void ProcessBroadcast(BaseEvent evt) {} // 0x00000001823E0C90-0x00000001823E0D70
	// [XID] // 0x000000018986E3F0-0x000000018986E410
	private void ProcessHit(EvtBeingHit hitEvent) {} // 0x00000001823E0400-0x00000001823E0680
	// [XID] // 0x000000018995CBA0-0x000000018995CBC0
	private void ScheduleFutureHandling(BaseEvent evt, float handlingTick, Action<BaseEvent> handlingCallback) {} // 0x00000001823E0A90-0x00000001823E0C90
}

