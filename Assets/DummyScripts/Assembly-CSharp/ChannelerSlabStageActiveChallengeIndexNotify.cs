/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannelerSlabStageActiveChallengeIndexNotify : MessageBase, IMessage<ChannelerSlabStageActiveChallengeIndexNotify> // TypeDefIndex: 22271
{
	// Fields
	private static readonly MessageParser<ChannelerSlabStageActiveChallengeIndexNotify> _parser; // 0x00
	public const int StageIdFieldNumber = 1; // Metadata: 0x00B0135B
	private uint stageId_; // 0x18
	public const int ChallengeIndexFieldNumber = 2; // Metadata: 0x00B0135F
	private uint challengeIndex_; // 0x1C
	public const int ActiveCampIndexFieldNumber = 3; // Metadata: 0x00B01363
	private uint activeCampIndex_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannelerSlabStageActiveChallengeIndexNotify> Parser { get => default; } // 0x000000018497BF90-0x000000018497C020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018497BC80-0x000000018497BD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018497B8A0-0x000000018497B920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018497B140-0x000000018497B1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018497C400-0x000000018497C4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018497C1F0-0x000000018497C250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018497BDB0-0x000000018497BEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018497C3B0-0x000000018497C400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018497B9C0-0x000000018497BAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StageId { get => default; set {} } // 0x000000018497C0B0-0x000000018497C150 0x000000018497BBE0-0x000000018497BC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeIndex { get => default; set {} } // 0x000000018497B3D0-0x000000018497B470 0x000000018497BD10-0x000000018497BDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActiveCampIndex { get => default; set {} } // 0x000000018497B800-0x000000018497B8A0 0x000000018497C4F0-0x000000018497C590

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22272
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22273
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8001
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabStageActiveChallengeIndexNotify() {} // 0x000000018497C8E0-0x000000018497C940
	static ChannelerSlabStageActiveChallengeIndexNotify() {} // 0x000000018497C820-0x000000018497C8E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabStageActiveChallengeIndexNotify Clone() => default; // 0x000000018497BEA0-0x000000018497BF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabStageActiveChallengeIndexNotify ShallowCopy() => default; // 0x000000018497B920-0x000000018497B9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018497B300-0x000000018497B350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018497C150-0x000000018497C1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018497C1A0-0x000000018497C1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018497B350-0x000000018497B3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018497B470-0x000000018497B540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannelerSlabStageActiveChallengeIndexNotify other) => default; // 0x000000018497B540-0x000000018497B680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018497BAB0-0x000000018497BBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018497C590-0x000000018497C820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018497C250-0x000000018497C3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018497B680-0x000000018497B800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannelerSlabStageActiveChallengeIndexNotify other) {} // 0x000000018497B1A0-0x000000018497B300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018497B030-0x000000018497B140
}

