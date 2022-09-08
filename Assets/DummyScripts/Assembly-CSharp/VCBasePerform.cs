/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCBasePerform : VCBase // TypeDefIndex: 11825
{
	// Fields
	protected VCBaseMove _vcMove; // 0x108
	protected bool delayHandleSitDown; // 0x110
	protected Vector3 delayHandlePos; // 0x114
	protected long delayHandleID; // 0x120
	private Vector3? _fixedPerformPosition; // 0x128
	private Quaternion? _fixedPerformRotation; // 0x138
	protected IChair _sitChair; // 0x150
	protected int _sitPointIndex; // 0x158
	protected bool _isSit; // 0x15C
	private SceneChairConfig.SitDirection _sitDirection; // 0x160

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B7F320-0x0000000189B7F340 */ get => default; } // 0x00000001830752A0-0x0000000183075340 
	public IChair sitChair { /* [XID] */ /* 0x0000000189BC9830-0x0000000189BC9850 */ get => default; } // 0x00000001830736E0-0x0000000183073790 
	public int sitPointIndex { /* [XID] */ /* 0x0000000189BD0FF0-0x0000000189BD1010 */ get => default; } // 0x00000001830749E0-0x0000000183074A80 
	public bool IsSit { /* [XID] */ /* 0x0000000189B15690-0x0000000189B156B0 */ get => default; } // 0x0000000183072C10-0x0000000183072CC0 
	public SceneChairConfig.SitDirection sitDirection { /* [XID] */ /* 0x00000001895ECBC0-0x00000001895ECBE0 */ get => default; } // 0x00000001830730B0-0x0000000183073150 

	// Constructors
	public VCBasePerform() {} // 0x0000000183075210-0x00000001830752A0

	// Methods
	// [XID] // 0x0000000189B86ED0-0x0000000189B86EF0
	protected override void Tick(float inDeltaTime) {} // 0x0000000183075120-0x0000000183075210
	// [XID] // 0x0000000189A3EAF0-0x0000000189A3EB10
	public override void Init() {} // 0x0000000183073D90-0x0000000183073E50
	// [XID] // 0x0000000189B954E0-0x0000000189B95500
	public override void Destroy() {} // 0x0000000183073000-0x00000001830730B0
	// [XID] // 0x0000000189B859A0-0x0000000189B859C0
	public virtual void DoPerform(int performID, float performParam, bool fixedPerformTrans) {} // 0x0000000183072CC0-0x0000000183072EB0
	// [XID] // 0x00000001897BC8B0-0x00000001897BC8D0
	public virtual void SetupVCMove(bool enableCollision) {} // 0x0000000183072B60-0x0000000183072C10
	// [XID] // 0x0000000189B2D1F0-0x0000000189B2D210
	public virtual void SetupRigidbody(bool enable) {} // 0x0000000183074D80-0x0000000183074E30
	// [XID] // 0x000000018960AE00-0x000000018960AE20
	public virtual void CancelPerform() {} // 0x0000000183072A60-0x0000000183072B00
	// [XID] // 0x0000000189BBA160-0x0000000189BBA180
	public void EnterPerformMove() {} // 0x0000000183074860-0x00000001830749E0
	// [XID] // 0x00000001897D2DC0-0x00000001897D2DE0
	private void CheckPerformStatus() {} // 0x0000000183073BF0-0x0000000183073C90
	// [XID] // 0x0000000189B8C870-0x0000000189B8C890
	public void SetSitChair(IChair chair, int index, SceneChairConfig.SitDirection sitDirection) {} // 0x0000000183073E50-0x0000000183073F30
	// [XID] // 0x00000001895F4250-0x00000001895F4270
	public static long pos2id(Vector3 vec) => default; // 0x0000000183074AF0-0x0000000183074C60
	// [XID] // 0x0000000189B43C10-0x0000000189B43C30
	public static Vector3 id2pos(long id) => default; // 0x0000000183072EB0-0x0000000183073000
	// [XID] // 0x00000001896031C0-0x00000001896031E0
	public virtual void TrySitOnChair(SceneChairConfig.SitDirection? direction = default) {} // 0x0000000183073790-0x0000000183073AE0
	// [XID] // 0x0000000189B4B1C0-0x0000000189B4B1E0
	public void RemoteSitOnChair(Vector3 position, long chairID) {} // 0x00000001830746D0-0x0000000183074860
	// [XID] // 0x00000001896121B0-0x00000001896121D0
	public void DoAuthoritySitOnChairRsp(Vector3 position, long chairID) {} // 0x0000000183074E30-0x0000000183074FC0
	// [XID] // 0x0000000189B529C0-0x0000000189B529E0
	public void AuthoritySitOnChairRsp(Vector3 position, long chairID) {} // 0x0000000183073C90-0x0000000183073D90
	// [XID] // 0x0000000189B67D30-0x0000000189B67D50
	private void CommonSitOnChair(Vector3 position, SceneChairConfig.SitDirection? direction) {} // 0x00000001830740B0-0x0000000183074250
	// [XID] // 0x0000000189B766E0-0x0000000189B76700
	protected virtual bool DoSitChairPerform(IChair chair, SceneChairConfig.SitDownData sitData) => default; // 0x0000000183073390-0x00000001830736E0
	// [XID] // 0x00000001897B4980-0x00000001897B49A0
	public virtual void TryStandFromChair(float? angle = default) {} // 0x0000000183073150-0x0000000183073310
	// [XID] // 0x0000000189B5A400-0x0000000189B5A420
	public void RemoteStandFromChair(SceneChairConfig.SitDirection direction, int performID) {} // 0x0000000183074250-0x0000000183074350
	// [XID] // 0x00000001897E1F20-0x00000001897E1F40
	protected virtual void CommonStandFromChair(SceneChairConfig.SitDirection sitDirection) {} // 0x0000000183073AE0-0x0000000183073BF0
	// [XID] // 0x0000000189B6EFA0-0x0000000189B6EFC0
	public void ClearChair() {} // 0x0000000183073F30-0x00000001830740B0
	// [XID] // 0x000000018964E000-0x000000018964E020
	private void CheckChairOccupiedByEntity() {} // 0x0000000183074C60-0x0000000183074D80
	// [XID] // 0x00000001896558D0-0x00000001896558F0
	public bool OccupiedChair(IChair chair) => default; // 0x0000000183075060-0x0000000183075120
	// [XID] // 0x000000018965D0C0-0x000000018965D0E0
	public virtual void NotifySitEnd() {} // 0x0000000183074350-0x00000001830743F0
	// [XID] // 0x0000000189664670-0x0000000189664690
	public virtual void NotifySitStart() {} // 0x0000000183074FC0-0x0000000183075060
	// [XID] // 0x000000018966BCD0-0x000000018966BCF0
	public void ForceSitOnChair(IChair chair, int index, SceneChairConfig.SitDirection enterDirection) {} // 0x0000000183074450-0x00000001830746D0
}

