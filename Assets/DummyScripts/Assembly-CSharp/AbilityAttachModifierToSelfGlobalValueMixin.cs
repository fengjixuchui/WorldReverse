/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityAttachModifierToSelfGlobalValueMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14466
{
	// Fields
	private AttachModifierToSelfGlobalValueMixin config; // 0x70
	private DynamicActorValue<SafeFloat> _valueHandle; // 0x78
	private float[] _valueSteps; // 0x80
	private int _curModifierStepIx; // 0x88

	// Constructors
	public AbilityAttachModifierToSelfGlobalValueMixin() {} // 0x00000001828B8F40-0x00000001828B8FA0

	// Methods
	// [XID] // 0x00000001899FBF40-0x00000001899FBF60
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001828B7950-0x00000001828B7D10
	// [XID] // 0x0000000189A03350-0x0000000189A03370
	public override void Clear() {} // 0x00000001828B7D80-0x00000001828B7E50
	// [XID] // 0x0000000189A0A9B0-0x0000000189A0A9D0
	public override void OnBeforePoolRecycled() {} // 0x00000001828B8B90-0x00000001828B8C40
	// [XID] // 0x0000000189A12160-0x0000000189A12180
	public override void OnAdded(bool syncToServer) {} // 0x00000001828B6A60-0x00000001828B6C60
	// [XID] // 0x0000000189A195D0-0x0000000189A195F0
	private void SubAttachGlobalValue(bool syncToServer) {} // 0x00000001828B6EC0-0x00000001828B7150
	// [XID] // 0x0000000189A20C90-0x0000000189A20CB0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001828B7870-0x00000001828B7950
	// [XID] // 0x0000000189A27FC0-0x0000000189A27FE0
	private void SubDetachGlobalValue() {} // 0x00000001828B8200-0x00000001828B8300
	// [XID] // 0x0000000189A2F6F0-0x0000000189A2F710
	private void OnValueChanged(SafeFloat fromValue, SafeFloat toValue) {} // 0x00000001828B80D0-0x00000001828B8200
	// [XID] // 0x0000000189A37120-0x0000000189A37140
	private void TickModifierByValue(float curValue) {} // 0x00000001828B74F0-0x00000001828B7870
	// [XID] // 0x0000000189A3E770-0x0000000189A3E790
	private int CalculateCurrentStep(float curValue) => default; // 0x00000001828B8550-0x00000001828B8690
	// [XID] // 0x0000000189A45EC0-0x0000000189A45EE0
	private void RemoveAllStepModifier(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB763 */) {} // 0x00000001828B86F0-0x00000001828B88C0
	// [XID] // 0x0000000189A4D5B0-0x0000000189A4D5D0
	public override string ToString() => default; // 0x00000001828B8DC0-0x00000001828B8F40
	// [XID] // 0x0000000189A54E70-0x0000000189A54E90
	private LCAbility GetAbility() => default; // 0x00000001828B8A50-0x00000001828B8B90
	// [XID] // 0x0000000189A5C780-0x0000000189A5C7A0
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001828B7150-0x00000001828B7490
	// [XID] // 0x0000000189A64070-0x0000000189A64090
	private void UpdateAttachedModifier() {} // 0x00000001828B88C0-0x00000001828B8A50
	// [XID] // 0x0000000189A6BA20-0x0000000189A6BA40
	private void ClearReduntantModifier(string curStepModifier) {} // 0x00000001828B7E50-0x00000001828B8070
	// [XID] // 0x0000000189A731C0-0x0000000189A731E0
	private void TryApplyModifier(string modifierName) {} // 0x00000001828B8390-0x00000001828B84F0
	[BlackList] // 0x0000000189A7AC70-0x0000000189A7ACB0
	// [XID] // 0x0000000189A7AC70-0x0000000189A7ACB0
	public override void AutoAllocTypeFields() {} // 0x00000001828B6CF0-0x00000001828B6D90
	[BlackList] // 0x0000000189A85310-0x0000000189A85350
	// [XID] // 0x0000000189A85310-0x0000000189A85350
	public override void AutoRecycleTypeFields() {} // 0x00000001828B6D90-0x00000001828B6E50
	[BlackList] // 0x0000000189A8FD10-0x0000000189A8FD50
	// [XID] // 0x0000000189A8FD10-0x0000000189A8FD50
	public override void ReturnToObjectPool() {} // 0x00000001828B8D20-0x00000001828B8DC0
}

