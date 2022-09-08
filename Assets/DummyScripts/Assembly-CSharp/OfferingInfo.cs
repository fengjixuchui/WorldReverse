/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OfferingInfo : MessageBase, IMessage<OfferingInfo> // TypeDefIndex: 26038
{
	// Fields
	private static readonly MessageParser<OfferingInfo> _parser; // 0x00
	public const int OfferingIdFieldNumber = 1; // Metadata: 0x00B0ACDF
	private uint offeringId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OfferingInfo> Parser { get => default; } // 0x0000000181A0F7F0-0x0000000181A0F880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A0F4E0-0x0000000181A0F570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A0F1F0-0x0000000181A0F270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A0ED00-0x0000000181A0ED60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A0FB40-0x0000000181A0FC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A0F9B0-0x0000000181A0FA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A0F570-0x0000000181A0F660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A0FAF0-0x0000000181A0FB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A0F310-0x0000000181A0F400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OfferingId { get => default; set {} } // 0x0000000181A0FC30-0x0000000181A0FCD0 0x0000000181A0F750-0x0000000181A0F7F0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OfferingInfo() {} // 0x0000000181A0FF00-0x0000000181A0FF60
	static OfferingInfo() {} // 0x0000000181A0FE40-0x0000000181A0FF00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OfferingInfo Clone() => default; // 0x0000000181A0F660-0x0000000181A0F750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OfferingInfo ShallowCopy() => default; // 0x0000000181A0F270-0x0000000181A0F310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A0EE70-0x0000000181A0EEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A0F910-0x0000000181A0F960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A0F960-0x0000000181A0F9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A0EEC0-0x0000000181A0EF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A0EF30-0x0000000181A0F000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OfferingInfo other) => default; // 0x0000000181A0F000-0x0000000181A0F100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A0F400-0x0000000181A0F4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A0FCD0-0x0000000181A0FE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A0FA10-0x0000000181A0FAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A0F100-0x0000000181A0F1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OfferingInfo other) {} // 0x0000000181A0ED60-0x0000000181A0EE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A0EC20-0x0000000181A0ED00
}

