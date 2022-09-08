/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FinishMainCoopRsp : MessageBase, IMessage<FinishMainCoopRsp> // TypeDefIndex: 22692
{
	// Fields
	private static readonly MessageParser<FinishMainCoopRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0229B
	private int retcode_; // 0x18
	public const int IdFieldNumber = 2; // Metadata: 0x00B0229F
	private uint id_; // 0x1C
	public const int EndingSavePointIdFieldNumber = 3; // Metadata: 0x00B022A3
	private uint endingSavePointId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FinishMainCoopRsp> Parser { get => default; } // 0x00000001835E0DD0-0x00000001835E0E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835E0B60-0x00000001835E0BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835E0820-0x00000001835E08A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835DFF80-0x00000001835DFFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835E12E0-0x00000001835E13D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835E10D0-0x00000001835E1130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835E0BF0-0x00000001835E0CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835E1290-0x00000001835E12E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835E0940-0x00000001835E0A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001835E06E0-0x00000001835E0780 0x00000001835E0210-0x00000001835E02B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x00000001835E0780-0x00000001835E0820 0x00000001835E0E60-0x00000001835E0F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndingSavePointId { get => default; set {} } // 0x00000001835E0FE0-0x00000001835E1080 0x00000001835E02B0-0x00000001835E0350

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22693
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22694
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1956
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishMainCoopRsp() {} // 0x00000001835E1720-0x00000001835E1780
	static FinishMainCoopRsp() {} // 0x00000001835E1660-0x00000001835E1720

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishMainCoopRsp Clone() => default; // 0x00000001835E0CE0-0x00000001835E0DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FinishMainCoopRsp ShallowCopy() => default; // 0x00000001835E08A0-0x00000001835E0940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835E0140-0x00000001835E0190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835E0F90-0x00000001835E0FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835E1080-0x00000001835E10D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835E0190-0x00000001835E0210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835E0490-0x00000001835E0560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FinishMainCoopRsp other) => default; // 0x00000001835E0350-0x00000001835E0490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835E0A30-0x00000001835E0B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835E13D0-0x00000001835E1660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835E1130-0x00000001835E1290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835E0560-0x00000001835E06E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FinishMainCoopRsp other) {} // 0x00000001835DFFE0-0x00000001835E0140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835DFE70-0x00000001835DFF80
}

