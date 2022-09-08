/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FurnitureMakeData : MessageBase, IMessage<FurnitureMakeData> // TypeDefIndex: 23440
{
	// Fields
	private static readonly MessageParser<FurnitureMakeData> _parser; // 0x00
	public const int IndexFieldNumber = 1; // Metadata: 0x00B04073
	private uint index_; // 0x18
	public const int MakeIdFieldNumber = 2; // Metadata: 0x00B04077
	private uint makeId_; // 0x1C
	public const int BeginTimeFieldNumber = 3; // Metadata: 0x00B0407B
	private uint beginTime_; // 0x20
	public const int DurTimeFieldNumber = 4; // Metadata: 0x00B0407F
	private uint durTime_; // 0x24
	public const int AccelerateTimeFieldNumber = 5; // Metadata: 0x00B04083
	private uint accelerateTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FurnitureMakeData> Parser { get => default; } // 0x00000001836EDD00-0x00000001836EDD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836EDA90-0x00000001836EDB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836ED5B0-0x00000001836ED630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836ECD90-0x00000001836ECDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836EE3D0-0x00000001836EE4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836EE000-0x00000001836EE060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836EDB20-0x00000001836EDC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836EE380-0x00000001836EE3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836ED6D0-0x00000001836ED7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Index { get => default; set {} } // 0x00000001836ED510-0x00000001836ED5B0 0x00000001836ED9F0-0x00000001836EDA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MakeId { get => default; set {} } // 0x00000001836ECFA0-0x00000001836ED040 0x00000001836ECCF0-0x00000001836ECD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x00000001836EE2E0-0x00000001836EE380 0x00000001836EDF60-0x00000001836EE000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DurTime { get => default; set {} } // 0x00000001836ED950-0x00000001836ED9F0 0x00000001836EDE70-0x00000001836EDF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AccelerateTime { get => default; set {} } // 0x00000001836EE060-0x00000001836EE100 0x00000001836EE4C0-0x00000001836EE560

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeData() {} // 0x00000001836EE9C0-0x00000001836EEA20
	static FurnitureMakeData() {} // 0x00000001836EE900-0x00000001836EE9C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeData Clone() => default; // 0x00000001836EDC10-0x00000001836EDD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeData ShallowCopy() => default; // 0x00000001836ED630-0x00000001836ED6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836ED040-0x00000001836ED090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836EDE20-0x00000001836EDE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836EDF10-0x00000001836EDF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001836ED090-0x00000001836ED130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836ED130-0x00000001836ED200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FurnitureMakeData other) => default; // 0x00000001836ED200-0x00000001836ED370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836ED7C0-0x00000001836ED950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836EE560-0x00000001836EE900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836EE100-0x00000001836EE2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001836ED370-0x00000001836ED510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FurnitureMakeData other) {} // 0x00000001836ECDF0-0x00000001836ECFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836ECB80-0x00000001836ECCF0
}

