/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SocialShowAvatarInfo : MessageBase, IMessage<SocialShowAvatarInfo> // TypeDefIndex: 25531
{
	// Fields
	private static readonly MessageParser<SocialShowAvatarInfo> _parser; // 0x00
	public const int AvatarIdFieldNumber = 1; // Metadata: 0x00B08FA3
	private uint avatarId_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B08FA7
	private uint level_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SocialShowAvatarInfo> Parser { get => default; } // 0x00000001812F8480-0x00000001812F8510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001812F8210-0x00000001812F82A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001812F7E60-0x00000001812F7EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001812F7710-0x00000001812F7770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001812F8810-0x00000001812F8900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001812F8640-0x00000001812F86A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001812F82A0-0x00000001812F8390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001812F87C0-0x00000001812F8810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001812F8020-0x00000001812F8110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001812F7D20-0x00000001812F7DC0 0x00000001812F7DC0-0x00000001812F7E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x00000001812F78A0-0x00000001812F7940 0x00000001812F7F80-0x00000001812F8020

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SocialShowAvatarInfo() {} // 0x00000001812F8BC0-0x00000001812F8C20
	static SocialShowAvatarInfo() {} // 0x00000001812F8B00-0x00000001812F8BC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SocialShowAvatarInfo Clone() => default; // 0x00000001812F8390-0x00000001812F8480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SocialShowAvatarInfo ShallowCopy() => default; // 0x00000001812F7EE0-0x00000001812F7F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001812F7940-0x00000001812F7990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001812F85A0-0x00000001812F85F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001812F85F0-0x00000001812F8640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001812F7990-0x00000001812F7A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001812F7A00-0x00000001812F7AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SocialShowAvatarInfo other) => default; // 0x00000001812F7AD0-0x00000001812F7BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001812F8110-0x00000001812F8210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001812F8900-0x00000001812F8B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001812F86A0-0x00000001812F87C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001812F7BF0-0x00000001812F7D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SocialShowAvatarInfo other) {} // 0x00000001812F7770-0x00000001812F78A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001812F7610-0x00000001812F7710
}

