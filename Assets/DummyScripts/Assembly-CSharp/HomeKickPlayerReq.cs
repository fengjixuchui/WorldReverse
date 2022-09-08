/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeKickPlayerReq : MessageBase, IMessage<HomeKickPlayerReq> // TypeDefIndex: 23400
{
	// Fields
	private static readonly MessageParser<HomeKickPlayerReq> _parser; // 0x00
	public const int IsKickAllFieldNumber = 1; // Metadata: 0x00B03F0B
	private bool isKickAll_; // 0x18
	public const int TargetUidFieldNumber = 2; // Metadata: 0x00B03F0F
	private uint targetUid_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeKickPlayerReq> Parser { get => default; } // 0x0000000182D7CF90-0x0000000182D7D020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D7CD20-0x0000000182D7CDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D7C960-0x0000000182D7C9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D7C2E0-0x0000000182D7C340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D7D3C0-0x0000000182D7D4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D7D1F0-0x0000000182D7D250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D7CDB0-0x0000000182D7CEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D7D370-0x0000000182D7D3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D7CA80-0x0000000182D7CB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsKickAll { get => default; set {} } // 0x0000000182D7D150-0x0000000182D7D1F0 0x0000000182D7C720-0x0000000182D7C7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000182D7CC80-0x0000000182D7CD20 0x0000000182D7C8C0-0x0000000182D7C960

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23401
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23402
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4487
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeKickPlayerReq() {} // 0x0000000182D7D770-0x0000000182D7D7D0
	static HomeKickPlayerReq() {} // 0x0000000182D7D6B0-0x0000000182D7D770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeKickPlayerReq Clone() => default; // 0x0000000182D7CEA0-0x0000000182D7CF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeKickPlayerReq ShallowCopy() => default; // 0x0000000182D7C9E0-0x0000000182D7CA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D7C470-0x0000000182D7C4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D7D0B0-0x0000000182D7D100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D7D100-0x0000000182D7D150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D7C4C0-0x0000000182D7C530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D7C650-0x0000000182D7C720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeKickPlayerReq other) => default; // 0x0000000182D7C530-0x0000000182D7C650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D7CB70-0x0000000182D7CC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D7D4B0-0x0000000182D7D6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D7D250-0x0000000182D7D370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D7C7C0-0x0000000182D7C8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeKickPlayerReq other) {} // 0x0000000182D7C340-0x0000000182D7C470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D7C1E0-0x0000000182D7C2E0
}

