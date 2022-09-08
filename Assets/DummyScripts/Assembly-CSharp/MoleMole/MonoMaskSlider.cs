/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	public class MonoMaskSlider : MonoBehaviour // TypeDefIndex: 30828
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform maskRect; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform fillRect; // 0x20
		public AnimStyle animStlye; // 0x28
		public Animation LoopAnim; // 0x30
		public FlashLoopAnimName LoopAnimName; // 0x38
		public bool LoopAnimEnable; // 0x3C
		public Animation SpreadAnim; // 0x40
		public bool SpreadAnimEnable; // 0x48
		public Action<MonoMaskSlider> OnCustomAnimUpdate; // 0x50
		private MonoMaskSlider _refSlider; // 0x58
		public Slider.Direction dirction; // 0x60
		public float sliderGrowTime; // 0x64
		public float minValue; // 0x68
		public float value; // 0x6C
		public float maxValue; // 0x70
		private const string FLASH_SPREAD_ANIM_NAME = "EnergyPluginFlashSpread"; // Metadata: 0x00B11606
		public Action<float, float> onValueChanged; // 0x78
		private bool _isLoopPlaying; // 0x80
		private bool _isSpreadPlaying; // 0x81
	
		// Nested types
		public enum AnimStyle // TypeDefIndex: 30829
		{
			FullSpreadThenLoop = 0,
			CustomControl = 1
		}
	
		public enum FlashLoopAnimName // TypeDefIndex: 30830
		{
			EnergyPluginFlashLoop = 0,
			ShieldRecoverFlashLoop = 1
		}
	
		// Constructors
		public MonoMaskSlider() {} // 0x0000000184938330-0x00000001849383E0
	
		// Methods
		// [XID] // 0x0000000189859620-0x0000000189859640
		private void Update() {} // 0x0000000184938290-0x0000000184938330
		// [XID] // 0x00000001898607A0-0x00000001898607C0
		private void OnDestroy() {} // 0x0000000184937760-0x0000000184937800
		// [XID] // 0x0000000189867E70-0x0000000189867E90
		public void UpdateValue(float value, float maxValue, float minValue = 0f /* Metadata: 0x00B115FE */) {} // 0x0000000184937FF0-0x0000000184938290
		// [XID] // 0x000000018986F3D0-0x000000018986F3F0
		public void SetRefSlider(MonoMaskSlider refSlider) {} // 0x0000000184937800-0x00000001849378E0
		// [XID] // 0x0000000189876A00-0x0000000189876A20
		public float GetRatio() => default; // 0x0000000184937690-0x0000000184937760
		// [XID] // 0x000000018987E520-0x000000018987E540
		public void StartFlashSpread(float normalizedTime = 0f /* Metadata: 0x00B11602 */) {} // 0x0000000184937BA0-0x0000000184937DA0
		// [XID] // 0x00000001898858D0-0x00000001898858F0
		public void StartFlashLoop() {} // 0x00000001849378E0-0x0000000184937BA0
		// [XID] // 0x000000018988CBC0-0x000000018988CBE0
		public float GetBlingAnimationNormalizedTime() => default; // 0x0000000184937490-0x0000000184937690
		// [XID] // 0x00000001898942D0-0x00000001898942F0
		public void StopFlashSpreadAnim() {} // 0x0000000184937EF0-0x0000000184937FF0
		// [XID] // 0x000000018989B840-0x000000018989B860
		public void StopFlashLoopAnim() {} // 0x0000000184937DA0-0x0000000184937EF0
		// [XID] // 0x00000001898A2D30-0x00000001898A2D50
		private void ResetStopAnim(Animation animation, string clipName) {} // 0x0000000184937180-0x00000001849372F0
		// [XID] // 0x00000001898AA250-0x00000001898AA270
		private void UpdateAnim() {} // 0x00000001849372F0-0x0000000184937490
	}
}
