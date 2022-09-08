/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseItemRsp : MessageBase, IMessage<UseItemRsp> // TypeDefIndex: 23627
{
	// Fields
	private static readonly MessageParser<UseItemRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04727
	private int retcode_; // 0x18
	public const int GuidFieldNumber = 2; // Metadata: 0x00B0472B
	private ulong guid_; // 0x20
	public const int ItemIdFieldNumber = 3; // Metadata: 0x00B0472F
	private uint itemId_; // 0x28
	public const int TargetGuidFieldNumber = 4; // Metadata: 0x00B04733
	private ulong targetGuid_; // 0x30
	public const int OptionIdxFieldNumber = 5; // Metadata: 0x00B04737
	private uint optionIdx_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UseItemRsp> Parser { get => default; } // 0x0000000182FC0200-0x0000000182FC0290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182FBFF90-0x0000000182FC0020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182FBFBF0-0x0000000182FBFC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182FBF0C0-0x0000000182FBF120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182FC08D0-0x0000000182FC09C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182FC0500-0x0000000182FC0560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182FC0020-0x0000000182FC0110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182FC07E0-0x0000000182FC0830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182FBFD10-0x0000000182FBFE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182FBFB50-0x0000000182FBFBF0 0x0000000182FBF5A0-0x0000000182FBF640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x0000000182FBF2D0-0x0000000182FBF370 0x0000000182FBF500-0x0000000182FBF5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x0000000182FC0320-0x0000000182FC03C0 0x0000000182FC0830-0x0000000182FC08D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetGuid { get => default; set {} } // 0x0000000182FC0460-0x0000000182FC0500 0x0000000182FBFAB0-0x0000000182FBFB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OptionIdx { get => default; set {} } // 0x0000000182FBF370-0x0000000182FBF410 0x0000000182FC0740-0x0000000182FC07E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23628
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23629
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 609
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseItemRsp() {} // 0x0000000182FC0E30-0x0000000182FC0E90
	static UseItemRsp() {} // 0x0000000182FC0D70-0x0000000182FC0E30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseItemRsp Clone() => default; // 0x0000000182FC0110-0x0000000182FC0200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseItemRsp ShallowCopy() => default; // 0x0000000182FBFC70-0x0000000182FBFD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182FBF410-0x0000000182FBF460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FC03C0-0x0000000182FC0410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FC0410-0x0000000182FC0460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182FBF460-0x0000000182FBF500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182FBF640-0x0000000182FBF710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UseItemRsp other) => default; // 0x0000000182FBF710-0x0000000182FBF890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182FBFE00-0x0000000182FBFF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182FC09C0-0x0000000182FC0D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182FC0560-0x0000000182FC0740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182FBF890-0x0000000182FBFAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UseItemRsp other) {} // 0x0000000182FBF120-0x0000000182FBF2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182FBEF70-0x0000000182FBF0C0
}

