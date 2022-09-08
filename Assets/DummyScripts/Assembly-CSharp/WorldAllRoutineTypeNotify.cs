/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldAllRoutineTypeNotify : MessageBase, IMessage<WorldAllRoutineTypeNotify> // TypeDefIndex: 24876
{
	// Fields
	private static readonly MessageParser<WorldAllRoutineTypeNotify> _parser; // 0x00
	public const int WorldRoutineTypeListFieldNumber = 1; // Metadata: 0x00B076E3
	private static readonly FieldCodec<WorldRoutineTypeInfo> _repeated_worldRoutineTypeList_codec; // 0x08
	private readonly RepeatedMessageField<WorldRoutineTypeInfo> worldRoutineTypeList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldAllRoutineTypeNotify> Parser { get => default; } // 0x0000000183419070-0x0000000183419100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183418E00-0x0000000183418E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183418B30-0x0000000183418BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001834185B0-0x0000000183418610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183419460-0x0000000183419550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834192B0-0x0000000183419310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183418E90-0x0000000183418F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183419410-0x0000000183419460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183418C50-0x0000000183418D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<WorldRoutineTypeInfo> WorldRoutineTypeList { get => default; } // 0x0000000183419550-0x00000001834195B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24877
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24878
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3502
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldAllRoutineTypeNotify() {} // 0x0000000183419810-0x00000001834198A0
	static WorldAllRoutineTypeNotify() {} // 0x0000000183419700-0x0000000183419810

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldAllRoutineTypeNotify Clone() => default; // 0x0000000183418F80-0x0000000183419070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldAllRoutineTypeNotify ShallowCopy() => default; // 0x0000000183418BB0-0x0000000183418C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183418740-0x0000000183418790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183419190-0x0000000183419220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183419220-0x00000001834192B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183418790-0x0000000183418860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183418860-0x0000000183418930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldAllRoutineTypeNotify other) => default; // 0x0000000183418930-0x0000000183418A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183418D40-0x0000000183418E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001834195B0-0x0000000183419700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183419310-0x0000000183419410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183418A40-0x0000000183418B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldAllRoutineTypeNotify other) {} // 0x0000000183418610-0x0000000183418740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183418480-0x00000001834185B0
}

