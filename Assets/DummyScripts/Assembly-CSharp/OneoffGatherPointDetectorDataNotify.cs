/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OneoffGatherPointDetectorDataNotify : MessageBase, IMessage<OneoffGatherPointDetectorDataNotify> // TypeDefIndex: 25853
{
	// Fields
	private static readonly MessageParser<OneoffGatherPointDetectorDataNotify> _parser; // 0x00
	public const int OneoffGatherPointDetectorDataListFieldNumber = 1; // Metadata: 0x00B09B7F
	private static readonly FieldCodec<OneoffGatherPointDetectorData> _repeated_oneoffGatherPointDetectorDataList_codec; // 0x08
	private readonly RepeatedMessageField<OneoffGatherPointDetectorData> oneoffGatherPointDetectorDataList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OneoffGatherPointDetectorDataNotify> Parser { get => default; } // 0x00000001815D2790-0x00000001815D2820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815D2520-0x00000001815D25B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815D2250-0x00000001815D22D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001815D1CD0-0x00000001815D1D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001815D2B80-0x00000001815D2C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001815D29D0-0x00000001815D2A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001815D25B0-0x00000001815D26A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001815D2B30-0x00000001815D2B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001815D2370-0x00000001815D2460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<OneoffGatherPointDetectorData> OneoffGatherPointDetectorDataList { get => default; } // 0x00000001815D2C70-0x00000001815D2CD0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25854
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25855
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4266
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneoffGatherPointDetectorDataNotify() {} // 0x00000001815D2F30-0x00000001815D3090
	static OneoffGatherPointDetectorDataNotify() {} // 0x00000001815D2E20-0x00000001815D2F30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneoffGatherPointDetectorDataNotify Clone() => default; // 0x00000001815D26A0-0x00000001815D2790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneoffGatherPointDetectorDataNotify ShallowCopy() => default; // 0x00000001815D22D0-0x00000001815D2370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815D1E60-0x00000001815D1EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815D28B0-0x00000001815D2940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815D2940-0x00000001815D29D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001815D1EB0-0x00000001815D1F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001815D2090-0x00000001815D2160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OneoffGatherPointDetectorDataNotify other) => default; // 0x00000001815D1F80-0x00000001815D2090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001815D2460-0x00000001815D2520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001815D2CD0-0x00000001815D2E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815D2A30-0x00000001815D2B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001815D2160-0x00000001815D2250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OneoffGatherPointDetectorDataNotify other) {} // 0x00000001815D1D30-0x00000001815D1E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001815D1BA0-0x00000001815D1CD0
}

