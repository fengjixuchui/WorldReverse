/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnchorPointDataNotify : MessageBase, IMessage<AnchorPointDataNotify> // TypeDefIndex: 25802
{
	// Fields
	private static readonly MessageParser<AnchorPointDataNotify> _parser; // 0x00
	public const int AnchorPointListFieldNumber = 1; // Metadata: 0x00B099AB
	private static readonly FieldCodec<AnchorPointData> _repeated_anchorPointList_codec; // 0x08
	private readonly RepeatedMessageField<AnchorPointData> anchorPointList_; // 0x18
	public const int NextUsableTimeFieldNumber = 2; // Metadata: 0x00B099AF
	private uint nextUsableTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AnchorPointDataNotify> Parser { get => default; } // 0x00000001837B1CF0-0x00000001837B1D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837B1A20-0x00000001837B1AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001837B1670-0x00000001837B16F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001837B1040-0x00000001837B10A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837B2120-0x00000001837B2210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837B1F30-0x00000001837B1F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837B1AB0-0x00000001837B1BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837B20D0-0x00000001837B2120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837B1790-0x00000001837B1880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AnchorPointData> AnchorPointList { get => default; } // 0x00000001837B1C90-0x00000001837B1CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextUsableTime { get => default; set {} } // 0x00000001837B2210-0x00000001837B22B0 0x00000001837B1980-0x00000001837B1A20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25803
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25804
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4251
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointDataNotify() {} // 0x00000001837B25A0-0x00000001837B2630
	static AnchorPointDataNotify() {} // 0x00000001837B2490-0x00000001837B25A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointDataNotify Clone() => default; // 0x00000001837B1BA0-0x00000001837B1C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointDataNotify ShallowCopy() => default; // 0x00000001837B16F0-0x00000001837B1790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837B1210-0x00000001837B1260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837B1E10-0x00000001837B1EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837B1EA0-0x00000001837B1F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837B1260-0x00000001837B1340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837B1460-0x00000001837B1530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AnchorPointDataNotify other) => default; // 0x00000001837B1340-0x00000001837B1460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837B1880-0x00000001837B1980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837B22B0-0x00000001837B2490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837B1F90-0x00000001837B20D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001837B1530-0x00000001837B1670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AnchorPointDataNotify other) {} // 0x00000001837B10A0-0x00000001837B1210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837B0EE0-0x00000001837B1040
}

