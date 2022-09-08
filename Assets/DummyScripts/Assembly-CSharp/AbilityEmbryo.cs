/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityEmbryo : MessageBase, IMessage<AbilityEmbryo> // TypeDefIndex: 26004
{
	// Fields
	private static readonly MessageParser<AbilityEmbryo> _parser; // 0x00
	public const int AbilityIdFieldNumber = 1; // Metadata: 0x00B0AA37
	private uint abilityId_; // 0x18
	public const int AbilityNameHashFieldNumber = 2; // Metadata: 0x00B0AA3B
	private uint abilityNameHash_; // 0x1C
	public const int AbilityOverrideNameHashFieldNumber = 3; // Metadata: 0x00B0AA3F
	private uint abilityOverrideNameHash_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityEmbryo> Parser { get => default; } // 0x0000000183D12EC0-0x0000000183D12F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D12B10-0x0000000183D12BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D127D0-0x0000000183D12850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D120E0-0x0000000183D12140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D13330-0x0000000183D13420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D13080-0x0000000183D130E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D12C40-0x0000000183D12D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D132E0-0x0000000183D13330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D128F0-0x0000000183D129E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AbilityId { get => default; set {} } // 0x0000000183D12730-0x0000000183D127D0 0x0000000183D13240-0x0000000183D132E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AbilityNameHash { get => default; set {} } // 0x0000000183D12BA0-0x0000000183D12C40 0x0000000183D12140-0x0000000183D121E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AbilityOverrideNameHash { get => default; set {} } // 0x0000000183D11F30-0x0000000183D11FD0 0x0000000183D12E20-0x0000000183D12EC0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityEmbryo() {} // 0x0000000183D13770-0x0000000183D137D0
	static AbilityEmbryo() {} // 0x0000000183D136B0-0x0000000183D13770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityEmbryo Clone() => default; // 0x0000000183D12D30-0x0000000183D12E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityEmbryo ShallowCopy() => default; // 0x0000000183D12850-0x0000000183D128F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D12340-0x0000000183D12390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D12FE0-0x0000000183D13030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D13030-0x0000000183D13080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D12390-0x0000000183D12410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D12550-0x0000000183D12620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityEmbryo other) => default; // 0x0000000183D12410-0x0000000183D12550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D129E0-0x0000000183D12B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D13420-0x0000000183D136B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D130E0-0x0000000183D13240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D12620-0x0000000183D12730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityEmbryo other) {} // 0x0000000183D121E0-0x0000000183D12340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D11FD0-0x0000000183D120E0
}

