/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetCurExpeditionChallengeIdReq : MessageBase, IMessage<SetCurExpeditionChallengeIdReq> // TypeDefIndex: 22192
{
	// Fields
	private static readonly MessageParser<SetCurExpeditionChallengeIdReq> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B0102B
	private uint id_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetCurExpeditionChallengeIdReq> Parser { get => default; } // 0x00000001823BCA80-0x00000001823BCB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823BC810-0x00000001823BC8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823BC520-0x00000001823BC5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823BBF90-0x00000001823BBFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823BCE70-0x00000001823BCF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823BCCE0-0x00000001823BCD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823BC8A0-0x00000001823BC990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823BCE20-0x00000001823BCE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823BC640-0x00000001823BC730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x00000001823BC480-0x00000001823BC520 0x00000001823BCB10-0x00000001823BCBB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22193
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22194
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2169
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetCurExpeditionChallengeIdReq() {} // 0x00000001823BD190-0x00000001823BD1F0
	static SetCurExpeditionChallengeIdReq() {} // 0x00000001823BD0D0-0x00000001823BD190

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetCurExpeditionChallengeIdReq Clone() => default; // 0x00000001823BC990-0x00000001823BCA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetCurExpeditionChallengeIdReq ShallowCopy() => default; // 0x00000001823BC5A0-0x00000001823BC640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823BC100-0x00000001823BC150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823BCC40-0x00000001823BCC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823BCC90-0x00000001823BCCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823BC150-0x00000001823BC1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823BC1C0-0x00000001823BC290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetCurExpeditionChallengeIdReq other) => default; // 0x00000001823BC290-0x00000001823BC390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823BC730-0x00000001823BC810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823BCF60-0x00000001823BD0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823BCD40-0x00000001823BCE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823BC390-0x00000001823BC480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetCurExpeditionChallengeIdReq other) {} // 0x00000001823BBFF0-0x00000001823BC100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823BBEB0-0x00000001823BBF90
}

