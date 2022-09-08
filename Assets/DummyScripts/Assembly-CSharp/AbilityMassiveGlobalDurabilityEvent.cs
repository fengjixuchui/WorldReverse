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

public sealed class AbilityMassiveGlobalDurabilityEvent : AbilityTaskEvent // TypeDefIndex: 20592
{
	// Fields
	public uint attackerId; // 0x10
	public ElementType elementType; // 0x14
	public float durability; // 0x18
	private List<MassiveEntityProxy> _proxys; // 0x20

	// Properties
	public override AbilityEventID eventID { /* [XID] */ /* 0x0000000189632220-0x0000000189632240 */ get => default; } // 0x0000000184D26A90-0x0000000184D26B30 
	public List<MassiveEntityProxy> proxys { /* [XID] */ /* 0x0000000189639D10-0x0000000189639D30 */ get => default; } // 0x0000000184D269F0-0x0000000184D26A90 

	// Constructors
	public AbilityMassiveGlobalDurabilityEvent() {} // 0x0000000184D26C00-0x0000000184D26CA0

	// Methods
	// [XID] // 0x0000000189641220-0x0000000189641240
	public void PushProxy(MassiveEntityProxy proxy) {} // 0x0000000184D26B30-0x0000000184D26C00
	// [XID] // 0x0000000189648BA0-0x0000000189648BC0
	public void Init(uint pAttackerId, ElementType pElementType, float pDurability) {} // 0x0000000184D26840-0x0000000184D26920
	// [XID] // 0x0000000189650200-0x0000000189650220
	public override void Destroy() {} // 0x0000000184D26780-0x0000000184D26840
}

