/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityGadgetInfo : MessageBase, IMessage<AbilityGadgetInfo> // TypeDefIndex: 26027
{
	// Fields
	private static readonly MessageParser<AbilityGadgetInfo> _parser; // 0x00
	public const int CampIdFieldNumber = 1; // Metadata: 0x00B0AC3F
	private uint campId_; // 0x18
	public const int CampTargetTypeFieldNumber = 2; // Metadata: 0x00B0AC43
	private uint campTargetType_; // 0x1C
	public const int TargetEntityIdFieldNumber = 3; // Metadata: 0x00B0AC47
	private uint targetEntityId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityGadgetInfo> Parser { get => default; } // 0x00000001841F9D10-0x00000001841F9DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841F9A00-0x00000001841F9A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841F96C0-0x00000001841F9740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841F9000-0x00000001841F9060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001841FA2C0-0x00000001841FA3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841FA010-0x00000001841FA070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001841F9A90-0x00000001841F9B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001841FA1D0-0x00000001841FA220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841F97E0-0x00000001841F98D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CampId { get => default; set {} } // 0x00000001841F9290-0x00000001841F9330 0x00000001841F9C70-0x00000001841F9D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CampTargetType { get => default; set {} } // 0x00000001841F9F70-0x00000001841FA010 0x00000001841FA3B0-0x00000001841FA450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetEntityId { get => default; set {} } // 0x00000001841FA220-0x00000001841FA2C0 0x00000001841F9ED0-0x00000001841F9F70

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityGadgetInfo() {} // 0x00000001841FA7A0-0x00000001841FA800
	static AbilityGadgetInfo() {} // 0x00000001841FA6E0-0x00000001841FA7A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityGadgetInfo Clone() => default; // 0x00000001841F9B80-0x00000001841F9C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityGadgetInfo ShallowCopy() => default; // 0x00000001841F9740-0x00000001841F97E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841F91C0-0x00000001841F9210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841F9E30-0x00000001841F9E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841F9E80-0x00000001841F9ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841F9210-0x00000001841F9290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841F9330-0x00000001841F9400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityGadgetInfo other) => default; // 0x00000001841F9400-0x00000001841F9540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841F98D0-0x00000001841F9A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841FA450-0x00000001841FA6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001841FA070-0x00000001841FA1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001841F9540-0x00000001841F96C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityGadgetInfo other) {} // 0x00000001841F9060-0x00000001841F91C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841F8EF0-0x00000001841F9000
}

