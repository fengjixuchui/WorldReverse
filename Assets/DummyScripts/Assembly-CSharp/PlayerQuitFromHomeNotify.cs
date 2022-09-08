/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerQuitFromHomeNotify : MessageBase, IMessage<PlayerQuitFromHomeNotify> // TypeDefIndex: 23436
{
	// Fields
	private static readonly MessageParser<PlayerQuitFromHomeNotify> _parser; // 0x00
	public const int ReasonFieldNumber = 1; // Metadata: 0x00B04043
	private Types.QuitReason reason_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerQuitFromHomeNotify> Parser { get => default; } // 0x0000000180F1C0F0-0x0000000180F1C180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180F1BDE0-0x0000000180F1BE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180F1BAC0-0x0000000180F1BB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180F1B530-0x0000000180F1B590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180F1C440-0x0000000180F1C530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180F1C2B0-0x0000000180F1C310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180F1BE70-0x0000000180F1BF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180F1C3F0-0x0000000180F1C440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180F1BBE0-0x0000000180F1BCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.QuitReason Reason { get => default; set {} } // 0x0000000180F1C050-0x0000000180F1C0F0 0x0000000180F1B6F0-0x0000000180F1B790

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23437
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23438
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4498
		}

		public enum QuitReason // TypeDefIndex: 23439
		{
			Invalid = 0,
			KickByHost = 1,
			BackToMyWorld = 2,
			HomeBlocked = 3,
			HomeInEditMode = 4,
			ByMuip = 5,
			CurModuleClosed = 6
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitFromHomeNotify() {} // 0x0000000180F1C760-0x0000000180F1C7D0
	static PlayerQuitFromHomeNotify() {} // 0x0000000180F1C6A0-0x0000000180F1C760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitFromHomeNotify Clone() => default; // 0x0000000180F1BF60-0x0000000180F1C050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitFromHomeNotify ShallowCopy() => default; // 0x0000000180F1BB40-0x0000000180F1BBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180F1B6A0-0x0000000180F1B6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180F1C210-0x0000000180F1C260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180F1C260-0x0000000180F1C2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180F1B790-0x0000000180F1B800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180F1B900-0x0000000180F1B9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerQuitFromHomeNotify other) => default; // 0x0000000180F1B800-0x0000000180F1B900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180F1BCD0-0x0000000180F1BDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180F1C530-0x0000000180F1C6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180F1C310-0x0000000180F1C3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180F1B9D0-0x0000000180F1BAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerQuitFromHomeNotify other) {} // 0x0000000180F1B590-0x0000000180F1B6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180F1B450-0x0000000180F1B530
}

