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

public class AbilityContext // TypeDefIndex: 20576
{
	// Fields
	protected Ability _ability; // 0x10
	protected AbilityComponentProxy _abilityProxy; // 0x18
	protected float _currentTime; // 0x20
	protected float _lastDeltaTime; // 0x24
	protected BaseEntity _owner; // 0x28
	protected BaseEntity _instigator; // 0x30
	protected List<BaseEntity> _targets; // 0x38
	protected Dictionary<int, AbilityTaskBlackboard> _taskBlackboardDic; // 0x40
	protected List<AbilityContextCommand> _contextPendingCommandsFMT; // 0x48
	protected List<AbilityContextCommand> _contextPendingCommands; // 0x50

	// Properties
	public List<AbilityContextCommand> contextPendingCommands { /* [XID] */ /* 0x0000000189ABC300-0x0000000189ABC320 */ get => default; } // 0x000000018479FB00-0x000000018479FBA0 

	// Constructors
	public AbilityContext() {} // 0x00000001847A08C0-0x00000001847A0990

	// Methods
	// [XID] // 0x0000000189AA54A0-0x0000000189AA54C0
	public float GetCurrentTime() => default; // 0x00000001847A00B0-0x00000001847A0160
	// [XID] // 0x0000000189AACCE0-0x0000000189AACD00
	public float GetDeltaTime() => default; // 0x00000001847A0350-0x00000001847A0400
	// [XID] // 0x0000000189AB4590-0x0000000189AB45B0
	public void PendCommandFMT(AbilityContextCommand cmd) {} // 0x000000018479FC70-0x000000018479FD40
	// [XID] // 0x0000000189AC3BC0-0x0000000189AC3BE0
	public void ClearCommands() {} // 0x00000001847A0810-0x00000001847A08C0
	// [XID] // 0x0000000189ACB080-0x0000000189ACB0A0
	private void ClearCommandsInternal(List<AbilityContextCommand> contextPendingCommands) {} // 0x000000018479F8F0-0x000000018479FA00
	// [XID] // 0x0000000189667AD0-0x0000000189667AF0
	public void Init(Ability ability, AbilityComponentProxy proxy, BaseEntity owner, BaseEntity instigater) {} // 0x000000018479FA00-0x000000018479FB00
	// [XID] // 0x0000000189ADA4E0-0x0000000189ADA500
	public void Clear() {} // 0x000000018479FBA0-0x000000018479FC70
	// [XID] // 0x00000001897515A0-0x00000001897515C0
	public void Destroy() {} // 0x000000018479F840-0x000000018479F8F0
	// [XID] // 0x0000000189BB5EB0-0x0000000189BB5ED0
	public void AllocateBlackboard(int capcity) {} // 0x000000018479FD40-0x000000018479FE20
	// [XID] // 0x0000000189AF1470-0x0000000189AF1490
	public void AddBlackboard(AbilityTask task) {} // 0x00000001847A0400-0x00000001847A0510
	// [XID] // 0x0000000189AF8A40-0x0000000189AF8A60
	public AbilityTaskBlackboard GetBlackboard(AbilityTask task) => default; // 0x000000018479FFA0-0x00000001847A00B0
	// [XID] // 0x0000000189B00050-0x0000000189B00070
	public void ClearBlackboard() {} // 0x00000001847A0510-0x00000001847A06D0
	// [XID] // 0x0000000189B07550-0x0000000189B07570
	public void DestroyBlackboard() {} // 0x00000001847A0160-0x00000001847A0350
	// [XID] // 0x0000000189B0ED70-0x0000000189B0ED90
	public void PreUpdate() {} // 0x000000018479FE20-0x000000018479FFA0
	// [XID] // 0x0000000189712BB0-0x0000000189712BD0
	public Ability GetAbility() => default; // 0x00000001847A06D0-0x00000001847A0770
	// [XID] // 0x0000000189B1D770-0x0000000189B1D790
	public AbilityComponentProxy GetAbilityProxy() => default; // 0x00000001847A0770-0x00000001847A0810
	// [XID] // 0x0000000189B25120-0x0000000189B25140
	public bool IsValid() => default; // 0x000000018479F790-0x000000018479F840
}

