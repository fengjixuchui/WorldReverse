/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class AbilityAttachModifierToElementDurabilityMixin : BaseAbilityMixin // TypeDefIndex: 14463
{
	// Fields
	private AttachModifierToElementDurabilityMixin config; // 0x70
	private VCBillboard _vcBillboard; // 0x78
	private float[] _valueSteps; // 0x80
	private ElementType _elementType; // 0x88
	private int _curModifierStepIx; // 0x8C
	private LCAbilityElement _lcElement; // 0x90
	private EntityMultiPlayerExcelConfig _multiConfig; // 0x98
	private float _multiRatio; // 0xA0

	// Constructors
	public AbilityAttachModifierToElementDurabilityMixin() {} // 0x000000018178FC50-0x000000018178FCD0

	// Methods
	// [XID] // 0x0000000189873430-0x0000000189873450
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018178E920-0x000000018178EBB0
	// [XID] // 0x000000018987AFA0-0x000000018987AFC0
	private void InitValueSteps() {} // 0x000000018178E400-0x000000018178E4E0
	// [XID] // 0x0000000189881FA0-0x0000000189881FC0
	private bool UpdateValueSteps() => default; // 0x000000018178F120-0x000000018178F630
	// [XID] // 0x00000001898896D0-0x00000001898896F0
	private void OnCombatCallBack(VCCombatBillboardPlugin billboardPlugin) {} // 0x000000018178EE40-0x000000018178EF10
	// [XID] // 0x0000000189890A80-0x0000000189890AA0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x000000018178ED60-0x000000018178EE40
	// [XID] // 0x00000001898980A0-0x00000001898980C0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x000000018178EF10-0x000000018178EFE0
	// [XID] // 0x000000018989F3A0-0x000000018989F3C0
	public override void Clear() {} // 0x000000018178ECA0-0x000000018178ED60
	// [XID] // 0x00000001898A6FA0-0x00000001898A6FC0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018178E780-0x000000018178E920
	// [XID] // 0x00000001898AE880-0x00000001898AE8A0
	public override void Tick(float inDeltaTime) {} // 0x000000018178F860-0x000000018178FA60
	// [XID] // 0x00000001898B5BF0-0x00000001898B5C10
	private void TickModifierByValue() {} // 0x000000018178E4E0-0x000000018178E700
	// [XID] // 0x00000001898BD560-0x00000001898BD580
	private int CalculateCurrentStep(float curValue) => default; // 0x000000018178EFE0-0x000000018178F120
	// [XID] // 0x00000001898C4E20-0x00000001898C4E40
	private void RemoveStepModifier(int index) {} // 0x000000018178E240-0x000000018178E400
	// [XID] // 0x00000001898CC2E0-0x00000001898CC300
	private void RemoveAllStepModifier(RemoveAbilityReason removeReason) {} // 0x000000018178F690-0x000000018178F860
	// [XID] // 0x00000001898D3B90-0x00000001898D3BB0
	public override string ToString() => default; // 0x000000018178FA60-0x000000018178FC50
}

