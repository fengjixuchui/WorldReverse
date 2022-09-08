/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ResinChangeNotify : MessageBase, IMessage<ResinChangeNotify> // TypeDefIndex: 23724
{
	// Fields
	private static readonly MessageParser<ResinChangeNotify> _parser; // 0x00
	public const int CurValueFieldNumber = 1; // Metadata: 0x00B04B1F
	private uint curValue_; // 0x18
	public const int NextAddTimestampFieldNumber = 2; // Metadata: 0x00B04B23
	private uint nextAddTimestamp_; // 0x1C
	public const int CurBuyCountFieldNumber = 3; // Metadata: 0x00B04B27
	private uint curBuyCount_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ResinChangeNotify> Parser { get => default; } // 0x0000000181E97990-0x0000000181E97A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E975E0-0x0000000181E97670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E972A0-0x0000000181E97320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E96AA0-0x0000000181E96B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E97E00-0x0000000181E97EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E97B50-0x0000000181E97BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E97670-0x0000000181E97760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E97D10-0x0000000181E97D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E973C0-0x0000000181E974B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurValue { get => default; set {} } // 0x0000000181E97850-0x0000000181E978F0 0x0000000181E96E70-0x0000000181E96F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextAddTimestamp { get => default; set {} } // 0x0000000181E96C60-0x0000000181E96D00 0x0000000181E96D50-0x0000000181E96DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurBuyCount { get => default; set {} } // 0x0000000181E97D60-0x0000000181E97E00 0x0000000181E978F0-0x0000000181E97990

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23725
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23726
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 643
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinChangeNotify() {} // 0x0000000181E98240-0x0000000181E982A0
	static ResinChangeNotify() {} // 0x0000000181E98180-0x0000000181E98240

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinChangeNotify Clone() => default; // 0x0000000181E97760-0x0000000181E97850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinChangeNotify ShallowCopy() => default; // 0x0000000181E97320-0x0000000181E973C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E96D00-0x0000000181E96D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E97AB0-0x0000000181E97B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E97B00-0x0000000181E97B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E96DF0-0x0000000181E96E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E96F10-0x0000000181E96FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ResinChangeNotify other) => default; // 0x0000000181E96FE0-0x0000000181E97120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E974B0-0x0000000181E975E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E97EF0-0x0000000181E98180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E97BB0-0x0000000181E97D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E97120-0x0000000181E972A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ResinChangeNotify other) {} // 0x0000000181E96B00-0x0000000181E96C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E96990-0x0000000181E96AA0
}

