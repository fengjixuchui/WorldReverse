/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntityDisappearNotify : MessageBase, IMessage<SceneEntityDisappearNotify> // TypeDefIndex: 24913
{
	// Fields
	private static readonly MessageParser<SceneEntityDisappearNotify> _parser; // 0x00
	public const int EntityListFieldNumber = 1; // Metadata: 0x00B07897
	private static readonly FieldCodec<uint> _repeated_entityList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> entityList_; // 0x18
	public const int DisappearTypeFieldNumber = 2; // Metadata: 0x00B0789B
	private VisionType disappearType_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntityDisappearNotify> Parser { get => default; } // 0x000000018540C6E0-0x000000018540C770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018540C3D0-0x000000018540C460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018540C090-0x000000018540C110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018540BA50-0x000000018540BAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018540CB30-0x000000018540CC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018540C8A0-0x000000018540C900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018540C460-0x000000018540C550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018540CAE0-0x000000018540CB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018540C1B0-0x000000018540C2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> EntityList { get => default; } // 0x000000018540BAB0-0x000000018540BB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public VisionType DisappearType { get => default; set {} } // 0x000000018540C640-0x000000018540C6E0 0x000000018540C900-0x000000018540C9A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24914
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24915
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 207
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityDisappearNotify() {} // 0x000000018540CEE0-0x000000018540CF80
	static SceneEntityDisappearNotify() {} // 0x000000018540CE00-0x000000018540CEE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityDisappearNotify Clone() => default; // 0x000000018540C550-0x000000018540C640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityDisappearNotify ShallowCopy() => default; // 0x000000018540C110-0x000000018540C1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018540BC40-0x000000018540BC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018540C800-0x000000018540C850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018540C850-0x000000018540C8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018540BC90-0x000000018540BD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018540BE80-0x000000018540BF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntityDisappearNotify other) => default; // 0x000000018540BD60-0x000000018540BE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018540C2A0-0x000000018540C3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018540CC20-0x000000018540CE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018540C9A0-0x000000018540CAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018540BF50-0x000000018540C090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntityDisappearNotify other) {} // 0x000000018540BB10-0x000000018540BC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018540B8F0-0x000000018540BA50
}

