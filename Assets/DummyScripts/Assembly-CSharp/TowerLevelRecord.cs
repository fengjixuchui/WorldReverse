/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerLevelRecord : MessageBase, IMessage<TowerLevelRecord> // TypeDefIndex: 25694
{
	// Fields
	private static readonly MessageParser<TowerLevelRecord> _parser; // 0x00
	public const int LevelIdFieldNumber = 1; // Metadata: 0x00B095B3
	private uint levelId_; // 0x18
	public const int SatisfiedCondListFieldNumber = 2; // Metadata: 0x00B095B7
	private static readonly FieldCodec<uint> _repeated_satisfiedCondList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> satisfiedCondList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerLevelRecord> Parser { get => default; } // 0x0000000181A99A00-0x0000000181A99A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A996F0-0x0000000181A99780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A993E0-0x0000000181A99460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A98D00-0x0000000181A98D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A99DB0-0x0000000181A99EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A99BC0-0x0000000181A99C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A99820-0x0000000181A99910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A99D60-0x0000000181A99DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A99500-0x0000000181A995F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LevelId { get => default; set {} } // 0x0000000181A98D60-0x0000000181A98E00 0x0000000181A99780-0x0000000181A99820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> SatisfiedCondList { get => default; } // 0x0000000181A98E00-0x0000000181A98E60 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelRecord() {} // 0x0000000181A9A160-0x0000000181A9A360
	static TowerLevelRecord() {} // 0x0000000181A9A080-0x0000000181A9A160

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelRecord Clone() => default; // 0x0000000181A99910-0x0000000181A99A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelRecord ShallowCopy() => default; // 0x0000000181A99460-0x0000000181A99500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A98F90-0x0000000181A98FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A99B20-0x0000000181A99B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A99B70-0x0000000181A99BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A98FE0-0x0000000181A990A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A991D0-0x0000000181A992A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerLevelRecord other) => default; // 0x0000000181A990A0-0x0000000181A991D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A995F0-0x0000000181A996F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A99EA0-0x0000000181A9A080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A99C20-0x0000000181A99D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A992A0-0x0000000181A993E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerLevelRecord other) {} // 0x0000000181A98E60-0x0000000181A98F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A98B90-0x0000000181A98D00
}

