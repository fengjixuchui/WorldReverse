/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StrengthenPointData : MessageBase, IMessage<StrengthenPointData> // TypeDefIndex: 22831
{
	// Fields
	private static readonly MessageParser<StrengthenPointData> _parser; // 0x00
	public const int BasePointFieldNumber = 1; // Metadata: 0x00B02793
	private uint basePoint_; // 0x18
	public const int CurPointFieldNumber = 2; // Metadata: 0x00B02797
	private uint curPoint_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StrengthenPointData> Parser { get => default; } // 0x0000000181584600-0x0000000181584690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815842F0-0x0000000181584380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181583FE0-0x0000000181584060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181583930-0x0000000181583990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181584A30-0x0000000181584B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181584860-0x00000001815848C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181584380-0x0000000181584470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001815849E0-0x0000000181584A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181584100-0x00000001815841F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BasePoint { get => default; set {} } // 0x0000000181584560-0x0000000181584600 0x0000000181583D70-0x0000000181583E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurPoint { get => default; set {} } // 0x0000000181583F40-0x0000000181583FE0 0x0000000181584690-0x0000000181584730

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StrengthenPointData() {} // 0x0000000181584DE0-0x0000000181584E40
	static StrengthenPointData() {} // 0x0000000181584D20-0x0000000181584DE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StrengthenPointData Clone() => default; // 0x0000000181584470-0x0000000181584560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StrengthenPointData ShallowCopy() => default; // 0x0000000181584060-0x0000000181584100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181583AC0-0x0000000181583B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815847C0-0x0000000181584810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181584810-0x0000000181584860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181583B10-0x0000000181583B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181583CA0-0x0000000181583D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StrengthenPointData other) => default; // 0x0000000181583B80-0x0000000181583CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001815841F0-0x00000001815842F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181584B20-0x0000000181584D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815848C0-0x00000001815849E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181583E10-0x0000000181583F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StrengthenPointData other) {} // 0x0000000181583990-0x0000000181583AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181583830-0x0000000181583930
}

