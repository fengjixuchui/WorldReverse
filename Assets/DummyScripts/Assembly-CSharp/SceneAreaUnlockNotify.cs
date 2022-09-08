/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneAreaUnlockNotify : MessageBase, IMessage<SceneAreaUnlockNotify> // TypeDefIndex: 24966
{
	// Fields
	private static readonly MessageParser<SceneAreaUnlockNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B07ABB
	private uint sceneId_; // 0x18
	public const int AreaListFieldNumber = 2; // Metadata: 0x00B07ABF
	private static readonly FieldCodec<uint> _repeated_areaList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> areaList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneAreaUnlockNotify> Parser { get => default; } // 0x0000000182047B70-0x0000000182047C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182047900-0x0000000182047990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820475F0-0x0000000182047670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182046E70-0x0000000182046ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182047F20-0x0000000182048010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182047D30-0x0000000182047D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182047990-0x0000000182047A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182047ED0-0x0000000182047F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182047710-0x0000000182047800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000182047170-0x0000000182047210 0x0000000182047550-0x00000001820475F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AreaList { get => default; } // 0x0000000182047110-0x0000000182047170 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24967
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24968
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 224
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAreaUnlockNotify() {} // 0x00000001820482D0-0x0000000182048360
	static SceneAreaUnlockNotify() {} // 0x00000001820481F0-0x00000001820482D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAreaUnlockNotify Clone() => default; // 0x0000000182047A80-0x0000000182047B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAreaUnlockNotify ShallowCopy() => default; // 0x0000000182047670-0x0000000182047710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182047000-0x0000000182047050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182047C90-0x0000000182047CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182047CE0-0x0000000182047D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182047050-0x0000000182047110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182047340-0x0000000182047410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneAreaUnlockNotify other) => default; // 0x0000000182047210-0x0000000182047340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182047800-0x0000000182047900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182048010-0x00000001820481F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182047D90-0x0000000182047ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182047410-0x0000000182047550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneAreaUnlockNotify other) {} // 0x0000000182046ED0-0x0000000182047000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182046D00-0x0000000182046E70
}

