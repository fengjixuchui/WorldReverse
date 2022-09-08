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

public class AbilityTask // TypeDefIndex: 20567
{
	// Fields
	protected Queue<BaseEvent> _entityEvents; // 0x10
	protected bool _isEntityEventDirty; // 0x18
	private static int _nextDataId; // 0x00
	protected int _uid; // 0x1C
	protected int _taskIndex; // 0x20
	protected bool _isAsync; // 0x24
	protected bool _isDisabled; // 0x25
	protected float _duration; // 0x28
	protected float _delayTime; // 0x2C
	protected float _startTime; // 0x30
	protected float _endTime; // 0x34
	protected ConfigAbilityTask _config; // 0x38
	protected bool _isFinished; // 0x40
	protected bool _isStarted; // 0x41
	protected bool _isCommandHandled; // 0x42
	protected bool _origCanFinished; // 0x43
	protected bool _canFinished; // 0x44
	protected AbilityInstance _abilityInstance; // 0x48
	protected AbilityComponentProxy _abilityProxy; // 0x50
	protected Queue<BaseEvent> _abilityEvents; // 0x58

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189703C00-0x0000000189703C20 */ get => default; } // 0x0000000183597C50-0x0000000183597D80 
	public int uid { /* [XID] */ /* 0x000000018996D370-0x000000018996D390 */ get => default; } // 0x00000001835964E0-0x0000000183596580 
	public int taskIndex { /* [XID] */ /* 0x0000000189858280-0x00000001898582A0 */ get => default; } // 0x0000000183596B40-0x0000000183596BE0 
	public bool isAsync { /* [XID] */ /* 0x000000018985F310-0x000000018985F330 */ get => default; } // 0x0000000183597640-0x00000001835976E0 
	public virtual bool isSingleInstance { /* [XID] */ /* 0x0000000189866AF0-0x0000000189866B10 */ get => default; } // 0x0000000183597180-0x0000000183597220 
	public bool isDisabled { /* [XID] */ /* 0x0000000189755FF0-0x0000000189756010 */ get => default; } // 0x0000000183596660-0x0000000183596700 
	public bool isSingleFrame { /* [XID] */ /* 0x0000000189875840-0x0000000189875860 */ get => default; } // 0x0000000183597D80-0x0000000183597E30 
	public bool isFinished { /* [XID] */ /* 0x000000018987D3D0-0x000000018987D3F0 */ get => default; } // 0x0000000183597970-0x0000000183597A10 
	public bool isStarted { /* [XID] */ /* 0x0000000189884270-0x0000000189884290 */ get => default; } // 0x0000000183597ED0-0x0000000183597F70 

	// Constructors
	public AbilityTask() {} // 0x0000000183598130-0x00000001835981E0
	static AbilityTask() {} // 0x00000001835980D0-0x0000000183598130

	// Methods
	// [XID] // 0x000000018982C170-0x000000018982C190
	protected void InitEntityEventQueue() {} // 0x0000000183597F70-0x0000000183598020
	// [XID] // 0x0000000189833640-0x0000000189833660
	protected void DestroyEntityEventQueue() {} // 0x0000000183597890-0x0000000183597970
	// [XID] // 0x000000018983AB20-0x000000018983AB40
	public void FireEntityEvent(BaseEvent evt) {} // 0x00000001835973A0-0x0000000183597480
	// [XID] // 0x00000001898421C0-0x00000001898421E0
	public void FlushEntityEvent() {} // 0x0000000183596890-0x00000001835969E0
	// [XID] // 0x000000018988BA00-0x000000018988BA20
	public void TryFinish() {} // 0x0000000183597BB0-0x0000000183597C50
	// [XID] // 0x0000000189685CD0-0x0000000189685CF0
	public virtual void Init(ConfigAbilityTask taskConfig, AbilityInstance instance, AbilityComponentProxy proxy) {} // 0x0000000183597030-0x0000000183597180
	// [XID] // 0x000000018989A7B0-0x000000018989A7D0
	public virtual void Clear() {} // 0x0000000183597220-0x00000001835972D0
	// [XID] // 0x00000001898A1A80-0x00000001898A1AA0
	public virtual void Destroy(AbilityInstance instance, AbilityComponentProxy proxy) {} // 0x00000001835967A0-0x0000000183596890
	// [XID] // 0x00000001898A92F0-0x00000001898A9310
	protected virtual void RegisterAbilityEvent(AbilityInstance instance, AbilityComponentProxy proxy) {} // 0x0000000183596BE0-0x0000000183596CA0
	// [XID] // 0x00000001897335E0-0x0000000189733600
	protected virtual void UnregisterAbilityEvent(AbilityInstance instance, AbilityComponentProxy proxy) {} // 0x00000001835977D0-0x0000000183597890
	// [XID] // 0x00000001898B8240-0x00000001898B8260
	public virtual void ActiveTask(AbilityContext context, float CurrentTime) {} // 0x0000000183596E20-0x0000000183596F20
	// [XID] // 0x00000001898BF980-0x00000001898BF9A0
	public virtual bool CanStart(AbilityContext context, float CurrentTime) => default; // 0x0000000183597AE0-0x0000000183597BB0
	// [XID] // 0x00000001898C71E0-0x00000001898C7200
	public virtual bool OnTaskStart(AbilityContext context) => default; // 0x00000001835972D0-0x00000001835973A0
	// [XID] // 0x00000001898CE770-0x00000001898CE790
	public virtual bool OnTaskTick(AbilityContext context, float deltaTime) => default; // 0x0000000183596D40-0x0000000183596E20
	// [XID] // 0x00000001898D6150-0x00000001898D6170
	public virtual bool OnTaskEnd(AbilityContext context, EAbilityTaskResult result) => default; // 0x0000000183596580-0x0000000183596660
	// [XID] // 0x00000001898DDDA0-0x00000001898DDDC0
	public virtual bool IsDone(AbilityContext context) => default; // 0x00000001835976E0-0x00000001835977D0
	// [XID] // 0x00000001898E56A0-0x00000001898E56C0
	public virtual void ResetTask(AbilityContext context) {} // 0x0000000183596A90-0x0000000183596B40
	// [XID] // 0x00000001898ECF20-0x00000001898ECF40
	public virtual void OnPreUpdate() {} // 0x0000000183597E30-0x0000000183597ED0
	// [XID] // 0x00000001898F47A0-0x00000001898F47C0
	public virtual void OnFlushUpdate() {} // 0x00000001835975A0-0x0000000183597640
	// [XID] // 0x00000001898FC070-0x00000001898FC090
	public virtual AbilityTaskBlackboard CreateBlackboard(AbilityContext context) => default; // 0x0000000183597A10-0x0000000183597AE0
	// [XID] // 0x0000000189903B50-0x0000000189903B70
	public bool HasDependencies() => default; // 0x0000000183596CA0-0x0000000183596D40
	// [XID] // 0x000000018990B030-0x000000018990B050
	public void HandleContextCommands(List<AbilityContextCommand> commands) {} // 0x0000000183596F20-0x0000000183597030
	// [XID] // 0x0000000189912C60-0x0000000189912C80
	public void ResetCommandHandler() {} // 0x0000000183596700-0x00000001835967A0
	// [XID] // 0x000000018991A5B0-0x000000018991A5D0
	protected void HandleContextCommand(AbilityContextCommand command) {} // 0x0000000183597480-0x00000001835975A0
	// [XID] // 0x0000000189921D40-0x0000000189921D60
	protected virtual void HandleEventCommand(AbilityContextEventCommand command) {} // 0x00000001835969E0-0x0000000183596A90
	// [XID] // 0x0000000189929440-0x0000000189929460
	protected virtual void HandleBeingHitCommand(AbilityContextBeingHitCommand command) {} // 0x0000000183598020-0x00000001835980D0
}

