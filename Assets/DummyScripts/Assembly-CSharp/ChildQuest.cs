/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChildQuest : MessageBase, IMessage<ChildQuest> // TypeDefIndex: 24572
{
	// Fields
	private static readonly MessageParser<ChildQuest> _parser; // 0x00
	public const int QuestIdFieldNumber = 1; // Metadata: 0x00B06BBF
	private uint questId_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B06BC3
	private uint state_; // 0x1C
	public const int QuestConfigIdFieldNumber = 3; // Metadata: 0x00B06BC7
	private uint questConfigId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChildQuest> Parser { get => default; } // 0x0000000182AEF990-0x0000000182AEFA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182AEF680-0x0000000182AEF710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182AEF340-0x0000000182AEF3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182AEEB40-0x0000000182AEEBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182AEFE00-0x0000000182AEFEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182AEFBF0-0x0000000182AEFC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182AEF710-0x0000000182AEF800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182AEFDB0-0x0000000182AEFE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182AEF460-0x0000000182AEF550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x0000000182AEEAA0-0x0000000182AEEB40 0x0000000182AEF2A0-0x0000000182AEF340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint State { get => default; set {} } // 0x0000000182AEF160-0x0000000182AEF200 0x0000000182AEF200-0x0000000182AEF2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestConfigId { get => default; set {} } // 0x0000000182AEFB00-0x0000000182AEFBA0 0x0000000182AEF8F0-0x0000000182AEF990

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChildQuest() {} // 0x0000000182AF0240-0x0000000182AF02A0
	static ChildQuest() {} // 0x0000000182AF0180-0x0000000182AF0240

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChildQuest Clone() => default; // 0x0000000182AEF800-0x0000000182AEF8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChildQuest ShallowCopy() => default; // 0x0000000182AEF3C0-0x0000000182AEF460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182AEED00-0x0000000182AEED50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AEFAB0-0x0000000182AEFB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AEFBA0-0x0000000182AEFBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182AEED50-0x0000000182AEEDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182AEEDD0-0x0000000182AEEEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChildQuest other) => default; // 0x0000000182AEEEA0-0x0000000182AEEFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182AEF550-0x0000000182AEF680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182AEFEF0-0x0000000182AF0180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182AEFC50-0x0000000182AEFDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182AEEFE0-0x0000000182AEF160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChildQuest other) {} // 0x0000000182AEEBA0-0x0000000182AEED00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182AEE990-0x0000000182AEEAA0
}

