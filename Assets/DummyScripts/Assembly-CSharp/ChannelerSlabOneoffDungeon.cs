/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannelerSlabOneoffDungeon : MessageBase, IMessage<ChannelerSlabOneoffDungeon> // TypeDefIndex: 22263
{
	// Fields
	private static readonly MessageParser<ChannelerSlabOneoffDungeon> _parser; // 0x00
	public const int DungeonIdFieldNumber = 1; // Metadata: 0x00B012DB
	private uint dungeonId_; // 0x18
	public const int IsDoneFieldNumber = 2; // Metadata: 0x00B012DF
	private bool isDone_; // 0x1C
	public const int RewardIdFieldNumber = 3; // Metadata: 0x00B012E3
	private uint rewardId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannelerSlabOneoffDungeon> Parser { get => default; } // 0x000000018261A340-0x000000018261A3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018261A030-0x000000018261A0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182619C50-0x0000000182619CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001826195D0-0x0000000182619630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018261A8F0-0x000000018261A9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018261A640-0x000000018261A6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018261A0C0-0x000000018261A1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018261A8A0-0x000000018261A8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182619E10-0x0000000182619F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x0000000182619D70-0x0000000182619E10 0x000000018261A800-0x000000018261A8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsDone { get => default; set {} } // 0x000000018261A4B0-0x000000018261A550 0x0000000182619790-0x0000000182619830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x000000018261A5A0-0x000000018261A640 0x000000018261A2A0-0x000000018261A340

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabOneoffDungeon() {} // 0x000000018261AD30-0x000000018261AD90
	static ChannelerSlabOneoffDungeon() {} // 0x000000018261AC70-0x000000018261AD30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabOneoffDungeon Clone() => default; // 0x000000018261A1B0-0x000000018261A2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabOneoffDungeon ShallowCopy() => default; // 0x0000000182619CD0-0x0000000182619D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182619830-0x0000000182619880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018261A460-0x000000018261A4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018261A550-0x000000018261A5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182619880-0x0000000182619900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182619900-0x00000001826199D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannelerSlabOneoffDungeon other) => default; // 0x00000001826199D0-0x0000000182619B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182619F00-0x000000018261A030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018261A9E0-0x000000018261AC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018261A6A0-0x000000018261A800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182619B10-0x0000000182619C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannelerSlabOneoffDungeon other) {} // 0x0000000182619630-0x0000000182619790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001826194C0-0x00000001826195D0
}

