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

public sealed class EvtBegingHitCombinePacket : CombinePacketBase // TypeDefIndex: 20984
{
	// Fields
	public const int MAX_EVTBEINGHIT_PACKET_COUNT = 10; // Metadata: 0x00AFE7F1
	private List<EvtBeingHitInfo> _begingHitInfos; // 0x18

	// Constructors
	public EvtBegingHitCombinePacket() {} // 0x0000000181BF9070-0x0000000181BF90D0

	// Methods
	// [XID] // 0x00000001897E1000-0x00000001897E1020
	public override void Init() {} // 0x0000000181BF8DD0-0x0000000181BF8EA0
	// [XID] // 0x00000001897E8730-0x00000001897E8750
	public override void Destroy() {} // 0x0000000181BF8C00-0x0000000181BF8CA0
	// [XID] // 0x00000001897F03C0-0x00000001897F03E0
	public override void LateTick() {} // 0x0000000181BF8FC0-0x0000000181BF9070
	// [XID] // 0x00000001897F7B10-0x00000001897F7B30
	private void SendEvtBeingHitCombine() {} // 0x0000000181BF8D00-0x0000000181BF8DD0
	// [XID] // 0x00000001897FF190-0x00000001897FF1B0
	public void RequestEvtBeingHit(EvtBeingHit evtBeingHit) {} // 0x0000000181BF8950-0x0000000181BF8C00
	// [XID] // 0x00000001898068F0-0x0000000189806910
	public void CheckEvtBeingHitPacketsCount() {} // 0x0000000181BF8EA0-0x0000000181BF8F60
}

