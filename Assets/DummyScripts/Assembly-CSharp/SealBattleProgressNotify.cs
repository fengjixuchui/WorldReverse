/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SealBattleProgressNotify : MessageBase, IMessage<SealBattleProgressNotify> // TypeDefIndex: 25094
{
	// Fields
	private static readonly MessageParser<SealBattleProgressNotify> _parser; // 0x00
	public const int SealEntityIdFieldNumber = 1; // Metadata: 0x00B07F83
	private uint sealEntityId_; // 0x18
	public const int ProgressFieldNumber = 2; // Metadata: 0x00B07F87
	private uint progress_; // 0x1C
	public const int MaxProgressFieldNumber = 3; // Metadata: 0x00B07F8B
	private uint maxProgress_; // 0x20
	public const int EndTimeFieldNumber = 4; // Metadata: 0x00B07F8F
	private uint endTime_; // 0x24
	public const int SealRadiusFieldNumber = 5; // Metadata: 0x00B07F93
	private uint sealRadius_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SealBattleProgressNotify> Parser { get => default; } // 0x00000001830EB6C0-0x00000001830EB750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001830EB1D0-0x00000001830EB260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001830EAD90-0x00000001830EAE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830EA500-0x00000001830EA560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830EBC50-0x00000001830EBD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830EB920-0x00000001830EB980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830EB300-0x00000001830EB3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830EBC00-0x00000001830EBC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001830EAF50-0x00000001830EB040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SealEntityId { get => default; set {} } // 0x00000001830EB620-0x00000001830EB6C0 0x00000001830EAC50-0x00000001830EACF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x00000001830EB260-0x00000001830EB300 0x00000001830EAEB0-0x00000001830EAF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxProgress { get => default; set {} } // 0x00000001830EBB60-0x00000001830EBC00 0x00000001830EB4E0-0x00000001830EB580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x00000001830EB580-0x00000001830EB620 0x00000001830EB880-0x00000001830EB920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SealRadius { get => default; set {} } // 0x00000001830EACF0-0x00000001830EAD90 0x00000001830EBD40-0x00000001830EBDE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25095
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25096
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 266
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleProgressNotify() {} // 0x00000001830EC240-0x00000001830EC2A0
	static SealBattleProgressNotify() {} // 0x00000001830EC180-0x00000001830EC240

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleProgressNotify Clone() => default; // 0x00000001830EB3F0-0x00000001830EB4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleProgressNotify ShallowCopy() => default; // 0x00000001830EAE10-0x00000001830EAEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001830EA710-0x00000001830EA760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830EB7E0-0x00000001830EB830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830EB830-0x00000001830EB880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830EA760-0x00000001830EA800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001830EA800-0x00000001830EA8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SealBattleProgressNotify other) => default; // 0x00000001830EA8D0-0x00000001830EAA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001830EB040-0x00000001830EB1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830EBDE0-0x00000001830EC180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830EB980-0x00000001830EBB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001830EAA40-0x00000001830EAC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SealBattleProgressNotify other) {} // 0x00000001830EA560-0x00000001830EA710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830EA3B0-0x00000001830EA500
}

