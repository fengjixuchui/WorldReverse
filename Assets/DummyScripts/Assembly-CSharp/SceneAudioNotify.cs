/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneAudioNotify : MessageBase, IMessage<SceneAudioNotify> // TypeDefIndex: 25352
{
	// Fields
	private static readonly MessageParser<SceneAudioNotify> _parser; // 0x00
	public const int SourceUidFieldNumber = 1; // Metadata: 0x00B08863
	private uint sourceUid_; // 0x18
	public const int TypeFieldNumber = 2; // Metadata: 0x00B08867
	private int type_; // 0x1C
	public const int Param1FieldNumber = 3; // Metadata: 0x00B0886B
	private static readonly FieldCodec<uint> _repeated_param1_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> param1_; // 0x20
	public const int Param2FieldNumber = 4; // Metadata: 0x00B0886F
	private static readonly FieldCodec<float> _repeated_param2_codec; // 0x10
	private readonly RepeatedPrimitiveField<float> param2_; // 0x28
	public const int Param3FieldNumber = 5; // Metadata: 0x00B08873
	private static readonly FieldCodec<string> _repeated_param3_codec; // 0x18
	private readonly RepeatedPrimitiveField<string> param3_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneAudioNotify> Parser { get => default; } // 0x00000001849DBBC0-0x00000001849DBC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849DB950-0x00000001849DB9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849DB5D0-0x00000001849DB650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849DAC30-0x00000001849DAC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849DC110-0x00000001849DC200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849DBDE0-0x00000001849DBE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849DB9E0-0x00000001849DBAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849DC020-0x00000001849DC070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849DB6F0-0x00000001849DB7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SourceUid { get => default; set {} } // 0x00000001849DAB90-0x00000001849DAC30 0x00000001849DAC90-0x00000001849DAD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Type { get => default; set {} } // 0x00000001849DA880-0x00000001849DA920 0x00000001849DC070-0x00000001849DC110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> Param1 { get => default; } // 0x00000001849DBD30-0x00000001849DBD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<float> Param2 { get => default; } // 0x00000001849DB0B0-0x00000001849DB110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> Param3 { get => default; } // 0x00000001849DB110-0x00000001849DB170 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25353
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25354
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3065
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAudioNotify() {} // 0x00000001849DC670-0x00000001849DC740
	static SceneAudioNotify() {} // 0x00000001849DC550-0x00000001849DC670

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAudioNotify Clone() => default; // 0x00000001849DBAD0-0x00000001849DBBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAudioNotify ShallowCopy() => default; // 0x00000001849DB650-0x00000001849DB6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849DAED0-0x00000001849DAF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849DBCE0-0x00000001849DBD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849DBD90-0x00000001849DBDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849DAF20-0x00000001849DB0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849DB170-0x00000001849DB240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneAudioNotify other) => default; // 0x00000001849DB240-0x00000001849DB3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849DB7E0-0x00000001849DB950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849DC200-0x00000001849DC550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849DBE40-0x00000001849DC020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849DB3E0-0x00000001849DB5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneAudioNotify other) {} // 0x00000001849DAD30-0x00000001849DAED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849DA920-0x00000001849DAB90
}

