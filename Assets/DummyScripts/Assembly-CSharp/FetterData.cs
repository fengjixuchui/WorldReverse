/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FetterData : MessageBase, IMessage<FetterData> // TypeDefIndex: 26066
{
	// Fields
	private static readonly MessageParser<FetterData> _parser; // 0x00
	public const int FetterIdFieldNumber = 1; // Metadata: 0x00B0AF3F
	private uint fetterId_; // 0x18
	public const int FetterStateFieldNumber = 2; // Metadata: 0x00B0AF43
	private uint fetterState_; // 0x1C
	public const int CondIndexListFieldNumber = 3; // Metadata: 0x00B0AF47
	private static readonly FieldCodec<uint> _repeated_condIndexList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> condIndexList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FetterData> Parser { get => default; } // 0x0000000182580450-0x00000001825804E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825801E0-0x0000000182580270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018257FEA0-0x000000018257FF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018257F780-0x000000018257F7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182580970-0x0000000182580A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182580610-0x0000000182580670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182580270-0x0000000182580360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182580920-0x0000000182580970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018257FFC0-0x00000001825800B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FetterId { get => default; set {} } // 0x000000018257F680-0x000000018257F720 0x0000000182580710-0x00000001825807B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FetterState { get => default; set {} } // 0x0000000182580670-0x0000000182580710 0x000000018257F7E0-0x000000018257F880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CondIndexList { get => default; } // 0x000000018257F720-0x000000018257F780 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FetterData() {} // 0x0000000182580DB0-0x0000000182580E40
	static FetterData() {} // 0x0000000182580CD0-0x0000000182580DB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FetterData Clone() => default; // 0x0000000182580360-0x0000000182580450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FetterData ShallowCopy() => default; // 0x000000018257FF20-0x000000018257FFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018257F9E0-0x000000018257FA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182580570-0x00000001825805C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825805C0-0x0000000182580610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018257FA30-0x000000018257FB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018257FB00-0x000000018257FBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FetterData other) => default; // 0x000000018257FBD0-0x000000018257FD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001825800B0-0x00000001825801E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182580A60-0x0000000182580CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001825807B0-0x0000000182580920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018257FD10-0x000000018257FEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FetterData other) {} // 0x000000018257F880-0x000000018257F9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018257F500-0x000000018257F680
}

