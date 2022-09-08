/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class WTArea2DAmbience // TypeDefIndex: 11236
{
	// Fields
	private const float CHECK_THRESHOLD = 0.2f; // Metadata: 0x00AE94D2
	private const float SQR_CHECK_THRESHOLD = 0.040000003f; // Metadata: 0x00AE94D6
	private const string SYNC_NAME_PATTERN = "Wwise Sync 2D (Area Ambience, [{0}])"; // Metadata: 0x00AE94DA
	private const float Y_OFFSET_THRESHOLD = 0.2f; // Metadata: 0x00AE9502
	private bool m_enabled; // 0x10
	private WorkerThreadContext _context; // 0x18
	private Area2DAmbienceData _data; // 0x20
	private Discretization<float> valueDiscretizationForX; // 0x28
	private Discretization<float> valueDiscretizationForZ; // 0x30
	private HashSet<int> currentInsideHashSet; // 0x38
	private BitSet currentInsideBitSet; // 0x40
	private BitSet tempBitSet; // 0x48
	private BitSet tempBitSet1; // 0x50
	private BitSet[] prefixSumsArrayForX; // 0x58
	private BitSet[] prefixSumsArrayForZ; // 0x60
	private List<int> reverbList; // 0x68
	private int curActiveReverbIndex; // 0x70
	private TimeSpan waitClearReverbTime; // 0x78
	private TimeSpan clearReverbDelayTime; // 0x80
	private bool waitClearReverb; // 0x88
	private bool needUpdateReverb; // 0x89
	private Vector3 _lastUpdatePosition; // 0x8C
	private float _lastUpdateHeight; // 0x98
	private SyncId[] areaSyncArray; // 0xA0

	// Constructors
	public WTArea2DAmbience() {} // Dummy constructor
	public WTArea2DAmbience(WorkerThreadContext context) {} // 0x00000001837BE160-0x00000001837BE220

	// Methods
	// [XID] // 0x000000018989F500-0x000000018989F520
	public void Init() {} // 0x00000001837BC8F0-0x00000001837BC990
	// [XID] // 0x0000000189693B90-0x0000000189693BB0
	public void Tick(TimeSpan deltaTime, Vector3 listenerPosition) {} // 0x00000001837BC990-0x00000001837BCAB0
	// [XID] // 0x00000001896A9D90-0x00000001896A9DB0
	private void TickAreaInside(Vector3 listenerPosition) {} // 0x00000001837BDBC0-0x00000001837BE160
	// [XID] // 0x0000000189622AC0-0x0000000189622AE0
	private void LeaveArea(int index) {} // 0x00000001837BD180-0x00000001837BD6D0
	// [XID] // 0x0000000189613C60-0x0000000189613C80
	private void EnterArea(int index) {} // 0x00000001837BAA60-0x00000001837BB000
	// [XID] // 0x00000001898C4F40-0x00000001898C4F60
	private void UpdateReverb() {} // 0x00000001837BBEA0-0x00000001837BC610
	// [XID] // 0x000000018966D810-0x000000018966D830
	private void TickUpdateReverb() {} // 0x00000001837BC840-0x00000001837BC8F0
	// [XID] // 0x00000001898D3DB0-0x00000001898D3DD0
	private void TickClearReverb(TimeSpan deltaTime) {} // 0x00000001837BDA70-0x00000001837BDBC0
	// [XID] // 0x000000018961CD20-0x000000018961CD40
	public void UpdateData(Area2DAmbienceData data) {} // 0x00000001837BCBF0-0x00000001837BCCB0
	// [XID] // 0x00000001898E31C0-0x00000001898E31E0
	private void BuildData() {} // 0x00000001837BB180-0x00000001837BBEA0
	// [XID] // 0x0000000189739700-0x0000000189739720
	private void BinaryIndexedTree_Update(BitSet[] data, int index, int range, BitSet value) {} // 0x00000001837BCAB0-0x00000001837BCBF0
	// [XID] // 0x00000001898F2660-0x00000001898F2680
	private BitSet BinaryIndexTree_Query(BitSet[] data, int index, int range) => default; // 0x00000001837BB000-0x00000001837BB180
	// [XID] // 0x00000001898F9DA0-0x00000001898F9DC0
	public void Clear() {} // 0x00000001837BCD60-0x00000001837BD180
	// [XID] // 0x0000000189901800-0x0000000189901820
	public void SetEnabled(bool enabled) {} // 0x00000001837BCCB0-0x00000001837BCD60
	// [XID] // 0x0000000189908F10-0x0000000189908F30
	public int SamplePostion(ref BitSet result, ref Vector2 position) => default; // 0x00000001837BD6D0-0x00000001837BDA70
	// [XID] // 0x0000000189910470-0x0000000189910490
	public int SamplePostionPrimeWay(ref BitSet result, ref Vector2 position) => default; // 0x00000001837BC610-0x00000001837BC840
}

