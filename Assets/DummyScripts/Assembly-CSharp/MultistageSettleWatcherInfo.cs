/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MultistageSettleWatcherInfo : MessageBase, IMessage<MultistageSettleWatcherInfo> // TypeDefIndex: 24153
{
	// Fields
	private static readonly MessageParser<MultistageSettleWatcherInfo> _parser; // 0x00
	public const int WatcherIdFieldNumber = 1; // Metadata: 0x00B05B73
	private uint watcherId_; // 0x18
	public const int CurProgressFieldNumber = 2; // Metadata: 0x00B05B77
	private uint curProgress_; // 0x1C
	public const int TotalProgressFieldNumber = 3; // Metadata: 0x00B05B7B
	private uint totalProgress_; // 0x20
	public const int IsInverseFieldNumber = 4; // Metadata: 0x00B05B7F
	private bool isInverse_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MultistageSettleWatcherInfo> Parser { get => default; } // 0x0000000183A78230-0x0000000183A782C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A77D40-0x0000000183A77DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A779D0-0x0000000183A77A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A772B0-0x0000000183A77310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A78780-0x0000000183A78870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A78490-0x0000000183A784F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A77F10-0x0000000183A78000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A78730-0x0000000183A78780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A77AF0-0x0000000183A77BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WatcherId { get => default; set {} } // 0x0000000183A77E70-0x0000000183A77F10 0x0000000183A77DD0-0x0000000183A77E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurProgress { get => default; set {} } // 0x0000000183A780F0-0x0000000183A78190 0x0000000183A78190-0x0000000183A78230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalProgress { get => default; set {} } // 0x0000000183A78690-0x0000000183A78730 0x0000000183A77210-0x0000000183A772B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsInverse { get => default; set {} } // 0x0000000183A77310-0x0000000183A773B0 0x0000000183A783F0-0x0000000183A78490

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistageSettleWatcherInfo() {} // 0x0000000183A78C50-0x0000000183A78CB0
	static MultistageSettleWatcherInfo() {} // 0x0000000183A78B90-0x0000000183A78C50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistageSettleWatcherInfo Clone() => default; // 0x0000000183A78000-0x0000000183A780F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistageSettleWatcherInfo ShallowCopy() => default; // 0x0000000183A77A50-0x0000000183A77AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A77530-0x0000000183A77580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A78350-0x0000000183A783A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A783A0-0x0000000183A783F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A77580-0x0000000183A77610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A77610-0x0000000183A776E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MultistageSettleWatcherInfo other) => default; // 0x0000000183A776E0-0x0000000183A77840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A77BE0-0x0000000183A77D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A78870-0x0000000183A78B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A784F0-0x0000000183A78690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A77840-0x0000000183A779D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MultistageSettleWatcherInfo other) {} // 0x0000000183A773B0-0x0000000183A77530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A770E0-0x0000000183A77210
}

