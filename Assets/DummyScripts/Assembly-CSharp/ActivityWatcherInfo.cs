/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityWatcherInfo : MessageBase, IMessage<ActivityWatcherInfo> // TypeDefIndex: 21873
{
	// Fields
	private static readonly MessageParser<ActivityWatcherInfo> _parser; // 0x00
	public const int WatcherIdFieldNumber = 1; // Metadata: 0x00B003C3
	private uint watcherId_; // 0x18
	public const int CurProgressFieldNumber = 2; // Metadata: 0x00B003C7
	private uint curProgress_; // 0x1C
	public const int TotalProgressFieldNumber = 3; // Metadata: 0x00B003CB
	private uint totalProgress_; // 0x20
	public const int IsTakenRewardFieldNumber = 4; // Metadata: 0x00B003CF
	private bool isTakenReward_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityWatcherInfo> Parser { get => default; } // 0x0000000183A1A1B0-0x0000000183A1A240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A19CC0-0x0000000183A19D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A19950-0x0000000183A199D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A19190-0x0000000183A191F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A1A660-0x0000000183A1A750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A1A370-0x0000000183A1A3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A19E90-0x0000000183A19F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A1A610-0x0000000183A1A660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A19A70-0x0000000183A19B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WatcherId { get => default; set {} } // 0x0000000183A19DF0-0x0000000183A19E90 0x0000000183A19D50-0x0000000183A19DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurProgress { get => default; set {} } // 0x0000000183A1A070-0x0000000183A1A110 0x0000000183A1A110-0x0000000183A1A1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalProgress { get => default; set {} } // 0x0000000183A1A570-0x0000000183A1A610 0x0000000183A190F0-0x0000000183A19190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTakenReward { get => default; set {} } // 0x0000000183A198B0-0x0000000183A19950 0x0000000183A191F0-0x0000000183A19290

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityWatcherInfo() {} // 0x0000000183A1AB30-0x0000000183A1AB90
	static ActivityWatcherInfo() {} // 0x0000000183A1AA70-0x0000000183A1AB30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityWatcherInfo Clone() => default; // 0x0000000183A19F80-0x0000000183A1A070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityWatcherInfo ShallowCopy() => default; // 0x0000000183A199D0-0x0000000183A19A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A19410-0x0000000183A19460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A1A2D0-0x0000000183A1A320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A1A320-0x0000000183A1A370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A19460-0x0000000183A194F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A19650-0x0000000183A19720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityWatcherInfo other) => default; // 0x0000000183A194F0-0x0000000183A19650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A19B60-0x0000000183A19CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A1A750-0x0000000183A1AA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A1A3D0-0x0000000183A1A570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A19720-0x0000000183A198B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityWatcherInfo other) {} // 0x0000000183A19290-0x0000000183A19410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A18FC0-0x0000000183A190F0
}

