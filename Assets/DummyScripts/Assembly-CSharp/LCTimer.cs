/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCTimer : LCBase // TypeDefIndex: 11774
{
	// Fields
	private EntityTimerReceiver _checkTimer; // 0x130
	private EntityTimerReceiver _lifeTimer; // 0x138
	public TimerLimitType lifeType; // 0x140
	public float lifeTime; // 0x144
	public float origLifeTime; // 0x148
	public float checkCD; // 0x14C
	public float startCheckTime; // 0x150
	private bool isKilled; // 0x154
	[NonSerialized]
	public Action onTriggerLifeOver; // 0x158
	[NonSerialized]
	public Action onCheckEvent; // 0x160

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A792F0-0x0000000189A79310 */ get => default; } // 0x0000000183D3F710-0x0000000183D3F7B0 
	public override bool canTickIfDisable { /* [XID] */ /* 0x0000000189A80960-0x0000000189A80980 */ set {} } // 0x0000000183D3F7B0-0x0000000183D3F930

	// Constructors
	public LCTimer() {} // 0x0000000183D3F670-0x0000000183D3F710

	// Methods
	// [XID] // 0x0000000189A88440-0x0000000189A88460
	private void InitInternal() {} // 0x0000000183D3EAF0-0x0000000183D3EE60
	// [XID] // 0x0000000189991870-0x0000000189991890
	public override void Init() {} // 0x0000000183D3EE60-0x0000000183D3EF10
	// [XID] // 0x0000000189999360-0x0000000189999380
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183D3F5B0-0x0000000183D3F670
	// [XID] // 0x0000000189A9E830-0x0000000189A9E850
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183D3E4E0-0x0000000183D3E650
	// [XID] // 0x0000000189AA61E0-0x0000000189AA6200
	public override void Destroy() {} // 0x0000000183D3E830-0x0000000183D3E910
	// [XID] // 0x00000001899AFD90-0x00000001899AFDB0
	public override void OnEnable() {} // 0x0000000183D3F4E0-0x0000000183D3F5B0
	// [XID] // 0x0000000189AB5040-0x0000000189AB5060
	public override void OnDisable() {} // 0x0000000183D3F3C0-0x0000000183D3F4E0
	// [XID] // 0x0000000189ABCD40-0x0000000189ABCD60
	private bool UpdateLife() => default; // 0x0000000183D3F300-0x0000000183D3F3C0
	// [XID] // 0x0000000189AC4630-0x0000000189AC4650
	private bool UpdateCheck() => default; // 0x0000000183D3E9C0-0x0000000183D3EA90
	// [XID] // 0x0000000189ACBC70-0x0000000189ACBC90
	private void OnInvokeAction(Action action) {} // 0x0000000183D3EF10-0x0000000183D3EFD0
	// [XID] // 0x0000000189974BD0-0x0000000189974BF0
	public void OnKill() {} // 0x0000000183D3F030-0x0000000183D3F140
	// [XID] // 0x000000018995E470-0x000000018995E490
	public bool IsKilled() => default; // 0x0000000183D3E910-0x0000000183D3E9C0
	// [XID] // 0x0000000189AE2840-0x0000000189AE2860
	private void SyncLifeTime() {} // 0x0000000183D3E650-0x0000000183D3E7D0
	// [XID] // 0x0000000189AEA330-0x0000000189AEA350
	public void AddLifeTime(float addLifeTime) {} // 0x0000000183D3F140-0x0000000183D3F220
}

