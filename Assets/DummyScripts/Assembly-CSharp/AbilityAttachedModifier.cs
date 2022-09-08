/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityAttachedModifier : MessageBase, IMessage<AbilityAttachedModifier> // TypeDefIndex: 25996
{
	// Fields
	private static readonly MessageParser<AbilityAttachedModifier> _parser; // 0x00
	public const int IsInvalidFieldNumber = 1; // Metadata: 0x00B0A997
	private bool isInvalid_; // 0x18
	public const int OwnerEntityIdFieldNumber = 2; // Metadata: 0x00B0A99B
	private uint ownerEntityId_; // 0x1C
	public const int InstancedModifierIdFieldNumber = 3; // Metadata: 0x00B0A99F
	private uint instancedModifierId_; // 0x20
	public const int IsServerbuffModifierFieldNumber = 4; // Metadata: 0x00B0A9A3
	private bool isServerbuffModifier_; // 0x24
	public const int AttachNameHashFieldNumber = 5; // Metadata: 0x00B0A9A7
	private int attachNameHash_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityAttachedModifier> Parser { get => default; } // 0x0000000182D04600-0x0000000182D04690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D04070-0x0000000182D04100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D03CD0-0x0000000182D03D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D03360-0x0000000182D033C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D04AF0-0x0000000182D04BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D047C0-0x0000000182D04820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D04380-0x0000000182D04470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D04AA0-0x0000000182D04AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D03DF0-0x0000000182D03EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsInvalid { get => default; set {} } // 0x0000000182D03840-0x0000000182D038E0 0x0000000182D04A00-0x0000000182D04AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OwnerEntityId { get => default; set {} } // 0x0000000182D03460-0x0000000182D03500 0x0000000182D042E0-0x0000000182D04380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedModifierId { get => default; set {} } // 0x0000000182D033C0-0x0000000182D03460 0x0000000182D041A0-0x0000000182D04240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsServerbuffModifier { get => default; set {} } // 0x0000000182D04100-0x0000000182D041A0 0x0000000182D03500-0x0000000182D035A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int AttachNameHash { get => default; set {} } // 0x0000000182D04560-0x0000000182D04600 0x0000000182D04240-0x0000000182D042E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAttachedModifier() {} // 0x0000000182D05040-0x0000000182D050A0
	static AbilityAttachedModifier() {} // 0x0000000182D04F80-0x0000000182D05040

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAttachedModifier Clone() => default; // 0x0000000182D04470-0x0000000182D04560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAttachedModifier ShallowCopy() => default; // 0x0000000182D03D50-0x0000000182D03DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D03750-0x0000000182D037A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D04720-0x0000000182D04770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D04770-0x0000000182D047C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D037A0-0x0000000182D03840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D03A50-0x0000000182D03B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityAttachedModifier other) => default; // 0x0000000182D038E0-0x0000000182D03A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D03EE0-0x0000000182D04070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D04BE0-0x0000000182D04F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D04820-0x0000000182D04A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D03B20-0x0000000182D03CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityAttachedModifier other) {} // 0x0000000182D035A0-0x0000000182D03750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D03210-0x0000000182D03360
}

