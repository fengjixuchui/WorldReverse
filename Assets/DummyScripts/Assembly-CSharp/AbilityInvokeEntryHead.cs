/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityInvokeEntryHead : MessageBase, IMessage<AbilityInvokeEntryHead> // TypeDefIndex: 21744
{
	// Fields
	private static readonly MessageParser<AbilityInvokeEntryHead> _parser; // 0x00
	public const int InstancedAbilityIdFieldNumber = 1; // Metadata: 0x00AFFE4F
	private uint instancedAbilityId_; // 0x18
	public const int InstancedModifierIdFieldNumber = 2; // Metadata: 0x00AFFE53
	private uint instancedModifierId_; // 0x1C
	public const int LocalIdFieldNumber = 3; // Metadata: 0x00AFFE57
	private int localId_; // 0x20
	public const int ModifierConfigLocalIdFieldNumber = 4; // Metadata: 0x00AFFE5B
	private int modifierConfigLocalId_; // 0x24
	public const int TargetIdFieldNumber = 5; // Metadata: 0x00AFFE5F
	private uint targetId_; // 0x28
	public const int IsServerbuffModifierFieldNumber = 6; // Metadata: 0x00AFFE63
	private bool isServerbuffModifier_; // 0x2C
	public const int ServerBuffUidFieldNumber = 7; // Metadata: 0x00AFFE67
	private uint serverBuffUid_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityInvokeEntryHead> Parser { get => default; } // 0x0000000184D4C6C0-0x0000000184D4C750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184D4C270-0x0000000184D4C300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184D4BE80-0x0000000184D4BF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184D4B270-0x0000000184D4B2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184D4CD70-0x0000000184D4CE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184D4C920-0x0000000184D4C980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184D4C440-0x0000000184D4C530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184D4CD20-0x0000000184D4CD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184D4BFA0-0x0000000184D4C090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedAbilityId { get => default; set {} } // 0x0000000184D4B370-0x0000000184D4B410 0x0000000184D4CF00-0x0000000184D4CFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedModifierId { get => default; set {} } // 0x0000000184D4B2D0-0x0000000184D4B370 0x0000000184D4C3A0-0x0000000184D4C440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int LocalId { get => default; set {} } // 0x0000000184D4CC80-0x0000000184D4CD20 0x0000000184D4CE60-0x0000000184D4CF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int ModifierConfigLocalId { get => default; set {} } // 0x0000000184D4B850-0x0000000184D4B8F0 0x0000000184D4B6F0-0x0000000184D4B790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetId { get => default; set {} } // 0x0000000184D4C980-0x0000000184D4CA20 0x0000000184D4C620-0x0000000184D4C6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsServerbuffModifier { get => default; set {} } // 0x0000000184D4C300-0x0000000184D4C3A0 0x0000000184D4B410-0x0000000184D4B4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ServerBuffUid { get => default; set {} } // 0x0000000184D4BDE0-0x0000000184D4BE80 0x0000000184D4C830-0x0000000184D4C8D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntryHead() {} // 0x0000000184D4D520-0x0000000184D4D580
	static AbilityInvokeEntryHead() {} // 0x0000000184D4D460-0x0000000184D4D520

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntryHead Clone() => default; // 0x0000000184D4C530-0x0000000184D4C620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntryHead ShallowCopy() => default; // 0x0000000184D4BF00-0x0000000184D4BFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184D4B6A0-0x0000000184D4B6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D4C7E0-0x0000000184D4C830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D4C8D0-0x0000000184D4C920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184D4B790-0x0000000184D4B850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184D4BAA0-0x0000000184D4BB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityInvokeEntryHead other) => default; // 0x0000000184D4B8F0-0x0000000184D4BAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184D4C090-0x0000000184D4C270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184D4CFA0-0x0000000184D4D460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184D4CA20-0x0000000184D4CC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184D4BB70-0x0000000184D4BDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityInvokeEntryHead other) {} // 0x0000000184D4B4B0-0x0000000184D4B6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184D4B0E0-0x0000000184D4B270
}

