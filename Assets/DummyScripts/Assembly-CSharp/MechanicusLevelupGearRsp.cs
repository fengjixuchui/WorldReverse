/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MechanicusLevelupGearRsp : MessageBase, IMessage<MechanicusLevelupGearRsp> // TypeDefIndex: 23904
{
	// Fields
	private static readonly MessageParser<MechanicusLevelupGearRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0518B
	private int retcode_; // 0x18
	public const int MechanicusIdFieldNumber = 2; // Metadata: 0x00B0518F
	private uint mechanicusId_; // 0x1C
	public const int GearIdFieldNumber = 3; // Metadata: 0x00B05193
	private uint gearId_; // 0x20
	public const int AfterGearLevelFieldNumber = 4; // Metadata: 0x00B05197
	private uint afterGearLevel_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MechanicusLevelupGearRsp> Parser { get => default; } // 0x0000000182108650-0x00000001821086E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182108340-0x00000001821083D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182107F30-0x0000000182107FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182107600-0x0000000182107660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182108B00-0x0000000182108BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001821088B0-0x0000000182108910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182108470-0x0000000182108560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182108AB0-0x0000000182108B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001821080F0-0x00000001821081E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182107E90-0x0000000182107F30 0x0000000182107A00-0x0000000182107AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusId { get => default; set {} } // 0x00000001821083D0-0x0000000182108470 0x0000000182107960-0x0000000182107A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GearId { get => default; set {} } // 0x0000000182108810-0x00000001821088B0 0x0000000182108050-0x00000001821080F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AfterGearLevel { get => default; set {} } // 0x0000000182107830-0x00000001821078D0 0x0000000182107430-0x00000001821074D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23905
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23906
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3910
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusLevelupGearRsp() {} // 0x0000000182108FD0-0x0000000182109030
	static MechanicusLevelupGearRsp() {} // 0x0000000182108F10-0x0000000182108FD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusLevelupGearRsp Clone() => default; // 0x0000000182108560-0x0000000182108650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusLevelupGearRsp ShallowCopy() => default; // 0x0000000182107FB0-0x0000000182108050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001821077E0-0x0000000182107830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182108770-0x00000001821087C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821087C0-0x0000000182108810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001821078D0-0x0000000182107960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182107BF0-0x0000000182107CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MechanicusLevelupGearRsp other) => default; // 0x0000000182107AA0-0x0000000182107BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001821081E0-0x0000000182108340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182108BF0-0x0000000182108F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182108910-0x0000000182108AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182107CC0-0x0000000182107E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MechanicusLevelupGearRsp other) {} // 0x0000000182107660-0x00000001821077E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001821074D0-0x0000000182107600
}

