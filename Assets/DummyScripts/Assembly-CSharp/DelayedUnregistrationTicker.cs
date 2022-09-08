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

public sealed class DelayedUnregistrationTicker : AudioStuffTicker<DelayedUnregistration> // TypeDefIndex: 11509
{
	// Fields
	private readonly AudioSyncRegistration _syncRegistration; // 0x18
	private readonly Dictionary<SyncId, int> _unregPrevention; // 0x20
	private readonly HashSet<SyncId> _delayedSyncs; // 0x28

	// Constructors
	public DelayedUnregistrationTicker() {} // Dummy constructor
	public DelayedUnregistrationTicker(AudioSyncRegistration syncRegistration) {} // 0x00000001823EB3C0-0x00000001823EB4B0

	// Methods
	// [XID] // 0x0000000189BCFC10-0x0000000189BCFC30
	public void AddDelayedUnregistration(SyncId syncId) {} // 0x00000001823EA8F0-0x00000001823EAA30
	// [XID] // 0x00000001896364E0-0x0000000189636500
	public void IncreaseUnregistrationPrevention(SyncId syncId) {} // 0x00000001823EA640-0x00000001823EA7B0
	// [XID] // 0x0000000189A886C0-0x0000000189A886E0
	public void DecreaseUnregistrationPrevention(SyncId syncId) {} // 0x00000001823EAF50-0x00000001823EB100
	// [XID] // 0x00000001896450C0-0x00000001896450E0
	public bool IsUnregistrationPrevented(SyncId syncId) => default; // 0x00000001823EA440-0x00000001823EA540
	// [XID] // 0x000000018964CBA0-0x000000018964CBC0
	public bool IsUnregistrationDelayed(SyncId syncId) => default; // 0x00000001823EA540-0x00000001823EA640
	// [XID] // 0x0000000189653FF0-0x0000000189654010
	public void CancelUnregistration(SyncId syncId) {} // 0x00000001823EABF0-0x00000001823EAEA0
	// [XID] // 0x000000018993ABB0-0x000000018993ABD0
	protected override void Added(DelayedUnregistration t) {} // 0x00000001823EA7B0-0x00000001823EA8F0
	// [XID] // 0x0000000189941B90-0x0000000189941BB0
	protected override void Tick(float deltaTime, DelayedUnregistration t) {} // 0x00000001823EAA30-0x00000001823EABF0
	// [XID] // 0x0000000189949770-0x0000000189949790
	protected override bool IsFinished(DelayedUnregistration t) => default; // 0x00000001823EB100-0x00000001823EB1C0
	// [XID] // 0x0000000189672570-0x0000000189672590
	protected override void Terminate(DelayedUnregistration t, bool natural) {} // 0x00000001823EB270-0x00000001823EB3C0
	// [XID] // 0x00000001895F14C0-0x00000001895F14E0
	protected override void Removed(DelayedUnregistration t) {} // 0x00000001823EAEA0-0x00000001823EAF50
	// [XID] // 0x00000001899586E0-0x0000000189958700
	protected override void Destroyed() {} // 0x00000001823EB1C0-0x00000001823EB270
}

