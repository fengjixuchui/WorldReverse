/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeReunionWatcherRewardRsp : MessageBase, IMessage<TakeReunionWatcherRewardRsp> // TypeDefIndex: 24840
{
	// Fields
	private static readonly MessageParser<TakeReunionWatcherRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B075BF
	private int retcode_; // 0x18
	public const int MissionIdFieldNumber = 2; // Metadata: 0x00B075C3
	private uint missionId_; // 0x1C
	public const int WatcherIdFieldNumber = 3; // Metadata: 0x00B075C7
	private uint watcherId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeReunionWatcherRewardRsp> Parser { get => default; } // 0x00000001837534E0-0x0000000183753570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183753090-0x0000000183753120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183752D50-0x0000000183752DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183752550-0x00000001837525B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837538B0-0x00000001837539A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837536A0-0x0000000183753700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183753300-0x00000001837533F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183753860-0x00000001837538B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183752E70-0x0000000183752F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183752CB0-0x0000000183752D50 0x0000000183752880-0x0000000183752920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MissionId { get => default; set {} } // 0x00000001837525B0-0x0000000183752650 0x0000000183753260-0x0000000183753300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WatcherId { get => default; set {} } // 0x00000001837531C0-0x0000000183753260 0x0000000183753120-0x00000001837531C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24841
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24842
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5062
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionWatcherRewardRsp() {} // 0x0000000183753CF0-0x0000000183753D50
	static TakeReunionWatcherRewardRsp() {} // 0x0000000183753C30-0x0000000183753CF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionWatcherRewardRsp Clone() => default; // 0x00000001837533F0-0x00000001837534E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionWatcherRewardRsp ShallowCopy() => default; // 0x0000000183752DD0-0x0000000183752E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837527B0-0x0000000183752800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183753600-0x0000000183753650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183753650-0x00000001837536A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183752800-0x0000000183752880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183752920-0x00000001837529F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeReunionWatcherRewardRsp other) => default; // 0x00000001837529F0-0x0000000183752B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183752F60-0x0000000183753090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837539A0-0x0000000183753C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183753700-0x0000000183753860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183752B30-0x0000000183752CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeReunionWatcherRewardRsp other) {} // 0x0000000183752650-0x00000001837527B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183752440-0x0000000183752550
}

