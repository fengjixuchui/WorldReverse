/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RemoveBlacklistRsp : MessageBase, IMessage<RemoveBlacklistRsp> // TypeDefIndex: 25615
{
	// Fields
	private static readonly MessageParser<RemoveBlacklistRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B092F3
	private int retcode_; // 0x18
	public const int TargetUidFieldNumber = 2; // Metadata: 0x00B092F7
	private uint targetUid_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RemoveBlacklistRsp> Parser { get => default; } // 0x00000001832F7DA0-0x00000001832F7E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001832F7B30-0x00000001832F7BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832F7780-0x00000001832F7800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832F7030-0x00000001832F7090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001832F8130-0x00000001832F8220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001832F7F60-0x00000001832F7FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832F7BC0-0x00000001832F7CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001832F80E0-0x00000001832F8130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832F78A0-0x00000001832F7990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001832F76E0-0x00000001832F7780 0x00000001832F7280-0x00000001832F7320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x00000001832F7A90-0x00000001832F7B30 0x00000001832F7640-0x00000001832F76E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25616
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25617
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4030
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RemoveBlacklistRsp() {} // 0x00000001832F84E0-0x00000001832F8540
	static RemoveBlacklistRsp() {} // 0x00000001832F8420-0x00000001832F84E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RemoveBlacklistRsp Clone() => default; // 0x00000001832F7CB0-0x00000001832F7DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RemoveBlacklistRsp ShallowCopy() => default; // 0x00000001832F7800-0x00000001832F78A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832F71C0-0x00000001832F7210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832F7EC0-0x00000001832F7F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832F7F10-0x00000001832F7F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001832F7210-0x00000001832F7280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001832F7320-0x00000001832F73F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RemoveBlacklistRsp other) => default; // 0x00000001832F73F0-0x00000001832F7510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832F7990-0x00000001832F7A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832F8220-0x00000001832F8420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832F7FC0-0x00000001832F80E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832F7510-0x00000001832F7640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RemoveBlacklistRsp other) {} // 0x00000001832F7090-0x00000001832F71C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001832F6F30-0x00000001832F7030
}

