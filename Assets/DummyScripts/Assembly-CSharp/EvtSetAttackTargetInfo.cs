/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtSetAttackTargetInfo : MessageBase, IMessage<EvtSetAttackTargetInfo> // TypeDefIndex: 23022
{
	// Fields
	private static readonly MessageParser<EvtSetAttackTargetInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B02F7B
	private uint entityId_; // 0x18
	public const int AttackTargetIdFieldNumber = 2; // Metadata: 0x00B02F7F
	private uint attackTargetId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtSetAttackTargetInfo> Parser { get => default; } // 0x0000000181B0EAF0-0x0000000181B0EB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B0E7E0-0x0000000181B0E870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B0E4D0-0x0000000181B0E550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181B0DEC0-0x0000000181B0DF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B0EF20-0x0000000181B0F010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B0ED50-0x0000000181B0EDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B0E910-0x0000000181B0EA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B0EED0-0x0000000181B0EF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B0E5F0-0x0000000181B0E6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181B0ECB0-0x0000000181B0ED50 0x0000000181B0F010-0x0000000181B0F0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AttackTargetId { get => default; set {} } // 0x0000000181B0DF20-0x0000000181B0DFC0 0x0000000181B0E870-0x0000000181B0E910

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSetAttackTargetInfo() {} // 0x0000000181B0F370-0x0000000181B0F3D0
	static EvtSetAttackTargetInfo() {} // 0x0000000181B0F2B0-0x0000000181B0F370

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSetAttackTargetInfo Clone() => default; // 0x0000000181B0EA00-0x0000000181B0EAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSetAttackTargetInfo ShallowCopy() => default; // 0x0000000181B0E550-0x0000000181B0E5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181B0E0F0-0x0000000181B0E140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B0EC10-0x0000000181B0EC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B0EC60-0x0000000181B0ECB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181B0E140-0x0000000181B0E1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181B0E2D0-0x0000000181B0E3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtSetAttackTargetInfo other) => default; // 0x0000000181B0E1B0-0x0000000181B0E2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B0E6E0-0x0000000181B0E7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B0F0B0-0x0000000181B0F2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B0EDB0-0x0000000181B0EED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181B0E3A0-0x0000000181B0E4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtSetAttackTargetInfo other) {} // 0x0000000181B0DFC0-0x0000000181B0E0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181B0DDC0-0x0000000181B0DEC0
}

