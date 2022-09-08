/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x0000000189670B20-0x0000000189670B60
[TickWithFrameDeltaTime] // 0x0000000189670B20-0x0000000189670B60
public class BaseAbilityMixin : IAutoAllocRecycle // TypeDefIndex: 14455
{
	// Fields
	public LCAbility actor; // 0x10
	public ActorAbility instancedAbility; // 0x18
	public ActorModifier instancedModifier; // 0x20
	public ConfigAbilityMixin mixinConfig; // 0x28
	public bool hasTick; // 0x38
	public bool hasOnEvent; // 0x39
	public bool hasOnEventRemote; // 0x3A
	public bool hasOnEventResolved; // 0x3B
	public bool hasListenEvent; // 0x3C
	public int[] selfOnEventIDs; // 0x40
	public int[] selfOnEventRemoteIDs; // 0x48
	public int[] selfOnEventResolvedIDs; // 0x50
	public int[] selfListenEventIDs; // 0x58
	private bool _enabled; // 0x60
	public int instancedMixinID; // 0x64
	private bool _hasRemovedEventListener; // 0x68

	// Properties
	public bool isInited { /* [XID] */ /* 0x0000000189B43960-0x0000000189B439A0 */ get; /* [XID] */ /* 0x0000000189B4E1B0-0x0000000189B4E1F0 */ set; } // 0x0000000180CAD490-0x0000000180CAD4F0 0x0000000180CADCF0-0x0000000180CADD50
	public bool hasOnAdded { /* [XID] */ /* 0x0000000189B58BC0-0x0000000189B58C00 */ get; /* [XID] */ /* 0x0000000189B62EA0-0x0000000189B62EE0 */ set; } // 0x0000000180CAD320-0x0000000180CAD380 0x0000000180CAD430-0x0000000180CAD490
	public MixinType mixinType { /* [XID] */ /* 0x0000000189B6D6D0-0x0000000189B6D710 */ get; /* [XID] */ /* 0x0000000189B77BC0-0x0000000189B77C00 */ set; } // 0x0000000180CAC3A0-0x0000000180CAC400 0x0000000180CACF70-0x0000000180CACFD0
	public bool enabled { /* [XID] */ /* 0x0000000189B9F960-0x0000000189B9F980 */ get => default; /* [XID] */ /* 0x0000000189BA71F0-0x0000000189BA7210 */ set {} } // 0x0000000180CAD280-0x0000000180CAD320 0x0000000180CAD4F0-0x0000000180CAD5C0
	public bool IsValid { /* [XID] */ /* 0x0000000189BD4010-0x0000000189BD4030 */ get => default; } // 0x0000000180CAD5C0-0x0000000180CAD670 

	// Nested types
	public enum HandleEventType // TypeDefIndex: 14456
	{
		OnEvent = 0,
		OnEventRemote = 1,
		OnEventResolved = 2,
		ListenEvent = 3
	}

	// Constructors
	public BaseAbilityMixin() {} // 0x0000000180CADFD0-0x0000000180CAE040

	// Methods
	// [XID] // 0x0000000189B823D0-0x0000000189B823F0
	protected static System.Type[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000180CAD090-0x0000000180CAD130
	// [XID] // 0x0000000189B89C30-0x0000000189B89C50
	protected static System.Type[] GetSelfOnEventRemoteIDsExcludingBase() => default; // 0x0000000180CAC6C0-0x0000000180CAC760
	// [XID] // 0x0000000189B911C0-0x0000000189B911E0
	protected static System.Type[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x0000000180CAD8F0-0x0000000180CAD990
	// [XID] // 0x0000000189B98410-0x0000000189B98430
	protected static System.Type[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000180CACAA0-0x0000000180CACB40
	// [XID] // 0x000000018963DCD0-0x000000018963DCF0
	public virtual void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000180CACC40-0x0000000180CACE80
	// [XID] // 0x0000000189601DB0-0x0000000189601DD0
	public void ResetActorAbilityMixin(ActorAbility instancedAbility, ConfigAbilityMixin config, RemoveAbilityReason removeReason) {} // 0x0000000180CABC10-0x0000000180CABEF0
	// [XID] // 0x000000018962E970-0x000000018962E990
	public virtual void Clear() {} // 0x0000000180CACE80-0x0000000180CACF70
	// [XID] // 0x0000000189BC4E00-0x0000000189BC4E20
	public virtual void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000180CAC760-0x0000000180CAC950
	// [XID] // 0x00000001896E1CF0-0x00000001896E1D10
	public virtual void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000180CAC240-0x0000000180CAC3A0
	// [XID] // 0x0000000189BDB930-0x0000000189BDB950
	public virtual void OnAdded(bool syncToServer) {} // 0x0000000180CABB10-0x0000000180CABC10
	// [XID] // 0x0000000189618290-0x00000001896182B0
	public virtual void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000180CACB40-0x0000000180CACC40
	// [XID] // 0x00000001895EFAE0-0x00000001895EFB00
	public virtual void OnAbilityTriggered(EvtAbilityStart evt) {} // 0x0000000180CAD1D0-0x0000000180CAD280
	// [XID] // 0x00000001895F74D0-0x00000001895F74F0
	public virtual bool OnEvent(BaseEvent evt) => default; // 0x0000000180CADBA0-0x0000000180CADC50
	// [XID] // 0x00000001895FE870-0x00000001895FE890
	public virtual bool OnEventRemote(BaseEvent evt) => default; // 0x0000000180CADA40-0x0000000180CADAF0
	// [XID] // 0x0000000189606230-0x0000000189606250
	public virtual bool OnEventResolved(BaseEvent evt) => default; // 0x0000000180CADAF0-0x0000000180CADBA0
	// [XID] // 0x000000018960DA50-0x000000018960DA70
	public virtual bool ListenEvent(BaseEvent evt) => default; // 0x0000000180CAD380-0x0000000180CAD430
	// [XID] // 0x0000000189615230-0x0000000189615250
	public virtual void Tick(float inDeltaTime) {} // 0x0000000180CADDF0-0x0000000180CADEA0
	// [XID] // 0x000000018961C980-0x000000018961C9A0
	public virtual void OnEnable() {} // 0x0000000180CACA00-0x0000000180CACAA0
	// [XID] // 0x0000000189623EC0-0x0000000189623EE0
	public virtual void OnDisable() {} // 0x0000000180CAC4B0-0x0000000180CAC550
	// [XID] // 0x000000018962B610-0x000000018962B630
	public virtual void Retarget(uint oldEntityRuntimeID, uint entityRuntimeID) {} // 0x0000000180CACFD0-0x0000000180CAD090
	// [XID] // 0x0000000189632E30-0x0000000189632E50
	public virtual void OnRefresh() {} // 0x0000000180CAC620-0x0000000180CAC6C0
	// [XID] // 0x000000018963A970-0x000000018963A990
	public virtual void HandleMixinInvokeEntry(UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000180CAC950-0x0000000180CACA00
	// [XID] // 0x0000000189642050-0x0000000189642070
	protected void StartRecordMixinInvokeEntry(out RecordInvokeEntryContext context) {
		context = default;
	} // 0x0000000180CAD670-0x0000000180CAD8F0
	// [XID] // 0x000000018965FFD0-0x000000018965FFF0
	public virtual void HandleRecoverData(RepeatedField<uint> data) {} // 0x0000000180CAC400-0x0000000180CAC4B0
	public static T CreateAbilityMixin<T>(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config)
		where T : BaseAbilityMixin, new() => default;
	// [XID] // 0x00000001895F2B50-0x00000001895F2B70
	protected virtual void AddEventListener() {} // 0x0000000180CAC1A0-0x0000000180CAC240
	// [XID] // 0x000000018961FD50-0x000000018961FD70
	protected virtual void RemoveEventListener() {} // 0x0000000180CAD130-0x0000000180CAD1D0
	// [XID] // 0x000000018965FCC0-0x000000018965FCE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180CAD990-0x0000000180CADA40
	// [XID] // 0x00000001896677E0-0x0000000189667800
	public virtual void OnPoolAllocated() {} // 0x0000000180CADC50-0x0000000180CADCF0
	// [XID] // 0x0000000189944DB0-0x0000000189944DD0
	public void Recycle() {} // 0x0000000180CAC550-0x0000000180CAC620
	// [XID] // 0x0000000189676930-0x0000000189676950
	public override string ToString() => default; // 0x0000000180CADEA0-0x0000000180CADFD0
	[BlackList] // 0x000000018967E1C0-0x000000018967E200
	// [XID] // 0x000000018967E1C0-0x000000018967E200
	public virtual void AutoAllocTypeFields() {} // 0x0000000180CABEF0-0x0000000180CABF90
	[BlackList] // 0x0000000189688E20-0x0000000189688E60
	// [XID] // 0x0000000189688E20-0x0000000189688E60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180CABF90-0x0000000180CAC130
	[BlackList] // 0x00000001896938D0-0x0000000189693910
	// [XID] // 0x00000001896938D0-0x0000000189693910
	public virtual void ReturnToObjectPool() {} // 0x0000000180CADD50-0x0000000180CADDF0
}

