/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerMatchStopNotify : MessageBase, IMessage<PlayerMatchStopNotify> // TypeDefIndex: 23840
{
	// Fields
	private static readonly MessageParser<PlayerMatchStopNotify> _parser; // 0x00
	public const int HostUidFieldNumber = 1; // Metadata: 0x00B04F3B
	private uint hostUid_; // 0x18
	public const int ReasonFieldNumber = 2; // Metadata: 0x00B04F3F
	private MatchReason reason_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerMatchStopNotify> Parser { get => default; } // 0x000000018376EF10-0x000000018376EFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018376EB60-0x000000018376EBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018376E800-0x000000018376E880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018376E150-0x000000018376E1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018376F2A0-0x000000018376F390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018376F0D0-0x000000018376F130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018376EBF0-0x000000018376ECE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018376F250-0x000000018376F2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018376E920-0x000000018376EA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HostUid { get => default; set {} } // 0x000000018376E1B0-0x000000018376E250 0x000000018376EDD0-0x000000018376EE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchReason Reason { get => default; set {} } // 0x000000018376EE70-0x000000018376EF10 0x000000018376E3D0-0x000000018376E470

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23841
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23842
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4156
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchStopNotify() {} // 0x000000018376F650-0x000000018376F6C0
	static PlayerMatchStopNotify() {} // 0x000000018376F590-0x000000018376F650

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchStopNotify Clone() => default; // 0x000000018376ECE0-0x000000018376EDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchStopNotify ShallowCopy() => default; // 0x000000018376E880-0x000000018376E920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018376E380-0x000000018376E3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018376F030-0x000000018376F080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018376F080-0x000000018376F0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018376E470-0x000000018376E4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018376E600-0x000000018376E6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerMatchStopNotify other) => default; // 0x000000018376E4E0-0x000000018376E600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018376EA10-0x000000018376EB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018376F390-0x000000018376F590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018376F130-0x000000018376F250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018376E6D0-0x000000018376E800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerMatchStopNotify other) {} // 0x000000018376E250-0x000000018376E380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018376E060-0x000000018376E150
}

