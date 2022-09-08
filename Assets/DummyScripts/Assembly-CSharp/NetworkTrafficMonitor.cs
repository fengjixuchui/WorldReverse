/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class NetworkTrafficMonitor // TypeDefIndex: 21739
{
	// Fields
	private const float UPDATE_INTERVAL = 1f; // Metadata: 0x00AFFD87
	private const string FILE_PATH = "/Profiling/Auto/"; // Metadata: 0x00AFFD8B
	public bool isWatching; // 0x10
	public float packetPerSecond; // 0x14
	public float clientTotalBandwidth; // 0x18
	public float packetRXPerSecond; // 0x1C
	public float clientRXBandWidth; // 0x20
	public float packetTXPerSecond; // 0x24
	public float clientTXBandWidth; // 0x28
	public int processedPacket; // 0x2C
	public float processTime; // 0x30
	public int remainPacket; // 0x34
	private TrafficPacketType overallTraffic; // 0x38
	private Dictionary<string, TrafficPacketType> packetTrafficDict; // 0x40
	public float _internalPacketRX; // 0x48
	public float _internalPacketTX; // 0x4C
	private int _internalClientRXBandWidth; // 0x50
	private int _internalClientTXBandWidth; // 0x54
	private int _processedPacket; // 0x58
	private int _maxProcessedPacket; // 0x5C
	private float _maxProcessedTime; // 0x60
	private int _maxRemainPacket; // 0x64
	private DateTime _startTimestamp; // 0x68
	private DateTime _lastCountedTimestamp; // 0x78

	// Properties
	public float kcpTotalBandwidth { /* [XID] */ /* 0x00000001896D6460-0x00000001896D6480 */ get => default; } // 0x000000018150E050-0x000000018150E120 
	public float kcpRXBandWidth { /* [XID] */ /* 0x00000001896DDB20-0x00000001896DDB40 */ get => default; } // 0x000000018150E120-0x000000018150E210 
	public float kcpTXBandWidth { /* [XID] */ /* 0x00000001896E51D0-0x00000001896E51F0 */ get => default; } // 0x000000018150D680-0x000000018150D770 

	// Nested types
	public struct UnionPerfResult // TypeDefIndex: 21740
	{
		// Fields
		public float overOverAllTraffic; // 0x00
	}

	// Constructors
	public NetworkTrafficMonitor() {} // 0x000000018150E9C0-0x000000018150EA90

	// Methods
	// [XID] // 0x00000001896EC6E0-0x00000001896EC700
	private void ClearInternalData() {} // 0x000000018150C5F0-0x000000018150C6A0
	// [XID] // 0x00000001896F3EA0-0x00000001896F3EC0
	private void Clear() {} // 0x000000018150D400-0x000000018150D500
	// [XID] // 0x00000001896FB6B0-0x00000001896FB6D0
	public void StartWatching() {} // 0x000000018150D500-0x000000018150D680
	// [XID] // 0x0000000189702D30-0x0000000189702D50
	public UnionPerfResult GetOverallTraffic() => default; // 0x000000018150D230-0x000000018150D400
	// [XID] // 0x000000018970A420-0x000000018970A440
	public string StopWatching() => default; // 0x000000018150CB70-0x000000018150D190
	// [XID] // 0x0000000189B46BA0-0x0000000189B46BC0
	public void CountPacket(TrafficType trafficType, IMessage packet, int len) {} // 0x000000018150E610-0x000000018150E810
	// [XID] // 0x00000001897194D0-0x00000001897194F0
	private void HandleCombatPacket(TrafficType trafficType, IMessage packet) {} // 0x000000018150E210-0x000000018150E610
	// [XID] // 0x0000000189720A70-0x0000000189720A90
	private void HandleAbilityPacket(TrafficType trafficType, IMessage packet) {} // 0x000000018150DC50-0x000000018150E050
	// [XID] // 0x00000001897280B0-0x00000001897280D0
	private void AddPacketToDictionary(ref Dictionary<string, TrafficPacketType> dict, TrafficType trafficType, int packetSize, string packetType) {} // 0x000000018150E810-0x000000018150E9C0
	// [XID] // 0x000000018972F6F0-0x000000018972F710
	public void CountProcessedPacket() {} // 0x000000018150D190-0x000000018150D230
	// [XID] // 0x0000000189737160-0x0000000189737180
	public void CountProcessTick(float elapsed, int remainPacket) {} // 0x000000018150C510-0x000000018150C5F0
	// [XID] // 0x000000018973ED00-0x000000018973ED20
	public void CalculatePerSecond() {} // 0x000000018150C6A0-0x000000018150C920
	// [XID] // 0x0000000189745F80-0x0000000189745FA0
	public string GetRealTimeNetworkTrafficStr() => default; // 0x000000018150C920-0x000000018150CB70
	// [XID] // 0x000000018974DA10-0x000000018974DA30
	public string GetOverallTrafficStr(float timeSpan) => default; // 0x000000018150D770-0x000000018150DC50
}

