/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarExpeditionStartReq : MessageBase, IMessage<AvatarExpeditionStartReq> // TypeDefIndex: 22462
{
	// Fields
	private static readonly MessageParser<AvatarExpeditionStartReq> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B01A0B
	private ulong avatarGuid_; // 0x18
	public const int ExpIdFieldNumber = 2; // Metadata: 0x00B01A0F
	private uint expId_; // 0x20
	public const int HourTimeFieldNumber = 3; // Metadata: 0x00B01A13
	private uint hourTime_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarExpeditionStartReq> Parser { get => default; } // 0x0000000183366F20-0x0000000183366FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183366B70-0x0000000183366C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183366820-0x00000001833668A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183365F80-0x0000000183365FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833672F0-0x00000001833673E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833670E0-0x0000000183367140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183366D40-0x0000000183366E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833672A0-0x00000001833672F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183366940-0x0000000183366A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000183366C00-0x0000000183366CA0 0x0000000183366280-0x0000000183366320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpId { get => default; set {} } // 0x00000001833663F0-0x0000000183366490 0x0000000183366080-0x0000000183366120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HourTime { get => default; set {} } // 0x0000000183366CA0-0x0000000183366D40 0x0000000183365FE0-0x0000000183366080

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22463
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22464
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1727
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionStartReq() {} // 0x0000000183367730-0x0000000183367790
	static AvatarExpeditionStartReq() {} // 0x0000000183367670-0x0000000183367730

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionStartReq Clone() => default; // 0x0000000183366E30-0x0000000183366F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionStartReq ShallowCopy() => default; // 0x00000001833668A0-0x0000000183366940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183366320-0x0000000183366370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183367040-0x0000000183367090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183367090-0x00000001833670E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183366370-0x00000001833663F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833665D0-0x00000001833666A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarExpeditionStartReq other) => default; // 0x0000000183366490-0x00000001833665D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183366A30-0x0000000183366B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833673E0-0x0000000183367670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183367140-0x00000001833672A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833666A0-0x0000000183366820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarExpeditionStartReq other) {} // 0x0000000183366120-0x0000000183366280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183365E70-0x0000000183365F80
}

