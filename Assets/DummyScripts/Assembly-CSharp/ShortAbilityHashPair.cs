/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShortAbilityHashPair : MessageBase, IMessage<ShortAbilityHashPair> // TypeDefIndex: 24307
{
	// Fields
	private static readonly MessageParser<ShortAbilityHashPair> _parser; // 0x00
	public const int AbilityNameHashFieldNumber = 1; // Metadata: 0x00B0622B
	private int abilityNameHash_; // 0x18
	public const int AbilityConfigHashFieldNumber = 2; // Metadata: 0x00B0622F
	private int abilityConfigHash_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShortAbilityHashPair> Parser { get => default; } // 0x0000000181610210-0x00000001816102A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018160FDC0-0x000000018160FE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018160FAB0-0x000000018160FB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018160F500-0x000000018160F560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001816105A0-0x0000000181610690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001816103D0-0x0000000181610430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018160FF90-0x0000000181610080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181610550-0x00000001816105A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018160FBD0-0x000000018160FCC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int AbilityNameHash { get => default; set {} } // 0x000000018160FE50-0x000000018160FEF0 0x000000018160F560-0x000000018160F600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int AbilityConfigHash { get => default; set {} } // 0x0000000181610170-0x0000000181610210 0x000000018160FEF0-0x000000018160FF90

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShortAbilityHashPair() {} // 0x0000000181610950-0x00000001816109B0
	static ShortAbilityHashPair() {} // 0x0000000181610890-0x0000000181610950

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShortAbilityHashPair Clone() => default; // 0x0000000181610080-0x0000000181610170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShortAbilityHashPair ShallowCopy() => default; // 0x000000018160FB30-0x000000018160FBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018160F730-0x000000018160F780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181610330-0x0000000181610380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181610380-0x00000001816103D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018160F780-0x000000018160F7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018160F7F0-0x000000018160F8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShortAbilityHashPair other) => default; // 0x000000018160F8C0-0x000000018160F9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018160FCC0-0x000000018160FDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181610690-0x0000000181610890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181610430-0x0000000181610550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018160F9E0-0x000000018160FAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShortAbilityHashPair other) {} // 0x000000018160F600-0x000000018160F730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018160F400-0x000000018160F500
}

