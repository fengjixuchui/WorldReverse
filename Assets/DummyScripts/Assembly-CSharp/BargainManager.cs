/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BargainManager : InLevelManager, INotifyInterface // TypeDefIndex: 20744
{
	// Fields
	private Dictionary<uint, BargainInstData> _bargainInstDataMap; // 0x10
	private Dictionary<uint, LCBaseInter> _interTargetMap; // 0x18
	private List<uint> _recycledBargainInst; // 0x20
	private uint _reqBarginId; // 0x28
	private LCBaseInter _reqInter; // 0x30
	private const float BARGAIN_GETDATA_TIMEOUT = 5f; // Metadata: 0x00AFE22D
	private Coroutine _getDataTimeoutCoroutine; // 0x38
	private Coroutine _bargainOfferTimeoutCoroutine; // 0x40
	private Action _bargainActionComplete; // 0x48
	private Action _closeBargainDialog; // 0x50
	private MonoLikingBar _monoLikingBar; // 0x58
	private GameObject _likingBarGO; // 0x60

	// Properties
	private MonoLikingBar monoLikingBar { /* [XID] */ /* 0x0000000189A67FB0-0x0000000189A67FD0 */ get => default; } // 0x000000018230C0D0-0x000000018230C280 

	// Constructors
	public BargainManager() {} // 0x000000018230E920-0x000000018230EA10

	// Methods
	// [XID] // 0x00000001899B38C0-0x00000001899B38E0
	public override void Init() {} // 0x000000018230C470-0x000000018230C6C0
	// [XID] // 0x00000001899BAD20-0x00000001899BAD40
	public bool OnNotify(Notify ntf) => default; // 0x000000018230E5A0-0x000000018230E7A0
	// [XID] // 0x00000001899C2730-0x00000001899C2750
	public override void Destroy() {} // 0x000000018230B640-0x000000018230B830
	// [XID] // 0x00000001899C9D40-0x00000001899C9D60
	public override void InitOnConnect() {} // 0x000000018230C3C0-0x000000018230C470
	// [XID] // 0x00000001899D15E0-0x00000001899D1600
	public override void ClearOnDisconnect() {} // 0x000000018230B190-0x000000018230B250
	// [XID] // 0x00000001899D8B50-0x00000001899D8B70
	public void GetBargainDataReq(uint bargainID, LCBaseInter inter) {} // 0x000000018230E430-0x000000018230E5A0
	// [XID] // 0x00000001899E0200-0x00000001899E0220
	private void HandleRequestBargainDataRsp(GetBargainDataRsp dataRsp) {} // 0x000000018230CB90-0x000000018230CF90
	// [XID] // 0x00000001899E7D00-0x00000001899E7D20
	public void ShowBargainDialog(uint bargainID, LCBaseInter inter) {} // 0x000000018230B360-0x000000018230B640
	// [XID] // 0x00000001899EF100-0x00000001899EF120
	private void HandleBargainPriceOfferRsp(BargainOfferPriceRsp rsp) {} // 0x000000018230B960-0x000000018230BC70
	[DebuggerHidden] // 0x00000001899F6AD0-0x00000001899F6B10
	// [XID] // 0x00000001899F6AD0-0x00000001899F6B10
	private IEnumerator DisplayBargainPriceOfferResult(BargainOfferPriceRsp rsp) => default; // 0x000000018230E800-0x000000018230E920
	// [XID] // 0x0000000189A00D10-0x0000000189A00D30
	private void HandleBargainPriceOfferRspPostMood(BargainOfferPriceRsp rsp) {} // 0x000000018230D8D0-0x000000018230DF60
	// [XID] // 0x0000000189A08650-0x0000000189A08670
	private void HandleGetAllActivatedBargainDataRsp(GetAllActivatedBargainDataRsp dataRsp) {} // 0x000000018230CF90-0x000000018230D320
	// [XID] // 0x0000000189A0FC10-0x0000000189A0FC30
	private void HandleBargainStartData(BargainStartNotify bargainData) {} // 0x000000018230BE50-0x000000018230C0D0
	// [XID] // 0x0000000189A17070-0x0000000189A17090
	private void RemoveBargainData(uint bargainID, bool delayHideLikingBar) {} // 0x000000018230E210-0x000000018230E360
	// [XID] // 0x0000000189A1E7E0-0x0000000189A1E800
	public void SendBargainPriceOfferReq(uint bargainID, uint price, LCBaseInter inter, Action closeBargainDialog) {} // 0x000000018230E070-0x000000018230E210
	// [XID] // 0x0000000189A25ED0-0x0000000189A25EF0
	public BargainInstData GetBargainInstData(uint bargainID) => default; // 0x000000018230CAA0-0x000000018230CB90
	// [XID] // 0x0000000189A2D2B0-0x0000000189A2D2D0
	public void RegisterBargainInter(uint bargainID, LCBaseInter inter) {} // 0x000000018230B830-0x000000018230B960
	// [XID] // 0x0000000189A34D30-0x0000000189A34D50
	public LCBaseInter GetBargainInter(uint bargainID) => default; // 0x000000018230C8A0-0x000000018230C990
	// [XID] // 0x0000000189AA6400-0x0000000189AA6420
	public bool IsBargainInstRecycled(uint bargainID) => default; // 0x000000018230E360-0x000000018230E430
	// [XID] // 0x0000000189A43D30-0x0000000189A43D50
	public void RegisterBargainDialogCallback(Action dialogCloseCallback) {} // 0x000000018230D320-0x000000018230D3D0
	[DebuggerHidden] // 0x0000000189A4B200-0x0000000189A4B240
	// [XID] // 0x0000000189A4B200-0x0000000189A4B240
	private IEnumerator BargainPriceOfferTimeout() => default; // 0x000000018230DF60-0x000000018230E070
	[DebuggerHidden] // 0x0000000189A55AC0-0x0000000189A55B00
	// [XID] // 0x0000000189A55AC0-0x0000000189A55B00
	private IEnumerator GetBargainDataTimeOut() => default; // 0x000000018230C990-0x000000018230CAA0
	// [XID] // 0x0000000189A60420-0x0000000189A60440
	private void InitLikingBar() {} // 0x000000018230C6C0-0x000000018230C8A0
	// [XID] // 0x0000000189A6F380-0x0000000189A6F3A0
	private void ClearLikingBar() {} // 0x000000018230C280-0x000000018230C360
	// [XID] // 0x0000000189A76BE0-0x0000000189A76C00
	public void ShowLikingBar(BaseEntity attachEntity, float fillValue, bool isWarning, string likingBarText, bool instFill, float delay = 0f /* Metadata: 0x00AFE228 */) {} // 0x000000018230BC70-0x000000018230BE50
	[DebuggerHidden] // 0x0000000189A7E580-0x0000000189A7E5C0
	// [XID] // 0x0000000189A7E580-0x0000000189A7E5C0
	private IEnumerator DelayActiveLikingBar(BaseEntity attachEntity, float fillValue, bool isWarning, string likingBarText, bool instFill, float delay) => default; // 0x000000018230D560-0x000000018230D710
	// [XID] // 0x0000000189A89130-0x0000000189A89150
	private void ShowLikingBarInternal(BaseEntity attachEntity, float fillValue, bool isWarning, string likingBarText, bool instFill) {} // 0x000000018230D710-0x000000018230D8D0
	// [XID] // 0x0000000189A90910-0x0000000189A90930
	public void HideLikingBar(bool hideAfterLerp = false /* Metadata: 0x00AFE22C */) {} // 0x000000018230D3D0-0x000000018230D560
	[DebuggerHidden] // 0x0000000189A98150-0x0000000189A98190
	// [XID] // 0x0000000189A98150-0x0000000189A98190
	private IEnumerator HideLikingBarAfterLerp() => default; // 0x000000018230B250-0x000000018230B360
}

