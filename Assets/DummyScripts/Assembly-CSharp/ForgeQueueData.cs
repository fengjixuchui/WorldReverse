/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ForgeQueueData : MessageBase, IMessage<ForgeQueueData> // TypeDefIndex: 23702
{
	// Fields
	private static readonly MessageParser<ForgeQueueData> _parser; // 0x00
	public const int QueueIdFieldNumber = 1; // Metadata: 0x00B04A43
	private uint queueId_; // 0x18
	public const int ForgeIdFieldNumber = 2; // Metadata: 0x00B04A47
	private uint forgeId_; // 0x1C
	public const int FinishCountFieldNumber = 3; // Metadata: 0x00B04A4B
	private uint finishCount_; // 0x20
	public const int UnfinishCountFieldNumber = 4; // Metadata: 0x00B04A4F
	private uint unfinishCount_; // 0x24
	public const int NextFinishTimestampFieldNumber = 5; // Metadata: 0x00B04A53
	private uint nextFinishTimestamp_; // 0x28
	public const int TotalFinishTimestampFieldNumber = 6; // Metadata: 0x00B04A57
	private uint totalFinishTimestamp_; // 0x2C
	public const int AvatarIdFieldNumber = 7; // Metadata: 0x00B04A5B
	private uint avatarId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ForgeQueueData> Parser { get => default; } // 0x0000000182966680-0x0000000182966710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182966230-0x00000001829662C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182965E40-0x0000000182965EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182965200-0x0000000182965260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182966DD0-0x0000000182966EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182966A20-0x0000000182966A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182966400-0x00000001829664F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182966D80-0x0000000182966DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182965F60-0x0000000182966050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QueueId { get => default; set {} } // 0x0000000182966360-0x0000000182966400 0x0000000182966980-0x0000000182966A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ForgeId { get => default; set {} } // 0x00000001829667A0-0x0000000182966840 0x0000000182966EC0-0x0000000182966F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishCount { get => default; set {} } // 0x00000001829662C0-0x0000000182966360 0x0000000182966890-0x0000000182966930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint UnfinishCount { get => default; set {} } // 0x0000000182965260-0x0000000182965300 0x0000000182965740-0x00000001829657E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextFinishTimestamp { get => default; set {} } // 0x0000000182965300-0x00000001829653A0 0x00000001829665E0-0x0000000182966680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalFinishTimestamp { get => default; set {} } // 0x0000000182966A80-0x0000000182966B20 0x00000001829653A0-0x0000000182965440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x0000000182965D00-0x0000000182965DA0 0x0000000182965DA0-0x0000000182965E40

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueData() {} // 0x00000001829674E0-0x0000000182967540
	static ForgeQueueData() {} // 0x0000000182967420-0x00000001829674E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueData Clone() => default; // 0x00000001829664F0-0x00000001829665E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueData ShallowCopy() => default; // 0x0000000182965EC0-0x0000000182965F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182965630-0x0000000182965680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182966840-0x0000000182966890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182966930-0x0000000182966980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182965680-0x0000000182965740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001829657E0-0x00000001829658B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ForgeQueueData other) => default; // 0x00000001829658B0-0x0000000182965A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182966050-0x0000000182966230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182966F60-0x0000000182967420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182966B20-0x0000000182966D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182965A60-0x0000000182965D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ForgeQueueData other) {} // 0x0000000182965440-0x0000000182965630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182965070-0x0000000182965200
}

