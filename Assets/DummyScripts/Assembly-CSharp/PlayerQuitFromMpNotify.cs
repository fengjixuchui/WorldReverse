/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerQuitFromMpNotify : MessageBase, IMessage<PlayerQuitFromMpNotify> // TypeDefIndex: 24040
{
	// Fields
	private static readonly MessageParser<PlayerQuitFromMpNotify> _parser; // 0x00
	public const int ReasonFieldNumber = 1; // Metadata: 0x00B056B7
	private Types.QuitReason reason_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerQuitFromMpNotify> Parser { get => default; } // 0x0000000183770360-0x00000001837703F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183770050-0x00000001837700E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018376FD30-0x000000018376FDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018376F7A0-0x000000018376F800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837706B0-0x00000001837707A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183770520-0x0000000183770580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837700E0-0x00000001837701D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183770660-0x00000001837706B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018376FE50-0x000000018376FF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.QuitReason Reason { get => default; set {} } // 0x00000001837702C0-0x0000000183770360 0x000000018376F960-0x000000018376FA00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24041
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24042
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1807
		}

		public enum QuitReason // TypeDefIndex: 24043
		{
			Invalid = 0,
			HostNoOtherPlayer = 1,
			KickByHost = 2,
			BackToMyWorld = 3,
			KickByHostLogout = 4,
			KickByHostBlock = 5,
			BeBlocked = 6,
			KickByHostEnterHome = 7,
			KickByPlay = 8
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitFromMpNotify() {} // 0x00000001837709D0-0x0000000183770A40
	static PlayerQuitFromMpNotify() {} // 0x0000000183770910-0x00000001837709D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitFromMpNotify Clone() => default; // 0x00000001837701D0-0x00000001837702C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitFromMpNotify ShallowCopy() => default; // 0x000000018376FDB0-0x000000018376FE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018376F910-0x000000018376F960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183770480-0x00000001837704D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837704D0-0x0000000183770520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018376FA00-0x000000018376FA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018376FA70-0x000000018376FB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerQuitFromMpNotify other) => default; // 0x000000018376FB40-0x000000018376FC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018376FF40-0x0000000183770050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837707A0-0x0000000183770910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183770580-0x0000000183770660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018376FC40-0x000000018376FD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerQuitFromMpNotify other) {} // 0x000000018376F800-0x000000018376F910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018376F6C0-0x000000018376F7A0
}

