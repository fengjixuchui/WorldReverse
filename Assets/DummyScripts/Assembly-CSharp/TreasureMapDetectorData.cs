/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TreasureMapDetectorData : MessageBase, IMessage<TreasureMapDetectorData> // TypeDefIndex: 25833
{
	// Fields
	private static readonly MessageParser<TreasureMapDetectorData> _parser; // 0x00
	public const int RegionIdFieldNumber = 1; // Metadata: 0x00B09AC3
	private uint regionId_; // 0x18
	public const int SpotListFieldNumber = 2; // Metadata: 0x00B09AC7
	private static readonly FieldCodec<Vector> _repeated_spotList_codec; // 0x08
	private readonly RepeatedMessageField<Vector> spotList_; // 0x20
	public const int CenterPosFieldNumber = 3; // Metadata: 0x00B09ACB
	private Vector centerPos_; // 0x28
	public const int RadiusFieldNumber = 4; // Metadata: 0x00B09ACF
	private uint radius_; // 0x30
	public const int IsRegionDetectedFieldNumber = 5; // Metadata: 0x00B09AD3
	private bool isRegionDetected_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TreasureMapDetectorData> Parser { get => default; } // 0x000000018189A5A0-0x000000018189A630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018189A290-0x000000018189A320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181899C90-0x0000000181899D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181899160-0x00000001818991C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018189AB50-0x000000018189AC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018189A800-0x000000018189A860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018189A3C0-0x000000018189A4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018189AB00-0x000000018189AB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181899E50-0x0000000181899F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionId { get => default; set {} } // 0x000000018189AA60-0x000000018189AB00 0x000000018189A1F0-0x000000018189A290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Vector> SpotList { get => default; } // 0x0000000181899490-0x00000001818994F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector CenterPos { get => default; set {} } // 0x000000018189A320-0x000000018189A3C0 0x000000018189A150-0x000000018189A1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Radius { get => default; set {} } // 0x0000000181899DB0-0x0000000181899E50 0x0000000181899730-0x00000001818997D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRegionDetected { get => default; set {} } // 0x00000001818990C0-0x0000000181899160 0x00000001818991C0-0x0000000181899260

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapDetectorData() {} // 0x000000018189B0C0-0x000000018189B150
	static TreasureMapDetectorData() {} // 0x000000018189AFB0-0x000000018189B0C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapDetectorData Clone() => default; // 0x000000018189A4B0-0x000000018189A5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapDetectorData ShallowCopy() => default; // 0x0000000181899D10-0x0000000181899DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818994F0-0x0000000181899570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018189A6C0-0x000000018189A760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018189A760-0x000000018189A800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181899570-0x0000000181899730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818997D0-0x00000001818998A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TreasureMapDetectorData other) => default; // 0x00000001818998A0-0x0000000181899A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181899F40-0x000000018189A150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018189AC40-0x000000018189AFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018189A860-0x000000018189AA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181899A40-0x0000000181899C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TreasureMapDetectorData other) {} // 0x0000000181899260-0x0000000181899490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181898ED0-0x00000001818990C0
}

