/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnterWorldAreaReq : MessageBase, IMessage<EnterWorldAreaReq> // TypeDefIndex: 24993
{
	// Fields
	private static readonly MessageParser<EnterWorldAreaReq> _parser; // 0x00
	public const int AreaTypeFieldNumber = 1; // Metadata: 0x00B07B9B
	private uint areaType_; // 0x18
	public const int AreaIdFieldNumber = 2; // Metadata: 0x00B07B9F
	private uint areaId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnterWorldAreaReq> Parser { get => default; } // 0x0000000184A430F0-0x0000000184A43180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A42DE0-0x0000000184A42E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A42AD0-0x0000000184A42B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A424C0-0x0000000184A42520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A43520-0x0000000184A43610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A43350-0x0000000184A433B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A42F10-0x0000000184A43000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A434D0-0x0000000184A43520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A42BF0-0x0000000184A42CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AreaType { get => default; set {} } // 0x0000000184A43610-0x0000000184A436B0 0x0000000184A43260-0x0000000184A43300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AreaId { get => default; set {} } // 0x0000000184A42710-0x0000000184A427B0 0x0000000184A42E70-0x0000000184A42F10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24994
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24995
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 233
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterWorldAreaReq() {} // 0x0000000184A43970-0x0000000184A439D0
	static EnterWorldAreaReq() {} // 0x0000000184A438B0-0x0000000184A43970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterWorldAreaReq Clone() => default; // 0x0000000184A43000-0x0000000184A430F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterWorldAreaReq ShallowCopy() => default; // 0x0000000184A42B50-0x0000000184A42BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A42650-0x0000000184A426A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A43210-0x0000000184A43260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A43300-0x0000000184A43350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A426A0-0x0000000184A42710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A427B0-0x0000000184A42880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EnterWorldAreaReq other) => default; // 0x0000000184A42880-0x0000000184A429A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A42CE0-0x0000000184A42DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A436B0-0x0000000184A438B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A433B0-0x0000000184A434D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A429A0-0x0000000184A42AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EnterWorldAreaReq other) {} // 0x0000000184A42520-0x0000000184A42650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A423C0-0x0000000184A424C0
}

