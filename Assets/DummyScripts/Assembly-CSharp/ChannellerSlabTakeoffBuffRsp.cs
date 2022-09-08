/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabTakeoffBuffRsp : MessageBase, IMessage<ChannellerSlabTakeoffBuffRsp> // TypeDefIndex: 22286
{
	// Fields
	private static readonly MessageParser<ChannellerSlabTakeoffBuffRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B013EF
	private int retcode_; // 0x18
	public const int BuffIdFieldNumber = 2; // Metadata: 0x00B013F3
	private uint buffId_; // 0x1C
	public const int SlotIdFieldNumber = 3; // Metadata: 0x00B013F7
	private uint slotId_; // 0x20
	public const int IsMpFieldNumber = 4; // Metadata: 0x00B013FB
	private bool isMp_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabTakeoffBuffRsp> Parser { get => default; } // 0x000000018440A150-0x000000018440A1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184409E40-0x0000000184409ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184409AD0-0x0000000184409B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184409090-0x00000001844090F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018440A560-0x000000018440A650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018440A310-0x000000018440A370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184409ED0-0x0000000184409FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018440A510-0x000000018440A560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184409BF0-0x0000000184409CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184409A30-0x0000000184409AD0 0x0000000184409530-0x00000001844095D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuffId { get => default; set {} } // 0x000000018440A0B0-0x000000018440A150 0x00000001844090F0-0x0000000184409190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SlotId { get => default; set {} } // 0x000000018440A650-0x000000018440A6F0 0x0000000184409800-0x00000001844098A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMp { get => default; set {} } // 0x0000000184409490-0x0000000184409530 0x0000000184409190-0x0000000184409230

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22287
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22288
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8006
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabTakeoffBuffRsp() {} // 0x000000018440AAD0-0x000000018440AB30
	static ChannellerSlabTakeoffBuffRsp() {} // 0x000000018440AA10-0x000000018440AAD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabTakeoffBuffRsp Clone() => default; // 0x0000000184409FC0-0x000000018440A0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabTakeoffBuffRsp ShallowCopy() => default; // 0x0000000184409B50-0x0000000184409BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001844093B0-0x0000000184409400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018440A270-0x000000018440A2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018440A2C0-0x000000018440A310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184409400-0x0000000184409490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184409730-0x0000000184409800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabTakeoffBuffRsp other) => default; // 0x00000001844095D0-0x0000000184409730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184409CE0-0x0000000184409E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018440A6F0-0x000000018440AA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018440A370-0x000000018440A510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001844098A0-0x0000000184409A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabTakeoffBuffRsp other) {} // 0x0000000184409230-0x00000001844093B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184408F60-0x0000000184409090
}

