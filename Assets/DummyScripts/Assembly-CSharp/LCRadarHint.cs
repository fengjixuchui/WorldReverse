/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCRadarHint : LCBaseMarkable // TypeDefIndex: 11757
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected uint _configID; // 0x168
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _radius; // 0x16C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _reportTimeThreshold; // 0x170
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private float _lastReportTime; // 0x174
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected bool _isNear; // 0x178
	private float _offsetRadius; // 0x17C
	private Vector3 _offset; // 0x180

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018999C2D0-0x000000018999C2F0 */ get => default; } // 0x0000000183B99620-0x0000000183B996C0 
	public uint radarHintConfigID { /* [XID] */ /* 0x00000001899B30B0-0x00000001899B30D0 */ get => default; } // 0x0000000183B989F0-0x0000000183B98A90 
	public bool updatePosition { /* [XID] */ /* 0x0000000189A92C60-0x0000000189A92CA0 */ get; /* [XID] */ /* 0x00000001899D5240-0x00000001899D5280 */ set; } // 0x0000000183B98AF0-0x0000000183B98B50 0x0000000183B98DB0-0x0000000183B98E20
	public float areaRadius { /* [XID] */ /* 0x0000000189AA7950-0x0000000189AA7990 */ get; /* [XID] */ /* 0x0000000189AB2350-0x0000000189AB2390 */ private set; } // 0x0000000183B98D40-0x0000000183B98DB0 0x0000000183B98C70-0x0000000183B98CE0

	// Constructors
	public LCRadarHint() {} // 0x0000000183B995A0-0x0000000183B99620

	// Methods
	// [XID] // 0x000000018970C940-0x000000018970C960
	public virtual void Setup(RadarHintExcelConfig config, bool updatePosition = false /* Metadata: 0x00AEA79E */) {} // 0x0000000183B97F60-0x0000000183B98150
	// [XID] // 0x0000000189705210-0x0000000189705230
	public override void Init() {} // 0x0000000183B98B50-0x0000000183B98C70
	// [XID] // 0x0000000189ACBC90-0x0000000189ACBCB0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183B99480-0x0000000183B995A0
	// [XID] // 0x0000000189AD3690-0x0000000189AD36B0
	public override void OnDisable() {} // 0x0000000183B99220-0x0000000183B992D0
	// [XID] // 0x0000000189ADB130-0x0000000189ADB150
	public override void OnEnable() {} // 0x0000000183B992D0-0x0000000183B99390
	// [XID] // 0x00000001899C91E0-0x00000001899C9200
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000183B97EA0-0x0000000183B97F60
	// [XID] // 0x0000000189AEA350-0x0000000189AEA370
	public override void Destroy() {} // 0x0000000183B981B0-0x0000000183B98260
	// [XID] // 0x000000018970C8C0-0x000000018970C8E0
	protected override void CheckPosition() {} // 0x0000000183B98400-0x0000000183B98910
	// [XID] // 0x0000000189AF9860-0x0000000189AF9880
	private void CheckMarkState() {} // 0x0000000183B98F80-0x0000000183B99220
	// [XID] // 0x00000001899D80F0-0x00000001899D8110
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183B98910-0x0000000183B989F0
	// [XID] // 0x0000000189BC5130-0x0000000189BC5150
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000183B99390-0x0000000183B99480
	// [IDTag] // 0x0000000189B0FAD0-0x0000000189B0FB10
	// [XID] // 0x0000000189B0FAD0-0x0000000189B0FB10
	public virtual RadarHintType GetRadarHintType() => default; // 0x0000000183B98300-0x0000000183B983A0
	// [IDTag] // 0x0000000189B19DC0-0x0000000189B19E00
	// [XID] // 0x0000000189B19DC0-0x0000000189B19E00
	public static RadarHintType GetRadarHintType(uint configID) => default; // 0x0000000183B98260-0x0000000183B98300
}

