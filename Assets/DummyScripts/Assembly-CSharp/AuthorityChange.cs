/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AuthorityChange : MessageBase, IMessage<AuthorityChange> // TypeDefIndex: 23063
{
	// Fields
	private static readonly MessageParser<AuthorityChange> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B031B7
	private uint entityId_; // 0x18
	public const int AuthorityPeerIdFieldNumber = 2; // Metadata: 0x00B031BB
	private uint authorityPeerId_; // 0x1C
	public const int EntityAuthorityInfoFieldNumber = 3; // Metadata: 0x00B031BF
	private EntityAuthorityInfo entityAuthorityInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AuthorityChange> Parser { get => default; } // 0x000000018322B020-0x000000018322B0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018322AD10-0x000000018322ADA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018322A8B0-0x000000018322A930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018322A0E0-0x000000018322A140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018322B630-0x000000018322B720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018322B420-0x000000018322B480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018322ADA0-0x000000018322AE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018322B5E0-0x000000018322B630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018322A9D0-0x000000018322AAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018322B2E0-0x000000018322B380 0x000000018322B720-0x000000018322B7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AuthorityPeerId { get => default; set {} } // 0x000000018322B0B0-0x000000018322B150 0x000000018322AF80-0x000000018322B020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAuthorityInfo EntityAuthorityInfo { get => default; set {} } // 0x000000018322B380-0x000000018322B420 0x000000018322AC70-0x000000018322AD10

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AuthorityChange() {} // 0x000000018322BAF0-0x000000018322BB50
	static AuthorityChange() {} // 0x000000018322BA30-0x000000018322BAF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AuthorityChange Clone() => default; // 0x000000018322AE90-0x000000018322AF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AuthorityChange ShallowCopy() => default; // 0x000000018322A930-0x000000018322A9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018322A2F0-0x000000018322A370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018322B1E0-0x000000018322B260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018322B260-0x000000018322B2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018322A370-0x000000018322A4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018322A600-0x000000018322A6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AuthorityChange other) => default; // 0x000000018322A4B0-0x000000018322A600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018322AAC0-0x000000018322AC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018322B7C0-0x000000018322BA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018322B480-0x000000018322B5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018322A6D0-0x000000018322A8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AuthorityChange other) {} // 0x000000018322A140-0x000000018322A2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183229F80-0x000000018322A0E0
}

