/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ForgeQueueDataNotify : MessageBase, IMessage<ForgeQueueDataNotify> // TypeDefIndex: 23703
{
	// Fields
	private static readonly MessageParser<ForgeQueueDataNotify> _parser; // 0x00
	public const int ForgeQueueMapFieldNumber = 1; // Metadata: 0x00B04A5F
	private static readonly MapField<uint, ForgeQueueData> _map_forgeQueueMap_codec; // 0x08
	private readonly MapField<uint, ForgeQueueData> forgeQueueMap_; // 0x18
	public const int RemovedForgeQueueListFieldNumber = 2; // Metadata: 0x00B04A63
	private static readonly FieldCodec<uint> _repeated_removedForgeQueueList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> removedForgeQueueList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ForgeQueueDataNotify> Parser { get => default; } // 0x000000018398B6D0-0x000000018398B760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018398B460-0x000000018398B4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018398B0D0-0x000000018398B150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018398A9E0-0x000000018398AA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018398BA70-0x000000018398BB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018398B890-0x000000018398B8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018398B4F0-0x000000018398B5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018398BA20-0x000000018398BA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018398B1F0-0x000000018398B2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, ForgeQueueData> ForgeQueueMap { get => default; } // 0x000000018398AA40-0x000000018398AAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RemovedForgeQueueList { get => default; } // 0x000000018398B400-0x000000018398B460 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23704
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23705
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 636
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueDataNotify() {} // 0x000000018398BEA0-0x000000018398BF50
	static ForgeQueueDataNotify() {} // 0x000000018398BD20-0x000000018398BEA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueDataNotify Clone() => default; // 0x000000018398B5E0-0x000000018398B6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueDataNotify ShallowCopy() => default; // 0x000000018398B150-0x000000018398B1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018398ABD0-0x000000018398AC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018398B7F0-0x000000018398B840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018398B840-0x000000018398B890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018398AC20-0x000000018398AD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018398AD30-0x000000018398AE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ForgeQueueDataNotify other) => default; // 0x000000018398AE00-0x000000018398AFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018398B2E0-0x000000018398B400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018398BB60-0x000000018398BD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018398B8F0-0x000000018398BA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018398AFB0-0x000000018398B0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ForgeQueueDataNotify other) {} // 0x000000018398AAA0-0x000000018398ABD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018398A830-0x000000018398A9E0
}

