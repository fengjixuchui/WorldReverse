/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NormalUidOpNotify : MessageBase, IMessage<NormalUidOpNotify> // TypeDefIndex: 24743
{
	// Fields
	private static readonly MessageParser<NormalUidOpNotify> _parser; // 0x00
	public const int ParamIndexFieldNumber = 1; // Metadata: 0x00B0720B
	private uint paramIndex_; // 0x18
	public const int ParamListFieldNumber = 2; // Metadata: 0x00B0720F
	private static readonly FieldCodec<uint> _repeated_paramList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> paramList_; // 0x20
	public const int ParamUidListFieldNumber = 3; // Metadata: 0x00B07213
	private static readonly FieldCodec<uint> _repeated_paramUidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> paramUidList_; // 0x28
	public const int DurationFieldNumber = 4; // Metadata: 0x00B07217
	private uint duration_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<NormalUidOpNotify> Parser { get => default; } // 0x00000001822199A0-0x0000000182219A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182219730-0x00000001822197C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001822193D0-0x0000000182219450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182218BC0-0x0000000182218C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182219EC0-0x0000000182219FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182219B60-0x0000000182219BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001822197C0-0x00000001822198B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182219E70-0x0000000182219EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822194F0-0x00000001822195E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParamIndex { get => default; set {} } // 0x0000000182219BC0-0x0000000182219C60 0x0000000182218B20-0x0000000182218BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamList { get => default; } // 0x0000000182219C60-0x0000000182219CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamUidList { get => default; } // 0x0000000182219FB0-0x000000018221A010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Duration { get => default; set {} } // 0x000000018221A010-0x000000018221A0B0 0x0000000182218C20-0x0000000182218CC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24744
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24745
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5701
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NormalUidOpNotify() {} // 0x000000018221A490-0x000000018221A540
	static NormalUidOpNotify() {} // 0x000000018221A390-0x000000018221A490

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NormalUidOpNotify Clone() => default; // 0x00000001822198B0-0x00000001822199A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NormalUidOpNotify ShallowCopy() => default; // 0x0000000182219450-0x00000001822194F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182218E40-0x0000000182218E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182219AC0-0x0000000182219B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182219B10-0x0000000182219B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182218E90-0x0000000182218FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182219140-0x0000000182219210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(NormalUidOpNotify other) => default; // 0x0000000182218FD0-0x0000000182219140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822195E0-0x0000000182219730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018221A0B0-0x000000018221A390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182219CC0-0x0000000182219E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182219210-0x00000001822193D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(NormalUidOpNotify other) {} // 0x0000000182218CC0-0x0000000182218E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182218930-0x0000000182218B20
}

