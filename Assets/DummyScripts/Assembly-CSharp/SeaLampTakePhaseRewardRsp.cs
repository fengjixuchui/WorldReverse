/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SeaLampTakePhaseRewardRsp : MessageBase, IMessage<SeaLampTakePhaseRewardRsp> // TypeDefIndex: 21908
{
	// Fields
	private static readonly MessageParser<SeaLampTakePhaseRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00527
	private int retcode_; // 0x18
	public const int PhaseIdFieldNumber = 2; // Metadata: 0x00B0052B
	private uint phaseId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SeaLampTakePhaseRewardRsp> Parser { get => default; } // 0x0000000184167550-0x00000001841675E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841672E0-0x0000000184167370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184166FD0-0x0000000184167050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184166880-0x00000001841668E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001841678E0-0x00000001841679D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184167710-0x0000000184167770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184167370-0x0000000184167460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184167890-0x00000001841678E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841670F0-0x00000001841671E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184166E90-0x0000000184166F30 0x0000000184166AD0-0x0000000184166B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PhaseId { get => default; set {} } // 0x00000001841667E0-0x0000000184166880 0x0000000184166F30-0x0000000184166FD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21909
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21910
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2019
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampTakePhaseRewardRsp() {} // 0x0000000184167C90-0x0000000184167CF0
	static SeaLampTakePhaseRewardRsp() {} // 0x0000000184167BD0-0x0000000184167C90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampTakePhaseRewardRsp Clone() => default; // 0x0000000184167460-0x0000000184167550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampTakePhaseRewardRsp ShallowCopy() => default; // 0x0000000184167050-0x00000001841670F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184166A10-0x0000000184166A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184167670-0x00000001841676C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841676C0-0x0000000184167710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184166A60-0x0000000184166AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184166C90-0x0000000184166D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SeaLampTakePhaseRewardRsp other) => default; // 0x0000000184166B70-0x0000000184166C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841671E0-0x00000001841672E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841679D0-0x0000000184167BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184167770-0x0000000184167890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184166D60-0x0000000184166E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SeaLampTakePhaseRewardRsp other) {} // 0x00000001841668E0-0x0000000184166A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841666E0-0x00000001841667E0
}

