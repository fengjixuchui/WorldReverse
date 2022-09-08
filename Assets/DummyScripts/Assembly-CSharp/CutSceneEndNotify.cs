/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CutSceneEndNotify : MessageBase, IMessage<CutSceneEndNotify> // TypeDefIndex: 25191
{
	// Fields
	private static readonly MessageParser<CutSceneEndNotify> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B082CF
	private int retcode_; // 0x18
	public const int CutsceneIdFieldNumber = 2; // Metadata: 0x00B082D3
	private uint cutsceneId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CutSceneEndNotify> Parser { get => default; } // 0x00000001840577C0-0x0000000184057850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001840574B0-0x0000000184057540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184057100-0x0000000184057180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184056A50-0x0000000184056AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184057B50-0x0000000184057C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184057980-0x00000001840579E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001840575E0-0x00000001840576D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184057B00-0x0000000184057B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184057220-0x0000000184057310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184057060-0x0000000184057100 0x0000000184056CA0-0x0000000184056D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CutsceneId { get => default; set {} } // 0x0000000184057410-0x00000001840574B0 0x0000000184057540-0x00000001840575E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25192
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25193
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 297
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CutSceneEndNotify() {} // 0x0000000184057F00-0x0000000184057F60
	static CutSceneEndNotify() {} // 0x0000000184057E40-0x0000000184057F00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CutSceneEndNotify Clone() => default; // 0x00000001840576D0-0x00000001840577C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CutSceneEndNotify ShallowCopy() => default; // 0x0000000184057180-0x0000000184057220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184056BE0-0x0000000184056C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840578E0-0x0000000184057930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184057930-0x0000000184057980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184056C30-0x0000000184056CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184056E60-0x0000000184056F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CutSceneEndNotify other) => default; // 0x0000000184056D40-0x0000000184056E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184057310-0x0000000184057410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184057C40-0x0000000184057E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001840579E0-0x0000000184057B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184056F30-0x0000000184057060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CutSceneEndNotify other) {} // 0x0000000184056AB0-0x0000000184056BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184056950-0x0000000184056A50
}

