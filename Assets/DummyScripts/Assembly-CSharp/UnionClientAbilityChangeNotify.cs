/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnionClientAbilityChangeNotify : UnionCmdBase<UnionClientAbilityChangeNotify, ClientAbilityChangeNotify> // TypeDefIndex: 21718
{
	// Fields
	public RepeatedMessageField<UnionAbilityInvokeEntry> Invokes; // 0x28

	// Constructors
	public UnionClientAbilityChangeNotify() {} // 0x000000018181F260-0x000000018181F300

	// Methods
	// [XID] // 0x0000000189979F30-0x0000000189979F50
	protected override void InternalMergeFrom(UnionClientAbilityChangeNotify other) {} // 0x000000018181F080-0x000000018181F1A0
	// [XID] // 0x00000001899816C0-0x00000001899816E0
	protected override void internalAfterDeserializeInWorkThread(CodedInputStream inputHelper) {} // 0x000000018181ED70-0x000000018181EFD0
	// [XID] // 0x0000000189988F30-0x0000000189988F50
	protected override void internalReset() {} // 0x000000018181EFD0-0x000000018181F080
	// [XID] // 0x0000000189990790-0x00000001899907B0
	protected override void internalDeleteReferenceMask() {} // 0x000000018181ECB0-0x000000018181ED70
	// [XID] // 0x00000001899982B0-0x00000001899982D0
	protected override void internalAddReferenceMask() {} // 0x000000018181F1A0-0x000000018181F260
}

