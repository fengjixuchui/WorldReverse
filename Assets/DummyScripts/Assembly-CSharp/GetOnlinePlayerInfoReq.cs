/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetOnlinePlayerInfoReq : MessageBase, IMessage<GetOnlinePlayerInfoReq> // TypeDefIndex: 23996
{
	// Fields
	private static readonly MessageParser<GetOnlinePlayerInfoReq> _parser; // 0x00
	public const int IsOnlineIdFieldNumber = 1; // Metadata: 0x00B054EF
	private bool isOnlineId_; // 0x18
	public const int TargetUidFieldNumber = 2; // Metadata: 0x00B054F3
	public const int OnlineIdFieldNumber = 3; // Metadata: 0x00B054F7
	public const int PsnIdFieldNumber = 4; // Metadata: 0x00B054FB
	private object playerId_; // 0x20
	private PlayerIdOneofCase playerIdCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetOnlinePlayerInfoReq> Parser { get => default; } // 0x00000001817018B0-0x0000000181701940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181701420-0x00000001817014B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181700F00-0x0000000181700F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181700540-0x00000001817005A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181701D70-0x0000000181701E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181701B30-0x0000000181701B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181701610-0x0000000181701700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181701D20-0x0000000181701D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181701020-0x0000000181701110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOnlineId { get => default; set {} } // 0x00000001817007F0-0x0000000181700890 0x0000000181701570-0x0000000181701610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000181701280-0x0000000181701350 0x0000000181700E50-0x0000000181700F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x0000000181701350-0x0000000181701420 0x00000001817017F0-0x00000001817018B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PsnId { get => default; set {} } // 0x0000000181700D80-0x0000000181700E50 0x0000000181701A20-0x0000000181701AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerIdOneofCase PlayerIdCase { get => default; } // 0x0000000181701510-0x0000000181701570 

	// Nested types
	public enum PlayerIdOneofCase // TypeDefIndex: 23997
	{
		None = 0,
		TargetUid = 2,
		OnlineId = 3,
		PsnId = 4
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23998
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23999
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 17
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOnlinePlayerInfoReq() {} // 0x0000000181702260-0x00000001817022D0
	static GetOnlinePlayerInfoReq() {} // 0x00000001817021A0-0x0000000181702260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOnlinePlayerInfoReq Clone() => default; // 0x0000000181701700-0x00000001817017F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOnlinePlayerInfoReq ShallowCopy() => default; // 0x0000000181700F80-0x0000000181701020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181700890-0x00000001817008E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817019D0-0x0000000181701A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181701AE0-0x0000000181701B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001817008E0-0x0000000181700950
	public void resetPlayerId() {} // 0x00000001817005A0-0x0000000181700630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearPlayerId() {} // 0x00000001817014B0-0x0000000181701510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181700B30-0x0000000181700C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetOnlinePlayerInfoReq other) => default; // 0x0000000181700950-0x0000000181700B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181701110-0x0000000181701280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181701E60-0x00000001817021A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181701B90-0x0000000181701D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181700C00-0x0000000181700D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetOnlinePlayerInfoReq other) {} // 0x0000000181700630-0x00000001817007F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181700410-0x0000000181700540
}

