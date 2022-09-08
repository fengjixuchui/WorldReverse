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
	public class MonoElementReaction : MonoSpriteProxy // TypeDefIndex: 31211
	{
		// Fields
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public ElementIcon[] elementIcons; // 0x20
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public ElementOverride elementOverride; // 0x28
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public ElementReaction elementReaction; // 0x38
	
		// Properties
		public bool show { /* [XID] */ /* 0x00000001899BC020-0x00000001899BC040 */ set {} } // 0x0000000183CA2230-0x0000000183CA2320
	
		// Nested types
		[Serializable]
		public struct ElementIcon // TypeDefIndex: 31212
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private CanvasGroup _canvas; // 0x00
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private bool _light; // 0x08
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private Image[] _images; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private Animation _animation; // 0x18
			private const string SHOW_BUFF_ICON_ANI_NAME = "Ani_ElementReaction_Legacy"; // Metadata: 0x00B12063
	
			// Properties
			public bool isPlaying { /* [XID] */ /* 0x00000001899F7C80-0x00000001899F7CA0 */ get => default; } // 0x0000000183C92940-0x0000000183C92A70 
			public float playingTime { /* [XID] */ /* 0x00000001899FF2B0-0x00000001899FF2D0 */ get => default; } // 0x0000000183C92A70-0x0000000183C92C60 
	
			// Methods
			// [XID] // 0x00000001899E1650-0x00000001899E1670
			private void SetAlpha(float alpha) {} // 0x0000000183C923D0-0x0000000183C92590
			// [XID] // 0x00000001899E8D00-0x00000001899E8D20
			private void SetImage(Sprite icon) {} // 0x0000000183C92700-0x0000000183C92820
			// [XID] // 0x00000001899F0680-0x00000001899F06A0
			private void ShowAnim(bool play, float time = 0f /* Metadata: 0x00B1205B */) {} // 0x0000000183C92590-0x0000000183C92700
			// [XID] // 0x0000000189A06AF0-0x0000000189A06B10
			public void Tick(float iconRemainTime, float reactionRemainTime) {} // 0x0000000183C92290-0x0000000183C923D0
			// [XID] // 0x0000000189A0E1C0-0x0000000189A0E1E0
			private void SetCanvas(bool active) {} // 0x0000000183C91E70-0x0000000183C91F50
			// [XID] // 0x0000000189A15780-0x0000000189A157A0
			public void SetIcon(Sprite sprite, bool playAnim, float playAnimTime = 0f /* Metadata: 0x00B1205F */) {} // 0x0000000183C92820-0x0000000183C92940
			// [XID] // 0x0000000189A1CC60-0x0000000189A1CC80
			public void UnsetIcon() {} // 0x0000000183C91F50-0x0000000183C92290
		}
	
		[Serializable]
		public struct ElementOverride // TypeDefIndex: 31213
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private CanvasGroup _canvas; // 0x00
			private bool _canvasShow; // 0x08
	
			// Properties
			public Transform transform { /* [XID] */ /* 0x0000000189A3A530-0x0000000189A3A550 */ get => default; } // 0x0000000183C92FC0-0x0000000183C93090 
	
			// Methods
			// [XID] // 0x0000000189A2B630-0x0000000189A2B650
			public void CheckState() {} // 0x0000000183C92EB0-0x0000000183C92FC0
			// [XID] // 0x0000000189A32C80-0x0000000189A32CA0
			private void SetAlpha(float alpha) {} // 0x0000000183C92DD0-0x0000000183C92EB0
			// [XID] // 0x0000000189A41E20-0x0000000189A41E40
			public void Tick(bool showOverrideIcon, float reactionRemainTime) {} // 0x0000000183C92C60-0x0000000183C92DD0
		}
	
		[Serializable]
		public struct ElementReaction // TypeDefIndex: 31214
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private Transform _transform; // 0x00
	
			// Properties
			public Transform transform { /* [XID] */ /* 0x0000000189A50D40-0x0000000189A50D60 */ get => default; } // 0x0000000183C93090-0x0000000183C931F0 
		}
	
		// Constructors
		public MonoElementReaction() {} // 0x0000000183CA21D0-0x0000000183CA2230
	
		// Methods
		// [XID] // 0x00000001899B4950-0x00000001899B4970
		public void InitState() {} // 0x0000000183CA2130-0x0000000183CA21D0
	}
}
