/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerChatNotify : MessageBase, IMessage<PlayerChatNotify> // TypeDefIndex: 25256
{
	// Fields
	private static readonly MessageParser<PlayerChatNotify> _parser; // 0x00
	public const int ChannelIdFieldNumber = 1; // Metadata: 0x00B0851F
	private uint channelId_; // 0x18
	public const int ChatInfoFieldNumber = 2; // Metadata: 0x00B08523
	private ChatInfo chatInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerChatNotify> Parser { get => default; } // 0x0000000182AD42F0-0x0000000182AD4380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182AD4080-0x0000000182AD4110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182AD3CF0-0x0000000182AD3D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182AD3520-0x0000000182AD3580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182AD48C0-0x0000000182AD49B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182AD45B0-0x0000000182AD4610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182AD4110-0x0000000182AD4200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182AD4870-0x0000000182AD48C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182AD3E10-0x0000000182AD3F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChannelId { get => default; set {} } // 0x0000000182AD38B0-0x0000000182AD3950 0x0000000182AD4510-0x0000000182AD45B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatInfo ChatInfo { get => default; set {} } // 0x0000000182AD4610-0x0000000182AD46B0 0x0000000182AD46B0-0x0000000182AD4750

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25257
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25258
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3020
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerChatNotify() {} // 0x0000000182AD4C50-0x0000000182AD4CB0
	static PlayerChatNotify() {} // 0x0000000182AD4B90-0x0000000182AD4C50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerChatNotify Clone() => default; // 0x0000000182AD4200-0x0000000182AD42F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerChatNotify ShallowCopy() => default; // 0x0000000182AD3D70-0x0000000182AD3E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182AD3700-0x0000000182AD3780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AD4410-0x0000000182AD4490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AD4490-0x0000000182AD4510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182AD3780-0x0000000182AD38B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182AD3A80-0x0000000182AD3B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerChatNotify other) => default; // 0x0000000182AD3950-0x0000000182AD3A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182AD3F00-0x0000000182AD4080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182AD49B0-0x0000000182AD4B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182AD4750-0x0000000182AD4870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182AD3B50-0x0000000182AD3CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerChatNotify other) {} // 0x0000000182AD3580-0x0000000182AD3700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182AD33E0-0x0000000182AD3520
}

