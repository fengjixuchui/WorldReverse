/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 56: NativeEdit.dll - Assembly: NativeEdit, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6676-6688

// [RequireComponent] // 0x0000000189A43460-0x0000000189A434B0
public class NativeEditBox : PluginMsgReceiver // TypeDefIndex: 6682
{
	// Fields
	public float androidUpdateDeltaTime; // 0x20
	public bool iOSWithDoneButton; // 0x24
	public bool useInputFieldFont; // 0x25
	public bool clearFocusOnReturnPressed; // 0x26
	public ReturnKeyType singleLineReturnKeyType; // 0x28
	public UnityEvent onReturnPressed; // 0x38
	public UnityEvent onBeginEdit; // 0x40
	public UnityEvent onEndEdit; // 0x48
	public UnityEvent onLayoutChanged; // 0x50
	private bool _hasNativeEditCreated; // 0x58
	private UnityEngine.UI.Text _textComponent; // 0x60
	private bool _focusOnCreate; // 0x68
	private bool _visibleOnCreate; // 0x69
	private EditBoxConfig _mConfig; // 0x70
	private Camera _uiCam; // 0xD8
	private RenderMode _renderMode; // 0xE0
	private const string MSG_CREATE = "CreateEdit"; // Metadata: 0x00ADDA17
	private const string MSG_REMOVE = "RemoveEdit"; // Metadata: 0x00ADDA25
	private const string MSG_SET_TEXT = "SetText"; // Metadata: 0x00ADDA33
	private const string MSG_SET_RECT = "SetRect"; // Metadata: 0x00ADDA3E
	private const string MSG_SET_TEXTSIZE = "SetTextSize"; // Metadata: 0x00ADDA49
	private const string MSG_SET_FOCUS = "SetFocus"; // Metadata: 0x00ADDA58
	private const string MSG_SET_VISIBLE = "SetVisible"; // Metadata: 0x00ADDA64
	private const string MSG_TEXT_CHANGE = "TextChange"; // Metadata: 0x00ADDA72
	private const string MSG_TEXT_BEGIN_EDIT = "TextBeginEdit"; // Metadata: 0x00ADDA80
	private const string MSG_TEXT_END_EDIT = "TextEndEdit"; // Metadata: 0x00ADDA91
	private const string MSG_ANDROID_KEY_DOWN = "AndroidKeyDown"; // Metadata: 0x00ADDAA0
	private const string MSG_RETURN_PRESSED = "ReturnPressed"; // Metadata: 0x00ADDAB2
	private const string MSG_GET_TEXT = "GetText"; // Metadata: 0x00ADDAC3
	private const string MSG_GET_HEIGHT = "GetHeight"; // Metadata: 0x00ADDACE
	public float heightRatio; // 0xF4

	// Properties
	public InputField inputField { get; private set; } // 0x000000018950A030-0x000000018950A090 0x000000018950A270-0x000000018950A2E0
	public bool visible { get; private set; } // 0x000000018950A140-0x000000018950A1A0 0x000000018950A3B0-0x000000018950A420
	public string text { get => default; set {} } // 0x000000018950A090-0x000000018950A140 0x000000018950A2E0-0x000000018950A3B0

	// Events
	public event Action returnPressed;

	// Nested types
	private struct EditBoxConfig // TypeDefIndex: 6683
	{
		// Fields
		public bool multiline; // 0x00
		public Color textColor; // 0x04
		public Color backColor; // 0x14
		public string contentType; // 0x28
		public string font; // 0x30
		public float fontSize; // 0x38
		public string align; // 0x40
		public string placeHolder; // 0x48
		public int characterLimit; // 0x50
		public Color placeHolderColor; // 0x54
	}

	public enum ReturnKeyType // TypeDefIndex: 6684
	{
		Default = 0,
		Next = 1,
		Done = 2,
		Send = 3,
		Go = 4
	}

	// Constructors
	public NativeEditBox() {} // 0x0000000189509EA0-0x0000000189509F60

	// Methods
	public float GetKeyboardHeightRatio() => default; // 0x0000000189508770-0x00000001895087E0
	private void Awake() {} // 0x0000000189507D80-0x0000000189507FE0
	private void InitCanvas() {} // 0x0000000189508BA0-0x0000000189508D40
	protected override void Start() {} // 0x0000000189509D80-0x0000000189509DE0
	private void OnEnable() {} // 0x0000000189508FC0-0x0000000189509030
	private void OnDisable() {} // 0x0000000189508F50-0x0000000189508FC0
	protected override void OnDestroy() {} // 0x0000000189508E90-0x0000000189508F50
	public void TryRmoveNative() {} // 0x0000000189509DE0-0x0000000189509E50
	private void OnApplicationPause(bool pause) {} // 0x0000000189508E10-0x0000000189508E90
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator InitializeOnNextFrame() => default; // 0x0000000189508D40-0x0000000189508E10
	private void Update() {} // 0x0000000189509E50-0x0000000189509EA0
	private Rect GetScreenRectFromRectTransform(RectTransform rectTransform) => default; // 0x0000000189508930-0x0000000189508BA0
	private float GetNativeFontSize() => default; // 0x00000001895087E0-0x0000000189508930
	private void PrepareNativeEdit() {} // 0x00000001895091C0-0x00000001895095C0
	public override void OnPluginMsgDirect(JsonObject jsonMsg) {} // 0x0000000189509030-0x00000001895090E0
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator PluginsMessageRoutine(JsonObject jsonMsg) => default; // 0x00000001895090E0-0x00000001895091C0
	private bool CheckErrorJsonRet(JsonObject jsonRet) => default; // 0x0000000189507FE0-0x00000001895080F0
	private void CreateNativeEdit() {} // 0x00000001895080F0-0x0000000189508770
	private void SetTextNative(string newText) {} // 0x0000000189509A00-0x0000000189509B20
	private void RemoveNative() {} // 0x00000001895095C0-0x0000000189509670
	public void SetRectNative(RectTransform rectTrans) {} // 0x00000001895097C0-0x0000000189509A00
	public void SetTextSize() {} // 0x0000000189509B20-0x0000000189509C40
	public void SetFocus(bool bFocus) {} // 0x0000000189509670-0x00000001895097C0
	public void SetVisible(bool bVisible) {} // 0x0000000189509C40-0x0000000189509D80
}

