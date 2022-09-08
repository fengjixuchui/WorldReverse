/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CityInfo : MessageBase, IMessage<CityInfo> // TypeDefIndex: 24937
{
	// Fields
	private static readonly MessageParser<CityInfo> _parser; // 0x00
	public const int CityIdFieldNumber = 1; // Metadata: 0x00B07983
	private uint cityId_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B07987
	private uint level_; // 0x1C
	public const int CrystalNumFieldNumber = 3; // Metadata: 0x00B0798B
	private uint crystalNum_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CityInfo> Parser { get => default; } // 0x000000018200EEC0-0x000000018200EF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018200EC50-0x000000018200ECE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018200E870-0x000000018200E8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018200E070-0x000000018200E0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018200F330-0x000000018200F420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018200F120-0x000000018200F180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018200ECE0-0x000000018200EDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018200F2E0-0x000000018200F330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018200EA30-0x000000018200EB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x000000018200E230-0x000000018200E2D0 0x000000018200EFE0-0x000000018200F080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x000000018200E2D0-0x000000018200E370 0x000000018200E990-0x000000018200EA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CrystalNum { get => default; set {} } // 0x000000018200DFD0-0x000000018200E070 0x000000018200E370-0x000000018200E410

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityInfo() {} // 0x000000018200F770-0x000000018200F7D0
	static CityInfo() {} // 0x000000018200F6B0-0x000000018200F770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityInfo Clone() => default; // 0x000000018200EDD0-0x000000018200EEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityInfo ShallowCopy() => default; // 0x000000018200E8F0-0x000000018200E990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018200E410-0x000000018200E460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018200F080-0x000000018200F0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018200F0D0-0x000000018200F120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018200E460-0x000000018200E4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018200E4E0-0x000000018200E5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CityInfo other) => default; // 0x000000018200E5B0-0x000000018200E6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018200EB20-0x000000018200EC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018200F420-0x000000018200F6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018200F180-0x000000018200F2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018200E6F0-0x000000018200E870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CityInfo other) {} // 0x000000018200E0D0-0x000000018200E230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018200DEC0-0x000000018200DFD0
}

