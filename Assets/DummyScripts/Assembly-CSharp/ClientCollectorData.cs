/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientCollectorData : MessageBase, IMessage<ClientCollectorData> // TypeDefIndex: 25832
{
	// Fields
	private static readonly MessageParser<ClientCollectorData> _parser; // 0x00
	public const int MaterialIdFieldNumber = 1; // Metadata: 0x00B09AB7
	private uint materialId_; // 0x18
	public const int MaxPointsFieldNumber = 2; // Metadata: 0x00B09ABB
	private uint maxPoints_; // 0x1C
	public const int CurrPointsFieldNumber = 3; // Metadata: 0x00B09ABF
	private uint currPoints_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientCollectorData> Parser { get => default; } // 0x0000000184312900-0x0000000184312990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184312410-0x00000001843124A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184312030-0x00000001843120B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184311A10-0x0000000184311A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184312D70-0x0000000184312E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184312B60-0x0000000184312BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184312680-0x0000000184312770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184312D20-0x0000000184312D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184312150-0x0000000184312240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaterialId { get => default; set {} } // 0x00000001843124A0-0x0000000184312540 0x0000000184312540-0x00000001843125E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxPoints { get => default; set {} } // 0x0000000184312990-0x0000000184312A30 0x0000000184312370-0x0000000184312410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurrPoints { get => default; set {} } // 0x00000001843125E0-0x0000000184312680 0x0000000184312860-0x0000000184312900

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientCollectorData() {} // 0x00000001843131B0-0x0000000184313210
	static ClientCollectorData() {} // 0x00000001843130F0-0x00000001843131B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientCollectorData Clone() => default; // 0x0000000184312770-0x0000000184312860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientCollectorData ShallowCopy() => default; // 0x00000001843120B0-0x0000000184312150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184311BD0-0x0000000184311C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184312AC0-0x0000000184312B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184312B10-0x0000000184312B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184311C20-0x0000000184311CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184311CA0-0x0000000184311D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientCollectorData other) => default; // 0x0000000184311D70-0x0000000184311EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184312240-0x0000000184312370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184312E60-0x00000001843130F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184312BC0-0x0000000184312D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184311EB0-0x0000000184312030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientCollectorData other) {} // 0x0000000184311A70-0x0000000184311BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184311900-0x0000000184311A10
}

