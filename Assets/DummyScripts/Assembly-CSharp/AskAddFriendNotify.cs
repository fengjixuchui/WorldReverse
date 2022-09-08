/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AskAddFriendNotify : MessageBase, IMessage<AskAddFriendNotify> // TypeDefIndex: 25591
{
	// Fields
	private static readonly MessageParser<AskAddFriendNotify> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B0922F
	private uint targetUid_; // 0x18
	public const int TargetFriendBriefFieldNumber = 2; // Metadata: 0x00B09233
	private FriendBrief targetFriendBrief_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AskAddFriendNotify> Parser { get => default; } // 0x0000000181E69F70-0x0000000181E6A000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E69C60-0x0000000181E69CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E69830-0x0000000181E698B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E68FC0-0x0000000181E69020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E6A360-0x0000000181E6A450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E6A190-0x0000000181E6A1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E69CF0-0x0000000181E69DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E6A310-0x0000000181E6A360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E69950-0x0000000181E69A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000181E69BC0-0x0000000181E69C60 0x0000000181E69790-0x0000000181E69830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendBrief TargetFriendBrief { get => default; set {} } // 0x0000000181E69020-0x0000000181E690C0 0x0000000181E69ED0-0x0000000181E69F70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25592
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25593
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4022
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AskAddFriendNotify() {} // 0x0000000181E6A6F0-0x0000000181E6A750
	static AskAddFriendNotify() {} // 0x0000000181E6A630-0x0000000181E6A6F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AskAddFriendNotify Clone() => default; // 0x0000000181E69DE0-0x0000000181E69ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AskAddFriendNotify ShallowCopy() => default; // 0x0000000181E698B0-0x0000000181E69950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E69240-0x0000000181E692C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E6A090-0x0000000181E6A110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E6A110-0x0000000181E6A190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E692C0-0x0000000181E693F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E693F0-0x0000000181E694C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AskAddFriendNotify other) => default; // 0x0000000181E694C0-0x0000000181E695F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E69A40-0x0000000181E69BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E6A450-0x0000000181E6A630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E6A1F0-0x0000000181E6A310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E695F0-0x0000000181E69790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AskAddFriendNotify other) {} // 0x0000000181E690C0-0x0000000181E69240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E68E80-0x0000000181E68FC0
}

