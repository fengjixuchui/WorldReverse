/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MapMarkTipsInfo : MessageBase, IMessage<MapMarkTipsInfo> // TypeDefIndex: 26103
{
	// Fields
	private static readonly MessageParser<MapMarkTipsInfo> _parser; // 0x00
	public const int TipsTypeFieldNumber = 1; // Metadata: 0x00B0B22B
	private MapMarkTipsType tipsType_; // 0x18
	public const int PointIdListFieldNumber = 2; // Metadata: 0x00B0B22F
	private static readonly FieldCodec<uint> _repeated_pointIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> pointIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MapMarkTipsInfo> Parser { get => default; } // 0x000000018378D6E0-0x000000018378D770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018378D470-0x000000018378D500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018378D080-0x000000018378D100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018378CA00-0x000000018378CA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018378DA90-0x000000018378DB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018378D8A0-0x000000018378D900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018378D500-0x000000018378D5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018378DA40-0x000000018378DA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018378D240-0x000000018378D330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkTipsType TipsType { get => default; set {} } // 0x000000018378D1A0-0x000000018378D240 0x000000018378CCA0-0x000000018378CD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> PointIdList { get => default; } // 0x000000018378C9A0-0x000000018378CA00 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkTipsInfo() {} // 0x000000018378DE40-0x000000018378DEE0
	static MapMarkTipsInfo() {} // 0x000000018378DD60-0x000000018378DE40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkTipsInfo Clone() => default; // 0x000000018378D5F0-0x000000018378D6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkTipsInfo ShallowCopy() => default; // 0x000000018378D100-0x000000018378D1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018378CB90-0x000000018378CBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018378D800-0x000000018378D850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018378D850-0x000000018378D8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018378CBE0-0x000000018378CCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018378CE70-0x000000018378CF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MapMarkTipsInfo other) => default; // 0x000000018378CD40-0x000000018378CE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018378D330-0x000000018378D470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018378DB80-0x000000018378DD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018378D900-0x000000018378DA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018378CF40-0x000000018378D080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MapMarkTipsInfo other) {} // 0x000000018378CA60-0x000000018378CB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018378C840-0x000000018378C9A0
}

