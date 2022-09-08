/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYo.SDK.Protobuf;
using MiHoYo.SDK.Protobuf.Collections;
using MiHoYo.SDK.Protobuf.Reflection;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public sealed class CommonInfo : IMessage<MiHoYo.SDK.CommonInfo> // TypeDefIndex: 8828
	{
		// Fields
		private static readonly MessageParser<CommonInfo> _parser; // 0x00
		public const int UserIdFieldNumber = 1; // Metadata: 0x00AE239F
		private string userId_; // 0x10
		public const int PlatformFieldNumber = 2; // Metadata: 0x00AE23A3
		private string platform_; // 0x18
		public const int DeviceNameFieldNumber = 3; // Metadata: 0x00AE23A7
		private string deviceName_; // 0x20
		public const int SystemVersionFieldNumber = 4; // Metadata: 0x00AE23AB
		private string systemVersion_; // 0x28
		public const int DeviceIdFieldNumber = 5; // Metadata: 0x00AE23AF
		private string deviceId_; // 0x30
		public const int AppVersionFieldNumber = 6; // Metadata: 0x00AE23B3
		private string appVersion_; // 0x38
		public const int PkgChannelFieldNumber = 7; // Metadata: 0x00AE23B7
		private string pkgChannel_; // 0x40
		public const int ExtraInfoFieldNumber = 8; // Metadata: 0x00AE23BB
		private static readonly MapField<string, string> _map_extraInfo_codec; // 0x08
		private readonly MapField<string, string> extraInfo_; // 0x48
	
		// Properties
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor IMessage.Descriptor { /* [XID] */ /* 0x0000000189B87190-0x0000000189B871B0 */ get => default; } // 0x00000001859D8770-0x00000001859D8840 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MessageParser<CommonInfo> Parser { /* [XID] */ /* 0x0000000189B77FF0-0x0000000189B78010 */ get => default; } // 0x00000001859D94B0-0x00000001859D9580 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public static MiHoYo.SDK.Protobuf.Reflection.MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189B7F500-0x0000000189B7F520 */ get => default; } // 0x00000001859D91D0-0x00000001859D92D0 
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string UserId { /* [XID] */ /* 0x0000000189B988D0-0x0000000189B988F0 */ get => default; /* [XID] */ /* 0x00000001898C4580-0x00000001898C45A0 */ set {} } // 0x00000001859D9760-0x00000001859D9800 0x00000001859D9C80-0x00000001859D9D70
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string Platform { /* [XID] */ /* 0x0000000189A08AB0-0x0000000189A08AD0 */ get => default; /* [XID] */ /* 0x00000001898D3310-0x00000001898D3330 */ set {} } // 0x00000001859D9620-0x00000001859D96C0 0x00000001859D9B00-0x00000001859D9BC0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string DeviceName { /* [XID] */ /* 0x0000000189BB5F50-0x0000000189BB5F70 */ get => default; /* [XID] */ /* 0x0000000189BBD5A0-0x0000000189BBD5C0 */ set {} } // 0x00000001859D9370-0x00000001859D9410 0x00000001859D9980-0x00000001859D9A40
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string SystemVersion { /* [XID] */ /* 0x0000000189BC52A0-0x0000000189BC52C0 */ get => default; /* [XID] */ /* 0x0000000189900E90-0x0000000189900EB0 */ set {} } // 0x00000001859D96C0-0x00000001859D9760 0x00000001859D9BC0-0x00000001859D9C80
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string DeviceId { /* [XID] */ /* 0x0000000189BD4330-0x0000000189BD4350 */ get => default; /* [XID] */ /* 0x0000000189BDBD20-0x0000000189BDBD40 */ set {} } // 0x00000001859D92D0-0x00000001859D9370 0x00000001859D98C0-0x00000001859D9980
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string AppVersion { /* [XID] */ /* 0x0000000189729BE0-0x0000000189729C00 */ get => default; /* [XID] */ /* 0x00000001895EFE70-0x00000001895EFE90 */ set {} } // 0x00000001859D9130-0x00000001859D91D0 0x00000001859D9800-0x00000001859D98C0
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public string PkgChannel { /* [XID] */ /* 0x00000001895F7750-0x00000001895F7770 */ get => default; /* [XID] */ /* 0x00000001895FEB10-0x00000001895FEB30 */ set {} } // 0x00000001859D9580-0x00000001859D9620 0x00000001859D9A40-0x00000001859D9B00
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public MapField<string, string> ExtraInfo { /* [XID] */ /* 0x0000000189606550-0x0000000189606570 */ get => default; } // 0x00000001859D9410-0x00000001859D94B0 
	
		// Constructors
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public CommonInfo() {} // 0x00000001859D9050-0x00000001859D9130
		[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
		public CommonInfo(CommonInfo other) {} // 0x00000001859D8F80-0x00000001859D9050
		static CommonInfo() {} // 0x00000001859D8E50-0x00000001859D8F80
	
		// Methods
		[DebuggerNonUserCode] // 0x0000000189B8E300-0x0000000189B8E340
		// [XID] // 0x0000000189B8E300-0x0000000189B8E340
		public CommonInfo Clone() => default; // 0x00000001859D7A70-0x00000001859D7B40
		[DebuggerNonUserCode] // 0x000000018960DF10-0x000000018960DF60
		// [IDTag] // 0x000000018960DF10-0x000000018960DF60
		// [XID] // 0x000000018960DF10-0x000000018960DF60
		public override bool Equals(object other) => default; // 0x00000001859D7EB0-0x00000001859D7F80
		[DebuggerNonUserCode] // 0x000000018961B3D0-0x000000018961B420
		// [IDTag] // 0x000000018961B3D0-0x000000018961B420
		// [XID] // 0x000000018961B3D0-0x000000018961B420
		public bool Equals(CommonInfo other) => default; // 0x00000001859D7B40-0x00000001859D7EB0
		[DebuggerNonUserCode] // 0x0000000189628A60-0x0000000189628AA0
		// [XID] // 0x0000000189628A60-0x0000000189628AA0
		public override int GetHashCode() => default; // 0x00000001859D7F80-0x00000001859D82B0
		[DebuggerNonUserCode] // 0x00000001896333A0-0x00000001896333E0
		// [XID] // 0x00000001896333A0-0x00000001896333E0
		public override string ToString() => default; // 0x00000001859D8840-0x00000001859D8910
		[DebuggerNonUserCode] // 0x000000018963DCF0-0x000000018963DD30
		// [XID] // 0x000000018963DCF0-0x000000018963DD30
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output) {} // 0x00000001859D8AE0-0x00000001859D8E50
		[DebuggerNonUserCode] // 0x0000000189648340-0x0000000189648380
		// [XID] // 0x0000000189648340-0x0000000189648380
		public int CalculateSize() => default; // 0x00000001859D76B0-0x00000001859D7A70
		[DebuggerNonUserCode] // 0x0000000189652A10-0x0000000189652A60
		// [IDTag] // 0x0000000189652A10-0x0000000189652A60
		// [XID] // 0x0000000189652A10-0x0000000189652A60
		public void MergeFrom(CommonInfo other) {} // 0x00000001859D84E0-0x00000001859D8770
		[DebuggerNonUserCode] // 0x0000000189660010-0x0000000189660060
		// [IDTag] // 0x0000000189660010-0x0000000189660060
		// [XID] // 0x0000000189660010-0x0000000189660060
		public void MergeFrom(MiHoYo.SDK.Protobuf.CodedInputStream input) {} // 0x00000001859D82B0-0x00000001859D84E0
	}
}
