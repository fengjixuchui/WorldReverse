/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerCurLevelRecordChangeNotify : MessageBase, IMessage<TowerCurLevelRecordChangeNotify> // TypeDefIndex: 25703
{
	// Fields
	private static readonly MessageParser<TowerCurLevelRecordChangeNotify> _parser; // 0x00
	public const int CurLevelRecordFieldNumber = 1; // Metadata: 0x00B09623
	private TowerCurLevelRecord curLevelRecord_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerCurLevelRecordChangeNotify> Parser { get => default; } // 0x0000000183C0A810-0x0000000183C0A8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C0A5A0-0x0000000183C0A630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C0A240-0x0000000183C0A2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C09B10-0x0000000183C09B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C0AC60-0x0000000183C0AD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C0AA30-0x0000000183C0AA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C0A630-0x0000000183C0A720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C0AB70-0x0000000183C0ABC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C0A360-0x0000000183C0A450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerCurLevelRecord CurLevelRecord { get => default; set {} } // 0x0000000183C09E70-0x0000000183C09F10 0x0000000183C0ABC0-0x0000000183C0AC60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25704
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25705
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2403
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerCurLevelRecordChangeNotify() {} // 0x0000000183C0AF60-0x0000000183C0AFC0
	static TowerCurLevelRecordChangeNotify() {} // 0x0000000183C0AEA0-0x0000000183C0AF60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerCurLevelRecordChangeNotify Clone() => default; // 0x0000000183C0A720-0x0000000183C0A810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerCurLevelRecordChangeNotify ShallowCopy() => default; // 0x0000000183C0A2C0-0x0000000183C0A360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C09CD0-0x0000000183C09D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C0A930-0x0000000183C0A9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C0A9B0-0x0000000183C0AA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C09D50-0x0000000183C09E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C0A020-0x0000000183C0A0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerCurLevelRecordChangeNotify other) => default; // 0x0000000183C09F10-0x0000000183C0A020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C0A450-0x0000000183C0A5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C0AD50-0x0000000183C0AEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C0AA90-0x0000000183C0AB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C0A0F0-0x0000000183C0A240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerCurLevelRecordChangeNotify other) {} // 0x0000000183C09B70-0x0000000183C09CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C09A00-0x0000000183C09B10
}

