/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SeaLampTakePhaseRewardReq : MessageBase, IMessage<SeaLampTakePhaseRewardReq> // TypeDefIndex: 21905
{
	// Fields
	private static readonly MessageParser<SeaLampTakePhaseRewardReq> _parser; // 0x00
	public const int ActivityIdFieldNumber = 2; // Metadata: 0x00B0050B
	private uint activityId_; // 0x18
	public const int PhaseIdFieldNumber = 1; // Metadata: 0x00B0050F
	private uint phaseId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SeaLampTakePhaseRewardReq> Parser { get => default; } // 0x00000001814E1AF0-0x00000001814E1B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001814E1880-0x00000001814E1910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001814E1570-0x00000001814E15F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001814E0EC0-0x00000001814E0F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001814E1F20-0x00000001814E2010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001814E1D50-0x00000001814E1DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001814E1910-0x00000001814E1A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001814E1ED0-0x00000001814E1F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001814E1690-0x00000001814E1780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x00000001814E1CB0-0x00000001814E1D50 0x00000001814E0F20-0x00000001814E0FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PhaseId { get => default; set {} } // 0x00000001814E0E20-0x00000001814E0EC0 0x00000001814E14D0-0x00000001814E1570

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21906
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21907
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2018
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampTakePhaseRewardReq() {} // 0x00000001814E22D0-0x00000001814E2330
	static SeaLampTakePhaseRewardReq() {} // 0x00000001814E2210-0x00000001814E22D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampTakePhaseRewardReq Clone() => default; // 0x00000001814E1A00-0x00000001814E1AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampTakePhaseRewardReq ShallowCopy() => default; // 0x00000001814E15F0-0x00000001814E1690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001814E10F0-0x00000001814E1140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814E1C10-0x00000001814E1C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814E1C60-0x00000001814E1CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001814E1140-0x00000001814E11B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001814E12D0-0x00000001814E13A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SeaLampTakePhaseRewardReq other) => default; // 0x00000001814E11B0-0x00000001814E12D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001814E1780-0x00000001814E1880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001814E2010-0x00000001814E2210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001814E1DB0-0x00000001814E1ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001814E13A0-0x00000001814E14D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SeaLampTakePhaseRewardReq other) {} // 0x00000001814E0FC0-0x00000001814E10F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001814E0D20-0x00000001814E0E20
}

