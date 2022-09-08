/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayGuestReplyNotify : MessageBase, IMessage<ScenePlayGuestReplyNotify> // TypeDefIndex: 25390
{
	// Fields
	private static readonly MessageParser<ScenePlayGuestReplyNotify> _parser; // 0x00
	public const int PlayIdFieldNumber = 1; // Metadata: 0x00B08A0B
	private uint playId_; // 0x18
	public const int GuestUidFieldNumber = 2; // Metadata: 0x00B08A0F
	private uint guestUid_; // 0x1C
	public const int IsAgreeFieldNumber = 3; // Metadata: 0x00B08A13
	private bool isAgree_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayGuestReplyNotify> Parser { get => default; } // 0x0000000183257130-0x00000001832571C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183256E20-0x0000000183256EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832569A0-0x0000000183256A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183256310-0x0000000183256370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183257640-0x0000000183257730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183257390-0x00000001832573F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183256EB0-0x0000000183256FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001832575F0-0x0000000183257640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183256AC0-0x0000000183256BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x0000000183256900-0x00000001832569A0 0x0000000183256D80-0x0000000183256E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GuestUid { get => default; set {} } // 0x0000000183256CE0-0x0000000183256D80 0x0000000183257550-0x00000001832575F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x0000000183257090-0x0000000183257130 0x00000001832571C0-0x0000000183257260

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25391
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25392
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4359
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayGuestReplyNotify() {} // 0x0000000183257A80-0x0000000183257AE0
	static ScenePlayGuestReplyNotify() {} // 0x00000001832579C0-0x0000000183257A80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayGuestReplyNotify Clone() => default; // 0x0000000183256FA0-0x0000000183257090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayGuestReplyNotify ShallowCopy() => default; // 0x0000000183256A20-0x0000000183256AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832564D0-0x0000000183256520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832572F0-0x0000000183257340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183257340-0x0000000183257390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183256520-0x00000001832565A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001832565A0-0x0000000183256670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayGuestReplyNotify other) => default; // 0x0000000183256670-0x00000001832567B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183256BB0-0x0000000183256CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183257730-0x00000001832579C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832573F0-0x0000000183257550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832567B0-0x0000000183256900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayGuestReplyNotify other) {} // 0x0000000183256370-0x00000001832564D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183256200-0x0000000183256310
}

