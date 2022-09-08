/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeFurnitureData : MessageBase, IMessage<HomeFurnitureData> // TypeDefIndex: 23337
{
	// Fields
	private static readonly MessageParser<HomeFurnitureData> _parser; // 0x00
	public const int FurnitureIdFieldNumber = 1; // Metadata: 0x00B03CA7
	private uint furnitureId_; // 0x18
	public const int SpawnPosFieldNumber = 3; // Metadata: 0x00B03CAB
	private Vector spawnPos_; // 0x20
	public const int SpawnRotFieldNumber = 4; // Metadata: 0x00B03CAF
	private Vector spawnRot_; // 0x28
	public const int ParentFurnitureIndexFieldNumber = 7; // Metadata: 0x00B03CB3
	private int parentFurnitureIndex_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeFurnitureData> Parser { get => default; } // 0x0000000181CFCEE0-0x0000000181CFCF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181CFCB30-0x0000000181CFCBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181CFC630-0x0000000181CFC6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181CFBA60-0x0000000181CFBAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181CFD4A0-0x0000000181CFD590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181CFD120-0x0000000181CFD180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181CFCBC0-0x0000000181CFCCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181CFD450-0x0000000181CFD4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181CFC7F0-0x0000000181CFC8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FurnitureId { get => default; set {} } // 0x0000000181CFBB60-0x0000000181CFBC00 0x0000000181CFBAC0-0x0000000181CFBB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector SpawnPos { get => default; set {} } // 0x0000000181CFD3B0-0x0000000181CFD450 0x0000000181CFCDA0-0x0000000181CFCE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector SpawnRot { get => default; set {} } // 0x0000000181CFD180-0x0000000181CFD220 0x0000000181CFC0B0-0x0000000181CFC150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int ParentFurnitureIndex { get => default; set {} } // 0x0000000181CFC750-0x0000000181CFC7F0 0x0000000181CFCE40-0x0000000181CFCEE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeFurnitureData() {} // 0x0000000181CFD930-0x0000000181CFD990
	static HomeFurnitureData() {} // 0x0000000181CFD870-0x0000000181CFD930

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeFurnitureData Clone() => default; // 0x0000000181CFCCB0-0x0000000181CFCDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeFurnitureData ShallowCopy() => default; // 0x0000000181CFC6B0-0x0000000181CFC750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181CFBE20-0x0000000181CFBEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CFD000-0x0000000181CFD090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CFD090-0x0000000181CFD120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181CFBEB0-0x0000000181CFC0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181CFC150-0x0000000181CFC220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeFurnitureData other) => default; // 0x0000000181CFC220-0x0000000181CFC3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181CFC8E0-0x0000000181CFCB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181CFD590-0x0000000181CFD870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181CFD220-0x0000000181CFD3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181CFC3A0-0x0000000181CFC630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeFurnitureData other) {} // 0x0000000181CFBC00-0x0000000181CFBE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181CFB8B0-0x0000000181CFBA60
}

