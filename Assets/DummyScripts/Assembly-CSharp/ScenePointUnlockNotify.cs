/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePointUnlockNotify : MessageBase, IMessage<ScenePointUnlockNotify> // TypeDefIndex: 24947
{
	// Fields
	private static readonly MessageParser<ScenePointUnlockNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B079FF
	private uint sceneId_; // 0x18
	public const int PointListFieldNumber = 2; // Metadata: 0x00B07A03
	private static readonly FieldCodec<uint> _repeated_pointList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> pointList_; // 0x20
	public const int LockedPointListFieldNumber = 3; // Metadata: 0x00B07A07
	private static readonly FieldCodec<uint> _repeated_lockedPointList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> lockedPointList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePointUnlockNotify> Parser { get => default; } // 0x0000000183E068F0-0x0000000183E06980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E06680-0x0000000183E06710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E062F0-0x0000000183E06370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E05A80-0x0000000183E05AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E06CD0-0x0000000183E06DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E06AB0-0x0000000183E06B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E06710-0x0000000183E06800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E06C80-0x0000000183E06CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E06410-0x0000000183E06500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000183E05E10-0x0000000183E05EB0 0x0000000183E06250-0x0000000183E062F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> PointList { get => default; } // 0x0000000183E05AE0-0x0000000183E05B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> LockedPointList { get => default; } // 0x0000000183E06620-0x0000000183E06680 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24948
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24949
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 218
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePointUnlockNotify() {} // 0x0000000183E07120-0x0000000183E071D0
	static ScenePointUnlockNotify() {} // 0x0000000183E07020-0x0000000183E07120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePointUnlockNotify Clone() => default; // 0x0000000183E06800-0x0000000183E068F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePointUnlockNotify ShallowCopy() => default; // 0x0000000183E06370-0x0000000183E06410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E05C90-0x0000000183E05CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E06A10-0x0000000183E06A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E06A60-0x0000000183E06AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E05CE0-0x0000000183E05E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E05EB0-0x0000000183E05F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePointUnlockNotify other) => default; // 0x0000000183E05F80-0x0000000183E060D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E06500-0x0000000183E06620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E06DC0-0x0000000183E07020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E06B10-0x0000000183E06C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E060D0-0x0000000183E06250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePointUnlockNotify other) {} // 0x0000000183E05B40-0x0000000183E05C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E058A0-0x0000000183E05A80
}

