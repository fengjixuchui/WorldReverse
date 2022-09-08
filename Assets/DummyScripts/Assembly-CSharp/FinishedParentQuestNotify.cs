/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FinishedParentQuestNotify : MessageBase, IMessage<FinishedParentQuestNotify> // TypeDefIndex: 24575
{
	// Fields
	private static readonly MessageParser<FinishedParentQuestNotify> _parser; // 0x00
	public const int ParentQuestListFieldNumber = 1; // Metadata: 0x00B06BF7
	private static readonly FieldCodec<ParentQuest> _repeated_parentQuestList_codec; // 0x08
	private readonly RepeatedMessageField<ParentQuest> parentQuestList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FinishedParentQuestNotify> Parser { get => default; } // 0x0000000184BD7EB0-0x0000000184BD7F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184BD7C40-0x0000000184BD7CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184BD7970-0x0000000184BD79F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184BD7390-0x0000000184BD73F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184BD82A0-0x0000000184BD8390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184BD80F0-0x0000000184BD8150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184BD7CD0-0x0000000184BD7DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184BD8250-0x0000000184BD82A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184BD7A90-0x0000000184BD7B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ParentQuest> ParentQuestList { get => default; } // 0x0000000184BD7640-0x0000000184BD76A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24576
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24577
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 404
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishedParentQuestNotify() {} // 0x0000000184BD85F0-0x0000000184BD8680
	static FinishedParentQuestNotify() {} // 0x0000000184BD84E0-0x0000000184BD85F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishedParentQuestNotify Clone() => default; // 0x0000000184BD7DC0-0x0000000184BD7EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishedParentQuestNotify ShallowCopy() => default; // 0x0000000184BD79F0-0x0000000184BD7A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184BD7520-0x0000000184BD7570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BD7FD0-0x0000000184BD8060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BD8060-0x0000000184BD80F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184BD7570-0x0000000184BD7640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184BD76A0-0x0000000184BD7770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FinishedParentQuestNotify other) => default; // 0x0000000184BD7770-0x0000000184BD7880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184BD7B80-0x0000000184BD7C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184BD8390-0x0000000184BD84E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184BD8150-0x0000000184BD8250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184BD7880-0x0000000184BD7970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FinishedParentQuestNotify other) {} // 0x0000000184BD73F0-0x0000000184BD7520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184BD7260-0x0000000184BD7390
}

