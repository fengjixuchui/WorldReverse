/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExpeditionRecallRsp : MessageBase, IMessage<ExpeditionRecallRsp> // TypeDefIndex: 22176
{
	// Fields
	private static readonly MessageParser<ExpeditionRecallRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00FA3
	private int retcode_; // 0x18
	public const int PathIdFieldNumber = 2; // Metadata: 0x00B00FA7
	private uint pathId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExpeditionRecallRsp> Parser { get => default; } // 0x0000000181FE8300-0x0000000181FE8390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181FE8090-0x0000000181FE8120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181FE7D80-0x0000000181FE7E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181FE7630-0x0000000181FE7690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181FE8690-0x0000000181FE8780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181FE84C0-0x0000000181FE8520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181FE8120-0x0000000181FE8210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181FE8640-0x0000000181FE8690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181FE7EA0-0x0000000181FE7F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181FE7CE0-0x0000000181FE7D80 0x0000000181FE7920-0x0000000181FE79C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PathId { get => default; set {} } // 0x0000000181FE7880-0x0000000181FE7920 0x0000000181FE7590-0x0000000181FE7630

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22177
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22178
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2164
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionRecallRsp() {} // 0x0000000181FE8A40-0x0000000181FE8AA0
	static ExpeditionRecallRsp() {} // 0x0000000181FE8980-0x0000000181FE8A40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionRecallRsp Clone() => default; // 0x0000000181FE8210-0x0000000181FE8300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionRecallRsp ShallowCopy() => default; // 0x0000000181FE7E00-0x0000000181FE7EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181FE77C0-0x0000000181FE7810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FE8420-0x0000000181FE8470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FE8470-0x0000000181FE84C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181FE7810-0x0000000181FE7880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181FE79C0-0x0000000181FE7A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExpeditionRecallRsp other) => default; // 0x0000000181FE7A90-0x0000000181FE7BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181FE7F90-0x0000000181FE8090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181FE8780-0x0000000181FE8980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181FE8520-0x0000000181FE8640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181FE7BB0-0x0000000181FE7CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExpeditionRecallRsp other) {} // 0x0000000181FE7690-0x0000000181FE77C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181FE7490-0x0000000181FE7590
}

