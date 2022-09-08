/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FinishedParentQuestUpdateNotify : MessageBase, IMessage<FinishedParentQuestUpdateNotify> // TypeDefIndex: 24578
{
	// Fields
	private static readonly MessageParser<FinishedParentQuestUpdateNotify> _parser; // 0x00
	public const int ParentQuestListFieldNumber = 1; // Metadata: 0x00B06C0B
	private static readonly FieldCodec<ParentQuest> _repeated_parentQuestList_codec; // 0x08
	private readonly RepeatedMessageField<ParentQuest> parentQuestList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FinishedParentQuestUpdateNotify> Parser { get => default; } // 0x000000018458DCC0-0x000000018458DD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018458DA50-0x000000018458DAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018458D780-0x000000018458D800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018458D1A0-0x000000018458D200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018458E0B0-0x000000018458E1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018458DF00-0x000000018458DF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018458DAE0-0x000000018458DBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018458E060-0x000000018458E0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018458D8A0-0x000000018458D990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ParentQuest> ParentQuestList { get => default; } // 0x000000018458D450-0x000000018458D4B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24579
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24580
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 405
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishedParentQuestUpdateNotify() {} // 0x000000018458E400-0x000000018458E490
	static FinishedParentQuestUpdateNotify() {} // 0x000000018458E2F0-0x000000018458E400

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishedParentQuestUpdateNotify Clone() => default; // 0x000000018458DBD0-0x000000018458DCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishedParentQuestUpdateNotify ShallowCopy() => default; // 0x000000018458D800-0x000000018458D8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018458D330-0x000000018458D380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018458DDE0-0x000000018458DE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018458DE70-0x000000018458DF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018458D380-0x000000018458D450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018458D4B0-0x000000018458D580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FinishedParentQuestUpdateNotify other) => default; // 0x000000018458D580-0x000000018458D690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018458D990-0x000000018458DA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018458E1A0-0x000000018458E2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018458DF60-0x000000018458E060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018458D690-0x000000018458D780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FinishedParentQuestUpdateNotify other) {} // 0x000000018458D200-0x000000018458D330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018458D070-0x000000018458D1A0
}

