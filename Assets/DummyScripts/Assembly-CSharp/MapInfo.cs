/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MapInfo : MessageBase, IMessage<MapInfo> // TypeDefIndex: 26106
{
	// Fields
	private static readonly MessageParser<MapInfo> _parser; // 0x00
	public const int MinxFieldNumber = 1; // Metadata: 0x00B0B25F
	private int minx_; // 0x18
	public const int MaxxFieldNumber = 2; // Metadata: 0x00B0B263
	private int maxx_; // 0x1C
	public const int MinzFieldNumber = 3; // Metadata: 0x00B0B267
	private int minz_; // 0x20
	public const int MaxzFieldNumber = 4; // Metadata: 0x00B0B26B
	private int maxz_; // 0x24
	public const int CellsFieldNumber = 5; // Metadata: 0x00B0B26F
	private static readonly FieldCodec<CellInfo> _repeated_cells_codec; // 0x08
	private readonly RepeatedMessageField<CellInfo> cells_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MapInfo> Parser { get => default; } // 0x000000018248A9A0-0x000000018248AA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018248A630-0x000000018248A6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018248A1F0-0x000000018248A270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182489800-0x0000000182489860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018248AFC0-0x000000018248B0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018248AC80-0x000000018248ACE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018248A6C0-0x000000018248A7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018248AF70-0x000000018248AFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018248A310-0x000000018248A400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Minx { get => default; set {} } // 0x000000018248ACE0-0x000000018248AD80 0x0000000182489860-0x0000000182489900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Maxx { get => default; set {} } // 0x000000018248A8A0-0x000000018248A940 0x000000018248AB50-0x000000018248ABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Minz { get => default; set {} } // 0x000000018248B0B0-0x000000018248B150 0x0000000182489B20-0x0000000182489BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Maxz { get => default; set {} } // 0x000000018248A590-0x000000018248A630 0x0000000182489CD0-0x0000000182489D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CellInfo> Cells { get => default; } // 0x000000018248A940-0x000000018248A9A0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapInfo() {} // 0x000000018248B5F0-0x000000018248B680
	static MapInfo() {} // 0x000000018248B4E0-0x000000018248B5F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapInfo Clone() => default; // 0x000000018248A7B0-0x000000018248A8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapInfo ShallowCopy() => default; // 0x000000018248A270-0x000000018248A310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182489AD0-0x0000000182489B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018248AAC0-0x000000018248AB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018248ABF0-0x000000018248AC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182489BC0-0x0000000182489CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182489D70-0x0000000182489E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MapInfo other) => default; // 0x0000000182489E40-0x0000000182489FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018248A400-0x000000018248A590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018248B150-0x000000018248B4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018248AD80-0x000000018248AF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182489FD0-0x000000018248A1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MapInfo other) {} // 0x0000000182489900-0x0000000182489AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182489640-0x0000000182489800
}

