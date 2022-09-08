/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EchoNotify : MessageBase, IMessage<EchoNotify> // TypeDefIndex: 24015
{
	// Fields
	private static readonly MessageParser<EchoNotify> _parser; // 0x00
	public const int SeqIdFieldNumber = 1; // Metadata: 0x00B055AB
	private uint seqId_; // 0x18
	public const int ContentFieldNumber = 2; // Metadata: 0x00B055AF
	private string content_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EchoNotify> Parser { get => default; } // 0x0000000183EA8250-0x0000000183EA82E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183EA7F30-0x0000000183EA7FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183EA7BF0-0x0000000183EA7C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183EA7560-0x0000000183EA75C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183EA8740-0x0000000183EA8830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183EA8550-0x0000000183EA85B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183EA7FC0-0x0000000183EA80B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183EA86F0-0x0000000183EA8740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183EA7D10-0x0000000183EA7E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SeqId { get => default; set {} } // 0x0000000183EA8460-0x0000000183EA8500 0x0000000183EA7760-0x0000000183EA7800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Content { get => default; set {} } // 0x0000000183EA8370-0x0000000183EA8410 0x0000000183EA81A0-0x0000000183EA8250

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24016
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24017
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 22
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EchoNotify() {} // 0x0000000183EA8AD0-0x0000000183EA8B40
	static EchoNotify() {} // 0x0000000183EA8A10-0x0000000183EA8AD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EchoNotify Clone() => default; // 0x0000000183EA80B0-0x0000000183EA81A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EchoNotify ShallowCopy() => default; // 0x0000000183EA7C70-0x0000000183EA7D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183EA7710-0x0000000183EA7760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EA8410-0x0000000183EA8460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EA8500-0x0000000183EA8550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183EA7800-0x0000000183EA7880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183EA79D0-0x0000000183EA7AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EchoNotify other) => default; // 0x0000000183EA7880-0x0000000183EA79D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183EA7E00-0x0000000183EA7F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183EA8830-0x0000000183EA8A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183EA85B0-0x0000000183EA86F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183EA7AA0-0x0000000183EA7BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EchoNotify other) {} // 0x0000000183EA75C0-0x0000000183EA7710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183EA7460-0x0000000183EA7560
}

