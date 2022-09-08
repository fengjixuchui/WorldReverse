/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneRouteChangeNotify : MessageBase, IMessage<SceneRouteChangeNotify> // TypeDefIndex: 25066
{
	// Fields
	private static readonly MessageParser<SceneRouteChangeNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B07E7F
	private uint sceneId_; // 0x18
	public const int RouteListFieldNumber = 2; // Metadata: 0x00B07E83
	private static readonly FieldCodec<SceneRouteChangeInfo> _repeated_routeList_codec; // 0x08
	private readonly RepeatedMessageField<SceneRouteChangeInfo> routeList_; // 0x20
	public const int SceneTimeFieldNumber = 3; // Metadata: 0x00B07E87
	private uint sceneTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneRouteChangeNotify> Parser { get => default; } // 0x0000000182477040-0x00000001824770D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182476D30-0x0000000182476DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182476990-0x0000000182476A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182476170-0x00000001824761D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182477550-0x0000000182477640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182477280-0x00000001824772E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182476E60-0x0000000182476F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182477460-0x00000001824774B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182476B10-0x0000000182476C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x00000001824764A0-0x0000000182476540 0x00000001824768F0-0x0000000182476990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SceneRouteChangeInfo> RouteList { get => default; } // 0x0000000182476AB0-0x0000000182476B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x0000000182476DC0-0x0000000182476E60 0x00000001824774B0-0x0000000182477550

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25067
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25068
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 257
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneRouteChangeNotify() {} // 0x00000001824779C0-0x0000000182477A50
	static SceneRouteChangeNotify() {} // 0x00000001824778B0-0x00000001824779C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneRouteChangeNotify Clone() => default; // 0x0000000182476F50-0x0000000182477040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneRouteChangeNotify ShallowCopy() => default; // 0x0000000182476A10-0x0000000182476AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182476360-0x00000001824763B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182477160-0x00000001824771F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824771F0-0x0000000182477280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001824763B0-0x00000001824764A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182476690-0x0000000182476760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneRouteChangeNotify other) => default; // 0x0000000182476540-0x0000000182476690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182476C00-0x0000000182476D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182477640-0x00000001824778B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824772E0-0x0000000182477460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182476760-0x00000001824768F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneRouteChangeNotify other) {} // 0x00000001824761D0-0x0000000182476360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182475FF0-0x0000000182476170
}

