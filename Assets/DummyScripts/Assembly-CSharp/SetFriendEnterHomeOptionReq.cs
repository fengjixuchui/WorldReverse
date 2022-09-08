/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetFriendEnterHomeOptionReq : MessageBase, IMessage<SetFriendEnterHomeOptionReq> // TypeDefIndex: 23363
{
	// Fields
	private static readonly MessageParser<SetFriendEnterHomeOptionReq> _parser; // 0x00
	public const int OptionFieldNumber = 1; // Metadata: 0x00B03DC3
	private FriendEnterHomeOption option_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetFriendEnterHomeOptionReq> Parser { get => default; } // 0x000000018300D950-0x000000018300D9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018300D5A0-0x000000018300D630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018300D280-0x000000018300D300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018300CD90-0x000000018300CDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018300DCA0-0x000000018300DD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018300DB10-0x000000018300DB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018300D770-0x000000018300D860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018300DC50-0x000000018300DCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018300D3A0-0x000000018300D490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendEnterHomeOption Option { get => default; set {} } // 0x000000018300D630-0x000000018300D6D0 0x000000018300D6D0-0x000000018300D770

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23364
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23365
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4469
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetFriendEnterHomeOptionReq() {} // 0x000000018300DFC0-0x000000018300E030
	static SetFriendEnterHomeOptionReq() {} // 0x000000018300DF00-0x000000018300DFC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetFriendEnterHomeOptionReq Clone() => default; // 0x000000018300D860-0x000000018300D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetFriendEnterHomeOptionReq ShallowCopy() => default; // 0x000000018300D300-0x000000018300D3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018300CF00-0x000000018300CF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018300DA70-0x000000018300DAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018300DAC0-0x000000018300DB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018300CF50-0x000000018300CFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018300CFC0-0x000000018300D090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetFriendEnterHomeOptionReq other) => default; // 0x000000018300D090-0x000000018300D190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018300D490-0x000000018300D5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018300DD90-0x000000018300DF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018300DB70-0x000000018300DC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018300D190-0x000000018300D280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetFriendEnterHomeOptionReq other) {} // 0x000000018300CDF0-0x000000018300CF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018300CCB0-0x000000018300CD90
}

