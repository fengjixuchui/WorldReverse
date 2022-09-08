/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerChatReq : MessageBase, IMessage<PlayerChatReq> // TypeDefIndex: 25250
{
	// Fields
	private static readonly MessageParser<PlayerChatReq> _parser; // 0x00
	public const int ChannelIdFieldNumber = 1; // Metadata: 0x00B084EB
	private uint channelId_; // 0x18
	public const int ChatInfoFieldNumber = 2; // Metadata: 0x00B084EF
	private ChatInfo chatInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerChatReq> Parser { get => default; } // 0x0000000182BA19A0-0x0000000182BA1A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182BA1730-0x0000000182BA17C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182BA13A0-0x0000000182BA1420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182BA0BD0-0x0000000182BA0C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182BA1F70-0x0000000182BA2060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182BA1C60-0x0000000182BA1CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182BA17C0-0x0000000182BA18B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182BA1F20-0x0000000182BA1F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182BA14C0-0x0000000182BA15B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChannelId { get => default; set {} } // 0x0000000182BA0F60-0x0000000182BA1000 0x0000000182BA1BC0-0x0000000182BA1C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatInfo ChatInfo { get => default; set {} } // 0x0000000182BA1CC0-0x0000000182BA1D60 0x0000000182BA1D60-0x0000000182BA1E00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25251
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25252
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3018
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerChatReq() {} // 0x0000000182BA2300-0x0000000182BA2360
	static PlayerChatReq() {} // 0x0000000182BA2240-0x0000000182BA2300

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerChatReq Clone() => default; // 0x0000000182BA18B0-0x0000000182BA19A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerChatReq ShallowCopy() => default; // 0x0000000182BA1420-0x0000000182BA14C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182BA0DB0-0x0000000182BA0E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BA1AC0-0x0000000182BA1B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BA1B40-0x0000000182BA1BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182BA0E30-0x0000000182BA0F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182BA1000-0x0000000182BA10D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerChatReq other) => default; // 0x0000000182BA10D0-0x0000000182BA1200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182BA15B0-0x0000000182BA1730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182BA2060-0x0000000182BA2240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182BA1E00-0x0000000182BA1F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182BA1200-0x0000000182BA13A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerChatReq other) {} // 0x0000000182BA0C30-0x0000000182BA0DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182BA0A90-0x0000000182BA0BD0
}

