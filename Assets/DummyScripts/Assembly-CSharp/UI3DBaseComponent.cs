/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class UI3DBaseComponent : BaseContextComponent // TypeDefIndex: 31321
{
	// Fields
	public GameObject ui3DObj; // 0x30
	public MonoUI3D monoUI3D; // 0x38
	private Action _onUI3DSetupFinish; // 0x40
	private UI3DComponentState _loadState; // 0x48
	protected string _ui3DPrefabPath; // 0x50
	protected uint _ui3DContainerHandle; // 0x58
	protected bool _anyncLoad; // 0x5C

	// Constructors
	public UI3DBaseComponent() {} // 0x00000001842C6F30-0x00000001842C6FB0

	// Methods
	// [XID] // 0x00000001896EAA00-0x00000001896EAA20
	public void SetUI3DActive(bool enabled) {} // 0x00000001842C5D70-0x00000001842C5ED0
	// [XID] // 0x00000001896F1D00-0x00000001896F1D20
	public override void Init(GameObject view) {} // 0x00000001842C5BB0-0x00000001842C5CA0
	// [XID] // 0x00000001896F9730-0x00000001896F9750
	public void LoadUI3DPrefab(Action onUI3DSetupFinish) {} // 0x00000001842C5840-0x00000001842C5AB0
	// [XID] // 0x0000000189700F40-0x0000000189700F60
	private bool CheckUI3DHasLoaded(GameObject instantiated) => default; // 0x00000001842C5670-0x00000001842C5840
	// [XID] // 0x0000000189708680-0x00000001897086A0
	protected virtual void InistantiateUI3D(GameObject prefab) {} // 0x00000001842C5F30-0x00000001842C6120
	// [XID] // 0x000000018970FFF0-0x0000000189710010
	private void Setup() {} // 0x00000001842C5030-0x00000001842C51C0
	// [XID] // 0x0000000189717370-0x0000000189717390
	public override void Destroy() {} // 0x00000001842C5220-0x00000001842C53B0
	// [XID] // 0x000000018971EDF0-0x000000018971EE10
	protected virtual void InitUI3D() {} // 0x00000001842C4D60-0x00000001842C4E00
	// [XID] // 0x0000000189726390-0x00000001897263B0
	protected virtual void SetupUI3DView() {} // 0x00000001842C6120-0x00000001842C61E0
	// [XID] // 0x000000018972D990-0x000000018972D9B0
	protected virtual void PostSetupUI3DView() {} // 0x00000001842C5410-0x00000001842C54B0
	// [XID] // 0x0000000189735110-0x0000000189735130
	protected virtual void ClearUI3DView() {} // 0x00000001842C54B0-0x00000001842C5670
	// [XID] // 0x000000018973CBB0-0x000000018973CBD0
	public override void OnEnable() {} // 0x00000001842C6990-0x00000001842C6A90
	// [XID] // 0x0000000189744110-0x0000000189744130
	public override void OnDisable() {} // 0x00000001842C6890-0x00000001842C6990
	// [XID] // 0x000000018974BE30-0x000000018974BE50
	protected virtual void InitMonoUI3D() {} // 0x00000001842C4EA0-0x00000001842C4F50
	// [XID] // 0x00000001897530F0-0x0000000189753110
	protected virtual void EnableMonoUI3D() {} // 0x00000001842C6E50-0x00000001842C6F30
	// [XID] // 0x000000018975A460-0x000000018975A480
	protected virtual void DisableMonoUI3D() {} // 0x00000001842C4AE0-0x00000001842C4BD0
	// [XID] // 0x0000000189762140-0x0000000189762160
	protected virtual void SetCurrentCamera(Camera camera) {} // 0x00000001842C4BD0-0x00000001842C4D60
	// [XID] // 0x00000001897696B0-0x00000001897696D0
	public override void BindViewCallbacks() {} // 0x00000001842C4E00-0x00000001842C4EA0
	// [IDTag] // 0x0000000189770C70-0x0000000189770CB0
	// [XID] // 0x0000000189770C70-0x0000000189770CB0
	public void BindViewCallback(Button button, UnityAction callback) {} // 0x00000001842C6670-0x00000001842C6750
	// [XID] // 0x000000018977B280-0x000000018977B2A0
	public void BindViewContainerButtonCallback(MonoUIContainer container, UnityAction callback) {} // 0x00000001842C4F50-0x00000001842C5030
	// [IDTag] // 0x0000000189782DC0-0x0000000189782E00
	// [XID] // 0x0000000189782DC0-0x0000000189782E00
	public void BindViewCallback(InputField inputfield, UnityAction<string> callback) {} // 0x00000001842C61E0-0x00000001842C62C0
	// [IDTag] // 0x000000018978D1A0-0x000000018978D1E0
	// [XID] // 0x000000018978D1A0-0x000000018978D1E0
	public void BindViewCallback(Dropdown dropdown, UnityAction<int> callback) {} // 0x00000001842C63D0-0x00000001842C64B0
	// [IDTag] // 0x0000000189797BF0-0x0000000189797C30
	// [XID] // 0x0000000189797BF0-0x0000000189797C30
	public void BindViewCallback(Toggle toggle, UnityAction<bool> callback) {} // 0x00000001842C64B0-0x00000001842C6590
	// [IDTag] // 0x00000001897A2860-0x00000001897A28A0
	// [XID] // 0x00000001897A2860-0x00000001897A28A0
	public void BindViewCallback(Slider slider, UnityAction<float> callback) {} // 0x00000001842C6590-0x00000001842C6670
	// [IDTag] // 0x00000001897ACFE0-0x00000001897AD020
	// [XID] // 0x00000001897ACFE0-0x00000001897AD020
	public void BindViewCallback(Transform trans, UnityEngine.EventSystems.EventTriggerType eventType, Action<BaseEventData> callback, bool clearTriggers = false /* Metadata: 0x00B12189 */) {} // 0x00000001842C62C0-0x00000001842C63D0
	// [IDTag] // 0x00000001897B7CB0-0x00000001897B7CF0
	// [XID] // 0x00000001897B7CB0-0x00000001897B7CF0
	public void BindViewCallback(UnityEvent evt, UnityAction callback) {} // 0x00000001842C6750-0x00000001842C6830
	public void BindViewCallback<T0>(UnityEvent<T0> evt, UnityAction<T0> callback) {}
	// [IDTag] // 0x00000001897C28B0-0x00000001897C28F0
	// [XID] // 0x00000001897C28B0-0x00000001897C28F0
	public void UnbindViewCallback(Button button) {} // 0x00000001842C6B50-0x00000001842C6C10
	// [IDTag] // 0x00000001897CD3A0-0x00000001897CD3E0
	// [XID] // 0x00000001897CD3A0-0x00000001897CD3E0
	public void UnbindViewCallback(Dropdown dropdown) {} // 0x00000001842C6A90-0x00000001842C6B50
	// [IDTag] // 0x00000001897D8000-0x00000001897D8040
	// [XID] // 0x00000001897D8000-0x00000001897D8040
	public void UnbindViewCallback(InputField input) {} // 0x00000001842C6C10-0x00000001842C6CD0
	// [IDTag] // 0x00000001897E2320-0x00000001897E2360
	// [XID] // 0x00000001897E2320-0x00000001897E2360
	public void UnbindViewCallback(Toggle toggle) {} // 0x00000001842C6CD0-0x00000001842C6D90
	// [IDTag] // 0x00000001897ECE10-0x00000001897ECE50
	// [XID] // 0x00000001897ECE10-0x00000001897ECE50
	public void UnbindViewCallback(UnityEventBase evt) {} // 0x00000001842C6D90-0x00000001842C6E50
}

