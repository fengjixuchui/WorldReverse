/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCBaseEquipController : VCBase // TypeDefIndex: 11811
{
	// Fields
	protected List<EquipContent> _equipList; // 0x108
	private bool _isDestoied; // 0x110
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public bool isManekinEquip; // 0x111
	[NonSerialized]
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	protected VCBaseMove _moveComponent; // 0x118
	private Vector3 offsetPosition; // 0x120
	private Vector3 sheathPointInitPosition; // 0x12C
	private Vector3 parentInitPosition; // 0x138
	private Quaternion withOffsetRotation; // 0x144
	private Quaternion parentInitRotation; // 0x154
	[NonSerialized]
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	private VCHeadController _headController; // 0x168
	private LCBaseEquipController _lcBaseEquipController; // 0x170
	protected Dictionary<string, string> _forceAttachPointRealName; // 0x178
	private VCHumanoidMove _humanoidMoveComponent; // 0x180
	private static AnimationCurve _weaponAnimcurve; // 0x00
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public float CLAMP_ANGLE; // 0x188
	public EquipSizeData[] equipSizeDatas; // 0x190

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018988C840-0x000000018988C860 */ get => default; } // 0x0000000180E57960-0x0000000180E57A00 

	// Constructors
	public VCBaseEquipController() {} // 0x0000000180E578C0-0x0000000180E57960
	static VCBaseEquipController() {} // 0x0000000180E57580-0x0000000180E578C0

	// Methods
	// [XID] // 0x00000001897FBC80-0x00000001897FBCA0
	public override void Init() {} // 0x0000000180E54470-0x0000000180E54BD0
	// [XID] // 0x00000001899495F0-0x0000000189949610
	public virtual void InitScale() {} // 0x0000000180E57410-0x0000000180E574B0
	// [XID] // 0x000000018980A5E0-0x000000018980A600
	public override void Destroy() {} // 0x0000000180E53510-0x0000000180E535E0
	// [XID] // 0x00000001898A2910-0x00000001898A2930
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000180E51590-0x0000000180E51660
	// [XID] // 0x00000001898B1850-0x00000001898B1870
	protected override void LateTick(float inDeltaTime) {} // 0x0000000180E56460-0x0000000180E56620
	// [XID] // 0x0000000189821110-0x0000000189821130
	public override void OnEnable() {} // 0x0000000180E57350-0x0000000180E57410
	// [XID] // 0x00000001898C0820-0x00000001898C0840
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000180E574B0-0x0000000180E57580
	// [XID] // 0x000000018982F970-0x000000018982F990
	protected virtual void ResetInternal() {} // 0x0000000180E535E0-0x0000000180E537A0
	// [XID] // 0x0000000189837250-0x0000000189837270
	public bool Attach(ulong guid, GadgetEntity equipEntity, string name, string equipPart, GadgetEntity subEquipEntity, string subName, string subEquipPart) => default; // 0x0000000180E53110-0x0000000180E533F0
	// [XID] // 0x000000018983E7D0-0x000000018983E7F0
	public bool Detach(ulong guid, bool detachOnly = false /* Metadata: 0x00AEAC10 */) => default; // 0x0000000180E56620-0x0000000180E568F0
	// [XID] // 0x0000000189845E50-0x0000000189845E70
	public bool DetachItemByID(uint entityID) => default; // 0x0000000180E51660-0x0000000180E518F0
	// [XID] // 0x000000018984D400-0x000000018984D420
	public virtual void SetVisible(bool visible) {} // 0x0000000180E537A0-0x0000000180E539F0
	// [XID] // 0x000000018995FC50-0x000000018995FC70
	public virtual void SetForceAttachPointRealName(string partName, string realName) {} // 0x0000000180E510A0-0x0000000180E51250
	// [XID] // 0x0000000189B9E2F0-0x0000000189B9E310
	protected void RefresTrans(string partName) {} // 0x0000000180E56B30-0x0000000180E56CF0
	// [XID] // 0x000000018997D680-0x000000018997D6A0
	public virtual void SetAuxTransEnable(string name, bool setEnable) {} // 0x0000000180E533F0-0x0000000180E534B0
	// [XID] // 0x0000000189985240-0x0000000189985260
	public virtual void PlaceEquip(string name, bool place, Vector3 pos, Quaternion rot) {} // 0x0000000180E56130-0x0000000180E56240
	// [XID] // 0x0000000189871E10-0x0000000189871E30
	public void ShowEquip(string name, bool show) {} // 0x0000000180E506B0-0x0000000180E509B0
	// [XID] // 0x00000001896EBFD0-0x00000001896EBFF0
	public bool ChangeItemPart(ulong guid, string orgPart, string destPart, string subOrgPart, string subDestPart) => default; // 0x0000000180E539F0-0x0000000180E53DA0
	// [XID] // 0x0000000189BBEB30-0x0000000189BBEB50
	protected EquipContent GetEquipContentByGuid(ulong guid) => default; // 0x0000000180E55C20-0x0000000180E55DF0
	// [XID] // 0x0000000189883810-0x0000000189883830
	public EquipContent GetEquipContentByRuntimeID(uint runtimeID) => default; // 0x0000000180E568F0-0x0000000180E56AC0
	// [XID] // 0x000000018988F5A0-0x000000018988F5C0
	protected virtual EquipContent AttachEquipContent(ulong guid, GadgetEntity equipEntity, string name, string equipPart, VCBaseEquipController vcEquip) => default; // 0x0000000180E55600-0x0000000180E55BC0
	// [XID] // 0x00000001896B0B40-0x00000001896B0B60
	private void InitAuxTransPostEntityReady(EvtEntityReadyPost evt) {} // 0x0000000180E50AF0-0x0000000180E50D70
	// [XID] // 0x0000000189BD2A30-0x0000000189BD2A50
	private void InitPutPointContent(EquipContent content) {} // 0x0000000180E55350-0x0000000180E55600
	// [XID] // 0x00000001898A5930-0x00000001898A5950
	public GadgetEntity GetGadgetEntity(string equipPart) => default; // 0x0000000180E53E40-0x0000000180E540A0
	// [XID] // 0x00000001898ACE60-0x00000001898ACE80
	public List<EquipContent> GetEquipList() => default; // 0x0000000180E56D60-0x0000000180E56E10
	// [XID] // 0x00000001899C1D40-0x00000001899C1D60
	public ulong GetPartGuid(string equipPart) => default; // 0x0000000180E55DF0-0x0000000180E56000
	// [XID] // 0x00000001898BC210-0x00000001898BC230
	public virtual void EquipLoadFinishCallback(BaseEntity baseEntity) {} // 0x0000000180E50FF0-0x0000000180E510A0
	// [XID] // 0x00000001899F3280-0x00000001899F32A0
	public void OnDrop(BaseEntity baseEntity) {} // 0x0000000180E572A0-0x0000000180E57350
	// [XID] // 0x00000001898CAF30-0x00000001898CAF50
	public void OnPick(BaseEntity baseEntity) {} // 0x0000000180E50A10-0x0000000180E50AF0
	// [XID] // 0x00000001898D25F0-0x00000001898D2610
	public ConfigBladeElementFx GetDefaultWeaponBladeElementFx() => default; // 0x0000000180E56240-0x0000000180E56460
	// [XID] // 0x00000001898D9F30-0x00000001898D9F50
	public static VCBaseEquipController GetSelfOrOwnerEquipController(BaseEntity entity) => default; // 0x0000000180E51250-0x0000000180E51390
	// [XID] // 0x00000001898E1AC0-0x00000001898E1AE0
	public ElementType GetCurWeaponElementType() => default; // 0x0000000180E54C70-0x0000000180E551B0
	// [XID] // 0x00000001898E9850-0x00000001898E9870
	protected virtual void UpdateEquipPartToAttachPoint(float deltaTime, EquipContent equipContent, bool with) {} // 0x0000000180E51970-0x0000000180E53110
	// [XID] // 0x00000001898F0D80-0x00000001898F0DA0
	protected virtual bool EnableFollowRotation() => default; // 0x0000000180E53DA0-0x0000000180E53E40
	// [XID] // 0x00000001898F8740-0x00000001898F8760
	protected virtual bool FollowRotationClosely() => default; // 0x0000000180E54BD0-0x0000000180E54C70
	// [XID] // 0x00000001898FFF80-0x00000001898FFFA0
	private void UpdateBreathAnimTime(float deltaTime, EquipContent equipContent) {} // 0x0000000180E51390-0x0000000180E51590
	// [XID] // 0x00000001899076C0-0x00000001899076E0
	private Vector3 GetBreathAnimPos(EquipContent equipContent) => default; // 0x0000000180E540A0-0x0000000180E54210
	// [XID] // 0x000000018990F010-0x000000018990F030
	protected virtual bool DetachPartFromAttachPoint(EquipContent equipPart) => default; // 0x0000000180E50DE0-0x0000000180E50FF0
	// [XID] // 0x00000001899168A0-0x00000001899168C0
	protected virtual string GetAttachPointRealName(string partName) => default; // 0x0000000180E57070-0x0000000180E572A0
	// [XID] // 0x00000001896AE190-0x00000001896AE1B0
	private string GetPutPointRealName() => default; // 0x0000000180E56000-0x0000000180E56130
	// [XID] // 0x0000000189925940-0x0000000189925960
	public Transform GetAttachTransform(string partName) => default; // 0x0000000180E551B0-0x0000000180E55350
	// [XID] // 0x000000018992CE10-0x000000018992CE30
	protected bool IsPutPoint(string part) => default; // 0x0000000180E50590-0x0000000180E506B0
	// [XID] // 0x0000000189679F40-0x0000000189679F60
	private float GetPutAwayScale(GadgetEntity equipEntity) => default; // 0x0000000180E54210-0x0000000180E54470
	// [XID] // 0x000000018993C030-0x000000018993C050
	private float GetTakeOutScale(GadgetEntity equipEntity) => default; // 0x0000000180E56E10-0x0000000180E57070
}

