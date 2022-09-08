/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Weapon : MessageBase, IMessage<Weapon> // TypeDefIndex: 25973
{
	// Fields
	private static readonly MessageParser<Weapon> _parser; // 0x00
	public const int LevelFieldNumber = 1; // Metadata: 0x00B0A88F
	private uint level_; // 0x18
	public const int ExpFieldNumber = 2; // Metadata: 0x00B0A893
	private uint exp_; // 0x1C
	public const int PromoteLevelFieldNumber = 3; // Metadata: 0x00B0A897
	private uint promoteLevel_; // 0x20
	public const int AffixMapFieldNumber = 4; // Metadata: 0x00B0A89B
	private static readonly MapField<uint, uint> _map_affixMap_codec; // 0x08
	private readonly MapField<uint, uint> affixMap_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Weapon> Parser { get => default; } // 0x0000000183269790-0x0000000183269820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183269480-0x0000000183269510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183269040-0x00000001832690C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832686C0-0x0000000183268720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183269C50-0x0000000183269D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001832699F0-0x0000000183269A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183269510-0x0000000183269600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183269C00-0x0000000183269C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183269200-0x00000001832692F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x00000001832688A0-0x0000000183268940 0x0000000183269160-0x0000000183269200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Exp { get => default; set {} } // 0x0000000183268A70-0x0000000183268B10 0x00000001832698B0-0x0000000183269950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PromoteLevel { get => default; set {} } // 0x0000000183268FA0-0x0000000183269040 0x00000001832696F0-0x0000000183269790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> AffixMap { get => default; } // 0x0000000183268F40-0x0000000183268FA0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Weapon() {} // 0x000000018326A170-0x000000018326A200
	static Weapon() {} // 0x000000018326A040-0x000000018326A170

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Weapon Clone() => default; // 0x0000000183269600-0x00000001832696F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Weapon ShallowCopy() => default; // 0x00000001832690C0-0x0000000183269160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183268940-0x0000000183268990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183269950-0x00000001832699A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832699A0-0x00000001832699F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183268990-0x0000000183268A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183268C90-0x0000000183268D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Weapon other) => default; // 0x0000000183268B10-0x0000000183268C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832692F0-0x0000000183269480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183269D40-0x000000018326A040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183269A50-0x0000000183269C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183268D60-0x0000000183268F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Weapon other) {} // 0x0000000183268720-0x00000001832688A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183268520-0x00000001832686C0
}

