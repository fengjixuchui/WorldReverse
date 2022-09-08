/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetScenePointReq : MessageBase, IMessage<GetScenePointReq> // TypeDefIndex: 24934
{
	// Fields
	private static readonly MessageParser<GetScenePointReq> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B07967
	private uint sceneId_; // 0x18
	public const int BelongUidFieldNumber = 2; // Metadata: 0x00B0796B
	private uint belongUid_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetScenePointReq> Parser { get => default; } // 0x0000000182243810-0x00000001822438A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001822435A0-0x0000000182243630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182243290-0x0000000182243310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182242B40-0x0000000182242BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182243C40-0x0000000182243D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182243A70-0x0000000182243AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182243630-0x0000000182243720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182243BF0-0x0000000182243C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822433B0-0x00000001822434A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000182242D90-0x0000000182242E30 0x00000001822431F0-0x0000000182243290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BelongUid { get => default; set {} } // 0x00000001822438A0-0x0000000182243940 0x0000000182242E30-0x0000000182242ED0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24935
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24936
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 214
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetScenePointReq() {} // 0x0000000182243FF0-0x0000000182244050
	static GetScenePointReq() {} // 0x0000000182243F30-0x0000000182243FF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetScenePointReq Clone() => default; // 0x0000000182243720-0x0000000182243810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetScenePointReq ShallowCopy() => default; // 0x0000000182243310-0x00000001822433B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182242CD0-0x0000000182242D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822439D0-0x0000000182243A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182243A20-0x0000000182243A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182242D20-0x0000000182242D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182242ED0-0x0000000182242FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetScenePointReq other) => default; // 0x0000000182242FA0-0x00000001822430C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822434A0-0x00000001822435A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182243D30-0x0000000182243F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182243AD0-0x0000000182243BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822430C0-0x00000001822431F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetScenePointReq other) {} // 0x0000000182242BA0-0x0000000182242CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182242A40-0x0000000182242B40
}

