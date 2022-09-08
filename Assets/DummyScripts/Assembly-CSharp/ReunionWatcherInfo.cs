/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReunionWatcherInfo : MessageBase, IMessage<ReunionWatcherInfo> // TypeDefIndex: 24803
{
	// Fields
	private static readonly MessageParser<ReunionWatcherInfo> _parser; // 0x00
	public const int WatcherIdFieldNumber = 1; // Metadata: 0x00B0745F
	private uint watcherId_; // 0x18
	public const int CurProgressFieldNumber = 2; // Metadata: 0x00B07463
	private uint curProgress_; // 0x1C
	public const int TotalProgressFieldNumber = 3; // Metadata: 0x00B07467
	private uint totalProgress_; // 0x20
	public const int IsTakenRewardFieldNumber = 4; // Metadata: 0x00B0746B
	private bool isTakenReward_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReunionWatcherInfo> Parser { get => default; } // 0x0000000185184CF0-0x0000000185184D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185184800-0x0000000185184890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185184490-0x0000000185184510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185183CD0-0x0000000185183D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001851851A0-0x0000000185185290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185184EB0-0x0000000185184F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001851849D0-0x0000000185184AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185185150-0x00000001851851A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001851845B0-0x00000001851846A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WatcherId { get => default; set {} } // 0x0000000185184930-0x00000001851849D0 0x0000000185184890-0x0000000185184930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurProgress { get => default; set {} } // 0x0000000185184BB0-0x0000000185184C50 0x0000000185184C50-0x0000000185184CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalProgress { get => default; set {} } // 0x00000001851850B0-0x0000000185185150 0x0000000185183C30-0x0000000185183CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTakenReward { get => default; set {} } // 0x00000001851843F0-0x0000000185184490 0x0000000185183D30-0x0000000185183DD0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionWatcherInfo() {} // 0x0000000185185670-0x00000001851856D0
	static ReunionWatcherInfo() {} // 0x00000001851855B0-0x0000000185185670

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionWatcherInfo Clone() => default; // 0x0000000185184AC0-0x0000000185184BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionWatcherInfo ShallowCopy() => default; // 0x0000000185184510-0x00000001851845B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185183F50-0x0000000185183FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185184E10-0x0000000185184E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185184E60-0x0000000185184EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185183FA0-0x0000000185184030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185184030-0x0000000185184100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReunionWatcherInfo other) => default; // 0x0000000185184100-0x0000000185184260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001851846A0-0x0000000185184800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185185290-0x00000001851855B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185184F10-0x00000001851850B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185184260-0x00000001851843F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReunionWatcherInfo other) {} // 0x0000000185183DD0-0x0000000185183F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185183B00-0x0000000185183C30
}

