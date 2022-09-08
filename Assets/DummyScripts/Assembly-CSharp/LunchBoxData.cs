/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LunchBoxData : MessageBase, IMessage<LunchBoxData> // TypeDefIndex: 25824
{
	// Fields
	private static readonly MessageParser<LunchBoxData> _parser; // 0x00
	public const int SlotMaterialMapFieldNumber = 1; // Metadata: 0x00B09A67
	private static readonly MapField<uint, uint> _map_slotMaterialMap_codec; // 0x08
	private readonly MapField<uint, uint> slotMaterialMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<LunchBoxData> Parser { get => default; } // 0x000000018416C780-0x000000018416C810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018416C510-0x000000018416C5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018416C210-0x000000018416C290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018416BC00-0x000000018416BC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018416CAF0-0x000000018416CBE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018416C940-0x000000018416C9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018416C5A0-0x000000018416C690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018416CAA0-0x000000018416CAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018416C330-0x000000018416C420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SlotMaterialMap { get => default; } // 0x000000018416BE70-0x000000018416BED0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LunchBoxData() {} // 0x000000018416CE60-0x000000018416CEF0
	static LunchBoxData() {} // 0x000000018416CD30-0x000000018416CE60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LunchBoxData Clone() => default; // 0x000000018416C690-0x000000018416C780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LunchBoxData ShallowCopy() => default; // 0x000000018416C290-0x000000018416C330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018416BD70-0x000000018416BDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018416C8A0-0x000000018416C8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018416C8F0-0x000000018416C940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018416BDC0-0x000000018416BE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018416BED0-0x000000018416BFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(LunchBoxData other) => default; // 0x000000018416BFA0-0x000000018416C120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018416C420-0x000000018416C510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018416CBE0-0x000000018416CD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018416C9A0-0x000000018416CAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018416C120-0x000000018416C210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(LunchBoxData other) {} // 0x000000018416BC60-0x000000018416BD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018416BAD0-0x000000018416BC00
}

