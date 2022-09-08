/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakePlayerLevelRewardReq : MessageBase, IMessage<TakePlayerLevelRewardReq> // TypeDefIndex: 24458
{
	// Fields
	private static readonly MessageParser<TakePlayerLevelRewardReq> _parser; // 0x00
	public const int LevelFieldNumber = 1; // Metadata: 0x00B067AF
	private uint level_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakePlayerLevelRewardReq> Parser { get => default; } // 0x0000000182ACBF50-0x0000000182ACBFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182ACBCE0-0x0000000182ACBD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182ACB950-0x0000000182ACB9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182ACB3C0-0x0000000182ACB420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182ACC2A0-0x0000000182ACC390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182ACC110-0x0000000182ACC170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182ACBD70-0x0000000182ACBE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182ACC250-0x0000000182ACC2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182ACBB10-0x0000000182ACBC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000182ACB530-0x0000000182ACB5D0 0x0000000182ACBA70-0x0000000182ACBB10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24459
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24460
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 152
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakePlayerLevelRewardReq() {} // 0x0000000182ACC5C0-0x0000000182ACC620
	static TakePlayerLevelRewardReq() {} // 0x0000000182ACC500-0x0000000182ACC5C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakePlayerLevelRewardReq Clone() => default; // 0x0000000182ACBE60-0x0000000182ACBF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakePlayerLevelRewardReq ShallowCopy() => default; // 0x0000000182ACB9D0-0x0000000182ACBA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182ACB5D0-0x0000000182ACB620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182ACC070-0x0000000182ACC0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182ACC0C0-0x0000000182ACC110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182ACB620-0x0000000182ACB690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182ACB690-0x0000000182ACB760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakePlayerLevelRewardReq other) => default; // 0x0000000182ACB760-0x0000000182ACB860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182ACBC00-0x0000000182ACBCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182ACC390-0x0000000182ACC500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182ACC170-0x0000000182ACC250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182ACB860-0x0000000182ACB950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakePlayerLevelRewardReq other) {} // 0x0000000182ACB420-0x0000000182ACB530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182ACB2E0-0x0000000182ACB3C0
}

