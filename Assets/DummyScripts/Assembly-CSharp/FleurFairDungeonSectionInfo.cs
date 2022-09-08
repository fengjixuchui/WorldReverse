/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairDungeonSectionInfo : MessageBase, IMessage<FleurFairDungeonSectionInfo> // TypeDefIndex: 22212
{
	// Fields
	private static readonly MessageParser<FleurFairDungeonSectionInfo> _parser; // 0x00
	public const int SectionIdFieldNumber = 1; // Metadata: 0x00B010DB
	private uint sectionId_; // 0x18
	public const int OpenTimeFieldNumber = 2; // Metadata: 0x00B010DF
	private uint openTime_; // 0x1C
	public const int IsOpenFieldNumber = 3; // Metadata: 0x00B010E3
	private bool isOpen_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairDungeonSectionInfo> Parser { get => default; } // 0x0000000182246CA0-0x0000000182246D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182246990-0x0000000182246A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182246650-0x00000001822466D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182245E80-0x0000000182245EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001822471B0-0x00000001822472A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182246F00-0x0000000182246F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182246A20-0x0000000182246B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182247160-0x00000001822471B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182246770-0x0000000182246860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SectionId { get => default; set {} } // 0x00000001822465B0-0x0000000182246650 0x0000000182246C00-0x0000000182246CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OpenTime { get => default; set {} } // 0x0000000182246510-0x00000001822465B0 0x0000000182246E60-0x0000000182246F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000182246F60-0x0000000182247000 0x0000000182245EE0-0x0000000182245F80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairDungeonSectionInfo() {} // 0x00000001822475F0-0x0000000182247650
	static FleurFairDungeonSectionInfo() {} // 0x0000000182247530-0x00000001822475F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairDungeonSectionInfo Clone() => default; // 0x0000000182246B10-0x0000000182246C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairDungeonSectionInfo ShallowCopy() => default; // 0x00000001822466D0-0x0000000182246770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001822460E0-0x0000000182246130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182246DC0-0x0000000182246E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182246E10-0x0000000182246E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182246130-0x00000001822461B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001822461B0-0x0000000182246280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairDungeonSectionInfo other) => default; // 0x0000000182246280-0x00000001822463C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182246860-0x0000000182246990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001822472A0-0x0000000182247530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182247000-0x0000000182247160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822463C0-0x0000000182246510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairDungeonSectionInfo other) {} // 0x0000000182245F80-0x00000001822460E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182245D70-0x0000000182245E80
}

