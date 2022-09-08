/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GatherGadgetInfo : MessageBase, IMessage<GatherGadgetInfo> // TypeDefIndex: 26028
{
	// Fields
	private static readonly MessageParser<GatherGadgetInfo> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B0AC4B
	private uint itemId_; // 0x18
	public const int IsForbidGuestFieldNumber = 2; // Metadata: 0x00B0AC4F
	private bool isForbidGuest_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GatherGadgetInfo> Parser { get => default; } // 0x000000018151E580-0x000000018151E610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018151E270-0x000000018151E300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018151DF50-0x000000018151DFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018151D970-0x000000018151D9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018151EA50-0x000000018151EB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018151E7E0-0x000000018151E840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018151E300-0x000000018151E3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018151E960-0x000000018151E9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018151E070-0x000000018151E160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x000000018151E6A0-0x000000018151E740 0x000000018151E9B0-0x000000018151EA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsForbidGuest { get => default; set {} } // 0x000000018151E4E0-0x000000018151E580 0x000000018151DEB0-0x000000018151DF50

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GatherGadgetInfo() {} // 0x000000018151EE00-0x000000018151EE60
	static GatherGadgetInfo() {} // 0x000000018151ED40-0x000000018151EE00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GatherGadgetInfo Clone() => default; // 0x000000018151E3F0-0x000000018151E4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GatherGadgetInfo ShallowCopy() => default; // 0x000000018151DFD0-0x000000018151E070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018151DB00-0x000000018151DB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018151E740-0x000000018151E790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018151E790-0x000000018151E7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018151DB50-0x000000018151DBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018151DBC0-0x000000018151DC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GatherGadgetInfo other) => default; // 0x000000018151DC90-0x000000018151DDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018151E160-0x000000018151E270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018151EB40-0x000000018151ED40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018151E840-0x000000018151E960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018151DDB0-0x000000018151DEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GatherGadgetInfo other) {} // 0x000000018151D9D0-0x000000018151DB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018151D870-0x000000018151D970
}

