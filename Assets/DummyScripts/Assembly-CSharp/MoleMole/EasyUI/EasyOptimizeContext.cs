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
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.EasyUI
{
	public sealed class EasyOptimizeContext : BaseEasyContext // TypeDefIndex: 28566
	{
		// Fields
		private List<UnityEventBase> _bindedEvents; // 0x20
		private MonoEasyOptimizeContext _mono; // 0x28
		private bool _hasCleared; // 0x30
		private InputField.OnChangeEvent emptyInputEvent; // 0x38
	
		// Constructors
		public EasyOptimizeContext() {} // Dummy constructor
		public EasyOptimizeContext(string name, GameObject go, MonoEasyOptimizeContext mono) {} // 0x0000000184D9A170-0x0000000184D9A340
	
		// Methods
		// [XID] // 0x0000000189BB92B0-0x0000000189BB92D0
		public override void ClearView() {} // 0x0000000184D99D60-0x0000000184D99EA0
		// [XID] // 0x0000000189BC1080-0x0000000189BC10A0
		private void UnbindView() {} // 0x0000000184D9A030-0x0000000184D9A170
		// [XID] // 0x0000000189BC8850-0x0000000189BC8870
		public EasyOptimizeContext BindOptimizeButton(string describeText, UnityAction callback, string buttonText = "Button" /* Metadata: 0x00B0D912 */) => default; // 0x0000000184D97BE0-0x0000000184D97F40
		// [IDTag] // 0x0000000189BD0050-0x0000000189BD0090
		// [XID] // 0x0000000189BD0050-0x0000000189BD0090
		public EasyOptimizeContext BindOptimizeToggle(string describeText, UnityAction<bool> callback, Action<Toggle> getInit = null, string toggleLabel = "Toggle" /* Metadata: 0x00B0D91C */) => default; // 0x0000000184D98C40-0x0000000184D98D90
		// [IDTag] // 0x0000000189BDA820-0x0000000189BDA860
		// [XID] // 0x0000000189BDA820-0x0000000189BDA860
		public EasyOptimizeContext BindOptimizeToggle(string describeText, UnityAction<bool> callback, bool isOnWhenInit, string toggleLabel = "Toggle" /* Metadata: 0x00B0D926 */) => default; // 0x0000000184D98AF0-0x0000000184D98C40
		// [XID] // 0x00000001895EA5F0-0x00000001895EA610
		private Toggle BuildOptimizeToggle(string describeText, UnityAction<bool> callback, string toggleLabel = "Toggle" /* Metadata: 0x00B0D930 */) => default; // 0x0000000184D99A10-0x0000000184D99D60
		// [IDTag] // 0x00000001895F1A90-0x00000001895F1AD0
		// [XID] // 0x00000001895F1A90-0x00000001895F1AD0
		public EasyOptimizeContext BindOptimizeInputField(string describeText, UnityAction<string> callback, Action<InputField> getInit = null) => default; // 0x0000000184D982A0-0x0000000184D983D0
		// [IDTag] // 0x00000001895FC280-0x00000001895FC2C0
		// [XID] // 0x00000001895FC280-0x00000001895FC2C0
		public EasyOptimizeContext BindOptimizeInputField(string describeText, UnityAction<string> callback, string textShownWhenInit) => default; // 0x0000000184D983D0-0x0000000184D98510
		// [XID] // 0x0000000189606A50-0x0000000189606A70
		private InputField BuildOptimizeInputField(string describeText, UnityAction<string> callback) => default; // 0x0000000184D98D90-0x0000000184D990C0
		// [IDTag] // 0x000000018960E390-0x000000018960E3D0
		// [XID] // 0x000000018960E390-0x000000018960E3D0
		public EasyOptimizeContext BindOptimizeSlider(string describeText, UnityAction<float> callback, Action<Slider> getInit = null) => default; // 0x0000000184D989C0-0x0000000184D98AF0
		// [IDTag] // 0x0000000189618DD0-0x0000000189618E10
		// [XID] // 0x0000000189618DD0-0x0000000189618E10
		public EasyOptimizeContext BindOptimizeSlider(string describeText, UnityAction<float> callback, float valueWhenInit) => default; // 0x0000000184D98880-0x0000000184D989C0
		// [XID] // 0x0000000189623040-0x0000000189623060
		private Slider BuildOptimizeSlider(string describeText, UnityAction<float> callback) => default; // 0x0000000184D996E0-0x0000000184D99A10
		// [XID] // 0x000000018962A850-0x000000018962A870
		public EasyOptimizeContext BindOptimizeDropdown(string describeText, UnityAction<int> callback, Action<Dropdown> getInit = null) => default; // 0x0000000184D97F40-0x0000000184D982A0
		// [IDTag] // 0x0000000189631F70-0x0000000189631FB0
		// [XID] // 0x0000000189631F70-0x0000000189631FB0
		public EasyOptimizeContext BindOptimizeSliderWithInput(string describeText, UnityAction<float> callbackSlider, Action<Slider> getInitSlider, UnityAction<string> callbackInput, Action<InputField> getInitInput) => default; // 0x0000000184D986B0-0x0000000184D98880
		// [IDTag] // 0x000000018963CBC0-0x000000018963CC00
		// [XID] // 0x000000018963CBC0-0x000000018963CC00
		public EasyOptimizeContext BindOptimizeSliderWithInput(string describeText, UnityAction<float> callbackSlider, float valueWhenInit) => default; // 0x0000000184D98510-0x0000000184D986B0
		// [XID] // 0x00000001896471A0-0x00000001896471C0
		private Slider BuildOptimizeSliderWithInput(string describeText, UnityAction<float> callbackSlider, UnityAction<string> callbackInput, out InputField input) {
			input = default;
			return default;
		} // 0x0000000184D990C0-0x0000000184D996E0
	}
}
