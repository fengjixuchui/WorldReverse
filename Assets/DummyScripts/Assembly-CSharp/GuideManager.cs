/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GuideManager : InLevelManager, INotifyInterface // TypeDefIndex: 20824
{
	// Fields
	private List<ConfigGuideTask> checkGuidingList; // 0x10
	private List<ConfigGuideTask> guidingList; // 0x18
	private List<ConfigGuideCondition> tickConditionList; // 0x20
	private Dictionary<int, Dictionary<uint, List<string>>> notify2Task; // 0x28
	private Dictionary<int, List<ConfigGuideCondition>> notify2Conditions; // 0x30
	private bool _isPostInited; // 0x38
	private HashSet<NotifyTypes> _restartGuideNotifies; // 0x40

	// Constructors
	public GuideManager() {} // 0x00000001844882D0-0x0000000184488460

	// Methods
	// [XID] // 0x0000000189993C50-0x0000000189993C70
	public NotifyTypes GetNotifyByTriggerType(GuideTriggerType type) => default; // 0x0000000184484D80-0x0000000184484EA0
	// [XID] // 0x000000018999B4C0-0x000000018999B4E0
	public override void Init() {} // 0x0000000184485E90-0x0000000184486300
	// [XID] // 0x00000001899A2C50-0x00000001899A2C70
	public override void Tick() {} // 0x0000000184488160-0x00000001844882D0
	// [XID] // 0x00000001899AA6A0-0x00000001899AA6C0
	public void AddTickCondition(ConfigGuideCondition condition) {} // 0x00000001844863D0-0x00000001844864C0
	// [XID] // 0x00000001899B2000-0x00000001899B2020
	public void RemoveTickCondition(ConfigGuideCondition condition) {} // 0x0000000184485DA0-0x0000000184485E90
	// [XID] // 0x00000001899B9460-0x00000001899B9480
	private void Clear() {} // 0x0000000184485440-0x00000001844854F0
	// [XID] // 0x00000001899C0E50-0x00000001899C0E70
	private void ClearGuideContexts() {} // 0x0000000184487600-0x0000000184487960
	// [XID] // 0x00000001899C8410-0x00000001899C8430
	public override void ClearOnDisconnect() {} // 0x0000000184484CE0-0x0000000184484D80
	// [XID] // 0x00000001899CFE90-0x00000001899CFEB0
	public override void Destroy() {} // 0x0000000184484EA0-0x0000000184484FC0
	// [XID] // 0x00000001899D73B0-0x00000001899D73D0
	private bool IsEqual(float a, float b) => default; // 0x0000000184486D50-0x0000000184486E20
	// [XID] // 0x00000001899DE750-0x00000001899DE770
	private bool BigThan(float a, float b) => default; // 0x0000000184486300-0x00000001844863D0
	// [XID] // 0x00000001899E6450-0x00000001899E6470
	private bool LessThan(float a, float b) => default; // 0x0000000184486B60-0x0000000184486C30
	// [XID] // 0x00000001899ED9A0-0x00000001899ED9C0
	private void CheckGuideByNotifyDict(NotifyTypes notifyType, Dictionary<uint, List<string>> dict, bool isInit, object body = null) {} // 0x0000000184484630-0x0000000184484BE0
	// [XID] // 0x00000001899F5390-0x00000001899F53B0
	public void PostInit() {} // 0x00000001844864C0-0x0000000184486700
	// [XID] // 0x00000001899FC9D0-0x00000001899FC9F0
	public bool OnNotify(Notify ntf) => default; // 0x0000000184487960-0x0000000184487B80
	// [XID] // 0x0000000189A03EE0-0x0000000189A03F00
	private void CheckRestartGuideNotify(Notify ntf) {} // 0x0000000184487510-0x0000000184487600
	// [XID] // 0x0000000189A0B5B0-0x0000000189A0B5D0
	private void RestartGuide() {} // 0x0000000184485830-0x0000000184485DA0
	// [XID] // 0x0000000189A12D10-0x0000000189A12D30
	private bool CheckFreshManTask(ConfigGuideTask task) => default; // 0x0000000184484FC0-0x00000001844850F0
	// [XID] // 0x0000000189A1A0D0-0x0000000189A1A0F0
	public bool StartGuide(string name, string rootTask = null) => default; // 0x00000001844854F0-0x0000000184485830
	// [XID] // 0x0000000189A21610-0x0000000189A21630
	private void DoTaskAfterPredicate(ConfigGuideTask task) {} // 0x00000001844873A0-0x0000000184487510
	// [XID] // 0x0000000189A28C10-0x0000000189A28C30
	public void CheckTasks() {} // 0x0000000184486700-0x0000000184486970
	// [XID] // 0x0000000189A302B0-0x0000000189A302D0
	private bool CheckTaskFinish(ConfigGuideTask task) => default; // 0x0000000184486E20-0x0000000184487010
	// [XID] // 0x0000000189A37D10-0x0000000189A37D30
	public bool EndGuide(string name, bool doAction = false /* Metadata: 0x00AFE5A4 */) => default; // 0x0000000184487010-0x00000001844873A0
	// [XID] // 0x0000000189A3F440-0x0000000189A3F460
	private bool CheckCondition(ConfigGuideCondition[] conditions) => default; // 0x0000000184488050-0x0000000184488160
	// [XID] // 0x0000000189A46A50-0x0000000189A46A70
	private void FinishCondition(ConfigGuideCondition[] conditions) {} // 0x0000000184486A60-0x0000000184486B60
	// [XID] // 0x0000000189A4E210-0x0000000189A4E230
	private void PrepareCondition(ConfigGuideCondition[] conditions) {} // 0x0000000184484BE0-0x0000000184484CE0
	// [XID] // 0x0000000189A55A80-0x0000000189A55AA0
	public void DoGuideAction(ConfigGuideAction[] actions, ConfigGuideTask task) {} // 0x0000000184487EE0-0x0000000184487FF0
	// [XID] // 0x0000000189A5D2C0-0x0000000189A5D2E0
	public void DoFullAction(ConfigGuideAction[] actions, ConfigGuideTask task) {} // 0x0000000184486C30-0x0000000184486D50
	// [XID] // 0x0000000189A64C20-0x0000000189A64C40
	private void StopGuideAction(ConfigGuideAction[] actions) {} // 0x0000000184486970-0x0000000184486A60
	// [XID] // 0x0000000189A6C420-0x0000000189A6C440
	public void RegisterNotifyList(NotifyTypes[] list, ConfigGuideCondition condition) {} // 0x00000001844850F0-0x00000001844853E0
	// [XID] // 0x0000000189A73BD0-0x0000000189A73BF0
	public void UnregisterNotifyList(NotifyTypes[] list, ConfigGuideCondition condition) {} // 0x0000000184487B80-0x0000000184487EE0
}

