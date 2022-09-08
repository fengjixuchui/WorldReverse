/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannelerSlabCamp : MessageBase, IMessage<ChannelerSlabCamp> // TypeDefIndex: 22261
{
	// Fields
	private static readonly MessageParser<ChannelerSlabCamp> _parser; // 0x00
	public const int GroupIdFieldNumber = 1; // Metadata: 0x00B012C3
	private uint groupId_; // 0x18
	public const int RewardIdFieldNumber = 2; // Metadata: 0x00B012C7
	private uint rewardId_; // 0x1C
	public const int PosFieldNumber = 3; // Metadata: 0x00B012CB
	private Vector pos_; // 0x20
	public const int BuffNumFieldNumber = 4; // Metadata: 0x00B012CF
	private uint buffNum_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannelerSlabCamp> Parser { get => default; } // 0x0000000184174D20-0x0000000184174DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841748D0-0x0000000184174960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841744D0-0x0000000184174550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184173B10-0x0000000184173B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184175370-0x0000000184175460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184175080-0x00000001841750E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184174960-0x0000000184174A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184175320-0x0000000184175370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841745F0-0x00000001841746E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000184174A50-0x0000000184174AF0 0x0000000184174430-0x00000001841744D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x0000000184174FE0-0x0000000184175080 0x0000000184174BE0-0x0000000184174C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000184174F40-0x0000000184174FE0 0x0000000184175280-0x0000000184175320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuffNum { get => default; set {} } // 0x0000000184174C80-0x0000000184174D20 0x0000000184174390-0x0000000184174430

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabCamp() {} // 0x0000000184175820-0x0000000184175880
	static ChannelerSlabCamp() {} // 0x0000000184175760-0x0000000184175820

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabCamp Clone() => default; // 0x0000000184174AF0-0x0000000184174BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabCamp ShallowCopy() => default; // 0x0000000184174550-0x00000001841745F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184173D50-0x0000000184173DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184174E40-0x0000000184174EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184174EC0-0x0000000184174F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184173DD0-0x0000000184173F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184174090-0x0000000184174160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannelerSlabCamp other) => default; // 0x0000000184173F20-0x0000000184174090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841746E0-0x00000001841748D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184175460-0x0000000184175760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001841750E0-0x0000000184175280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184174160-0x0000000184174390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannelerSlabCamp other) {} // 0x0000000184173B70-0x0000000184173D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184173990-0x0000000184173B10
}

