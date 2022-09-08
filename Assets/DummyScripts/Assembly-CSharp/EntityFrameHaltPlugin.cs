/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityFrameHaltPlugin : BaseComponentPlugin // TypeDefIndex: 12043
{
	// Fields
	private TimerReceiver _timer; // 0x58

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018961CA20-0x000000018961CA40 */ get => default; } // 0x0000000181BEEBF0-0x0000000181BEEC90 

	// Constructors
	public EntityFrameHaltPlugin() {} // 0x0000000181BEEB80-0x0000000181BEEBF0

	// Methods
	// [XID] // 0x000000018990F090-0x000000018990F0B0
	public void FrameHalt(float haltTimeScale, float haltTime) {} // 0x0000000181BEE770-0x0000000181BEE970
	// [XID] // 0x000000018962B6B0-0x000000018962B6D0
	private bool OnHaltFinish() => default; // 0x0000000181BEE970-0x0000000181BEEA40
	// [XID] // 0x0000000189632ED0-0x0000000189632EF0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181BEE600-0x0000000181BEE6C0
	// [XID] // 0x000000018963AA10-0x000000018963AA30
	public override void Destroy() {} // 0x0000000181BEE6C0-0x0000000181BEE770
	// [XID] // 0x00000001896420F0-0x0000000189642110
	private void ClearDurationTimer() {} // 0x0000000181BEE550-0x0000000181BEE600
}

