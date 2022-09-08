/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeBattlePassRewardReq : MessageBase, IMessage<TakeBattlePassRewardReq> // TypeDefIndex: 22558
{
	// Fields
	private static readonly MessageParser<TakeBattlePassRewardReq> _parser; // 0x00
	public const int TakeOptionListFieldNumber = 1; // Metadata: 0x00B01DDB
	private static readonly FieldCodec<BattlePassRewardTakeOption> _repeated_takeOptionList_codec; // 0x08
	private readonly RepeatedMessageField<BattlePassRewardTakeOption> takeOptionList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeBattlePassRewardReq> Parser { get => default; } // 0x00000001851DEA80-0x00000001851DEB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001851DE810-0x00000001851DE8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001851DE540-0x00000001851DE5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001851DDF60-0x00000001851DDFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001851DEE70-0x00000001851DEF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001851DECC0-0x00000001851DED20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001851DE8A0-0x00000001851DE990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001851DEE20-0x00000001851DEE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001851DE660-0x00000001851DE750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BattlePassRewardTakeOption> TakeOptionList { get => default; } // 0x00000001851DE4E0-0x00000001851DE540 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22559
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22560
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2605
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassRewardReq() {} // 0x00000001851DF1C0-0x00000001851DF250
	static TakeBattlePassRewardReq() {} // 0x00000001851DF0B0-0x00000001851DF1C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassRewardReq Clone() => default; // 0x00000001851DE990-0x00000001851DEA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassRewardReq ShallowCopy() => default; // 0x00000001851DE5C0-0x00000001851DE660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001851DE0F0-0x00000001851DE140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851DEBA0-0x00000001851DEC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851DEC30-0x00000001851DECC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001851DE140-0x00000001851DE210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001851DE210-0x00000001851DE2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeBattlePassRewardReq other) => default; // 0x00000001851DE2E0-0x00000001851DE3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001851DE750-0x00000001851DE810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001851DEF60-0x00000001851DF0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001851DED20-0x00000001851DEE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001851DE3F0-0x00000001851DE4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeBattlePassRewardReq other) {} // 0x00000001851DDFC0-0x00000001851DE0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001851DDE30-0x00000001851DDF60
}

