/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MarkMapRsp : MessageBase, IMessage<MarkMapRsp> // TypeDefIndex: 25223
{
	// Fields
	private static readonly MessageParser<MarkMapRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B083F3
	private int retcode_; // 0x18
	public const int MarkListFieldNumber = 2; // Metadata: 0x00B083F7
	private static readonly FieldCodec<MapMarkPoint> _repeated_markList_codec; // 0x08
	private readonly RepeatedMessageField<MapMarkPoint> markList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MarkMapRsp> Parser { get => default; } // 0x0000000183C10E80-0x0000000183C10F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C10C10-0x0000000183C10CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C10900-0x0000000183C10980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C10190-0x0000000183C101F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C112B0-0x0000000183C113A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C110C0-0x0000000183C11120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C10CA0-0x0000000183C10D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C11260-0x0000000183C112B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C10A20-0x0000000183C10B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183C10860-0x0000000183C10900 0x0000000183C10480-0x0000000183C10520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MapMarkPoint> MarkList { get => default; } // 0x0000000183C10130-0x0000000183C10190 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25224
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25225
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3011
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkMapRsp() {} // 0x0000000183C11690-0x0000000183C11720
	static MarkMapRsp() {} // 0x0000000183C11580-0x0000000183C11690

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkMapRsp Clone() => default; // 0x0000000183C10D90-0x0000000183C10E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkMapRsp ShallowCopy() => default; // 0x0000000183C10980-0x0000000183C10A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C10350-0x0000000183C103A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C10FA0-0x0000000183C11030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C11030-0x0000000183C110C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C103A0-0x0000000183C10480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C10520-0x0000000183C105F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MarkMapRsp other) => default; // 0x0000000183C105F0-0x0000000183C10720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C10B10-0x0000000183C10C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C113A0-0x0000000183C11580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C11120-0x0000000183C11260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C10720-0x0000000183C10860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MarkMapRsp other) {} // 0x0000000183C101F0-0x0000000183C10350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C0FFD0-0x0000000183C10130
}

