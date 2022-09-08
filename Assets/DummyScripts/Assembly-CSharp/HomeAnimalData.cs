/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeAnimalData : MessageBase, IMessage<HomeAnimalData> // TypeDefIndex: 23340
{
	// Fields
	private static readonly MessageParser<HomeAnimalData> _parser; // 0x00
	public const int FurnitureIdFieldNumber = 1; // Metadata: 0x00B03CCF
	private uint furnitureId_; // 0x18
	public const int SpawnPosFieldNumber = 2; // Metadata: 0x00B03CD3
	private Vector spawnPos_; // 0x20
	public const int SpawnRotFieldNumber = 3; // Metadata: 0x00B03CD7
	private Vector spawnRot_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeAnimalData> Parser { get => default; } // 0x000000018151CE80-0x000000018151CF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018151CB70-0x000000018151CC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018151C740-0x000000018151C7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018151BC00-0x000000018151BC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018151D400-0x000000018151D4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018151D0C0-0x000000018151D120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018151CC00-0x000000018151CCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018151D3B0-0x000000018151D400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018151C860-0x000000018151C950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FurnitureId { get => default; set {} } // 0x000000018151BD00-0x000000018151BDA0 0x000000018151BC60-0x000000018151BD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector SpawnPos { get => default; set {} } // 0x000000018151D310-0x000000018151D3B0 0x000000018151CDE0-0x000000018151CE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector SpawnRot { get => default; set {} } // 0x000000018151D120-0x000000018151D1C0 0x000000018151C220-0x000000018151C2C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeAnimalData() {} // 0x000000018151D810-0x000000018151D870
	static HomeAnimalData() {} // 0x000000018151D750-0x000000018151D810

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeAnimalData Clone() => default; // 0x000000018151CCF0-0x000000018151CDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeAnimalData ShallowCopy() => default; // 0x000000018151C7C0-0x000000018151C860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018151BFA0-0x000000018151C030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018151CFA0-0x000000018151D030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018151D030-0x000000018151D0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018151C030-0x000000018151C220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018151C420-0x000000018151C4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeAnimalData other) => default; // 0x000000018151C2C0-0x000000018151C420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018151C950-0x000000018151CB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018151D4F0-0x000000018151D750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018151D1C0-0x000000018151D310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018151C4F0-0x000000018151C740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeAnimalData other) {} // 0x000000018151BDA0-0x000000018151BFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018151BA70-0x000000018151BC00
}

