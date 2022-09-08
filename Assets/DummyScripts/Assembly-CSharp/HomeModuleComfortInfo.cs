/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeModuleComfortInfo : MessageBase, IMessage<HomeModuleComfortInfo> // TypeDefIndex: 23432
{
	// Fields
	private static readonly MessageParser<HomeModuleComfortInfo> _parser; // 0x00
	public const int ModuleIdFieldNumber = 1; // Metadata: 0x00B04023
	private uint moduleId_; // 0x18
	public const int WorldSceneBlockComfortValueListFieldNumber = 2; // Metadata: 0x00B04027
	private static readonly FieldCodec<uint> _repeated_worldSceneBlockComfortValueList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> worldSceneBlockComfortValueList_; // 0x20
	public const int RoomSceneComfortValueFieldNumber = 3; // Metadata: 0x00B0402B
	private uint roomSceneComfortValue_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeModuleComfortInfo> Parser { get => default; } // 0x00000001833B2870-0x00000001833B2900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833B2600-0x00000001833B2690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833B22C0-0x00000001833B2340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833B1AF0-0x00000001833B1B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833B2DA0-0x00000001833B2E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833B2AD0-0x00000001833B2B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833B2690-0x00000001833B2780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833B2D50-0x00000001833B2DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833B23E0-0x00000001833B24D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ModuleId { get => default; set {} } // 0x00000001833B2990-0x00000001833B2A30 0x00000001833B2B30-0x00000001833B2BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> WorldSceneBlockComfortValueList { get => default; } // 0x00000001833B1A90-0x00000001833B1AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoomSceneComfortValue { get => default; set {} } // 0x00000001833B1DE0-0x00000001833B1E80 0x00000001833B1E80-0x00000001833B1F20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeModuleComfortInfo() {} // 0x00000001833B31E0-0x00000001833B3270
	static HomeModuleComfortInfo() {} // 0x00000001833B3100-0x00000001833B31E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeModuleComfortInfo Clone() => default; // 0x00000001833B2780-0x00000001833B2870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeModuleComfortInfo ShallowCopy() => default; // 0x00000001833B2340-0x00000001833B23E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833B1CB0-0x00000001833B1D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833B2A30-0x00000001833B2A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833B2A80-0x00000001833B2AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833B1D00-0x00000001833B1DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833B1F20-0x00000001833B1FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeModuleComfortInfo other) => default; // 0x00000001833B1FF0-0x00000001833B2130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833B24D0-0x00000001833B2600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833B2E90-0x00000001833B3100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833B2BD0-0x00000001833B2D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833B2130-0x00000001833B22C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeModuleComfortInfo other) {} // 0x00000001833B1B50-0x00000001833B1CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833B1910-0x00000001833B1A90
}

