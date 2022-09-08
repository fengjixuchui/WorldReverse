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

public class BaseInterTask : ISimplePoolObject // TypeDefIndex: 20849
{
	// Fields
	public const float DURATION_ENDLESS = -1f; // Metadata: 0x00AFE6DA
	protected bool _isStarted; // 0x10
	protected float _timeCnt; // 0x14
	protected float _duration; // 0x18
	protected float _timeCheckPoint; // 0x1C
	protected InterDelay _delay; // 0x20
	protected BaseInterAction _candidateInterAction; // 0x28
	protected BaseInterAction _currInterAction; // 0x30

	// Properties
	protected float DeltaTime { /* [XID] */ /* 0x0000000189B27E30-0x0000000189B27E50 */ get => default; } // 0x0000000180CA9380-0x0000000180CA9440 
	public virtual InteractionType dataType { /* [XID] */ /* 0x0000000189B4D430-0x0000000189B4D450 */ get => default; } // 0x0000000180CA95F0-0x0000000180CA9690 

	// Constructors
	public BaseInterTask() {} // 0x0000000180CA9F60-0x0000000180CA9FE0

	// Methods
	// [XID] // 0x0000000189B20770-0x0000000189B20790
	public virtual void ResetObject() {} // 0x0000000180CA9E60-0x0000000180CA9F60
	// [XID] // 0x0000000189B2F170-0x0000000189B2F190
	protected bool CheckTime() => default; // 0x0000000180CA9A10-0x0000000180CA9B20
	// [XID] // 0x0000000189B36AD0-0x0000000189B36AF0
	protected virtual bool CheckDelay() => default; // 0x0000000180CA9240-0x0000000180CA9380
	// [XID] // 0x0000000189B3E270-0x0000000189B3E290
	public bool IsInDelay() => default; // 0x0000000180CA8D70-0x0000000180CA8E20
	// [XID] // 0x0000000189B45F60-0x0000000189B45F80
	public float GetTimeCount() => default; // 0x0000000180CA9DB0-0x0000000180CA9E60
	// [XID] // 0x0000000189B54C90-0x0000000189B54CB0
	protected virtual bool IsTypeValid(InteractionType type) => default; // 0x0000000180CA9780-0x0000000180CA9850
	// [XID] // 0x0000000189B5C670-0x0000000189B5C690
	public bool IsFinished() => default; // 0x0000000180CA9B20-0x0000000180CA9BD0
	// [XID] // 0x0000000189B63D50-0x0000000189B63D70
	public virtual void DoAction(BaseInterAction interAction) {} // 0x0000000180CA9850-0x0000000180CA9A10
	// [XID] // 0x0000000189B6B4E0-0x0000000189B6B500
	protected virtual void DoActionInternal(BaseInterAction interAction) {} // 0x0000000180CA9690-0x0000000180CA9780
	// [XID] // 0x0000000189B72B30-0x0000000189B72B50
	public virtual void DoClear() {} // 0x0000000180CA9D00-0x0000000180CA9DB0
	// [XID] // 0x0000000189B7A070-0x0000000189B7A090
	protected virtual void DoClearInternal() {} // 0x0000000180CA8EC0-0x0000000180CA8FA0
	// [XID] // 0x0000000189B817D0-0x0000000189B817F0
	public virtual void FinishCurr() {} // 0x0000000180CA9440-0x0000000180CA95F0
	// [XID] // 0x0000000189B88E70-0x0000000189B88E90
	public virtual void ForceFinishCurr() {} // 0x0000000180CA9070-0x0000000180CA9170
	// [XID] // 0x0000000189B90400-0x0000000189B90420
	protected virtual bool CheckCurrExternalFinished() => default; // 0x0000000180CA8FA0-0x0000000180CA9070
	// [XID] // 0x0000000189B97830-0x0000000189B97850
	public virtual void Tick() {} // 0x0000000180CA9170-0x0000000180CA9240
	// [XID] // 0x0000000189B9EC90-0x0000000189B9ECB0
	public virtual bool OnEvent(BaseEvent evt) => default; // 0x0000000180CA9BD0-0x0000000180CA9D00
	// [XID] // 0x0000000189BA65A0-0x0000000189BA65C0
	protected virtual void DoOnForceFinish() {} // 0x0000000180CA8E20-0x0000000180CA8EC0
}

