/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetPlayerSocialDetailReq : MessageBase, IMessage<GetPlayerSocialDetailReq> // TypeDefIndex: 25552
{
	// Fields
	private static readonly MessageParser<GetPlayerSocialDetailReq> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B090FB
	private uint uid_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetPlayerSocialDetailReq> Parser { get => default; } // 0x00000001839BC340-0x00000001839BC3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001839BC030-0x00000001839BC0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001839BBD40-0x00000001839BBDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001839BB7B0-0x00000001839BB810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001839BC690-0x00000001839BC780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001839BC500-0x00000001839BC560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001839BC160-0x00000001839BC250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001839BC640-0x00000001839BC690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001839BBE60-0x00000001839BBF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001839BBCA0-0x00000001839BBD40 0x00000001839BC0C0-0x00000001839BC160

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25553
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25554
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4009
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerSocialDetailReq() {} // 0x00000001839BC9B0-0x00000001839BCA10
	static GetPlayerSocialDetailReq() {} // 0x00000001839BC8F0-0x00000001839BC9B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerSocialDetailReq Clone() => default; // 0x00000001839BC250-0x00000001839BC340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerSocialDetailReq ShallowCopy() => default; // 0x00000001839BBDC0-0x00000001839BBE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001839BB920-0x00000001839BB970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839BC460-0x00000001839BC4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839BC4B0-0x00000001839BC500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001839BB970-0x00000001839BB9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001839BBAE0-0x00000001839BBBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetPlayerSocialDetailReq other) => default; // 0x00000001839BB9E0-0x00000001839BBAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001839BBF50-0x00000001839BC030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001839BC780-0x00000001839BC8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001839BC560-0x00000001839BC640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001839BBBB0-0x00000001839BBCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetPlayerSocialDetailReq other) {} // 0x00000001839BB810-0x00000001839BB920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001839BB6D0-0x00000001839BB7B0
}

