/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingGiveFriendPicRsp : MessageBase, IMessage<BlessingGiveFriendPicRsp> // TypeDefIndex: 22140
{
	// Fields
	private static readonly MessageParser<BlessingGiveFriendPicRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00E33
	private int retcode_; // 0x18
	public const int UidFieldNumber = 2; // Metadata: 0x00B00E37
	private uint uid_; // 0x1C
	public const int PicIdFieldNumber = 3; // Metadata: 0x00B00E3B
	private uint picId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingGiveFriendPicRsp> Parser { get => default; } // 0x0000000184CA20D0-0x0000000184CA2160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184CA1D20-0x0000000184CA1DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184CA1940-0x0000000184CA19C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184CA1140-0x0000000184CA11A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184CA24A0-0x0000000184CA2590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184CA2290-0x0000000184CA22F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184CA1EF0-0x0000000184CA1FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184CA2450-0x0000000184CA24A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184CA1B00-0x0000000184CA1BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184CA1800-0x0000000184CA18A0 0x0000000184CA13D0-0x0000000184CA1470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000184CA18A0-0x0000000184CA1940 0x0000000184CA1DB0-0x0000000184CA1E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PicId { get => default; set {} } // 0x0000000184CA1A60-0x0000000184CA1B00 0x0000000184CA1E50-0x0000000184CA1EF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22141
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22142
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2148
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGiveFriendPicRsp() {} // 0x0000000184CA28E0-0x0000000184CA2940
	static BlessingGiveFriendPicRsp() {} // 0x0000000184CA2820-0x0000000184CA28E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGiveFriendPicRsp Clone() => default; // 0x0000000184CA1FE0-0x0000000184CA20D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGiveFriendPicRsp ShallowCopy() => default; // 0x0000000184CA19C0-0x0000000184CA1A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184CA1300-0x0000000184CA1350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CA21F0-0x0000000184CA2240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CA2240-0x0000000184CA2290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184CA1350-0x0000000184CA13D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184CA1470-0x0000000184CA1540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingGiveFriendPicRsp other) => default; // 0x0000000184CA1540-0x0000000184CA1680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184CA1BF0-0x0000000184CA1D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184CA2590-0x0000000184CA2820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184CA22F0-0x0000000184CA2450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184CA1680-0x0000000184CA1800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingGiveFriendPicRsp other) {} // 0x0000000184CA11A0-0x0000000184CA1300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184CA1030-0x0000000184CA1140
}

