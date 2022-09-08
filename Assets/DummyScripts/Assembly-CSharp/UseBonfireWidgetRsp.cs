/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseBonfireWidgetRsp : MessageBase, IMessage<UseBonfireWidgetRsp> // TypeDefIndex: 25821
{
	// Fields
	private static readonly MessageParser<UseBonfireWidgetRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09A4F
	private int retcode_; // 0x18
	public const int NextUsableTimeFieldNumber = 2; // Metadata: 0x00B09A53
	private uint nextUsableTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UseBonfireWidgetRsp> Parser { get => default; } // 0x00000001817CBF40-0x00000001817CBFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001817CBCD0-0x00000001817CBD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001817CB920-0x00000001817CB9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001817CB270-0x00000001817CB2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001817CC2D0-0x00000001817CC3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001817CC100-0x00000001817CC160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001817CBD60-0x00000001817CBE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001817CC280-0x00000001817CC2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001817CBA40-0x00000001817CBB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001817CB880-0x00000001817CB920 0x00000001817CB4C0-0x00000001817CB560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextUsableTime { get => default; set {} } // 0x00000001817CC3C0-0x00000001817CC460 0x00000001817CBC30-0x00000001817CBCD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25822
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25823
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4257
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseBonfireWidgetRsp() {} // 0x00000001817CC720-0x00000001817CC780
	static UseBonfireWidgetRsp() {} // 0x00000001817CC660-0x00000001817CC720

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseBonfireWidgetRsp Clone() => default; // 0x00000001817CBE50-0x00000001817CBF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseBonfireWidgetRsp ShallowCopy() => default; // 0x00000001817CB9A0-0x00000001817CBA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001817CB400-0x00000001817CB450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817CC060-0x00000001817CC0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817CC0B0-0x00000001817CC100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001817CB450-0x00000001817CB4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001817CB560-0x00000001817CB630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UseBonfireWidgetRsp other) => default; // 0x00000001817CB630-0x00000001817CB750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001817CBB30-0x00000001817CBC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001817CC460-0x00000001817CC660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001817CC160-0x00000001817CC280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001817CB750-0x00000001817CB880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UseBonfireWidgetRsp other) {} // 0x00000001817CB2D0-0x00000001817CB400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001817CB170-0x00000001817CB270
}

