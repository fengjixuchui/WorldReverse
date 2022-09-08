/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityIdentifier : MessageBase, IMessage<AbilityIdentifier> // TypeDefIndex: 22987
{
	// Fields
	private static readonly MessageParser<AbilityIdentifier> _parser; // 0x00
	public const int InstancedAbilityIdFieldNumber = 1; // Metadata: 0x00B02D73
	private uint instancedAbilityId_; // 0x18
	public const int AbilityCasterIdFieldNumber = 2; // Metadata: 0x00B02D77
	private uint abilityCasterId_; // 0x1C
	public const int LocalIdFieldNumber = 3; // Metadata: 0x00B02D7B
	private int localId_; // 0x20
	public const int InstancedModifierIdFieldNumber = 4; // Metadata: 0x00B02D7F
	private uint instancedModifierId_; // 0x24
	public const int ModifierOwnerIdFieldNumber = 5; // Metadata: 0x00B02D83
	private uint modifierOwnerId_; // 0x28
	public const int IsServerbuffModifierFieldNumber = 6; // Metadata: 0x00B02D87
	private bool isServerbuffModifier_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityIdentifier> Parser { get => default; } // 0x0000000182230D80-0x0000000182230E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001822309D0-0x0000000182230A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001822304C0-0x0000000182230540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018222FA80-0x000000018222FAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182231350-0x0000000182231440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182230F40-0x0000000182230FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182230BA0-0x0000000182230C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182231300-0x0000000182231350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822305E0-0x00000001822306D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedAbilityId { get => default; set {} } // 0x000000018222FC20-0x000000018222FCC0 0x00000001822314E0-0x0000000182231580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AbilityCasterId { get => default; set {} } // 0x0000000182230930-0x00000001822309D0 0x000000018222FB80-0x000000018222FC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int LocalId { get => default; set {} } // 0x0000000182231260-0x0000000182231300 0x0000000182231440-0x00000001822314E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedModifierId { get => default; set {} } // 0x000000018222FAE0-0x000000018222FB80 0x0000000182230B00-0x0000000182230BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ModifierOwnerId { get => default; set {} } // 0x0000000182230890-0x0000000182230930 0x00000001822311C0-0x0000000182231260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsServerbuffModifier { get => default; set {} } // 0x0000000182230A60-0x0000000182230B00 0x000000018222FCC0-0x000000018222FD60

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityIdentifier() {} // 0x0000000182231A70-0x0000000182231AD0
	static AbilityIdentifier() {} // 0x00000001822319B0-0x0000000182231A70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityIdentifier Clone() => default; // 0x0000000182230C90-0x0000000182230D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityIdentifier ShallowCopy() => default; // 0x0000000182230540-0x00000001822305E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018222FF30-0x000000018222FF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182230EA0-0x0000000182230EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182230EF0-0x0000000182230F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018222FF80-0x0000000182230030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182230030-0x0000000182230100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityIdentifier other) => default; // 0x0000000182230100-0x00000001822302A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822306D0-0x0000000182230890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182231580-0x00000001822319B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182230FA0-0x00000001822311C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822302A0-0x00000001822304C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityIdentifier other) {} // 0x000000018222FD60-0x000000018222FF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018222F910-0x000000018222FA80
}

