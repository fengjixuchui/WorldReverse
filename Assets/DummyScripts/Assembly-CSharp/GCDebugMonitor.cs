/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class GCDebugMonitor // TypeDefIndex: 27721
{
	// Fields
	private static GCTimer _timer; // 0x00
	private static GCInfo _gcCurrentInfo; // 0x08
	private static GCInfo _gcInfo; // 0x30

	// Properties
	public static GCInfo gcInfo { /* [XID] */ /* 0x00000001897E5670-0x00000001897E5690 */ get => default; } // 0x000000018212AD30-0x000000018212AE70 
	public static bool dirty { /* [XID] */ /* 0x00000001897ED0F0-0x00000001897ED130 */ get; /* [XID] */ /* 0x00000001897F78A0-0x00000001897F78E0 */ private set; } // 0x000000018212BB20-0x000000018212BBB0 0x000000018212BA90-0x000000018212BB20

	// Nested types
	public struct GCInfo // TypeDefIndex: 27722
	{
		// Fields
		public ulong allocBytes; // 0x00
		public ulong allocCount; // 0x08
		public ulong maxFrameAllocBytes; // 0x10
		public ulong maxFrameAllocCount; // 0x18
		public int frameCount; // 0x20
		public bool isLoading; // 0x24
	}

	private class GCTimer : DebugMonitorTimer // TypeDefIndex: 27723
	{
		// Constructors
		public GCTimer() {} // 0x00000001821270C0-0x0000000182127120

		// Methods
		// [XID] // 0x0000000189827760-0x0000000189827780
		public override void Update(bool overtime) {} // 0x0000000182126FE0-0x00000001821270C0
	}

	// Constructors
	public GCDebugMonitor() {} // 0x000000018212BCF0-0x000000018212BD50
	static GCDebugMonitor() {} // 0x000000018212BBB0-0x000000018212BCF0

	// Methods
	// [XID] // 0x0000000189802200-0x0000000189802220
	private static void UpdateGCInfo(bool force) {} // 0x000000018212B6F0-0x000000018212BA90
	// [XID] // 0x0000000189809650-0x0000000189809670
	public static void Tick() {} // 0x000000018212B400-0x000000018212B4D0
	// [XID] // 0x0000000189810E60-0x0000000189810E80
	public static void GetGCInfo() {} // 0x000000018212AE70-0x000000018212B110
	// [XID] // 0x0000000189818930-0x0000000189818950
	public static string GetGCInfoString() => default; // 0x000000018212B4D0-0x000000018212B6F0
	// [XID] // 0x00000001898201E0-0x0000000189820200
	public static void AddGCInfo(StringBuilder buffer) {} // 0x000000018212B110-0x000000018212B400
}

