/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeAsterSpecialRewardReq : MessageBase, IMessage<TakeAsterSpecialRewardReq> // TypeDefIndex: 22022
{
	// Fields
	private static readonly MessageParser<TakeAsterSpecialRewardReq> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B0097F
	private uint scheduleId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeAsterSpecialRewardReq> Parser { get => default; } // 0x00000001837CA5D0-0x00000001837CA660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837CA360-0x00000001837CA3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001837CA070-0x00000001837CA0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001837C9AE0-0x00000001837C9B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837CA9C0-0x00000001837CAAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837CA790-0x00000001837CA7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837CA3F0-0x00000001837CA4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837CA970-0x00000001837CA9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837CA190-0x00000001837CA280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001837C9D10-0x00000001837C9DB0 0x00000001837CA7F0-0x00000001837CA890

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22023
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22024
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2067
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAsterSpecialRewardReq() {} // 0x00000001837CACE0-0x00000001837CAD40
	static TakeAsterSpecialRewardReq() {} // 0x00000001837CAC20-0x00000001837CACE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAsterSpecialRewardReq Clone() => default; // 0x00000001837CA4E0-0x00000001837CA5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAsterSpecialRewardReq ShallowCopy() => default; // 0x00000001837CA0F0-0x00000001837CA190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837C9C50-0x00000001837C9CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837CA6F0-0x00000001837CA740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837CA740-0x00000001837CA790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837C9CA0-0x00000001837C9D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837C9DB0-0x00000001837C9E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeAsterSpecialRewardReq other) => default; // 0x00000001837C9E80-0x00000001837C9F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837CA280-0x00000001837CA360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837CAAB0-0x00000001837CAC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837CA890-0x00000001837CA970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001837C9F80-0x00000001837CA070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeAsterSpecialRewardReq other) {} // 0x00000001837C9B40-0x00000001837C9C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837C9A00-0x00000001837C9AE0
}

