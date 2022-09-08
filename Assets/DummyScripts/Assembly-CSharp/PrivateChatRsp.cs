/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PrivateChatRsp : MessageBase, IMessage<PrivateChatRsp> // TypeDefIndex: 22619
{
	// Fields
	private static readonly MessageParser<PrivateChatRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02027
	private int retcode_; // 0x18
	public const int ChatForbiddenEndtimeFieldNumber = 2; // Metadata: 0x00B0202B
	private uint chatForbiddenEndtime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PrivateChatRsp> Parser { get => default; } // 0x0000000183FDC540-0x0000000183FDC5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FDC2D0-0x0000000183FDC360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FDBFC0-0x0000000183FDC040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FDB7D0-0x0000000183FDB830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FDC8D0-0x0000000183FDC9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FDC700-0x0000000183FDC760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FDC360-0x0000000183FDC450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FDC880-0x0000000183FDC8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FDC0E0-0x0000000183FDC1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183FDBF20-0x0000000183FDBFC0 0x0000000183FDBB60-0x0000000183FDBC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChatForbiddenEndtime { get => default; set {} } // 0x0000000183FDB8D0-0x0000000183FDB970 0x0000000183FDB830-0x0000000183FDB8D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22620
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22621
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4952
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatRsp() {} // 0x0000000183FDCC80-0x0000000183FDCCE0
	static PrivateChatRsp() {} // 0x0000000183FDCBC0-0x0000000183FDCC80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatRsp Clone() => default; // 0x0000000183FDC450-0x0000000183FDC540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PrivateChatRsp ShallowCopy() => default; // 0x0000000183FDC040-0x0000000183FDC0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FDBAA0-0x0000000183FDBAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FDC660-0x0000000183FDC6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FDC6B0-0x0000000183FDC700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FDBAF0-0x0000000183FDBB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FDBC00-0x0000000183FDBCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PrivateChatRsp other) => default; // 0x0000000183FDBCD0-0x0000000183FDBDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FDC1D0-0x0000000183FDC2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FDC9C0-0x0000000183FDCBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FDC760-0x0000000183FDC880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FDBDF0-0x0000000183FDBF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PrivateChatRsp other) {} // 0x0000000183FDB970-0x0000000183FDBAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FDB6D0-0x0000000183FDB7D0
}

