/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GmTalkRsp : MessageBase, IMessage<GmTalkRsp> // TypeDefIndex: 23957
{
	// Fields
	private static readonly MessageParser<GmTalkRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0539B
	private int retcode_; // 0x18
	public const int MsgFieldNumber = 2; // Metadata: 0x00B0539F
	private string msg_; // 0x20
	public const int RetmsgFieldNumber = 3; // Metadata: 0x00B053A3
	private string retmsg_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GmTalkRsp> Parser { get => default; } // 0x00000001820348F0-0x0000000182034980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182034680-0x0000000182034710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182034250-0x00000001820342D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820338C0-0x0000000182033920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182034CF0-0x0000000182034DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182034AB0-0x0000000182034B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182034710-0x0000000182034800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182034CA0-0x0000000182034CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182034370-0x0000000182034460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001820341B0-0x0000000182034250 0x0000000182033CE0-0x0000000182033D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Msg { get => default; set {} } // 0x00000001820345E0-0x0000000182034680 0x0000000182034DE0-0x0000000182034E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Retmsg { get => default; set {} } // 0x0000000182033920-0x00000001820339C0 0x0000000182033C30-0x0000000182033CE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23958
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23959
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GmTalkRsp() {} // 0x00000001820351B0-0x0000000182035230
	static GmTalkRsp() {} // 0x00000001820350F0-0x00000001820351B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GmTalkRsp Clone() => default; // 0x0000000182034800-0x00000001820348F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GmTalkRsp ShallowCopy() => default; // 0x00000001820342D0-0x0000000182034370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182033B50-0x0000000182033BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182034A10-0x0000000182034A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182034A60-0x0000000182034AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182033BA0-0x0000000182033C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182033F20-0x0000000182033FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GmTalkRsp other) => default; // 0x0000000182033D80-0x0000000182033F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182034460-0x00000001820345E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182034E90-0x00000001820350F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182034B10-0x0000000182034CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182033FF0-0x00000001820341B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GmTalkRsp other) {} // 0x00000001820339C0-0x0000000182033B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820337B0-0x00000001820338C0
}

