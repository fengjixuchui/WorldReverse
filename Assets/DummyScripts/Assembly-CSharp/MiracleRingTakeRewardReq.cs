/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MiracleRingTakeRewardReq : MessageBase, IMessage<MiracleRingTakeRewardReq> // TypeDefIndex: 23929
{
	// Fields
	private static readonly MessageParser<MiracleRingTakeRewardReq> _parser; // 0x00
	public const int GadgetEntityIdFieldNumber = 1; // Metadata: 0x00B0527F
	private uint gadgetEntityId_; // 0x18
	public const int GadgetIdFieldNumber = 2; // Metadata: 0x00B05283
	private uint gadgetId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MiracleRingTakeRewardReq> Parser { get => default; } // 0x00000001844EA8A0-0x00000001844EA930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001844EA630-0x00000001844EA6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001844EA280-0x00000001844EA300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001844E9BD0-0x00000001844E9C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001844EACD0-0x00000001844EADC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001844EAA60-0x00000001844EAAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001844EA6C0-0x00000001844EA7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001844EAC80-0x00000001844EACD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001844EA3A0-0x00000001844EA490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x00000001844EAAC0-0x00000001844EAB60 0x00000001844E9C30-0x00000001844E9CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x00000001844EA1E0-0x00000001844EA280 0x00000001844EA590-0x00000001844EA630

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23930
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23931
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5204
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingTakeRewardReq() {} // 0x00000001844EB080-0x00000001844EB0E0
	static MiracleRingTakeRewardReq() {} // 0x00000001844EAFC0-0x00000001844EB080

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingTakeRewardReq Clone() => default; // 0x00000001844EA7B0-0x00000001844EA8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingTakeRewardReq ShallowCopy() => default; // 0x00000001844EA300-0x00000001844EA3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001844E9E00-0x00000001844E9E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001844EA9C0-0x00000001844EAA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001844EAA10-0x00000001844EAA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001844E9E50-0x00000001844E9EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001844E9FE0-0x00000001844EA0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MiracleRingTakeRewardReq other) => default; // 0x00000001844E9EC0-0x00000001844E9FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001844EA490-0x00000001844EA590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001844EADC0-0x00000001844EAFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001844EAB60-0x00000001844EAC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001844EA0B0-0x00000001844EA1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MiracleRingTakeRewardReq other) {} // 0x00000001844E9CD0-0x00000001844E9E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001844E9AD0-0x00000001844E9BD0
}

