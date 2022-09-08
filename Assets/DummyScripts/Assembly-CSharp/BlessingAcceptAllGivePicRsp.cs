/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingAcceptAllGivePicRsp : MessageBase, IMessage<BlessingAcceptAllGivePicRsp> // TypeDefIndex: 22161
{
	// Fields
	private static readonly MessageParser<BlessingAcceptAllGivePicRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00EE3
	private int retcode_; // 0x18
	public const int AcceptPicNumMapFieldNumber = 2; // Metadata: 0x00B00EE7
	private static readonly MapField<uint, uint> _map_acceptPicNumMap_codec; // 0x08
	private readonly MapField<uint, uint> acceptPicNumMap_; // 0x20
	public const int AcceptIndexListFieldNumber = 3; // Metadata: 0x00B00EEB
	private static readonly FieldCodec<uint> _repeated_acceptIndexList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> acceptIndexList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingAcceptAllGivePicRsp> Parser { get => default; } // 0x00000001838EFF30-0x00000001838EFFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838EFCC0-0x00000001838EFD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001838EF950-0x00000001838EF9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838EF070-0x00000001838EF0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838F0310-0x00000001838F0400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838F00F0-0x00000001838F0150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838EFD50-0x00000001838EFE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838F02C0-0x00000001838F0310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838EFA70-0x00000001838EFB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001838EF850-0x00000001838EF8F0 0x00000001838EF3F0-0x00000001838EF490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> AcceptPicNumMap { get => default; } // 0x00000001838EF8F0-0x00000001838EF950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AcceptIndexList { get => default; } // 0x00000001838EF220-0x00000001838EF280 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22162
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22163
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2155
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingAcceptAllGivePicRsp() {} // 0x00000001838F07B0-0x00000001838F0860
	static BlessingAcceptAllGivePicRsp() {} // 0x00000001838F0660-0x00000001838F07B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingAcceptAllGivePicRsp Clone() => default; // 0x00000001838EFE40-0x00000001838EFF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingAcceptAllGivePicRsp ShallowCopy() => default; // 0x00000001838EF9D0-0x00000001838EFA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838EF280-0x00000001838EF2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838F0050-0x00000001838F00A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838F00A0-0x00000001838F00F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001838EF2D0-0x00000001838EF3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838EF600-0x00000001838EF6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingAcceptAllGivePicRsp other) => default; // 0x00000001838EF490-0x00000001838EF600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001838EFB60-0x00000001838EFCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838F0400-0x00000001838F0660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838F0150-0x00000001838F02C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838EF6D0-0x00000001838EF850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingAcceptAllGivePicRsp other) {} // 0x00000001838EF0D0-0x00000001838EF220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838EEE90-0x00000001838EF070
}

