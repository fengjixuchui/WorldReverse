/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetSceneAreaReq : MessageBase, IMessage<GetSceneAreaReq> // TypeDefIndex: 24960
{
	// Fields
	private static readonly MessageParser<GetSceneAreaReq> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B07A7F
	private uint sceneId_; // 0x18
	public const int BelongUidFieldNumber = 2; // Metadata: 0x00B07A83
	private uint belongUid_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetSceneAreaReq> Parser { get => default; } // 0x0000000182616F80-0x0000000182617010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182616D10-0x0000000182616DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182616A00-0x0000000182616A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001826162B0-0x0000000182616310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001826173B0-0x00000001826174A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001826171E0-0x0000000182617240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182616DA0-0x0000000182616E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182617360-0x00000001826173B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182616B20-0x0000000182616C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000182616500-0x00000001826165A0 0x0000000182616960-0x0000000182616A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BelongUid { get => default; set {} } // 0x0000000182617010-0x00000001826170B0 0x00000001826165A0-0x0000000182616640

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24961
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24962
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 222
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneAreaReq() {} // 0x0000000182617760-0x00000001826177C0
	static GetSceneAreaReq() {} // 0x00000001826176A0-0x0000000182617760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneAreaReq Clone() => default; // 0x0000000182616E90-0x0000000182616F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneAreaReq ShallowCopy() => default; // 0x0000000182616A80-0x0000000182616B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182616440-0x0000000182616490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182617140-0x0000000182617190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182617190-0x00000001826171E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182616490-0x0000000182616500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182616640-0x0000000182616710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetSceneAreaReq other) => default; // 0x0000000182616710-0x0000000182616830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182616C10-0x0000000182616D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001826174A0-0x00000001826176A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182617240-0x0000000182617360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182616830-0x0000000182616960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetSceneAreaReq other) {} // 0x0000000182616310-0x0000000182616440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001826161B0-0x00000001826162B0
}

