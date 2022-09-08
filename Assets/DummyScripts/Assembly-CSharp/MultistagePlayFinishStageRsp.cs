/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MultistagePlayFinishStageRsp : MessageBase, IMessage<MultistagePlayFinishStageRsp> // TypeDefIndex: 24150
{
	// Fields
	private static readonly MessageParser<MultistagePlayFinishStageRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05B57
	private int retcode_; // 0x18
	public const int PlayIndexFieldNumber = 2; // Metadata: 0x00B05B5B
	private uint playIndex_; // 0x1C
	public const int GroupIdFieldNumber = 3; // Metadata: 0x00B05B5F
	private uint groupId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MultistagePlayFinishStageRsp> Parser { get => default; } // 0x0000000184256930-0x00000001842569C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184256580-0x0000000184256610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184256240-0x00000001842562C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001842559A0-0x0000000184255A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184256D00-0x0000000184256DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184256AF0-0x0000000184256B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001842566B0-0x00000001842567A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184256CB0-0x0000000184256D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184256360-0x0000000184256450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184256060-0x0000000184256100 0x0000000184255C30-0x0000000184255CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x0000000184256100-0x00000001842561A0 0x0000000184256610-0x00000001842566B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x00000001842567A0-0x0000000184256840 0x00000001842561A0-0x0000000184256240

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24151
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24152
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5315
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayFinishStageRsp() {} // 0x0000000184257140-0x00000001842571A0
	static MultistagePlayFinishStageRsp() {} // 0x0000000184257080-0x0000000184257140

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayFinishStageRsp Clone() => default; // 0x0000000184256840-0x0000000184256930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayFinishStageRsp ShallowCopy() => default; // 0x00000001842562C0-0x0000000184256360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184255B60-0x0000000184255BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184256A50-0x0000000184256AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184256AA0-0x0000000184256AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184255BB0-0x0000000184255C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184255E10-0x0000000184255EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MultistagePlayFinishStageRsp other) => default; // 0x0000000184255CD0-0x0000000184255E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184256450-0x0000000184256580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184256DF0-0x0000000184257080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184256B50-0x0000000184256CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184255EE0-0x0000000184256060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MultistagePlayFinishStageRsp other) {} // 0x0000000184255A00-0x0000000184255B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184255890-0x00000001842559A0
}

