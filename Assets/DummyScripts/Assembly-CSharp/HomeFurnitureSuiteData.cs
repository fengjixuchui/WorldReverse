/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeFurnitureSuiteData : MessageBase, IMessage<HomeFurnitureSuiteData> // TypeDefIndex: 23338
{
	// Fields
	private static readonly MessageParser<HomeFurnitureSuiteData> _parser; // 0x00
	public const int SuiteIdFieldNumber = 1; // Metadata: 0x00B03CB7
	private uint suiteId_; // 0x18
	public const int SpawnPosFieldNumber = 2; // Metadata: 0x00B03CBB
	private Vector spawnPos_; // 0x20
	public const int IncludedFurnitureIndexListFieldNumber = 3; // Metadata: 0x00B03CBF
	private static readonly FieldCodec<int> _repeated_includedFurnitureIndexList_codec; // 0x08
	private readonly RepeatedPrimitiveField<int> includedFurnitureIndexList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeFurnitureSuiteData> Parser { get => default; } // 0x0000000183377590-0x0000000183377620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183377280-0x0000000183377310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183376ED0-0x0000000183376F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183376500-0x0000000183376560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183377A70-0x0000000183377B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833777B0-0x0000000183377810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183377310-0x0000000183377400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183377A20-0x0000000183377A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183376FF0-0x00000001833770E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SuiteId { get => default; set {} } // 0x0000000183376E30-0x0000000183376ED0 0x0000000183376560-0x0000000183376600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector SpawnPos { get => default; set {} } // 0x0000000183377980-0x0000000183377A20 0x00000001833774F0-0x0000000183377590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> IncludedFurnitureIndexList { get => default; } // 0x0000000183376DD0-0x0000000183376E30 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeFurnitureSuiteData() {} // 0x0000000183377EA0-0x0000000183377F30
	static HomeFurnitureSuiteData() {} // 0x0000000183377DC0-0x0000000183377EA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeFurnitureSuiteData Clone() => default; // 0x0000000183377400-0x00000001833774F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeFurnitureSuiteData ShallowCopy() => default; // 0x0000000183376F50-0x0000000183376FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833767B0-0x0000000183376830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833776B0-0x0000000183377730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183377730-0x00000001833777B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183376830-0x00000001833769C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833769C0-0x0000000183376A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeFurnitureSuiteData other) => default; // 0x0000000183376A90-0x0000000183376BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833770E0-0x0000000183377280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183377B60-0x0000000183377DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183377810-0x0000000183377980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183376BE0-0x0000000183376DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeFurnitureSuiteData other) {} // 0x0000000183376600-0x00000001833767B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183376340-0x0000000183376500
}

