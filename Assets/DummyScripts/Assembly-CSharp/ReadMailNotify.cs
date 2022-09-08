/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReadMailNotify : MessageBase, IMessage<ReadMailNotify> // TypeDefIndex: 23792
{
	// Fields
	private static readonly MessageParser<ReadMailNotify> _parser; // 0x00
	public const int MailIdListFieldNumber = 1; // Metadata: 0x00B04D5B
	private static readonly FieldCodec<uint> _repeated_mailIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> mailIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReadMailNotify> Parser { get => default; } // 0x00000001815D7F80-0x00000001815D8010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815D7D10-0x00000001815D7DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815D7A40-0x00000001815D7AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001815D7500-0x00000001815D7560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001815D82F0-0x00000001815D83E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001815D8140-0x00000001815D81A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001815D7DA0-0x00000001815D7E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001815D82A0-0x00000001815D82F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001815D7B60-0x00000001815D7C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MailIdList { get => default; } // 0x00000001815D74A0-0x00000001815D7500 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23793
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23794
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1403
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReadMailNotify() {} // 0x00000001815D8610-0x00000001815D86A0
	static ReadMailNotify() {} // 0x00000001815D8530-0x00000001815D8610

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReadMailNotify Clone() => default; // 0x00000001815D7E90-0x00000001815D7F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReadMailNotify ShallowCopy() => default; // 0x00000001815D7AC0-0x00000001815D7B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815D7670-0x00000001815D76C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815D80A0-0x00000001815D80F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815D80F0-0x00000001815D8140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001815D76C0-0x00000001815D7780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001815D7880-0x00000001815D7950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReadMailNotify other) => default; // 0x00000001815D7780-0x00000001815D7880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001815D7C50-0x00000001815D7D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001815D83E0-0x00000001815D8530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815D81A0-0x00000001815D82A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001815D7950-0x00000001815D7A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReadMailNotify other) {} // 0x00000001815D7560-0x00000001815D7670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001815D7360-0x00000001815D74A0
}

