/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityInvokeEntry : MessageBase, IMessage<AbilityInvokeEntry> // TypeDefIndex: 21745
{
	// Fields
	private static readonly MessageParser<AbilityInvokeEntry> _parser; // 0x00
	public const int HeadFieldNumber = 1; // Metadata: 0x00AFFE6B
	private AbilityInvokeEntryHead head_; // 0x18
	public const int ArgumentTypeFieldNumber = 2; // Metadata: 0x00AFFE6F
	private AbilityInvokeArgument argumentType_; // 0x20
	public const int AbilityDataFieldNumber = 3; // Metadata: 0x00AFFE73
	private ByteString abilityData_; // 0x28
	public const int EntityIdFieldNumber = 4; // Metadata: 0x00AFFE77
	private uint entityId_; // 0x30
	public const int ForwardTypeFieldNumber = 5; // Metadata: 0x00AFFE7B
	private ForwardType forwardType_; // 0x34
	public const int ForwardPeerFieldNumber = 6; // Metadata: 0x00AFFE7F
	private uint forwardPeer_; // 0x38
	public const int EventIdFieldNumber = 7; // Metadata: 0x00AFFE83
	private uint eventId_; // 0x3C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityInvokeEntry> Parser { get => default; } // 0x000000018349DB00-0x000000018349DB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018349D560-0x000000018349D5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018349CEF0-0x000000018349CF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018349C2F0-0x000000018349C350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018349E2C0-0x000000018349E3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018349DE60-0x000000018349DEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018349D880-0x000000018349D970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018349E1D0-0x000000018349E220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018349D010-0x000000018349D100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntryHead Head { get => default; set {} } // 0x000000018349D5F0-0x000000018349D690 0x000000018349DD20-0x000000018349DDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeArgument ArgumentType { get => default; set {} } // 0x000000018349E220-0x000000018349E2C0 0x000000018349D7E0-0x000000018349D880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString AbilityData { get => default; set {} } // 0x000000018349DA60-0x000000018349DB00 0x000000018349D730-0x000000018349D7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018349DDC0-0x000000018349DE60 0x000000018349E3B0-0x000000018349E450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x000000018349CE50-0x000000018349CEF0 0x000000018349C630-0x000000018349C6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ForwardPeer { get => default; set {} } // 0x000000018349D420-0x000000018349D4C0 0x000000018349D4C0-0x000000018349D560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EventId { get => default; set {} } // 0x000000018349D690-0x000000018349D730 0x000000018349E130-0x000000018349E1D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry() {} // 0x000000018349E9A0-0x000000018349EA40
	static AbilityInvokeEntry() {} // 0x000000018349E8E0-0x000000018349E9A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry Clone() => default; // 0x000000018349D970-0x000000018349DA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry ShallowCopy() => default; // 0x000000018349CF70-0x000000018349D010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018349C5B0-0x000000018349C630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018349DC20-0x000000018349DCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018349DCA0-0x000000018349DD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018349C6D0-0x000000018349C870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018349C870-0x000000018349C940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityInvokeEntry other) => default; // 0x000000018349C940-0x000000018349CB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018349D100-0x000000018349D420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018349E450-0x000000018349E8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018349DEC0-0x000000018349E130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018349CB30-0x000000018349CE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityInvokeEntry other) {} // 0x000000018349C350-0x000000018349C5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018349C140-0x000000018349C2F0
}

