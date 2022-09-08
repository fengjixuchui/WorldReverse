/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PingRsp : MessageBase, IMessage<PingRsp> // TypeDefIndex: 23968
{
	// Fields
	private static readonly MessageParser<PingRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0540F
	private int retcode_; // 0x18
	public const int SeqFieldNumber = 2; // Metadata: 0x00B05413
	private uint seq_; // 0x1C
	public const int ClientTimeFieldNumber = 3; // Metadata: 0x00B05417
	private uint clientTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PingRsp> Parser { get => default; } // 0x00000001822D6340-0x00000001822D63D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001822D6030-0x00000001822D60C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001822D5CF0-0x00000001822D5D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001822D5450-0x00000001822D54B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001822D67B0-0x00000001822D68A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001822D6500-0x00000001822D6560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001822D60C0-0x00000001822D61B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001822D6760-0x00000001822D67B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822D5E10-0x00000001822D5F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001822D5BB0-0x00000001822D5C50 0x00000001822D5780-0x00000001822D5820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Seq { get => default; set {} } // 0x00000001822D5610-0x00000001822D56B0 0x00000001822D5C50-0x00000001822D5CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientTime { get => default; set {} } // 0x00000001822D6560-0x00000001822D6600 0x00000001822D61B0-0x00000001822D6250

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23969
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23970
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 6
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PingRsp() {} // 0x00000001822D6BF0-0x00000001822D6C50
	static PingRsp() {} // 0x00000001822D6B30-0x00000001822D6BF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PingRsp Clone() => default; // 0x00000001822D6250-0x00000001822D6340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PingRsp ShallowCopy() => default; // 0x00000001822D5D70-0x00000001822D5E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001822D56B0-0x00000001822D5700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822D6460-0x00000001822D64B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822D64B0-0x00000001822D6500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001822D5700-0x00000001822D5780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001822D5960-0x00000001822D5A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PingRsp other) => default; // 0x00000001822D5820-0x00000001822D5960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822D5F00-0x00000001822D6030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001822D68A0-0x00000001822D6B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001822D6600-0x00000001822D6760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822D5A30-0x00000001822D5BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PingRsp other) {} // 0x00000001822D54B0-0x00000001822D5610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001822D5340-0x00000001822D5450
}

