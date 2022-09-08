/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MeetNpcRsp : MessageBase, IMessage<MeetNpcRsp> // TypeDefIndex: 24219
{
	// Fields
	private static readonly MessageParser<MeetNpcRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05E03
	private int retcode_; // 0x18
	public const int NpcFirstMetIdFieldNumber = 2; // Metadata: 0x00B05E07
	private uint npcFirstMetId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MeetNpcRsp> Parser { get => default; } // 0x0000000182DA0890-0x0000000182DA0920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182DA0620-0x0000000182DA06B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182DA0310-0x0000000182DA0390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D9FBC0-0x0000000182D9FC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182DA0CC0-0x0000000182DA0DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182DA0AF0-0x0000000182DA0B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182DA06B0-0x0000000182DA07A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182DA0C70-0x0000000182DA0CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182DA0430-0x0000000182DA0520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182DA0270-0x0000000182DA0310 0x0000000182D9FEB0-0x0000000182D9FF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NpcFirstMetId { get => default; set {} } // 0x0000000182D9FE10-0x0000000182D9FEB0 0x0000000182DA0A50-0x0000000182DA0AF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24220
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24221
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 508
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MeetNpcRsp() {} // 0x0000000182DA1070-0x0000000182DA10D0
	static MeetNpcRsp() {} // 0x0000000182DA0FB0-0x0000000182DA1070

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MeetNpcRsp Clone() => default; // 0x0000000182DA07A0-0x0000000182DA0890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MeetNpcRsp ShallowCopy() => default; // 0x0000000182DA0390-0x0000000182DA0430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D9FD50-0x0000000182D9FDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DA09B0-0x0000000182DA0A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DA0A00-0x0000000182DA0A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D9FDA0-0x0000000182D9FE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D9FF50-0x0000000182DA0020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MeetNpcRsp other) => default; // 0x0000000182DA0020-0x0000000182DA0140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182DA0520-0x0000000182DA0620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182DA0DB0-0x0000000182DA0FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182DA0B50-0x0000000182DA0C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182DA0140-0x0000000182DA0270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MeetNpcRsp other) {} // 0x0000000182D9FC20-0x0000000182D9FD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D9FAC0-0x0000000182D9FBC0
}

