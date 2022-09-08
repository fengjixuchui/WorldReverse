/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityAbilityInvokeEntry : MessageBase, IMessage<EntityAbilityInvokeEntry> // TypeDefIndex: 21801
{
	// Fields
	private static readonly MessageParser<EntityAbilityInvokeEntry> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B00067
	private uint entityId_; // 0x18
	public const int InvokesFieldNumber = 2; // Metadata: 0x00B0006B
	private static readonly FieldCodec<AbilityInvokeEntry> _repeated_invokes_codec; // 0x08
	private readonly RepeatedMessageField<AbilityInvokeEntry> invokes_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityAbilityInvokeEntry> Parser { get => default; } // 0x00000001850A52C0-0x00000001850A5350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001850A4FF0-0x00000001850A5080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001850A4CE0-0x00000001850A4D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001850A46B0-0x00000001850A4710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001850A5790-0x00000001850A5880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001850A55A0-0x00000001850A5600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001850A5080-0x00000001850A5170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001850A5740-0x00000001850A5790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001850A4E00-0x00000001850A4EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001850A5500-0x00000001850A55A0 0x00000001850A5880-0x00000001850A5920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AbilityInvokeEntry> Invokes { get => default; } // 0x00000001850A5260-0x00000001850A52C0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAbilityInvokeEntry() {} // 0x00000001850A5C10-0x00000001850A5CA0
	static EntityAbilityInvokeEntry() {} // 0x00000001850A5B00-0x00000001850A5C10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAbilityInvokeEntry Clone() => default; // 0x00000001850A5170-0x00000001850A5260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAbilityInvokeEntry ShallowCopy() => default; // 0x00000001850A4D60-0x00000001850A4E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001850A4870-0x00000001850A48C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850A53E0-0x00000001850A5470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850A5470-0x00000001850A5500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001850A48C0-0x00000001850A49A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001850A4AD0-0x00000001850A4BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityAbilityInvokeEntry other) => default; // 0x00000001850A49A0-0x00000001850A4AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001850A4EF0-0x00000001850A4FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001850A5920-0x00000001850A5B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001850A5600-0x00000001850A5740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001850A4BA0-0x00000001850A4CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityAbilityInvokeEntry other) {} // 0x00000001850A4710-0x00000001850A4870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001850A4550-0x00000001850A46B0
}

