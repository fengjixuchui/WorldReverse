/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BaseActorActionContext // TypeDefIndex: 14617
{
	// Fields
	public static BaseAbilityMixin[] EMPTY_INSTANCED_MIXINS; // 0x00
	[InspectorCollapsedFoldout] // 0x000000018981F560-0x000000018981F570
	public BaseAbilityMixin[] instancedMixins; // 0x10
	private List<Tuple<int, string>> _attachedPatternIndices; // 0x18
	private List<Tuple<LCAbility, ConfigBuffDebuffResistance>> _attachedResistanceBuffDebuffs; // 0x20
	private List<Tuple<LCAbility, ElementType, float>> _attachedElementTypeResistance; // 0x28
	private IList<BaseAbilityMixin> _tickMixins; // 0x30

	// Nested types
	private enum OwnedPredicateState // TypeDefIndex: 14618
	{
		Attach = 0,
		Detach = 1
	}

	// Constructors
	public BaseActorActionContext() {} // 0x00000001837F3180-0x00000001837F3220
	static BaseActorActionContext() {} // 0x00000001837F3100-0x00000001837F3180

	// Methods
	// [XID] // 0x0000000189826B10-0x0000000189826B30
	public BaseAbilityMixin GetInstancedMixin(int mixinLocalID) => default; // 0x00000001837F2EE0-0x00000001837F3050
	public abstract string GetDebugContextName();
	public abstract LCAbility GetOwner();
	// [XID] // 0x000000018982E1C0-0x000000018982E1E0
	public virtual void OnEnable() {} // 0x00000001837F0E50-0x00000001837F0FF0
	// [XID] // 0x00000001898358B0-0x00000001898358D0
	public virtual void OnDisable() {} // 0x00000001837F0B40-0x00000001837F0CD0
	// [XID] // 0x000000018983CF60-0x000000018983CF80
	public virtual void Retarget(uint oldEntityRuntimeID, uint newEntityRuntimeID) {} // 0x00000001837F1410-0x00000001837F1740
	// [Conditional] // 0x00000001898445C0-0x0000000189844630
	// [Conditional] // 0x00000001898445C0-0x0000000189844630
	// [XID] // 0x00000001898445C0-0x0000000189844630
	protected void DebugLogContext(string format, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] args) {} // 0x00000001837F1820-0x00000001837F19B0
	private void CheckInit<T>(ref List<T> ls) {}
	// [XID] // 0x0000000189858EB0-0x0000000189858ED0
	public void AttachEffectPatternIndex(int patternIx, string effectPattern) {} // 0x00000001837F0A10-0x00000001837F0B40
	// [XID] // 0x00000001898600B0-0x00000001898600D0
	protected void AttachToActor(LCAbility actor) {} // 0x00000001837F3050-0x00000001837F3100
	// [XID] // 0x000000018984EF30-0x000000018984EF50
	public void DetachAttachModifierFromActor(LCAbility actor, RemoveAbilityReason removeReason) {} // 0x00000001837F1C90-0x00000001837F1DA0
	// [XID] // 0x00000001898400A0-0x00000001898400C0
	public void DetachFromActor(LCAbility actor, RemoveAbilityReason removeReason) {} // 0x00000001837F2630-0x00000001837F2940
	// [XID] // 0x00000001898DB730-0x00000001898DB750
	public virtual void Clear() {} // 0x00000001837F10E0-0x00000001837F1410
	// [XID] // 0x000000018987DEF0-0x000000018987DF10
	public void AttachBuffDebuffResistance(BaseEntity target, ConfigBuffDebuffResistance resistance) {} // 0x00000001837F2CE0-0x00000001837F2E40
	// [XID] // 0x0000000189884F60-0x0000000189884F80
	public void AttachElementTypeResistance(BaseEntity target, ElementType elementType, float durationRatio) {} // 0x00000001837F2290-0x00000001837F2430
	// [XID] // 0x00000001898A7180-0x00000001898A71A0
	private void DetachElementTypeResistances() {} // 0x00000001837F01F0-0x00000001837F0440
	// [XID] // 0x0000000189B82800-0x0000000189B82820
	public void InitTickMixins() {} // 0x00000001837F2A30-0x00000001837F2C40
	// [XID] // 0x0000000189B9FD00-0x0000000189B9FD20
	protected virtual void TryAddTickContext() {} // 0x00000001837F0440-0x00000001837F04E0
	// [XID] // 0x00000001898A25D0-0x00000001898A25F0
	protected virtual void OnMixinAdd(BaseAbilityMixin mixin, bool flush = false /* Metadata: 0x00AEB99F */) {} // 0x00000001837F0FF0-0x00000001837F10E0
	// [XID] // 0x00000001898A9BC0-0x00000001898A9BE0
	protected virtual void OnMixinRemove(BaseAbilityMixin mixin, bool flush = false /* Metadata: 0x00AEB9A0 */) {} // 0x00000001837F2940-0x00000001837F2A30
	// [XID] // 0x00000001898B1630-0x00000001898B1650
	protected virtual void TryAddEventMixin(BaseAbilityMixin mixin) {} // 0x00000001837F1740-0x00000001837F1820
	// [XID] // 0x00000001898B8FA0-0x00000001898B8FC0
	protected virtual void TryRemoveEventMixin(BaseAbilityMixin mixin) {} // 0x00000001837F1DA0-0x00000001837F1E80
	// [XID] // 0x00000001898C0540-0x00000001898C0560
	protected virtual void TryAddTickMixin(BaseAbilityMixin mixin, bool checkTickContext = false /* Metadata: 0x00AEB9A1 */) {} // 0x00000001837F0CD0-0x00000001837F0E50
	// [XID] // 0x00000001898C7D60-0x00000001898C7D80
	protected virtual void TryRemoveTickMixin(BaseAbilityMixin mixin, bool checkTickContext = false /* Metadata: 0x00AEB9A2 */) {} // 0x00000001837F05A0-0x00000001837F06E0
	// [XID] // 0x00000001898CF580-0x00000001898CF5A0
	private void ClearTickMixins() {} // 0x00000001837F1E80-0x00000001837F2060
	// [XID] // 0x00000001898D6DB0-0x00000001898D6DD0
	public void TickMixins(float inDeltaTime) {} // 0x00000001837F1A50-0x00000001837F1C90
	// [XID] // 0x00000001898DEBB0-0x00000001898DEBD0
	public bool HasTickMixins() => default; // 0x00000001837F04E0-0x00000001837F05A0
	// [XID] // 0x00000001898E6270-0x00000001898E6290
	public void RefreshMixinTickOnSetEnabled(BaseAbilityMixin mixin) {} // 0x00000001837F2100-0x00000001837F2290
	// [XID] // 0x00000001898EDB40-0x00000001898EDB60
	protected virtual void RefreshContextTickOnSetMixinEnabled() {} // 0x00000001837F19B0-0x00000001837F1A50
	// [XID] // 0x00000001898F5450-0x00000001898F5470
	public void InitEventMixins() {} // 0x00000001837F2430-0x00000001837F2630
	// [XID] // 0x000000018991F850-0x000000018991F870
	private void ClearEventMixins() {} // 0x00000001837F0940-0x00000001837F0A10
	// [XID] // 0x0000000189904580-0x00000001899045A0
	public virtual void CheckHandleMixinsIfChangeAuthority() {} // 0x00000001837F2C40-0x00000001837F2CE0
	// [XID] // 0x000000018990BCC0-0x000000018990BCE0
	public void AttachModifier(ActorModifier modifier) {} // 0x00000001837F06E0-0x00000001837F0810
	// [XID] // 0x00000001898B5E30-0x00000001898B5E50
	public void RemoveAttachedModifier(ActorModifier modifier) {} // 0x00000001837F0810-0x00000001837F0940
	// [XID] // 0x000000018991B040-0x000000018991B060
	public virtual uint GetAttachContainerKey() => default; // 0x00000001837F2E40-0x00000001837F2EE0
	// [XID] // 0x0000000189922670-0x0000000189922690
	public virtual ActorActionContextType GetContextType() => default; // 0x00000001837F2060-0x00000001837F2100
}

