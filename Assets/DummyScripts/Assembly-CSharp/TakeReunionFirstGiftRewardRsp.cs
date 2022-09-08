/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeReunionFirstGiftRewardRsp : MessageBase, IMessage<TakeReunionFirstGiftRewardRsp> // TypeDefIndex: 24816
{
	// Fields
	private static readonly MessageParser<TakeReunionFirstGiftRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B074F7
	private int retcode_; // 0x18
	public const int RewardIdFieldNumber = 2; // Metadata: 0x00B074FB
	private int rewardId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeReunionFirstGiftRewardRsp> Parser { get => default; } // 0x000000018491A650-0x000000018491A6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018491A340-0x000000018491A3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018491A030-0x000000018491A0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184919980-0x00000001849199E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018491AA80-0x000000018491AB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018491A8B0-0x000000018491A910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018491A3D0-0x000000018491A4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018491AA30-0x000000018491AA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018491A150-0x000000018491A240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184919F90-0x000000018491A030 0x0000000184919BD0-0x0000000184919C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int RewardId { get => default; set {} } // 0x000000018491A810-0x000000018491A8B0 0x000000018491A5B0-0x000000018491A650

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24817
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24818
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5054
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionFirstGiftRewardRsp() {} // 0x000000018491AE30-0x000000018491AE90
	static TakeReunionFirstGiftRewardRsp() {} // 0x000000018491AD70-0x000000018491AE30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionFirstGiftRewardRsp Clone() => default; // 0x000000018491A4C0-0x000000018491A5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionFirstGiftRewardRsp ShallowCopy() => default; // 0x000000018491A0B0-0x000000018491A150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184919B10-0x0000000184919B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018491A770-0x000000018491A7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018491A7C0-0x000000018491A810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184919B60-0x0000000184919BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184919C70-0x0000000184919D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeReunionFirstGiftRewardRsp other) => default; // 0x0000000184919D40-0x0000000184919E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018491A240-0x000000018491A340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018491AB70-0x000000018491AD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018491A910-0x000000018491AA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184919E60-0x0000000184919F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeReunionFirstGiftRewardRsp other) {} // 0x00000001849199E0-0x0000000184919B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184919880-0x0000000184919980
}

