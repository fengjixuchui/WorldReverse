/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SalesmanTakeSpecialRewardRsp : MessageBase, IMessage<SalesmanTakeSpecialRewardRsp> // TypeDefIndex: 21957
{
	// Fields
	private static readonly MessageParser<SalesmanTakeSpecialRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0071F
	private int retcode_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B00723
	private uint scheduleId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SalesmanTakeSpecialRewardRsp> Parser { get => default; } // 0x0000000183A88F90-0x0000000183A89020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A88D20-0x0000000183A88DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A88A10-0x0000000183A88A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A882C0-0x0000000183A88320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A893C0-0x0000000183A894B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A89150-0x0000000183A891B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A88DB0-0x0000000183A88EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A89370-0x0000000183A893C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A88B30-0x0000000183A88C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183A88970-0x0000000183A88A10 0x0000000183A885B0-0x0000000183A88650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000183A88510-0x0000000183A885B0 0x0000000183A891B0-0x0000000183A89250

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21958
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21959
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2037
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanTakeSpecialRewardRsp() {} // 0x0000000183A89770-0x0000000183A897D0
	static SalesmanTakeSpecialRewardRsp() {} // 0x0000000183A896B0-0x0000000183A89770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanTakeSpecialRewardRsp Clone() => default; // 0x0000000183A88EA0-0x0000000183A88F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanTakeSpecialRewardRsp ShallowCopy() => default; // 0x0000000183A88A90-0x0000000183A88B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A88450-0x0000000183A884A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A890B0-0x0000000183A89100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A89100-0x0000000183A89150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A884A0-0x0000000183A88510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A88770-0x0000000183A88840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SalesmanTakeSpecialRewardRsp other) => default; // 0x0000000183A88650-0x0000000183A88770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A88C20-0x0000000183A88D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A894B0-0x0000000183A896B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A89250-0x0000000183A89370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A88840-0x0000000183A88970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SalesmanTakeSpecialRewardRsp other) {} // 0x0000000183A88320-0x0000000183A88450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A881C0-0x0000000183A882C0
}

