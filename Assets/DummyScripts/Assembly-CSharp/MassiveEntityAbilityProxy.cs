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

public sealed class MassiveEntityAbilityProxy : BaseAbilityActionContainer // TypeDefIndex: 20586
{
	// Fields
	private int _containerIndex; // 0x28
	private MassiveEntityProxy _entityProxy; // 0x30
	private string attackID; // 0x38
	private string actionID; // 0x40
	private ModifierStacking _stackType; // 0x48
	private float _abilityDurability; // 0x4C
	private List<ConfigAbilityAction> _onFlush; // 0x50
	private List<ConfigAbilityAction> _onPreUpdate; // 0x58

	// Constructors
	public MassiveEntityAbilityProxy() {} // 0x0000000184651FF0-0x0000000184652100

	// Methods
	// [XID] // 0x00000001897740E0-0x0000000189774100
	public static MassiveEntityAbilityProxy Create(MassiveEntityProxy entityProxy, int containerIndex) => default; // 0x0000000184651570-0x0000000184651650
	// [XID] // 0x000000018977B860-0x000000018977B880
	public static void Release(ref MassiveEntityAbilityProxy abilityProxy) {} // 0x00000001846519C0-0x0000000184651A80
	// [XID] // 0x00000001897832F0-0x0000000189783310
	public float GetAbilityDurability() => default; // 0x0000000184651790-0x0000000184651840
	// [XID] // 0x000000018978A8E0-0x000000018978A900
	public void SetAbilityDurability(float value) {} // 0x0000000184651220-0x00000001846512E0
	// [XID] // 0x0000000189792000-0x0000000189792020
	public void SetAbilityDurabilityInternal(float value) {} // 0x0000000184651F40-0x0000000184651FF0
	// [XID] // 0x0000000189799670-0x0000000189799690
	public bool TickAbilityDurability(float deltaTimeDurability) => default; // 0x00000001846518F0-0x00000001846519C0
	// [XID] // 0x00000001897A14E0-0x00000001897A1500
	public override BaseEntity GetOwner() => default; // 0x0000000184650CE0-0x0000000184650D90
	// [XID] // 0x00000001897A8C80-0x00000001897A8CA0
	public void Init(MassiveEntityProxy entityProxy, int containerIndex) {} // 0x00000001846512E0-0x00000001846513B0
	// [XID] // 0x00000001897B0560-0x00000001897B0580
	public void Destroy() {} // 0x0000000184650E00-0x0000000184650F30
	// [XID] // 0x00000001897B8380-0x00000001897B83A0
	private bool HasAction(List<ConfigAbilityAction> actionList) => default; // 0x0000000184651650-0x0000000184651720
	// [XID] // 0x00000001897C0420-0x00000001897C0440
	public bool HasActionOnFlush() => default; // 0x0000000184651840-0x00000001846518F0
	// [XID] // 0x00000001897C7C90-0x00000001897C7CB0
	public void HandleOnFlush() {} // 0x0000000184651D80-0x0000000184651F40
	// [XID] // 0x00000001897CEF00-0x00000001897CEF20
	public bool HasActionOnPreUpdate() => default; // 0x0000000184651BD0-0x0000000184651C80
	// [XID] // 0x00000001897D6700-0x00000001897D6720
	public void HandleOnPreUpdate() {} // 0x00000001846513B0-0x0000000184651570
	// [XID] // 0x00000001897DDE90-0x00000001897DDEB0
	public void Attach(ConfigMassiveElementTriggerAction config, out bool hasActionOnFlush, out bool hasActionOnPreUpdate) {
		hasActionOnFlush = default;
		hasActionOnPreUpdate = default;
	} // 0x0000000184650F30-0x0000000184651220
	// [XID] // 0x00000001897E5940-0x00000001897E5960
	private bool HandleStack(ConfigMassiveElementTriggerAction config) => default; // 0x0000000184651C80-0x0000000184651D80
	// [XID] // 0x00000001897ED430-0x00000001897ED450
	public override bool Detach() => default; // 0x0000000184651A80-0x0000000184651BD0
}

