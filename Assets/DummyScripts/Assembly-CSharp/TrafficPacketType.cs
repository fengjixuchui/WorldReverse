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

internal class TrafficPacketType // TypeDefIndex: 21741
{
	// Fields
	public int packetCount; // 0x10
	public int totalSize; // 0x14
	public int packetCounterDownload; // 0x18
	public int totalSizeDownload; // 0x1C
	public int packetCounterUpload; // 0x20
	public int totalSizeUpload; // 0x24

	// Constructors
	public TrafficPacketType() {} // 0x000000018300E530-0x000000018300E5A0

	// Methods
	// [XID] // 0x0000000189755080-0x00000001897550A0
	public void CountPacket(TrafficType trafficType, int packetSize) {} // 0x000000018300E450-0x000000018300E530
	// [XID] // 0x000000018975C1F0-0x000000018975C210
	public void GetTraffic(ref StringBuilder sb, float timeSpan) {} // 0x000000018300E030-0x000000018300E450
}

