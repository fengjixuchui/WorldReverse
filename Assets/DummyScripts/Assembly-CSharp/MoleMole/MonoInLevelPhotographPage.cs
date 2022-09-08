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
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInLevelPhotographPage : MonoUIProxy // TypeDefIndex: 29753
	{
		// Fields
		public MonoSliderWithButton sliderWithButton; // 0x40
		public Button close; // 0x48
		public Button btnSetUp; // 0x50
		public Button btnAct; // 0x58
		public Button btnEmotion; // 0x60
		public Button btnReset; // 0x68
		public Button btnTakePhotograph; // 0x70
		public MonoUIContainer btnBackSetup; // 0x78
		public MonoUIContainer btnBackPose; // 0x80
		public MonoUIContainer btnBackToMain; // 0x88
		public GameObject grpSetUp; // 0x90
		public GameObject grpAct; // 0x98
		public GameObject grpEmotion; // 0xA0
		public GameObject grpTab; // 0xA8
		public Toggle hideToggle; // 0xB0
		public GameObject grpMain; // 0xB8
		public static readonly int Slider_shift; // 0x00
		public static readonly int Slider_dofDis; // 0x04
		public static readonly int Slider_dofAmount; // 0x08
		public MonoUIContainer[] setupUIContainerSlider; // 0xC0
		public MonoGridScroller scrollerPose; // 0xC8
		public MonoGridScroller scrollerEmotion; // 0xD0
		public MonoScrollRectExtention scrollerRectAct; // 0xD8
		public MonoScrollRectExtention scrollerRectEmot; // 0xE0
		public GameObject[] toHideJoypad; // 0xE8
		public MonoUIContainer[] toHideBtnPC; // 0xF0
		public MonoHybridScrollerJoypadHelper setupJoyPadHelper; // 0xF8
		public GameObject[] toHideOnPS4; // 0x100
		public GameObject PS4Res; // 0x108
		public GameObject[] dofRelated; // 0x110
		public MonoInLevelPhotographDirection directionBtnPanel; // 0x118
		public MonoInLevelPhotographUnlockPanel posePanel; // 0x120
		public MonoInLevelPhotographUnlockPanel emotionPanel; // 0x128
		public UnityEngine.UI.Text photographTaskTipStart; // 0x130
		public UnityEngine.UI.Text photographTaskTipFinish; // 0x138
		public static readonly int Toggle_dof; // 0x0C
		public static readonly int Toggle_faceyou; // 0x10
		public static readonly int Toggle_hideme; // 0x14
		public static readonly int Toggle_hideInfo; // 0x18
		public MonoUIContainer[] setupUIContainerToggle; // 0x140
		private PhotographStates _currState; // 0x148
		public Animator hint1; // 0x150
		public Animator hint2; // 0x158
		private bool hint1Shown; // 0x160
		private bool hint2Shown; // 0x161
		private Coroutine _coroutine; // 0x168
	
		// Properties
		public MonoUIContainer btnSetUpContainer { /* [XID] */ /* 0x000000018984F2C0-0x000000018984F2E0 */ get => default; } // 0x0000000183D6F5F0-0x0000000183D6F6A0 
		public MonoUIContainer btnPoseContainer { /* [XID] */ /* 0x0000000189856420-0x0000000189856440 */ get => default; } // 0x0000000183D6F540-0x0000000183D6F5F0 
		public MonoUIContainer btnEmotionContainer { /* [XID] */ /* 0x000000018985D810-0x000000018985D830 */ get => default; } // 0x0000000183D6F490-0x0000000183D6F540 
		public PhotographStates CurrState { /* [XID] */ /* 0x0000000189873AE0-0x0000000189873B00 */ get => default; } // 0x0000000183D6F3F0-0x0000000183D6F490 
	
		// Nested types
		public enum PhotographStates // TypeDefIndex: 29754
		{
			main = 0,
			setting = 1,
			pose = 2,
			emotion = 3,
			noUI = 4
		}
	
		// Constructors
		public MonoInLevelPhotographPage() {} // 0x0000000183D6F370-0x0000000183D6F3F0
		static MonoInLevelPhotographPage() {} // 0x0000000183D6F290-0x0000000183D6F370
	
		// Methods
		// [XID] // 0x0000000189865130-0x0000000189865150
		public Slider SetupGetSlider(int index) => default; // 0x0000000183D6E900-0x0000000183D6EA50
		// [XID] // 0x000000018986C690-0x000000018986C6B0
		public Toggle SetupGetToggle(int index) => default; // 0x0000000183D6EA50-0x0000000183D6EBE0
		// [XID] // 0x000000018987B570-0x000000018987B590
		public void SetStates(PhotographStates state) {} // 0x0000000183D6DDC0-0x0000000183D6E900
		// [XID] // 0x00000001898826F0-0x0000000189882710
		public void ToggleHideBtn(bool show) {} // 0x0000000183D6EF60-0x0000000183D6F100
		// [XID] // 0x0000000189889EE0-0x0000000189889F00
		public void ToggleMainJoypadButton(bool show) {} // 0x0000000183D6F100-0x0000000183D6F290
		// [XID] // 0x0000000189891340-0x0000000189891360
		public void RefreshForPS4() {} // 0x0000000183D6DC70-0x0000000183D6DDC0
		// [XID] // 0x0000000189898950-0x0000000189898970
		public void ClearCoroutine() {} // 0x0000000183D6D8C0-0x0000000183D6D980
		[DebuggerHidden] // 0x000000018989FB90-0x000000018989FBD0
		// [XID] // 0x000000018989FB90-0x000000018989FBD0
		private IEnumerator CheckShowHint1() => default; // 0x0000000183D6DB60-0x0000000183D6DC70
		// [XID] // 0x00000001898AA3D0-0x00000001898AA3F0
		public void ShowHintUnmeet(bool show, bool needCoroutine = false /* Metadata: 0x00B0FE40 */) {} // 0x0000000183D6ED70-0x0000000183D6EF60
		// [XID] // 0x00000001898B1DB0-0x00000001898B1DD0
		public void ShowHintMeet(bool show) {} // 0x0000000183D6EBE0-0x0000000183D6ED70
	}
}
