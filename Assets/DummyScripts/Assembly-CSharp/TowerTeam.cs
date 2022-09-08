/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerTeam : MessageBase, IMessage<TowerTeam> // TypeDefIndex: 25693
{
	// Fields
	private static readonly MessageParser<TowerTeam> _parser; // 0x00
	public const int TowerTeamIdFieldNumber = 1; // Metadata: 0x00B095AB
	private uint towerTeamId_; // 0x18
	public const int AvatarGuidListFieldNumber = 2; // Metadata: 0x00B095AF
	private static readonly FieldCodec<ulong> _repeated_avatarGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> avatarGuidList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerTeam> Parser { get => default; } // 0x0000000184E5BF70-0x0000000184E5C000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184E5BCA0-0x0000000184E5BD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184E5B990-0x0000000184E5BA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184E5B270-0x0000000184E5B2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184E5C320-0x0000000184E5C410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184E5C130-0x0000000184E5C190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184E5BD30-0x0000000184E5BE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184E5C2D0-0x0000000184E5C320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184E5BAB0-0x0000000184E5BBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TowerTeamId { get => default; set {} } // 0x0000000184E5B8F0-0x0000000184E5B990 0x0000000184E5B510-0x0000000184E5B5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> AvatarGuidList { get => default; } // 0x0000000184E5BF10-0x0000000184E5BF70 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerTeam() {} // 0x0000000184E5C6D0-0x0000000184E5C760
	static TowerTeam() {} // 0x0000000184E5C5F0-0x0000000184E5C6D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerTeam Clone() => default; // 0x0000000184E5BE20-0x0000000184E5BF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerTeam ShallowCopy() => default; // 0x0000000184E5BA10-0x0000000184E5BAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184E5B400-0x0000000184E5B450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E5C090-0x0000000184E5C0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E5C0E0-0x0000000184E5C130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184E5B450-0x0000000184E5B510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184E5B5B0-0x0000000184E5B680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerTeam other) => default; // 0x0000000184E5B680-0x0000000184E5B7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184E5BBA0-0x0000000184E5BCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184E5C410-0x0000000184E5C5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184E5C190-0x0000000184E5C2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184E5B7B0-0x0000000184E5B8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerTeam other) {} // 0x0000000184E5B2D0-0x0000000184E5B400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184E5B100-0x0000000184E5B270
}

