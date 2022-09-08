/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SelectAsterMidDifficultyRsp : MessageBase, IMessage<SelectAsterMidDifficultyRsp> // TypeDefIndex: 22007
{
	// Fields
	private static readonly MessageParser<SelectAsterMidDifficultyRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0090B
	private int retcode_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B0090F
	private uint scheduleId_; // 0x1C
	public const int GadgetEntityIdFieldNumber = 3; // Metadata: 0x00B00913
	private uint gadgetEntityId_; // 0x20
	public const int DifficultyIdFieldNumber = 4; // Metadata: 0x00B00917
	private uint difficultyId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SelectAsterMidDifficultyRsp> Parser { get => default; } // 0x00000001823BEB40-0x00000001823BEBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823BE830-0x00000001823BE8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823BE4C0-0x00000001823BE540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823BDAF0-0x00000001823BDB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823BF090-0x00000001823BF180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823BED00-0x00000001823BED60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823BE960-0x00000001823BEA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823BF040-0x00000001823BF090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823BE5E0-0x00000001823BE6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001823BE420-0x00000001823BE4C0 0x00000001823BDF90-0x00000001823BE030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001823BDEF0-0x00000001823BDF90 0x00000001823BED60-0x00000001823BEE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x00000001823BEE00-0x00000001823BEEA0 0x00000001823BDB50-0x00000001823BDBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyId { get => default; set {} } // 0x00000001823BDBF0-0x00000001823BDC90 0x00000001823BE8C0-0x00000001823BE960

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22008
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22009
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2062
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectAsterMidDifficultyRsp() {} // 0x00000001823BF560-0x00000001823BF5C0
	static SelectAsterMidDifficultyRsp() {} // 0x00000001823BF4A0-0x00000001823BF560

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectAsterMidDifficultyRsp Clone() => default; // 0x00000001823BEA50-0x00000001823BEB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectAsterMidDifficultyRsp ShallowCopy() => default; // 0x00000001823BE540-0x00000001823BE5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823BDE10-0x00000001823BDE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823BEC60-0x00000001823BECB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823BECB0-0x00000001823BED00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823BDE60-0x00000001823BDEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823BE030-0x00000001823BE100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SelectAsterMidDifficultyRsp other) => default; // 0x00000001823BE100-0x00000001823BE250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823BE6D0-0x00000001823BE830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823BF180-0x00000001823BF4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823BEEA0-0x00000001823BF040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823BE250-0x00000001823BE420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SelectAsterMidDifficultyRsp other) {} // 0x00000001823BDC90-0x00000001823BDE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823BD9C0-0x00000001823BDAF0
}

