/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingAcceptGivePicRsp : MessageBase, IMessage<BlessingAcceptGivePicRsp> // TypeDefIndex: 22146
{
	// Fields
	private static readonly MessageParser<BlessingAcceptGivePicRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00E6B
	private int retcode_; // 0x18
	public const int UidFieldNumber = 2; // Metadata: 0x00B00E6F
	private uint uid_; // 0x1C
	public const int IndexFieldNumber = 3; // Metadata: 0x00B00E73
	private uint index_; // 0x20
	public const int PicIdFieldNumber = 4; // Metadata: 0x00B00E77
	private uint picId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingAcceptGivePicRsp> Parser { get => default; } // 0x0000000182914AF0-0x0000000182914B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182914740-0x00000001829147D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182914290-0x0000000182914310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182913960-0x00000001829139C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182914F00-0x0000000182914FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182914CB0-0x0000000182914D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182914910-0x0000000182914A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182914EB0-0x0000000182914F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182914450-0x0000000182914540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182914150-0x00000001829141F0 0x0000000182913C20-0x0000000182913CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001829141F0-0x0000000182914290 0x00000001829147D0-0x0000000182914870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Index { get => default; set {} } // 0x00000001829140B0-0x0000000182914150 0x00000001829146A0-0x0000000182914740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PicId { get => default; set {} } // 0x00000001829143B0-0x0000000182914450 0x0000000182914870-0x0000000182914910

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22147
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22148
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2150
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingAcceptGivePicRsp() {} // 0x00000001829153D0-0x0000000182915430
	static BlessingAcceptGivePicRsp() {} // 0x0000000182915310-0x00000001829153D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingAcceptGivePicRsp Clone() => default; // 0x0000000182914A00-0x0000000182914AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingAcceptGivePicRsp ShallowCopy() => default; // 0x0000000182914310-0x00000001829143B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182913B40-0x0000000182913B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182914C10-0x0000000182914C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182914C60-0x0000000182914CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182913B90-0x0000000182913C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182913E10-0x0000000182913EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingAcceptGivePicRsp other) => default; // 0x0000000182913CC0-0x0000000182913E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182914540-0x00000001829146A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182914FF0-0x0000000182915310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182914D10-0x0000000182914EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182913EE0-0x00000001829140B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingAcceptGivePicRsp other) {} // 0x00000001829139C0-0x0000000182913B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182913830-0x0000000182913960
}

