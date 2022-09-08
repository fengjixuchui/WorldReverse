/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Reliquary : MessageBase, IMessage<Reliquary> // TypeDefIndex: 25972
{
	// Fields
	private static readonly MessageParser<Reliquary> _parser; // 0x00
	public const int LevelFieldNumber = 1; // Metadata: 0x00B0A87B
	private uint level_; // 0x18
	public const int ExpFieldNumber = 2; // Metadata: 0x00B0A87F
	private uint exp_; // 0x1C
	public const int PromoteLevelFieldNumber = 3; // Metadata: 0x00B0A883
	private uint promoteLevel_; // 0x20
	public const int MainPropIdFieldNumber = 4; // Metadata: 0x00B0A887
	private uint mainPropId_; // 0x24
	public const int AppendPropIdListFieldNumber = 5; // Metadata: 0x00B0A88B
	private static readonly FieldCodec<uint> _repeated_appendPropIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> appendPropIdList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Reliquary> Parser { get => default; } // 0x0000000183971E80-0x0000000183971F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183971B10-0x0000000183971BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183971630-0x00000001839716B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183970C00-0x0000000183970C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183972380-0x0000000183972470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001839720E0-0x0000000183972140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183971C00-0x0000000183971CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183972330-0x0000000183972380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001839717F0-0x00000001839718E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000183970EA0-0x0000000183970F40 0x0000000183971750-0x00000001839717F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Exp { get => default; set {} } // 0x0000000183971080-0x0000000183971120 0x0000000183971FA0-0x0000000183972040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PromoteLevel { get => default; set {} } // 0x0000000183971590-0x0000000183971630 0x0000000183971DE0-0x0000000183971E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MainPropId { get => default; set {} } // 0x0000000183970C60-0x0000000183970D00 0x0000000183971A70-0x0000000183971B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AppendPropIdList { get => default; } // 0x0000000183971BA0-0x0000000183971C00 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Reliquary() {} // 0x00000001839728E0-0x0000000183972970
	static Reliquary() {} // 0x0000000183972800-0x00000001839728E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Reliquary Clone() => default; // 0x0000000183971CF0-0x0000000183971DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Reliquary ShallowCopy() => default; // 0x00000001839716B0-0x0000000183971750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183970F40-0x0000000183970F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183972040-0x0000000183972090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183972090-0x00000001839720E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183970F90-0x0000000183971080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001839712A0-0x0000000183971370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Reliquary other) => default; // 0x0000000183971120-0x00000001839712A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001839718E0-0x0000000183971A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183972470-0x0000000183972800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183972140-0x0000000183972330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183971370-0x0000000183971590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Reliquary other) {} // 0x0000000183970D00-0x0000000183970EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183970A40-0x0000000183970C00
}

