/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnionCmdNotify : MessageBase, IMessage<UnionCmdNotify> // TypeDefIndex: 23993
{
	// Fields
	private static readonly MessageParser<UnionCmdNotify> _parser; // 0x00
	public const int CmdListFieldNumber = 1; // Metadata: 0x00B054D7
	private static readonly FieldCodec<UnionCmd> _repeated_cmdList_codec; // 0x08
	private readonly RepeatedMessageField<UnionCmd> cmdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnionCmdNotify> Parser { get => default; } // 0x00000001850A86F0-0x00000001850A8780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001850A8420-0x00000001850A84B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001850A8150-0x00000001850A81D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001850A7BD0-0x00000001850A7C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001850A8AE0-0x00000001850A8BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001850A8930-0x00000001850A8990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001850A84B0-0x00000001850A85A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001850A8A90-0x00000001850A8AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001850A8270-0x00000001850A8360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UnionCmd> CmdList { get => default; } // 0x00000001850A8690-0x00000001850A86F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23994
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23995
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 16
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnionCmdNotify() {} // 0x00000001850A8E30-0x00000001850A8EC0
	static UnionCmdNotify() {} // 0x00000001850A8D20-0x00000001850A8E30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnionCmdNotify Clone() => default; // 0x00000001850A85A0-0x00000001850A8690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnionCmdNotify ShallowCopy() => default; // 0x00000001850A81D0-0x00000001850A8270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001850A7D60-0x00000001850A7DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850A8810-0x00000001850A88A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850A88A0-0x00000001850A8930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001850A7DB0-0x00000001850A7E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001850A7F90-0x00000001850A8060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnionCmdNotify other) => default; // 0x00000001850A7E80-0x00000001850A7F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001850A8360-0x00000001850A8420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001850A8BD0-0x00000001850A8D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001850A8990-0x00000001850A8A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001850A8060-0x00000001850A8150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnionCmdNotify other) {} // 0x00000001850A7C30-0x00000001850A7D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001850A7AA0-0x00000001850A7BD0
}

