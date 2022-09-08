/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarTeam : MessageBase, IMessage<AvatarTeam> // TypeDefIndex: 22389
{
	// Fields
	private static readonly MessageParser<AvatarTeam> _parser; // 0x00
	public const int AvatarGuidListFieldNumber = 1; // Metadata: 0x00B01777
	private static readonly FieldCodec<ulong> _repeated_avatarGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> avatarGuidList_; // 0x18
	public const int TeamNameFieldNumber = 2; // Metadata: 0x00B0177B
	private string teamName_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarTeam> Parser { get => default; } // 0x0000000181AAC690-0x0000000181AAC720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181AAC320-0x0000000181AAC3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181AAC000-0x0000000181AAC080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181AAB9D0-0x0000000181AABA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181AACB00-0x0000000181AACBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181AAC900-0x0000000181AAC960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181AAC450-0x0000000181AAC540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181AACAB0-0x0000000181AACB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181AAC120-0x0000000181AAC210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> AvatarGuidList { get => default; } // 0x0000000181AAC630-0x0000000181AAC690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TeamName { get => default; set {} } // 0x0000000181AAC3B0-0x0000000181AAC450 0x0000000181AAC850-0x0000000181AAC900

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarTeam() {} // 0x0000000181AACE90-0x0000000181AACF30
	static AvatarTeam() {} // 0x0000000181AACDB0-0x0000000181AACE90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarTeam Clone() => default; // 0x0000000181AAC540-0x0000000181AAC630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarTeam ShallowCopy() => default; // 0x0000000181AAC080-0x0000000181AAC120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181AABB70-0x0000000181AABBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181AAC7B0-0x0000000181AAC800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181AAC800-0x0000000181AAC850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181AABBC0-0x0000000181AABC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181AABDE0-0x0000000181AABEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarTeam other) => default; // 0x0000000181AABC90-0x0000000181AABDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181AAC210-0x0000000181AAC320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181AACBF0-0x0000000181AACDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181AAC960-0x0000000181AACAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181AABEB0-0x0000000181AAC000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarTeam other) {} // 0x0000000181AABA30-0x0000000181AABB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181AAB860-0x0000000181AAB9D0
}

