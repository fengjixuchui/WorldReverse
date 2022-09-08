/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FlightActivitySettleNotify : MessageBase, IMessage<FlightActivitySettleNotify> // TypeDefIndex: 22033
{
	// Fields
	private static readonly MessageParser<FlightActivitySettleNotify> _parser; // 0x00
	public const int IsSuccessFieldNumber = 1; // Metadata: 0x00B009E3
	private bool isSuccess_; // 0x18
	public const int LeftTimeFieldNumber = 2; // Metadata: 0x00B009E7
	private uint leftTime_; // 0x1C
	public const int CollectNumFieldNumber = 3; // Metadata: 0x00B009EB
	private uint collectNum_; // 0x20
	public const int TotalNumFieldNumber = 4; // Metadata: 0x00B009EF
	private uint totalNum_; // 0x24
	public const int ScoreFieldNumber = 5; // Metadata: 0x00B009F3
	private uint score_; // 0x28
	public const int IsNewRecordFieldNumber = 6; // Metadata: 0x00B009F7
	private bool isNewRecord_; // 0x2C
	public const int MedalLevelFieldNumber = 7; // Metadata: 0x00B009FB
	private uint medalLevel_; // 0x30
	public const int GroupIdFieldNumber = 8; // Metadata: 0x00B009FF
	private uint groupId_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FlightActivitySettleNotify> Parser { get => default; } // 0x0000000183600030-0x00000001836000C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835FFB40-0x00000001835FFBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835FF680-0x00000001835FF700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835FEAB0-0x00000001835FEB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183600720-0x0000000183600810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183600330-0x0000000183600390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835FFD10-0x00000001835FFE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836006D0-0x0000000183600720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835FF7A0-0x00000001835FF890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x0000000183600290-0x0000000183600330 0x00000001835FEBB0-0x00000001835FEC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LeftTime { get => default; set {} } // 0x00000001835FF020-0x00000001835FF0C0 0x00000001835FFAA0-0x00000001835FFB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CollectNum { get => default; set {} } // 0x00000001835FEEC0-0x00000001835FEF60 0x00000001835FEA10-0x00000001835FEAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalNum { get => default; set {} } // 0x00000001835FFF90-0x0000000183600030 0x0000000183600390-0x0000000183600430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Score { get => default; set {} } // 0x00000001835FFBD0-0x00000001835FFC70 0x00000001835FEB10-0x00000001835FEBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNewRecord { get => default; set {} } // 0x00000001835FFC70-0x00000001835FFD10 0x0000000183600810-0x00000001836008B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MedalLevel { get => default; set {} } // 0x0000000183600150-0x00000001836001F0 0x00000001836008B0-0x0000000183600950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x00000001835FFE00-0x00000001835FFEA0 0x00000001835FF5E0-0x00000001835FF680

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22034
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22035
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2070
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivitySettleNotify() {} // 0x0000000183600F60-0x0000000183600FC0
	static FlightActivitySettleNotify() {} // 0x0000000183600EA0-0x0000000183600F60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivitySettleNotify Clone() => default; // 0x00000001835FFEA0-0x00000001835FFF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivitySettleNotify ShallowCopy() => default; // 0x00000001835FF700-0x00000001835FF7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835FEE70-0x00000001835FEEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836001F0-0x0000000183600240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183600240-0x0000000183600290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835FEF60-0x00000001835FF020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835FF0C0-0x00000001835FF190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FlightActivitySettleNotify other) => default; // 0x00000001835FF190-0x00000001835FF360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835FF890-0x00000001835FFAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183600950-0x0000000183600EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183600430-0x00000001836006D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835FF360-0x00000001835FF5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FlightActivitySettleNotify other) {} // 0x00000001835FEC50-0x00000001835FEE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835FE860-0x00000001835FEA10
}

